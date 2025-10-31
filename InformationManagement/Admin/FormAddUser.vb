Imports System.Drawing.Drawing2D

Public Class FormAddUser

    Private Sub FormAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(15)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tb.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                tb.TextAlign = HorizontalAlignment.Left
                tb.Padding = New Padding(0, 8, 0, 0)
                tb.AutoSize = False
                tb.Multiline = True
                tb.Height = 35
            End If
        Next
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

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Validate all required fields
        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show("Please enter full name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If

        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show("Please enter email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If txtPhone.Text.Trim() = "" Then
            MessageBox.Show("Please enter phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        If cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRole.Focus()
            Return
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select a status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus()
            Return
        End If

        Dim dateJoined As String = DateTime.Now.ToString("MMMM dd, yyyy")

        UsersAccounts.UsersAccountData.Rows.Add(
        txtFullName.Text.Trim(),
        txtEmail.Text.Trim(),
        txtPhone.Text.Trim(),
        cmbRole.SelectedItem.ToString(),
        cmbStatus.SelectedItem.ToString(),
        dateJoined
    )

        txtFullName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        cmbRole.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

        Me.Close()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class