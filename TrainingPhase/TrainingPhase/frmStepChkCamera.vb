Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure

Public Class frmStepChkCamera
    Dim camCapture As Capture = New Capture
    Dim picImage As Image(Of Bgr, Byte)

    Private Sub frmStepChkCamera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmStream.Start()
    End Sub

    Private Sub tmStream_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmStream.Tick
        picImage = camCapture.RetrieveBgrFrame
        picCapture.Image = picImage.ToBitmap
    End Sub
End Class