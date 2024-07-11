Public Class Form1
    Dim redcolor, greencolor, bluecolor, transparent, ptransparent As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'red
        redcolor = 128
        txtR.Text = redcolor
        trbR.Value = redcolor
        'green
        greencolor = 128
        txtG.Text = greencolor
        trbG.Value = greencolor
        'Blue
        bluecolor = 128
        txtB.Text = bluecolor
        trbB.Value = bluecolor
        'transparent
        transparent = 255
        txtT.Text = transparent
        trbT.Value = transparent
        Mixcolor()
    End Sub
    Private Sub trbR_Scroll(sender As Object, e As EventArgs) Handles trbR.Scroll
        redcolor = Val(trbR.Value)
        txtR.Text = redcolor
        Mixcolor()
    End Sub
    Private Sub trbG_Scroll(sender As Object, e As EventArgs) Handles trbG.Scroll
        greencolor = Val(trbG.Value)
        txtG.Text = greencolor
        Mixcolor()
    End Sub
    Private Sub trbB_Scroll(sender As Object, e As EventArgs) Handles trbB.Scroll
        bluecolor = Val(trbB.Value)
        txtB.Text = bluecolor
        Mixcolor()
    End Sub
    Private Sub trbT_Scroll(sender As Object, e As EventArgs) Handles trbT.Scroll
        transparent = Val(trbT.Value)
        txtT.Text = transparent
        Mixcolor()
    End Sub
    Private Sub txtT_TextChanged(sender As Object, e As EventArgs) Handles txtT.TextChanged
        ptransparent = (transparent / 255) * 100
        txtT.Text = ptransparent & ("%")
    End Sub
    Public Function Mixcolor()
        lblmix.BackColor = Color.FromArgb(transparent, redcolor, greencolor, bluecolor)
        If redcolor = 128 Or greencolor >= 128 Or bluecolor >= 128 Then
            lblmix.ForeColor = Color.Black
        Else lblmix.ForeColor = Color.White
        End If
        lblmix.Text = "#" & transparent.ToString("x2") & redcolor.ToString("x2") & greencolor.ToString("x2") & bluecolor.ToString("x2")
    End Function
End Class
