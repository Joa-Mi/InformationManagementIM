Imports System.Security.Policy

Public Class UsersAccounts
    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Adduserbtn_Click(sender As Object, e As EventArgs) Handles Adduserbtn.Click
        With FormAddUser
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With

    End Sub




End Class