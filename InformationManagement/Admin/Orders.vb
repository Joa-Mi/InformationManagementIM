Public Class Orders

    Private Sub AddOrdersBtn_Click(sender As Object, e As EventArgs) Handles AddOrdersBtn.Click
        With FormAddOrder
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With
    End Sub
End Class