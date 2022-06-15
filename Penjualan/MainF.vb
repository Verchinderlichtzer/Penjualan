Public Class MainF

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletPrimer)
    End Sub

    Private Sub FormTerpilih(ChildForm As Form, Gambar As Bitmap)
        LBLTitle.Text = ChildForm.Text
        LBLTitle.Values.Image = Gambar
        ChildForm.TopLevel = False
        ChildForm.Dock = DockStyle.Fill
        PanelForm.Controls.Clear()
        PanelForm.Controls.Add(ChildForm)
        PanelForm.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
    End Sub

    Private Sub Pilihan(sender As Object, e As EventArgs) Handles Thumbnail.Click, BTNUser.Click, BTNBarang.Click, BTNPelanggan.Click, BTNTransaksi.Click, BTNCatatan.Click, BTNLaporan.Click
        'HakAkses()
        Dim BTNMenu() As Object = {Thumbnail, BTNUser, BTNBarang, BTNPelanggan, BTNTransaksi, BTNCatatan, BTNLaporan} 'Semua BTNMenu
        For Each x In BTNMenu
            If x IsNot sender Then x.Checked = 0 Else x.Checked = 1
        Next
        If sender Is Thumbnail Then
            FormTerpilih(New Dashboard, My.Resources.title_dashboard)
        ElseIf sender Is BTNUser Then
            FormTerpilih(New User, My.Resources.title_user)
        ElseIf sender Is BTNBarang Then
            FormTerpilih(New Barang, My.Resources.title_barang)
        ElseIf sender Is BTNPelanggan Then
            FormTerpilih(New Pelanggan, My.Resources.title_pelanggan)
        ElseIf sender Is BTNTransaksi Then
            FormTerpilih(New Transaksi, My.Resources.title_transaksi)
        ElseIf sender Is BTNCatatan Then
            FormTerpilih(New Catatan, My.Resources.title_catatan)
        ElseIf sender Is BTNLaporan Then
            FormTerpilih(New Laporan, My.Resources.title_laporan)
        End If
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedBinaries", "None")
        'PanelForm.Controls.Clear()
        Visible = 0
        Login.Show()
        Login.TUsername.Clear()
        Login.TPassword.Clear()
        Login.CBCookies.Checked = 0
        Login.TUsername.Focus()
    End Sub

    Private Sub MainF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            'CP.Style = &HA0000
            CP.ExStyle = CP.ExStyle Or &H2000000
            Return CP
        End Get
    End Property


    Private Sub MainF_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Thumbnail.PerformClick()
        Dim Kolom = 0
        If UserAktif.ToString.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then BTNUser.Enabled = 1 Else BTNUser.Enabled = 0
        QR("SELECT RBarang, RPelanggan, Transaksi, EBarang, EPelanggan FROM TBLUser WHERE Username = '" & UserAktif & "'")
        Hak = {DR(0), DR(1), DR(2), DR(3), DR(4)}
        Dim BTNMenuAkses() As Object = {BTNBarang, BTNPelanggan, BTNTransaksi} 'Semua BTNMenu, kecuali User dan Kategori Lain
        For Each BTN In BTNMenuAkses
            If Hak(Kolom) = 0 Then
                BTN.Enabled = 0
                'BTN.Checked = 0
            Else
                BTN.Enabled = 1
            End If
            Kolom += 1
        Next
    End Sub
End Class