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
                tBoxPhone.Text = myDataTable.Rows(0).Item("u_phone")
                tBoxAddr.Text = myDataTable.Rows(0).Item("u_addr")
                tBoxBName.Text = myDataTable.Rows(0).Item("u_bname")
                tBoxBAccount.Text = myDataTable.Rows(0).Item("u_baccount")
                tBoxEtc.Text = myDataTable.Rows(0).Item("u_comment")
            Else
                MsgBox("해당 이름이 없습니다.")
                tBoxName.Text = ""
                tBoxPhone.Text = ""
                tBoxAddr.Text = ""
                tBoxBName.Text = ""
                tBoxBAccount.Text = ""
                tBoxEtc.Text = ""
            End If
        End If
    End Sub

    Private Sub EnableTextBoxes()
        tBoxName.Enabled = True
        tBoxPhone.Enabled = True
        tBoxAddr.Enabled = True
        tBoxBName.Enabled = True
        tBoxBAccount.Enabled = True
        tBoxEtc.Enabled = True
    End Sub

    Private Sub ClearTextBoxes()
        tBoxName.Text = ""
        tBoxPhone.Text = ""
        tBoxAddr.Text = ""
        tBoxBName.Text = ""
        tBoxBAccount.Text = ""
        tBoxEtc.Text = ""
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
                Dim cmdText = "INSERT INTO [user] (u_name, u_phone, u_addr, u_bname, u_baccount, u_comment) VALUES (?, ?, ?, ?, ?, ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)
                myCmd.Parameters.AddWithValue("@name", tBoxName.Text)
                myCmd.Parameters.AddWithValue("@idnum", tBoxPhone.Text)
                myCmd.Parameters.AddWithValue("@head", tBoxAddr.Text)
                myCmd.Parameters.AddWithValue("@addr", tBoxBName.Text)
                myCmd.Parameters.AddWithValue("@type", tBoxBAccount.Text)
                myCmd.Parameters.AddWithValue("@jongmok", tBoxEtc.Text)
                myCmd.ExecuteNonQuery()
                Button_Add.Visible = True
                Button_Modify.Visible = True
                Button_OK.Visible = False
                ClearTextBoxes()
                Button_Clear.Text = "비우기"
            End If
            If lblAOE.Text = "수정모드입니다" Then
                Dim cmdText = "UPDATE [user] SET u_phone = ?, u_addr = ?, u_bname = ?, u_baccount = ?, u_comment = ? WHERE (u_name = ?)"
                Dim myCmd = New OleDbCommand(cmdText, myConn)


                myCmd.Parameters.AddWithValue("@idnum", tBoxPhone.Text)
                myCmd.Parameters.AddWithValue("@addr", tBoxAddr.Text)
                myCmd.Parameters.AddWithValue("@bname", tBoxBName.Text)
                myCmd.Parameters.AddWithValue("@baccount", tBoxBAccount.Text)
                myCmd.Parameters.AddWithValue("@comment", tBoxEtc.Text)
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