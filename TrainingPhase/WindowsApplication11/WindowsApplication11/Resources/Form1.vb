Public Class frmObject




    Private Sub btnStartVLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartVLC.Click
        AxWindowsMediaPlayer1.URL = "e:\object.wmv"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub btnPauseVLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPauseVLC.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

End Class