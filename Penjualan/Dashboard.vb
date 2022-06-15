Imports System.Data.OleDb
Public Class Dashboard

    Dim Harian, Mingguan, Bulanan, Tahunan, Semua As Integer
    Dim PHarian, PMingguan, PBulanan, PTahunan, PSemua As Integer

    Private Sub TWarna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TWarna.SelectedIndexChanged
        TemaWarna(Me, TWarna.SelectedIndex, PaletDashboard)
        Warna = TWarna.SelectedIndex
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedTheme", TWarna.SelectedIndex)
    End Sub

    Private Sub LBLAuthor_Click(sender As Object, e As EventArgs) Handles LBLAuthor.Click
        Process.Start("https://api.whatsapp.com/send?phone=6285739194810")
    End Sub

    Private Sub LBLGantiPassword_Click(sender As Object, e As EventArgs) Handles LBLGantiPassword.Click
        Dim Confirm As New Konfirmasi("Masukan password lama dan password baru.", "--", 1)
        Confirm.ShowDialog()
    End Sub

    Private Sub LBLBackupDatabase_Click(sender As Object, e As EventArgs) Handles LBLBackupDatabase.Click
        With SaveFileDialog1
            .FileName = "DBInventori" & Format(Today, "yyMMdd") & ".accdb"
            .Filter = "Microsoft Access 2007 - 2016(*.accdb)|*.accdb"
            .FilterIndex = 1
        End With
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Path & "\Ill.accdb", SaveFileDialog1.FileName, overwrite:=True)
            Pesan("Database berhasil dibackup.", 1)
        End If
    End Sub

    Private Sub LBLHapusTransaksi_Click(sender As Object, e As EventArgs) Handles LBLHapusTransaksi.Click
        Dim Confirm As New Konfirmasi("Konfirmasi", "Hapus SEMUA data transaksi?", 1)
        If UserAktif = "Admin" AndAlso Confirm.ShowDialog() = DialogResult.Yes Then
            QN("DELETE FROM TBLTransaksi")
            Pesan("Semua data transaksi berhasil dihapus.", 1)
            TFaktur.Enabled = 0
            TTanggal.Clear()
            TPelanggan.Clear()
            TTotal.Clear()
            TTerbayar.Clear()
            TUsername.Clear()
            TampilFaktur()
            TampilTransaksi()
            TampilPendapatan()
        End If
    End Sub

    Private Sub SimpanInfo(sender As Object, e As EventArgs) Handles TTelepon.TextChanged, TPengurus.TextChanged, TNama.TextChanged, TJabatan.TextChanged, TAlamat.TextChanged
        If Locked Then Exit Sub
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        QN("UPDATE TBLInfo SET Nama = '" & TNama.Text & "', Alamat = '" & TAlamat.Text & "', Telepon = '" & TTelepon.Text & "', Pengurus = '" & TPengurus.Text & "', Jabatan = '" & TJabatan.Text & "'")
        Pesan("Info berhasil diubah", 1)
        Timer1.Stop()
    End Sub

    Sub TampilFaktur()
        TFaktur.Items.Clear()
        QRL("SELECT Faktur FROM TBLTransaksi ORDER BY Faktur DESC")
        Do While DR.Read
            TFaktur.Items.Add(DR(0))
        Loop
    End Sub

    Private Sub TampilRiwayat(sender As Object, e As EventArgs) Handles TFaktur.SelectedIndexChanged
        If Locked Then Exit Sub
        QR("SELECT Tanggal, Nama, Total, Terbayar, Username FROM TBLPelanggan INNER JOIN TBLTransaksi ON TBLPelanggan.ID_Pelanggan = TBLTransaksi.ID_Pelanggan WHERE Faktur = '" & TFaktur.SelectedItem & "'")
        TTanggal.Text = Format(DR(0), "dd-MM-yyyy")
        TPelanggan.Text = ": " & DR(1)
        TTotal.Text = ": Rp " & FormatNumber(DR(2), 0)
        TTerbayar.Text = ": Rp " & FormatNumber(DR(3), 0)
        TUsername.Text = ": " & DR(4)
    End Sub

    Sub TampilProfil()
        QR("SELECT * FROM TBLInfo")
        TNama.Text = DR(0)
        TAlamat.Text = DR(1)
        TTelepon.Text = DR(2)
        TPengurus.Text = DR(3)
        TJabatan.Text = DR(4)
    End Sub

    Sub TampilTransaksi()
        QR("SELECT COUNT(*) FROM TBLTransaksi")
        If Not IsDBNull(DR(0)) Then Semua = DR(0)
        QR("SELECT COUNT(*) FROM TBLTransaksi WHERE DATEVALUE(Tanggal) = #" & Format(Today, "M/d/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then Harian = DR(0)
        QR("SELECT COUNT(*) FROM TBLTransaksi WHERE DATEVALUE(Tanggal) BETWEEN #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 1, Today), "M/d/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 7, Today), "M/d/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then Mingguan = DR(0)
        QR("SELECT COUNT(*) FROM TBLTransaksi WHERE MONTH(Tanggal) = '" & Month(Today) & "' AND YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then Bulanan = DR(0)
        QR("SELECT COUNT(*) FROM TBLTransaksi WHERE YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then Tahunan = DR(0)
    End Sub

    Sub TampilPendapatan()
        QR("SELECT SUM(Nominal) FROM TBLBayar")
        If Not IsDBNull(DR(0)) Then PSemua = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayar WHERE DATEVALUE(Tanggal) = #" & Format(Today, "M/d/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then PHarian = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayar WHERE DATEVALUE(Tanggal) BETWEEN #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 1, Today), "M/d/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 7, Today), "M/d/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then PMingguan = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayar WHERE MONTH(Tanggal) = '" & Month(Today) & "' AND YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then PBulanan = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayar WHERE YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then PTahunan = DR(0)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TWarna.SelectedIndex = Warna
        Locked = 1
        TampilProfil()
        TampilFaktur()
        TampilTransaksi()
        TampilPendapatan()
        Locked = 0
        LBLUserAktif.Text = UserAktif
        If UserAktif = "Admin" Then
            LBLBackupDatabase.Visible = 1
            LBLHapusTransaksi.Visible = 1
            TNama.ReadOnly = 0
            TAlamat.ReadOnly = 0
            TTelepon.ReadOnly = 0
            TPengurus.ReadOnly = 0
            TJabatan.ReadOnly = 0
        Else
            LBLBackupDatabase.Visible = 0
            LBLHapusTransaksi.Visible = 0
            TNama.ReadOnly = 1
            TAlamat.ReadOnly = 1
            TTelepon.ReadOnly = 1
            TPengurus.ReadOnly = 1
            TJabatan.ReadOnly = 1
        End If
        DGV.Rows.Add("Harian", Harian, PHarian)
        DGV.Rows.Add("Mingguan", Mingguan, PMingguan)
        DGV.Rows.Add("Bulanan", Bulanan, PBulanan)
        DGV.Rows.Add("Tahunan", Tahunan, PTahunan)
        DGV.Rows.Add("Semua", Semua, PSemua)
        DA = New OleDbDataAdapter("SELECT Tanggal, SUM(Nominal) AS Totals FROM TBLBayar WHERE Tanggal BETWEEN #" & Format(Today, "M/d/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -7, Today), "M/d/yyyy") & "# GROUP BY Tanggal", CONN)
        DA.Fill(Ill.TBLGrafik)
        Chart1.ChartAreas(0).AxisX.Minimum = DateDiff(DateInterval.Day, #12/30/1899#, DateAdd(DateInterval.Day, -7, Today))
        Chart1.ChartAreas(0).AxisX.Maximum = DateDiff(DateInterval.Day, #12/30/1899#, Today)
    End Sub
End Class