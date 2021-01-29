Public Class F_Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim main = F_MainScreen
        main.ShowDialog()
    End Sub

    Private Sub ll_createAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_createAccount.LinkClicked
        Dim addAccount = F_CreateAccount
        addAccount.ShowDialog()
    End Sub
End Class
