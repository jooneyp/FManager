Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Forklift Manager"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Deal.Click
        DealForm.Show()
    End Sub

    Private Sub Button_UserMod_Click(sender As Object, e As EventArgs) Handles Button_UserMod.Click
        UserForm.Show()
    End Sub

    Private Sub Button_ClientMod_Click(sender As Object, e As EventArgs) Handles Button_ClientMod.Click
        ClientForm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PrintForm.Show()
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click
        Import.Show()
    End Sub
End Class
