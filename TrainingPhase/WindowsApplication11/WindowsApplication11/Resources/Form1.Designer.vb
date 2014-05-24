<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObject))
        Me.btnStartVLC = New System.Windows.Forms.Button()
        Me.btnPauseVLC = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartVLC
        '
        Me.btnStartVLC.Location = New System.Drawing.Point(44, 295)
        Me.btnStartVLC.Name = "btnStartVLC"
        Me.btnStartVLC.Size = New System.Drawing.Size(75, 23)
        Me.btnStartVLC.TabIndex = 2
        Me.btnStartVLC.Text = "Start"
        Me.btnStartVLC.UseVisualStyleBackColor = True
        '
        'btnPauseVLC
        '
        Me.btnPauseVLC.Location = New System.Drawing.Point(144, 295)
        Me.btnPauseVLC.Name = "btnPauseVLC"
        Me.btnPauseVLC.Size = New System.Drawing.Size(75, 23)
        Me.btnPauseVLC.TabIndex = 3
        Me.btnPauseVLC.Text = "Pause"
        Me.btnPauseVLC.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(251, 295)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(44, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(282, 240)
        Me.AxWindowsMediaPlayer1.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(396, 23)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(276, 520)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'frmObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 593)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPauseVLC)
        Me.Controls.Add(Me.btnStartVLC)
        Me.Name = "frmObject"
        Me.Text = "What's an Object?"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartVLC As System.Windows.Forms.Button
    Friend WithEvents btnPauseVLC As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
