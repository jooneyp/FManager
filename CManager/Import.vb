Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Import

    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        Dim ExcelApp As Excel.Application
        Dim WorkB As Excel.Workbook
        Dim WorkS As Excel.Worksheet
        Dim cmdText As String

        ExcelApp = New Excel.Application
        ExcelApp.Visible = False
        Dim ofd As New OpenFileDialog
        ofd.DefaultExt = "xlsx"
        Try
            If ofd.ShowDialog = DialogResult.OK Then
                WorkB = ExcelApp.Workbooks.Open(ofd.FileName)
            ElseIf ofd.ShowDialog = DialogResult.Abort Then
                lbl_wait.Text = "파일 열기를 취소하셨습니다."
            End If
        Catch err As Exception
        End Try



        Dim sCount As Integer
        Dim cCount As Integer
        Dim cUser As Integer
        Dim index As Integer
        Dim i As Integer
        Dim j As Integer
        Dim commentText As String
        Dim data() As String = {"", "", "", "", "", ""}

        myConn.Open()


        cUser = 0
        cCount = 0
        sCount = 1
        Try
            Do Until sCount = ExcelApp.Worksheets.Count
                lbl_wait.Visible = False
                lbl_prog.Visible = True
                lbl_prog.Text = "작업중입니다.. ( " & sCount & " / " & ExcelApp.Worksheets.Count - 1 & " )"
                index = 2
                WorkS = ExcelApp.Sheets(sCount)
                Do Until WorkS.Cells(index, 5).Value = ""
                    i = 3
                    Do Until WorkS.Cells(index + i, 1).Value = "" Or WorkS.Cells(index + i, 1).Value = "합  계"
                        For j = 3 To 33
                            If WorkS.Cells(index + i, j).Value <> Nothing Then

                                'add client name
                                data(0) = WorkS.Cells(index, 5).Value
                                Console.WriteLine(data(0))
                                'add user name
                                data(1) = WorkS.Cells(index + i, 1).Value
                                Console.WriteLine(data(1))
                                'add date
                                data(2) = ExcelApp.Sheets(1).Cells(2, 36).Value & "-" & WorkS.Cells(index + 2, j).Value
                                Console.WriteLine(data(2))
                                Try
                                    commentText = WorkS.Cells(index + i, j).Comment.Text
                                    'add cost&tons
                                    Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [tonData] WHERE (code = '" + commentText + "')", myConn)
                                    Dim myDataTable As New DataTable
                                    myAdapter.Fill(myDataTable)
                                    If myDataTable.Rows.Count > 0 Then
                                        data(3) = myDataTable.Rows(0).Item("cost")
                                        data(4) = myDataTable.Rows(0).Item("ton")
                                    Else
                                    End If

                                Catch ex As Exception
                                    data(3) = "40000"
                                    data(4) = ""
                                End Try
                                Console.Out.WriteLine(data(3))
                                Console.Out.WriteLine(data(4))
                                'add qty
                                data(5) = WorkS.Cells(index + i, j).Value
                                Console.Out.WriteLine(data(5))
                                'End If

                                cmdText = "INSERT INTO [deal] (d_client, d_user, d_date, d_cost, d_tons, d_qty) VALUES (?, ?, ?, ?, ?, ?)"
                                Dim myCmd = New OleDbCommand(cmdText, myConn)
                                myCmd.Parameters.AddWithValue("@d_client", data(0))
                                myCmd.Parameters.AddWithValue("@d_user", data(1))
                                myCmd.Parameters.AddWithValue("@d_date", data(2))
                                myCmd.Parameters.AddWithValue("@d_cost", data(3))
                                myCmd.Parameters.AddWithValue("@d_tons", data(4))
                                myCmd.Parameters.AddWithValue("@d_qty", data(5))
                                myCmd.ExecuteNonQuery()
                            End If
                        Next
                        cUser += 1
                        i += 1
                    Loop
                    'Next Client
                    Do Until WorkS.Cells(index + i, 1).Value = "총   합   계"
                        i += 1
                    Loop
                    Dim UpdateCmd = "UPDATE [client] SET c_provider = ? WHERE (c_name = ?)"
                    Dim myUpdateCmd = New OleDbCommand(UpdateCmd, myConn)
                    myUpdateCmd.Parameters.AddWithValue("@c_provider", WorkS.Cells(index + i, 36).Value())
                    myUpdateCmd.Parameters.AddWithValue("@c_name", WorkS.Cells(index, 5).Value())
                    myUpdateCmd.ExecuteNonQuery()
                    index += 12
                Loop
                sCount += 1
            Loop

        Catch ex As Exception

        End Try
        myConn.Close()
        lbl_prog.Visible = False
        lbl_complete.Visible = True
    End Sub
End Class