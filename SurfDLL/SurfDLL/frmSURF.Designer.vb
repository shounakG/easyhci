<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSURF
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
        Me.components = New System.ComponentModel.Container()
        Me.picSURF = New System.Windows.Forms.PictureBox()
        Me.tmSURF = New System.Windows.Forms.Timer(Me.components)
        Me.lblLooking = New System.Windows.Forms.Label()
        Me.tmStop = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSURF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSURF
        '
        Me.picSURF.Location = New System.Drawing.Point(12, 27)
        Me.picSURF.Name = "picSURF"
        Me.picSURF.Size = New System.Drawing.Size(440, 408)
        Me.picSURF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSURF.TabIndex = 0
        Me.picSURF.TabStop = False
        '
        'tmSURF
        '
        Me.tmSURF.Interval = 10
        '
        'lblLooking
        '
        Me.lblLooking.AutoSize = True
        Me.lblLooking.Location = New System.Drawing.Point(12, 9)
        Me.lblLooking.Name = "lblLooking"
        Me.lblLooking.Size = New System.Drawing.Size(0, 13)
        Me.lblLooking.TabIndex = 1
        '
        'tmStop
        '
        Me.tmStop.Enabled = True
        Me.tmStop.Interval = 3000
        '
        'frmSURF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLooking)
        Me.Controls.Add(Me.picSURF)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSURF"
        Me.Text = "Trying to redetect the object"
        CType(Me.picSURF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picSURF As System.Windows.Forms.PictureBox
    Public WithEvents tmSURF As System.Windows.Forms.Timer
    Friend WithEvents lblLooking As System.Windows.Forms.Label
    Friend WithEvents tmStop As System.Windows.Forms.Timer
End Class
