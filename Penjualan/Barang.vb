Public Class Barang

    Dim NewData As Boolean
    Dim NamaBarang As String

#Region "Form"
    Sub Notis()
        NewData = 1
        BTNSimpan.Values.Image = ImgSave
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.simpan_default
        TID.Text = 1
        Dim x = 0
        QRL("SELECT ID_Barang FROM TBLBarang ORDER BY ID_Barang ASC")
        Do While DR.Read
            x += 1
            If DR.HasRows Then
                If DR(0) = x Then
                    TID.Text = x + 1
                Else
                    TID.Text = x
                    Exit Sub
                End If
            End If
        Loop
    End Sub

    Sub Clear()
        Notis()
        TBarcode.Clear()
        TNama.Clear()
        TKategori.Clear()
        TUkuran.Clear()
        TSatuan.Clear()
        THarga.Clear()
        TampilDGV()
        TCariData.Clear()
        Tampil()
        TNama.Focus()
    End Sub

    Sub Tampil()
        TSatuan.AutoCompleteCustomSource.Clear()
        TKategori.AutoCompleteCustomSource.Clear()
        QRL("SELECT DISTINCT Satuan FROM TBLBarang")
        Do While DR.Read
            TSatuan.AutoCompleteCustomSource.Add(DR(0))
        Loop
        QRL("SELECT DISTINCT Kategori FROM TBLBarang")
        Do While DR.Read
            TKategori.AutoCompleteCustomSource.Add(DR(0))
        Loop
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletPrimer)
        HakAksesEdit(3, BTNSimpan, BTNHapus)
        Clear()
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles THarga.KeyPress
        If sender.Text = "" And Asc(e.KeyChar) = 48 Then e.Handled = 1
        Angka(e)
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TNama.TextChanged, THarga.TextChanged
        If TNama.Text = "" Or Val(THarga.Text) = 0 Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

    Sub CariID()
        QR("SELECT * FROM TBLBarang WHERE ID_Barang = " & Val(TID.Text))
    End Sub
#End Region

#Region "CRUD"
    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        QR("SELECT Barcode FROM TBLBarang WHERE Barcode = '" & TBarcode.Text & "' AND NOT ID_Barang = " & Val(TID.Text))
        If NewData And Not (TBarcode.Text <> "" AndAlso DR.HasRows) Then
            QN("INSERT INTO TBLBarang VALUES(" & Val(TID.Text) & ",'" & TBarcode.Text & "','" & TNama.Text & "','" & TKategori.Text & "','" & TUkuran.Text & "','" & TSatuan.Text & "'," & THarga.Text & ")")
            Pesan("Barang berhasil ditambah", 1)
        ElseIf Not (TBarcode.Text <> "" AndAlso DR.HasRows) Then
            QN("UPDATE TBLBarang SET Barcode = '" & TBarcode.Text & "', Nama = '" & TNama.Text & "', Kategori = '" & TKategori.Text & "', Ukuran = '" & TUkuran.Text & "', Satuan = '" & TSatuan.Text & "', Harga = " & Val(THarga.Text) & " WHERE ID_Barang = " & Val(TID.Text))
            Pesan("Barang berhasil diubah", 1)
        Else
            Pesan("Barcode sudah terdaftar", 0)
            Exit Sub
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT ID_Barang FROM TBLDetailTransaksi WHERE ID_Barang = " & Val(TID.Text))
        If DR.HasRows Then
            Pesan("Barang pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        If NewData Then
            Pesan("ID Barang tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & NamaBarang & "?", 0)
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLBarang WHERE ID_Barang = " & Val(TID.Text))
                Pesan("Barang berhasil dihapus", 1)
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 1
        CurrentPage = 1
        Clear()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef Msg As Message, Koentji As Keys) As Boolean
        If Koentji = Keys.Enter Then
            BTNSimpan.PerformClick()
            Return True
        ElseIf Koentji = Keys.Escape Then
            BTNHapus.PerformClick()
            Return True
        ElseIf Koentji = Keys.Oemtilde Then
            BTNClear.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(Msg, Koentji)
    End Function
#End Region

#Region "DGV"
    ReadOnly Baris As New Collection
    Dim FetchData As Integer = 1
    Dim CurrentPage As Integer = 1

    Sub Paging()
        DGV.Rows.Clear()
        DGVPageCounter.Text = CurrentPage & " / " & If(Baris.Count <= 13, 1, Math.Ceiling(Baris.Count / 13))
        If CurrentPage = 1 Then
            DGVPrev.Enabled = 0
            DGVFirst.Enabled = 0
        Else
            DGVPrev.Enabled = 1
            DGVFirst.Enabled = 1
        End If
        If CurrentPage >= Math.Ceiling(Baris.Count / 13) Then
            DGVNext.Enabled = 0
            DGVLast.Enabled = 0
        Else
            DGVNext.Enabled = 1
            DGVLast.Enabled = 1
        End If
        If Baris.Count = 0 Then Exit Sub

        If Baris.Count Mod 13 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(Baris.Count / 13) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 12
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4), Baris(x)(5), Baris(x)(6), Baris(x)(7))
            If x = Baris.Count Then Exit For
        Next
    End Sub

    Sub TampilDGV()
        Baris.Clear()
        QRL("SELECT ID_Barang, Barcode, Nama, Kategori, Ukuran, Satuan, Harga FROM TBLBarang WHERE Barcode LIKE '%" & TCariData.Text & "%' OR Nama LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Ukuran LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' ORDER BY Nama")
        Do While DR.Read
            Baris.Add({DR(0), Baris.Count + 1, DR(1), DR(2), DR(3), DR(4), DR(5), DR(6)})
        Loop
        Paging()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FetchData = 1
        CurrentPage = 1
        TampilDGV()
        Timer1.Stop()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        NewData = 0
        TID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CariID()
        TBarcode.Text = DR(1)
        NamaBarang = DR(2)
        TNama.Text = DR(2)
        TKategori.Text = DR(3)
        TUkuran.Text = DR(4)
        TSatuan.Text = DR(5)
        THarga.Text = DR(6)
        BTNSimpan.Values.Image = ImgEdit
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.edit_default
    End Sub

    Private Sub DGVFirst_Click(sender As Object, e As EventArgs) Handles DGVFirst.Click
        FetchData = 1
        CurrentPage = 1
        Paging()
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 13
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 13
        CurrentPage += 1
        Paging()
    End Sub

    Private Sub DGVLast_Click(sender As Object, e As EventArgs) Handles DGVLast.Click
        FetchData = (Math.Ceiling(Baris.Count / 13) - 1) * 13 + 1
        CurrentPage = Math.Ceiling(Baris.Count / 13)
        Paging()
    End Sub

    Private Sub DGVPageCounter_Click(sender As Object, e As EventArgs) Handles DGVPageCounter.Click
        GoToPageNumber(Baris.Count, 13, FetchData, CurrentPage)
        Paging()
    End Sub
#End Region

End Class