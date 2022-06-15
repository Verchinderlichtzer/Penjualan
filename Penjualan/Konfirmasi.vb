Public Class Konfirmasi
    Private xJudul As String
    Public Property Judul As String
        Get
            Return xJudul
        End Get
        Set(value As String)
            xJudul = value
            LBLTitle.Text = value
        End Set
    End Property

    Private xDeskripsi As String
    Public Property Deskripsi As String
        Get
            Return xDeskripsi
        End Get
        Set(value As String)
            xDeskripsi = value
            TDeskripsi.Text = value
        End Set
    End Property

    Public Sub New(Judulnya As String, Deskripsinya As String, Gambarnya As Integer)
        InitializeComponent()
        Judul = Judulnya
        Deskripsi = Deskripsinya
        If Gambarnya = 0 Then
            PBIcon.Image = ImgQuestion
        ElseIf Gambarnya = 1 Then
            PBIcon.Image = ImgExclamation
        End If
        If Deskripsinya = "--" Then
            T2.Visible = 1
        ElseIf Deskripsinya = "-" Then
            T1.UseSystemPasswordChar = 0
            T1.PasswordChar = ""
        End If
        If Deskripsinya Like "-*" Then
            BTNYa.Text = "Ok"
            BTNTidak.Text = "Batal"
            T1.Visible = 1
            T1.Focus()
        End If
    End Sub

    Private Sub T1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged
        If TDeskripsi.Text = "-" AndAlso Val(T1.Text) > Val(LBLTitle.Text.Substring(LBLTitle.Text.LastIndexOf(" ") + 1)) Then
            T1.Text = LBLTitle.Text.Substring(LBLTitle.Text.LastIndexOf(" ") + 1)
            T1.SelectionStart = T1.Text.Length
        End If
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles T1.KeyPress
        If TDeskripsi.Text = "-" Then
            If T1.SelectionStart = 0 And Asc(e.KeyChar) = 48 Then e.Handled = 1
            Angka(e)
        End If
    End Sub

    Private Sub BTNYa_Click(sender As Object, e As EventArgs) Handles BTNYa.Click
        If TDeskripsi.Text = "--" Then
            QR("SELECT Username FROM TBLUser WHERE Username = '" & UserAktif & "' AND Pw = '" & EncodePassword(UserAktif, T1.Text) & "'")
            If T1.Text = "" Or T2.Text = "" Then
                Pesan("Password kosong", 0)
            ElseIf Not DR.HasRows Then
                Pesan("Password lama salah", 0)
            ElseIf T1.Text = T2.Text Then
                Pesan("Password sama", 0)
            Else
                QN("UPDATE TBLUser SET Pw = '" & EncodePassword(UserAktif, T2.Text) & "' WHERE Username = '" & UserAktif & "'")
                Pesan("Password berhasil diubah", 1)
            End If
        ElseIf TDeskripsi.Text = "-" Then
            HalamanTerpilih = Val(T1.Text)
        End If
        DialogResult = vbYes
    End Sub

    Private Sub BTNTidak_Click(sender As Object, e As EventArgs) Handles BTNTidak.Click
        DialogResult = vbNo
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef Msg As Message, Koentji As Keys) As Boolean
        If Koentji = Keys.Enter Then
            BTNYa.PerformClick()
            Return True
        ElseIf Koentji = Keys.Escape Then
            BTNTidak.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(Msg, Koentji)
    End Function

    Private Sub Konfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Warna = 0 Then
            PanelKonfirmasi.StateCommon.Border.Color1 = Color.FromArgb(254, 55, 83)
            LBLTitle.StateCommon.ShortText.Color1 = Color.FromArgb(127, 27, 41)
            TDeskripsi.StateCommon.Content.Color1 = Color.FromArgb(190, 41, 62)
            BTNYa.OverrideDefault.Back.Color1 = Color.FromArgb(190, 41, 62)
            BTNYa.StateCommon.Back.Color1 = Color.FromArgb(254, 55, 83)
            BTNYa.StateNormal.Back.Color1 = Color.FromArgb(190, 41, 62)
            BTNTidak.OverrideDefault.Back.Color1 = Color.FromArgb(190, 41, 62)
            BTNTidak.StateCommon.Back.Color1 = Color.FromArgb(254, 55, 83)
            BTNTidak.StateNormal.Back.Color1 = Color.FromArgb(190, 41, 62)
        ElseIf Warna = 1 Then
            PanelKonfirmasi.StateCommon.Border.Color1 = Color.FromArgb(255, 209, 37)
            LBLTitle.StateCommon.ShortText.Color1 = Color.FromArgb(127, 104, 18)
            TDeskripsi.StateCommon.Content.Color1 = Color.FromArgb(191, 157, 27)
            BTNYa.OverrideDefault.Back.Color1 = Color.FromArgb(191, 157, 27)
            BTNYa.StateCommon.Back.Color1 = Color.FromArgb(255, 209, 37)
            BTNYa.StateNormal.Back.Color1 = Color.FromArgb(191, 157, 27)
            BTNTidak.OverrideDefault.Back.Color1 = Color.FromArgb(191, 157, 27)
            BTNTidak.StateCommon.Back.Color1 = Color.FromArgb(255, 209, 37)
            BTNTidak.StateNormal.Back.Color1 = Color.FromArgb(191, 157, 27)
        ElseIf Warna = 2 Then
            PanelKonfirmasi.StateCommon.Border.Color1 = Color.FromArgb(108, 203, 120)
            LBLTitle.StateCommon.ShortText.Color1 = Color.FromArgb(54, 101, 60)
            TDeskripsi.StateCommon.Content.Color1 = Color.FromArgb(81, 152, 90)
            BTNYa.OverrideDefault.Back.Color1 = Color.FromArgb(81, 152, 90)
            BTNYa.StateCommon.Back.Color1 = Color.FromArgb(108, 203, 120)
            BTNYa.StateNormal.Back.Color1 = Color.FromArgb(81, 152, 90)
            BTNTidak.OverrideDefault.Back.Color1 = Color.FromArgb(81, 152, 90)
            BTNTidak.StateCommon.Back.Color1 = Color.FromArgb(108, 203, 120)
            BTNTidak.StateNormal.Back.Color1 = Color.FromArgb(81, 152, 90)
        ElseIf Warna = 3 Then
            PanelKonfirmasi.StateCommon.Border.Color1 = Color.FromArgb(1, 175, 193)
            LBLTitle.StateCommon.ShortText.Color1 = Color.FromArgb(0, 87, 96)
            TDeskripsi.StateCommon.Content.Color1 = Color.FromArgb(0, 131, 145)
            BTNYa.OverrideDefault.Back.Color1 = Color.FromArgb(0, 131, 145)
            BTNYa.StateCommon.Back.Color1 = Color.FromArgb(1, 175, 193)
            BTNYa.StateNormal.Back.Color1 = Color.FromArgb(0, 131, 145)
            BTNTidak.OverrideDefault.Back.Color1 = Color.FromArgb(0, 131, 145)
            BTNTidak.StateCommon.Back.Color1 = Color.FromArgb(1, 175, 193)
            BTNTidak.StateNormal.Back.Color1 = Color.FromArgb(0, 131, 145)
        ElseIf Warna = 4 Then
            PanelKonfirmasi.StateCommon.Border.Color1 = Color.FromArgb(212, 123, 232)
            LBLTitle.StateCommon.ShortText.Color1 = Color.FromArgb(106, 61, 116)
            TDeskripsi.StateCommon.Content.Color1 = Color.FromArgb(159, 92, 174)
            BTNYa.OverrideDefault.Back.Color1 = Color.FromArgb(159, 92, 174)
            BTNYa.StateCommon.Back.Color1 = Color.FromArgb(212, 123, 232)
            BTNYa.StateNormal.Back.Color1 = Color.FromArgb(159, 92, 174)
            BTNTidak.OverrideDefault.Back.Color1 = Color.FromArgb(159, 92, 174)
            BTNTidak.StateCommon.Back.Color1 = Color.FromArgb(212, 123, 232)
            BTNTidak.StateNormal.Back.Color1 = Color.FromArgb(159, 92, 174)
        ElseIf Warna = 5 Then
            PanelKonfirmasi.StateCommon.Border.Color1 = Color.FromArgb(191, 146, 113)
            LBLTitle.StateCommon.ShortText.Color1 = Color.FromArgb(95, 73, 56)
            TDeskripsi.StateCommon.Content.Color1 = Color.FromArgb(143, 109, 84)
            BTNYa.OverrideDefault.Back.Color1 = Color.FromArgb(143, 109, 84)
            BTNYa.StateCommon.Back.Color1 = Color.FromArgb(191, 146, 113)
            BTNYa.StateNormal.Back.Color1 = Color.FromArgb(143, 109, 84)
            BTNTidak.OverrideDefault.Back.Color1 = Color.FromArgb(143, 109, 84)
            BTNTidak.StateCommon.Back.Color1 = Color.FromArgb(191, 146, 113)
            BTNTidak.StateNormal.Back.Color1 = Color.FromArgb(143, 109, 84)
        End If
    End Sub
End Class