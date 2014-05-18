Public Class MainForm
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

    Private Sub btn_Import_Click(sender As Object, e As EventArgs) Handles btn_Import.Click
        Import.Show()
    End Sub
End Class
