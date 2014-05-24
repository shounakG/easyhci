

Imports MiscellaniousAPI
Imports AllExplorerWindowOperations
Public Class frmRG
    Private Sub frmRG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTM.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.openTaskMgr()
    End Sub

    Private Sub btnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculator.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.openCalc()
    End Sub

    Private Sub btnCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmd.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.openCmd()
    End Sub

    Private Sub btnNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepad.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.openNotepad()
    End Sub

    Private Sub btnWebBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWebBrowser.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.openInternet()
    End Sub

    Private Sub btnShutDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutDown.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.shutdown60()
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.restart60()
    End Sub

    Private Sub btnHibernate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHibernate.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.hibernate()
    End Sub

    Private Sub btnSleep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSleep.Click
        Dim cll As New MiscellaniousAPI.clsMisc
        cll.sleep()
    End Sub

    
    Private Sub btnTMperform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTMperform.Click

    End Sub
End Class