Imports System.Data.OleDb

Public Class CodeMod
    Dim flag As Integer = 0

    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub CodeMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.tonData' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.TonDataTableAdapter.Fill(Me.SourceDBDataSet.tonData)
        myConn.Open()
    End Sub

    Private Sub cBoxCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxCode.SelectedIndexChanged
        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [tonData] WHERE (code = '" + cBoxCode.Text + "')", myConn)
        Dim myDataTable As New DataTable
        myAdapter.Fill(myDataTable)
        If myDataTable.Rows.Count > 0 Then
            tBoxTons.Text = myDataTable.Rows(0).Item("ton")
            tBoxCost.Text = myDataTable.Rows(0).Item("cost")
        Else
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cBoxCode.DropDownStyle = ComboBoxStyle.DropDown
        flag = 0
        btnOK.Visible = True
        btnCancel.Visible = True
        cBoxCode.Text = ""
        tBoxCost.Text = ""
        tBoxTons.Text = ""
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        flag = 1
        btnOK.Visible = True
        btnCancel.Visible = True
    End Sub

    Private Sub CodeMod_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cBoxCode.Text = "" Or tBoxCost.Text = "" Or tBoxTons.Text = "" Then
            MessageBox.Show("입력 내용을 확인해주세요.")
        Else
            If flag = 0 Then
                Dim cmdText = "INSERT INTO [tonData] (code, ton, cost) VALUES (?, ?, ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@code", cBoxCode.Text)
                myCmd.Parameters.AddWithValue("@ton", tBoxTons.Text)
                myCmd.Parameters.AddWithValue("@cost", tBoxCost.Text)
                myCmd.ExecuteNonQuery()
                cBoxCode.DropDownStyle = ComboBoxStyle.DropDownList
            ElseIf flag = 1 Then
                Dim cmdText = "UPDATE [tonData] SET ton = ?, cost = ? WHERE (code = ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@code", cBoxCode.Text)
                myCmd.Parameters.AddWithValue("@ton", tBoxTons.Text)
                myCmd.Parameters.AddWithValue("@cost", tBoxCost.Text)
                myCmd.ExecuteNonQuery()
            End If

            MessageBox.Show("입력이 완료되었습니다.")
            btnOK.Visible = False
            btnCancel.Visible = False
            cBoxCode.Text = ""
            tBoxCost.Text = ""
            tBoxTons.Text = ""
            Me.TonDataTableAdapter.Fill(Me.SourceDBDataSet.tonData)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnOK.Visible = False
        btnCancel.Visible = False
        cBoxCode.Text = "a"
    End Sub
End Class