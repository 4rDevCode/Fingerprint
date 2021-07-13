Imports AxZKFPEngXControl

Public Class Form1

    Private ZkFprint As New AxZKFPEngX()
    Private Check As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Controls.Add(ZkFprint)
            InitialAxZkfp()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub InitialAxZkfp()
        Try

            AddHandler ZkFprint.OnImageReceived, AddressOf zkFprint_OnImageReceived
            AddHandler ZkFprint.OnFeatureInfo, AddressOf zkFprint_OnFeatureInfo
            AddHandler ZkFprint.OnEnroll, AddressOf zkFprint_OnEnroll
            AddHandler ZkFprint.OnCapture, AddressOf zkFprint_OnCapture

            If (ZkFprint.InitEngine = 0) Then
                ZkFprint.FPEngineVersion = "9"
                ZkFprint.EnrollCount = 3
                deviceSerial.Text = (deviceSerial.Text + (" " _
                            + (ZkFprint.SensorSN + ("Count: " _
                            + (ZkFprint.SensorCount.ToString + ("Index: " + ZkFprint.SensorIndex.ToString))))))
                ShowHintInfo("Dispositivo conectado correctamente.")
            End If
        Catch ex As Exception
            ShowHintInfo(("Error de inicio del dispositivo, error: " + ex.Message))
        End Try
    End Sub
    Private Sub zkFprint_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent)
        Dim g As Graphics = fpicture.CreateGraphics()
        Dim bmp As New Bitmap(fpicture.Width, fpicture.Height)
        g = Graphics.FromImage(bmp)
        Dim dc As Integer = g.GetHdc().ToInt32()
        ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        fpicture.Image = bmp
    End Sub
    Private Sub zkFprint_OnFeatureInfo(sender As Object, e As IZKFPEngXEvents_OnFeatureInfoEvent)
        Dim strTemp As String = String.Empty
        If ZkFprint.EnrollIndex <> 1 Then
            If ZkFprint.IsRegister Then
                If ZkFprint.EnrollIndex - 1 > 0 Then
                    Dim eindex As Integer = ZkFprint.EnrollIndex - 1
                    strTemp = "Por favor escanee de nuevo ..." & eindex
                End If
            End If
        End If
        ShowHintInfo(strTemp)
    End Sub
    Private Sub zkFprint_OnEnroll(sender As Object, e As IZKFPEngXEvents_OnEnrollEvent)
        If e.actionResult Then
            Dim template As String = ZkFprint.EncodeTemplate1(e.aTemplate)
            txtTemplate.Text = template
            ShowHintInfo("Registro exitoso. Puedes verificarlo ahora.")
            btnRegister.Enabled = False
            btnVerify.Enabled = True
        Else
            ShowHintInfo("Error, por favor regístrate de nuevo.")
        End If
    End Sub
    Private Sub zkFprint_OnCapture(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnCaptureEvent)
        Dim template As String = ZkFprint.EncodeTemplate1(e.aTemplate)
        If ZkFprint.VerFingerFromStr(template, txtTemplate.Text, False, Check) Then
            ShowHintInfo("Verificado.")
        Else
            ShowHintInfo("No Verificado.")
        End If
    End Sub
    Private Sub btnVerify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVerify.Click
        If ZkFprint.IsRegister Then
            ZkFprint.CancelEnroll()
        End If
        'ZkFprint.OnCapture = (ZkFprint.OnCapture + zkFprint_OnCapture())
        ZkFprint.BeginCapture()
        ShowHintInfo("Por favor dar muestra de huellas dactilares.")
    End Sub
    Private Sub ShowHintInfo(s As String)
        prompt.Text = s
    End Sub
    Private Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        ZkFprint.CancelEnroll()
        ZkFprint.EnrollCount = 3
        ZkFprint.BeginEnroll()
        ShowHintInfo("Por favor dar muestra de huellas dactilares.")
    End Sub
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        fpicture.Image = Nothing
    End Sub

End Class
