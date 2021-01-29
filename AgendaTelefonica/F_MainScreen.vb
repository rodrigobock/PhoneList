Public Class F_MainScreen
    Private Sub F_MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim addContact = F_AddContact
        addContact.ShowDialog()
    End Sub
End Class