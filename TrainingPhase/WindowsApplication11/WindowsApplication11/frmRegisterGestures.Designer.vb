<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterGestures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterGestures))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbHowToPerformAGesture = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHowToPerformAGesture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 86)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(312, 271)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbHowToPerformAGesture
        '
        Me.pbHowToPerformAGesture.Image = Global.WindowsApplication11.My.Resources.Resources.HowToPerformAGesture
        Me.pbHowToPerformAGesture.Location = New System.Drawing.Point(95, 11)
        Me.pbHowToPerformAGesture.Name = "pbHowToPerformAGesture"
        Me.pbHowToPerformAGesture.Size = New System.Drawing.Size(408, 68)
        Me.pbHowToPerformAGesture.TabIndex = 1
        Me.pbHowToPerformAGesture.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(403, 86)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 431)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(40, 396)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(143, 396)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 5
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(250, 396)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(117, 493)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(75, 23)
        Me.btnProceed.TabIndex = 7
        Me.btnProceed.Text = "Continue"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'frmRegisterGestures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 568)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.pbHowToPerformAGesture)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "frmRegisterGestures"
        Me.Text = "Register Gestures"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHowToPerformAGesture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pbHowToPerformAGesture As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnProceed As System.Windows.Forms.Button
End Class
