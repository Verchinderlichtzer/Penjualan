Imports USB_Barcode_Scanner

Public Class Transaksi

    Dim TglTransaksi As Date = Today
    Dim TotalHarga, Terbayar, Sisa, Balance As Integer
    WithEvents BCScanner As USB_Barcode_Scanner.BarcodeScanner

#Region "Form"
    Sub TampilFaktur()
        TFaktur.Items.Clear()
        QR("SELECT Faktur FROM TBLTransaksi ORDER BY Faktur DESC")
        If DR.HasRows AndAlso Mid(DR(0), 2, 6) = Format(Today, "yyMMdd") Then TFaktur.Items.Add("T" & Microsoft.VisualBasic.Right(DR(0), 8) + 1) Else TFaktur.Items.Add("T" & Format(Today, "yyMMdd") & "01")
        QRL("SELECT Faktur FROM TBLTransaksi WHERE Total > Terbayar ORDER BY Faktur DESC")
        Do While DR.Read
            TFaktur.Items.Add(DR(0))
        Loop
        TFaktur.SelectedIndex = 0
    End Sub

    Sub TampilPelanggan()
        TPelanggan.Items.Clear()
        QRL("SELECT ID_Pelanggan, Nama FROM TBLPelanggan ORDER BY Nama")
        Do While DR.Read
            TPelanggan.Items.Add(DR(0) & " - " & DR(1))
        Loop
    End Sub

    Sub Clear()
        TPelanggan.SelectedIndex = -1
        TCariData.Clear()
        TglTransaksi = Today
        TotalHarga = 0
        Terbayar = 0
        Sisa = 0
        Balance = 0
        TDibayar.Clear()

        Baris.Clear()
        BarisBarang.Clear()
        FetchData = 1
        CurrentPage = 1
        FetchDataBarang = 1
        CurrentPageBarang = 1
        Paging()
        PagingBarang()

        Hitung()
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles TDibayar.KeyPress
        If (sender.Text = "" And Asc(e.KeyChar) = 48) Or TotalHarga = 0 Then e.Handled = 1
        Angka(e)
    End Sub

    Sub Validasi()
        If TPelanggan.SelectedIndex = -1 Or Baris.Count = 0 Or (TFaktur.SelectedIndex > 0 And Val(TDibayar.Text) = 0) Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletPrimer)
        TampilFaktur()
        BCScanner = New BarcodeScanner(DGV)
        QRL("SELECT ID_Pelanggan, Nama FROM TBLPelanggan ORDER BY Nama")
        Do While DR.Read
            TPelanggan.Items.Add(DR(0) & " - " & DR(1))
        Loop
    End Sub

    Private Sub BCScanner_BarcodeScanned(sender As Object, e As BarcodeScannerEventArgs) Handles BCScanner.BarcodeScanned
        For Each x In Baris
            If x(1) = e.Barcode Then
                Pesan("Barang sudah terdaftar", 0)
                Exit Sub
            End If
        Next
        QR("SELECT ID_Barang, Nama, Ukuran + ' ' + Satuan, Harga FROM TBLBarang WHERE Barcode = '" & e.Barcode & "'")
        Baris.Add({DR(0), e.Barcode, DR(1), 1, DR(2), DR(3), DR(3)})
        If CurrentPage = Math.Ceiling(Baris.Count / 16) And DGV.Rows.Count < 16 Then
            DGV.Rows.Add(DR(0), e.Barcode, DR(1), 1, DR(2), DR(3), DR(3))
        End If
        Hitung()
        Paging()
        Validasi()
    End Sub

    Private Sub TFaktur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TFaktur.SelectedIndexChanged
        Clear()
        If TFaktur.SelectedIndex > 0 Then
            QRL("SELECT TBLTransaksi.ID_Pelanggan, TBLPelanggan.Nama, TBLDetailTransaksi.ID_Barang, Barcode, TBLBarang.Nama, Qty, Ukuran + ' ' + Satuan, TBLDetailTransaksi.Harga, Tanggal, Terbayar FROM TBLPelanggan INNER JOIN (TBLBarang INNER JOIN (TBLTransaksi INNER JOIN TBLDetailTransaksi ON TBLTransaksi.Faktur = TBLDetailTransaksi.Faktur) ON TBLBarang.ID_Barang = TBLDetailTransaksi.ID_Barang) ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE TBLTransaksi.Faktur = '" & TFaktur.SelectedItem & "'")
            Locked = 1
            Do While DR.Read
                Baris.Add({DR(2), DR(3), DR(4), DR(5), DR(6), DR(7), DR(5) * DR(7)})
                If Terbayar > 0 Then Continue Do
                TPelanggan.SelectedItem = DR(0) & " - " & DR(1)
                TglTransaksi = DR(8)
                Terbayar = DR(9)
            Loop
            Locked = 0
            LBLTerbayar.Visible = 1
            TTerbayar.Visible = 1
            LBLSisa.Visible = 1
            TSisa.Visible = 1
            TPelanggan.Enabled = 0
            BTNSimpan.Values.Image = ImgEdit
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.edit_default
        Else 'Baru
            LBLTerbayar.Visible = 0
            TTerbayar.Visible = 0
            LBLSisa.Visible = 0
            TSisa.Visible = 0
            TPelanggan.Enabled = 1
            BTNSimpan.Values.Image = ImgSave
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.simpan_default
        End If
        Paging()
        Hitung()
        Validasi()
    End Sub

    Private Sub TPelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TPelanggan.SelectedIndexChanged
        If TPelanggan.SelectedIndex = -1 Or Locked Then Exit Sub
        TampilDGVBarang()
        Validasi()
    End Sub

    Sub Hitung()
        TotalHarga = 0
        For Each x In Baris
            TotalHarga += x(6)
        Next
        Sisa = TotalHarga - Terbayar
        Balance = Math.Abs(If(Terbayar > 0, Val(TDibayar.Text) - Sisa, Val(TDibayar.Text) - TotalHarga))
        If TFaktur.SelectedIndex = 0 And TotalHarga > Val(TDibayar.Text) Then
            LBLBalance.Text = "Sisa :"
        ElseIf TFaktur.SelectedIndex > 0 And TotalHarga > Val(TDibayar.Text) Then
            LBLBalance.Text = "Kurang :"
        ElseIf TotalHarga < Val(TDibayar.Text) Then
            LBLBalance.Text = "Kembali :"
        End If
        If TotalHarga = Val(TDibayar.Text) Or Val(TDibayar.Text) = 0 Then
            LBLBalance.Visible = 0
            TBalance.Visible = 0
        Else
            LBLBalance.Visible = 1
            TBalance.Visible = 1
        End If
        'Isi
        TTglTransaksi.Text = Format(TglTransaksi, "dd-MM-yyyy")
        TTotalHarga.Text = Format(TotalHarga, "#,##0")
        TTerbayar.Text = Format(Terbayar, "#,##0")
        TSisa.Text = Format(Sisa, "#,##0")
        TBalance.Text = Format(Balance, "#,##0")
    End Sub

    Private Sub TDibayar_TextChanged(sender As Object, e As EventArgs) Handles TDibayar.TextChanged
        Hitung()
        Validasi()
    End Sub
#End Region

#Region "CRUD"
    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If TFaktur.SelectedIndex = 0 Then
            QN("INSERT INTO TBLTransaksi VALUES('" & TFaktur.SelectedItem & "'," & TPelanggan.SelectedItem.Substring(0, TPelanggan.SelectedItem.IndexOf(" ")) & ",DATE()," & TotalHarga & "," & If(TotalHarga > Val(TDibayar.Text), Val(TDibayar.Text), TotalHarga) & ",'" & UserAktif & "')")
            For Each x In Baris
                QN("INSERT INTO TBLDetailTransaksi VALUES('" & TFaktur.SelectedItem & "'," & x(0) & "," & x(3) & "," & x(5) & ")")
            Next
            If Val(TDibayar.Text) > 0 Then QN("INSERT INTO TBLBayar VALUES('" & TFaktur.SelectedItem & "',DATE()," & If(Sisa > Val(TDibayar.Text), Val(TDibayar.Text), Sisa) & ")")
        Else
            QN("UPDATE TBLTransaksi SET Terbayar " & If(Sisa > Val(TDibayar.Text), "= Terbayar + " & Val(TDibayar.Text), "= " & TotalHarga) & " WHERE Faktur = '" & TFaktur.SelectedItem & "'")
            QN("INSERT INTO TBLBayar VALUES('" & TFaktur.SelectedItem & "',DATE()," & If(Sisa > Val(TDibayar.Text), Val(TDibayar.Text), Sisa) & ")")
        End If
        'Dim Confirm As New Konfirmasi("Cetak Struk", "Transaksi berhasil, cetak struknya?", 0)
        'If Confirm.ShowDialog() = DialogResult.Yes Then

        'End If
        Pesan("Transaksi berhasil", 1)
        TampilFaktur()
        Clear()
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        Clear()
    End Sub
#End Region

#Region "DGVBarang"
    ReadOnly BarisBarang As New Collection
    Dim FetchDataBarang As Integer = 1
    Dim CurrentPageBarang As Integer = 1

    Sub PagingBarang()
        DGVBarang.Rows.Clear()
        DGVBarangPageCounter.Text = CurrentPageBarang & " / " & If(BarisBarang.Count <= 16, 1, Math.Ceiling(BarisBarang.Count / 16))
        If CurrentPageBarang = 1 Then
            DGVBarangPrev.Enabled = 0
            DGVBarangFirst.Enabled = 0
        Else
            DGVBarangPrev.Enabled = 1
            DGVBarangFirst.Enabled = 1
        End If
        If CurrentPageBarang >= Math.Ceiling(BarisBarang.Count / 16) Then
            DGVBarangNext.Enabled = 0
            DGVBarangLast.Enabled = 0
        Else
            DGVBarangNext.Enabled = 1
            DGVBarangLast.Enabled = 1
        End If
        If BarisBarang.Count = 0 Then Exit Sub

        If BarisBarang.Count Mod 16 = 0 And CurrentPageBarang > 1 And CurrentPageBarang = Math.Ceiling(BarisBarang.Count / 16) + 1 Then DGVBarangPrev.PerformClick()
        For x = FetchDataBarang To FetchDataBarang + 15
            DGVBarang.Rows.Add(BarisBarang(x)(0), BarisBarang(x)(1), BarisBarang(x)(2), BarisBarang(x)(3), BarisBarang(x)(4), BarisBarang(x)(5))
            If x = BarisBarang.Count Then Exit For
        Next
    End Sub

    Sub TampilDGVBarang()
        BarisBarang.Clear()
        If TFaktur.SelectedIndex > 0 Then Exit Sub
        QRL("SELECT ID_Barang, Barcode, Nama, Ukuran + ' ' + Satuan, Harga, Nama + ' (' + Ukuran + ' ' + Satuan + ')' FROM TBLBarang WHERE Barcode LIKE '%" & TCariData.Text & "%' OR Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' ORDER BY Nama")
        Do While DR.Read
            BarisBarang.Add({DR(0), DR(1), DR(2), DR(3), DR(4), DR(5)})
        Loop
        PagingBarang()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        If TPelanggan.SelectedIndex = -1 Then Exit Sub
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FetchDataBarang = 1
        CurrentPageBarang = 1
        TampilDGVBarang()
        Timer1.Stop()
    End Sub

    Private Sub DGVBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVBarang.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        For Each x In Baris
            If x(0) = DGVBarang.Rows(e.RowIndex).Cells(0).Value Then
                Pesan("Barang sudah dipilih", 0)
                Exit Sub
            End If
        Next
        Baris.Add({DGVBarang.Rows(e.RowIndex).Cells(0).Value, DGVBarang.Rows(e.RowIndex).Cells(1).Value, DGVBarang.Rows(e.RowIndex).Cells(2).Value, 1, DGVBarang.Rows(e.RowIndex).Cells(3).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value})
        If CurrentPage = Math.Ceiling(Baris.Count / 16) And DGV.Rows.Count < 16 Then
            DGV.Rows.Add(DGVBarang.Rows(e.RowIndex).Cells(0).Value, DGVBarang.Rows(e.RowIndex).Cells(1).Value, DGVBarang.Rows(e.RowIndex).Cells(2).Value, 1, DGVBarang.Rows(e.RowIndex).Cells(3).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value)
        End If
        Hitung()
        Paging()
        Validasi()
    End Sub

    Private Sub DGVBarangFirst_Click(sender As Object, e As EventArgs) Handles DGVBarangFirst.Click
        FetchDataBarang = 1
        CurrentPageBarang = 1
        PagingBarang()
    End Sub

    Private Sub DGVBarangPrev_Click(sender As Object, e As EventArgs) Handles DGVBarangPrev.Click
        FetchDataBarang -= 16
        CurrentPageBarang -= 1
        PagingBarang()
    End Sub

    Private Sub DGVBarangNext_Click(sender As Object, e As EventArgs) Handles DGVBarangNext.Click
        FetchDataBarang += 16
        CurrentPageBarang += 1
        PagingBarang()
    End Sub

    Private Sub DGVBarangLast_Click(sender As Object, e As EventArgs) Handles DGVBarangLast.Click
        FetchDataBarang = (Math.Ceiling(BarisBarang.Count / 16) - 1) * 16 + 1
        CurrentPageBarang = Math.Ceiling(BarisBarang.Count / 16)
        PagingBarang()
    End Sub

    Private Sub DGVBarangPageCounter_Click(sender As Object, e As EventArgs) Handles DGVBarangPageCounter.Click
        GoToPageNumber(BarisBarang.Count, 16, FetchDataBarang, CurrentPageBarang)
        PagingBarang()
    End Sub
#End Region

#Region "DGV"
    ReadOnly Baris As New Collection
    Dim FetchData As Integer = 1
    Dim CurrentPage As Integer = 1

    Sub Paging()
        DGV.Rows.Clear()
        DGVPageCounter.Text = CurrentPage & " / " & If(Baris.Count <= 16, 1, Math.Ceiling(Baris.Count / 16))
        If CurrentPage = 1 Then
            DGVPrev.Enabled = 0
            DGVFirst.Enabled = 0
        Else
            DGVPrev.Enabled = 1
            DGVFirst.Enabled = 1
        End If
        If CurrentPage >= Math.Ceiling(Baris.Count / 16) Then
            DGVNext.Enabled = 0
            DGVLast.Enabled = 0
        Else
            DGVNext.Enabled = 1
            DGVLast.Enabled = 1
        End If
        If Baris.Count = 0 Then Exit Sub

        If Baris.Count Mod 16 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(Baris.Count / 16) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 15
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4), Baris(x)(5), Baris(x)(6))
            If x = Baris.Count Then Exit For
        Next
    End Sub

    Private Sub DGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        Dim Angka As TextBox = CType(e.Control, TextBox)
        AddHandler Angka.KeyPress, AddressOf Angka_KeyPress
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If DGV.CurrentCell.Value <= 0 Then
            DGV.CurrentCell.Value = 1
            Exit Sub
        End If
        If e.ColumnIndex = 5 Then DGV.Rows(e.RowIndex).Cells(5).Value = Format(Val(DGV.Rows(e.RowIndex).Cells(5).Value.ToString.Replace("."c, "")), "#,##0")
        DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(3).Value * Val(DGV.Rows(e.RowIndex).Cells(5).Value.ToString.Replace("."c, ""))
        Baris((CurrentPage - 1) * 16 + DGV.CurrentCellAddress.Y + 1)(DGV.CurrentCellAddress.X) = Val(DGV.CurrentCell.Value.ToString.Replace("."c, ""))
        Baris((CurrentPage - 1) * 16 + DGV.CurrentCellAddress.Y + 1)(6) = DGV.Rows(e.RowIndex).Cells(6).Value
        Hitung()
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If Asc(e.KeyChar) = 27 Then Baris.Remove((CurrentPage - 1) * 16 + DGV.CurrentRow.Index + 1)
        Hitung()
        Validasi()
        Paging()
    End Sub

    Private Sub DGVFirst_Click(sender As Object, e As EventArgs) Handles DGVFirst.Click
        FetchData = 1
        CurrentPage = 1
        Paging()
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 16
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 16
        CurrentPage += 1
        Paging()
    End Sub

    Private Sub DGVLast_Click(sender As Object, e As EventArgs) Handles DGVLast.Click
        FetchData = (Math.Ceiling(Baris.Count / 16) - 1) * 16 + 1
        CurrentPage = Math.Ceiling(Baris.Count / 16)
        Paging()
    End Sub

    Private Sub DGVPageCounter_Click(sender As Object, e As EventArgs) Handles DGVPageCounter.Click
        GoToPageNumber(Baris.Count, 16, FetchData, CurrentPage)
        Paging()
    End Sub
#End Region

End Class