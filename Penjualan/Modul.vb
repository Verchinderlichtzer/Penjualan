Imports System.Data.OleDb, System.Environment
Module Modul
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public DS, DS2 As DataSet

    Public UserAktif As String = Nothing
    Public Hak As Integer()
    Public Locked As Boolean
    Public Warna As Integer
    Public HalamanTerpilih As Integer
    Public Path As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Ill"
    Public ImgSave, ImgEdit, ImgBerhasil, ImgGagal, ImgQuestion, ImgExclamation As Bitmap

    Public Sub HakAksesEdit(MulaiDari3 As Integer, BTN1 As Krypton.Toolkit.KryptonButton, BTN2 As Krypton.Toolkit.KryptonButton)
        If Hak(MulaiDari3) = 0 Then
            BTN1.Visible = 0
            BTN2.Visible = 0
        Else
            BTN1.Visible = 1
            BTN2.Visible = 1
        End If
    End Sub

    Sub GoToPageNumber(TB As Integer, JB As Integer, ByRef FD As Integer, ByRef CP As Integer) 'TotalBaris, JumlahBaris, FetchData, CurrentPage
        If Math.Ceiling(TB / JB) <= 1 Then Exit Sub
        Dim Confirm As New Konfirmasi("Pilih antara halaman 1 ~ " & Math.Ceiling(TB / JB), "-", 0)
        If Confirm.ShowDialog() = DialogResult.Yes And Not HalamanTerpilih = 0 Then
            FD = (HalamanTerpilih - 1) * JB + 1
            CP = HalamanTerpilih
        End If
    End Sub

    Public Sub Koneksi()
        CONN = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Path & "\Ill.accdb;Jet OLEDB:Database Password=zxc123;")
        Try
            CONN.Open()
        Catch ex As Exception
            End
        End Try
    End Sub

    Public Sub QR(QueryReader As String)
        CMD = New OleDbCommand(QueryReader, CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Application.Restart()
        End Try
    End Sub

    Public Sub QRL(QueryReaderLooping As String)
        CMD = New OleDbCommand(QueryReaderLooping, CONN)
        DR = CMD.ExecuteReader
        Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Application.Restart()
        End Try
    End Sub

    Public Sub QN(QueryNonReader As String)
        CMD = New OleDbCommand(QueryNonReader, CONN)
        CMD.ExecuteNonQuery()
        Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Application.Restart()
        End Try
    End Sub

    Public Sub QDGV(QueryDGV As String, DataGrid As DataGridView, StartRecord As Integer, MaxRecord As Integer, SrcTable As String)
        DataGrid.DataSource = Nothing
        DA = New OleDbDataAdapter(QueryDGV, CONN)
        DS = New DataSet
        DA.Fill(DS, StartRecord, MaxRecord, SrcTable)
        DataGrid.DataSource = DS.Tables(0)
    End Sub

    Public Sub QDGV2(QueryDGV As String, DataGrid As DataGridView, StartRecord As Integer, MaxRecord As Integer, SrcTable As String)
        DA = New OleDbDataAdapter(QueryDGV, CONN)
        DS2 = New DataSet
        DA.Fill(DS2, StartRecord, MaxRecord, SrcTable)
        DataGrid.DataSource = DS2.Tables(0)
    End Sub

    Public Sub Pesan(msg As String, type As Notifikasi.AlertTypeEnum)
        Dim f As New Notifikasi
        f.SetAlert(msg, type)
    End Sub

    Public Sub Angka(e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then e.Handled = True
    End Sub

    Public Sub Angka_KeyPress(sender As Object, e As KeyPressEventArgs) 'DGV Input Angka
        Angka(e)
    End Sub

    Public Function EncodeUsername(plainUsername As String) As String
        Dim wrapper As New Encryptor("1337")
        Dim cipherUsername As String = wrapper.EncryptData(plainUsername)
        Return cipherUsername
    End Function

    Public Function DecodeUsername(cipherUsername As String) As String
        Dim wrapper As New Encryptor("1337")
        Dim plainUsername As String = wrapper.DecryptData(cipherUsername)
        Return plainUsername
    End Function

    Public Function EncodePassword(plainUsername As String, plainPassword As String) As String
        Dim wrapper As New Encryptor(plainUsername)
        Dim cipherPassword As String = wrapper.EncryptData(StrReverse(plainPassword))
        Dim asciis As Byte() = Text.Encoding.ASCII.GetBytes(cipherPassword)
        For i As Integer = 0 To asciis.Length - 1
            asciis(i) = CByte(asciis(i) + 4)
        Next
        Return Text.Encoding.ASCII.GetString(asciis)
    End Function

    Public Function DecodePassword(plainUsername As String, cipherPassword As String) As String
        Dim wrapper As New Encryptor(plainUsername)
        Dim asciis As Byte() = Text.Encoding.ASCII.GetBytes(cipherPassword)
        For i As Integer = 0 To asciis.Length - 1
            asciis(i) = CByte(asciis(i) - 4)
        Next
        Dim plainPassword As String = wrapper.DecryptData(Text.Encoding.ASCII.GetString(asciis))
        Return StrReverse(plainPassword)
    End Function

    Sub Ukur(Sesuatu As Object)
        If TypeOf Sesuatu Is DataGridView Then
            Dim y As Integer = 0
            Dim z As String = Nothing
            For Each x In Sesuatu.Columns
                If x.Visible = False Then Continue For
                z &= x.Width & "  "
                y += x.Width
            Next
            MsgBox(z & "|  " & Sesuatu.Width & " - " & y & " = " & Sesuatu.Width - y, MsgBoxStyle.Information, "18 = VScrollBar, 1 = Pagination")
        Else
            MsgBox(Sesuatu.Width & " x " & Sesuatu.Height, MsgBoxStyle.Information, "Panjang x Lebar")
        End If
    End Sub

    Public Sub TemaWarna(Formku As Form, Ix As Integer, Paletku As Krypton.Toolkit.KryptonPalette)
        If Ix = 0 Then 'Merah
            MainF.BTNUser.Values.Image = My.Resources.user_merah
            MainF.BTNUser.Values.ImageStates.ImageTracking = My.Resources.user_tracking_merah
            MainF.BTNBarang.Values.Image = My.Resources.barang_merah
            MainF.BTNBarang.Values.ImageStates.ImageTracking = My.Resources.barang_tracking_merah
            MainF.BTNPelanggan.Values.Image = My.Resources.pelanggan_merah
            MainF.BTNPelanggan.Values.ImageStates.ImageTracking = My.Resources.pelanggan_tracking_merah
            MainF.BTNTransaksi.Values.Image = My.Resources.transaksi_merah
            MainF.BTNTransaksi.Values.ImageStates.ImageTracking = My.Resources.transaksi_tracking_merah
            MainF.BTNCatatan.Values.Image = My.Resources.catatan_merah
            MainF.BTNCatatan.Values.ImageStates.ImageTracking = My.Resources.catatan_tracking_merah
            MainF.BTNLaporan.Values.Image = My.Resources.laporan_merah
            MainF.BTNLaporan.Values.ImageStates.ImageTracking = My.Resources.laporan_tracking_merah
            MainF.BTNLogout.Values.ImageStates.ImagePressed = My.Resources.logout_merah
            MainF.BTNLogout.Values.ImageStates.ImageTracking = My.Resources.logout_tracking_merah
            MainF.BTNLogout.StatePressed.Content.ShortText.Color1 = Color.FromArgb(254, 55, 83)
            MainF.BTNLogout.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 156, 170)
            For Each TombolMenu In MainF.Sidebar.Controls.OfType(Of Krypton.Toolkit.KryptonCheckButton)
                TombolMenu.StateCommon.Border.Color1 = Color.FromArgb(254, 55, 83)
                TombolMenu.StateCommon.Content.ShortText.Color1 = Color.FromArgb(254, 55, 83)
                TombolMenu.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 156, 170)
            Next
            For Each TextBoxKu In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonTextBox)
                TextBoxKu.StateActive.Border.Color1 = Color.FromArgb(190, 41, 62)
            Next
            For Each Buttonku In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonButton)
                If Buttonku.Name = "BTNSimpan" Or Buttonku.Name = "BTNHapus" Or Buttonku.Name = "BTNClear" Or Buttonku.Name = "BTNPrint" Then
                    Buttonku.StateCommon.Border.Color1 = Color.FromArgb(190, 41, 62)
                    If Buttonku.Name = "BTNHapus" Then Buttonku.Values.Image = My.Resources.hapus_merah
                    If Buttonku.Name = "BTNClear" Then Buttonku.Values.Image = My.Resources.clear_merah
                    If Buttonku.Name = "BTNPrint" Then Buttonku.Values.Image = My.Resources.print_merah
                ElseIf Buttonku.Size.Width = 24 And Buttonku.Size.Height = 24 Then
                    Buttonku.StateNormal.Content.ShortText.Color1 = Color.FromArgb(190, 41, 62)
                    Buttonku.StateCommon.Content.ShortText.Color1 = Color.FromArgb(254, 55, 83)
                Else
                    Buttonku.OverrideDefault.Back.Color1 = Color.FromArgb(190, 41, 62)
                    Buttonku.StateCommon.Back.Color1 = Color.FromArgb(190, 41, 62)
                    Buttonku.StateTracking.Back.Color1 = Color.FromArgb(254, 55, 83)
                    Buttonku.StatePressed.Back.Color1 = Color.FromArgb(255, 105, 126)
                End If
            Next
            With Paletku
                .InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = Color.FromArgb(190, 41, 62)
                .Images.CheckBox.CheckedNormal = My.Resources.check_true_merah
                .Images.CheckBox.CheckedPressed = My.Resources.check_true_merah
                .Images.CheckBox.CheckedTracking = My.Resources.check_true_merah
                .Images.RadioButton.CheckedNormal = My.Resources.radio_true_merah
                .Images.RadioButton.CheckedPressed = My.Resources.radio_true_merah
                .Images.RadioButton.CheckedTracking = My.Resources.radio_true_merah
                .GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(127, 27, 41)
                .GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(190, 41, 62)
            End With
            ImgSave = My.Resources.simpan_merah
            ImgEdit = My.Resources.edit_merah
            ImgBerhasil = My.Resources.berhasil_merah
            ImgGagal = My.Resources.gagal_merah
            ImgQuestion = My.Resources.question_merah
            ImgExclamation = My.Resources.exclamation_merah
        ElseIf Ix = 1 Then 'Kuning
            MainF.BTNUser.Values.Image = My.Resources.user_kuning
            MainF.BTNUser.Values.ImageStates.ImageTracking = My.Resources.user_tracking_kuning
            MainF.BTNBarang.Values.Image = My.Resources.barang_kuning
            MainF.BTNBarang.Values.ImageStates.ImageTracking = My.Resources.barang_tracking_kuning
            MainF.BTNPelanggan.Values.Image = My.Resources.pelanggan_kuning
            MainF.BTNPelanggan.Values.ImageStates.ImageTracking = My.Resources.pelanggan_tracking_kuning
            MainF.BTNTransaksi.Values.Image = My.Resources.transaksi_kuning
            MainF.BTNTransaksi.Values.ImageStates.ImageTracking = My.Resources.transaksi_tracking_kuning
            MainF.BTNCatatan.Values.Image = My.Resources.catatan_kuning
            MainF.BTNCatatan.Values.ImageStates.ImageTracking = My.Resources.catatan_tracking_kuning
            MainF.BTNLaporan.Values.Image = My.Resources.laporan_kuning
            MainF.BTNLaporan.Values.ImageStates.ImageTracking = My.Resources.laporan_tracking_kuning
            MainF.BTNLogout.Values.ImageStates.ImagePressed = My.Resources.logout_kuning
            MainF.BTNLogout.Values.ImageStates.ImageTracking = My.Resources.logout_tracking_kuning
            MainF.BTNLogout.StatePressed.Content.ShortText.Color1 = Color.FromArgb(255, 209, 37)
            MainF.BTNLogout.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 232, 146)
            For Each TombolMenu In MainF.Sidebar.Controls.OfType(Of Krypton.Toolkit.KryptonCheckButton)
                TombolMenu.StateCommon.Border.Color1 = Color.FromArgb(255, 209, 37)
                TombolMenu.StateCommon.Content.ShortText.Color1 = Color.FromArgb(255, 209, 37)
                TombolMenu.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 232, 146)
            Next
            For Each TextBoxKu In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonTextBox)
                TextBoxKu.StateActive.Border.Color1 = Color.FromArgb(191, 157, 27)
            Next
            For Each Buttonku In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonButton)
                If Buttonku.Name = "BTNSimpan" Or Buttonku.Name = "BTNHapus" Or Buttonku.Name = "BTNClear" Or Buttonku.Name = "BTNPrint" Then
                    Buttonku.StateCommon.Border.Color1 = Color.FromArgb(191, 157, 27)
                    If Buttonku.Name = "BTNHapus" Then Buttonku.Values.Image = My.Resources.hapus_kuning
                    If Buttonku.Name = "BTNClear" Then Buttonku.Values.Image = My.Resources.clear_kuning
                    If Buttonku.Name = "BTNPrint" Then Buttonku.Values.Image = My.Resources.print_kuning
                ElseIf Buttonku.Size.Width = 24 And Buttonku.Size.Height = 24 Then
                    Buttonku.StateNormal.Content.ShortText.Color1 = Color.FromArgb(191, 157, 27)
                    Buttonku.StateCommon.Content.ShortText.Color1 = Color.FromArgb(255, 209, 37)
                Else
                    Buttonku.OverrideDefault.Back.Color1 = Color.FromArgb(191, 157, 27)
                    Buttonku.StateCommon.Back.Color1 = Color.FromArgb(191, 157, 27)
                    Buttonku.StateTracking.Back.Color1 = Color.FromArgb(255, 209, 37)
                    Buttonku.StatePressed.Back.Color1 = Color.FromArgb(255, 221, 92)
                End If
            Next
            With Paletku
                .InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = Color.FromArgb(191, 157, 27)
                .Images.CheckBox.CheckedNormal = My.Resources.check_true_kuning
                .Images.CheckBox.CheckedPressed = My.Resources.check_true_kuning
                .Images.CheckBox.CheckedTracking = My.Resources.check_true_kuning
                .Images.RadioButton.CheckedNormal = My.Resources.radio_true_kuning
                .Images.RadioButton.CheckedPressed = My.Resources.radio_true_kuning
                .Images.RadioButton.CheckedTracking = My.Resources.radio_true_kuning
                .GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(127, 104, 18)
                .GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(191, 157, 27)
            End With
            ImgSave = My.Resources.simpan_kuning
            ImgEdit = My.Resources.edit_kuning
            ImgBerhasil = My.Resources.berhasil_kuning
            ImgGagal = My.Resources.gagal_kuning
            ImgQuestion = My.Resources.question_kuning
            ImgExclamation = My.Resources.exclamation_kuning
        ElseIf Ix = 2 Then 'Hijau
            MainF.BTNUser.Values.Image = My.Resources.user_hijau
            MainF.BTNUser.Values.ImageStates.ImageTracking = My.Resources.user_tracking_hijau
            MainF.BTNBarang.Values.Image = My.Resources.barang_hijau
            MainF.BTNBarang.Values.ImageStates.ImageTracking = My.Resources.barang_tracking_hijau
            MainF.BTNPelanggan.Values.Image = My.Resources.pelanggan_hijau
            MainF.BTNPelanggan.Values.ImageStates.ImageTracking = My.Resources.pelanggan_tracking_hijau
            MainF.BTNTransaksi.Values.Image = My.Resources.transaksi_hijau
            MainF.BTNTransaksi.Values.ImageStates.ImageTracking = My.Resources.transaksi_tracking_hijau
            MainF.BTNCatatan.Values.Image = My.Resources.catatan_hijau
            MainF.BTNCatatan.Values.ImageStates.ImageTracking = My.Resources.catatan_tracking_hijau
            MainF.BTNLaporan.Values.Image = My.Resources.laporan_hijau
            MainF.BTNLaporan.Values.ImageStates.ImageTracking = My.Resources.laporan_tracking_hijau
            MainF.BTNLogout.Values.ImageStates.ImagePressed = My.Resources.logout_hijau
            MainF.BTNLogout.Values.ImageStates.ImageTracking = My.Resources.logout_tracking_hijau
            MainF.BTNLogout.StatePressed.Content.ShortText.Color1 = Color.FromArgb(108, 203, 120)
            MainF.BTNLogout.StateTracking.Content.ShortText.Color1 = Color.FromArgb(182, 229, 188)
            For Each TombolMenu In MainF.Sidebar.Controls.OfType(Of Krypton.Toolkit.KryptonCheckButton)
                TombolMenu.StateCommon.Border.Color1 = Color.FromArgb(108, 203, 120)
                TombolMenu.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 203, 120)
                TombolMenu.StateTracking.Content.ShortText.Color1 = Color.FromArgb(182, 229, 188)
            Next
            For Each TextBoxKu In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonTextBox)
                TextBoxKu.StateActive.Border.Color1 = Color.FromArgb(81, 152, 90)
            Next
            For Each Buttonku In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonButton)
                If Buttonku.Name = "BTNSimpan" Or Buttonku.Name = "BTNHapus" Or Buttonku.Name = "BTNClear" Or Buttonku.Name = "BTNPrint" Then
                    Buttonku.StateCommon.Border.Color1 = Color.FromArgb(81, 152, 90)
                    If Buttonku.Name = "BTNHapus" Then Buttonku.Values.Image = My.Resources.hapus_hijau
                    If Buttonku.Name = "BTNClear" Then Buttonku.Values.Image = My.Resources.clear_hijau
                    If Buttonku.Name = "BTNPrint" Then Buttonku.Values.Image = My.Resources.print_hijau
                ElseIf Buttonku.Size.Width = 24 And Buttonku.Size.Height = 24 Then
                    Buttonku.StateNormal.Content.ShortText.Color1 = Color.FromArgb(81, 152, 90)
                    Buttonku.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 203, 120)
                Else
                    Buttonku.OverrideDefault.Back.Color1 = Color.FromArgb(81, 152, 90)
                    Buttonku.StateCommon.Back.Color1 = Color.FromArgb(81, 152, 90)
                    Buttonku.StateTracking.Back.Color1 = Color.FromArgb(108, 203, 120)
                    Buttonku.StatePressed.Back.Color1 = Color.FromArgb(145, 216, 154)
                End If
            Next
            With Paletku
                .InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = Color.FromArgb(81, 152, 90)
                .Images.CheckBox.CheckedNormal = My.Resources.check_true_hijau
                .Images.CheckBox.CheckedPressed = My.Resources.check_true_hijau
                .Images.CheckBox.CheckedTracking = My.Resources.check_true_hijau
                .Images.RadioButton.CheckedNormal = My.Resources.radio_true_hijau
                .Images.RadioButton.CheckedPressed = My.Resources.radio_true_hijau
                .Images.RadioButton.CheckedTracking = My.Resources.radio_true_hijau
                .GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(54, 101, 60)
                .GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(81, 152, 90)
            End With
            ImgSave = My.Resources.simpan_hijau
            ImgEdit = My.Resources.edit_hijau
            ImgBerhasil = My.Resources.berhasil_hijau
            ImgGagal = My.Resources.gagal_hijau
            ImgQuestion = My.Resources.question_hijau
            ImgExclamation = My.Resources.exclamation_hijau
        ElseIf Ix = 3 Then 'Biru
            MainF.BTNUser.Values.Image = My.Resources.user_biru
            MainF.BTNUser.Values.ImageStates.ImageTracking = My.Resources.user_tracking_biru
            MainF.BTNBarang.Values.Image = My.Resources.barang_biru
            MainF.BTNBarang.Values.ImageStates.ImageTracking = My.Resources.barang_tracking_biru
            MainF.BTNPelanggan.Values.Image = My.Resources.pelanggan_biru
            MainF.BTNPelanggan.Values.ImageStates.ImageTracking = My.Resources.pelanggan_tracking_biru
            MainF.BTNTransaksi.Values.Image = My.Resources.transaksi_biru
            MainF.BTNTransaksi.Values.ImageStates.ImageTracking = My.Resources.transaksi_tracking_biru
            MainF.BTNCatatan.Values.Image = My.Resources.catatan_biru
            MainF.BTNCatatan.Values.ImageStates.ImageTracking = My.Resources.catatan_tracking_biru
            MainF.BTNLaporan.Values.Image = My.Resources.laporan_biru
            MainF.BTNLaporan.Values.ImageStates.ImageTracking = My.Resources.laporan_tracking_biru
            MainF.BTNLogout.Values.ImageStates.ImagePressed = My.Resources.logout_biru
            MainF.BTNLogout.Values.ImageStates.ImageTracking = My.Resources.logout_tracking_biru
            MainF.BTNLogout.StatePressed.Content.ShortText.Color1 = Color.FromArgb(1, 175, 193)
            MainF.BTNLogout.StateTracking.Content.ShortText.Color1 = Color.FromArgb(128, 215, 224)
            For Each TombolMenu In MainF.Sidebar.Controls.OfType(Of Krypton.Toolkit.KryptonCheckButton)
                TombolMenu.StateCommon.Border.Color1 = Color.FromArgb(1, 175, 193)
                TombolMenu.StateCommon.Content.ShortText.Color1 = Color.FromArgb(1, 175, 193)
                TombolMenu.StateTracking.Content.ShortText.Color1 = Color.FromArgb(128, 215, 224)
            Next
            For Each TextBoxKu In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonTextBox)
                TextBoxKu.StateActive.Border.Color1 = Color.FromArgb(0, 131, 145)
            Next
            For Each Buttonku In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonButton)
                If Buttonku.Name = "BTNSimpan" Or Buttonku.Name = "BTNHapus" Or Buttonku.Name = "BTNClear" Or Buttonku.Name = "BTNPrint" Then
                    Buttonku.StateCommon.Border.Color1 = Color.FromArgb(0, 131, 145)
                    If Buttonku.Name = "BTNHapus" Then Buttonku.Values.Image = My.Resources.hapus_biru
                    If Buttonku.Name = "BTNClear" Then Buttonku.Values.Image = My.Resources.clear_biru
                    If Buttonku.Name = "BTNPrint" Then Buttonku.Values.Image = My.Resources.print_biru
                ElseIf Buttonku.Size.Width = 24 And Buttonku.Size.Height = 24 Then
                    Buttonku.StateNormal.Content.ShortText.Color1 = Color.FromArgb(0, 131, 145)
                    Buttonku.StateCommon.Content.ShortText.Color1 = Color.FromArgb(1, 175, 193)
                Else
                    Buttonku.OverrideDefault.Back.Color1 = Color.FromArgb(0, 131, 145)
                    Buttonku.StateCommon.Back.Color1 = Color.FromArgb(0, 131, 145)
                    Buttonku.StateTracking.Back.Color1 = Color.FromArgb(1, 175, 193)
                    Buttonku.StatePressed.Back.Color1 = Color.FromArgb(65, 195, 209)
                End If
            Next
            With Paletku
                .InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = Color.FromArgb(0, 131, 145)
                .Images.CheckBox.CheckedNormal = My.Resources.check_true_biru
                .Images.CheckBox.CheckedPressed = My.Resources.check_true_biru
                .Images.CheckBox.CheckedTracking = My.Resources.check_true_biru
                .Images.RadioButton.CheckedNormal = My.Resources.radio_true_biru
                .Images.RadioButton.CheckedPressed = My.Resources.radio_true_biru
                .Images.RadioButton.CheckedTracking = My.Resources.radio_true_biru
                .GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(0, 87, 96)
                .GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(0, 131, 145)
            End With
            ImgSave = My.Resources.simpan_biru
            ImgEdit = My.Resources.edit_biru
            ImgBerhasil = My.Resources.berhasil_biru
            ImgGagal = My.Resources.gagal_biru
            ImgQuestion = My.Resources.question_biru
            ImgExclamation = My.Resources.exclamation_biru
        ElseIf Ix = 4 Then 'Ungu
            MainF.BTNUser.Values.Image = My.Resources.user_ungu
            MainF.BTNUser.Values.ImageStates.ImageTracking = My.Resources.user_tracking_ungu
            MainF.BTNBarang.Values.Image = My.Resources.barang_ungu
            MainF.BTNBarang.Values.ImageStates.ImageTracking = My.Resources.barang_tracking_ungu
            MainF.BTNPelanggan.Values.Image = My.Resources.pelanggan_ungu
            MainF.BTNPelanggan.Values.ImageStates.ImageTracking = My.Resources.pelanggan_tracking_ungu
            MainF.BTNTransaksi.Values.Image = My.Resources.transaksi_ungu
            MainF.BTNTransaksi.Values.ImageStates.ImageTracking = My.Resources.transaksi_tracking_ungu
            MainF.BTNCatatan.Values.Image = My.Resources.catatan_ungu
            MainF.BTNCatatan.Values.ImageStates.ImageTracking = My.Resources.catatan_tracking_ungu
            MainF.BTNLaporan.Values.Image = My.Resources.laporan_ungu
            MainF.BTNLaporan.Values.ImageStates.ImageTracking = My.Resources.laporan_tracking_ungu
            MainF.BTNLogout.Values.ImageStates.ImagePressed = My.Resources.logout_ungu
            MainF.BTNLogout.Values.ImageStates.ImageTracking = My.Resources.logout_tracking_ungu
            MainF.BTNLogout.StatePressed.Content.ShortText.Color1 = Color.FromArgb(212, 123, 232)
            MainF.BTNLogout.StateTracking.Content.ShortText.Color1 = Color.FromArgb(234, 189, 244)
            For Each TombolMenu In MainF.Sidebar.Controls.OfType(Of Krypton.Toolkit.KryptonCheckButton)
                TombolMenu.StateCommon.Border.Color1 = Color.FromArgb(212, 123, 232)
                TombolMenu.StateCommon.Content.ShortText.Color1 = Color.FromArgb(212, 123, 232)
                TombolMenu.StateTracking.Content.ShortText.Color1 = Color.FromArgb(234, 189, 244)
            Next
            For Each TextBoxKu In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonTextBox)
                TextBoxKu.StateActive.Border.Color1 = Color.FromArgb(159, 92, 174)
            Next
            For Each Buttonku In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonButton)
                If Buttonku.Name = "BTNSimpan" Or Buttonku.Name = "BTNHapus" Or Buttonku.Name = "BTNClear" Or Buttonku.Name = "BTNPrint" Then
                    Buttonku.StateCommon.Border.Color1 = Color.FromArgb(159, 92, 174)
                    If Buttonku.Name = "BTNHapus" Then Buttonku.Values.Image = My.Resources.hapus_ungu
                    If Buttonku.Name = "BTNClear" Then Buttonku.Values.Image = My.Resources.clear_ungu
                    If Buttonku.Name = "BTNPrint" Then Buttonku.Values.Image = My.Resources.print_ungu
                ElseIf Buttonku.Size.Width = 24 And Buttonku.Size.Height = 24 Then
                    Buttonku.StateNormal.Content.ShortText.Color1 = Color.FromArgb(159, 92, 174)
                    Buttonku.StateCommon.Content.ShortText.Color1 = Color.FromArgb(212, 123, 232)
                Else
                    Buttonku.OverrideDefault.Back.Color1 = Color.FromArgb(159, 92, 174)
                    Buttonku.StateCommon.Back.Color1 = Color.FromArgb(159, 92, 174)
                    Buttonku.StateTracking.Back.Color1 = Color.FromArgb(212, 123, 232)
                    Buttonku.StatePressed.Back.Color1 = Color.FromArgb(223, 156, 238)
                End If
            Next
            With Paletku
                .InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = Color.FromArgb(159, 92, 174)
                .Images.CheckBox.CheckedNormal = My.Resources.check_true_ungu
                .Images.CheckBox.CheckedPressed = My.Resources.check_true_ungu
                .Images.CheckBox.CheckedTracking = My.Resources.check_true_ungu
                .Images.RadioButton.CheckedNormal = My.Resources.radio_true_ungu
                .Images.RadioButton.CheckedPressed = My.Resources.radio_true_ungu
                .Images.RadioButton.CheckedTracking = My.Resources.radio_true_ungu
                .GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(106, 61, 116)
                .GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(159, 92, 174)
            End With
            ImgSave = My.Resources.simpan_ungu
            ImgEdit = My.Resources.edit_ungu
            ImgBerhasil = My.Resources.berhasil_ungu
            ImgGagal = My.Resources.gagal_ungu
            ImgQuestion = My.Resources.question_ungu
            ImgExclamation = My.Resources.exclamation_ungu
        ElseIf Ix = 5 Then 'Coklat
            MainF.BTNUser.Values.Image = My.Resources.user_coklat
            MainF.BTNUser.Values.ImageStates.ImageTracking = My.Resources.user_tracking_coklat
            MainF.BTNBarang.Values.Image = My.Resources.barang_coklat
            MainF.BTNBarang.Values.ImageStates.ImageTracking = My.Resources.barang_tracking_coklat
            MainF.BTNPelanggan.Values.Image = My.Resources.pelanggan_coklat
            MainF.BTNPelanggan.Values.ImageStates.ImageTracking = My.Resources.pelanggan_tracking_coklat
            MainF.BTNTransaksi.Values.Image = My.Resources.transaksi_coklat
            MainF.BTNTransaksi.Values.ImageStates.ImageTracking = My.Resources.transaksi_tracking_coklat
            MainF.BTNCatatan.Values.Image = My.Resources.catatan_coklat
            MainF.BTNCatatan.Values.ImageStates.ImageTracking = My.Resources.catatan_tracking_coklat
            MainF.BTNLaporan.Values.Image = My.Resources.laporan_coklat
            MainF.BTNLaporan.Values.ImageStates.ImageTracking = My.Resources.laporan_tracking_coklat
            MainF.BTNLogout.Values.ImageStates.ImagePressed = My.Resources.logout_coklat
            MainF.BTNLogout.Values.ImageStates.ImageTracking = My.Resources.logout_tracking_coklat
            MainF.BTNLogout.StatePressed.Content.ShortText.Color1 = Color.FromArgb(191, 146, 113)
            MainF.BTNLogout.StateTracking.Content.ShortText.Color1 = Color.FromArgb(223, 201, 184)
            For Each TombolMenu In MainF.Sidebar.Controls.OfType(Of Krypton.Toolkit.KryptonCheckButton)
                TombolMenu.StateCommon.Border.Color1 = Color.FromArgb(191, 146, 113)
                TombolMenu.StateCommon.Content.ShortText.Color1 = Color.FromArgb(191, 146, 113)
                TombolMenu.StateTracking.Content.ShortText.Color1 = Color.FromArgb(223, 201, 184)
            Next
            For Each TextBoxKu In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonTextBox)
                TextBoxKu.StateActive.Border.Color1 = Color.FromArgb(143, 109, 84)
            Next
            For Each Buttonku In Formku.Controls.OfType(Of Krypton.Toolkit.KryptonButton)
                If Buttonku.Name = "BTNSimpan" Or Buttonku.Name = "BTNHapus" Or Buttonku.Name = "BTNClear" Or Buttonku.Name = "BTNPrint" Then
                    Buttonku.StateCommon.Border.Color1 = Color.FromArgb(143, 109, 84)
                    If Buttonku.Name = "BTNHapus" Then Buttonku.Values.Image = My.Resources.hapus_coklat
                    If Buttonku.Name = "BTNClear" Then Buttonku.Values.Image = My.Resources.clear_coklat
                    If Buttonku.Name = "BTNPrint" Then Buttonku.Values.Image = My.Resources.print_coklat
                ElseIf ButtonKu.Size.Width = 24 And Buttonku.Size.Height = 24 Then
                    Buttonku.StateNormal.Content.ShortText.Color1 = Color.FromArgb(143, 109, 84)
                    Buttonku.StateCommon.Content.ShortText.Color1 = Color.FromArgb(191, 146, 113)
                Else
                    Buttonku.OverrideDefault.Back.Color1 = Color.FromArgb(143, 109, 84)
                    Buttonku.StateCommon.Back.Color1 = Color.FromArgb(143, 109, 84)
                    Buttonku.StateTracking.Back.Color1 = Color.FromArgb(191, 146, 113)
                    Buttonku.StatePressed.Back.Color1 = Color.FromArgb(207, 174, 149)
                End If
            Next
            With Paletku
                .InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = Color.FromArgb(143, 109, 84)
                .Images.CheckBox.CheckedNormal = My.Resources.check_true_coklat
                .Images.CheckBox.CheckedPressed = My.Resources.check_true_coklat
                .Images.CheckBox.CheckedTracking = My.Resources.check_true_coklat
                .Images.RadioButton.CheckedNormal = My.Resources.radio_true_coklat
                .Images.RadioButton.CheckedPressed = My.Resources.radio_true_coklat
                .Images.RadioButton.CheckedTracking = My.Resources.radio_true_coklat
                .GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(95, 73, 56)
                .GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(143, 109, 84)
            End With
            ImgSave = My.Resources.simpan_coklat
            ImgEdit = My.Resources.edit_coklat
            ImgBerhasil = My.Resources.berhasil_coklat
            ImgGagal = My.Resources.gagal_coklat
            ImgQuestion = My.Resources.question_coklat
            ImgExclamation = My.Resources.exclamation_coklat
        End If
    End Sub
End Module