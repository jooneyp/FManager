Imports System.Data.OleDb

Public Class UserForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")
    Dim tBoxs(8) As TextBox
    Dim i As Integer

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [user] WHERE (u_headname = '" + tBox3.Text + "')", myConn)
        Dim myDataTable As New DataTable
        If tBox3.Text = "" Then
            MsgBox("대표자명을 입력해주세요.")
        Else
            myAdapter.Fill(myDataTable)
            If myDataTable.Rows.Count > 0 Then
                Try
                    tBox2.Text = myDataTable.Rows(0).Item("u_name")
                    tBox4.Text = myDataTable.Rows(0).Item("u_address")
                    tBox5.Text = myDataTable.Rows(0).Item("u_type")
                    tBox6.Text = myDataTable.Rows(0).Item("u_jongmok")
                    tBox7.Text = myDataTable.Rows(0).Item("u_idnum")
                    tBox8.Text = myDataTable.Rows(0).Item("u_comment")
                    Button_Modify.Enabled = True
                    Button_Delete.Enabled = True
                Catch ex As InvalidCastException
                End Try
            Else
                MsgBox("해당 대표자가 없습니다.")
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
        tBox3.Enabled = True
    End Sub

    Private Sub ClearTextBoxes()
        For i As Integer = 1 To 8
            tBoxs(i).Text = ""
        Next
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        ClearTextBoxes()
        EnableTextBoxes()
        lblStat.Text = "add"
        tBox1.Enabled = False
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ClearTextBoxes()
        DisableTextBoxes()
    End Sub

    Private Sub Button_Modify_Click(sender As Object, e As EventArgs) Handles Button_Modify.Click
        EnableTextBoxes()
        tBox1.Enabled = False
        lblStat.Text = "mod"
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Try
            If lblStat.Text = "add" Then
                Dim cmdText = "INSERT INTO [user] (u_name, u_headname, u_address, u_type, u_jongmok, u_idnum, u_comment) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@uname", tBox2.Text)
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
                Dim cmdText = "UPDATE [user] SET u_name = ?, u_headname = ?, u_address = ?, u_type = ?, u_jongmok = ?, u_idnum = ?, u_comment = ? WHERE (key = ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@uname", tBox2.Text)
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
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If MessageBox.Show("정말 이 데이터를 삭제하시겠습니까?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("취소되었습니다.")
            Exit Sub
        Else
            Dim cmdText = "DELETE FROM [user] WHERE (key = " + tBox1.Text + ")"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
            MsgBox("삭제되었습니다.")
            ClearTextBoxes()
            Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
        End If
    End Sub

    Private Sub Button_GridView_Click(sender As Object, e As EventArgs) Handles Button_GridView.Click
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'SourceDBDataSet.user' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
        myConn.Open()
        For i As Integer = 1 To 8
            tBoxs(i) = CType(Controls("tBox" + i.ToString), TextBox)
        Next i
        DataGridView.Sort(DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub UserFrom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick

        DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Try
            For i As Integer = 1 To 8
                tBoxs(i).Text = DataGridView.Item(i - 1, e.RowIndex).Value.ToString
            Next
        Catch ee As Exception
        End Try
        Button_Modify.Enabled = True
        Button_Delete.Enabled = True
    End Sub
End Class