<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stafflogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stafflogin))
        Me.Back2 = New System.Windows.Forms.Button()
        Me.stafflog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoundedPanel1 = New InformationManagement.RoundedPanel()
        Me.RoundedTextBox2 = New InformationManagement.RoundedTextBox()
        Me.RoundedTextBox1 = New InformationManagement.RoundedTextBox()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back2
        '
        Me.Back2.BackColor = System.Drawing.Color.White
        Me.Back2.FlatAppearance.BorderSize = 0
        Me.Back2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back2.ForeColor = System.Drawing.Color.Red
        Me.Back2.Location = New System.Drawing.Point(11, 11)
        Me.Back2.Margin = New System.Windows.Forms.Padding(2)
        Me.Back2.Name = "Back2"
        Me.Back2.Size = New System.Drawing.Size(74, 28)
        Me.Back2.TabIndex = 10
        Me.Back2.Text = "Back"
        Me.Back2.UseVisualStyleBackColor = False
        '
        'stafflog
        '
        Me.stafflog.BackColor = System.Drawing.Color.White
        Me.stafflog.FlatAppearance.BorderSize = 0
        Me.stafflog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stafflog.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stafflog.ForeColor = System.Drawing.Color.Red
        Me.stafflog.Location = New System.Drawing.Point(103, 214)
        Me.stafflog.Margin = New System.Windows.Forms.Padding(2)
        Me.stafflog.Name = "stafflog"
        Me.stafflog.Size = New System.Drawing.Size(98, 33)
        Me.stafflog.TabIndex = 8
        Me.stafflog.Text = "Login"
        Me.stafflog.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(133, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(47, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(47, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password :"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RoundedPanel1.Controls.Add(Me.RoundedTextBox2)
        Me.RoundedPanel1.Controls.Add(Me.RoundedTextBox1)
        Me.RoundedPanel1.Controls.Add(Me.stafflog)
        Me.RoundedPanel1.Controls.Add(Me.Label1)
        Me.RoundedPanel1.Controls.Add(Me.Label2)
        Me.RoundedPanel1.Controls.Add(Me.Label3)
        Me.RoundedPanel1.CornerRadius = 24
        Me.RoundedPanel1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedPanel1.Location = New System.Drawing.Point(169, 43)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(308, 294)
        Me.RoundedPanel1.TabIndex = 12
        '
        'RoundedTextBox2
        '
        Me.RoundedTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.RoundedTextBox2.BorderRadius = 6
        Me.RoundedTextBox2.FocusBorderColor = System.Drawing.Color.Red
        Me.RoundedTextBox2.Location = New System.Drawing.Point(51, 157)
        Me.RoundedTextBox2.MaxLength = 32767
        Me.RoundedTextBox2.MinimumSize = New System.Drawing.Size(50, 20)
        Me.RoundedTextBox2.Multiline = False
        Me.RoundedTextBox2.Name = "RoundedTextBox2"
        Me.RoundedTextBox2.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RoundedTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RoundedTextBox2.Size = New System.Drawing.Size(200, 30)
        Me.RoundedTextBox2.TabIndex = 10
        Me.RoundedTextBox2.TextBoxBackColor = System.Drawing.Color.White
        Me.RoundedTextBox2.TextColor = System.Drawing.Color.Black
        Me.RoundedTextBox2.TextFont = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RoundedTextBox1
        '
        Me.RoundedTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedTextBox1.BorderRadius = 6
        Me.RoundedTextBox1.FocusBorderColor = System.Drawing.Color.Red
        Me.RoundedTextBox1.Location = New System.Drawing.Point(51, 85)
        Me.RoundedTextBox1.MaxLength = 32767
        Me.RoundedTextBox1.MinimumSize = New System.Drawing.Size(50, 20)
        Me.RoundedTextBox1.Multiline = False
        Me.RoundedTextBox1.Name = "RoundedTextBox1"
        Me.RoundedTextBox1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RoundedTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RoundedTextBox1.Size = New System.Drawing.Size(200, 30)
        Me.RoundedTextBox1.TabIndex = 9
        Me.RoundedTextBox1.TextBoxBackColor = System.Drawing.Color.White
        Me.RoundedTextBox1.TextColor = System.Drawing.Color.Black
        Me.RoundedTextBox1.TextFont = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Stafflogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 366)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.Controls.Add(Me.Back2)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Stafflogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stafflogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Back2 As Button
    Friend WithEvents stafflog As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedTextBox2 As RoundedTextBox
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
End Class
