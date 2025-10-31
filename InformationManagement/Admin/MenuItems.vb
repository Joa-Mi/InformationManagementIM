Public Class MenuItems

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub AddMenuItemsbtn_Click(sender As Object, e As EventArgs) Handles AddMenuItemsbtn.Click

        With FormAddNewmenuItem
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With
    End Sub
End Class
