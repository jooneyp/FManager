Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class PrintForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim Month As String = DTP.Value.Month.ToString
        Dim Year As String = DTP.Value.Year.ToString
        Dim YM As String
        If Month < 10 Then
            Month = "0" & Month
        End If
        YM = Year & "-" & Month

        If (rBtnUser.Checked) Then

            Dim Adp As New OleDbDataAdapter("SELECT d_date, d_tons, d_qty, d_cost FROM deal WHERE (deal.d_client)=""" + cBoxClient.Text + """ AND ((deal.d_date) Like """ & YM & "%"") AND ((deal.d_user)=""" + CBoxUser.Text + """)", myConn)
            Dim Table As New DataTable
            Adp.Fill(Table)
            DataGridView1.DataSource = Table

        ElseIf (rBtnClient.Checked) Then

            Dim Adp As New OleDbDataAdapter("SELECT d_user, d_date, d_cost, d_tons, d_qty FROM deal WHERE (deal.d_client) = """ + cBoxClient.Text + """ AND ((deal.d_date) Like """ & YM & "%"")", myConn)
            Dim Table As New DataTable
            Adp.Fill(Table)
            DataGridView1.DataSource = Table
            DataGridView1.Sort(DataGridView1.Sort, System.ComponentModel.ListSortDirection.Ascending)
        Else
            MsgBox("업체/작업자 구분을 선택해주세요")
        End If



    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim ExcelApp As Excel.Application
        Dim WorkB As Excel.Workbook
        Dim WorkS As Excel.Worksheet

        Dim i As Integer
        Dim j As Integer

        ExcelApp = New Excel.Application
        ExcelApp.Visible = True
        WorkB = ExcelApp.Workbooks.Open(My.Computer.FileSystem.CurrentDirectory & "\ExcelForm.xls")
        WorkS = ExcelApp.Sheets("input_se")

        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [client] WHERE [c_name] = '" + cBoxClient.Text + "'", myConn)
        Dim myDataTable As New DataTable
        myAdapter.Fill(myDataTable)

        WorkS.Cells(5, 8).Value = cBoxClient.Text
        WorkS.Cells(6, 8).Value = myDataTable.Rows(0).Item("c_idnum")
        WorkS.Cells(7, 8).Value = myDataTable.Rows(0).Item("c_headname")
        WorkS.Cells(8, 8).Value = myDataTable.Rows(0).Item("c_address")
        WorkS.Cells(9, 8).Value = myDataTable.Rows(0).Item("c_type")
        WorkS.Cells(8, 10).Value = myDataTable.Rows(0).Item("c_comment")
        WorkS.Cells(9, 10).Value = myDataTable.Rows(0).Item("c_jongmok")
        WorkS.Cells(11, 8).Value = Date.Today
        WorkS.Cells(11, 9).Value = Date.Today
        WorkS.Cells(11, 10).Value = Date.Today
        WorkS.Cells(13, 2).Value = "지게차 사용료"

        WorkS = ExcelApp.Sheets("input_gm")

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                WorkS.Cells(i + 19, j + 6) = DataGridView1(j, i).Value.ToString()
                WorkS.Cells(i + 19, 3) = "지게차 사용료"
            Next
        Next

        ExcelApp.Sheets("output_se").printout()
        ExcelApp.Sheets("output_gm").printout()
        WorkB.Close()
    End Sub

    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.user' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.client' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.ClientTableAdapter.Fill(Me.SourceDBDataSet.client)
        DTP.Format = DateTimePickerFormat.Custom
        DTP.CustomFormat = "yyyy-MM"

        UserBindingSource
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnUser.CheckedChanged
        CBoxUser.Enabled = True
        btnPrint.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnClient.CheckedChanged
        CBoxUser.Enabled = False
        btnPrint.Enabled = False

    End Sub
End Class