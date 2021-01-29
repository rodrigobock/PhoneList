Public Class F_MainScreen
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim addContact = F_AddContact
        addContact.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lb_datetime.Text = Now.ToString()
    End Sub
End Class