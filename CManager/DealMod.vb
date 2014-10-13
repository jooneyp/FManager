Imports System.Data.OleDb

Public Class DealMod
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub DealMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn.Open()

        'TODO: 이 코드는 데이터를 'SourceDBDataSet.user' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.tonData' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.TonDataTableAdapter.Fill(Me.SourceDBDataSet.tonData)

        tBox_dealID.Text = ClientForm.dgv_dealList.Item(0, ClientForm.dIndex).Value
        dtp_date.Value = ClientForm.dgv_dealList.Item(1, ClientForm.dIndex).Value
        cBox_user.Text = ClientForm.dgv_dealList.Item(2, ClientForm.dIndex).Value
        cBox_tons.Text = ClientForm.dgv_dealList.Item(3, ClientForm.dIndex).Value
        tBox_qty.Text = ClientForm.dgv_dealList.Item(4, ClientForm.dIndex).Value

        Multiplier()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmdText = "UPDATE [deal] SET d_date = ?, d_user = ?, d_tons = ?, d_qty = ?, d_cost = ? WHERE (deal_id = ?)"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.Parameters.AddWithValue("@d_date", dtp_date.Text)
            myCmd.Parameters.AddWithValue("@d_user", cBox_user.Text)
            myCmd.Parameters.AddWithValue("@d_tons", cBox_tons.Text)
            myCmd.Parameters.AddWithValue("@d_qty", tBox_qty.Text)
            myCmd.Parameters.AddWithValue("@d_cost", lbl_cost.Text)
            myCmd.Parameters.AddWithValue("@deal_id", tBox_dealID.Text)
            myCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("DB 처리 중 오류가 발생하였습니다.")
        End Try
        myConn.Close()
        ClientForm.refreshDeal()
        Me.Close()
    End Sub

    Private Sub tBox_qty_TextChanged(sender As Object, e As EventArgs) Handles tBox_qty.TextChanged
        Multiplier()
    End Sub

    Private Sub cBox_tons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBox_tons.SelectedIndexChanged
        Multiplier()
    End Sub

    Private Sub Multiplier()
        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [tonData] WHERE (ton = '" + cBox_tons.Text + "')", myConn)
        Dim myDataTable As New DataTable
        myAdapter.Fill(myDataTable)
        If myDataTable.Rows.Count > 0 Then
            Try
                lbl_cost.Text = CInt(myDataTable.Rows(0).Item("cost")) * CInt(tBox_qty.Text)
            Catch ex As InvalidCastException
                lbl_cost.Text = "0"
            End Try
        Else
        End If
    End Sub

    Private Sub DealMod_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub
End Class