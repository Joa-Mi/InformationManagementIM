﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservationStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReservationStatus))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 12.0R)
        Dim DataPoint8 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 28.0R)
        Dim DataPoint9 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 5.0R)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pending = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Confirmed = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cancelled = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RoundedPane21 = New InformationManagement.RoundedPane2()
        Me.lblTotalReservations = New System.Windows.Forms.Label()
        Me.RoundedPane22 = New InformationManagement.RoundedPane2()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.RoundedPane23 = New InformationManagement.RoundedPane2()
        Me.lblConfirmed = New System.Windows.Forms.Label()
        Me.RoundedPane24 = New InformationManagement.RoundedPane2()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.RoundedPane25 = New InformationManagement.RoundedPane2()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPane21.SuspendLayout()
        Me.RoundedPane22.SuspendLayout()
        Me.RoundedPane23.SuspendLayout()
        Me.RoundedPane24.SuspendLayout()
        Me.RoundedPane25.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(25, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This Month"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Reservations"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(205, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(27, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Awaiting Confirmation"
        '
        'Pending
        '
        Me.Pending.AutoSize = True
        Me.Pending.BackColor = System.Drawing.Color.Transparent
        Me.Pending.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Pending.Location = New System.Drawing.Point(26, 20)
        Me.Pending.Name = "Pending"
        Me.Pending.Size = New System.Drawing.Size(58, 19)
        Me.Pending.TabIndex = 0
        Me.Pending.Text = "Pending"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(191, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(27, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ready to serve"
        '
        'Confirmed
        '
        Me.Confirmed.AutoSize = True
        Me.Confirmed.BackColor = System.Drawing.Color.Transparent
        Me.Confirmed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Confirmed.Location = New System.Drawing.Point(16, 21)
        Me.Confirmed.Name = "Confirmed"
        Me.Confirmed.Size = New System.Drawing.Size(73, 19)
        Me.Confirmed.TabIndex = 0
        Me.Confirmed.Text = "Confirmed"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(203, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(27, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cancellations"
        '
        'Cancelled
        '
        Me.Cancelled.AutoSize = True
        Me.Cancelled.BackColor = System.Drawing.Color.Transparent
        Me.Cancelled.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Cancelled.Location = New System.Drawing.Point(26, 20)
        Me.Cancelled.Name = "Cancelled"
        Me.Cancelled.Size = New System.Drawing.Size(67, 19)
        Me.Cancelled.TabIndex = 0
        Me.Cancelled.Text = "Cancelled"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(874, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Period :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Daily"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Yearly"})
        Me.ComboBox1.Location = New System.Drawing.Point(955, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'RoundedPane21
        '
        Me.RoundedPane21.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane21.BorderThickness = 1
        Me.RoundedPane21.Controls.Add(Me.lblTotalReservations)
        Me.RoundedPane21.Controls.Add(Me.Label2)
        Me.RoundedPane21.Controls.Add(Me.PictureBox1)
        Me.RoundedPane21.Controls.Add(Me.Label1)
        Me.RoundedPane21.CornerRadius = 15
        Me.RoundedPane21.FillColor = System.Drawing.Color.White
        Me.RoundedPane21.Location = New System.Drawing.Point(32, 64)
        Me.RoundedPane21.Name = "RoundedPane21"
        Me.RoundedPane21.Size = New System.Drawing.Size(246, 141)
        Me.RoundedPane21.TabIndex = 6
        '
        'lblTotalReservations
        '
        Me.lblTotalReservations.AutoSize = True
        Me.lblTotalReservations.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalReservations.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReservations.Location = New System.Drawing.Point(23, 65)
        Me.lblTotalReservations.Name = "lblTotalReservations"
        Me.lblTotalReservations.Size = New System.Drawing.Size(39, 30)
        Me.lblTotalReservations.TabIndex = 3
        Me.lblTotalReservations.Text = "45"
        '
        'RoundedPane22
        '
        Me.RoundedPane22.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane22.BorderThickness = 1
        Me.RoundedPane22.Controls.Add(Me.lblPending)
        Me.RoundedPane22.Controls.Add(Me.PictureBox2)
        Me.RoundedPane22.Controls.Add(Me.Pending)
        Me.RoundedPane22.Controls.Add(Me.Label3)
        Me.RoundedPane22.CornerRadius = 15
        Me.RoundedPane22.FillColor = System.Drawing.Color.White
        Me.RoundedPane22.Location = New System.Drawing.Point(297, 64)
        Me.RoundedPane22.Name = "RoundedPane22"
        Me.RoundedPane22.Size = New System.Drawing.Size(246, 141)
        Me.RoundedPane22.TabIndex = 7
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.BackColor = System.Drawing.Color.Transparent
        Me.lblPending.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.Color.Orange
        Me.lblPending.Location = New System.Drawing.Point(25, 65)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(39, 30)
        Me.lblPending.TabIndex = 4
        Me.lblPending.Text = "12"
        '
        'RoundedPane23
        '
        Me.RoundedPane23.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane23.BorderThickness = 1
        Me.RoundedPane23.Controls.Add(Me.lblConfirmed)
        Me.RoundedPane23.Controls.Add(Me.PictureBox3)
        Me.RoundedPane23.Controls.Add(Me.Label5)
        Me.RoundedPane23.Controls.Add(Me.Confirmed)
        Me.RoundedPane23.CornerRadius = 15
        Me.RoundedPane23.FillColor = System.Drawing.Color.White
        Me.RoundedPane23.Location = New System.Drawing.Point(563, 64)
        Me.RoundedPane23.Name = "RoundedPane23"
        Me.RoundedPane23.Size = New System.Drawing.Size(246, 141)
        Me.RoundedPane23.TabIndex = 8
        '
        'lblConfirmed
        '
        Me.lblConfirmed.AutoSize = True
        Me.lblConfirmed.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmed.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblConfirmed.Location = New System.Drawing.Point(25, 65)
        Me.lblConfirmed.Name = "lblConfirmed"
        Me.lblConfirmed.Size = New System.Drawing.Size(39, 30)
        Me.lblConfirmed.TabIndex = 4
        Me.lblConfirmed.Text = "28"
        '
        'RoundedPane24
        '
        Me.RoundedPane24.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane24.BorderThickness = 1
        Me.RoundedPane24.Controls.Add(Me.lblCancelled)
        Me.RoundedPane24.Controls.Add(Me.PictureBox4)
        Me.RoundedPane24.Controls.Add(Me.Cancelled)
        Me.RoundedPane24.Controls.Add(Me.Label7)
        Me.RoundedPane24.CornerRadius = 15
        Me.RoundedPane24.FillColor = System.Drawing.Color.White
        Me.RoundedPane24.Location = New System.Drawing.Point(830, 64)
        Me.RoundedPane24.Name = "RoundedPane24"
        Me.RoundedPane24.Size = New System.Drawing.Size(246, 141)
        Me.RoundedPane24.TabIndex = 9
        '
        'lblCancelled
        '
        Me.lblCancelled.AutoSize = True
        Me.lblCancelled.BackColor = System.Drawing.Color.Transparent
        Me.lblCancelled.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCancelled.Location = New System.Drawing.Point(25, 65)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(26, 30)
        Me.lblCancelled.TabIndex = 4
        Me.lblCancelled.Text = "5"
        '
        'RoundedPane25
        '
        Me.RoundedPane25.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane25.BorderThickness = 1
        Me.RoundedPane25.Controls.Add(Me.Button1)
        Me.RoundedPane25.Controls.Add(Me.Chart1)
        Me.RoundedPane25.Controls.Add(Me.Label4)
        Me.RoundedPane25.CornerRadius = 15
        Me.RoundedPane25.FillColor = System.Drawing.Color.White
        Me.RoundedPane25.Location = New System.Drawing.Point(32, 228)
        Me.RoundedPane25.Name = "RoundedPane25"
        Me.RoundedPane25.Size = New System.Drawing.Size(1045, 306)
        Me.RoundedPane25.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(918, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "   Export"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(19, 65)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "ReservationStatus"
        DataPoint7.AxisLabel = "Pending"
        DataPoint7.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataPoint8.AxisLabel = "Confirmed"
        DataPoint8.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataPoint9.AxisLabel = "Cancelled"
        DataPoint9.Color = System.Drawing.Color.Red
        Series3.Points.Add(DataPoint7)
        Series3.Points.Add(DataPoint8)
        Series3.Points.Add(DataPoint9)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(1007, 224)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reservation Status Breakdown"
        '
        'FormReservationStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 749)
        Me.Controls.Add(Me.RoundedPane25)
        Me.Controls.Add(Me.RoundedPane24)
        Me.Controls.Add(Me.RoundedPane23)
        Me.Controls.Add(Me.RoundedPane22)
        Me.Controls.Add(Me.RoundedPane21)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.DoubleBuffered = True
        Me.Name = "FormReservationStatus"
        Me.Text = "FormReservationStatus"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPane21.ResumeLayout(False)
        Me.RoundedPane21.PerformLayout()
        Me.RoundedPane22.ResumeLayout(False)
        Me.RoundedPane22.PerformLayout()
        Me.RoundedPane23.ResumeLayout(False)
        Me.RoundedPane23.PerformLayout()
        Me.RoundedPane24.ResumeLayout(False)
        Me.RoundedPane24.PerformLayout()
        Me.RoundedPane25.ResumeLayout(False)
        Me.RoundedPane25.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Pending As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Confirmed As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cancelled As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RoundedPane21 As RoundedPane2
    Friend WithEvents RoundedPane22 As RoundedPane2
    Friend WithEvents RoundedPane23 As RoundedPane2
    Friend WithEvents RoundedPane24 As RoundedPane2
    Friend WithEvents lblTotalReservations As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents lblConfirmed As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents RoundedPane25 As RoundedPane2
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
