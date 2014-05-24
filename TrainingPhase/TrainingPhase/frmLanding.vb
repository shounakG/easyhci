'Imports ClassLibrary1
Public Class frmLanding

    Private Sub frmLanding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '       MsgBox("sum is: " + a.showmsg(3, 4).ToString)
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Dim frmNext As New frmStepChkCamera
        With frmNext
            .ShowInTaskbar = False
            .ShowIcon = False
            .Show()
        End With
    End Sub
End Class
