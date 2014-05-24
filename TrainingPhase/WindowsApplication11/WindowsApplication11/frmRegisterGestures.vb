Public Class frmRegisterGestures

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        AxWindowsMediaPlayer1.URL = "e:\gesture.wmv"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        frmRG.Show()
    End Sub

    Private Sub frmRegisterGestures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class