Public Class User

    Dim NewData As Boolean

#Region "Form"
    Sub Clear()
        NewData = 1
        TUsername.Enabled = 1
        BTNSimpan.Values.Image = ImgSave
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.simpan_default
        TUsername.Clear()
        TPassword.Clear()
        TampilDGV()
        TCariData.Clear()
        TUsername.Focus()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaWarna(Me, Warna, PaletPrimer)
        DGVIndikator.Rows.Add("A", "Barang")
        DGVIndikator.Rows.Add("B", "Pelanggan")
        DGVIndikator.Rows.Add("C", "Transaksi")
        Clear()
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TUsername.TextChanged, TPassword.TextChanged
        If TUsername.Text = "" Or TPassword.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

    Sub CariID()
        QR("SELECT Username FROM TBLUser WHERE Username = '" & TUsername.Text & "'")
    End Sub
#End Region

#Region "CRUD"
    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CariID()
        If NewData And DR.HasRows Then
            Pesan("User sudah terdaftar", 0)
            Exit Sub
        End If
        If Not DR.HasRows Then
            QN("INSERT INTO TBLUser(Username, Pw) VALUES('" & TUsername.Text & "','" & EncodePassword(TUsername.Text, TPassword.Text) & "')")
            Pesan("User berhasil ditambah", 1)
        Else
            QN("UPDATE TBLUser SET Pw = '" & EncodePassword(TUsername.Text, TPassword.Text) & "' WHERE Username = '" & TUsername.Text & "'")
            Pesan("User berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT Username FROM TBLTransaksi WHERE Username = '" & TUsername.Text & "'")
        If DR.HasRows Then
            Pesan("User pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        CariID()
        If Not DR.HasRows Then
            Pesan("ID User tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & TUsername.Text & "?", 0)
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLUser WHERE Username = '" & TUsername.Text & "'")
                Pesan("User berhasil dihapus", 1)
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
        DGVPageCounter.Text = CurrentPage & " / " & If(Baris.Count <= 15, 1, Math.Ceiling(Baris.Count / 15))
        If CurrentPage = 1 Then
            DGVPrev.Enabled = 0
            DGVFirst.Enabled = 0
        Else
            DGVPrev.Enabled = 1
            DGVFirst.Enabled = 1
        End If
        If CurrentPage >= Math.Ceiling(Baris.Count / 15) Then
            DGVNext.Enabled = 0
            DGVLast.Enabled = 0
        Else
            DGVNext.Enabled = 1
            DGVLast.Enabled = 1
        End If
        If Baris.Count = 0 Then Exit Sub

        If Baris.Count Mod 15 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(Baris.Count / 15) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 14
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4), Baris(x)(5))
            If x = Baris.Count Then Exit For
        Next
    End Sub

    Sub TampilDGV()
        Baris.Clear()
        QRL("SELECT Username, RBarang, EBarang, RPelanggan, EPelanggan, Transaksi FROM TBLUser WHERE Username LIKE '%" & TCariData.Text & "%' AND NOT Username = 'Admin' ORDER BY Username")
        Do While DR.Read
            Baris.Add({DR(0), DR(1), DR(2), DR(3), DR(4), DR(5)})
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
        If Not e.ColumnIndex = 0 Or e.RowIndex < 0 Then Exit Sub
        NewData = 0
        TUsername.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TUsername.Enabled = 0
        TPassword.Clear()
        BTNSimpan.Values.Image = ImgEdit
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.edit_default
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If e.ColumnIndex = 0 Or e.RowIndex < 0 Then Exit Sub
        DGV.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If e.ColumnIndex = 1 AndAlso DGV.Rows(e.RowIndex).Cells(1).Value = 0 Then DGV.Rows(e.RowIndex).Cells(2).Value = 0
        If e.ColumnIndex = 2 AndAlso DGV.Rows(e.RowIndex).Cells(2).Value = -1 Then DGV.Rows(e.RowIndex).Cells(1).Value = -1
        If e.ColumnIndex = 3 AndAlso DGV.Rows(e.RowIndex).Cells(3).Value = 0 Then DGV.Rows(e.RowIndex).Cells(4).Value = 0
        If e.ColumnIndex = 4 AndAlso DGV.Rows(e.RowIndex).Cells(4).Value = -1 Then DGV.Rows(e.RowIndex).Cells(3).Value = -1
        QN("UPDATE TBLUser SET RBarang = " & Val(DGV.Rows(e.RowIndex).Cells(1).Value) & ", EBarang = " & Val(DGV.Rows(e.RowIndex).Cells(2).Value) & ", RPelanggan = " & Val(DGV.Rows(e.RowIndex).Cells(3).Value) & ", EPelanggan = " & Val(DGV.Rows(e.RowIndex).Cells(4).Value) & ", Transaksi = " & Val(DGV.Rows(e.RowIndex).Cells(5).Value) & " WHERE Username = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'")
    End Sub

    Private Sub DGVFirst_Click(sender As Object, e As EventArgs) Handles DGVFirst.Click
        FetchData = 1
        CurrentPage = 1
        Paging()
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 15
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 15
        CurrentPage += 1
        Paging()
    End Sub

    Private Sub DGVLast_Click(sender As Object, e As EventArgs) Handles DGVLast.Click
        FetchData = (Math.Ceiling(Baris.Count / 15) - 1) * 15 + 1
        CurrentPage = Math.Ceiling(Baris.Count / 15)
        Paging()
    End Sub

    Private Sub DGVPageCounter_Click(sender As Object, e As EventArgs) Handles DGVPageCounter.Click
        GoToPageNumber(Baris.Count, 15, FetchData, CurrentPage)
        Paging()
    End Sub
#End Region

End Class