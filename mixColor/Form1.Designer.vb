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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.trbB = New System.Windows.Forms.TrackBar()
        Me.trbR = New System.Windows.Forms.TrackBar()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.trbT = New System.Windows.Forms.TrackBar()
        Me.trbG = New System.Windows.Forms.TrackBar()
        Me.lblmix = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(111, 36)
        Me.TrackBar1.MaximumSize = New System.Drawing.Size(0, 255)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(0, 45)
        Me.TrackBar1.TabIndex = 0
        '
        'trbB
        '
        Me.trbB.Location = New System.Drawing.Point(111, 138)
        Me.trbB.Maximum = 255
        Me.trbB.Name = "trbB"
        Me.trbB.Size = New System.Drawing.Size(221, 45)
        Me.trbB.TabIndex = 1
        '
        'trbR
        '
        Me.trbR.Location = New System.Drawing.Point(111, 36)
        Me.trbR.Maximum = 255
        Me.trbR.Name = "trbR"
        Me.trbR.Size = New System.Drawing.Size(221, 45)
        Me.trbR.TabIndex = 2
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblR.ForeColor = System.Drawing.Color.Red
        Me.lblR.Location = New System.Drawing.Point(68, 36)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(39, 20)
        Me.lblR.TabIndex = 3
        Me.lblR.Text = "Red"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblG.ForeColor = System.Drawing.Color.Lime
        Me.lblG.Location = New System.Drawing.Point(53, 87)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(54, 20)
        Me.lblG.TabIndex = 4
        Me.lblG.Text = "Green"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(66, 138)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(41, 20)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "Blue"
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(338, 36)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(100, 20)
        Me.txtR.TabIndex = 6
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(338, 87)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(100, 20)
        Me.txtG.TabIndex = 7
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(338, 138)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 8
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(338, 189)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(100, 20)
        Me.txtT.TabIndex = 11
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblT.ForeColor = System.Drawing.Color.SlateGray
        Me.lblT.Location = New System.Drawing.Point(12, 189)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(95, 20)
        Me.lblT.TabIndex = 10
        Me.lblT.Text = "Transparent"
        '
        'trbT
        '
        Me.trbT.Location = New System.Drawing.Point(111, 189)
        Me.trbT.Maximum = 255
        Me.trbT.Name = "trbT"
        Me.trbT.Size = New System.Drawing.Size(221, 45)
        Me.trbT.TabIndex = 9
        '
        'trbG
        '
        Me.trbG.Location = New System.Drawing.Point(111, 87)
        Me.trbG.Maximum = 255
        Me.trbG.Name = "trbG"
        Me.trbG.Size = New System.Drawing.Size(221, 45)
        Me.trbG.TabIndex = 12
        '
        'lblmix
        '
        Me.lblmix.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblmix.Location = New System.Drawing.Point(489, 36)
        Me.lblmix.Name = "lblmix"
        Me.lblmix.Size = New System.Drawing.Size(212, 198)
        Me.lblmix.TabIndex = 13
        Me.lblmix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 264)
        Me.Controls.Add(Me.lblmix)
        Me.Controls.Add(Me.trbG)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.trbT)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.trbR)
        Me.Controls.Add(Me.trbB)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "Form1"
        Me.Text = "Mixcolor"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents trbB As TrackBar
    Friend WithEvents trbR As TrackBar
    Friend WithEvents lblR As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblB As Label
    Friend WithEvents txtR As TextBox
    Friend WithEvents txtG As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtT As TextBox
    Friend WithEvents lblT As Label
    Friend WithEvents trbT As TrackBar
    Friend WithEvents trbG As TrackBar
    Friend WithEvents lblmix As Label
End Class
