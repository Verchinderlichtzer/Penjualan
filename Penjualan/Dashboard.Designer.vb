<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.LBLTemaWarna = New Krypton.Toolkit.KryptonLabel()
        Me.PaletDashboard = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.TWarna = New Krypton.Toolkit.KryptonComboBox()
        Me.PanelProfil = New System.Windows.Forms.Panel()
        Me.LBLPengurus = New Krypton.Toolkit.KryptonLabel()
        Me.LBLAlamat = New Krypton.Toolkit.KryptonLabel()
        Me.LBLJabatan = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTelepon = New Krypton.Toolkit.KryptonLabel()
        Me.LBLNama = New Krypton.Toolkit.KryptonLabel()
        Me.LBLProfil = New Krypton.Toolkit.KryptonLabel()
        Me.TPengurus = New Krypton.Toolkit.KryptonTextBox()
        Me.TAlamat = New Krypton.Toolkit.KryptonTextBox()
        Me.TJabatan = New Krypton.Toolkit.KryptonTextBox()
        Me.TTelepon = New Krypton.Toolkit.KryptonTextBox()
        Me.TNama = New Krypton.Toolkit.KryptonTextBox()
        Me.Footer = New System.Windows.Forms.Panel()
        Me.LBLUserAktif = New Krypton.Toolkit.KryptonLabel()
        Me.LBLAuthor = New Krypton.Toolkit.KryptonLabel()
        Me.PanelRekapitulasi = New System.Windows.Forms.Panel()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.CPeriode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPendapatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBLRekapitulasi = New Krypton.Toolkit.KryptonLabel()
        Me.PanelRiwayatTransaksi = New System.Windows.Forms.Panel()
        Me.TTerbayar = New Krypton.Toolkit.KryptonTextBox()
        Me.TTanggal = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTerbayar = New Krypton.Toolkit.KryptonLabel()
        Me.TUsername = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLUsername = New Krypton.Toolkit.KryptonLabel()
        Me.TTotal = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTotal = New Krypton.Toolkit.KryptonLabel()
        Me.TPelanggan = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLPelanggan = New Krypton.Toolkit.KryptonLabel()
        Me.LBLFaktur = New Krypton.Toolkit.KryptonLabel()
        Me.TFaktur = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLRiwayatTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.LBLGantiPassword = New Krypton.Toolkit.KryptonLabel()
        Me.LBLBackupDatabase = New Krypton.Toolkit.KryptonLabel()
        Me.LBLHapusTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.PanelPengaturan = New System.Windows.Forms.Panel()
        Me.LBLPengaturan = New Krypton.Toolkit.KryptonLabel()
        Me.PanelGrafik = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Ill = New Penjualan.Ill()
        Me.LBLGrafik = New Krypton.Toolkit.KryptonLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TBLGrafikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLGrafikTableAdapter = New Penjualan.IllTableAdapters.TBLGrafikTableAdapter()
        CType(Me.TWarna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProfil.SuspendLayout()
        Me.Footer.SuspendLayout()
        Me.PanelRekapitulasi.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRiwayatTransaksi.SuspendLayout()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPengaturan.SuspendLayout()
        Me.PanelGrafik.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLGrafikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLTemaWarna
        '
        Me.LBLTemaWarna.AutoSize = False
        Me.LBLTemaWarna.Location = New System.Drawing.Point(3, 36)
        Me.LBLTemaWarna.Name = "LBLTemaWarna"
        Me.LBLTemaWarna.Palette = Me.PaletDashboard
        Me.LBLTemaWarna.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTemaWarna.Size = New System.Drawing.Size(134, 26)
        Me.LBLTemaWarna.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTemaWarna.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTemaWarna.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTemaWarna.TabIndex = 218
        Me.LBLTemaWarna.Values.Text = "Tema Warna"
        '
        'PaletDashboard
        '
        Me.PaletDashboard.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletDashboard.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.PaletDashboard.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletDashboard.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.PaletDashboard.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PaletDashboard.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PaletDashboard.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletDashboard.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletDashboard.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletDashboard.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletDashboard.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletDashboard.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletDashboard.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'TWarna
        '
        Me.TWarna.AlwaysActive = False
        Me.TWarna.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TWarna.DropDownHeight = 502
        Me.TWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TWarna.DropDownWidth = 119
        Me.TWarna.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TWarna.IntegralHeight = False
        Me.TWarna.Items.AddRange(New Object() {"Merah", "Kuning", "Hijau", "Biru", "Ungu", "Coklat"})
        Me.TWarna.Location = New System.Drawing.Point(143, 36)
        Me.TWarna.MaxDropDownItems = 20
        Me.TWarna.Name = "TWarna"
        Me.TWarna.Palette = Me.PaletDashboard
        Me.TWarna.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TWarna.Size = New System.Drawing.Size(119, 26)
        Me.TWarna.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TWarna.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TWarna.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TWarna.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TWarna.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TWarna.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green
        Me.TWarna.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TWarna.StateCommon.Item.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TWarna.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TWarna.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TWarna.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TWarna.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TWarna.TabIndex = 6
        '
        'PanelProfil
        '
        Me.PanelProfil.BackColor = System.Drawing.Color.White
        Me.PanelProfil.Controls.Add(Me.LBLPengurus)
        Me.PanelProfil.Controls.Add(Me.LBLAlamat)
        Me.PanelProfil.Controls.Add(Me.LBLJabatan)
        Me.PanelProfil.Controls.Add(Me.LBLTelepon)
        Me.PanelProfil.Controls.Add(Me.LBLNama)
        Me.PanelProfil.Controls.Add(Me.LBLProfil)
        Me.PanelProfil.Location = New System.Drawing.Point(15, 15)
        Me.PanelProfil.Name = "PanelProfil"
        Me.PanelProfil.Size = New System.Drawing.Size(533, 222)
        Me.PanelProfil.TabIndex = 221
        '
        'LBLPengurus
        '
        Me.LBLPengurus.AutoSize = False
        Me.LBLPengurus.Location = New System.Drawing.Point(3, 158)
        Me.LBLPengurus.Name = "LBLPengurus"
        Me.LBLPengurus.Size = New System.Drawing.Size(86, 26)
        Me.LBLPengurus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPengurus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPengurus.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPengurus.TabIndex = 250
        Me.LBLPengurus.Values.Text = "Pengurus"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.AutoSize = False
        Me.LBLAlamat.Location = New System.Drawing.Point(3, 68)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(86, 26)
        Me.LBLAlamat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAlamat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAlamat.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAlamat.TabIndex = 250
        Me.LBLAlamat.Values.Text = "Alamat"
        '
        'LBLJabatan
        '
        Me.LBLJabatan.AutoSize = False
        Me.LBLJabatan.Location = New System.Drawing.Point(3, 190)
        Me.LBLJabatan.Name = "LBLJabatan"
        Me.LBLJabatan.Size = New System.Drawing.Size(86, 26)
        Me.LBLJabatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLJabatan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLJabatan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLJabatan.TabIndex = 250
        Me.LBLJabatan.Values.Text = "Jabatan"
        '
        'LBLTelepon
        '
        Me.LBLTelepon.AutoSize = False
        Me.LBLTelepon.Location = New System.Drawing.Point(3, 126)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(86, 26)
        Me.LBLTelepon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTelepon.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTelepon.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTelepon.TabIndex = 250
        Me.LBLTelepon.Values.Text = "Telepon"
        '
        'LBLNama
        '
        Me.LBLNama.AutoSize = False
        Me.LBLNama.Location = New System.Drawing.Point(3, 36)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.Size = New System.Drawing.Size(86, 26)
        Me.LBLNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLNama.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLNama.TabIndex = 250
        Me.LBLNama.Values.Text = "Nama"
        '
        'LBLProfil
        '
        Me.LBLProfil.AutoSize = False
        Me.LBLProfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLProfil.Location = New System.Drawing.Point(0, 0)
        Me.LBLProfil.Name = "LBLProfil"
        Me.LBLProfil.Size = New System.Drawing.Size(533, 30)
        Me.LBLProfil.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLProfil.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLProfil.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProfil.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLProfil.TabIndex = 219
        Me.LBLProfil.Values.Text = "Profil"
        '
        'TPengurus
        '
        Me.TPengurus.AlwaysActive = False
        Me.TPengurus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TPengurus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TPengurus.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPengurus.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPengurus.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPengurus.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TPengurus.Location = New System.Drawing.Point(110, 173)
        Me.TPengurus.MaxLength = 100
        Me.TPengurus.Name = "TPengurus"
        Me.TPengurus.Size = New System.Drawing.Size(435, 29)
        Me.TPengurus.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TPengurus.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPengurus.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengurus.StateActive.Border.Rounding = 0!
        Me.TPengurus.StateActive.Border.Width = 1
        Me.TPengurus.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPengurus.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TPengurus.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TPengurus.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPengurus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengurus.StateCommon.Border.Rounding = 0!
        Me.TPengurus.StateCommon.Border.Width = 1
        Me.TPengurus.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPengurus.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPengurus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPengurus.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengurus.StateDisabled.Border.Rounding = 0!
        Me.TPengurus.StateDisabled.Border.Width = 0
        Me.TPengurus.TabIndex = 249
        '
        'TAlamat
        '
        Me.TAlamat.AlwaysActive = False
        Me.TAlamat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TAlamat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TAlamat.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TAlamat.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TAlamat.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TAlamat.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TAlamat.Location = New System.Drawing.Point(110, 83)
        Me.TAlamat.MaxLength = 100
        Me.TAlamat.Multiline = True
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.Size = New System.Drawing.Size(435, 55)
        Me.TAlamat.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TAlamat.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TAlamat.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateActive.Border.Rounding = 0!
        Me.TAlamat.StateActive.Border.Width = 1
        Me.TAlamat.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TAlamat.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TAlamat.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TAlamat.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TAlamat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateCommon.Border.Rounding = 0!
        Me.TAlamat.StateCommon.Border.Width = 1
        Me.TAlamat.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TAlamat.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TAlamat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TAlamat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateDisabled.Border.Rounding = 0!
        Me.TAlamat.StateDisabled.Border.Width = 0
        Me.TAlamat.TabIndex = 249
        '
        'TJabatan
        '
        Me.TJabatan.AlwaysActive = False
        Me.TJabatan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TJabatan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TJabatan.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TJabatan.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TJabatan.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TJabatan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TJabatan.Location = New System.Drawing.Point(110, 205)
        Me.TJabatan.MaxLength = 100
        Me.TJabatan.Name = "TJabatan"
        Me.TJabatan.Size = New System.Drawing.Size(435, 29)
        Me.TJabatan.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TJabatan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TJabatan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJabatan.StateActive.Border.Rounding = 0!
        Me.TJabatan.StateActive.Border.Width = 1
        Me.TJabatan.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TJabatan.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TJabatan.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TJabatan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TJabatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJabatan.StateCommon.Border.Rounding = 0!
        Me.TJabatan.StateCommon.Border.Width = 1
        Me.TJabatan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TJabatan.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TJabatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TJabatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJabatan.StateDisabled.Border.Rounding = 0!
        Me.TJabatan.StateDisabled.Border.Width = 0
        Me.TJabatan.TabIndex = 249
        '
        'TTelepon
        '
        Me.TTelepon.AlwaysActive = False
        Me.TTelepon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TTelepon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TTelepon.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTelepon.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTelepon.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTelepon.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTelepon.Location = New System.Drawing.Point(110, 141)
        Me.TTelepon.MaxLength = 100
        Me.TTelepon.Name = "TTelepon"
        Me.TTelepon.Size = New System.Drawing.Size(435, 29)
        Me.TTelepon.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTelepon.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelepon.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateActive.Border.Rounding = 0!
        Me.TTelepon.StateActive.Border.Width = 1
        Me.TTelepon.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTelepon.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TTelepon.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TTelepon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelepon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateCommon.Border.Rounding = 0!
        Me.TTelepon.StateCommon.Border.Width = 1
        Me.TTelepon.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTelepon.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTelepon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTelepon.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateDisabled.Border.Rounding = 0!
        Me.TTelepon.StateDisabled.Border.Width = 0
        Me.TTelepon.TabIndex = 249
        '
        'TNama
        '
        Me.TNama.AlwaysActive = False
        Me.TNama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TNama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TNama.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TNama.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TNama.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TNama.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TNama.Location = New System.Drawing.Point(110, 51)
        Me.TNama.MaxLength = 100
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(435, 29)
        Me.TNama.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TNama.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNama.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateActive.Border.Rounding = 0!
        Me.TNama.StateActive.Border.Width = 1
        Me.TNama.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TNama.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TNama.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TNama.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNama.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateCommon.Border.Rounding = 0!
        Me.TNama.StateCommon.Border.Width = 1
        Me.TNama.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TNama.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TNama.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TNama.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateDisabled.Border.Rounding = 0!
        Me.TNama.StateDisabled.Border.Width = 0
        Me.TNama.TabIndex = 249
        '
        'Footer
        '
        Me.Footer.Controls.Add(Me.LBLUserAktif)
        Me.Footer.Controls.Add(Me.LBLAuthor)
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.Location = New System.Drawing.Point(0, 612)
        Me.Footer.Name = "Footer"
        Me.Footer.Size = New System.Drawing.Size(1111, 26)
        Me.Footer.TabIndex = 223
        '
        'LBLUserAktif
        '
        Me.LBLUserAktif.AutoSize = False
        Me.LBLUserAktif.Dock = System.Windows.Forms.DockStyle.Right
        Me.LBLUserAktif.Location = New System.Drawing.Point(396, 0)
        Me.LBLUserAktif.Name = "LBLUserAktif"
        Me.LBLUserAktif.Palette = Me.PaletDashboard
        Me.LBLUserAktif.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLUserAktif.Size = New System.Drawing.Size(715, 26)
        Me.LBLUserAktif.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUserAktif.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUserAktif.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUserAktif.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLUserAktif.TabIndex = 220
        Me.LBLUserAktif.Values.Text = "-"
        '
        'LBLAuthor
        '
        Me.LBLAuthor.AutoSize = False
        Me.LBLAuthor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLAuthor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBLAuthor.Location = New System.Drawing.Point(0, 0)
        Me.LBLAuthor.Name = "LBLAuthor"
        Me.LBLAuthor.Palette = Me.PaletDashboard
        Me.LBLAuthor.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLAuthor.Size = New System.Drawing.Size(390, 26)
        Me.LBLAuthor.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAuthor.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAuthor.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAuthor.TabIndex = 219
        Me.LBLAuthor.Values.Text = "Aplikasi Penjualan Sederhana (by Sujudi Hanif)"
        '
        'PanelRekapitulasi
        '
        Me.PanelRekapitulasi.BackColor = System.Drawing.Color.White
        Me.PanelRekapitulasi.Controls.Add(Me.DGV)
        Me.PanelRekapitulasi.Controls.Add(Me.LBLRekapitulasi)
        Me.PanelRekapitulasi.Location = New System.Drawing.Point(563, 15)
        Me.PanelRekapitulasi.Name = "PanelRekapitulasi"
        Me.PanelRekapitulasi.Size = New System.Drawing.Size(533, 201)
        Me.PanelRekapitulasi.TabIndex = 224
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPeriode, Me.CTransaksi, Me.CPendapatan})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(3, 36)
        Me.DGV.Name = "DGV"
        Me.DGV.Palette = Me.PaletDashboard
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(527, 162)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.DGV.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGV.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGV.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGV.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGV.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGV.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGV.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGV.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGV.TabIndex = 220
        '
        'CPeriode
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CPeriode.DefaultCellStyle = DataGridViewCellStyle2
        Me.CPeriode.HeaderText = "Periode"
        Me.CPeriode.Name = "CPeriode"
        Me.CPeriode.ReadOnly = True
        Me.CPeriode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CPeriode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CPeriode.Width = 150
        '
        'CTransaksi
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTransaksi.DefaultCellStyle = DataGridViewCellStyle3
        Me.CTransaksi.HeaderText = "Transaksi"
        Me.CTransaksi.Name = "CTransaksi"
        Me.CTransaksi.ReadOnly = True
        Me.CTransaksi.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTransaksi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTransaksi.Width = 188
        '
        'CPendapatan
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,##0"
        Me.CPendapatan.DefaultCellStyle = DataGridViewCellStyle4
        Me.CPendapatan.HeaderText = "Pendapatan"
        Me.CPendapatan.Name = "CPendapatan"
        Me.CPendapatan.ReadOnly = True
        Me.CPendapatan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CPendapatan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CPendapatan.Width = 188
        '
        'LBLRekapitulasi
        '
        Me.LBLRekapitulasi.AutoSize = False
        Me.LBLRekapitulasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLRekapitulasi.Location = New System.Drawing.Point(0, 0)
        Me.LBLRekapitulasi.Name = "LBLRekapitulasi"
        Me.LBLRekapitulasi.Size = New System.Drawing.Size(533, 30)
        Me.LBLRekapitulasi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLRekapitulasi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLRekapitulasi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRekapitulasi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLRekapitulasi.TabIndex = 219
        Me.LBLRekapitulasi.Values.Text = "Rekapitulasi"
        '
        'PanelRiwayatTransaksi
        '
        Me.PanelRiwayatTransaksi.BackColor = System.Drawing.Color.White
        Me.PanelRiwayatTransaksi.Controls.Add(Me.TTerbayar)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.TTanggal)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.LBLTerbayar)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.TUsername)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.LBLUsername)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.TTotal)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.LBLTotal)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.TPelanggan)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.LBLPelanggan)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.LBLFaktur)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.TFaktur)
        Me.PanelRiwayatTransaksi.Controls.Add(Me.LBLRiwayatTransaksi)
        Me.PanelRiwayatTransaksi.Location = New System.Drawing.Point(15, 252)
        Me.PanelRiwayatTransaksi.Name = "PanelRiwayatTransaksi"
        Me.PanelRiwayatTransaksi.Size = New System.Drawing.Size(533, 196)
        Me.PanelRiwayatTransaksi.TabIndex = 225
        '
        'TTerbayar
        '
        Me.TTerbayar.AlwaysActive = False
        Me.TTerbayar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TTerbayar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TTerbayar.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTerbayar.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTerbayar.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTerbayar.Enabled = False
        Me.TTerbayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTerbayar.Location = New System.Drawing.Point(102, 132)
        Me.TTerbayar.MaxLength = 100
        Me.TTerbayar.Name = "TTerbayar"
        Me.TTerbayar.Size = New System.Drawing.Size(198, 29)
        Me.TTerbayar.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTerbayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTerbayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateActive.Border.Rounding = 0!
        Me.TTerbayar.StateActive.Border.Width = 1
        Me.TTerbayar.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTerbayar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TTerbayar.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TTerbayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTerbayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateCommon.Border.Rounding = 0!
        Me.TTerbayar.StateCommon.Border.Width = 1
        Me.TTerbayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTerbayar.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTerbayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTerbayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateDisabled.Border.Rounding = 0!
        Me.TTerbayar.StateDisabled.Border.Width = 0
        Me.TTerbayar.TabIndex = 251
        '
        'TTanggal
        '
        Me.TTanggal.AlwaysActive = False
        Me.TTanggal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TTanggal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TTanggal.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTanggal.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTanggal.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTanggal.Enabled = False
        Me.TTanggal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTanggal.Location = New System.Drawing.Point(233, 36)
        Me.TTanggal.MaxLength = 100
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(113, 29)
        Me.TTanggal.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTanggal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTanggal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTanggal.StateActive.Border.Rounding = 0!
        Me.TTanggal.StateActive.Border.Width = 1
        Me.TTanggal.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTanggal.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TTanggal.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TTanggal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTanggal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTanggal.StateCommon.Border.Rounding = 0!
        Me.TTanggal.StateCommon.Border.Width = 1
        Me.TTanggal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTanggal.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTanggal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTanggal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTanggal.StateDisabled.Border.Rounding = 0!
        Me.TTanggal.StateDisabled.Border.Width = 0
        Me.TTanggal.TabIndex = 252
        '
        'LBLTerbayar
        '
        Me.LBLTerbayar.AutoSize = False
        Me.LBLTerbayar.Location = New System.Drawing.Point(3, 132)
        Me.LBLTerbayar.Name = "LBLTerbayar"
        Me.LBLTerbayar.Size = New System.Drawing.Size(93, 26)
        Me.LBLTerbayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTerbayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTerbayar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTerbayar.TabIndex = 256
        Me.LBLTerbayar.Values.Text = "Terbayar"
        '
        'TUsername
        '
        Me.TUsername.AlwaysActive = False
        Me.TUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TUsername.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TUsername.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TUsername.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TUsername.Enabled = False
        Me.TUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TUsername.Location = New System.Drawing.Point(102, 164)
        Me.TUsername.MaxLength = 100
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Size = New System.Drawing.Size(428, 29)
        Me.TUsername.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TUsername.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateActive.Border.Rounding = 0!
        Me.TUsername.StateActive.Border.Width = 1
        Me.TUsername.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TUsername.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TUsername.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TUsername.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateCommon.Border.Rounding = 0!
        Me.TUsername.StateCommon.Border.Width = 1
        Me.TUsername.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUsername.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TUsername.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUsername.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateDisabled.Border.Rounding = 0!
        Me.TUsername.StateDisabled.Border.Width = 0
        Me.TUsername.TabIndex = 253
        '
        'LBLUsername
        '
        Me.LBLUsername.AutoSize = False
        Me.LBLUsername.Location = New System.Drawing.Point(3, 164)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(93, 26)
        Me.LBLUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUsername.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUsername.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUsername.TabIndex = 258
        Me.LBLUsername.Values.Text = "Username"
        '
        'TTotal
        '
        Me.TTotal.AlwaysActive = False
        Me.TTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TTotal.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTotal.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTotal.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTotal.Enabled = False
        Me.TTotal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTotal.Location = New System.Drawing.Point(102, 100)
        Me.TTotal.MaxLength = 100
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(198, 29)
        Me.TTotal.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTotal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTotal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotal.StateActive.Border.Rounding = 0!
        Me.TTotal.StateActive.Border.Width = 1
        Me.TTotal.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTotal.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TTotal.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TTotal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotal.StateCommon.Border.Rounding = 0!
        Me.TTotal.StateCommon.Border.Width = 1
        Me.TTotal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTotal.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTotal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTotal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotal.StateDisabled.Border.Rounding = 0!
        Me.TTotal.StateDisabled.Border.Width = 0
        Me.TTotal.TabIndex = 254
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = False
        Me.LBLTotal.Location = New System.Drawing.Point(3, 100)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(93, 26)
        Me.LBLTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTotal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTotal.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTotal.TabIndex = 259
        Me.LBLTotal.Values.Text = "Total"
        '
        'TPelanggan
        '
        Me.TPelanggan.AlwaysActive = False
        Me.TPelanggan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TPelanggan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TPelanggan.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPelanggan.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPelanggan.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPelanggan.Enabled = False
        Me.TPelanggan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TPelanggan.Location = New System.Drawing.Point(102, 68)
        Me.TPelanggan.MaxLength = 100
        Me.TPelanggan.Name = "TPelanggan"
        Me.TPelanggan.Size = New System.Drawing.Size(428, 29)
        Me.TPelanggan.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TPelanggan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPelanggan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPelanggan.StateActive.Border.Rounding = 0!
        Me.TPelanggan.StateActive.Border.Width = 1
        Me.TPelanggan.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPelanggan.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TPelanggan.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TPelanggan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPelanggan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPelanggan.StateCommon.Border.Rounding = 0!
        Me.TPelanggan.StateCommon.Border.Width = 1
        Me.TPelanggan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPelanggan.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPelanggan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPelanggan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPelanggan.StateDisabled.Border.Rounding = 0!
        Me.TPelanggan.StateDisabled.Border.Width = 0
        Me.TPelanggan.TabIndex = 255
        '
        'LBLPelanggan
        '
        Me.LBLPelanggan.AutoSize = False
        Me.LBLPelanggan.Location = New System.Drawing.Point(3, 68)
        Me.LBLPelanggan.Name = "LBLPelanggan"
        Me.LBLPelanggan.Size = New System.Drawing.Size(93, 26)
        Me.LBLPelanggan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPelanggan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPelanggan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPelanggan.TabIndex = 260
        Me.LBLPelanggan.Values.Text = "Pelanggan"
        '
        'LBLFaktur
        '
        Me.LBLFaktur.AutoSize = False
        Me.LBLFaktur.Location = New System.Drawing.Point(3, 36)
        Me.LBLFaktur.Name = "LBLFaktur"
        Me.LBLFaktur.Palette = Me.PaletDashboard
        Me.LBLFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFaktur.Size = New System.Drawing.Size(93, 26)
        Me.LBLFaktur.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFaktur.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFaktur.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLFaktur.TabIndex = 221
        Me.LBLFaktur.Values.Text = "Faktur"
        '
        'TFaktur
        '
        Me.TFaktur.AlwaysActive = False
        Me.TFaktur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TFaktur.DropDownHeight = 502
        Me.TFaktur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TFaktur.DropDownWidth = 119
        Me.TFaktur.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TFaktur.IntegralHeight = False
        Me.TFaktur.Items.AddRange(New Object() {"Merah", "Kuning", "Hijau", "Biru", "Ungu", "Coklat"})
        Me.TFaktur.Location = New System.Drawing.Point(108, 36)
        Me.TFaktur.MaxDropDownItems = 20
        Me.TFaktur.Name = "TFaktur"
        Me.TFaktur.Palette = Me.PaletDashboard
        Me.TFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TFaktur.Size = New System.Drawing.Size(119, 26)
        Me.TFaktur.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TFaktur.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFaktur.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFaktur.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TFaktur.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TFaktur.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green
        Me.TFaktur.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TFaktur.StateCommon.Item.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TFaktur.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFaktur.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TFaktur.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TFaktur.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TFaktur.TabIndex = 220
        '
        'LBLRiwayatTransaksi
        '
        Me.LBLRiwayatTransaksi.AutoSize = False
        Me.LBLRiwayatTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLRiwayatTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.LBLRiwayatTransaksi.Name = "LBLRiwayatTransaksi"
        Me.LBLRiwayatTransaksi.Size = New System.Drawing.Size(533, 30)
        Me.LBLRiwayatTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLRiwayatTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLRiwayatTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRiwayatTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLRiwayatTransaksi.TabIndex = 219
        Me.LBLRiwayatTransaksi.Values.Text = "Riwayat Transaksi"
        '
        'LBLGantiPassword
        '
        Me.LBLGantiPassword.AutoSize = False
        Me.LBLGantiPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLGantiPassword.Location = New System.Drawing.Point(3, 68)
        Me.LBLGantiPassword.Name = "LBLGantiPassword"
        Me.LBLGantiPassword.Palette = Me.PaletDashboard
        Me.LBLGantiPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLGantiPassword.Size = New System.Drawing.Size(134, 26)
        Me.LBLGantiPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLGantiPassword.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLGantiPassword.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLGantiPassword.TabIndex = 252
        Me.LBLGantiPassword.Values.Text = "Ganti Password"
        '
        'LBLBackupDatabase
        '
        Me.LBLBackupDatabase.AutoSize = False
        Me.LBLBackupDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLBackupDatabase.Location = New System.Drawing.Point(318, 36)
        Me.LBLBackupDatabase.Name = "LBLBackupDatabase"
        Me.LBLBackupDatabase.Palette = Me.PaletDashboard
        Me.LBLBackupDatabase.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLBackupDatabase.Size = New System.Drawing.Size(147, 26)
        Me.LBLBackupDatabase.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBackupDatabase.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBackupDatabase.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBackupDatabase.TabIndex = 254
        Me.LBLBackupDatabase.Values.Text = "Backup Database"
        '
        'LBLHapusTransaksi
        '
        Me.LBLHapusTransaksi.AutoSize = False
        Me.LBLHapusTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLHapusTransaksi.Location = New System.Drawing.Point(318, 68)
        Me.LBLHapusTransaksi.Name = "LBLHapusTransaksi"
        Me.LBLHapusTransaksi.Palette = Me.PaletDashboard
        Me.LBLHapusTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLHapusTransaksi.Size = New System.Drawing.Size(199, 26)
        Me.LBLHapusTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHapusTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLHapusTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLHapusTransaksi.TabIndex = 256
        Me.LBLHapusTransaksi.Values.Text = "Hapus Semua Transaksi"
        '
        'PanelPengaturan
        '
        Me.PanelPengaturan.BackColor = System.Drawing.Color.White
        Me.PanelPengaturan.Controls.Add(Me.LBLHapusTransaksi)
        Me.PanelPengaturan.Controls.Add(Me.LBLPengaturan)
        Me.PanelPengaturan.Controls.Add(Me.LBLBackupDatabase)
        Me.PanelPengaturan.Controls.Add(Me.LBLTemaWarna)
        Me.PanelPengaturan.Controls.Add(Me.LBLGantiPassword)
        Me.PanelPengaturan.Controls.Add(Me.TWarna)
        Me.PanelPengaturan.Location = New System.Drawing.Point(15, 463)
        Me.PanelPengaturan.Name = "PanelPengaturan"
        Me.PanelPengaturan.Size = New System.Drawing.Size(533, 143)
        Me.PanelPengaturan.TabIndex = 226
        '
        'LBLPengaturan
        '
        Me.LBLPengaturan.AutoSize = False
        Me.LBLPengaturan.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLPengaturan.Location = New System.Drawing.Point(0, 0)
        Me.LBLPengaturan.Name = "LBLPengaturan"
        Me.LBLPengaturan.Size = New System.Drawing.Size(533, 30)
        Me.LBLPengaturan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPengaturan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPengaturan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPengaturan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLPengaturan.TabIndex = 219
        Me.LBLPengaturan.Values.Text = "Pengaturan"
        '
        'PanelGrafik
        '
        Me.PanelGrafik.BackColor = System.Drawing.Color.White
        Me.PanelGrafik.Controls.Add(Me.Chart1)
        Me.PanelGrafik.Controls.Add(Me.LBLGrafik)
        Me.PanelGrafik.Location = New System.Drawing.Point(563, 231)
        Me.PanelGrafik.Name = "PanelGrafik"
        Me.PanelGrafik.Size = New System.Drawing.Size(533, 375)
        Me.PanelGrafik.TabIndex = 227
        '
        'Chart1
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.Maximum = 44721.0R
        ChartArea1.AxisX.Minimum = 44714.0R
        ChartArea1.AxisY.LabelStyle.Format = "#,##0"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.TBLGrafikBindingSource
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart1.Location = New System.Drawing.Point(0, 30)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Green
        Series1.IsVisibleInLegend = False
        Series1.MarkerColor = System.Drawing.Color.Red
        Series1.Name = "Series1"
        Series1.XValueMember = "Tanggal"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series1.YValueMembers = "Totals"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(533, 345)
        Me.Chart1.TabIndex = 220
        Me.Chart1.Text = "Chart1"
        '
        'Ill
        '
        Me.Ill.DataSetName = "Ill"
        Me.Ill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LBLGrafik
        '
        Me.LBLGrafik.AutoSize = False
        Me.LBLGrafik.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLGrafik.Location = New System.Drawing.Point(0, 0)
        Me.LBLGrafik.Name = "LBLGrafik"
        Me.LBLGrafik.Size = New System.Drawing.Size(533, 30)
        Me.LBLGrafik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLGrafik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLGrafik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLGrafik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLGrafik.TabIndex = 219
        Me.LBLGrafik.Values.Text = "Grafik penjualan 8 hari terakhir"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Title = "Backup Database"
        '
        'TBLGrafikBindingSource
        '
        Me.TBLGrafikBindingSource.DataMember = "TBLGrafik"
        Me.TBLGrafikBindingSource.DataSource = Me.Ill
        '
        'TBLGrafikTableAdapter
        '
        Me.TBLGrafikTableAdapter.ClearBeforeFill = True
        '
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.PanelGrafik)
        Me.Controls.Add(Me.TPengurus)
        Me.Controls.Add(Me.TAlamat)
        Me.Controls.Add(Me.TJabatan)
        Me.Controls.Add(Me.TTelepon)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.PanelPengaturan)
        Me.Controls.Add(Me.PanelRiwayatTransaksi)
        Me.Controls.Add(Me.PanelRekapitulasi)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.PanelProfil)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.TWarna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfil.ResumeLayout(False)
        Me.Footer.ResumeLayout(False)
        Me.PanelRekapitulasi.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRiwayatTransaksi.ResumeLayout(False)
        Me.PanelRiwayatTransaksi.PerformLayout()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPengaturan.ResumeLayout(False)
        Me.PanelGrafik.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLGrafikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTemaWarna As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TWarna As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents PaletDashboard As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PanelProfil As Panel
    Friend WithEvents Footer As Panel
    Friend WithEvents LBLUserAktif As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLAuthor As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLProfil As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TPengurus As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TAlamat As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLPengurus As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLAlamat As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TTelepon As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTelepon As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TNama As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLNama As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TJabatan As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLJabatan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelRekapitulasi As Panel
    Friend WithEvents LBLRekapitulasi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelRiwayatTransaksi As Panel
    Friend WithEvents LBLRiwayatTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLGantiPassword As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBackupDatabase As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLHapusTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelPengaturan As Panel
    Friend WithEvents LBLPengaturan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelGrafik As Panel
    Friend WithEvents LBLGrafik As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CPeriode As DataGridViewTextBoxColumn
    Friend WithEvents CTransaksi As DataGridViewTextBoxColumn
    Friend WithEvents CPendapatan As DataGridViewTextBoxColumn
    Friend WithEvents LBLFaktur As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TFaktur As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TTerbayar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTanggal As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLUsername As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TTotal As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTotal As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TPelanggan As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLPelanggan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LBLTerbayar As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Ill As Ill
    Friend WithEvents TBLGrafikBindingSource As BindingSource
    Friend WithEvents TBLGrafikTableAdapter As IllTableAdapters.TBLGrafikTableAdapter
End Class
