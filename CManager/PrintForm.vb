Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class PrintForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")
    Dim loadClicked As Boolean = False
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim Month As String = dtp_print.Value.Month.ToString
        Dim Year As String = dtp_print.Value.Year.ToString
        Dim YM As String
        If Month < 10 Then
            Month = "0" & Month
        End If
        YM = Year & "-" & Month
        If (rBtn_user.Checked) Then
            Dim Adp As New OleDbDataAdapter("SELECT d_date, d_tons, d_qty, d_cost FROM deal WHERE (deal.d_client)=""" + cBox_client.Text + """ AND ((deal.d_date) Like """ & YM & "%"") AND ((deal.d_user)=""" + cBox_user.Text + """)", myConn)
            Dim Table As New DataTable
            Adp.Fill(Table)
            DataGridView_view.DataSource = Table
            loadClicked = True
        ElseIf (rBtn_client.Checked) Then
            Dim Adp As New OleDbDataAdapter("SELECT d_user, d_date, d_cost, d_tons, d_qty FROM deal WHERE (deal.d_client) = """ + cBox_client.Text + """ AND ((deal.d_date) Like """ & YM & "%"")", myConn)
            Dim Table As New DataTable
            Adp.Fill(Table)
            DataGridView_view.DataSource = Table
            loadClicked = True
        Else
            MsgBox("업체/작업자 구분을 선택해주세요")
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If loadClicked = True Then
            Dim ExcelApp As Excel.Application
            Dim WorkB As Excel.Workbook
            Dim WorkS As Excel.Worksheet

            Dim i As Integer
            Dim j As Integer

            ExcelApp = New Excel.Application
            ExcelApp.Visible = False
            WorkB = ExcelApp.Workbooks.Open(My.Computer.FileSystem.CurrentDirectory & "\PrintForm.xls")
            WorkS = ExcelApp.Sheets("input_se")

            Dim UserAdapter As New OleDbDataAdapter("SELECT * FROM [user] WHERE [u_name] = '" + cBox_user.Text + "'", myConn)
            Dim UserDataTable As New DataTable
            UserAdapter.Fill(UserDataTable)
            WorkS.Cells(5, 3).Value = cBox_user.Text
            WorkS.Cells(9, 5).Value = UserDataTable.Rows(0).Item("u_jongmok")
            WorkS.Cells(7, 3).Value = UserDataTable.Rows(0).Item("u_headname")
            WorkS.Cells(6, 3).Value = UserDataTable.Rows(0).Item("u_idnum")
            WorkS.Cells(8, 3).Value = UserDataTable.Rows(0).Item("u_address")
            WorkS.Cells(9, 3).Value = UserDataTable.Rows(0).Item("u_type")


            Dim CliAdapter As New OleDbDataAdapter("SELECT * FROM [client] WHERE [c_name] = '" + cBox_client.Text + "'", myConn)
            Dim CliDataTable As New DataTable
            CliAdapter.Fill(CliDataTable)
            WorkS.Cells(5, 8).Value = cBox_client.Text
            WorkS.Cells(6, 8).Value = CliDataTable.Rows(0).Item("c_idnum")
            WorkS.Cells(7, 8).Value = CliDataTable.Rows(0).Item("c_headname")
            WorkS.Cells(8, 8).Value = CliDataTable.Rows(0).Item("c_address")
            WorkS.Cells(9, 8).Value = CliDataTable.Rows(0).Item("c_type")
            WorkS.Cells(8, 10).Value = CliDataTable.Rows(0).Item("c_comment")
            WorkS.Cells(9, 10).Value = CliDataTable.Rows(0).Item("c_jongmok")
            WorkS.Cells(11, 8).Value = Date.Today
            WorkS.Cells(11, 9).Value = Date.Today
            WorkS.Cells(11, 10).Value = Date.Today
            WorkS.Cells(13, 2).Value = "지게차 사용료"

            WorkS = ExcelApp.Sheets("input_gm")

            For i = 0 To DataGridView_view.RowCount - 2
                For j = 0 To DataGridView_view.ColumnCount - 1
                    WorkS.Cells(i + 19, j + 6) = DataGridView_view(j, i).Value.ToString()
                    WorkS.Cells(i + 19, 3) = "지게차 사용료"
                Next
            Next
            Try

                ExcelApp.Sheets("output_se").printout()
                ExcelApp.Sheets("output_gm").printout()
            Catch Exception As Exception

            End Try
            WorkB.Close()
        Else
            MsgBox("먼저 데이터를 로드해주세요.")
        End If

    End Sub

    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.user' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.client' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.ClientTableAdapter.Fill(Me.SourceDBDataSet.client)
        dtp_print.Format = DateTimePickerFormat.Custom
        dtp_print.CustomFormat = "yyyy-MM"
    End Sub

    Private Sub rBtn_user_CheckedChanged(sender As Object, e As EventArgs) Handles rBtn_user.CheckedChanged
        cBox_user.Enabled = True
        btn_print.Enabled = True
    End Sub

    Private Sub rBtn_client_CheckedChanged(sender As Object, e As EventArgs) Handles rBtn_client.CheckedChanged
        cBox_user.Enabled = False
        btn_print.Enabled = False

    End Sub
End Class