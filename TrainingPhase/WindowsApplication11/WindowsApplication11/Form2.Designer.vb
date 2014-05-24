<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnObject = New System.Windows.Forms.Button()
        Me.btnGesture = New System.Windows.Forms.Button()
        Me.btnRegisterGestures = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnObject
        '
        Me.btnObject.Location = New System.Drawing.Point(338, 207)
        Me.btnObject.Name = "btnObject"
        Me.btnObject.Size = New System.Drawing.Size(241, 23)
        Me.btnObject.TabIndex = 0
        Me.btnObject.Text = "Whats an object?"
        Me.btnObject.UseVisualStyleBackColor = True
        '
        'btnGesture
        '
        Me.btnGesture.Location = New System.Drawing.Point(338, 274)
        Me.btnGesture.Name = "btnGesture"
        Me.btnGesture.Size = New System.Drawing.Size(241, 23)
        Me.btnGesture.TabIndex = 1
        Me.btnGesture.Text = "How to perform a gesture?"
        Me.btnGesture.UseVisualStyleBackColor = True
        '
        'btnRegisterGestures
        '
        Me.btnRegisterGestures.Location = New System.Drawing.Point(338, 338)
        Me.btnRegisterGestures.Name = "btnRegisterGestures"
        Me.btnRegisterGestures.Size = New System.Drawing.Size(241, 23)
        Me.btnRegisterGestures.TabIndex = 2
        Me.btnRegisterGestures.Text = "Register Gestures"
        Me.btnRegisterGestures.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 664)
        Me.Controls.Add(Me.btnRegisterGestures)
        Me.Controls.Add(Me.btnGesture)
        Me.Controls.Add(Me.btnObject)
        Me.Name = "frmMain"
        Me.Text = "EasyHCI Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnObject As System.Windows.Forms.Button
    Friend WithEvents btnGesture As System.Windows.Forms.Button
    Friend WithEvents btnRegisterGestures As System.Windows.Forms.Button
End Class
