Imports System.Data.OleDb

Public Class MainForm

    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")
    Dim cmdText As String

    Private Sub btn_deal_Click(sender As Object, e As EventArgs) Handles btn_deal.Click
        DealForm.Show()
    End Sub

    Private Sub btn_userMod_Click(sender As Object, e As EventArgs) Handles btn_userMod.Click
        UserForm.Show()
    End Sub

    Private Sub btn_clientMod_Click(sender As Object, e As EventArgs) Handles btn_clientMod.Click
        ClientForm.Show()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintForm.Show()
    End Sub

    Private Sub btn_dealMod_Click(sender As Object, e As EventArgs)
        DealMod.Show()
    End Sub

    Private Sub 파일ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 파일ToolStripMenuItem.Click
        Import.Show()
    End Sub

    Private Sub 코드관리ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 코드관리ToolStripMenuItem.Click
        CodeMod.Show()
    End Sub

    Private Sub 사용자초기화ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 사용자초기화ToolStripMenuItem.Click
        myConn.Open()
        Dim result = MessageBox.Show("사용자 정보를 초기화합니다. 계속하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If result = DialogResult.OK Then
            cmdText = "DELETE FROM user"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
        End If
        myConn.Close()
    End Sub

    Private Sub 업체목록초기화ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 업체목록초기화ToolStripMenuItem.Click
        myConn.Open()
        Dim result = MessageBox.Show("업체 정보를 초기화합니다. 계속하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If result = DialogResult.OK Then
            cmdText = "DELETE FROM [client]"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
        End If
        myConn.Close()
    End Sub

    Private Sub 거래내역초기화ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 거래내역초기화ToolStripMenuItem1.Click
        myConn.Open()
        Dim result = MessageBox.Show("거래 내역을 초기화합니다. 계속하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If result = DialogResult.OK Then
            cmdText = "DELETE FROM deal"
            Dim myCmd = New OleDbCommand(cmdText, myConn)
            myCmd.ExecuteNonQuery()
        End If
        myConn.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
