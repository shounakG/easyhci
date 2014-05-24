Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure
Imports Emgu.CV.Features2D
Imports System.Drawing
Imports System.Math
Imports System.Runtime.InteropServices

<ComVisible(True)> Public Class frmSURF

    Dim camCapture As New Capture
    Dim startTracking As Boolean
    Dim tgtImage As Image(Of Gray, Byte)
    Dim actualImage As Image(Of Gray, Byte)
    Dim resImage As Image(Of Bgr, Byte)
    Dim sumAngle As Double
    Dim angle1, angle2, angle3, angle4 As Double
    Dim slp1, slp2, slp3, slp4 As Double
    Dim temp1, temp2, temp3, temp4 As Double 'For slope calculations

    Public imgFile As String = ""
    Public P2, P4 As Point
    Public arrImgPoints() As Integer = {-1, -1, -1, -1}

    Private Sub frmSURF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgtImage = New Image(Of Gray, Byte)(imgFile)
        startTracking = True
        actualImage = camCapture.RetrieveGrayFrame
        AddHandler Me.FormClosed, AddressOf getPoints
        tmSURF.Start()
    End Sub

    Private Sub tmSURF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmSURF.Tick
        Try
            actualImage = camCapture.RetrieveGrayFrame

            If startTracking = True Then

            End If

            Dim CPUsurfDz As SURFDetector = New SURFDetector(500, False)        'less the number, more the feature points
            Dim homography As HomographyMatrix = Nothing
            Dim modelkeypoints As VectorOfKeyPoint          'keypoints in the model image(set image)
            Dim observedkeypoints As VectorOfKeyPoint       'keypoints in the realtime capture
            Dim indices As Matrix(Of Integer)
            Dim dist As Matrix(Of Single)
            Dim mask As Matrix(Of Byte)

            modelkeypoints = CPUsurfDz.DetectKeyPointsRaw(tgtImage, Nothing)      'detect the keypoints in model image
            Dim modeldescriptors As Matrix(Of Single) =
                    CPUsurfDz.ComputeDescriptorsRaw(tgtImage, Nothing, modelkeypoints)    'compute the descriptors and note the points

            observedkeypoints = CPUsurfDz.DetectKeyPointsRaw(actualImage, Nothing)
            Dim observeddescriptors As Matrix(Of Single) = CPUsurfDz.ComputeDescriptorsRaw(actualImage, Nothing, observedkeypoints)

            'initialize a brute force matcher to match detected and observed keypoints
            Dim matcher As BruteForceMatcher(Of Single) = New BruteForceMatcher(Of Single)(DistanceType.L2)

            matcher.Add(modeldescriptors)       'add parameters for matching

            indices = New Matrix(Of Integer)(observeddescriptors.Rows, 2)
            dist = New Matrix(Of Single)(observeddescriptors.Rows, 2)

            'match using K-nearest match algo
            matcher.KnnMatch(observeddescriptors, indices, dist, 2, Nothing)

            mask = New Matrix(Of Byte)(dist.Rows, 1)
            mask.SetValue(255)

            Features2DToolbox.VoteForUniqueness(dist, 0.8, mask)

            Dim nonzerocount As Integer = CvInvoke.cvCountNonZero(mask)
            If nonzerocount >= 4 Then 'Change to Greater-than-or-equal-to

                'as it is a transformation invariant algo, also vote for size and orientation
                nonzerocount = Features2DToolbox.VoteForSizeAndOrientation(modelkeypoints, observedkeypoints, indices, mask, 1.5, 20)
                If nonzerocount >= 4 Then 'Change to Greater-than-or-equal-to
                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelkeypoints, observedkeypoints, indices, mask, 3)
                End If
            End If

            resImage = Features2DToolbox.DrawMatches(tgtImage, modelkeypoints, actualImage, observedkeypoints, indices, New Bgr(255, 255, 255), New Bgr(255, 255, 255), mask, Features2DToolbox.KeypointDrawType.NOT_DRAW_SINGLE_POINTS)


            sumAngle = 0
            Dim rect As Rectangle = tgtImage.ROI

            Dim P1f As PointF = New PointF(rect.Left, rect.Bottom)
            Dim P2f As PointF = New PointF(rect.Right, rect.Bottom)
            Dim P3f As PointF = New PointF(rect.Right, rect.Top)
            Dim P4f As PointF = New PointF(rect.Left, rect.Top)

            Dim pts() As PointF = {P1f, P2f, P3f, P4f}

            homography.ProjectPoints(pts)

            Dim P1 As Point = New Point(pts(0).X, pts(0).Y)
            P2 = New Point(pts(1).X, pts(1).Y)
            Dim P3 As Point = New Point(pts(2).X, pts(2).Y)
            P4 = New Point(pts(3).X, pts(3).Y)

            Dim pointz() As Point = {P1, P2, P3, P4}
            P1.Y = 480 - P1.Y
            P2.Y = 480 - P2.Y
            P3.Y = 480 - P3.Y
            P4.Y = 480 - P4.Y

            resImage.DrawPolyline(pointz, True, New Bgr(Color.Blue), 3)

            slp1 = ((P2.Y - P1.Y) / (P2.X - P1.X))
            slp2 = ((P3.Y - P2.Y) / (P3.X - P2.X))
            slp3 = ((P4.Y - P3.Y) / (P4.X - P3.X))
            slp4 = ((P1.Y - P4.Y) / (P1.X - P4.X))
            temp1 = Abs((slp1 - slp2) / (1 + (slp1 * slp2)))
            temp2 = Abs((slp2 - slp3) / (1 + (slp2 * slp3)))
            temp3 = Abs((slp3 - slp4) / (1 + (slp3 * slp4)))
            temp4 = Abs((slp4 - slp1) / (1 + (slp4 * slp1)))

            angle1 = Atan(temp1)
            angle1 = angle1 * 57.29577
            angle2 = Atan(temp2)
            angle2 = angle2 * 57.29577
            angle3 = Atan(temp3)
            angle3 = angle3 * 57.29577
            angle4 = Atan(temp4)
            angle4 = angle4 * 57.29577

            sumAngle = angle1 + angle2 + angle3 + angle4
            If sumAngle > 330 And sumAngle < 361 Then
                tmSURF.Stop()
                camCapture.Dispose()
                Me.Close()
            End If
            picSURF.Image = resImage.ToBitmap

        Catch ex As Exception
        End Try

    End Sub

    Public Sub getPoints(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        If sumAngle > 330 And sumAngle < 361 Then
            arrImgPoints(0) = P4.X
            arrImgPoints(1) = P4.Y
            arrImgPoints(2) = P2.X
            arrImgPoints(3) = P2.Y
        End If
    End Sub


    Public Sub New(ByVal imgFile As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.imgFile = imgFile
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub tmStop_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmStop.Tick
        tmSURF.Stop()
        Me.Close()
    End Sub
End Class