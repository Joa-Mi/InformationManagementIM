Public Class MenuItems

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub AddMenuItemsbtn_Click(sender As Object, e As EventArgs) Handles AddMenuItemsbtn.Click
        ' Open the Add New Menu Item form
        With FormAddNewmenuItem
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With
    End Sub
    Private Sub DataGridMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMenu.CellContentClick
        If e.RowIndex >= 0 Then
            ' --- EDIT BUTTON ---
            If e.ColumnIndex = DataGridMenu.Columns("colEdit").Index Then
                Dim selectedRow As DataGridViewRow = DataGridMenu.Rows(e.RowIndex)
                Dim username As String = selectedRow.Cells("Name").Value.ToString()

                Dim editForm As New FormEditMenu()
                ' Pass data to edit form
                editForm.ShowDialog()
            End If

            ' --- DELETE BUTTON ---
            If e.ColumnIndex = DataGridMenu.Columns("colDelete").Index Then
                Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )
                If result = DialogResult.Yes Then
                    DataGridMenu.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub
    ' Helper method for rounded buttons
    Private Sub FillRoundedRectangle(g As Graphics, brush As Brush, rect As Rectangle, radius As Integer)
        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.FillPath(brush, path)
        End Using
    End Sub

End Class
