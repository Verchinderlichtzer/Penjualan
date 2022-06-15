<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelTotalTransaksi = New Krypton.Toolkit.KryptonGroup()
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PanelTengah = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RBRingkasan = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBDetail = New Krypton.Toolkit.KryptonRadioButton()
        Me.LBLBentuk = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge3 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBSudah = New Krypton.Toolkit.KryptonCheckBox()
        Me.LBLStatusLunas = New Krypton.Toolkit.KryptonLabel()
        Me.CBBelum = New Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelPeriodik = New System.Windows.Forms.Panel()
        Me.LBLTanggalTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.TTahunan = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLBulanan = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPeriodik = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTahunan = New Krypton.Toolkit.KryptonLabel()
        Me.TBulanan = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.LBLSampai = New Krypton.Toolkit.KryptonLabel()
        Me.TSampai = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.TDari = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.PanelKanan = New System.Windows.Forms.Panel()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVLast = New Krypton.Toolkit.KryptonButton()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.TEntitas = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLEntitas = New Krypton.Toolkit.KryptonLabel()
        Me.Pemisah2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelKiri = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBGrafik = New Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonBorderEdge2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.LBLFile = New Krypton.Toolkit.KryptonLabel()
        Me.RBTransaksi = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBBarang = New Krypton.Toolkit.KryptonRadioButton()
        Me.LBLTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.RBPelanggan = New Krypton.Toolkit.KryptonRadioButton()
        Me.Pemisah1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelLapor = New Krypton.Toolkit.KryptonGroup()
        Me.LBLFilter = New Krypton.Toolkit.KryptonLabel()
        Me.BTNLapor = New Krypton.Toolkit.KryptonButton()
        Me.BTNBersihkan = New Krypton.Toolkit.KryptonButton()
        Me.Ill = New Penjualan.Ill()
        Me.TBLPelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPelangganTableAdapter = New Penjualan.IllTableAdapters.TBLPelangganTableAdapter()
        Me.TBLBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBarangTableAdapter = New Penjualan.IllTableAdapters.TBLBarangTableAdapter()
        Me.TBLTransaksiDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLTransaksiDetailTableAdapter = New Penjualan.IllTableAdapters.TBLTransaksiDetailTableAdapter()
        Me.TBLGrafikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLGrafikTableAdapter = New Penjualan.IllTableAdapters.TBLGrafikTableAdapter()
        Me.TBLTransaksiRingkasanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLTransaksiRingkasanTableAdapter = New Penjualan.IllTableAdapters.TBLTransaksiRingkasanTableAdapter()
        Me.TBLPelangganRingkasanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPelangganRingkasanTableAdapter = New Penjualan.IllTableAdapters.TBLPelangganRingkasanTableAdapter()
        Me.TBLPelangganDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPelangganDetailTableAdapter = New Penjualan.IllTableAdapters.TBLPelangganDetailTableAdapter()
        Me.TBLFakturBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLFakturTableAdapter = New Penjualan.IllTableAdapters.TBLFakturTableAdapter()
        Me.TBLBarangRingkasanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBarangRingkasanTableAdapter = New Penjualan.IllTableAdapters.TBLBarangRingkasanTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonLabel()
        CType(Me.PanelTotalTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTotalTransaksi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotalTransaksi.Panel.SuspendLayout()
        Me.PanelTotalTransaksi.SuspendLayout()
        Me.PanelTengah.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelPeriodik.SuspendLayout()
        CType(Me.TTahunan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKanan.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEntitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKiri.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PanelLapor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelLapor.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLapor.Panel.SuspendLayout()
        Me.PanelLapor.SuspendLayout()
        CType(Me.Ill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLTransaksiDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLGrafikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLTransaksiRingkasanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPelangganRingkasanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPelangganDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLFakturBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangRingkasanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTotalTransaksi
        '
        Me.PanelTotalTransaksi.Location = New System.Drawing.Point(37, 37)
        Me.PanelTotalTransaksi.Name = "PanelTotalTransaksi"
        Me.PanelTotalTransaksi.Palette = Me.PaletSekunder
        Me.PanelTotalTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        '
        'PanelTotalTransaksi.Panel
        '
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.PanelTengah)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.PanelKanan)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.PanelKiri)
        Me.PanelTotalTransaksi.Size = New System.Drawing.Size(1037, 495)
        Me.PanelTotalTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTotalTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelTotalTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PanelTotalTransaksi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelTotalTransaksi.StateCommon.Border.Width = 3
        Me.PanelTotalTransaksi.TabIndex = 119
        '
        'PaletSekunder
        '
        Me.PaletSekunder.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletSekunder.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.PaletSekunder.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PaletSekunder.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PaletSekunder.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'PanelTengah
        '
        Me.PanelTengah.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTengah.Controls.Add(Me.Panel4)
        Me.PanelTengah.Controls.Add(Me.KryptonBorderEdge3)
        Me.PanelTengah.Controls.Add(Me.Panel1)
        Me.PanelTengah.Controls.Add(Me.KryptonBorderEdge1)
        Me.PanelTengah.Controls.Add(Me.PanelPeriodik)
        Me.PanelTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTengah.Location = New System.Drawing.Point(390, 0)
        Me.PanelTengah.Name = "PanelTengah"
        Me.PanelTengah.Size = New System.Drawing.Size(251, 489)
        Me.PanelTengah.TabIndex = 109
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RBRingkasan)
        Me.Panel4.Controls.Add(Me.RBDetail)
        Me.Panel4.Controls.Add(Me.LBLBentuk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 369)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(251, 120)
        Me.Panel4.TabIndex = 116
        '
        'RBRingkasan
        '
        Me.RBRingkasan.Checked = True
        Me.RBRingkasan.Location = New System.Drawing.Point(16, 35)
        Me.RBRingkasan.Name = "RBRingkasan"
        Me.RBRingkasan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBRingkasan.Palette = Me.PaletSekunder
        Me.RBRingkasan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBRingkasan.Size = New System.Drawing.Size(104, 26)
        Me.RBRingkasan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBRingkasan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBRingkasan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBRingkasan.TabIndex = 111
        Me.RBRingkasan.Values.Text = "Ringkasan"
        '
        'RBDetail
        '
        Me.RBDetail.Location = New System.Drawing.Point(16, 67)
        Me.RBDetail.Name = "RBDetail"
        Me.RBDetail.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBDetail.Palette = Me.PaletSekunder
        Me.RBDetail.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBDetail.Size = New System.Drawing.Size(75, 26)
        Me.RBDetail.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBDetail.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDetail.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBDetail.TabIndex = 110
        Me.RBDetail.Values.Text = "Detail"
        '
        'LBLBentuk
        '
        Me.LBLBentuk.AutoSize = False
        Me.LBLBentuk.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLBentuk.Location = New System.Drawing.Point(0, 0)
        Me.LBLBentuk.Name = "LBLBentuk"
        Me.LBLBentuk.Palette = Me.PaletSekunder
        Me.LBLBentuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLBentuk.Size = New System.Drawing.Size(251, 26)
        Me.LBLBentuk.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLBentuk.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBentuk.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBentuk.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBentuk.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLBentuk.TabIndex = 85
        Me.LBLBentuk.Values.Text = "Bentuk"
        '
        'KryptonBorderEdge3
        '
        Me.KryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonBorderEdge3.Location = New System.Drawing.Point(0, 366)
        Me.KryptonBorderEdge3.Name = "KryptonBorderEdge3"
        Me.KryptonBorderEdge3.Size = New System.Drawing.Size(251, 3)
        Me.KryptonBorderEdge3.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.KryptonBorderEdge3.StateCommon.Width = 3
        Me.KryptonBorderEdge3.Text = "KryptonBorderEdge3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBSudah)
        Me.Panel1.Controls.Add(Me.LBLStatusLunas)
        Me.Panel1.Controls.Add(Me.CBBelum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 120)
        Me.Panel1.TabIndex = 110
        '
        'CBSudah
        '
        Me.CBSudah.Location = New System.Drawing.Point(16, 35)
        Me.CBSudah.Name = "CBSudah"
        Me.CBSudah.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBSudah.Palette = Me.PaletSekunder
        Me.CBSudah.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBSudah.Size = New System.Drawing.Size(73, 26)
        Me.CBSudah.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBSudah.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSudah.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.CBSudah.TabIndex = 83
        Me.CBSudah.Values.Text = "Sudah"
        '
        'LBLStatusLunas
        '
        Me.LBLStatusLunas.AutoSize = False
        Me.LBLStatusLunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLStatusLunas.Location = New System.Drawing.Point(0, 0)
        Me.LBLStatusLunas.Name = "LBLStatusLunas"
        Me.LBLStatusLunas.Palette = Me.PaletSekunder
        Me.LBLStatusLunas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLStatusLunas.Size = New System.Drawing.Size(251, 26)
        Me.LBLStatusLunas.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLStatusLunas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLStatusLunas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLStatusLunas.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStatusLunas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLStatusLunas.TabIndex = 85
        Me.LBLStatusLunas.Values.Text = "Status Lunas"
        '
        'CBBelum
        '
        Me.CBBelum.Location = New System.Drawing.Point(16, 67)
        Me.CBBelum.Name = "CBBelum"
        Me.CBBelum.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBBelum.Palette = Me.PaletSekunder
        Me.CBBelum.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBBelum.Size = New System.Drawing.Size(75, 26)
        Me.CBBelum.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBBelum.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBelum.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.CBBelum.TabIndex = 84
        Me.CBBelum.Values.Text = "Belum"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(0, 243)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(251, 3)
        Me.KryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.KryptonBorderEdge1.StateCommon.Width = 3
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'PanelPeriodik
        '
        Me.PanelPeriodik.Controls.Add(Me.LBLTanggalTransaksi)
        Me.PanelPeriodik.Controls.Add(Me.TTahunan)
        Me.PanelPeriodik.Controls.Add(Me.LBLBulanan)
        Me.PanelPeriodik.Controls.Add(Me.LBLPeriodik)
        Me.PanelPeriodik.Controls.Add(Me.LBLTahunan)
        Me.PanelPeriodik.Controls.Add(Me.TBulanan)
        Me.PanelPeriodik.Controls.Add(Me.LBLSampai)
        Me.PanelPeriodik.Controls.Add(Me.TSampai)
        Me.PanelPeriodik.Controls.Add(Me.TDari)
        Me.PanelPeriodik.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPeriodik.Location = New System.Drawing.Point(0, 0)
        Me.PanelPeriodik.Name = "PanelPeriodik"
        Me.PanelPeriodik.Size = New System.Drawing.Size(251, 243)
        Me.PanelPeriodik.TabIndex = 97
        '
        'LBLTanggalTransaksi
        '
        Me.LBLTanggalTransaksi.AutoSize = False
        Me.LBLTanggalTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLTanggalTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.LBLTanggalTransaksi.Name = "LBLTanggalTransaksi"
        Me.LBLTanggalTransaksi.Palette = Me.PaletSekunder
        Me.LBLTanggalTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTanggalTransaksi.Size = New System.Drawing.Size(251, 26)
        Me.LBLTanggalTransaksi.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLTanggalTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTanggalTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTanggalTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggalTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTanggalTransaksi.TabIndex = 261
        Me.LBLTanggalTransaksi.Values.Text = "Tanggal Transaksi"
        '
        'TTahunan
        '
        Me.TTahunan.AlwaysActive = False
        Me.TTahunan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TTahunan.DropDownHeight = 502
        Me.TTahunan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TTahunan.DropDownWidth = 119
        Me.TTahunan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTahunan.IntegralHeight = False
        Me.TTahunan.Location = New System.Drawing.Point(90, 204)
        Me.TTahunan.MaxDropDownItems = 20
        Me.TTahunan.Name = "TTahunan"
        Me.TTahunan.Palette = Me.PaletSekunder
        Me.TTahunan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TTahunan.Size = New System.Drawing.Size(119, 26)
        Me.TTahunan.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TTahunan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTahunan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTahunan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TTahunan.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TTahunan.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green
        Me.TTahunan.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTahunan.StateCommon.Item.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TTahunan.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTahunan.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TTahunan.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTahunan.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TTahunan.TabIndex = 260
        '
        'LBLBulanan
        '
        Me.LBLBulanan.AutoSize = False
        Me.LBLBulanan.Location = New System.Drawing.Point(6, 163)
        Me.LBLBulanan.Name = "LBLBulanan"
        Me.LBLBulanan.Palette = Me.PaletSekunder
        Me.LBLBulanan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLBulanan.Size = New System.Drawing.Size(78, 26)
        Me.LBLBulanan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBulanan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBulanan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBulanan.TabIndex = 94
        Me.LBLBulanan.Values.Text = "Bulanan"
        '
        'LBLPeriodik
        '
        Me.LBLPeriodik.AutoSize = False
        Me.LBLPeriodik.Location = New System.Drawing.Point(86, 36)
        Me.LBLPeriodik.Name = "LBLPeriodik"
        Me.LBLPeriodik.Palette = Me.PaletSekunder
        Me.LBLPeriodik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLPeriodik.Size = New System.Drawing.Size(78, 26)
        Me.LBLPeriodik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPeriodik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPeriodik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPeriodik.TabIndex = 95
        Me.LBLPeriodik.Values.Text = "Periodik"
        '
        'LBLTahunan
        '
        Me.LBLTahunan.AutoSize = False
        Me.LBLTahunan.Location = New System.Drawing.Point(6, 204)
        Me.LBLTahunan.Name = "LBLTahunan"
        Me.LBLTahunan.Palette = Me.PaletSekunder
        Me.LBLTahunan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTahunan.Size = New System.Drawing.Size(78, 26)
        Me.LBLTahunan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTahunan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTahunan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTahunan.TabIndex = 93
        Me.LBLTahunan.Values.Text = "Tahunan"
        '
        'TBulanan
        '
        Me.TBulanan.AlwaysActive = False
        Me.TBulanan.CustomFormat = "MMMM yyyy"
        Me.TBulanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TBulanan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBulanan.Location = New System.Drawing.Point(90, 163)
        Me.TBulanan.Name = "TBulanan"
        Me.TBulanan.Palette = Me.PaletSekunder
        Me.TBulanan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBulanan.Size = New System.Drawing.Size(155, 26)
        Me.TBulanan.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBulanan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TBulanan.TabIndex = 0
        Me.TBulanan.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'LBLSampai
        '
        Me.LBLSampai.AutoSize = False
        Me.LBLSampai.Location = New System.Drawing.Point(90, 95)
        Me.LBLSampai.Name = "LBLSampai"
        Me.LBLSampai.Palette = Me.PaletSekunder
        Me.LBLSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLSampai.Size = New System.Drawing.Size(71, 26)
        Me.LBLSampai.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSampai.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSampai.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSampai.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLSampai.TabIndex = 92
        Me.LBLSampai.Values.Text = "Sampai"
        '
        'TSampai
        '
        Me.TSampai.AlwaysActive = False
        Me.TSampai.CustomFormat = "dd MMMM yyyy"
        Me.TSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TSampai.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSampai.Location = New System.Drawing.Point(48, 122)
        Me.TSampai.Name = "TSampai"
        Me.TSampai.Palette = Me.PaletSekunder
        Me.TSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSampai.Size = New System.Drawing.Size(155, 26)
        Me.TSampai.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSampai.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TSampai.TabIndex = 1
        Me.TSampai.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'TDari
        '
        Me.TDari.AlwaysActive = False
        Me.TDari.CustomFormat = "dd MMMM yyyy"
        Me.TDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TDari.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TDari.Location = New System.Drawing.Point(48, 68)
        Me.TDari.Name = "TDari"
        Me.TDari.Palette = Me.PaletSekunder
        Me.TDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TDari.Size = New System.Drawing.Size(155, 26)
        Me.TDari.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDari.TabIndex = 0
        Me.TDari.ValueNullable = New Date(2022, 9, 23, 0, 0, 0, 0)
        '
        'PanelKanan
        '
        Me.PanelKanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelKanan.Controls.Add(Me.DGVPageCounter)
        Me.PanelKanan.Controls.Add(Me.TCariData)
        Me.PanelKanan.Controls.Add(Me.DGVPrev)
        Me.PanelKanan.Controls.Add(Me.DGVFirst)
        Me.PanelKanan.Controls.Add(Me.DGVNext)
        Me.PanelKanan.Controls.Add(Me.DGVLast)
        Me.PanelKanan.Controls.Add(Me.DGV)
        Me.PanelKanan.Controls.Add(Me.TEntitas)
        Me.PanelKanan.Controls.Add(Me.LBLEntitas)
        Me.PanelKanan.Controls.Add(Me.Pemisah2)
        Me.PanelKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelKanan.Location = New System.Drawing.Point(641, 0)
        Me.PanelKanan.Name = "PanelKanan"
        Me.PanelKanan.Size = New System.Drawing.Size(390, 489)
        Me.PanelKanan.TabIndex = 108
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari data..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(9, 66)
        Me.TCariData.MaxLength = 100
        Me.TCariData.Name = "TCariData"
        Me.TCariData.Palette = Me.PaletSekunder
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TCariData.Size = New System.Drawing.Size(374, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.Gray
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TCariData.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TCariData.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateCommon.Border.Rounding = 0!
        Me.TCariData.StateCommon.Border.Width = 1
        Me.TCariData.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCariData.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TCariData.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariData.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateDisabled.Border.Rounding = 0!
        Me.TCariData.StateDisabled.Border.Width = 0
        Me.TCariData.TabIndex = 130
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(117, 458)
        Me.DGVPrev.Name = "DGVPrev"
        Me.DGVPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.Palette = Me.PaletSekunder
        Me.DGVPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVPrev.Size = New System.Drawing.Size(24, 24)
        Me.DGVPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVPrev.TabIndex = 264
        Me.DGVPrev.Values.Text = "‹"
        '
        'DGVFirst
        '
        Me.DGVFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVFirst.Enabled = False
        Me.DGVFirst.Location = New System.Drawing.Point(90, 458)
        Me.DGVFirst.Name = "DGVFirst"
        Me.DGVFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVFirst.Palette = Me.PaletSekunder
        Me.DGVFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVFirst.Size = New System.Drawing.Size(24, 24)
        Me.DGVFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVFirst.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVFirst.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVFirst.TabIndex = 265
        Me.DGVFirst.Values.Text = "«"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(251, 458)
        Me.DGVNext.Name = "DGVNext"
        Me.DGVNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.Palette = Me.PaletSekunder
        Me.DGVNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVNext.Size = New System.Drawing.Size(24, 24)
        Me.DGVNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVNext.TabIndex = 266
        Me.DGVNext.Values.Text = "›"
        '
        'DGVLast
        '
        Me.DGVLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVLast.Enabled = False
        Me.DGVLast.Location = New System.Drawing.Point(278, 458)
        Me.DGVLast.Name = "DGVLast"
        Me.DGVLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVLast.Palette = Me.PaletSekunder
        Me.DGVLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVLast.Size = New System.Drawing.Size(24, 24)
        Me.DGVLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVLast.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVLast.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVLast.TabIndex = 267
        Me.DGVLast.Values.Text = "»"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(9, 101)
        Me.DGV.Name = "DGV"
        Me.DGV.Palette = Me.PaletSekunder
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(374, 351)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.DGV.TabIndex = 262
        '
        'TEntitas
        '
        Me.TEntitas.AlwaysActive = False
        Me.TEntitas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TEntitas.DropDownHeight = 502
        Me.TEntitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TEntitas.DropDownWidth = 119
        Me.TEntitas.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TEntitas.IntegralHeight = False
        Me.TEntitas.Items.AddRange(New Object() {"Faktur", "Barang", "Pelanggan"})
        Me.TEntitas.Location = New System.Drawing.Point(9, 34)
        Me.TEntitas.MaxDropDownItems = 20
        Me.TEntitas.Name = "TEntitas"
        Me.TEntitas.Palette = Me.PaletSekunder
        Me.TEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TEntitas.Size = New System.Drawing.Size(374, 26)
        Me.TEntitas.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TEntitas.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEntitas.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEntitas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TEntitas.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TEntitas.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green
        Me.TEntitas.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TEntitas.StateCommon.Item.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TEntitas.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEntitas.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TEntitas.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TEntitas.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TEntitas.TabIndex = 261
        '
        'LBLEntitas
        '
        Me.LBLEntitas.AutoSize = False
        Me.LBLEntitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLEntitas.Location = New System.Drawing.Point(3, 0)
        Me.LBLEntitas.Name = "LBLEntitas"
        Me.LBLEntitas.Palette = Me.PaletSekunder
        Me.LBLEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLEntitas.Size = New System.Drawing.Size(387, 26)
        Me.LBLEntitas.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLEntitas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLEntitas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLEntitas.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEntitas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLEntitas.TabIndex = 108
        Me.LBLEntitas.Values.Text = "Transaksi Per Entitas"
        '
        'Pemisah2
        '
        Me.Pemisah2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pemisah2.Location = New System.Drawing.Point(0, 0)
        Me.Pemisah2.Name = "Pemisah2"
        Me.Pemisah2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah2.Palette = Me.PaletSekunder
        Me.Pemisah2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Pemisah2.Size = New System.Drawing.Size(3, 489)
        Me.Pemisah2.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.Pemisah2.StateCommon.Width = 3
        Me.Pemisah2.Text = "KryptonBorderEdge1"
        '
        'PanelKiri
        '
        Me.PanelKiri.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelKiri.Controls.Add(Me.Panel2)
        Me.PanelKiri.Controls.Add(Me.Pemisah1)
        Me.PanelKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelKiri.Location = New System.Drawing.Point(0, 0)
        Me.PanelKiri.Name = "PanelKiri"
        Me.PanelKiri.Size = New System.Drawing.Size(390, 489)
        Me.PanelKiri.TabIndex = 106
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RBGrafik)
        Me.Panel2.Controls.Add(Me.KryptonBorderEdge2)
        Me.Panel2.Controls.Add(Me.LBLFile)
        Me.Panel2.Controls.Add(Me.RBTransaksi)
        Me.Panel2.Controls.Add(Me.RBBarang)
        Me.Panel2.Controls.Add(Me.LBLTransaksi)
        Me.Panel2.Controls.Add(Me.RBPelanggan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 489)
        Me.Panel2.TabIndex = 106
        '
        'RBGrafik
        '
        Me.RBGrafik.Location = New System.Drawing.Point(16, 310)
        Me.RBGrafik.Name = "RBGrafik"
        Me.RBGrafik.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBGrafik.Palette = Me.PaletSekunder
        Me.RBGrafik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBGrafik.Size = New System.Drawing.Size(76, 26)
        Me.RBGrafik.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBGrafik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBGrafik.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBGrafik.TabIndex = 105
        Me.RBGrafik.Values.Text = "Grafik"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(0, 243)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(387, 3)
        Me.KryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.KryptonBorderEdge2.StateCommon.Width = 3
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge1"
        '
        'LBLFile
        '
        Me.LBLFile.AutoSize = False
        Me.LBLFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLFile.Location = New System.Drawing.Point(0, 0)
        Me.LBLFile.Name = "LBLFile"
        Me.LBLFile.Palette = Me.PaletSekunder
        Me.LBLFile.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFile.Size = New System.Drawing.Size(387, 26)
        Me.LBLFile.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLFile.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFile.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFile.TabIndex = 108
        Me.LBLFile.Values.Text = "File"
        '
        'RBTransaksi
        '
        Me.RBTransaksi.Location = New System.Drawing.Point(16, 278)
        Me.RBTransaksi.Name = "RBTransaksi"
        Me.RBTransaksi.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBTransaksi.Palette = Me.PaletSekunder
        Me.RBTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBTransaksi.Size = New System.Drawing.Size(100, 26)
        Me.RBTransaksi.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTransaksi.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBTransaksi.TabIndex = 109
        Me.RBTransaksi.Values.Text = "Transaksi"
        '
        'RBBarang
        '
        Me.RBBarang.Location = New System.Drawing.Point(16, 32)
        Me.RBBarang.Name = "RBBarang"
        Me.RBBarang.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBBarang.Palette = Me.PaletSekunder
        Me.RBBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBBarang.Size = New System.Drawing.Size(81, 26)
        Me.RBBarang.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBBarang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBBarang.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBBarang.TabIndex = 106
        Me.RBBarang.Values.Text = "Barang"
        '
        'LBLTransaksi
        '
        Me.LBLTransaksi.AutoSize = False
        Me.LBLTransaksi.Location = New System.Drawing.Point(0, 246)
        Me.LBLTransaksi.Name = "LBLTransaksi"
        Me.LBLTransaksi.Palette = Me.PaletSekunder
        Me.LBLTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTransaksi.Size = New System.Drawing.Size(387, 26)
        Me.LBLTransaksi.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTransaksi.TabIndex = 108
        Me.LBLTransaksi.Values.Text = "Transaksi / Grafik"
        '
        'RBPelanggan
        '
        Me.RBPelanggan.Location = New System.Drawing.Point(16, 64)
        Me.RBPelanggan.Name = "RBPelanggan"
        Me.RBPelanggan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBPelanggan.Palette = Me.PaletSekunder
        Me.RBPelanggan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBPelanggan.Size = New System.Drawing.Size(106, 26)
        Me.RBPelanggan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBPelanggan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPelanggan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBPelanggan.TabIndex = 107
        Me.RBPelanggan.Values.Text = "Pelanggan"
        '
        'Pemisah1
        '
        Me.Pemisah1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pemisah1.Location = New System.Drawing.Point(387, 0)
        Me.Pemisah1.Name = "Pemisah1"
        Me.Pemisah1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah1.Size = New System.Drawing.Size(3, 489)
        Me.Pemisah1.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.Pemisah1.StateCommon.Width = 3
        Me.Pemisah1.Text = "KryptonBorderEdge1"
        '
        'PanelLapor
        '
        Me.PanelLapor.Location = New System.Drawing.Point(37, 538)
        Me.PanelLapor.Name = "PanelLapor"
        Me.PanelLapor.Palette = Me.PaletSekunder
        Me.PanelLapor.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        '
        'PanelLapor.Panel
        '
        Me.PanelLapor.Panel.Controls.Add(Me.LBLFilter)
        Me.PanelLapor.Size = New System.Drawing.Size(1037, 42)
        Me.PanelLapor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelLapor.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelLapor.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PanelLapor.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelLapor.StateCommon.Border.Rounding = 0!
        Me.PanelLapor.StateCommon.Border.Width = 3
        Me.PanelLapor.TabIndex = 122
        '
        'LBLFilter
        '
        Me.LBLFilter.AutoSize = False
        Me.LBLFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLFilter.Location = New System.Drawing.Point(0, 0)
        Me.LBLFilter.Name = "LBLFilter"
        Me.LBLFilter.Palette = Me.PaletSekunder
        Me.LBLFilter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFilter.Size = New System.Drawing.Size(1031, 36)
        Me.LBLFilter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFilter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilter.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFilter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFilter.TabIndex = 83
        Me.LBLFilter.Values.Text = ""
        '
        'BTNLapor
        '
        Me.BTNLapor.Location = New System.Drawing.Point(401, 586)
        Me.BTNLapor.Name = "BTNLapor"
        Me.BTNLapor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNLapor.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLapor.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLapor.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLapor.Palette = Me.PaletSekunder
        Me.BTNLapor.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNLapor.Size = New System.Drawing.Size(150, 30)
        Me.BTNLapor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNLapor.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLapor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLapor.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLapor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLapor.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLapor.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNLapor.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLapor.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLapor.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BTNLapor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNLapor.TabIndex = 129
        Me.BTNLapor.Values.Text = "Tampil Laporan"
        '
        'BTNBersihkan
        '
        Me.BTNBersihkan.Location = New System.Drawing.Point(559, 586)
        Me.BTNBersihkan.Name = "BTNBersihkan"
        Me.BTNBersihkan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNBersihkan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBersihkan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBersihkan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBersihkan.Palette = Me.PaletSekunder
        Me.BTNBersihkan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNBersihkan.Size = New System.Drawing.Size(150, 30)
        Me.BTNBersihkan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNBersihkan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBersihkan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBersihkan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBersihkan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNBersihkan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBersihkan.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNBersihkan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNBersihkan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNBersihkan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BTNBersihkan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNBersihkan.TabIndex = 128
        Me.BTNBersihkan.Values.Text = "Clear Filter"
        '
        'Ill
        '
        Me.Ill.DataSetName = "Ill"
        Me.Ill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLPelangganBindingSource
        '
        Me.TBLPelangganBindingSource.DataMember = "TBLPelanggan"
        Me.TBLPelangganBindingSource.DataSource = Me.Ill
        '
        'TBLPelangganTableAdapter
        '
        Me.TBLPelangganTableAdapter.ClearBeforeFill = True
        '
        'TBLBarangBindingSource
        '
        Me.TBLBarangBindingSource.DataMember = "TBLBarang"
        Me.TBLBarangBindingSource.DataSource = Me.Ill
        '
        'TBLBarangTableAdapter
        '
        Me.TBLBarangTableAdapter.ClearBeforeFill = True
        '
        'TBLTransaksiDetailBindingSource
        '
        Me.TBLTransaksiDetailBindingSource.DataMember = "TBLTransaksiDetail"
        Me.TBLTransaksiDetailBindingSource.DataSource = Me.Ill
        '
        'TBLTransaksiDetailTableAdapter
        '
        Me.TBLTransaksiDetailTableAdapter.ClearBeforeFill = True
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
        'TBLTransaksiRingkasanBindingSource
        '
        Me.TBLTransaksiRingkasanBindingSource.DataMember = "TBLTransaksiRingkasan"
        Me.TBLTransaksiRingkasanBindingSource.DataSource = Me.Ill
        '
        'TBLTransaksiRingkasanTableAdapter
        '
        Me.TBLTransaksiRingkasanTableAdapter.ClearBeforeFill = True
        '
        'TBLPelangganRingkasanBindingSource
        '
        Me.TBLPelangganRingkasanBindingSource.DataMember = "TBLPelangganRingkasan"
        Me.TBLPelangganRingkasanBindingSource.DataSource = Me.Ill
        '
        'TBLPelangganRingkasanTableAdapter
        '
        Me.TBLPelangganRingkasanTableAdapter.ClearBeforeFill = True
        '
        'TBLPelangganDetailBindingSource
        '
        Me.TBLPelangganDetailBindingSource.DataMember = "TBLPelangganDetail"
        Me.TBLPelangganDetailBindingSource.DataSource = Me.Ill
        '
        'TBLPelangganDetailTableAdapter
        '
        Me.TBLPelangganDetailTableAdapter.ClearBeforeFill = True
        '
        'TBLFakturBindingSource
        '
        Me.TBLFakturBindingSource.DataMember = "TBLFaktur"
        Me.TBLFakturBindingSource.DataSource = Me.Ill
        '
        'TBLFakturTableAdapter
        '
        Me.TBLFakturTableAdapter.ClearBeforeFill = True
        '
        'TBLBarangRingkasanBindingSource
        '
        Me.TBLBarangRingkasanBindingSource.DataMember = "TBLBarangRingkasan"
        Me.TBLBarangRingkasanBindingSource.DataSource = Me.Ill
        '
        'TBLBarangRingkasanTableAdapter
        '
        Me.TBLBarangRingkasanTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AutoSize = False
        Me.DGVPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVPageCounter.Location = New System.Drawing.Point(144, 458)
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVPageCounter.TabIndex = 290
        Me.DGVPageCounter.Values.Text = "1 / 1"
        '
        'Laporan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.BTNLapor)
        Me.Controls.Add(Me.BTNBersihkan)
        Me.Controls.Add(Me.PanelLapor)
        Me.Controls.Add(Me.PanelTotalTransaksi)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Laporan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan"
        CType(Me.PanelTotalTransaksi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalTransaksi.Panel.ResumeLayout(False)
        CType(Me.PanelTotalTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalTransaksi.ResumeLayout(False)
        Me.PanelTengah.ResumeLayout(False)
        Me.PanelTengah.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelPeriodik.ResumeLayout(False)
        CType(Me.TTahunan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKanan.ResumeLayout(False)
        Me.PanelKanan.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEntitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKiri.ResumeLayout(False)
        Me.PanelKiri.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PanelLapor.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLapor.Panel.ResumeLayout(False)
        CType(Me.PanelLapor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLapor.ResumeLayout(False)
        CType(Me.Ill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLTransaksiDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLGrafikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLTransaksiRingkasanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPelangganRingkasanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPelangganDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLFakturBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangRingkasanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTotalTransaksi As Krypton.Toolkit.KryptonGroup
    Friend WithEvents PanelKanan As Panel
    Friend WithEvents LBLEntitas As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Pemisah2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelLapor As Krypton.Toolkit.KryptonGroup
    Friend WithEvents LBLFilter As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TEntitas As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents BTNLapor As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNBersihkan As Krypton.Toolkit.KryptonButton
    Friend WithEvents PanelTengah As Panel
    Friend WithEvents TTahunan As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LBLTahunan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelPeriodik As Panel
    Friend WithEvents LBLPeriodik As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSampai As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TSampai As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents TDari As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBSudah As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LBLStatusLunas As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CBBelum As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents LBLBulanan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TBulanan As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents PanelKiri As Panel
    Friend WithEvents Pemisah1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RBRingkasan As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBDetail As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents LBLBentuk As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge3 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents RBGrafik As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBTransaksi As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents LBLTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBLFile As Krypton.Toolkit.KryptonLabel
    Friend WithEvents RBBarang As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBPelanggan As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLTanggalTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Ill As Ill
    Friend WithEvents TBLPelangganBindingSource As BindingSource
    Friend WithEvents TBLPelangganTableAdapter As IllTableAdapters.TBLPelangganTableAdapter
    Friend WithEvents TBLBarangBindingSource As BindingSource
    Friend WithEvents TBLBarangTableAdapter As IllTableAdapters.TBLBarangTableAdapter
    Friend WithEvents TBLTransaksiDetailBindingSource As BindingSource
    Friend WithEvents TBLTransaksiDetailTableAdapter As IllTableAdapters.TBLTransaksiDetailTableAdapter
    Friend WithEvents TBLGrafikBindingSource As BindingSource
    Friend WithEvents TBLGrafikTableAdapter As IllTableAdapters.TBLGrafikTableAdapter
    Friend WithEvents TBLTransaksiRingkasanBindingSource As BindingSource
    Friend WithEvents TBLTransaksiRingkasanTableAdapter As IllTableAdapters.TBLTransaksiRingkasanTableAdapter
    Friend WithEvents TBLPelangganRingkasanBindingSource As BindingSource
    Friend WithEvents TBLPelangganRingkasanTableAdapter As IllTableAdapters.TBLPelangganRingkasanTableAdapter
    Friend WithEvents TBLPelangganDetailBindingSource As BindingSource
    Friend WithEvents TBLPelangganDetailTableAdapter As IllTableAdapters.TBLPelangganDetailTableAdapter
    Friend WithEvents TBLFakturBindingSource As BindingSource
    Friend WithEvents TBLFakturTableAdapter As IllTableAdapters.TBLFakturTableAdapter
    Friend WithEvents TBLBarangRingkasanBindingSource As BindingSource
    Friend WithEvents TBLBarangRingkasanTableAdapter As IllTableAdapters.TBLBarangRingkasanTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonLabel
End Class
