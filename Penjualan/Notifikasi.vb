Public Class Notifikasi
    Enum AlertTypeEnum
        Gagal
        Berhasil
    End Enum

    Dim x, y As Integer
    Public Sub SetAlert(msg As String, type As AlertTypeEnum)
        Opacity = 0
        StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 30
            fname = "Peringatan " & i.ToString
            Dim f As Notifikasi = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i
                Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5
        Select Case type
            Case AlertTypeEnum.Berhasil
                Notif.Values.Image = ImgBerhasil
                BackColor = Color.ForestGreen
            Case AlertTypeEnum.Gagal
                Notif.Values.Image = ImgGagal
                BackColor = Color.Firebrick
        End Select
        Notif.Text = msg
        TopMost = 1
        ShowIcon = 0
        ShowInTaskbar = 0
        Show()
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Enum ActionEnum
        Wait
        Start
        Close
    End Enum

    Private Action As ActionEnum = ActionEnum.Start

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case Action
            Case ActionEnum.Start
                Timer1.Interval = 1
                Opacity += 0.1
                If x < Location.X Then
                    Left -= 1
                ElseIf Opacity = 1 Then
                    Action = ActionEnum.Wait
                End If
            Case ActionEnum.Wait
                Timer1.Interval = 2500
                Action = ActionEnum.Close
            Case ActionEnum.Close
                Timer1.Interval = 1
                Opacity -= 0.1
                Left -= 3
                If Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub

    Private Sub Notifikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Warna = 0 Then
            Notif.OverrideDefault.Border.Color1 = Color.FromArgb(254, 55, 83)
            Notif.StateCommon.Border.Color1 = Color.FromArgb(254, 55, 83)
            Notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(190, 41, 62)
        ElseIf Warna = 1 Then
            Notif.OverrideDefault.Border.Color1 = Color.FromArgb(255, 209, 37)
            Notif.StateCommon.Border.Color1 = Color.FromArgb(255, 209, 37)
            Notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(191, 157, 27)
        ElseIf Warna = 2 Then
            Notif.OverrideDefault.Border.Color1 = Color.FromArgb(108, 203, 120)
            Notif.StateCommon.Border.Color1 = Color.FromArgb(108, 203, 120)
            Notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(81, 152, 90)
        ElseIf Warna = 3 Then
            Notif.OverrideDefault.Border.Color1 = Color.FromArgb(1, 175, 193)
            Notif.StateCommon.Border.Color1 = Color.FromArgb(1, 175, 193)
            Notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(0, 131, 145)
        ElseIf Warna = 4 Then
            Notif.OverrideDefault.Border.Color1 = Color.FromArgb(212, 123, 232)
            Notif.StateCommon.Border.Color1 = Color.FromArgb(212, 123, 232)
            Notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(159, 92, 174)
        ElseIf Warna = 5 Then
            Notif.OverrideDefault.Border.Color1 = Color.FromArgb(191, 146, 113)
            Notif.StateCommon.Border.Color1 = Color.FromArgb(191, 146, 113)
            Notif.StateCommon.Content.ShortText.Color1 = Color.FromArgb(143, 109, 84)
        End If
    End Sub

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property
End Class