Imports System.Drawing.Drawing2D
'Derek Bradshaw
'11/13/2021
'CPT 341 -  VB.NET NJIT Fall 2021 Semester

Public Class Form1
    'init color as black
    Dim pen As Pen = New Pen(Color.Black, 5)

    'set position inits
    Dim xPosAdd As Integer = 200
    Dim yPosAdd As Integer = 10




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Tool tip stuff
        Dim toolTip1 As New ToolTip()
        Dim toolTip2 As New ToolTip()
        Dim toolTip3 As New ToolTip()
        Dim toolTip4 As New ToolTip()
        Dim toolTip5 As New ToolTip()
        Dim toolTip6 As New ToolTip()
        Dim toolTip7 As New ToolTip()
        Dim toolTip8 As New ToolTip()
        toolTip1.ShowAlways = True
        toolTip2.ShowAlways = True
        toolTip3.ShowAlways = True
        toolTip4.ShowAlways = True
        toolTip5.ShowAlways = True
        toolTip6.ShowAlways = True
        toolTip7.ShowAlways = True
        toolTip8.ShowAlways = True
        toolTip1.SetToolTip(btnColorSelect, "Select a Color to draw with")
        toolTip2.SetToolTip(btnFontSelect, "Select a Font to type with")
        toolTip3.SetToolTip(btnEllipse, "Draws an ellipse with given values")
        toolTip4.SetToolTip(btnRectangle, "Draws an rectangle with given values")
        toolTip5.SetToolTip(btnRectHatch, "Draws an rectangle with a hatch pattern with given values")
        toolTip6.SetToolTip(btnRectGrad, "Draws an rectangle with a gradient pattern with given values")
        toolTip7.SetToolTip(btnDrawCurve, "Draws a belitzer curve with given values")
        toolTip8.SetToolTip(btnDrawText, "Displays given text with chosen color and font")
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Drawing.Graphics = e.Graphics 'Not sure why i have to do it like this, but whatever
    End Sub
    'Dialouge stuff
    '---------------------------------------------------------------------------------------------------------

    Private Sub btnColorSelect_Click(sender As Object, e As EventArgs) Handles btnColorSelect.Click
        diaColor.ShowDialog()
    End Sub

    Private Sub btnFontSelect_Click(sender As Object, e As EventArgs) Handles btnFontSelect.Click
        diaFont.ShowDialog()
    End Sub
    '---------------------------------------------------------------------------------------------------------

    'The following call the approprite function below to draw their shape
    '---------------------------------------------------------------------------------------------------------
    Private Sub btnEllipse_Click(sender As Object, e As EventArgs) Handles btnEllipse.Click
        DrawEllipse()
    End Sub

    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click
        DrawRectangle()
    End Sub

    Private Sub btnRectGrad_Click(sender As Object, e As EventArgs) Handles btnRectGrad.Click
        DrawRectGradient()
    End Sub

    Private Sub btnRectHatch_Click(sender As Object, e As EventArgs) Handles btnRectHatch.Click
        DrawRectHatch()
    End Sub

    Private Sub btnDrawCurve_Click(sender As Object, e As EventArgs) Handles btnDrawCurve.Click
        DrawCurve()
    End Sub

    Private Sub btnDrawText_Click(sender As Object, e As EventArgs) Handles btnDrawText.Click
        DrawText()
    End Sub
    '---------------------------------------------------------------------------------------------------------


    'Draww the Correct shape
    '---------------------------------------------------------------------------------------------------------

    Public Sub DrawEllipse() 'Draws circle
        Dim X1 As Decimal
        Dim X2 As Decimal
        Dim Y1 As Decimal
        Dim Y2 As Decimal
        Try 'getting X and Y 
            X1 = CDec(txtX1.Text) + xPosAdd
            X2 = CDec(txtX2.Text)
            Y1 = CDec(txtY1.Text) + yPosAdd
            Y2 = CDec(txtY2.Text)

            Me.Refresh()
            Dim b As Pen = New Pen(diaColor.Color, 10)
            Using g As Drawing.Graphics = Me.CreateGraphics
                'Draw a Circle 
                g.DrawEllipse(b, X1, Y1, X2, Y2)
            End Using
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal value.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtX1.Clear()
            txtX2.Clear()
            txtY1.Clear()
            txtY2.Clear()
        End Try
    End Sub

    Public Sub DrawRectangle() 'draws empty rectangle
        Dim X1 As Decimal
        Dim X2 As Decimal
        Dim Y1 As Decimal
        Dim Y2 As Decimal
        Try 'getting X and Y 
            X1 = CDec(txtX1.Text) + xPosAdd
            X2 = CDec(txtX2.Text)
            Y1 = CDec(txtY1.Text) + yPosAdd
            Y2 = CDec(txtY2.Text)

            Me.Refresh()
            Dim b As Pen = New Pen(diaColor.Color, 10)
            Using g As Drawing.Graphics = Me.CreateGraphics
                'Draw a Rectangle 
                g.DrawRectangle(b, X1, Y1, X2, Y2)
            End Using
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal value.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtX1.Clear()
            txtX2.Clear()
            txtY1.Clear()
            txtY2.Clear()
        End Try
    End Sub

    Public Sub DrawRectGradient() 'drawn rectangle with gradient to blue
        Dim X1 As Decimal
        Dim X2 As Decimal
        Dim Y1 As Decimal
        Dim Y2 As Decimal
        Try 'getting X and Y for Circle and Rectangle
            X1 = CDec(txtX1.Text) + xPosAdd
            X2 = CDec(txtX2.Text)
            Y1 = CDec(txtY1.Text) + yPosAdd
            Y2 = CDec(txtY2.Text)

            Me.Refresh()
            Dim oRect As New Rectangle(X1, Y1, X2, Y2)
            Dim b As New LinearGradientBrush(oRect, diaColor.Color, Color.Blue,
    LinearGradientMode.ForwardDiagonal)
            Using g As Drawing.Graphics = Me.CreateGraphics

                'Draw a Rectangle 
                g.FillRectangle(b, X1, Y1, X2, Y2)
            End Using
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal value.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtX1.Clear()
            txtX2.Clear()
            txtY1.Clear()
            txtY2.Clear()
        End Try

    End Sub

    Public Sub DrawRectHatch() 'draws rectangle with a hatch pattern
        Dim X1 As Decimal
        Dim X2 As Decimal
        Dim Y1 As Decimal
        Dim Y2 As Decimal
        Try 'getting X and Y
            X1 = CDec(txtX1.Text) + xPosAdd
            X2 = CDec(txtX2.Text)
            Y1 = CDec(txtY1.Text) + yPosAdd
            Y2 = CDec(txtY2.Text)

            Me.Refresh()
            Dim oRect As New Rectangle(X1, Y1, X2, Y2)
            Dim b As New HatchBrush(
             HatchStyle.Weave,
            Color.Black,
            diaColor.Color)
            Using g As Drawing.Graphics = Me.CreateGraphics

                'Draw a Rectangle 
                g.FillRectangle(b, X1, Y1, X2, Y2)
            End Using
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal value.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtX1.Clear()
            txtX2.Clear()
            txtY1.Clear()
            txtY2.Clear()
        End Try
    End Sub

    Public Sub DrawCurve() 'draws belitzer curve
        Dim X1 As Decimal
        Dim X2 As Decimal
        Dim X3 As Decimal
        Dim X4 As Decimal
        Dim Y1 As Decimal
        Dim Y2 As Decimal
        Dim Y3 As Decimal
        Dim Y4 As Decimal
        Try 'getting X and Y 
            X1 = CDec(txtX1Curve.Text)
            X2 = CDec(txtX2Curve.Text)
            X3 = CDec(txtX3Curve.Text)
            X4 = CDec(txtX4Curve.Text)
            Y1 = CDec(txtY1Curve.Text)
            Y2 = CDec(txtY2Curve.Text)
            Y3 = CDec(txtY3Curve.Text)
            Y4 = CDec(txtY4Curve.Text)

            Me.Refresh()
            Dim b As Pen = New Pen(diaColor.Color, 10)
            Using g As Drawing.Graphics = Me.CreateGraphics
                g.SmoothingMode = SmoothingMode.HighQuality
                'Draw a Curve 
                g.DrawBezier(b, X1, Y1, X2, Y2, X3, Y3, X4, Y4)
            End Using
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal value.", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtX1Curve.Clear()
            txtX2Curve.Clear()
            txtX3Curve.Clear()
            txtX4Curve.Clear()
            txtY1Curve.Clear()
            txtY2Curve.Clear()
            txtY3Curve.Clear()
            txtY4Curve.Clear()
        End Try

    End Sub

    Public Sub DrawText() 'displays text


        Me.Refresh()
        Dim b = New SolidBrush(diaColor.Color)

        Using g As Drawing.Graphics = Me.CreateGraphics
            'Draw Text
            g.DrawString(txtString.Text, diaFont.Font, b, xPosAdd, yPosAdd)
        End Using


    End Sub


End Class
