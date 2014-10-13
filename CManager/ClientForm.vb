Imports System.Data.OleDb

Public Class ClientForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")
    Dim tBoxs(9) As TextBox
    Dim i As Integer
    Public dIndex As Integer
    Public cIndex As Integer

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientTableAdapter1.Fill(Me.SourceDBDataSet.client)
        myConn.Open()
        For i As Integer = 1 To 8
            tBoxs(i) = CType(Controls("tBox" + i.ToString), TextBox)
        Next i
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [client] WHERE (c_name = '" + tBox2.Text + "')", myConn)
        Dim myDataTable As New DataTable
        If tBox2.Text = "" Then
            MsgBox("업체명을 입력해주세요.")
        Else
            myAdapter.Fill(myDataTable)
            If myDataTable.Rows.Count > 0 Then
                Try
                    tBox3.Text = myDataTable.Rows(0).Item("c_headname")
                    tBox4.Text = myDataTable.Rows(0).Item("c_address")
                    tBox5.Text = myDataTable.Rows(0).Item("c_type")
                    tBox6.Text = myDataTable.Rows(0).Item("c_jongmok")
                    tBox7.Text = myDataTable.Rows(0).Item("c_idnum")
                    tBox8.Text = myDataTable.Rows(0).Item("c_comment")
                    Button_Modify.Enabled = True
                    Button_Delete.Enabled = True
                Catch ex As InvalidCastException
                End Try
            Else
                MsgBox("해당 업체가 없습니다.")
                For i As Integer = 1 To 8
                    tBoxs(i).Text = ""
                Next
            End If
        End If
    End Sub

    Private Sub EnableTextBoxes()
        For i As Integer = 1 To 8
            tBoxs(i).Enabled = True
        Next
    End Sub

    Private Sub DisableTextBoxes()
        For i As Integer = 1 To 8
            tBoxs(i).Enabled = False
        Next
        tBox2.Enabled = True
    End Sub

    Private Sub ClearTextBoxes()
        For i As Integer = 1 To 8
            tBoxs(i).Text = ""
        Next
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Try
            EnableTextBoxes()
            ClearTextBoxes()
            lblStat.Text = "add"
            tBox1.Enabled = False
        Catch er As NullReferenceException
        End Try
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ClearTextBoxes()
        DisableTextBoxes()
    End Sub

    Private Sub Button_Modify_Click(sender As Object, e As EventArgs) Handles Button_Modify.Click
        EnableTextBoxes()
        lblStat.Text = "mod"
        tBox1.Enabled = False
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Try
            If lblStat.Text = "add" Then
                Dim cmdText = "INSERT INTO [client] (c_name, c_headname, c_address, c_type, c_jongmok, c_idnum, c_comment) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@cname", tBox2.Text)
                myCmd.Parameters.AddWithValue("@head", tBox3.Text)
                myCmd.Parameters.AddWithValue("@addr", tBox4.Text)
                myCmd.Parameters.AddWithValue("@type", tBox5.Text)
                myCmd.Parameters.AddWithValue("@jongmok", tBox6.Text)
                myCmd.Parameters.AddWithValue("@idnum", tBox7.Text)
                myCmd.Parameters.AddWithValue("@comment", tBox8.Text)
                myCmd.ExecuteNonQuery()
                ClearTextBoxes()
                DisableTextBoxes()
                lblStat.Text = ""
            End If
            If lblStat.Text = "mod" Then
                Dim cmdText = "UPDATE [client] SET c_name = ?, c_headname = ?, c_address = ?, c_type = ?, c_jongmok = ?, c_idnum = ?, c_comment = ? WHERE (key = ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@cname", tBox2.Text)
                myCmd.Parameters.AddWithValue("@head", tBox3.Text)
                myCmd.Parameters.AddWithValue("@addr", tBox4.Text)
                myCmd.Parameters.AddWithValue("@type", tBox5.Text)
                myCmd.Parameters.AddWithValue("@jongmok", tBox6.Text)
                myCmd.Parameters.AddWithValue("@idnum", tBox7.Text)
                myCmd.Parameters.AddWithValue("@comment", tBox8.Text)
                myCmd.Parameters.AddWithValue("@key", tBox1.Text)
                myCmd.ExecuteNonQuery()
                ClearTextBoxes()
                DisableTextBoxes()
                lblStat.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If MessageBox.Show("정말 이 데이터를 삭제하시겠습니까?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("취소되었습니다.")
            Exit Sub
        Else
            Dim cmdText = "DELETE FROM [client] WHERE (c_name = '" + tBox2.Text + "')"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
            MsgBox("삭제되었습니다.")
            ClearTextBoxes()
        End If
        dgv_cliList.Sort(dgv_cliList.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Button_GridView_Click(sender As Object, e As EventArgs) Handles Button_GridView.Click
        Me.ClientTableAdapter1.Fill(Me.SourceDBDataSet.client)
    End Sub

    Private Sub ClientFrom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub

    Public Sub dgv_cliList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_cliList.CellClick
        dgv_cliList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        cIndex = e.RowIndex
        Try
            For i As Integer = 1 To 8
                tBoxs(i).Text = dgv_cliList.Item(i - 1, e.RowIndex).Value.ToString
            Next
            Button_Modify.Enabled = True
            Button_Delete.Enabled = True
            refreshDeal()
        Catch ee As Exception

        End Try
    End Sub

    Private Sub dgv_dealList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_dealList.CellClick
        dgv_dealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dIndex = e.RowIndex
    End Sub

    Private Sub btn_dealMod_Click(sender As Object, e As EventArgs) Handles btn_dealMod.Click
        DealMod.Show()
    End Sub

    Private Sub btn_dealDel_Click(sender As Object, e As EventArgs) Handles btn_dealDel.Click
        Dim response = MsgBox("거래번호 ''" + dgv_dealList.Item(0, dIndex).Value.ToString + "''의 Data를 삭제합니다.", MsgBoxStyle.Exclamation, vbOKCancel)
        If response = MsgBoxResult.Ok Then
            Dim cmdText = "DELETE FROM [deal] WHERE (deal_id = " + dgv_dealList.Item(0, dIndex).Value.ToString + ")"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
            MsgBox("삭제되었습니다.")
            refreshDeal()
        End If
    End Sub

    Public Sub refreshDeal()
        Dim Adp As New OleDbDataAdapter("SELECT deal_id, d_date, d_user, d_tons, d_qty, d_cost FROM deal WHERE (deal.d_client) = """ + dgv_cliList.Item(1, cIndex).Value + """ ORDER BY deal_id ASC", myConn)
        Dim Table As New DataTable
        Adp.Fill(Table)
        dgv_dealList.DataSource = Table
    End Sub
End Class