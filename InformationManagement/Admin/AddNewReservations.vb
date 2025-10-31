
Public Class PanelCreateReservation

    Private Sub AddNewReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundFormCorners(20)

    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCreateReservation_Click(sender As Object, e As EventArgs) Handles btnCreateReservation.Click

        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please enter full name", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter email address", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub RoundFormCorners(radius As Integer)
        Dim gp As New Drawing.Drawing2D.GraphicsPath()
        gp.AddArc(0, 0, radius, radius, 180, 90)
        gp.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        gp.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        gp.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        gp.CloseFigure()
        Me.Region = New Region(gp)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class