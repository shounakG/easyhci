<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStepChkCamera
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
        Me.picCapture = New System.Windows.Forms.PictureBox()
        Me.tmStream = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCapture
        '
        Me.picCapture.Location = New System.Drawing.Point(12, 12)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(383, 405)
        Me.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCapture.TabIndex = 0
        Me.picCapture.TabStop = False
        '
        'tmStream
        '
        Me.tmStream.Interval = 10
        '
        'frmStepChkCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 429)
        Me.Controls.Add(Me.picCapture)
        Me.Name = "frmStepChkCamera"
        Me.Text = "Camera Check"
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCapture As System.Windows.Forms.PictureBox
    Public WithEvents tmStream As System.Windows.Forms.Timer
End Class
