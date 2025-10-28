Imports System.Drawing.Drawing2D

Public Class FormAddUser


    Private Sub FormAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(15)
    End Sub

    Private Sub RoundCorners(radius As Integer)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        Dim d As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseAllFigures()

        Me.Region = New Region(path)
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserbtn.Click

    End Sub
End Class