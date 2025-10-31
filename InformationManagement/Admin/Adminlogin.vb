Public Class Adminlogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' You can leave this empty or remove it
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Optional: Add logic if needed
    End Sub

    Private Sub Back1_Click(sender As Object, e As EventArgs) Handles Back1.Click
        ' Show the Login form and match the same window size/state
        Login.WindowState = Me.WindowState
        Login.Size = Me.Size
        Login.Location = Me.Location
        Login.Show()

        ' Hide the Admin login form
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Optional: Add logic if needed
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Optional: Add logic if needed
    End Sub

    Private Sub Adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Match the Login form’s window state, size, and position
        Me.WindowState = Login.WindowState
        Me.Size = Login.Size
        Me.Location = Login.Location
    End Sub

    Private Sub adminlog_Click(sender As Object, e As EventArgs) Handles adminlog.Click
        Dim dashboard As New AdminDashboard()
        dashboard.StartPosition = FormStartPosition.CenterScreen
        dashboard.WindowState = FormWindowState.Maximized
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
