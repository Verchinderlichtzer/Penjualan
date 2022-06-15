Imports System.Data.OleDb, Microsoft.Reporting.WinForms
Public Class Laporan
    '8.27in, 11.69in  -  11.69in, 8.27in

    'Filter

    'Nama
    'Alamat
    'Telepon
    'Fax
    'Email
    'Website
    'Pengurus
    'Jabatan
    'Bank
    'Rekening
    'AtasNama

    'Tahun

    'Header BackColor dan BorderColor = #21333a
    'Header BorderStyle Solid (Variasi = Left, Right)
    'Header Font = Segoe UI, 11pt, Default, Bold, Default

    'Row BackColor  =IIf(RowNumber(Nothing) Mod 2, "#EEEFF0", "#DBDEDF")
    'Row BackColor By Group  =IIf(RunningValue(Fields!ID_Barang.Value, CountDistinct, Nothing) Mod 2, "#EEEFF0", "#DBDEDF")
    'Row BorderColor = #c8cdcf
    'Row BorderStyle Solid (Variasi = Left, Right)
    'Row Font = Segoe UI, 10pt, Default, Normal, Default

    '=IIf(Fields!Status.Value = "Belum Lunas", "#A52733", "#333333")
    '=IIf(Left(Fields!ID_Masuk.Value, 1) = "K", "#1E7D33", "#A52733")
    '#333333 = Default
    '#1E7D33 = Hijau
    '#A52733 = Merah



    'Grafik :

    'Category Groups :

    'Group Expression
    '=Month(Fields!Tanggal.Value)

    'Labels
    '=IIf(Month(Fields!Tanggal.Value) = 1, "JAN", IIf(Month(Fields!Tanggal.Value) = 2, "FEB", IIf(Month(Fields!Tanggal.Value) = 3, "MAR", IIf(Month(Fields!Tanggal.Value) = 4, "APR", IIf(Month(Fields!Tanggal.Value) = 5, "MEI", IIf(Month(Fields!Tanggal.Value) = 6, "JUN", IIf(Month(Fields!Tanggal.Value) = 7, "JUL", IIf(Month(Fields!Tanggal.Value) = 8, "AGS", IIf(Month(Fields!Tanggal.Value) = 9, "SEP", IIf(Month(Fields!Tanggal.Value) = 10, "OKT", IIf(Month(Fields!Tanggal.Value) = 11, "NOV", IIf(Month(Fields!Tanggal.Value) = 12, "DES", Nothing))))))))))))

    'Values
    '=Sum(IIf(Left(Fields!ID_Masuk.Value, 1) = "M / K", Fields!Nominal.Value, Nothing))

    Dim QueryTanggal, QueryLunas As String
    Dim FilterLaporan, FilterTanggal, FilterLunas, FilterBentuk As String
    Dim LaporanTerpilih As String
    Dim IDTerpilih, NamaTerpilih As String

    Dim ParamFilter, ParamNama, ParamAlamat, ParamTelepon, ParamPengurus, ParamJabatan, ParamTahun As ReportParameter
    Dim Params As ReportParameter()

    Sub Bersihkan()
        Locked = 1
        RBRingkasan.Checked = 1
        Dim Check As Object() = {RBBarang, RBPelanggan, RBTransaksi, RBGrafik, CBSudah, CBBelum, RBDetail}
        For Each x In Check
            x.Checked = 0
        Next

        TDari.Value = Today
        TSampai.Value = Today
        TBulanan.Value = Today
        TTahunan.SelectedIndex = 0

        TEntitas.SelectedIndex = -1
        TCariData.Clear()
        'Bersihkan DGV
        Locked = 0

        FilterLaporan = Nothing
        FilterTanggal = Nothing
        FilterLunas = Nothing
        FilterBentuk = Nothing
        LBLFilter.Text = ""

        QueryTanggal = Nothing
        QueryLunas = Nothing
        LaporanTerpilih = Nothing
    End Sub

    'Sub TidakMemilih()
    '    FilterLaporan = Nothing
    '    FilterTanggal = Nothing
    '    LBLFilter.Text = ""
    '    Query = Nothing
    '    QueryTanggal = Nothing
    '    IDEntitas = Nothing
    '    NamaTerpilih = Nothing
    '    LaporanTerpilih = Nothing
    'End Sub

    Private Sub Lapor(sender As Object, e As EventArgs) Handles BTNLapor.Click
        If LaporanTerpilih = Nothing Then
            Pesan("Pilih Laporan valid", 0)
            Exit Sub
        End If
        Select Case LaporanTerpilih
            Case "RBBarang"
                TampilLaporan("Barang", TBLBarangBindingSource, "SELECT * FROM TBLBarang ORDER BY Nama", Ill.TBLBarang)
            Case "RBPelanggan"
                TampilLaporan("Pelanggan", TBLPelangganBindingSource, "SELECT * FROM TBLPelanggan ORDER BY Nama", Ill.TBLPelanggan)
            Case "RBTransaksi"
                If RBRingkasan.Checked = True Then
                    TampilLaporan("TransaksiRingkasan", TBLTransaksiRingkasanBindingSource, "SELECT Faktur, Tanggal, Nama, Total, Terbayar FROM TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE NOT Faktur IS NULL" & QueryTanggal & QueryLunas & " ORDER BY Faktur DESC", Ill.TBLTransaksiRingkasan)
                Else 'Detail
                    TampilLaporan("TransaksiDetail", TBLTransaksiDetailBindingSource, "SELECT TBLTransaksi.Faktur, Tanggal, TBLPelanggan.Nama, Total, Terbayar, TBLBarang.Nama, Ukuran, Satuan, Qty, TBLDetailTransaksi.Harga FROM (TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan) INNER JOIN (TBLBarang INNER JOIN TBLDetailTransaksi ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang) ON TBLTransaksi.Faktur = TBLDetailTransaksi.Faktur WHERE NOT TBLTransaksi.Faktur IS NULL" & QueryTanggal & QueryLunas & " ORDER BY TBLTransaksi.Faktur DESC, TBLBarang.Nama", Ill.TBLTransaksiDetail)
                End If
            Case "RBGrafik"
                TampilLaporan("Grafik", TBLGrafikBindingSource, "SELECT Tanggal, Nominal FROM TBLBayar WHERE YEAR(Tanggal) = " & TTahunan.SelectedItem, Ill.TBLGrafik)
            Case "Faktur"
                TampilLaporan("Faktur", TBLFakturBindingSource, "SELECT TBLTransaksi.Faktur, Tanggal, Total, Terbayar, TBLPelanggan.Nama, Alamat, Telepon, TBLBarang.Nama, Ukuran, Satuan, Qty, TBLDetailTransaksi.Harga FROM TBLBarang INNER JOIN (TBLPelanggan INNER JOIN (TBLTransaksi INNER JOIN TBLDetailTransaksi ON TBLTransaksi.Faktur = TBLDetailTransaksi.Faktur) ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan) ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang WHERE TBLTransaksi.Faktur = '" & IDTerpilih & "' ORDER BY TBLBarang.Nama", Ill.TBLFaktur)
            Case "Barang"
                TampilLaporan("BarangRingkasan", TBLBarangRingkasanBindingSource, "SELECT TBLBarang.ID_Barang, Barcode, TBLBarang.Nama, Kategori, Ukuran, Satuan, TBLDetailTransaksi.Faktur, Tanggal, TBLPelanggan.Nama, Qty, TBLDetailTransaksi.Harga FROM TBLPelanggan INNER JOIN (TBLTransaksi INNER JOIN (TBLBarang INNER JOIN TBLDetailTransaksi ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang) ON TBLTransaksi.Faktur = TBLDetailTransaksi.Faktur) ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE TBLBarang.ID_Barang = " & IDTerpilih & QueryTanggal & QueryLunas & " ORDER BY TBLDetailTransaksi.Faktur DESC", Ill.TBLBarangRingkasan)
            Case "Pelanggan"
                If RBRingkasan.Checked = True Then
                    TampilLaporan("PelangganRingkasan", TBLPelangganRingkasanBindingSource, "SELECT TBLPelanggan.ID_Pelanggan, Nama, Alamat, Telepon, Faktur, Tanggal, Total, Terbayar FROM TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE TBLPelanggan.ID_Pelanggan = " & IDTerpilih & QueryTanggal & QueryLunas & " ORDER BY Faktur DESC", Ill.TBLPelangganRingkasan)
                Else 'Detail
                    TampilLaporan("PelangganDetail", TBLPelangganDetailBindingSource, "SELECT TBLPelanggan.ID_Pelanggan, TBLPelanggan.Nama, Alamat, Telepon, TBLTransaksi.Faktur, Tanggal, Total, Terbayar, TBLBarang.Nama, Qty, TBLDetailTransaksi.Harga FROM TBLBarang INNER JOIN ((TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan) INNER JOIN TBLDetailTransaksi ON TBLTransaksi.Faktur = TBLDetailTransaksi.Faktur) ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang WHERE TBLPelanggan.ID_Pelanggan = " & IDTerpilih & QueryTanggal & QueryLunas & " ORDER BY TBLTransaksi.Faktur DESC, TBLBarang.Nama", Ill.TBLPelangganDetail)
                End If
        End Select
    End Sub

    Private Sub BTNBersihkan_Click(sender As Object, e As EventArgs) Handles BTNBersihkan.Click
        Bersihkan()
    End Sub

    Sub TampilLaporan(Judul As String, BS As BindingSource, Query As String, DT As DataTable)
        ParamFilter = New ReportParameter("Filter", LBLFilter.Text)
        ParamTahun = New ReportParameter("Tahun", TTahunan.SelectedItem.ToString)
        Dim CurrentReportDataSource = New ReportDataSource()
        Ill.Clear()
        Terlapor.Show()
        Terlapor.RV.LocalReport.ReportEmbeddedResource = "Penjualan.Laporan" & Judul & ".rdlc"
        CurrentReportDataSource.Name = "DS" & Judul
        CurrentReportDataSource.Value = BS
        Terlapor.RV.LocalReport.DataSources.Add(CurrentReportDataSource)
        DA = New OleDbDataAdapter(Query, CONN)
        DA.Fill(DT)
        Terlapor.RV.LocalReport.SetParameters(ParamFilter)
        Terlapor.RV.LocalReport.SetParameters(ParamTahun)
        For Each param As ReportParameter In Params
            Terlapor.RV.LocalReport.SetParameters(param)
        Next
        Terlapor.RV.SetDisplayMode(DisplayMode.PrintLayout)
        Terlapor.RV.ZoomMode = ZoomMode.Percent
        Terlapor.RV.ZoomPercent = 100
        Terlapor.RV.RefreshReport()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletSekunder)
        QR("SELECT * FROM TBLInfo")
        If DR.HasRows Then
            ParamNama = New ReportParameter("Nama", DR(0).ToString)
            ParamAlamat = New ReportParameter("Alamat", DR(1).ToString)
            ParamTelepon = New ReportParameter("Telepon", DR(2).ToString)
            ParamPengurus = New ReportParameter("Pengurus", DR(3).ToString)
            ParamJabatan = New ReportParameter("Jabatan", DR(4).ToString)
        End If
        Params = {ParamNama, ParamAlamat, ParamTelepon, ParamPengurus, ParamJabatan}
        TDari.Value = Today
        TSampai.Value = Today
        TBulanan.Value = Today
        For x = Year(Today) To 2021 Step -1
            TTahunan.Items.Add(x)
        Next
        TTahunan.SelectedIndex = 0
    End Sub

    Sub Filter()
        If LaporanTerpilih = "RBBarang" Or LaporanTerpilih = "RBPelanggan" Then
            LBLFilter.Text = "Laporan " & FilterLaporan
        ElseIf LaporanTerpilih = "RBTransaksi" Then
            LBLFilter.Text = "Laporan " & FilterLaporan & FilterTanggal & FilterLunas
        ElseIf LaporanTerpilih = "RBGrafik" Then
            LBLFilter.Text = "Grafik pada tahun " & TTahunan.SelectedItem
        ElseIf LaporanTerpilih = "Faktur" Or LaporanTerpilih = "Barang" Or LaporanTerpilih = "Pelanggan" Then
            LBLFilter.Text = "Laporan " & FilterLaporan & NamaTerpilih & FilterTanggal & FilterLunas
        End If
    End Sub

    Private Sub LaporanFileTransaksi(sender As Object, e As EventArgs) Handles RBBarang.CheckedChanged, RBPelanggan.CheckedChanged, RBTransaksi.CheckedChanged, RBGrafik.CheckedChanged
        If Locked Then Exit Sub
        QueryTanggal = Nothing
        FilterTanggal = Nothing
        QueryLunas = Nothing
        FilterLunas = Nothing
        LaporanTerpilih = sender.Name
        FilterLaporan = sender.Text
        Filter()
    End Sub

    Private Sub KriteriaLunas(sender As Object, e As EventArgs) Handles CBSudah.CheckedChanged, CBBelum.CheckedChanged
        If Locked Then Exit Sub
        QueryLunas = Nothing
        FilterLunas = Nothing
        If CBSudah.Checked = True And CBBelum.Checked = False Then
            QueryLunas = " AND Total = Terbayar"
            FilterLunas = " yang sudah lunas"
        ElseIf CBSudah.Checked = False And CBBelum.Checked = True Then
            QueryLunas = " AND Total > Terbayar"
            FilterLunas = " yang belum lunas"
        End If
        Filter()
    End Sub

    Private Sub TEntitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TEntitas.SelectedIndexChanged
        If Locked Then Exit Sub
        LaporanTerpilih = TEntitas.SelectedItem
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        If TEntitas.SelectedIndex = -1 Or Locked Then Exit Sub
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
        Timer1.Stop()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        IDTerpilih = DGV.Rows(e.RowIndex).Cells(0).Value
        If TEntitas.SelectedIndex = 0 Then 'Faktur
            FilterLaporan = "faktur "
            NamaTerpilih = DGV.Rows(e.RowIndex).Cells(0).Value
        ElseIf TEntitas.SelectedIndex = 1 Then 'Barang
            FilterLaporan = "transaksi pada "
            NamaTerpilih = DGV.Rows(e.RowIndex).Cells(1).Value
        ElseIf TEntitas.SelectedIndex = 2 Then 'Pelanggan
            FilterLaporan = "transaksi oleh "
            NamaTerpilih = DGV.Rows(e.RowIndex).Cells(1).Value
        End If
        Filter()
    End Sub

#Region "Tanggal Transaksi"
    Private Sub DTPPeriodik(sender As Object, e As EventArgs) Handles TSampai.ValueChanged, TDari.ValueChanged
        If FilterLaporan = Nothing Or Locked Then Exit Sub
        If sender Is TDari And TDari.Value > TSampai.Value Then
            TSampai.Value = TDari.Value
        ElseIf sender Is TSampai And TSampai.Value < TDari.Value Then
            TDari.Value = TSampai.Value
        End If
        If TDari.Value = TSampai.Value Then
            FilterTanggal = " pada tanggal " & Format(TDari.Value, "dd-MM-yyyy")
        Else
            FilterTanggal = " antara tanggal " & Format(TDari.Value, "dd-MM-yyyy") & " sampai " & Format(TSampai.Value, "dd-MM-yyyy")
        End If
        QueryTanggal = " AND (DATEVALUE(Tanggal) BETWEEN #" & Format(TDari.Value, "M/d/yyyy") & "# AND #" & Format(TSampai.Value, "M/d/yyyy") & "#)"
        If RBGrafik.Checked = True Then Exit Sub
        Filter()
    End Sub

    Private Sub TBulanan_ValueChanged(sender As Object, e As EventArgs) Handles TBulanan.ValueChanged
        If FilterLaporan = Nothing Or Locked Then Exit Sub
        Dim NamaBulan As String
        If Month(TBulanan.Value) = 1 Then
            NamaBulan = "Januari"
        ElseIf Month(TBulanan.Value) = 2 Then
            NamaBulan = "Februari"
        ElseIf Month(TBulanan.Value) = 3 Then
            NamaBulan = "Maret"
        ElseIf Month(TBulanan.Value) = 4 Then
            NamaBulan = "April"
        ElseIf Month(TBulanan.Value) = 5 Then
            NamaBulan = "Mei"
        ElseIf Month(TBulanan.Value) = 6 Then
            NamaBulan = "Juni"
        ElseIf Month(TBulanan.Value) = 7 Then
            NamaBulan = "Juli"
        ElseIf Month(TBulanan.Value) = 8 Then
            NamaBulan = "Agustus"
        ElseIf Month(TBulanan.Value) = 9 Then
            NamaBulan = "September"
        ElseIf Month(TBulanan.Value) = 10 Then
            NamaBulan = "Oktober"
        ElseIf Month(TBulanan.Value) = 11 Then
            NamaBulan = "November"
        Else
            NamaBulan = "Desember"
        End If
        FilterTanggal = " pada bulan " & NamaBulan & " tahun " & Year(TBulanan.Value)
        QueryTanggal = " AND MONTH(Tanggal) = " & Month(TBulanan.Value) & " AND YEAR(Tanggal) = " & Year(TBulanan.Value)
        If RBGrafik.Checked = True Then Exit Sub
        Filter()
    End Sub

    Private Sub TTahunan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TTahunan.SelectedIndexChanged
        If FilterLaporan = Nothing Or Locked Then Exit Sub
        FilterTanggal = " pada tahun " & TTahunan.SelectedItem
        QueryTanggal = " AND YEAR(Tanggal) = " & TTahunan.SelectedItem
        Filter()
    End Sub
#End Region

#Region "DGV"
    Dim FetchData As Integer
    Dim JumlahData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        If TEntitas.SelectedIndex = 0 Then 'Faktur
            QR("SELECT COUNT(Faktur) FROM TBLTransaksi WHERE Faktur LIKE '%" & TCariData.Text & "%'")
        ElseIf TEntitas.SelectedIndex = 1 Then 'Barang
            QR("SELECT COUNT(ID_Barang) FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%'")
        ElseIf TEntitas.SelectedIndex = 2 Then 'Pelanggan
            QR("SELECT COUNT(ID_Pelanggan) FROM TBLPelanggan WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%'")
        End If
        JumlahData = DR(0)
        If JumlahData Mod 12 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(JumlahData / 12) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & If(JumlahData <= 12, 1, Math.Ceiling(JumlahData / 12))
        If CurrentPage = 1 Then
            DGVPrev.Enabled = 0
            DGVFirst.Enabled = 0
        Else
            DGVPrev.Enabled = 1
            DGVFirst.Enabled = 1
        End If
        If CurrentPage >= Math.Ceiling(JumlahData / 12) Then
            DGVNext.Enabled = 0
            DGVLast.Enabled = 0
        Else
            DGVNext.Enabled = 1
            DGVLast.Enabled = 1
        End If
    End Sub

    Sub TampilDGV()
        'DGV.DataSource = Nothing
        If TEntitas.SelectedIndex = 0 Then 'Faktur
            QDGV("SELECT Faktur FROM TBLTransaksi WHERE Faktur LIKE '%" & TCariData.Text & "%' ORDER BY Faktur DESC", DGV, FetchData, 12, 0)
        ElseIf TEntitas.SelectedIndex = 1 Then 'Barang
            QDGV("SELECT ID_Barang, Nama, Nama + ' (' + Ukuran + ' ' + Satuan + ')' AS [Daftar Barang] FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' ORDER BY Nama", DGV, FetchData, 12, 0)
            DGV.Columns(0).Visible = 0
            DGV.Columns(1).Visible = 0
        ElseIf TEntitas.SelectedIndex = 2 Then 'Pelanggan
            QDGV("SELECT ID_Pelanggan, Nama AS [Daftar Pelanggan] FROM TBLPelanggan WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' ORDER BY Nama", DGV, FetchData, 12, 0)
            DGV.Columns(0).Visible = 0
        End If
        Paging()
    End Sub

    Private Sub DGVFirst_Click(sender As Object, e As EventArgs) Handles DGVFirst.Click
        FetchData = 0
        CurrentPage = 1
        Paging()
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 12
        DS.Clear()
        If TEntitas.SelectedIndex = 0 Then 'Faktur
            DA = New OleDbDataAdapter("SELECT Faktur FROM TBLTransaksi WHERE Faktur LIKE '%" & TCariData.Text & "%' ORDER BY Faktur DESC", CONN)
        ElseIf TEntitas.SelectedIndex = 1 Then 'Barang
            DA = New OleDbDataAdapter("SELECT ID_Barang, Nama, Nama + ' (' + Ukurang + ' ' + Satuan + ')' AS [Daftar Barang] FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' ORDER BY Nama", CONN)
        ElseIf TEntitas.SelectedIndex = 2 Then 'Pelanggan
            DA = New OleDbDataAdapter("SELECT ID_Pelanggan, Nama AS [Daftar Pelanggan] FROM TBLPelanggan WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' ORDER BY Nama", CONN)
        End If
        DA.Fill(DS, FetchData, 12, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 12
        DS.Clear()
        If TEntitas.SelectedIndex = 0 Then 'Faktur
            DA = New OleDbDataAdapter("SELECT Faktur FROM TBLTransaksi WHERE Faktur LIKE '%" & TCariData.Text & "%' ORDER BY Faktur DESC", CONN)
        ElseIf TEntitas.SelectedIndex = 1 Then 'Barang
            DA = New OleDbDataAdapter("SELECT ID_Barang, Nama, Nama + ' (' + Ukuran + ' ' + Satuan + ')' AS [Daftar Barang] FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' ORDER BY Nama", CONN)
        ElseIf TEntitas.SelectedIndex = 2 Then 'Pelanggan
            DA = New OleDbDataAdapter("SELECT ID_Pelanggan, Nama AS [Daftar Pelanggan] FROM TBLPelanggan WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' ORDER BY Nama", CONN)
        End If
        DA.Fill(DS, FetchData, 12, 0)
        CurrentPage += 1
        Paging()
    End Sub

    Private Sub DGVLast_Click(sender As Object, e As EventArgs) Handles DGVLast.Click
        FetchData = (Math.Ceiling(JumlahData / 12) - 1) * 12 + 1
        CurrentPage = Math.Ceiling(JumlahData / 12)
        Paging()
    End Sub

    Private Sub DGVPageCounter_Click(sender As Object, e As EventArgs) Handles DGVPageCounter.Click
        GoToPageNumber(JumlahData, 12, FetchData, CurrentPage)
        Paging()
    End Sub
#End Region

End Class