﻿Imports System.Drawing.Drawing2D

Public Class Reports

    ' === Load Form into Panel1 ===
    Private Sub LoadFormIntoPanel(childForm As Form)
        Panel1.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === FLOWLAYOUTPANEL SETTINGS ===
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.WrapContents = False
        FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        FlowLayoutPanel1.Padding = New Padding(8)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.BackColor = Color.FromArgb(240, 240, 240)
        FlowLayoutPanel1.Height = 50
        FlowLayoutPanel1.Top = 80   'Adjust below your label
        FlowLayoutPanel1.Left = 20
        FlowLayoutPanel1.Width = Me.ClientSize.Width - 320
        FlowLayoutPanel1.Height = 70

        FlowLayoutPanel1.AutoSize = False

        ' === APPLY ROUNDED CORNERS TO FLOWLAYOUTPANEL ===
        ApplyRoundedCorners(FlowLayoutPanel1, 35)

        ' === MOVE EXISTING BUTTONS TO FLOWLAYOUTPANEL ===
        Dim toMove As New List(Of Control)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Parent Is Me Then
                toMove.Add(ctrl)
            End If
        Next

        For Each ctrl As Control In toMove
            FlowLayoutPanel1.Controls.Add(ctrl)
        Next

        ' Bring FlowLayoutPanel forward so buttons are visible
        FlowLayoutPanel1.BringToFront()

        ' === LOAD DEFAULT PAGE ===
        LoadFormIntoPanel(New FormSales())
        HighlightActiveButton(btnSales)
    End Sub

    ' === APPLY ROUNDED CORNERS TO CONTROL ===
    Private Sub ApplyRoundedCorners(ctrl As Control, radius As Integer)
        Dim gp As New GraphicsPath()
        gp.AddArc(0, 0, radius, radius, 180, 90)
        gp.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        gp.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        gp.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)
        gp.CloseFigure()
        ctrl.Region = New Region(gp)
    End Sub

    ' === BUTTON CLICKS ===
    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles btnSales.Click, btnOrders.Click, btnPayroll.Click, btnCatering.Click, btnStatus.Click,
                btnDineIn.Click, btnTakeout.Click, btnCustomerHistory.Click, btnEmployeeAttendance.Click, btnProductsPerformance.Click

        Dim clickedBtn As Button = CType(sender, Button)
        HighlightActiveButton(CType(sender, Button))

        Select Case clickedBtn.Name
            Case "btnSales" : LoadFormIntoPanel(New FormSales())
            Case "btnOrders" : LoadFormIntoPanel(New FormOrders())
            Case "btnPayroll" : LoadFormIntoPanel(New FormPayroll())
            Case "btnCatering" : LoadFormIntoPanel(New FormCateringReservations())
            Case "btnStatus" : LoadFormIntoPanel(New FormReservationStatus())
            Case "btnDineIn" : LoadFormIntoPanel(New FormDineInOrders())
            Case "btnTakeout" : LoadFormIntoPanel(New FormTakeOutOrders())
            Case "btnCustomerHistory" : LoadFormIntoPanel(New FormCustomerHistory())
            Case "btnEmployeeAttendance" : LoadFormIntoPanel(New FormEmployeeAttendance())
            Case "btnProductsPerformance" : LoadFormIntoPanel(New FormProductPerformance())
        End Select
    End Sub

    ' === HIGHLIGHT ACTIVE BUTTON WITH PILL SHAPE ===
    Private Sub HighlightActiveButton(activeBtn As Button)
        ' Reset all buttons first
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.BackColor = Color.FromArgb(240, 240, 240) ' Light gray default
                btn.ForeColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = btn.BackColor
                btn.Region = Nothing
            End If
        Next

        ' Apply white color to the active (clicked) button
        activeBtn.BackColor = Color.White
        activeBtn.ForeColor = Color.Black
        activeBtn.FlatAppearance.MouseOverBackColor = Color.White

        ' Create pill-shaped rounded corners (fully rounded ends)
        Dim radius As Integer = activeBtn.Height ' Use height as radius for pill shape
        Dim gp As New GraphicsPath()

        ' Left semi-circle
        gp.AddArc(0, 0, radius, radius, 90, 180)
        ' Right semi-circle
        gp.AddArc(activeBtn.Width - radius, 0, radius, radius, 270, 180)

        gp.CloseFigure()
        activeBtn.Region = New Region(gp)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class