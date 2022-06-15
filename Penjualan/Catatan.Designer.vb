<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Catatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catatan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TPelanggan = New Krypton.Toolkit.KryptonComboBox()
        Me.TBarang = New Krypton.Toolkit.KryptonComboBox()
        Me.TFaktur = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLEntitas = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPelanggan = New Krypton.Toolkit.KryptonLabel()
        Me.LBLBarang = New Krypton.Toolkit.KryptonLabel()
        Me.LBLFaktur = New Krypton.Toolkit.KryptonLabel()
        Me.Pemisah2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CBTanggalTransaksi = New Krypton.Toolkit.KryptonCheckBox()
        Me.TDari = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.TSampai = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.LBLSampai = New Krypton.Toolkit.KryptonLabel()
        Me.LBLDari = New Krypton.Toolkit.KryptonLabel()
        Me.Pemisah1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CBBelum = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBSudah = New Krypton.Toolkit.KryptonCheckBox()
        Me.LBLLunas = New Krypton.Toolkit.KryptonLabel()
        Me.DGVKiri = New Krypton.Toolkit.KryptonDataGridView()
        Me.DGVKiriPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVKiriFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVKiriNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVKiriLast = New Krypton.Toolkit.KryptonButton()
        Me.DGVKananPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVKananFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVKananNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVKananLast = New Krypton.Toolkit.KryptonButton()
        Me.DGVKanan = New Krypton.Toolkit.KryptonDataGridView()
        Me.LBLFilterKiri = New Krypton.Toolkit.KryptonLabel()
        Me.LBLFilterKanan = New Krypton.Toolkit.KryptonLabel()
        Me.DGVKiriPageCounter = New Krypton.Toolkit.KryptonLabel()
        Me.DGVKananPageCounter = New Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.TPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGVKiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVKanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(8, 8)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        Me.KryptonGroup1.Palette = Me.PaletSekunder
        Me.KryptonGroup1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1095, 115)
        Me.KryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Width = 3
        Me.KryptonGroup1.TabIndex = 176
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Pemisah2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Pemisah1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 109)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TPelanggan)
        Me.Panel4.Controls.Add(Me.TBarang)
        Me.Panel4.Controls.Add(Me.TFaktur)
        Me.Panel4.Controls.Add(Me.LBLEntitas)
        Me.Panel4.Controls.Add(Me.LBLPelanggan)
        Me.Panel4.Controls.Add(Me.LBLBarang)
        Me.Panel4.Controls.Add(Me.LBLFaktur)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(720, 109)
        Me.Panel4.TabIndex = 49
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
        Me.TPelanggan.Location = New System.Drawing.Point(102, 81)
        Me.TPelanggan.MaxDropDownItems = 20
        Me.TPelanggan.Name = "TPelanggan"
        Me.TPelanggan.Palette = Me.PaletSekunder
        Me.TPelanggan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TPelanggan.Size = New System.Drawing.Size(612, 26)
        Me.TPelanggan.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TPelanggan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPelanggan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPelanggan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TPelanggan.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TPelanggan.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green
        Me.TPelanggan.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPelanggan.StateCommon.Item.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TPelanggan.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPelanggan.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TPelanggan.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPelanggan.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TPelanggan.TabIndex = 259
        '
        'TBarang
        '
        Me.TBarang.AlwaysActive = False
        Me.TBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TBarang.DropDownHeight = 502
        Me.TBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TBarang.DropDownWidth = 119
        Me.TBarang.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBarang.IntegralHeight = False
        Me.TBarang.Location = New System.Drawing.Point(102, 54)
        Me.TBarang.MaxDropDownItems = 20
        Me.TBarang.Name = "TBarang"
        Me.TBarang.Palette = Me.PaletSekunder
        Me.TBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBarang.Size = New System.Drawing.Size(612, 26)
        Me.TBarang.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TBarang.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBarang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBarang.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TBarang.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TBarang.StateCommon.Item.Back.Color1 = System.Drawing.Color.Green
        Me.TBarang.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBarang.StateCommon.Item.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TBarang.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBarang.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TBarang.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBarang.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TBarang.TabIndex = 259
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
        Me.TFaktur.Location = New System.Drawing.Point(102, 27)
        Me.TFaktur.MaxDropDownItems = 20
        Me.TFaktur.Name = "TFaktur"
        Me.TFaktur.Palette = Me.PaletSekunder
        Me.TFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TFaktur.Size = New System.Drawing.Size(612, 26)
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
        Me.TFaktur.TabIndex = 259
        '
        'LBLEntitas
        '
        Me.LBLEntitas.AutoSize = False
        Me.LBLEntitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLEntitas.Location = New System.Drawing.Point(0, 0)
        Me.LBLEntitas.Name = "LBLEntitas"
        Me.LBLEntitas.Palette = Me.PaletSekunder
        Me.LBLEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLEntitas.Size = New System.Drawing.Size(720, 26)
        Me.LBLEntitas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLEntitas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLEntitas.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLEntitas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLEntitas.TabIndex = 13
        Me.LBLEntitas.Values.Text = "Entitas"
        '
        'LBLPelanggan
        '
        Me.LBLPelanggan.AutoSize = False
        Me.LBLPelanggan.Location = New System.Drawing.Point(3, 81)
        Me.LBLPelanggan.Name = "LBLPelanggan"
        Me.LBLPelanggan.Palette = Me.PaletSekunder
        Me.LBLPelanggan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLPelanggan.Size = New System.Drawing.Size(93, 26)
        Me.LBLPelanggan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPelanggan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPelanggan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPelanggan.TabIndex = 13
        Me.LBLPelanggan.Values.Text = "Pelanggan"
        '
        'LBLBarang
        '
        Me.LBLBarang.AutoSize = False
        Me.LBLBarang.Location = New System.Drawing.Point(3, 54)
        Me.LBLBarang.Name = "LBLBarang"
        Me.LBLBarang.Palette = Me.PaletSekunder
        Me.LBLBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLBarang.Size = New System.Drawing.Size(93, 26)
        Me.LBLBarang.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBarang.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBarang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBarang.TabIndex = 13
        Me.LBLBarang.Values.Text = "Barang"
        '
        'LBLFaktur
        '
        Me.LBLFaktur.AutoSize = False
        Me.LBLFaktur.Location = New System.Drawing.Point(3, 27)
        Me.LBLFaktur.Name = "LBLFaktur"
        Me.LBLFaktur.Palette = Me.PaletSekunder
        Me.LBLFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFaktur.Size = New System.Drawing.Size(93, 26)
        Me.LBLFaktur.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFaktur.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFaktur.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLFaktur.TabIndex = 13
        Me.LBLFaktur.Values.Text = "Faktur"
        '
        'Pemisah2
        '
        Me.Pemisah2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pemisah2.Location = New System.Drawing.Point(720, 0)
        Me.Pemisah2.Name = "Pemisah2"
        Me.Pemisah2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah2.Palette = Me.PaletSekunder
        Me.Pemisah2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Pemisah2.Size = New System.Drawing.Size(3, 109)
        Me.Pemisah2.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.Pemisah2.StateCommon.Width = 3
        Me.Pemisah2.Text = "KryptonBorderEdge4"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CBTanggalTransaksi)
        Me.Panel3.Controls.Add(Me.TDari)
        Me.Panel3.Controls.Add(Me.TSampai)
        Me.Panel3.Controls.Add(Me.LBLSampai)
        Me.Panel3.Controls.Add(Me.LBLDari)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(723, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 109)
        Me.Panel3.TabIndex = 47
        '
        'CBTanggalTransaksi
        '
        Me.CBTanggalTransaksi.Enabled = False
        Me.CBTanggalTransaksi.Location = New System.Drawing.Point(11, 0)
        Me.CBTanggalTransaksi.Name = "CBTanggalTransaksi"
        Me.CBTanggalTransaksi.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTanggalTransaksi.Palette = Me.PaletSekunder
        Me.CBTanggalTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBTanggalTransaksi.Size = New System.Drawing.Size(170, 26)
        Me.CBTanggalTransaksi.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTanggalTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBTanggalTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBTanggalTransaksi.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBTanggalTransaksi.TabIndex = 16
        Me.CBTanggalTransaksi.Values.Text = "Tanggal Transaksi"
        '
        'TDari
        '
        Me.TDari.AlwaysActive = False
        Me.TDari.CustomFormat = "dd/MM/yyyy"
        Me.TDari.Enabled = False
        Me.TDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TDari.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TDari.Location = New System.Drawing.Point(84, 38)
        Me.TDari.Name = "TDari"
        Me.TDari.Palette = Me.PaletSekunder
        Me.TDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TDari.Size = New System.Drawing.Size(101, 26)
        Me.TDari.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TDari.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDari.TabIndex = 0
        Me.TDari.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'TSampai
        '
        Me.TSampai.AlwaysActive = False
        Me.TSampai.CustomFormat = "dd/MM/yyyy"
        Me.TSampai.Enabled = False
        Me.TSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TSampai.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSampai.Location = New System.Drawing.Point(84, 70)
        Me.TSampai.Name = "TSampai"
        Me.TSampai.Palette = Me.PaletSekunder
        Me.TSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSampai.Size = New System.Drawing.Size(101, 26)
        Me.TSampai.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TSampai.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSampai.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TSampai.TabIndex = 1
        Me.TSampai.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'LBLSampai
        '
        Me.LBLSampai.AutoSize = False
        Me.LBLSampai.Location = New System.Drawing.Point(6, 70)
        Me.LBLSampai.Name = "LBLSampai"
        Me.LBLSampai.Palette = Me.PaletSekunder
        Me.LBLSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLSampai.Size = New System.Drawing.Size(70, 26)
        Me.LBLSampai.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSampai.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSampai.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSampai.TabIndex = 13
        Me.LBLSampai.Values.Text = "Sampai"
        '
        'LBLDari
        '
        Me.LBLDari.AutoSize = False
        Me.LBLDari.Location = New System.Drawing.Point(6, 38)
        Me.LBLDari.Name = "LBLDari"
        Me.LBLDari.Palette = Me.PaletSekunder
        Me.LBLDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLDari.Size = New System.Drawing.Size(70, 26)
        Me.LBLDari.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDari.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDari.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDari.TabIndex = 13
        Me.LBLDari.Values.Text = "Dari"
        '
        'Pemisah1
        '
        Me.Pemisah1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pemisah1.Location = New System.Drawing.Point(916, 0)
        Me.Pemisah1.Name = "Pemisah1"
        Me.Pemisah1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah1.Palette = Me.PaletSekunder
        Me.Pemisah1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Pemisah1.Size = New System.Drawing.Size(3, 109)
        Me.Pemisah1.StateCommon.Color1 = System.Drawing.Color.Gray
        Me.Pemisah1.StateCommon.Width = 3
        Me.Pemisah1.Text = "KryptonBorderEdge4"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel5.Controls.Add(Me.CBBelum)
        Me.Panel5.Controls.Add(Me.CBSudah)
        Me.Panel5.Controls.Add(Me.LBLLunas)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(919, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(170, 109)
        Me.Panel5.TabIndex = 46
        '
        'CBBelum
        '
        Me.CBBelum.Enabled = False
        Me.CBBelum.Location = New System.Drawing.Point(6, 70)
        Me.CBBelum.Name = "CBBelum"
        Me.CBBelum.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBBelum.Palette = Me.PaletSekunder
        Me.CBBelum.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBBelum.Size = New System.Drawing.Size(75, 26)
        Me.CBBelum.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBBelum.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBelum.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!)
        Me.CBBelum.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBBelum.TabIndex = 15
        Me.CBBelum.Values.Text = "Belum"
        '
        'CBSudah
        '
        Me.CBSudah.Enabled = False
        Me.CBSudah.Location = New System.Drawing.Point(6, 38)
        Me.CBSudah.Name = "CBSudah"
        Me.CBSudah.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBSudah.Palette = Me.PaletSekunder
        Me.CBSudah.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBSudah.Size = New System.Drawing.Size(73, 26)
        Me.CBSudah.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBSudah.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBSudah.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!)
        Me.CBSudah.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBSudah.TabIndex = 14
        Me.CBSudah.Values.Text = "Sudah"
        '
        'LBLLunas
        '
        Me.LBLLunas.AutoSize = False
        Me.LBLLunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLLunas.Location = New System.Drawing.Point(0, 0)
        Me.LBLLunas.Name = "LBLLunas"
        Me.LBLLunas.Palette = Me.PaletSekunder
        Me.LBLLunas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLLunas.Size = New System.Drawing.Size(170, 26)
        Me.LBLLunas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLLunas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLunas.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLLunas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLLunas.TabIndex = 13
        Me.LBLLunas.Values.Text = "Lunas?"
        '
        'DGVKiri
        '
        Me.DGVKiri.AllowUserToAddRows = False
        Me.DGVKiri.AllowUserToDeleteRows = False
        Me.DGVKiri.AllowUserToResizeColumns = False
        Me.DGVKiri.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVKiri.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVKiri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVKiri.ColumnHeadersHeight = 27
        Me.DGVKiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVKiri.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVKiri.HideOuterBorders = True
        Me.DGVKiri.Location = New System.Drawing.Point(8, 182)
        Me.DGVKiri.Name = "DGVKiri"
        Me.DGVKiri.Palette = Me.PaletSekunder
        Me.DGVKiri.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKiri.ReadOnly = True
        Me.DGVKiri.RowHeadersVisible = False
        Me.DGVKiri.RowTemplate.Height = 27
        Me.DGVKiri.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVKiri.Size = New System.Drawing.Size(442, 405)
        Me.DGVKiri.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVKiri.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGVKiri.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVKiri.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVKiri.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGVKiri.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVKiri.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKiri.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiri.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiri.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGVKiri.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKiri.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVKiri.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVKiri.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVKiri.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiri.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGVKiri.TabIndex = 255
        '
        'DGVKiriPrev
        '
        Me.DGVKiriPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKiriPrev.Enabled = False
        Me.DGVKiriPrev.Location = New System.Drawing.Point(150, 593)
        Me.DGVKiriPrev.Name = "DGVKiriPrev"
        Me.DGVKiriPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriPrev.Palette = Me.PaletSekunder
        Me.DGVKiriPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKiriPrev.Size = New System.Drawing.Size(24, 24)
        Me.DGVKiriPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriPrev.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKiriPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKiriPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKiriPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKiriPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKiriPrev.TabIndex = 256
        Me.DGVKiriPrev.Values.Text = "‹"
        '
        'DGVKiriFirst
        '
        Me.DGVKiriFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKiriFirst.Enabled = False
        Me.DGVKiriFirst.Location = New System.Drawing.Point(123, 593)
        Me.DGVKiriFirst.Name = "DGVKiriFirst"
        Me.DGVKiriFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriFirst.Palette = Me.PaletSekunder
        Me.DGVKiriFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKiriFirst.Size = New System.Drawing.Size(24, 24)
        Me.DGVKiriFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriFirst.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKiriFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKiriFirst.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKiriFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKiriFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKiriFirst.TabIndex = 257
        Me.DGVKiriFirst.Values.Text = "«"
        '
        'DGVKiriNext
        '
        Me.DGVKiriNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKiriNext.Enabled = False
        Me.DGVKiriNext.Location = New System.Drawing.Point(284, 593)
        Me.DGVKiriNext.Name = "DGVKiriNext"
        Me.DGVKiriNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriNext.Palette = Me.PaletSekunder
        Me.DGVKiriNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKiriNext.Size = New System.Drawing.Size(24, 24)
        Me.DGVKiriNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriNext.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKiriNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKiriNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKiriNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKiriNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKiriNext.TabIndex = 258
        Me.DGVKiriNext.Values.Text = "›"
        '
        'DGVKiriLast
        '
        Me.DGVKiriLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKiriLast.Enabled = False
        Me.DGVKiriLast.Location = New System.Drawing.Point(311, 593)
        Me.DGVKiriLast.Name = "DGVKiriLast"
        Me.DGVKiriLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriLast.Palette = Me.PaletSekunder
        Me.DGVKiriLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKiriLast.Size = New System.Drawing.Size(24, 24)
        Me.DGVKiriLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKiriLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKiriLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKiriLast.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKiriLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKiriLast.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKiriLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKiriLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKiriLast.TabIndex = 259
        Me.DGVKiriLast.Values.Text = "»"
        '
        'DGVKananPrev
        '
        Me.DGVKananPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKananPrev.Enabled = False
        Me.DGVKananPrev.Location = New System.Drawing.Point(700, 593)
        Me.DGVKananPrev.Name = "DGVKananPrev"
        Me.DGVKananPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananPrev.Palette = Me.PaletSekunder
        Me.DGVKananPrev.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKananPrev.Size = New System.Drawing.Size(24, 24)
        Me.DGVKananPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananPrev.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKananPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKananPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKananPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKananPrev.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKananPrev.TabIndex = 261
        Me.DGVKananPrev.Values.Text = "‹"
        '
        'DGVKananFirst
        '
        Me.DGVKananFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKananFirst.Enabled = False
        Me.DGVKananFirst.Location = New System.Drawing.Point(673, 593)
        Me.DGVKananFirst.Name = "DGVKananFirst"
        Me.DGVKananFirst.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananFirst.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananFirst.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananFirst.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananFirst.Palette = Me.PaletSekunder
        Me.DGVKananFirst.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKananFirst.Size = New System.Drawing.Size(24, 24)
        Me.DGVKananFirst.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananFirst.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananFirst.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananFirst.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananFirst.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKananFirst.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKananFirst.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKananFirst.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKananFirst.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKananFirst.TabIndex = 262
        Me.DGVKananFirst.Values.Text = "«"
        '
        'DGVKananNext
        '
        Me.DGVKananNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKananNext.Enabled = False
        Me.DGVKananNext.Location = New System.Drawing.Point(834, 593)
        Me.DGVKananNext.Name = "DGVKananNext"
        Me.DGVKananNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananNext.Palette = Me.PaletSekunder
        Me.DGVKananNext.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKananNext.Size = New System.Drawing.Size(24, 24)
        Me.DGVKananNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananNext.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKananNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKananNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKananNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKananNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKananNext.TabIndex = 263
        Me.DGVKananNext.Values.Text = "›"
        '
        'DGVKananLast
        '
        Me.DGVKananLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVKananLast.Enabled = False
        Me.DGVKananLast.Location = New System.Drawing.Point(861, 593)
        Me.DGVKananLast.Name = "DGVKananLast"
        Me.DGVKananLast.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananLast.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananLast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananLast.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananLast.Palette = Me.PaletSekunder
        Me.DGVKananLast.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKananLast.Size = New System.Drawing.Size(24, 24)
        Me.DGVKananLast.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVKananLast.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananLast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKananLast.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVKananLast.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.DGVKananLast.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DGVKananLast.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKananLast.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVKananLast.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DGVKananLast.TabIndex = 264
        Me.DGVKananLast.Values.Text = "»"
        '
        'DGVKanan
        '
        Me.DGVKanan.AllowUserToAddRows = False
        Me.DGVKanan.AllowUserToDeleteRows = False
        Me.DGVKanan.AllowUserToResizeColumns = False
        Me.DGVKanan.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVKanan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVKanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVKanan.ColumnHeadersHeight = 27
        Me.DGVKanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVKanan.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVKanan.HideOuterBorders = True
        Me.DGVKanan.Location = New System.Drawing.Point(456, 182)
        Me.DGVKanan.Name = "DGVKanan"
        Me.DGVKanan.Palette = Me.PaletSekunder
        Me.DGVKanan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVKanan.ReadOnly = True
        Me.DGVKanan.RowHeadersVisible = False
        Me.DGVKanan.RowTemplate.Height = 27
        Me.DGVKanan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVKanan.Size = New System.Drawing.Size(647, 405)
        Me.DGVKanan.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVKanan.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGVKanan.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVKanan.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVKanan.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGVKanan.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVKanan.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKanan.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKanan.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKanan.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGVKanan.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVKanan.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVKanan.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVKanan.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVKanan.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVKanan.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGVKanan.TabIndex = 266
        '
        'LBLFilterKiri
        '
        Me.LBLFilterKiri.AutoSize = False
        Me.LBLFilterKiri.Location = New System.Drawing.Point(8, 124)
        Me.LBLFilterKiri.Name = "LBLFilterKiri"
        Me.LBLFilterKiri.Palette = Me.PaletSekunder
        Me.LBLFilterKiri.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFilterKiri.Size = New System.Drawing.Size(1095, 26)
        Me.LBLFilterKiri.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFilterKiri.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilterKiri.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFilterKiri.TabIndex = 267
        Me.LBLFilterKiri.Values.Text = ""
        '
        'LBLFilterKanan
        '
        Me.LBLFilterKanan.AutoSize = False
        Me.LBLFilterKanan.Location = New System.Drawing.Point(8, 153)
        Me.LBLFilterKanan.Name = "LBLFilterKanan"
        Me.LBLFilterKanan.Palette = Me.PaletSekunder
        Me.LBLFilterKanan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFilterKanan.Size = New System.Drawing.Size(1095, 26)
        Me.LBLFilterKanan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFilterKanan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilterKanan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFilterKanan.TabIndex = 268
        Me.LBLFilterKanan.Values.Text = ""
        '
        'DGVKiriPageCounter
        '
        Me.DGVKiriPageCounter.AutoSize = False
        Me.DGVKiriPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVKiriPageCounter.Location = New System.Drawing.Point(177, 593)
        Me.DGVKiriPageCounter.Name = "DGVKiriPageCounter"
        Me.DGVKiriPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVKiriPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVKiriPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKiriPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVKiriPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVKiriPageCounter.TabIndex = 290
        Me.DGVKiriPageCounter.Values.Text = "1 / 1"
        '
        'DGVKananPageCounter
        '
        Me.DGVKananPageCounter.AutoSize = False
        Me.DGVKananPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVKananPageCounter.Location = New System.Drawing.Point(727, 593)
        Me.DGVKananPageCounter.Name = "DGVKananPageCounter"
        Me.DGVKananPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVKananPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVKananPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVKananPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVKananPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVKananPageCounter.TabIndex = 291
        Me.DGVKananPageCounter.Values.Text = "1 / 1"
        '
        'Catatan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.DGVKananPageCounter)
        Me.Controls.Add(Me.DGVKiriPageCounter)
        Me.Controls.Add(Me.LBLFilterKanan)
        Me.Controls.Add(Me.LBLFilterKiri)
        Me.Controls.Add(Me.DGVKanan)
        Me.Controls.Add(Me.DGVKananPrev)
        Me.Controls.Add(Me.DGVKananFirst)
        Me.Controls.Add(Me.DGVKananNext)
        Me.Controls.Add(Me.DGVKananLast)
        Me.Controls.Add(Me.DGVKiri)
        Me.Controls.Add(Me.DGVKiriPrev)
        Me.Controls.Add(Me.DGVKiriFirst)
        Me.Controls.Add(Me.DGVKiriNext)
        Me.Controls.Add(Me.DGVKiriLast)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Catatan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catatan"
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.TPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGVKiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVKanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TBarang As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LBLEntitas As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBarang As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Pemisah2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TDari As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents TSampai As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents LBLSampai As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLDari As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Pemisah1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LBLLunas As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents DGVKiri As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVKiriPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKiriFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKiriNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKiriLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents TPelanggan As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TFaktur As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LBLPelanggan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLFaktur As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CBBelum As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBSudah As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents DGVKananPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKananFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKananNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKananLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVKanan As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CBTanggalTransaksi As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LBLFilterKiri As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLFilterKanan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGVKiriPageCounter As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGVKananPageCounter As Krypton.Toolkit.KryptonLabel
End Class
