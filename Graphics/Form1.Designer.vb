<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnDrawText = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnDrawCurve = New System.Windows.Forms.Button()
        Me.txtY4Curve = New System.Windows.Forms.TextBox()
        Me.txtX4Curve = New System.Windows.Forms.TextBox()
        Me.txtY3Curve = New System.Windows.Forms.TextBox()
        Me.txtX3Curve = New System.Windows.Forms.TextBox()
        Me.txtY2Curve = New System.Windows.Forms.TextBox()
        Me.txtX2Curve = New System.Windows.Forms.TextBox()
        Me.txtY1Curve = New System.Windows.Forms.TextBox()
        Me.txtX1Curve = New System.Windows.Forms.TextBox()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.btnRectGrad = New System.Windows.Forms.Button()
        Me.btnRectHatch = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnEllipse = New System.Windows.Forms.Button()
        Me.btnFontSelect = New System.Windows.Forms.Button()
        Me.btnColorSelect = New System.Windows.Forms.Button()
        Me.diaColor = New System.Windows.Forms.ColorDialog()
        Me.diaFont = New System.Windows.Forms.FontDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.lblText)
        Me.GroupBox1.Controls.Add(Me.btnDrawText)
        Me.GroupBox1.Controls.Add(Me.txtString)
        Me.GroupBox1.Controls.Add(Me.btnDrawCurve)
        Me.GroupBox1.Controls.Add(Me.txtY4Curve)
        Me.GroupBox1.Controls.Add(Me.txtX4Curve)
        Me.GroupBox1.Controls.Add(Me.txtY3Curve)
        Me.GroupBox1.Controls.Add(Me.txtX3Curve)
        Me.GroupBox1.Controls.Add(Me.txtY2Curve)
        Me.GroupBox1.Controls.Add(Me.txtX2Curve)
        Me.GroupBox1.Controls.Add(Me.txtY1Curve)
        Me.GroupBox1.Controls.Add(Me.txtX1Curve)
        Me.GroupBox1.Controls.Add(Me.txtY2)
        Me.GroupBox1.Controls.Add(Me.txtY1)
        Me.GroupBox1.Controls.Add(Me.txtX2)
        Me.GroupBox1.Controls.Add(Me.txtX1)
        Me.GroupBox1.Controls.Add(Me.btnRectGrad)
        Me.GroupBox1.Controls.Add(Me.btnRectHatch)
        Me.GroupBox1.Controls.Add(Me.btnRectangle)
        Me.GroupBox1.Controls.Add(Me.btnEllipse)
        Me.GroupBox1.Controls.Add(Me.btnFontSelect)
        Me.GroupBox1.Controls.Add(Me.btnColorSelect)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 565)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GDI + Primatives"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(27, 434)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(118, 16)
        Me.lblText.TabIndex = 22
        Me.lblText.Text = "Text To Display"
        '
        'btnDrawText
        '
        Me.btnDrawText.Location = New System.Drawing.Point(8, 481)
        Me.btnDrawText.Name = "btnDrawText"
        Me.btnDrawText.Size = New System.Drawing.Size(151, 23)
        Me.btnDrawText.TabIndex = 21
        Me.btnDrawText.Text = "Draw Text"
        Me.btnDrawText.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(8, 453)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(151, 22)
        Me.txtString.TabIndex = 20
        '
        'btnDrawCurve
        '
        Me.btnDrawCurve.Location = New System.Drawing.Point(8, 379)
        Me.btnDrawCurve.Name = "btnDrawCurve"
        Me.btnDrawCurve.Size = New System.Drawing.Size(151, 23)
        Me.btnDrawCurve.TabIndex = 19
        Me.btnDrawCurve.Text = "DrawCurve"
        Me.btnDrawCurve.UseVisualStyleBackColor = True
        '
        'txtY4Curve
        '
        Me.txtY4Curve.Location = New System.Drawing.Point(129, 351)
        Me.txtY4Curve.Name = "txtY4Curve"
        Me.txtY4Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtY4Curve.TabIndex = 18
        Me.txtY4Curve.Text = "Y4"
        Me.txtY4Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX4Curve
        '
        Me.txtX4Curve.Location = New System.Drawing.Point(88, 351)
        Me.txtX4Curve.Name = "txtX4Curve"
        Me.txtX4Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtX4Curve.TabIndex = 17
        Me.txtX4Curve.Text = "X4"
        Me.txtX4Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY3Curve
        '
        Me.txtY3Curve.Location = New System.Drawing.Point(47, 351)
        Me.txtY3Curve.Name = "txtY3Curve"
        Me.txtY3Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtY3Curve.TabIndex = 16
        Me.txtY3Curve.Text = "Y3"
        Me.txtY3Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX3Curve
        '
        Me.txtX3Curve.Location = New System.Drawing.Point(6, 351)
        Me.txtX3Curve.Name = "txtX3Curve"
        Me.txtX3Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtX3Curve.TabIndex = 15
        Me.txtX3Curve.Text = "X3"
        Me.txtX3Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY2Curve
        '
        Me.txtY2Curve.Location = New System.Drawing.Point(129, 323)
        Me.txtY2Curve.Name = "txtY2Curve"
        Me.txtY2Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtY2Curve.TabIndex = 14
        Me.txtY2Curve.Text = "Y2"
        Me.txtY2Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX2Curve
        '
        Me.txtX2Curve.Location = New System.Drawing.Point(88, 323)
        Me.txtX2Curve.Name = "txtX2Curve"
        Me.txtX2Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtX2Curve.TabIndex = 13
        Me.txtX2Curve.Text = "X2"
        Me.txtX2Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY1Curve
        '
        Me.txtY1Curve.Location = New System.Drawing.Point(47, 323)
        Me.txtY1Curve.Name = "txtY1Curve"
        Me.txtY1Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtY1Curve.TabIndex = 12
        Me.txtY1Curve.Text = "Y1"
        Me.txtY1Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX1Curve
        '
        Me.txtX1Curve.Location = New System.Drawing.Point(6, 323)
        Me.txtX1Curve.Name = "txtX1Curve"
        Me.txtX1Curve.Size = New System.Drawing.Size(35, 22)
        Me.txtX1Curve.TabIndex = 11
        Me.txtX1Curve.Text = "X1"
        Me.txtX1Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY2
        '
        Me.txtY2.Location = New System.Drawing.Point(97, 129)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(48, 22)
        Me.txtY2.TabIndex = 10
        Me.txtY2.Text = "Y2"
        Me.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(97, 101)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(48, 22)
        Me.txtY1.TabIndex = 9
        Me.txtY1.Text = "Y1"
        Me.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(8, 129)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(48, 22)
        Me.txtX2.TabIndex = 8
        Me.txtX2.Text = "X2"
        Me.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(8, 101)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(48, 22)
        Me.txtX1.TabIndex = 7
        Me.txtX1.Text = "X1"
        Me.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRectGrad
        '
        Me.btnRectGrad.Location = New System.Drawing.Point(6, 244)
        Me.btnRectGrad.Name = "btnRectGrad"
        Me.btnRectGrad.Size = New System.Drawing.Size(137, 44)
        Me.btnRectGrad.TabIndex = 6
        Me.btnRectGrad.Text = "Rectangle Gradient"
        Me.btnRectGrad.UseVisualStyleBackColor = True
        '
        'btnRectHatch
        '
        Me.btnRectHatch.Location = New System.Drawing.Point(6, 215)
        Me.btnRectHatch.Name = "btnRectHatch"
        Me.btnRectHatch.Size = New System.Drawing.Size(137, 23)
        Me.btnRectHatch.TabIndex = 5
        Me.btnRectHatch.Text = "Rectangle Hatch"
        Me.btnRectHatch.UseVisualStyleBackColor = True
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(8, 186)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(137, 23)
        Me.btnRectangle.TabIndex = 4
        Me.btnRectangle.Text = "Draw Rectangle"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'btnEllipse
        '
        Me.btnEllipse.Location = New System.Drawing.Point(8, 157)
        Me.btnEllipse.Name = "btnEllipse"
        Me.btnEllipse.Size = New System.Drawing.Size(137, 23)
        Me.btnEllipse.TabIndex = 3
        Me.btnEllipse.Text = "Draw Ellipse"
        Me.btnEllipse.UseVisualStyleBackColor = True
        '
        'btnFontSelect
        '
        Me.btnFontSelect.Location = New System.Drawing.Point(8, 62)
        Me.btnFontSelect.Name = "btnFontSelect"
        Me.btnFontSelect.Size = New System.Drawing.Size(137, 23)
        Me.btnFontSelect.TabIndex = 2
        Me.btnFontSelect.Text = "Select Font"
        Me.btnFontSelect.UseVisualStyleBackColor = True
        '
        'btnColorSelect
        '
        Me.btnColorSelect.Location = New System.Drawing.Point(8, 33)
        Me.btnColorSelect.Name = "btnColorSelect"
        Me.btnColorSelect.Size = New System.Drawing.Size(137, 23)
        Me.btnColorSelect.TabIndex = 1
        Me.btnColorSelect.Text = "Select Color"
        Me.btnColorSelect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 573)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CPT 341 Project 4 - GDI+ Fall 2021"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFontSelect As Button
    Friend WithEvents btnColorSelect As Button
    Friend WithEvents diaColor As ColorDialog
    Friend WithEvents diaFont As FontDialog
    Friend WithEvents btnEllipse As Button
    Friend WithEvents btnRectangle As Button
    Friend WithEvents btnRectGrad As Button
    Friend WithEvents btnRectHatch As Button
    Friend WithEvents btnDrawCurve As Button
    Friend WithEvents txtY4Curve As TextBox
    Friend WithEvents txtX4Curve As TextBox
    Friend WithEvents txtY3Curve As TextBox
    Friend WithEvents txtX3Curve As TextBox
    Friend WithEvents txtY2Curve As TextBox
    Friend WithEvents txtX2Curve As TextBox
    Friend WithEvents txtY1Curve As TextBox
    Friend WithEvents txtX1Curve As TextBox
    Friend WithEvents txtY2 As TextBox
    Friend WithEvents txtY1 As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents btnDrawText As Button
    Friend WithEvents txtString As TextBox
End Class
