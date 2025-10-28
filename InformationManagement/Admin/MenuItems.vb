Public Class MenuItems

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub AddMenuItemsbtn_Click(sender As Object, e As EventArgs) Handles AddMenuItemsbtn.Click
        Dim addForm As New FormAddNewmenuItem()

        With addForm
            .FormBorderStyle = FormBorderStyle.None
            .StartPosition = FormStartPosition.CenterParent
            .BackColor = Color.White
            .Size = New Size(520, 450)
        End With

        addForm.ShowDialog(Me)
    End Sub
End Class
