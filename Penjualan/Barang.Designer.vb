<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.TID = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLID = New Krypton.Toolkit.KryptonLabel()
        Me.LBLNama = New Krypton.Toolkit.KryptonLabel()
        Me.TNama = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLSatuan = New Krypton.Toolkit.KryptonLabel()
        Me.TSatuan = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLKategori = New Krypton.Toolkit.KryptonLabel()
        Me.TKategori = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLHarga = New Krypton.Toolkit.KryptonLabel()
        Me.THarga = New Krypton.Toolkit.KryptonTextBox()
        Me.TBarcode = New Krypton.Toolkit.KryptonTextBox()
        Me.Barcode = New Krypton.Toolkit.KryptonLabel()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUkuran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVLast = New Krypton.Toolkit.KryptonButton()
        Me.DGVFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.LBLUkuran = New Krypton.Toolkit.KryptonLabel()
        Me.TUkuran = New Krypton.Toolkit.KryptonTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonLabel()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BTNSimpan
        '
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Enabled = False
        Me.BTNSimpan.Location = New System.Drawing.Point(851, 550)
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
        Me.BTNSimpan.TabIndex = 8
        Me.BTNSimpan.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.simpan_default
        Me.BTNSimpan.Values.Text = ""
        '
        'BTNHapus
        '
        Me.BTNHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHapus.Location = New System.Drawing.Point(937, 550)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNHapus.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.OverrideDefault.Border.Rounding = 0!
        Me.BTNHapus.OverrideDefault.Border.Width = 3
        Me.BTNHapus.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNHapus.Palette = Me.PaletPrimer
        Me.BTNHapus.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNHapus.Size = New System.Drawing.Size(80, 80)
        Me.BTNHapus.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.BTNHapus.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNHapus.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNHapus.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StateCommon.Border.Rounding = 0!
        Me.BTNHapus.StateCommon.Border.Width = 2
        Me.BTNHapus.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNHapus.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNHapus.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapus.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BTNHapus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNHapus.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNHapus.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.TabIndex = 9
        Me.BTNHapus.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNHapus.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNHapus.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNHapus.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.hapus_default
        Me.BTNHapus.Values.Text = ""
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
        Me.BTNClear.TabIndex = 10
        Me.BTNClear.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNClear.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.clear_default
        Me.BTNClear.Values.Text = ""
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari barang..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(8, 550)
        Me.TCariData.MaxLength = 100
        Me.TCariData.Name = "TCariData"
        Me.TCariData.Palette = Me.PaletPrimer
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TCariData.Size = New System.Drawing.Size(837, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.Gray
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TCariData.TabIndex = 7
        '
        'TID
        '
        Me.TID.AlwaysActive = False
        Me.TID.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TID.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TID.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TID.Enabled = False
        Me.TID.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TID.Location = New System.Drawing.Point(130, 8)
        Me.TID.MaxLength = 100
        Me.TID.Name = "TID"
        Me.TID.Palette = Me.PaletPrimer
        Me.TID.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TID.Size = New System.Drawing.Size(61, 29)
        Me.TID.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TID.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TID.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateActive.Border.Rounding = 0!
        Me.TID.StateActive.Border.Width = 1
        Me.TID.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TID.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TID.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateCommon.Border.Rounding = 0!
        Me.TID.StateCommon.Border.Width = 1
        Me.TID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TID.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TID.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TID.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateDisabled.Border.Rounding = 0!
        Me.TID.StateDisabled.Border.Width = 0
        Me.TID.TabIndex = 244
        '
        'LBLID
        '
        Me.LBLID.AutoSize = False
        Me.LBLID.Location = New System.Drawing.Point(8, 8)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Palette = Me.PaletPrimer
        Me.LBLID.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLID.Size = New System.Drawing.Size(116, 26)
        Me.LBLID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLID.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLID.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLID.TabIndex = 248
        Me.LBLID.Values.Text = "ID"
        '
        'LBLNama
        '
        Me.LBLNama.AutoSize = False
        Me.LBLNama.Location = New System.Drawing.Point(8, 40)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.Palette = Me.PaletPrimer
        Me.LBLNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLNama.Size = New System.Drawing.Size(116, 26)
        Me.LBLNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLNama.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLNama.TabIndex = 248
        Me.LBLNama.Values.Text = "Nama Barang"
        '
        'TNama
        '
        Me.TNama.AlwaysActive = False
        Me.TNama.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TNama.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TNama.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TNama.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TNama.Location = New System.Drawing.Point(130, 40)
        Me.TNama.MaxLength = 100
        Me.TNama.Name = "TNama"
        Me.TNama.Palette = Me.PaletPrimer
        Me.TNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TNama.Size = New System.Drawing.Size(973, 29)
        Me.TNama.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TNama.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNama.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateActive.Border.Rounding = 0!
        Me.TNama.StateActive.Border.Width = 1
        Me.TNama.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TNama.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TNama.TabIndex = 0
        '
        'LBLSatuan
        '
        Me.LBLSatuan.AutoSize = False
        Me.LBLSatuan.Location = New System.Drawing.Point(290, 104)
        Me.LBLSatuan.Name = "LBLSatuan"
        Me.LBLSatuan.Palette = Me.PaletPrimer
        Me.LBLSatuan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLSatuan.Size = New System.Drawing.Size(66, 26)
        Me.LBLSatuan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSatuan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSatuan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSatuan.TabIndex = 248
        Me.LBLSatuan.Values.Text = "Satuan"
        '
        'TSatuan
        '
        Me.TSatuan.AlwaysActive = False
        Me.TSatuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TSatuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TSatuan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TSatuan.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TSatuan.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TSatuan.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TSatuan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSatuan.Location = New System.Drawing.Point(362, 104)
        Me.TSatuan.MaxLength = 100
        Me.TSatuan.Name = "TSatuan"
        Me.TSatuan.Palette = Me.PaletPrimer
        Me.TSatuan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSatuan.Size = New System.Drawing.Size(145, 29)
        Me.TSatuan.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TSatuan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSatuan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSatuan.StateActive.Border.Rounding = 0!
        Me.TSatuan.StateActive.Border.Width = 1
        Me.TSatuan.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TSatuan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSatuan.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TSatuan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSatuan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSatuan.StateCommon.Border.Rounding = 0!
        Me.TSatuan.StateCommon.Border.Width = 1
        Me.TSatuan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSatuan.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TSatuan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSatuan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSatuan.StateDisabled.Border.Rounding = 0!
        Me.TSatuan.StateDisabled.Border.Width = 0
        Me.TSatuan.TabIndex = 3
        '
        'LBLKategori
        '
        Me.LBLKategori.AutoSize = False
        Me.LBLKategori.Location = New System.Drawing.Point(8, 72)
        Me.LBLKategori.Name = "LBLKategori"
        Me.LBLKategori.Palette = Me.PaletPrimer
        Me.LBLKategori.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLKategori.Size = New System.Drawing.Size(116, 26)
        Me.LBLKategori.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLKategori.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLKategori.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLKategori.TabIndex = 248
        Me.LBLKategori.Values.Text = "Kategori"
        '
        'TKategori
        '
        Me.TKategori.AlwaysActive = False
        Me.TKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TKategori.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TKategori.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TKategori.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TKategori.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TKategori.Location = New System.Drawing.Point(130, 72)
        Me.TKategori.MaxLength = 100
        Me.TKategori.Name = "TKategori"
        Me.TKategori.Palette = Me.PaletPrimer
        Me.TKategori.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TKategori.Size = New System.Drawing.Size(377, 29)
        Me.TKategori.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TKategori.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKategori.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKategori.StateActive.Border.Rounding = 0!
        Me.TKategori.StateActive.Border.Width = 1
        Me.TKategori.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TKategori.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKategori.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TKategori.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKategori.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKategori.StateCommon.Border.Rounding = 0!
        Me.TKategori.StateCommon.Border.Width = 1
        Me.TKategori.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TKategori.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TKategori.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKategori.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKategori.StateDisabled.Border.Rounding = 0!
        Me.TKategori.StateDisabled.Border.Width = 0
        Me.TKategori.TabIndex = 1
        '
        'LBLHarga
        '
        Me.LBLHarga.AutoSize = False
        Me.LBLHarga.Location = New System.Drawing.Point(934, 72)
        Me.LBLHarga.Name = "LBLHarga"
        Me.LBLHarga.Palette = Me.PaletPrimer
        Me.LBLHarga.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLHarga.Size = New System.Drawing.Size(58, 26)
        Me.LBLHarga.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHarga.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLHarga.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLHarga.TabIndex = 248
        Me.LBLHarga.Values.Text = "Harga"
        '
        'THarga
        '
        Me.THarga.AlwaysActive = False
        Me.THarga.CueHint.Color1 = System.Drawing.Color.Gray
        Me.THarga.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.THarga.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.THarga.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.THarga.Location = New System.Drawing.Point(998, 72)
        Me.THarga.MaxLength = 9
        Me.THarga.Name = "THarga"
        Me.THarga.Palette = Me.PaletPrimer
        Me.THarga.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.THarga.Size = New System.Drawing.Size(105, 29)
        Me.THarga.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.THarga.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.THarga.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THarga.StateActive.Border.Rounding = 0!
        Me.THarga.StateActive.Border.Width = 1
        Me.THarga.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.THarga.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.THarga.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.THarga.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.THarga.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THarga.StateCommon.Border.Rounding = 0!
        Me.THarga.StateCommon.Border.Width = 1
        Me.THarga.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.THarga.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.THarga.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.THarga.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THarga.StateDisabled.Border.Rounding = 0!
        Me.THarga.StateDisabled.Border.Width = 0
        Me.THarga.TabIndex = 4
        '
        'TBarcode
        '
        Me.TBarcode.AlwaysActive = False
        Me.TBarcode.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TBarcode.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TBarcode.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TBarcode.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBarcode.Location = New System.Drawing.Point(297, 8)
        Me.TBarcode.MaxLength = 100
        Me.TBarcode.Name = "TBarcode"
        Me.TBarcode.Palette = Me.PaletPrimer
        Me.TBarcode.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBarcode.Size = New System.Drawing.Size(210, 29)
        Me.TBarcode.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TBarcode.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBarcode.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBarcode.StateActive.Border.Rounding = 0!
        Me.TBarcode.StateActive.Border.Width = 1
        Me.TBarcode.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TBarcode.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBarcode.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TBarcode.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBarcode.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBarcode.StateCommon.Border.Rounding = 0!
        Me.TBarcode.StateCommon.Border.Width = 1
        Me.TBarcode.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBarcode.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TBarcode.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBarcode.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBarcode.StateDisabled.Border.Rounding = 0!
        Me.TBarcode.StateDisabled.Border.Width = 0
        Me.TBarcode.TabIndex = 5
        '
        'Barcode
        '
        Me.Barcode.AutoSize = False
        Me.Barcode.Location = New System.Drawing.Point(214, 8)
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Palette = Me.PaletPrimer
        Me.Barcode.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Barcode.Size = New System.Drawing.Size(77, 26)
        Me.Barcode.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Barcode.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Barcode.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.Barcode.TabIndex = 256
        Me.Barcode.Values.Text = "Barcode"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.CNo, Me.CBarcode, Me.CNama, Me.CKategori, Me.CUkuran, Me.CSatuan, Me.CHarga})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 136)
        Me.DGV.Name = "DGV"
        Me.DGV.Palette = Me.PaletPrimer
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(1095, 378)
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
        Me.DGV.TabIndex = 6
        '
        'CID
        '
        Me.CID.HeaderText = "ID Barang"
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CID.Visible = False
        Me.CID.Width = 85
        '
        'CNo
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CNo.DefaultCellStyle = DataGridViewCellStyle9
        Me.CNo.HeaderText = "No"
        Me.CNo.Name = "CNo"
        Me.CNo.ReadOnly = True
        Me.CNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNo.Width = 70
        '
        'CBarcode
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CBarcode.DefaultCellStyle = DataGridViewCellStyle10
        Me.CBarcode.HeaderText = "Barcode"
        Me.CBarcode.Name = "CBarcode"
        Me.CBarcode.ReadOnly = True
        Me.CBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CBarcode.Width = 150
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama Barang"
        Me.CNama.Name = "CNama"
        Me.CNama.ReadOnly = True
        Me.CNama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNama.Width = 410
        '
        'CKategori
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CKategori.DefaultCellStyle = DataGridViewCellStyle11
        Me.CKategori.HeaderText = "Kategori"
        Me.CKategori.Name = "CKategori"
        Me.CKategori.ReadOnly = True
        Me.CKategori.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CKategori.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CKategori.Width = 196
        '
        'CUkuran
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CUkuran.DefaultCellStyle = DataGridViewCellStyle12
        Me.CUkuran.HeaderText = "Ukuran"
        Me.CUkuran.Name = "CUkuran"
        Me.CUkuran.ReadOnly = True
        Me.CUkuran.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CUkuran.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CUkuran.Width = 64
        '
        'CSatuan
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CSatuan.DefaultCellStyle = DataGridViewCellStyle13
        Me.CSatuan.HeaderText = "Satuan"
        Me.CSatuan.Name = "CSatuan"
        Me.CSatuan.ReadOnly = True
        Me.CSatuan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CSatuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CSatuan.Width = 90
        '
        'CHarga
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "#,##0"
        Me.CHarga.DefaultCellStyle = DataGridViewCellStyle14
        Me.CHarga.HeaderText = "Harga"
        Me.CHarga.Name = "CHarga"
        Me.CHarga.ReadOnly = True
        Me.CHarga.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHarga.Width = 114
        '
        'DGVLast
        '
        Me.DGVLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVLast.Enabled = False
        Me.DGVLast.Location = New System.Drawing.Point(637, 520)
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
        Me.DGVLast.TabIndex = 253
        Me.DGVLast.Values.Text = "»"
        '
        'DGVFirst
        '
        Me.DGVFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVFirst.Enabled = False
        Me.DGVFirst.Location = New System.Drawing.Point(449, 520)
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
        Me.DGVFirst.TabIndex = 252
        Me.DGVFirst.Values.Text = "«"
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(476, 520)
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
        Me.DGVPrev.TabIndex = 252
        Me.DGVPrev.Values.Text = "‹"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(610, 520)
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
        Me.DGVNext.TabIndex = 253
        Me.DGVNext.Values.Text = "›"
        '
        'LBLUkuran
        '
        Me.LBLUkuran.AutoSize = False
        Me.LBLUkuran.Location = New System.Drawing.Point(8, 104)
        Me.LBLUkuran.Name = "LBLUkuran"
        Me.LBLUkuran.Size = New System.Drawing.Size(116, 26)
        Me.LBLUkuran.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUkuran.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUkuran.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUkuran.TabIndex = 256
        Me.LBLUkuran.Values.Text = "Ukuran"
        '
        'TUkuran
        '
        Me.TUkuran.AlwaysActive = False
        Me.TUkuran.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TUkuran.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TUkuran.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TUkuran.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TUkuran.Location = New System.Drawing.Point(130, 104)
        Me.TUkuran.MaxLength = 100
        Me.TUkuran.Name = "TUkuran"
        Me.TUkuran.Size = New System.Drawing.Size(140, 29)
        Me.TUkuran.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TUkuran.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUkuran.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUkuran.StateActive.Border.Rounding = 0!
        Me.TUkuran.StateActive.Border.Width = 1
        Me.TUkuran.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TUkuran.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUkuran.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TUkuran.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUkuran.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUkuran.StateCommon.Border.Rounding = 0!
        Me.TUkuran.StateCommon.Border.Width = 1
        Me.TUkuran.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUkuran.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TUkuran.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUkuran.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUkuran.StateDisabled.Border.Rounding = 0!
        Me.TUkuran.StateDisabled.Border.Width = 0
        Me.TUkuran.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AutoSize = False
        Me.DGVPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVPageCounter.Location = New System.Drawing.Point(503, 520)
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.Palette = Me.PaletPrimer
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVPageCounter.TabIndex = 280
        Me.DGVPageCounter.Values.Text = "1 / 1"
        '
        'Barang
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TUkuran)
        Me.Controls.Add(Me.LBLUkuran)
        Me.Controls.Add(Me.TBarcode)
        Me.Controls.Add(Me.Barcode)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVFirst)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.DGVLast)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.THarga)
        Me.Controls.Add(Me.TKategori)
        Me.Controls.Add(Me.LBLHarga)
        Me.Controls.Add(Me.LBLKategori)
        Me.Controls.Add(Me.TSatuan)
        Me.Controls.Add(Me.LBLSatuan)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.LBLNama)
        Me.Controls.Add(Me.TID)
        Me.Controls.Add(Me.LBLID)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Barang"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TID As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLID As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLNama As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TNama As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLSatuan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TSatuan As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLKategori As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TKategori As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLHarga As Krypton.Toolkit.KryptonLabel
    Friend WithEvents THarga As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TBarcode As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Barcode As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents LBLUkuran As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TUkuran As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents CNo As DataGridViewTextBoxColumn
    Friend WithEvents CBarcode As DataGridViewTextBoxColumn
    Friend WithEvents CNama As DataGridViewTextBoxColumn
    Friend WithEvents CKategori As DataGridViewTextBoxColumn
    Friend WithEvents CUkuran As DataGridViewTextBoxColumn
    Friend WithEvents CSatuan As DataGridViewTextBoxColumn
    Friend WithEvents CHarga As DataGridViewTextBoxColumn
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonLabel
End Class
