Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormAddNewmenuItem
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub FormAddNewmenuItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtItemName.TextBoxBackColor = Color.WhiteSmoke
        txtDescription.TextBoxBackColor = Color.WhiteSmoke
        txtImageUrl.TextBoxBackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse
           String.IsNullOrWhiteSpace(txtDescription.Text) OrElse
           numericPrice.Value <= 0 Then
            MessageBox.Show("Please fill all required fields properly.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Prepare row data (no image)
        Dim row As Object() = {
            Nothing,
            txtItemName.Text,
            txtDescription.Text,
            numericPrice.Value.ToString("0.00"),
            comboCategory.SelectedItem.ToString(),
            comboStatus.SelectedItem.ToString()
        }

        ' Add new row to the DataGridView in MenuItems form
        MenuItems.DataGridMenu.Rows.Add(row)

        MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Close the Add Item form
        Me.Close()
    End Sub


End Class
