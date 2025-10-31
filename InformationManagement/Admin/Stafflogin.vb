Public Class Stafflogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' You can leave this empty or remove it
    End Sub

    Private Sub Back2_Click(sender As Object, e As EventArgs) Handles Back2.Click
        ' Show the Login form and match the same window size/state
        Login.WindowState = Me.WindowState
        Login.Size = Me.Size
        Login.Location = Me.Location
        Login.Show()

        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub Stafflogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Match the Login form’s window when opening
        Me.WindowState = Login.WindowState
        Me.Size = Login.Size
        Me.Location = Login.Location
    End Sub
End Class