Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Import

    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For d As Integer = 0 To 1
            Label1.Show()
        Next
        Dim ExcelApp As Excel.Application
        Dim WorkB As Excel.Workbook
        Dim WorkS As Excel.Worksheet
        Dim cmdText As String

        ExcelApp = New Excel.Application
        ExcelApp.Visible = False
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            WorkB = ExcelApp.Workbooks.Open(ofd.FileName)
        ElseIf ofd.ShowDialog = DialogResult.Abort Then
            MessageBox.Show("취소하였습니다.")

        End If

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
        Do Until sCount = ExcelApp.Worksheets.Count
            index = 2
            WorkS = ExcelApp.Sheets(sCount)
            Do Until WorkS.Cells(index, 5).Value = ""
                i = 3
                Do Until WorkS.Cells(index + i, 1).Value = "" Or i > 8
                    For j = 3 To 33
                        If WorkS.Cells(index + i, j).Value <> Nothing Then

                            'add client name
                            data(0) = WorkS.Cells(index, 5).Value
                            Debug.WriteLine(data(0))
                            'add user name
                            data(1) = WorkS.Cells(index + i, 1).Value
                            Debug.WriteLine(data(1))
                            'add date
                            data(2) = ExcelApp.Sheets(1).Cells(2, 36).Value & "-" & WorkS.Cells(index + 2, j).Value
                            Debug.WriteLine(data(2))
                            Try
                                commentText = WorkS.Cells(index + i, j).Comment.Text
                                'add cost&tons
                                Debug.WriteLine(commentText)
                                If commentText = "a" Then
                                    data(3) = "a"
                                    data(4) = "a"
                                ElseIf commentText = "b" Then
                                    data(3) = "b"
                                    data(4) = "b"
                                ElseIf commentText = "c" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "d" Then
                                    data(3) = "b"
                                    data(4) = ""
                                ElseIf commentText = "e" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "f" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "g" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "h" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "i" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "j" Then
                                    data(3) = ""
                                    data(4) = ""
                                ElseIf commentText = "k" Then
                                    data(3) = ""
                                    data(4) = ""
                                End If
                                Debug.WriteLine(data(3))
                                Debug.WriteLine(data(4))
                            Catch ex As Exception
                                data(3) = "40000"
                                Debug.WriteLine(data(3))
                                data(4) = "(7t)"
                                Debug.WriteLine(data(4))
                            End Try
                            'add qty
                            data(5) = WorkS.Cells(index + i, j).Value
                            Debug.WriteLine(data(5))
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

                            Debug.WriteLine("")
                        End If
                    Next
                    cUser += 1
                    i += 1
                Loop
                'Next Client
                index += 12
            Loop
            sCount += 1
        Loop
        myConn.Close()
        Label1.Text = "데이터 입력이 완료되었습니다."
    End Sub
End Class