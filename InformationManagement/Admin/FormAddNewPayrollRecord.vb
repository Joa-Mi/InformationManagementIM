Public Class FormAddNewPayrollRecord
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub FormAddNewPayrollRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedTextBox1.TextBoxBackColor = Color.WhiteSmoke
    End Sub
End Class