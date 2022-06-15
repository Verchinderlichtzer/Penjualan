Public Class Catatan

    Dim QueryKiri, QueryTanggal, QueryLunas, QueryOrder, QueryKanan As String
    Dim FilterEntitas, FilterTanggal, FilterStatus, FilterDetail As String
    Dim EntitasTerpilih As Object

#Region "Form"
    Private Sub Catatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletSekunder)
        TDari.Value = Today
        TSampai.Value = Today
        QRL("SELECT Faktur, Tanggal, Nama FROM TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan ORDER BY Faktur DESC")
        Do While DR.Read
            TFaktur.Items.Add(DR(0) & " - " & Format(DR(1), "dd/MM/yyyy") & " - " & DR(2))
        Loop
        QRL("SELECT ID_Barang, Nama, Ukuran, Satuan FROM TBLBarang ORDER BY Nama")
        Do While DR.Read
            TBarang.Items.Add(DR(0) & " - " & DR(1) & " (" & DR(2) & " " & DR(3) & ")")
        Loop
        QRL("SELECT ID_Pelanggan, Nama FROM TBLPelanggan ORDER BY Nama")
        Do While DR.Read
            TPelanggan.Items.Add(DR(0) & " - " & DR(1))
        Loop
    End Sub

    Sub Filter()
        If EntitasTerpilih Is TFaktur Then
            LBLFilterKiri.Text = FilterEntitas
        Else
            LBLFilterKiri.Text = FilterEntitas & FilterTanggal & FilterStatus
        End If
        LBLFilterKanan.Text = FilterDetail
    End Sub

    Private Sub TEntitas(sender As Object, e As EventArgs) Handles TFaktur.SelectedIndexChanged, TBarang.SelectedIndexChanged, TPelanggan.SelectedIndexChanged
        If TFaktur.SelectedIndex = -1 And TBarang.SelectedIndex = -1 And TPelanggan.SelectedIndex = -1 Then Exit Sub
        EntitasTerpilih = sender
        Locked = 1
        If sender Is TFaktur Then
            CBTanggalTransaksi.Enabled = 0
            CBTanggalTransaksi.Checked = 0
            CBSudah.Enabled = 0
            CBSudah.Checked = 0
            CBBelum.Enabled = 0
            CBBelum.Checked = 0
            TDari.Enabled = 0
            TSampai.Enabled = 0
        Else
            CBTanggalTransaksi.Enabled = 1
            CBSudah.Enabled = 1
            CBBelum.Enabled = 1
        End If
        Locked = 0
        QueryKanan = Nothing
        FilterEntitas = Nothing
        FilterDetail = Nothing
        If sender Is TFaktur Then
            QueryKiri = "SELECT FORMAT(Tanggal, 'dd-MM-yyyy') AS Tanggal, Nominal FROM TBLBayar WHERE Faktur = '" & Strings.Left(sender.SelectedItem, 9) & "'"
            QueryOrder = " ORDER BY Tanggal DESC"
            QueryKanan = "SELECT Nama AS [Nama Barang], Ukuran + ' ' + Satuan AS Satuan, Qty, TBLDetailTransaksi.Harga, Qty * TBLDetailTransaksi.Harga AS Total FROM TBLBarang INNER JOIN TBLDetailTransaksi ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang WHERE Faktur = '" & Strings.Left(sender.SelectedItem, 9) & "'"
            FilterEntitas = "Tanggal pembayaran pada faktur " & Strings.Left(sender.SelectedItem, 9) & " dan detail barangnya"
        ElseIf sender Is TBarang Then
            QueryKiri = "SELECT TBLTransaksi.Faktur, FORMAT(Tanggal, 'dd-MM-yyyy') AS Tanggal, Nama AS [Nama Pelanggan], Qty FROM TBLPelanggan INNER JOIN (TBLTransaksi INNER JOIN TBLDetailTransaksi ON TBLTransaksi.Faktur = TBLDetailTransaksi.Faktur) ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE ID_Barang = " & Val(sender.SelectedItem.Substring(0, sender.SelectedItem.IndexOf(" ")))
            QueryOrder = " ORDER BY TBLTransaksi.Faktur DESC"
            FilterEntitas = "Transaksi pada " & sender.SelectedItem.Substring(sender.SelectedItem.IndexOf("-") + 2)
        Else
            QueryKiri = "SELECT Faktur, FORMAT(Tanggal, 'dd-MM-yyyy') AS Tanggal, Total, Terbayar FROM TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE TBLTransaksi.ID_Pelanggan = " & Val(sender.SelectedItem.Substring(0, sender.SelectedItem.IndexOf(" ")))
            QueryOrder = " ORDER BY Faktur DESC"
            FilterEntitas = "Transaksi yang dilakukan oleh " & sender.SelectedItem.Substring(sender.SelectedItem.IndexOf("-") + 2)
        End If
        Filter()
        TampilDGVKiri()
        TampilDGVKanan()
    End Sub

    Private Sub DTPTanggalTransaksi(sender As Object, e As EventArgs) Handles CBTanggalTransaksi.CheckedChanged, TDari.ValueChanged, TSampai.ValueChanged
        If EntitasTerpilih Is TFaktur Or Locked Then Exit Sub
        QueryTanggal = Nothing
        QueryKanan = Nothing
        FilterTanggal = Nothing
        FilterDetail = Nothing
        If sender Is TDari And TDari.Value > TSampai.Value Then
            TSampai.Value = TDari.Value
        ElseIf sender Is TSampai And TSampai.Value < TDari.Value Then
            TDari.Value = TSampai.Value
        End If
        If CBTanggalTransaksi.Checked = False Then
            TDari.Enabled = 0
            TSampai.Enabled = 0
            GoTo 1
        Else
            TDari.Enabled = 1
            TSampai.Enabled = 1
        End If
        If FilterEntitas = Nothing Then Exit Sub
        QueryTanggal = " AND (Tanggal BETWEEN #" & Format(TDari.Value, "M/d/yyyy") & "# AND #" & Format(TSampai.Value, "M/d/yyyy") & "#)"
        If TDari.Value = TSampai.Value Then
            FilterTanggal = " yang terjadi pada tanggal " & Format(TDari.Value, "dd-MM-yyyy")
        Else
            FilterTanggal = " yang terjadi antara tanggal " & Format(TDari.Value, "dd-MM-yyyy") & " sampai " & Format(TSampai.Value, "dd-MM-yyyy")
        End If
1:      Filter()
        TampilDGVKiri()
        TampilDGVKanan()
    End Sub

    Private Sub CBLunas(sender As Object, e As EventArgs) Handles CBSudah.CheckedChanged, CBBelum.CheckedChanged
        If EntitasTerpilih Is TFaktur Then Exit Sub
        QueryLunas = Nothing
        QueryKanan = Nothing
        FilterStatus = Nothing
        FilterDetail = Nothing
        If CBSudah.Checked = True And CBBelum.Checked = False Then
            QueryLunas = " AND Total = Terbayar"
            FilterStatus = " yang sudah lunas"
        ElseIf CBSudah.Checked = False And CBBelum.Checked = True Then
            QueryLunas = " AND Total > Terbayar"
            FilterStatus = " yang belum lunas"
        End If
        Filter()
        TampilDGVKiri()
        TampilDGVKanan()
    End Sub
#End Region

#Region "DGVKiri"
    Dim FetchDataKiri As Integer
    Dim JumlahDataKiri As Integer
    Dim CurrentPageKiri As Integer = 1

    Sub PagingKiri()
        QR(Replace(QueryKiri & If(EntitasTerpilih Is TFaktur, Nothing, QueryTanggal & QueryLunas), QueryKiri.Substring(7, QueryKiri.IndexOf("FROM") - 8), "COUNT(*)"))
        JumlahDataKiri = DR(0)
        If JumlahDataKiri Mod 14 = 0 And CurrentPageKiri > 1 And CurrentPageKiri = Math.Ceiling(JumlahDataKiri / 14) + 1 Then DGVKiriPrev.PerformClick()
        DGVKiriPageCounter.Text = CurrentPageKiri & " / " & If(JumlahDataKiri <= 14, 1, Math.Ceiling(JumlahDataKiri / 14))
        If CurrentPageKiri = 1 Then
            DGVKiriPrev.Enabled = 0
            DGVKiriFirst.Enabled = 0
        Else
            DGVKiriPrev.Enabled = 1
            DGVKiriFirst.Enabled = 1
        End If
        If CurrentPageKiri >= Math.Ceiling(JumlahDataKiri / 14) Then
            DGVKiriNext.Enabled = 0
            DGVKiriLast.Enabled = 0
        Else
            DGVKiriNext.Enabled = 1
            DGVKiriLast.Enabled = 1
        End If
        If EntitasTerpilih Is TPelanggan Then
            For Each Style In DGVKiri.Rows
                If Style.Cells(3).Value < Style.Cells(2).Value Then
                    Style.Cells(3).Style.ForeColor = Color.FromArgb(220, 53, 69)
                    Style.Cells(3).Style.SelectionForeColor = Color.FromArgb(220, 53, 69)
                End If
            Next
        End If
    End Sub

    Sub TampilDGVKiri()
        If QueryKiri = Nothing Then
            DGVKiri.Visible = 0
            Exit Sub
        Else
            DGVKiri.Visible = 1
        End If
        FetchDataKiri = 0
        CurrentPageKiri = 1
        QDGV(QueryKiri & If(EntitasTerpilih Is TFaktur, Nothing, QueryTanggal & QueryLunas) & QueryOrder, DGVKiri, FetchDataKiri, 14, 0)
        PagingKiri()
        If EntitasTerpilih Is TBarang Then
            Dim Lebar() As Integer = {107, 107, 184, 43}
            Dim I = 0
            For Each Kolom In DGVKiri.Columns
                Kolom.SortMode = DataGridViewColumnSortMode.NotSortable
                Kolom.Width = Lebar(I)
                I += 1
            Next
            DGVKiri.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVKiri.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ElseIf EntitasTerpilih Is TFaktur Then
            DGVKiri.Columns(1).DefaultCellStyle.Format = "#,##0"
            DGVKiri.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGVKiri.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DGVKiri.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        ElseIf EntitasTerpilih Is TPelanggan Then
            DGVKiri.Columns(2).DefaultCellStyle.Format = "#,##0"
            DGVKiri.Columns(3).DefaultCellStyle.Format = "#,##0"
            DGVKiri.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVKiri.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGVKiri.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGVKiri.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DGVKiri.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            DGVKiri.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            DGVKiri.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        End If
        DGVKiri.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub DGVKiriFirst_Click(sender As Object, e As EventArgs) Handles DGVKiriFirst.Click
        FetchDataKiri = 0
        CurrentPageKiri = 1
        PagingKiri()
    End Sub

    Private Sub DGVKiriPrevClick(sender As Object, e As EventArgs) Handles DGVKiriPrev.Click
        FetchDataKiri -= 14
        DS.Clear()
        DA.Fill(DS, FetchDataKiri, 14, 0)
        CurrentPageKiri -= 1
        PagingKiri()
    End Sub

    Private Sub DGVKiriNextClick(sender As Object, e As EventArgs) Handles DGVKiriNext.Click
        FetchDataKiri += 14
        DS.Clear()
        DA.Fill(DS, FetchDataKiri, 14, 0)
        CurrentPageKiri += 1
        PagingKiri()
    End Sub

    Private Sub DGVKiriLast_Click(sender As Object, e As EventArgs) Handles DGVKiriLast.Click
        FetchDataKiri = (Math.Ceiling(JumlahDataKiri / 14) - 1) * 14 + 1
        CurrentPageKiri = Math.Ceiling(JumlahDataKiri / 14)
        PagingKiri()
    End Sub

    Private Sub DGVKiri_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVKiri.CellMouseClick
        If e.RowIndex < 0 Or EntitasTerpilih Is TFaktur Then Exit Sub
        QueryKanan = "SELECT Nama AS [Nama Barang], Ukuran + ' ' + Satuan AS Satuan, Qty, TBLDetailTransaksi.Harga, Qty * TBLDetailTransaksi.Harga AS Total FROM TBLBarang INNER JOIN TBLDetailTransaksi ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang WHERE Faktur = '" & DGVKiri.Rows(e.RowIndex).Cells(0).Value & "'"
        FilterDetail = "Detail barang pada faktur " & DGVKiri.Rows(e.RowIndex).Cells(0).Value
        Filter()
        TampilDGVKanan()
    End Sub

    Private Sub DGVKiriPageCounter_Click(sender As Object, e As EventArgs) Handles DGVKiriPageCounter.Click
        GoToPageNumber(JumlahDataKiri, 14, FetchDataKiri, CurrentPageKiri)
        PagingKiri()
    End Sub
#End Region

#Region "DGVKanan"
    Dim FetchDataKanan As Integer
    Dim JumlahDataKanan As Integer
    Dim CurrentPageKanan As Integer = 1

    Sub PagingKanan()
        QR(Replace(QueryKanan, QueryKanan.Substring(7, QueryKanan.IndexOf("FROM") - 8), "COUNT(*)"))
        JumlahDataKanan = DR(0)
        If JumlahDataKanan Mod 14 = 0 And CurrentPageKanan > 1 And CurrentPageKanan = Math.Ceiling(JumlahDataKanan / 14) + 1 Then DGVKananPrev.PerformClick()
        DGVKananPageCounter.Text = CurrentPageKanan & " / " & If(JumlahDataKanan <= 14, 1, Math.Ceiling(JumlahDataKanan / 14))
        If CurrentPageKanan = 1 Then
            DGVKananPrev.Enabled = 0
            DGVKananFirst.Enabled = 0
        Else
            DGVKananPrev.Enabled = 1
            DGVKananFirst.Enabled = 1
        End If
        If CurrentPageKanan >= Math.Ceiling(JumlahDataKanan / 14) Then
            DGVKananNext.Enabled = 0
            DGVKananLast.Enabled = 0
        Else
            DGVKananNext.Enabled = 1
            DGVKananLast.Enabled = 1
        End If
    End Sub

    Sub TampilDGVKanan()
        If QueryKanan = Nothing Then
            DGVKanan.Visible = 0
            Exit Sub
        Else
            DGVKanan.Visible = 1
        End If
        FetchDataKanan = 0
        CurrentPageKanan = 1
        QDGV2(QueryKanan & " ORDER BY Nama", DGVKanan, FetchDataKanan, 14, 0)
        PagingKanan()
        Dim Lebar() As Integer = {294, 109, 43, 100, 100}
        Dim I = 0
        For Each Kolom In DGVKanan.Columns
            Kolom.SortMode = DataGridViewColumnSortMode.NotSortable
            Kolom.Width = Lebar(I)
            I += 1
        Next
        DGVKanan.Columns(3).DefaultCellStyle.Format = "#,##0"
        DGVKanan.Columns(4).DefaultCellStyle.Format = "#,##0"
        DGVKanan.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGVKanan.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGVKanan.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVKanan.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub DGVKananFirst_Click(sender As Object, e As EventArgs) Handles DGVKananFirst.Click
        FetchDataKanan = 0
        CurrentPageKanan = 1
        PagingKanan()
    End Sub

    Private Sub DGVKananPrevClick(sender As Object, e As EventArgs) Handles DGVKananPrev.Click
        FetchDataKanan -= 14
        DS2.Clear()
        DA.Fill(DS2, FetchDataKanan, 14, 0)
        CurrentPageKanan -= 1
        PagingKanan()
    End Sub

    Private Sub DGVKananNextClick(sender As Object, e As EventArgs) Handles DGVKananNext.Click
        FetchDataKanan += 14
        DS2.Clear()
        DA.Fill(DS2, FetchDataKanan, 14, 0)
        CurrentPageKanan += 1
        PagingKanan()
    End Sub

    Private Sub DGVKananLast_Click(sender As Object, e As EventArgs) Handles DGVKananLast.Click
        FetchDataKanan = (Math.Ceiling(JumlahDataKanan / 14) - 1) * 14 + 1
        CurrentPageKanan = Math.Ceiling(JumlahDataKanan / 14)
        PagingKanan()
    End Sub

    Private Sub DGVKananPageCounter_Click(sender As Object, e As EventArgs) Handles DGVKananPageCounter.Click
        GoToPageNumber(JumlahDataKanan, 14, FetchDataKanan, CurrentPageKanan)
        PagingKanan()
    End Sub
#End Region

End Class