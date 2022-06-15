Public Class Pelanggan

    Dim NewData As Boolean
    Dim NamaPelanggan As String

#Region "Form"
    Sub Notis()
        NewData = 1
        BTNSimpan.Values.Image = ImgSave
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.simpan_default
        TID.Text = 1
        Dim x = 0
        QRL("SELECT ID_Pelanggan FROM TBLPelanggan ORDER BY ID_Pelanggan ASC")
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
        TNama.Clear()
        TAlamat.Clear()
        TTelepon.Clear()
        TampilDGV()
        TCariData.Clear()
        TNama.Focus()
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletPrimer)
        HakAksesEdit(4, BTNSimpan, BTNHapus)
        Clear()
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TNama.TextChanged
        If TNama.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

    Sub CariID()
        QR("SELECT * FROM TBLPelanggan WHERE ID_Pelanggan = " & Val(TID.Text))
    End Sub
#End Region

#Region "CRUD"
    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If NewData Then
            QN("INSERT INTO TBLPelanggan VALUES(" & Val(TID.Text) & ",'" & TNama.Text & "','" & TAlamat.Text & "','" & TTelepon.Text & "')")
            Pesan("Pelanggan berhasil ditambah", 1)
        Else
            QN("UPDATE TBLPelanggan SET Nama = '" & TNama.Text & "', Alamat = '" & TAlamat.Text & "', Telepon = '" & TTelepon.Text & "' WHERE ID_Pelanggan = " & Val(TID.Text))
            Pesan("Pelanggan berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT ID_Pelanggan FROM TBLTransaksi WHERE ID_Pelanggan = " & Val(TID.Text))
        If DR.HasRows Then
            Pesan("Pelanggan pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        If NewData Then
            Pesan("ID Pelanggan tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & NamaPelanggan & "?", 0)
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLPelanggan WHERE ID_Pelanggan = " & Val(TID.Text))
                Pesan("Pelanggan berhasil dihapus", 1)
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
        DGVPageCounter.Text = CurrentPage & " / " & If(Baris.Count <= 14, 1, Math.Ceiling(Baris.Count / 14))
        If CurrentPage = 1 Then
            DGVPrev.Enabled = 0
            DGVFirst.Enabled = 0
        Else
            DGVPrev.Enabled = 1
            DGVFirst.Enabled = 1
        End If
        If CurrentPage >= Math.Ceiling(Baris.Count / 14) Then
            DGVNext.Enabled = 0
            DGVLast.Enabled = 0
        Else
            DGVNext.Enabled = 1
            DGVLast.Enabled = 1
        End If
        If Baris.Count = 0 Then Exit Sub

        If Baris.Count Mod 14 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(Baris.Count / 14) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 13
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4))
            If x = Baris.Count Then Exit For
        Next
    End Sub

    Sub TampilDGV()
        Baris.Clear()
        QRL("SELECT ID_Pelanggan, Nama, Alamat, Telepon FROM TBLPelanggan WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' ORDER BY Nama")
        Do While DR.Read
            Baris.Add({DR(0), Baris.Count + 1, DR(1), DR(2), DR(3)})
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
        NamaPelanggan = DR(1)
        TNama.Text = DR(1)
        TAlamat.Text = DR(2)
        TTelepon.Text = DR(3)
        BTNSimpan.Values.Image = ImgEdit
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.edit_default
    End Sub

    Private Sub DGVFirst_Click(sender As Object, e As EventArgs) Handles DGVFirst.Click
        FetchData = 1
        CurrentPage = 1
        Paging()
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 14
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 14
        CurrentPage += 1
        Paging()
    End Sub

    Private Sub DGVLast_Click(sender As Object, e As EventArgs) Handles DGVLast.Click
        FetchData = (Math.Ceiling(Baris.Count / 14) - 1) * 14 + 1
        CurrentPage = Math.Ceiling(Baris.Count / 14)
        Paging()
    End Sub

    Private Sub DGVPageCounter_Click(sender As Object, e As EventArgs) Handles DGVPageCounter.Click
        GoToPageNumber(Baris.Count, 14, FetchData, CurrentPage)
        Paging()
    End Sub
#End Region

End Class