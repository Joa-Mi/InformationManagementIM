<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Edit User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Name"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(443, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 27)
        Me.btnClose.TabIndex = 25
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Status"
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.White
        Me.btnUpdateUser.Location = New System.Drawing.Point(12, 407)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(460, 42)
        Me.btnUpdateUser.TabIndex = 30
        Me.btnUpdateUser.Text = "Update User"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(27, 71)
        Me.txtFullName.MinimumSize = New System.Drawing.Size(0, 35)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(440, 35)
        Me.txtFullName.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(27, 143)
        Me.txtEmail.MinimumSize = New System.Drawing.Size(0, 35)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(440, 35)
        Me.txtEmail.TabIndex = 32
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(27, 214)
        Me.txtPhone.MinimumSize = New System.Drawing.Size(0, 35)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(440, 35)
        Me.txtPhone.TabIndex = 33
        '
        'cmbRole
        '
        Me.cmbRole.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRole.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"Staff", "Employee", "Customer"})
        Me.cmbRole.Location = New System.Drawing.Point(27, 290)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(440, 25)
        Me.cmbRole.TabIndex = 34
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active ", "InActive"})
        Me.cmbStatus.Location = New System.Drawing.Point(27, 357)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(428, 25)
        Me.cmbStatus.TabIndex = 35
        '
        'FormEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditUser"
        Me.Text = "FormEditUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents cmbStatus As ComboBox
End Class
