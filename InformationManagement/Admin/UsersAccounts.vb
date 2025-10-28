Imports System.Security.Policy

Public Class UsersAccounts
    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Adduserbtn_Click(sender As Object, e As EventArgs) Handles Adduserbtn.Click
        Dim addForm As New FormAddUser()

        With addForm
            .FormBorderStyle = FormBorderStyle.None
            .StartPosition = FormStartPosition.CenterParent
            .BackColor = Color.White
            .Size = New Size(520, 450)
        End With

        addForm.ShowDialog(Me)
    End Sub




End Class