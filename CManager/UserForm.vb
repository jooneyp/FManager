Imports System.Data.OleDb

Public Class UserForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click

        Dim myAdapter As New OleDbDataAdapter("SELECT * FROM [user] WHERE (u_name = '" + tBoxName.Text + "')", myConn)
        Dim myDataTable As New DataTable
        If tBoxName.Text = "" Then
            MsgBox("이름을 입력해주세요.")
        Else
            myAdapter.Fill(myDataTable)
            If myDataTable.Rows.Count > 0 Then
                tBoxIdnum.Text = myDataTable.Rows(0).Item("u_idnum")
                tBoxHeadname.Text = myDataTable.Rows(0).Item("u_headname")
                tBoxAddr.Text = myDataTable.Rows(0).Item("u_address")
                tBoxType.Text = myDataTable.Rows(0).Item("u_type")
                tBoxJongmok.Text = myDataTable.Rows(0).Item("u_jongmok")
                tBoxComment.Text = myDataTable.Rows(0).Item("u_comment")
            Else
                MsgBox("해당 이름이 없습니다.")
                tBoxName.Text = ""
                tBoxHeadname.Text = ""
                tBoxIdnum.Text = ""
                tBoxAddr.Text = ""
                tBoxType.Text = ""
                tBoxJongmok.Text = ""
                tBoxComment.Text = ""
            End If
        End If
    End Sub

    Private Sub EnableTextBoxes()
        tBoxName.Enabled = True
        tBoxIdnum.Enabled = True
        tBoxHeadname.Enabled = True
        tBoxAddr.Enabled = True
        tBoxType.Enabled = True
        tBoxJongmok.Enabled = True
        tBoxComment.Enabled = True
    End Sub

    Private Sub ClearTextBoxes()
        tBoxName.Text = ""
        tBoxIdnum.Text = ""
        tBoxHeadname.Text = ""
        tBoxAddr.Text = ""
        tBoxType.Text = ""
        tBoxJongmok.Text = ""
        tBoxComment.Text = ""
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        lblAOE.Text = "추가모드입니다"
        Button_Clear.Text = "취소"
        ClearTextBoxes()
        Button_Add.Visible = False
        Button_Modify.Visible = False
        Button_OK.Visible = True
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ClearTextBoxes()
        Button_Add.Visible = True
        Button_Modify.Visible = True
        Button_OK.Visible = False
        lblAOE.Text = ""
        Button_Clear.Text = "비우기"
    End Sub

    Private Sub Button_Modify_Click(sender As Object, e As EventArgs) Handles Button_Modify.Click
        lblAOE.Text = "수정모드입니다"
        Button_Add.Visible = False
        Button_Modify.Visible = False
        Button_OK.Visible = True
        Button_Clear.Text = "취소"
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Try
            If lblAOE.Text = "추가모드입니다" Then
                Dim cmdText = "INSERT INTO [user] (u_name, u_idnum, u_headname, u_address, u_type, u_jongmok, u_comment) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@name", tBoxName.Text)
                myCmd.Parameters.AddWithValue("@idnum", tBoxIdnum.Text)
                myCmd.Parameters.AddWithValue("@head", tBoxHeadname.Text)
                myCmd.Parameters.AddWithValue("@addr", tBoxAddr.Text)
                myCmd.Parameters.AddWithValue("@type", tBoxType.Text)
                myCmd.Parameters.AddWithValue("@jongmok", tBoxJongmok.Text)
                myCmd.Parameters.AddWithValue("@comment", tBoxComment.Text)
                myCmd.ExecuteNonQuery()
                Button_Add.Visible = True
                Button_Modify.Visible = True
                Button_OK.Visible = False
                ClearTextBoxes()
                Button_Clear.Text = "비우기"
            End If
            If lblAOE.Text = "수정모드입니다" Then
                Dim cmdText = "UPDATE [user] SET  u_idnum = ?, u_headname = ?, u_address = ?, u_type = ?, u_jongmok = ?, u_comment = ? WHERE (u_name = ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@idnum", tBoxIdnum.Text)
                myCmd.Parameters.AddWithValue("@head", tBoxHeadname.Text)
                myCmd.Parameters.AddWithValue("@addr", tBoxAddr.Text)
                myCmd.Parameters.AddWithValue("@type", tBoxType.Text)
                myCmd.Parameters.AddWithValue("@jongmok", tBoxJongmok.Text)
                myCmd.Parameters.AddWithValue("@comment", tBoxComment.Text)
                myCmd.Parameters.AddWithValue("@name", tBoxName.Text)

                myCmd.ExecuteNonQuery()
                Button_Add.Visible = True
                Button_Modify.Visible = True
                Button_OK.Visible = False
                ClearTextBoxes()
                Button_Clear.Text = "비우기"
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
            Dim cmdText = ("DELETE FROM [user] WHERE u_name = ('" + tBoxName.Text + "')")
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
            MsgBox("삭제되었습니다.")
            ClearTextBoxes()
        End If
    End Sub

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
        myConn.Open()
    End Sub

    Private Sub Button_GridView_Click(sender As Object, e As EventArgs) Handles Button_GridView.Click
        Me.UserTableAdapter.Fill(Me.SourceDBDataSet.user)
    End Sub

    Private Sub UserFrom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub
End Class