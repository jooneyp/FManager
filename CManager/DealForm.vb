Imports System.Data.OleDb

Public Class DealForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cmdText = "INSERT INTO [deal] (d_client, d_user, d_date, d_cost, d_tons, d_qty) VALUES (?, ?, ?, ?, ?, ?)"
        Dim myCmd = New OleDbCommand(cmdText, myConn)
        myCmd.Parameters.AddWithValue("@name", cBoxc_name.Text)
        myCmd.Parameters.AddWithValue("@idnum", cBoxu_name.Text)
        myCmd.Parameters.AddWithValue("@head", DateTimePicker1.Text)
        myCmd.Parameters.AddWithValue("@addr", tBoxCost.Text)
        myCmd.Parameters.AddWithValue("@type", cBoxTons.Text)
        myCmd.Parameters.AddWithValue("@jongmok", tBoxQty.Text)
        myCmd.ExecuteNonQuery()

        lblFCostR.Text = (tBoxCost.Text * tBoxQty.Text)
        lblDutyR.Text = (lblFCostR.Text * 0.1)
        lblFCostR.Visible = True
        lblDutyR.Visible = True

        MessageBox.Show("입력되었습니다.", "확인", MessageBoxButtons.OK)
    End Sub

    Private Sub DealForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'DBDataSet.tonData' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.TonDataTableAdapter.Fill(Me.DBDataSet.tonData)
        Me.UserTableAdapter.Fill(Me.DBDataSet.user)
        Me.ClientTableAdapter.Fill(Me.DBDataSet.client)
        myConn.Open()
    End Sub

    Private Sub DealFrom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub

    Private Sub cBoxTons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxTons.SelectedIndexChanged
        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [tonData] WHERE (ton = '" + cBoxTons.Text + "')", myConn)
        Dim myDataTable As New DataTable
        myAdapter.Fill(myDataTable)
        If myDataTable.Rows.Count > 0 Then
            tBoxCost.Text = myDataTable.Rows(0).Item("cost")
        Else
        End If
    End Sub
End Class