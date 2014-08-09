Imports System.Data.OleDb

Public Class CodeMod
    Dim codeBoxes(19) As TextBox
    Dim tonBoxes(19) As TextBox
    Dim costBoxes(19) As TextBox

    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub CodeMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 1 To 20
            codeBoxes(i - 1) = CType(Controls("code" + i.ToString), TextBox)
            tonBoxes(i - 1) = CType(Controls("tons" + i.ToString), TextBox)
            costBoxes(i - 1) = CType(Controls("cost" + i.ToString), TextBox)
        Next

        Me.TonDataTableAdapter.Fill(Me.SourceDBDataSet.tonData)
        myConn.Open()
        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [tonData] ORDER BY code", myConn)
        Dim myDataTable As New DataTable
        myAdapter.Fill(myDataTable)
        Try
            If myDataTable.Rows.Count > 0 Then
                For i = 0 To 19
                    tonBoxes(i).Text = myDataTable.Rows(i).Item("ton")
                    costBoxes(i).Text = myDataTable.Rows(i).Item("cost")
                Next
            End If
        Catch exception As IndexOutOfRangeException
        Catch exception As InvalidCastException
        End Try

    End Sub

    Private Sub CodeMod_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim cmdText
        Dim myCmd
        For i As Integer = 0 To 19
            cmdText = "UPDATE [tonData] SET ton = ?, cost = ? WHERE (code = ?)"
            myCmd = New OleDbCommand(cmdText, myConn)

            myCmd.Parameters.AddWithValue("@ton", tonBoxes(i).Text)
            myCmd.Parameters.AddWithValue("@cost", costBoxes(i).Text)
            myCmd.Parameters.AddWithValue("@code", codeBoxes(i).Text)

            myCmd.ExecuteNonQuery()
        Next
        MessageBox.Show("업데이트 완료.", "DB Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        myConn.Close()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class