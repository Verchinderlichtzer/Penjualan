<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TPelanggan = New Krypton.Toolkit.KryptonComboBox()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.LBLTotalHarga = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTerbayar = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPelanggan = New Krypton.Toolkit.KryptonLabel()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarang = New Krypton.Toolkit.KryptonDataGridView()
        Me.DGVBarangCID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBarangCBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBarangCNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBarangCSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBarangCHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBarangCBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTotalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.TTotalHarga = New Krypton.Toolkit.KryptonTextBox()
        Me.TTerbayar = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVLast = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarangPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarangFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarangNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarangLast = New Krypton.Toolkit.KryptonButton()
        Me.TFaktur = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLFaktur = New Krypton.Toolkit.KryptonLabel()
        Me.TSisa = New Krypton.Toolkit.KryptonTextBox()
        Me.TDibayar = New Krypton.Toolkit.KryptonTextBox()
        Me.TBalance = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLBalance = New Krypton.Toolkit.KryptonLabel()
        Me.LBLSisa = New Krypton.Toolkit.KryptonLabel()
        Me.LBLDibayar = New Krypton.Toolkit.KryptonLabel()
        Me.TTglTransaksi = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTglTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.GrupBayar = New Krypton.Toolkit.KryptonGroup()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonLabel()
        Me.DGVBarangPageCounter = New Krypton.Toolkit.KryptonLabel()
        CType(Me.TPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupBayar.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupBayar.Panel.SuspendLayout()
        Me.GrupBayar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TPelanggan
        '
        Me.TPelanggan.AlwaysActive = False
        Me.TPelanggan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TPelanggan.DropDownHeight = 502
        Me.TPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TPelanggan.DropDownWidth = 119
        Me.TPelanggan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TPelanggan.IntegralHeight = False
        Me.TPelanggan.Location = New System.Drawing.Point(330, 8)
        Me.TPelanggan.MaxDropDownItems = 20
        Me.TPelanggan.Name = "TPelanggan"
        Me.TPelanggan.Palette = Me.PaletPrimer
        Me.TPelanggan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TPelanggan.Size = New System.Drawing.Size(515, 26)
        Me.TPelanggan.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TPelanggan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPelanggan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPelanggan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TPelanggan.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TPelanggan.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TPelanggan.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPelanggan.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TPelanggan.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TPelanggan.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TPelanggan.TabIndex = 1
        '
        'PaletPrimer
        '
        Me.PaletPrimer.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletPrimer.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.PaletPrimer.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PaletPrimer.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PaletPrimer.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'LBLTotalHarga
        '
        Me.LBLTotalHarga.AutoSize = False
        Me.LBLTotalHarga.Location = New System.Drawing.Point(7, 591)
        Me.LBLTotalHarga.Name = "LBLTotalHarga"
        Me.LBLTotalHarga.Palette = Me.PaletPrimer
        Me.LBLTotalHarga.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTotalHarga.Size = New System.Drawing.Size(128, 26)
        Me.LBLTotalHarga.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTotalHarga.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTotalHarga.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTotalHarga.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTotalHarga.TabIndex = 221
        Me.LBLTotalHarga.Values.Text = "Total Harga :"
        '
        'LBLTerbayar
        '
        Me.LBLTerbayar.AutoSize = False
        Me.LBLTerbayar.Location = New System.Drawing.Point(304, 559)
        Me.LBLTerbayar.Name = "LBLTerbayar"
        Me.LBLTerbayar.Palette = Me.PaletPrimer
        Me.LBLTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTerbayar.Size = New System.Drawing.Size(96, 26)
        Me.LBLTerbayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTerbayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTerbayar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTerbayar.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTerbayar.TabIndex = 220
        Me.LBLTerbayar.Values.Text = "Terbayar :"
        Me.LBLTerbayar.Visible = False
        '
        'LBLPelanggan
        '
        Me.LBLPelanggan.AutoSize = False
        Me.LBLPelanggan.Location = New System.Drawing.Point(231, 8)
        Me.LBLPelanggan.Name = "LBLPelanggan"
        Me.LBLPelanggan.Palette = Me.PaletPrimer
        Me.LBLPelanggan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLPelanggan.Size = New System.Drawing.Size(93, 26)
        Me.LBLPelanggan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPelanggan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPelanggan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPelanggan.TabIndex = 218
        Me.LBLPelanggan.Values.Text = "Pelanggan"
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Enabled = False
        Me.BTNSimpan.Location = New System.Drawing.Point(937, 550)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.OverrideDefault.Border.Rounding = 0!
        Me.BTNSimpan.OverrideDefault.Border.Width = 3
        Me.BTNSimpan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.Palette = Me.PaletPrimer
        Me.BTNSimpan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNSimpan.Size = New System.Drawing.Size(80, 80)
        Me.BTNSimpan.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNSimpan.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StateCommon.Border.Rounding = 0!
        Me.BTNSimpan.StateCommon.Border.Width = 2
        Me.BTNSimpan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSimpan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpan.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BTNSimpan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNSimpan.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSimpan.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.TabIndex = 6
        Me.BTNSimpan.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.simpan_default
        Me.BTNSimpan.Values.Text = ""
        '
        'BTNClear
        '
        Me.BTNClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNClear.Location = New System.Drawing.Point(1023, 550)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.OverrideDefault.Border.Rounding = 0!
        Me.BTNClear.OverrideDefault.Border.Width = 3
        Me.BTNClear.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.Palette = Me.PaletPrimer
        Me.BTNClear.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNClear.Size = New System.Drawing.Size(80, 80)
        Me.BTNClear.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.BTNClear.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNClear.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StateCommon.Border.Rounding = 0!
        Me.BTNClear.StateCommon.Border.Width = 2
        Me.BTNClear.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNClear.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClear.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BTNClear.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNClear.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNClear.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.TabIndex = 8
        Me.BTNClear.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNClear.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.clear_default
        Me.BTNClear.Values.Text = ""
        '
        'DGVBarang
        '
        Me.DGVBarang.AllowUserToAddRows = False
        Me.DGVBarang.AllowUserToDeleteRows = False
        Me.DGVBarang.AllowUserToResizeColumns = False
        Me.DGVBarang.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBarang.ColumnHeadersHeight = 27
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGVBarangCID, Me.DGVBarangCBarcode, Me.DGVBarangCNama, Me.DGVBarangCSatuan, Me.DGVBarangCHarga, Me.DGVBarangCBarang})
        Me.DGVBarang.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVBarang.HideOuterBorders = True
        Me.DGVBarang.Location = New System.Drawing.Point(851, 40)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.Palette = Me.PaletPrimer
        Me.DGVBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVBarang.ReadOnly = True
        Me.DGVBarang.RowHeadersVisible = False
        Me.DGVBarang.RowTemplate.Height = 27
        Me.DGVBarang.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVBarang.Size = New System.Drawing.Size(252, 459)
        Me.DGVBarang.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVBarang.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGVBarang.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVBarang.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVBarang.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGVBarang.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVBarang.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarang.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarang.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarang.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGVBarang.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarang.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBarang.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBarang.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVBarang.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarang.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGVBarang.TabIndex = 3
        '
        'DGVBarangCID
        '
        Me.DGVBarangCID.HeaderText = "ID Barang"
        Me.DGVBarangCID.Name = "DGVBarangCID"
        Me.DGVBarangCID.ReadOnly = True
        Me.DGVBarangCID.Visible = False
        '
        'DGVBarangCBarcode
        '
        Me.DGVBarangCBarcode.HeaderText = "Barcode"
        Me.DGVBarangCBarcode.Name = "DGVBarangCBarcode"
        Me.DGVBarangCBarcode.ReadOnly = True
        Me.DGVBarangCBarcode.Visible = False
        '
        'DGVBarangCNama
        '
        Me.DGVBarangCNama.HeaderText = "Nama"
        Me.DGVBarangCNama.Name = "DGVBarangCNama"
        Me.DGVBarangCNama.ReadOnly = True
        Me.DGVBarangCNama.Visible = False
        '
        'DGVBarangCSatuan
        '
        Me.DGVBarangCSatuan.HeaderText = "Satuan"
        Me.DGVBarangCSatuan.Name = "DGVBarangCSatuan"
        Me.DGVBarangCSatuan.ReadOnly = True
        Me.DGVBarangCSatuan.Visible = False
        '
        'DGVBarangCHarga
        '
        Me.DGVBarangCHarga.HeaderText = "Harga"
        Me.DGVBarangCHarga.Name = "DGVBarangCHarga"
        Me.DGVBarangCHarga.ReadOnly = True
        Me.DGVBarangCHarga.Visible = False
        '
        'DGVBarangCBarang
        '
        Me.DGVBarangCBarang.HeaderText = "Daftar Barang"
        Me.DGVBarangCBarang.Name = "DGVBarangCBarang"
        Me.DGVBarangCBarang.ReadOnly = True
        Me.DGVBarangCBarang.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVBarangCBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.CBarcode, Me.CNama, Me.CQty, Me.CSatuan, Me.CHarga, Me.CTotalHarga})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 40)
        Me.DGV.Name = "DGV"
        Me.DGV.Palette = Me.PaletPrimer
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(837, 459)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.DGV.TabIndex = 4
        '
        'CID
        '
        Me.CID.HeaderText = "ID Barang"
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Visible = False
        Me.CID.Width = 5
        '
        'CBarcode
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CBarcode.DefaultCellStyle = DataGridViewCellStyle3
        Me.CBarcode.HeaderText = "Barcode"
        Me.CBarcode.Name = "CBarcode"
        Me.CBarcode.ReadOnly = True
        Me.CBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CBarcode.Width = 150
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama Barang"
        Me.CNama.Name = "CNama"
        Me.CNama.ReadOnly = True
        Me.CNama.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNama.Width = 309
        '
        'CQty
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.CQty.HeaderText = "Qty"
        Me.CQty.MaxInputLength = 4
        Me.CQty.Name = "CQty"
        Me.CQty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CQty.Width = 53
        '
        'CSatuan
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CSatuan.DefaultCellStyle = DataGridViewCellStyle5
        Me.CSatuan.HeaderText = "Satuan"
        Me.CSatuan.Name = "CSatuan"
        Me.CSatuan.ReadOnly = True
        Me.CSatuan.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CSatuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CSatuan.Width = 96
        '
        'CHarga
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "#,##0"
        Me.CHarga.DefaultCellStyle = DataGridViewCellStyle6
        Me.CHarga.HeaderText = "Harga"
        Me.CHarga.MaxInputLength = 9
        Me.CHarga.Name = "CHarga"
        Me.CHarga.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHarga.Width = 114
        '
        'CTotalHarga
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "#,##0"
        Me.CTotalHarga.DefaultCellStyle = DataGridViewCellStyle7
        Me.CTotalHarga.HeaderText = "Total Harga"
        Me.CTotalHarga.Name = "CTotalHarga"
        Me.CTotalHarga.ReadOnly = True
        Me.CTotalHarga.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CTotalHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTotalHarga.Width = 114
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari barang..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(851, 8)
        Me.TCariData.MaxLength = 100
        Me.TCariData.Name = "TCariData"
        Me.TCariData.Palette = Me.PaletPrimer
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TCariData.Size = New System.Drawing.Size(252, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariData.StateCommon.Border.Color1 = System.Drawing.Color.Silver
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
        Me.TCariData.TabIndex = 2
        '
        'TTotalHarga
        '
        Me.TTotalHarga.AlwaysActive = False
        Me.TTotalHarga.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTotalHarga.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTotalHarga.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTotalHarga.Enabled = False
        Me.TTotalHarga.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTotalHarga.Location = New System.Drawing.Point(143, 591)
        Me.TTotalHarga.MaxLength = 100
        Me.TTotalHarga.Name = "TTotalHarga"
        Me.TTotalHarga.Palette = Me.PaletPrimer
        Me.TTotalHarga.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TTotalHarga.Size = New System.Drawing.Size(148, 29)
        Me.TTotalHarga.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTotalHarga.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTotalHarga.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotalHarga.StateActive.Border.Rounding = 0!
        Me.TTotalHarga.StateActive.Border.Width = 1
        Me.TTotalHarga.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTotalHarga.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTotalHarga.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TTotalHarga.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTotalHarga.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotalHarga.StateCommon.Border.Rounding = 0!
        Me.TTotalHarga.StateCommon.Border.Width = 1
        Me.TTotalHarga.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTotalHarga.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTotalHarga.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTotalHarga.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotalHarga.StateDisabled.Border.Rounding = 0!
        Me.TTotalHarga.StateDisabled.Border.Width = 0
        Me.TTotalHarga.TabIndex = 265
        '
        'TTerbayar
        '
        Me.TTerbayar.AlwaysActive = False
        Me.TTerbayar.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTerbayar.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTerbayar.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTerbayar.Enabled = False
        Me.TTerbayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTerbayar.Location = New System.Drawing.Point(405, 559)
        Me.TTerbayar.MaxLength = 100
        Me.TTerbayar.Name = "TTerbayar"
        Me.TTerbayar.Palette = Me.PaletPrimer
        Me.TTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TTerbayar.Size = New System.Drawing.Size(118, 29)
        Me.TTerbayar.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTerbayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTerbayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateActive.Border.Rounding = 0!
        Me.TTerbayar.StateActive.Border.Width = 1
        Me.TTerbayar.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTerbayar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TTerbayar.TabIndex = 270
        Me.TTerbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TTerbayar.Visible = False
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(347, 505)
        Me.DGVPrev.Name = "DGVPrev"
        Me.DGVPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.Palette = Me.PaletPrimer
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
        Me.DGVPrev.TabIndex = 268
        Me.DGVPrev.Values.Text = "‹"
        '
        'DGVFirst
        '
        Me.DGVFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVFirst.Enabled = False
        Me.DGVFirst.Location = New System.Drawing.Point(320, 505)
        Me.DGVFirst.Name = "DGVFirst"
        Me.DGVFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVFirst.Palette = Me.PaletPrimer
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
        Me.DGVFirst.TabIndex = 269
        Me.DGVFirst.Values.Text = "«"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(481, 505)
        Me.DGVNext.Name = "DGVNext"
        Me.DGVNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.Palette = Me.PaletPrimer
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
        Me.DGVNext.TabIndex = 270
        Me.DGVNext.Values.Text = "›"
        '
        'DGVLast
        '
        Me.DGVLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVLast.Enabled = False
        Me.DGVLast.Location = New System.Drawing.Point(508, 505)
        Me.DGVLast.Name = "DGVLast"
        Me.DGVLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVLast.Palette = Me.PaletPrimer
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
        Me.DGVLast.TabIndex = 271
        Me.DGVLast.Values.Text = "»"
        '
        'DGVBarangPrev
        '
        Me.DGVBarangPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBarangPrev.Enabled = False
        Me.DGVBarangPrev.Location = New System.Drawing.Point(898, 505)
        Me.DGVBarangPrev.Name = "DGVBarangPrev"
        Me.DGVBarangPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangPrev.Palette = Me.PaletPrimer
        Me.DGVBarangPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVBarangPrev.Size = New System.Drawing.Size(24, 24)
        Me.DGVBarangPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangPrev.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVBarangPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVBarangPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBarangPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVBarangPrev.TabIndex = 273
        Me.DGVBarangPrev.Values.Text = "‹"
        '
        'DGVBarangFirst
        '
        Me.DGVBarangFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBarangFirst.Enabled = False
        Me.DGVBarangFirst.Location = New System.Drawing.Point(871, 505)
        Me.DGVBarangFirst.Name = "DGVBarangFirst"
        Me.DGVBarangFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangFirst.Palette = Me.PaletPrimer
        Me.DGVBarangFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVBarangFirst.Size = New System.Drawing.Size(24, 24)
        Me.DGVBarangFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangFirst.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVBarangFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVBarangFirst.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBarangFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVBarangFirst.TabIndex = 274
        Me.DGVBarangFirst.Values.Text = "«"
        '
        'DGVBarangNext
        '
        Me.DGVBarangNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBarangNext.Enabled = False
        Me.DGVBarangNext.Location = New System.Drawing.Point(1032, 505)
        Me.DGVBarangNext.Name = "DGVBarangNext"
        Me.DGVBarangNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangNext.Palette = Me.PaletPrimer
        Me.DGVBarangNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVBarangNext.Size = New System.Drawing.Size(24, 24)
        Me.DGVBarangNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangNext.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVBarangNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVBarangNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBarangNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVBarangNext.TabIndex = 275
        Me.DGVBarangNext.Values.Text = "›"
        '
        'DGVBarangLast
        '
        Me.DGVBarangLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBarangLast.Enabled = False
        Me.DGVBarangLast.Location = New System.Drawing.Point(1059, 505)
        Me.DGVBarangLast.Name = "DGVBarangLast"
        Me.DGVBarangLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangLast.Palette = Me.PaletPrimer
        Me.DGVBarangLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVBarangLast.Size = New System.Drawing.Size(24, 24)
        Me.DGVBarangLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangLast.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVBarangLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVBarangLast.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBarangLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVBarangLast.TabIndex = 276
        Me.DGVBarangLast.Values.Text = "»"
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
        Me.TFaktur.Location = New System.Drawing.Point(105, 8)
        Me.TFaktur.MaxDropDownItems = 20
        Me.TFaktur.Name = "TFaktur"
        Me.TFaktur.Palette = Me.PaletPrimer
        Me.TFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TFaktur.Size = New System.Drawing.Size(120, 26)
        Me.TFaktur.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TFaktur.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFaktur.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFaktur.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TFaktur.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TFaktur.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TFaktur.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFaktur.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TFaktur.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TFaktur.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TFaktur.TabIndex = 0
        '
        'LBLFaktur
        '
        Me.LBLFaktur.AutoSize = False
        Me.LBLFaktur.Location = New System.Drawing.Point(8, 8)
        Me.LBLFaktur.Name = "LBLFaktur"
        Me.LBLFaktur.Palette = Me.PaletPrimer
        Me.LBLFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFaktur.Size = New System.Drawing.Size(91, 26)
        Me.LBLFaktur.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFaktur.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFaktur.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLFaktur.TabIndex = 279
        Me.LBLFaktur.Values.Text = "No Faktur"
        '
        'TSisa
        '
        Me.TSisa.AlwaysActive = False
        Me.TSisa.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TSisa.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TSisa.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TSisa.Enabled = False
        Me.TSisa.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSisa.Location = New System.Drawing.Point(405, 591)
        Me.TSisa.MaxLength = 100
        Me.TSisa.Name = "TSisa"
        Me.TSisa.Palette = Me.PaletPrimer
        Me.TSisa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSisa.Size = New System.Drawing.Size(118, 29)
        Me.TSisa.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TSisa.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSisa.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSisa.StateActive.Border.Rounding = 0!
        Me.TSisa.StateActive.Border.Width = 1
        Me.TSisa.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TSisa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSisa.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TSisa.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSisa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSisa.StateCommon.Border.Rounding = 0!
        Me.TSisa.StateCommon.Border.Width = 1
        Me.TSisa.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSisa.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TSisa.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSisa.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSisa.StateDisabled.Border.Rounding = 0!
        Me.TSisa.StateDisabled.Border.Width = 0
        Me.TSisa.TabIndex = 284
        Me.TSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TSisa.Visible = False
        '
        'TDibayar
        '
        Me.TDibayar.AlwaysActive = False
        Me.TDibayar.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TDibayar.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TDibayar.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TDibayar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TDibayar.Location = New System.Drawing.Point(695, 559)
        Me.TDibayar.MaxLength = 9
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.Palette = Me.PaletPrimer
        Me.TDibayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TDibayar.Size = New System.Drawing.Size(119, 29)
        Me.TDibayar.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TDibayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDibayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDibayar.StateActive.Border.Rounding = 0!
        Me.TDibayar.StateActive.Border.Width = 1
        Me.TDibayar.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TDibayar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TDibayar.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TDibayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDibayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDibayar.StateCommon.Border.Rounding = 0!
        Me.TDibayar.StateCommon.Border.Width = 1
        Me.TDibayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDibayar.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TDibayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDibayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDibayar.StateDisabled.Border.Rounding = 0!
        Me.TDibayar.StateDisabled.Border.Width = 0
        Me.TDibayar.TabIndex = 5
        Me.TDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBalance
        '
        Me.TBalance.AlwaysActive = False
        Me.TBalance.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TBalance.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TBalance.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TBalance.Enabled = False
        Me.TBalance.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBalance.Location = New System.Drawing.Point(695, 591)
        Me.TBalance.MaxLength = 100
        Me.TBalance.Name = "TBalance"
        Me.TBalance.Palette = Me.PaletPrimer
        Me.TBalance.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBalance.Size = New System.Drawing.Size(119, 29)
        Me.TBalance.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TBalance.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBalance.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBalance.StateActive.Border.Rounding = 0!
        Me.TBalance.StateActive.Border.Width = 1
        Me.TBalance.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TBalance.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TBalance.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TBalance.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBalance.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBalance.StateCommon.Border.Rounding = 0!
        Me.TBalance.StateCommon.Border.Width = 1
        Me.TBalance.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBalance.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TBalance.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBalance.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBalance.StateDisabled.Border.Rounding = 0!
        Me.TBalance.StateDisabled.Border.Width = 0
        Me.TBalance.TabIndex = 285
        Me.TBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLBalance
        '
        Me.LBLBalance.AutoSize = False
        Me.LBLBalance.Location = New System.Drawing.Point(2, 35)
        Me.LBLBalance.Name = "LBLBalance"
        Me.LBLBalance.Palette = Me.PaletPrimer
        Me.LBLBalance.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLBalance.Size = New System.Drawing.Size(88, 26)
        Me.LBLBalance.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBalance.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBalance.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBalance.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLBalance.TabIndex = 283
        Me.LBLBalance.Values.Text = "Sisa :"
        '
        'LBLSisa
        '
        Me.LBLSisa.AutoSize = False
        Me.LBLSisa.Location = New System.Drawing.Point(303, 591)
        Me.LBLSisa.Name = "LBLSisa"
        Me.LBLSisa.Palette = Me.PaletPrimer
        Me.LBLSisa.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLSisa.Size = New System.Drawing.Size(96, 26)
        Me.LBLSisa.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSisa.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSisa.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSisa.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLSisa.TabIndex = 282
        Me.LBLSisa.Values.Text = "Sisa :"
        Me.LBLSisa.Visible = False
        '
        'LBLDibayar
        '
        Me.LBLDibayar.AutoSize = False
        Me.LBLDibayar.Location = New System.Drawing.Point(3, 3)
        Me.LBLDibayar.Name = "LBLDibayar"
        Me.LBLDibayar.Palette = Me.PaletPrimer
        Me.LBLDibayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLDibayar.Size = New System.Drawing.Size(88, 26)
        Me.LBLDibayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDibayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDibayar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDibayar.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLDibayar.TabIndex = 281
        Me.LBLDibayar.Values.Text = "Dibayar :"
        '
        'TTglTransaksi
        '
        Me.TTglTransaksi.AlwaysActive = False
        Me.TTglTransaksi.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTglTransaksi.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTglTransaksi.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTglTransaksi.Enabled = False
        Me.TTglTransaksi.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTglTransaksi.Location = New System.Drawing.Point(143, 559)
        Me.TTglTransaksi.MaxLength = 100
        Me.TTglTransaksi.Name = "TTglTransaksi"
        Me.TTglTransaksi.Palette = Me.PaletPrimer
        Me.TTglTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TTglTransaksi.Size = New System.Drawing.Size(148, 29)
        Me.TTglTransaksi.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTglTransaksi.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTglTransaksi.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTglTransaksi.StateActive.Border.Rounding = 0!
        Me.TTglTransaksi.StateActive.Border.Width = 1
        Me.TTglTransaksi.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTglTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTglTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TTglTransaksi.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTglTransaksi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTglTransaksi.StateCommon.Border.Rounding = 0!
        Me.TTglTransaksi.StateCommon.Border.Width = 1
        Me.TTglTransaksi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTglTransaksi.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTglTransaksi.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTglTransaksi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTglTransaksi.StateDisabled.Border.Rounding = 0!
        Me.TTglTransaksi.StateDisabled.Border.Width = 0
        Me.TTglTransaksi.TabIndex = 287
        '
        'LBLTglTransaksi
        '
        Me.LBLTglTransaksi.AutoSize = False
        Me.LBLTglTransaksi.Location = New System.Drawing.Point(9, 559)
        Me.LBLTglTransaksi.Name = "LBLTglTransaksi"
        Me.LBLTglTransaksi.Palette = Me.PaletPrimer
        Me.LBLTglTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTglTransaksi.Size = New System.Drawing.Size(128, 26)
        Me.LBLTglTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTglTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTglTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTglTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTglTransaksi.TabIndex = 286
        Me.LBLTglTransaksi.Values.Text = "Tgl Transaksi :"
        '
        'GrupBayar
        '
        Me.GrupBayar.Location = New System.Drawing.Point(600, 553)
        Me.GrupBayar.Name = "GrupBayar"
        Me.GrupBayar.Palette = Me.PaletPrimer
        Me.GrupBayar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        '
        'GrupBayar.Panel
        '
        Me.GrupBayar.Panel.Controls.Add(Me.LBLDibayar)
        Me.GrupBayar.Panel.Controls.Add(Me.LBLBalance)
        Me.GrupBayar.Size = New System.Drawing.Size(220, 73)
        Me.GrupBayar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GrupBayar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.GrupBayar.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.GrupBayar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.GrupBayar.StateCommon.Border.Width = 3
        Me.GrupBayar.TabIndex = 288
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AutoSize = False
        Me.DGVPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVPageCounter.Location = New System.Drawing.Point(374, 505)
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.Palette = Me.PaletPrimer
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVPageCounter.TabIndex = 289
        Me.DGVPageCounter.Values.Text = "1 / 1"
        '
        'DGVBarangPageCounter
        '
        Me.DGVBarangPageCounter.AutoSize = False
        Me.DGVBarangPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVBarangPageCounter.Location = New System.Drawing.Point(925, 505)
        Me.DGVBarangPageCounter.Name = "DGVBarangPageCounter"
        Me.DGVBarangPageCounter.Palette = Me.PaletPrimer
        Me.DGVBarangPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVBarangPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVBarangPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVBarangPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVBarangPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBarangPageCounter.TabIndex = 290
        Me.DGVBarangPageCounter.Values.Text = "1 / 1"
        '
        'Transaksi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.DGVBarangPageCounter)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.TDibayar)
        Me.Controls.Add(Me.TBalance)
        Me.Controls.Add(Me.GrupBayar)
        Me.Controls.Add(Me.TTglTransaksi)
        Me.Controls.Add(Me.LBLTglTransaksi)
        Me.Controls.Add(Me.TSisa)
        Me.Controls.Add(Me.LBLSisa)
        Me.Controls.Add(Me.TFaktur)
        Me.Controls.Add(Me.LBLFaktur)
        Me.Controls.Add(Me.DGVBarangPrev)
        Me.Controls.Add(Me.DGVBarangFirst)
        Me.Controls.Add(Me.DGVBarangNext)
        Me.Controls.Add(Me.DGVBarangLast)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVFirst)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.DGVLast)
        Me.Controls.Add(Me.TTotalHarga)
        Me.Controls.Add(Me.TTerbayar)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DGVBarang)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.TPelanggan)
        Me.Controls.Add(Me.LBLTotalHarga)
        Me.Controls.Add(Me.LBLTerbayar)
        Me.Controls.Add(Me.LBLPelanggan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transaksi"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        CType(Me.TPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupBayar.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupBayar.Panel.ResumeLayout(False)
        CType(Me.GrupBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupBayar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TPelanggan As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LBLTotalHarga As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLTerbayar As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLPelanggan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarang As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTotalHarga As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTerbayar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarangPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarangFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarangNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarangLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents TFaktur As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LBLFaktur As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TSisa As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TDibayar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TBalance As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLBalance As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSisa As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLDibayar As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TTglTransaksi As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTglTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents GrupBayar As Krypton.Toolkit.KryptonGroup
    Friend WithEvents DGVBarangCID As DataGridViewTextBoxColumn
    Friend WithEvents DGVBarangCBarcode As DataGridViewTextBoxColumn
    Friend WithEvents DGVBarangCNama As DataGridViewTextBoxColumn
    Friend WithEvents DGVBarangCSatuan As DataGridViewTextBoxColumn
    Friend WithEvents DGVBarangCHarga As DataGridViewTextBoxColumn
    Friend WithEvents DGVBarangCBarang As DataGridViewTextBoxColumn
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents CBarcode As DataGridViewTextBoxColumn
    Friend WithEvents CNama As DataGridViewTextBoxColumn
    Friend WithEvents CQty As DataGridViewTextBoxColumn
    Friend WithEvents CSatuan As DataGridViewTextBoxColumn
    Friend WithEvents CHarga As DataGridViewTextBoxColumn
    Friend WithEvents CTotalHarga As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGVBarangPageCounter As Krypton.Toolkit.KryptonLabel
End Class
