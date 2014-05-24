<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.pbWelcome = New System.Windows.Forms.PictureBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbWelcome
        '
        Me.pbWelcome.Image = Global.WindowsApplication11.My.Resources.Resources.welcome
        Me.pbWelcome.InitialImage = Global.WindowsApplication11.My.Resources.Resources.welcome
        Me.pbWelcome.Location = New System.Drawing.Point(43, 38)
        Me.pbWelcome.Name = "pbWelcome"
        Me.pbWelcome.Size = New System.Drawing.Size(712, 530)
        Me.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWelcome.TabIndex = 0
        Me.pbWelcome.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(337, 601)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 636)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.pbWelcome)
        Me.Name = "frmWelcome"
        Me.Text = "EasyHCI Welcome"
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbWelcome As System.Windows.Forms.PictureBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button

End Class
