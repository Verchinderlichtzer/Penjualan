Public Class Login
    Private Declare Sub keybd_event Lib "user32" (bVk As Byte, bScan As Byte, dwFlags As Integer, dwExtraInfo As Integer)

    Private Sub Valid(sender As Object, e As EventArgs) Handles TUsername.TextChanged, TPassword.TextChanged
        If TUsername.Text = "" Or TPassword.Text = "" Then BTNLogin.Enabled = 0 Else BTNLogin.Enabled = 1
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletPrimer)
        If IsKeyLocked(Keys.CapsLock) Then
            Call keybd_event(Keys.CapsLock, &H14, 1, 0)
            Call keybd_event(Keys.CapsLock, &H14, 3, 0)
        End If
        'TUsername.Focus()
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        QR("SELECT Username FROM TBLUser WHERE Username = '" & TUsername.Text & "' AND Pw = '" & EncodePassword(TUsername.Text, TPassword.Text) & "'")
        If Not DR.HasRows Then
            Pesan("Username / Password salah", 0)
        Else
            If CBCookies.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedBinaries", EncodeUsername(TUsername.Text))
            End If
            UserAktif = DR(0)
            MainF.Show()
            MainF.Thumbnail.PerformClick()
            Visible = 0
        End If
    End Sub

    Private Sub BTNBatal_Click(sender As Object, e As EventArgs) Handles BTNBatal.Click
        Application.ExitThread()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef Msg As Message, Koentji As Keys) As Boolean
        If Msg.WParam.ToInt32() = Keys.Enter And BTNLogin.Enabled = True Then
            BTNLogin.PerformClick()
            Return True
        ElseIf Msg.WParam.ToInt32() = Keys.Escape Then
            Application.ExitThread()
            Return True
        End If
        Return MyBase.ProcessCmdKey(Msg, Koentji)
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            'CP.Style = &HA0000
            CP.ExStyle = CP.ExStyle Or &H2000000
            Return CP
        End Get
    End Property

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim Rng As New Random()
        Dim Acak As Integer = Rng.Next(1, 100)
        If Acak <= 20 Then
            PBGambar.Image = My.Resources.Yrden
        ElseIf Acak <= 40 Then
            PBGambar.Image = My.Resources.Quen
        ElseIf Acak <= 60 Then
            PBGambar.Image = My.Resources.Igni
        ElseIf Acak <= 80 Then
            PBGambar.Image = My.Resources.Axii
        ElseIf Acak <= 100 Then
            PBGambar.Image = My.Resources.Aard
        End If
    End Sub
End Class