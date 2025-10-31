Public Class FormEditUser
    Private Sub FormEditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Me.DialogResult = DialogResult.OK
        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

End Class