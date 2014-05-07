Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Import
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ExcelApp As Excel.Application
        Dim WorkB As Excel.Workbook
        Dim WorkS As Excel.Worksheet

        ExcelApp = New Excel.Application
        ExcelApp.Visible = False
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            WorkB = ExcelApp.Workbooks.Open(ofd.FileName)
        End If
        Label4.Text = ofd.FileName

        Dim sCount As Integer
        Dim cCount As Integer
        Dim cUser As Integer
        Dim index As Integer
        Dim i As Integer
        Dim j As Integer
        Dim commentText As String
        Dim data As String() = {}

        Dim cmdText = "INSERT INTO [deal] (d_client, d_user, d_date, d_cost, d_tons, d_qty) VALUES (?, ?, ?, ?, ?, ?)"

        cUser = 0
        cCount = 0
        sCount = 1
        Do Until sCount = ExcelApp.Worksheets.Count
            index = 2
            WorkS = ExcelApp.Sheets(sCount)
            Label3.Text = sCount
            Do Until WorkS.Cells(index, 5).Value = ""
                i = 3
                Label1.Text = i
                Do Until WorkS.Cells(index + i, 1).Value = ""
                    For j = 3 To 33
                        'add client name
                        data(0) = WorkS.Cells(index, 5).Value
                        Label2.Text = 0
                        'add user name
                        data(1) = WorkS.Cells(index + i, 1).Value
                        Label2.Text = 1
                        If WorkS.Cells(index + 1, j).Value <> "" Then
                            'add date
                            data(2) = WorkS.Cells(2, 36).Value + "-" + WorkS.Cells(index + 2, j).Value
                            Label2.Text = 2
                            If WorkS.Cells(index + 1, j).Comment.Text <> "" Then
                                commentText = WorkS.Cells(index + 1, j).Comment.Text
                                'add cost&tons
                                If commentText = "a" Then
                                    'data(cUser)(3) = cost
                                    'data(cUser)(4) = tons
                                ElseIf commentText = "b" Then

                                ElseIf commentText = "c" Then

                                End If
                            Else
                                data(3) = "40000"
                                Label2.Text = 3
                                data(4) = "(7t)"
                                Label2.Text = 4
                            End If
                            'add qty
                            data(5) = WorkS.Cells(index + 1, j).Value
                            Label2.Text = 5
                            DataGridView1.Rows.Add(data)
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
        lbl_stat.Text = "데이터베이스 입력 중.."
        For i = 0 To cUser
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.Parameters.AddWithValue("@d_client", data(0))
            myCmd.Parameters.AddWithValue("@d_user", data(1))
            myCmd.Parameters.AddWithValue("@d_date", data(2))
            myCmd.Parameters.AddWithValue("@d_cost", data(3))
            myCmd.Parameters.AddWithValue("@d_tons", data(4))
            myCmd.Parameters.AddWithValue("@d_qty", data(5))
            myCmd.ExecuteNonQuery()
        Next
    End Sub
End Class