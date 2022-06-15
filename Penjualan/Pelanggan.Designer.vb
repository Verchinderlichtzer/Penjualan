<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pelanggan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAlamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTelepon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVLast = New Krypton.Toolkit.KryptonButton()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.TTelepon = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTelepon = New Krypton.Toolkit.KryptonLabel()
        Me.TNama = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLNama = New Krypton.Toolkit.KryptonLabel()
        Me.TID = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLID = New Krypton.Toolkit.KryptonLabel()
        Me.TAlamat = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLAlamat = New Krypton.Toolkit.KryptonLabel()
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.CNo, Me.CNama, Me.CAlamat, Me.CTelepon})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 104)
        Me.DGV.Name = "DGV"
        Me.DGV.Palette = Me.PaletPrimer
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(1095, 405)
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
        Me.DGV.TabIndex = 3
        '
        'CID
        '
        Me.CID.HeaderText = "ID Pelanggan"
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Visible = False
        Me.CID.Width = 110
        '
        'CNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.CNo.HeaderText = "No"
        Me.CNo.Name = "CNo"
        Me.CNo.ReadOnly = True
        Me.CNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNo.Width = 70
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama"
        Me.CNama.Name = "CNama"
        Me.CNama.ReadOnly = True
        Me.CNama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNama.Width = 246
        '
        'CAlamat
        '
        Me.CAlamat.HeaderText = "Alamat"
        Me.CAlamat.Name = "CAlamat"
        Me.CAlamat.ReadOnly = True
        Me.CAlamat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CAlamat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CAlamat.Width = 615
        '
        'CTelepon
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTelepon.DefaultCellStyle = DataGridViewCellStyle3
        Me.CTelepon.HeaderText = "Telepon"
        Me.CTelepon.Name = "CTelepon"
        Me.CTelepon.ReadOnly = True
        Me.CTelepon.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTelepon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTelepon.Width = 163
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(476, 515)
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
        Me.DGVPrev.TabIndex = 276
        Me.DGVPrev.Values.Text = "‹"
        '
        'DGVFirst
        '
        Me.DGVFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVFirst.Enabled = False
        Me.DGVFirst.Location = New System.Drawing.Point(449, 515)
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
        Me.DGVFirst.TabIndex = 275
        Me.DGVFirst.Values.Text = "«"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(610, 515)
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
        Me.DGVNext.TabIndex = 278
        Me.DGVNext.Values.Text = "›"
        '
        'DGVLast
        '
        Me.DGVLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVLast.Enabled = False
        Me.DGVLast.Location = New System.Drawing.Point(637, 515)
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
        Me.DGVLast.TabIndex = 277
        Me.DGVLast.Values.Text = "»"
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
        Me.BTNSimpan.TabIndex = 5
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
        Me.BTNHapus.TabIndex = 6
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
        Me.BTNClear.TabIndex = 7
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
        Me.TCariData.CueHint.CueHintText = "Cari pelanggan..."
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
        Me.TCariData.TabIndex = 4
        '
        'TTelepon
        '
        Me.TTelepon.AlwaysActive = False
        Me.TTelepon.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTelepon.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTelepon.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTelepon.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTelepon.Location = New System.Drawing.Point(931, 40)
        Me.TTelepon.MaxLength = 100
        Me.TTelepon.Name = "TTelepon"
        Me.TTelepon.Palette = Me.PaletPrimer
        Me.TTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TTelepon.Size = New System.Drawing.Size(172, 29)
        Me.TTelepon.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TTelepon.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelepon.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateActive.Border.Rounding = 0!
        Me.TTelepon.StateActive.Border.Width = 1
        Me.TTelepon.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTelepon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TTelepon.TabIndex = 2
        '
        'LBLTelepon
        '
        Me.LBLTelepon.AutoSize = False
        Me.LBLTelepon.Location = New System.Drawing.Point(846, 40)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Palette = Me.PaletPrimer
        Me.LBLTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTelepon.Size = New System.Drawing.Size(79, 26)
        Me.LBLTelepon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTelepon.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTelepon.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTelepon.TabIndex = 274
        Me.LBLTelepon.Values.Text = "Telepon"
        '
        'TNama
        '
        Me.TNama.AlwaysActive = False
        Me.TNama.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TNama.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TNama.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TNama.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TNama.Location = New System.Drawing.Point(157, 40)
        Me.TNama.MaxLength = 100
        Me.TNama.Name = "TNama"
        Me.TNama.Palette = Me.PaletPrimer
        Me.TNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TNama.Size = New System.Drawing.Size(683, 29)
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
        'LBLNama
        '
        Me.LBLNama.AutoSize = False
        Me.LBLNama.Location = New System.Drawing.Point(8, 40)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.Palette = Me.PaletPrimer
        Me.LBLNama.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLNama.Size = New System.Drawing.Size(143, 26)
        Me.LBLNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLNama.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLNama.TabIndex = 269
        Me.LBLNama.Values.Text = "Nama Pelanggan"
        '
        'TID
        '
        Me.TID.AlwaysActive = False
        Me.TID.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TID.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TID.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TID.Enabled = False
        Me.TID.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TID.Location = New System.Drawing.Point(157, 8)
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
        Me.TID.TabIndex = 268
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
        Me.LBLID.TabIndex = 273
        Me.LBLID.Values.Text = "ID"
        '
        'TAlamat
        '
        Me.TAlamat.AlwaysActive = False
        Me.TAlamat.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TAlamat.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TAlamat.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TAlamat.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TAlamat.Location = New System.Drawing.Point(157, 72)
        Me.TAlamat.MaxLength = 100
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.Palette = Me.PaletPrimer
        Me.TAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TAlamat.Size = New System.Drawing.Size(946, 29)
        Me.TAlamat.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TAlamat.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TAlamat.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateActive.Border.Rounding = 0!
        Me.TAlamat.StateActive.Border.Width = 1
        Me.TAlamat.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TAlamat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TAlamat.TabIndex = 1
        '
        'LBLAlamat
        '
        Me.LBLAlamat.AutoSize = False
        Me.LBLAlamat.Location = New System.Drawing.Point(8, 72)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Palette = Me.PaletPrimer
        Me.LBLAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLAlamat.Size = New System.Drawing.Size(116, 26)
        Me.LBLAlamat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAlamat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAlamat.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAlamat.TabIndex = 283
        Me.LBLAlamat.Values.Text = "Alamat"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AutoSize = False
        Me.DGVPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVPageCounter.Location = New System.Drawing.Point(503, 515)
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.Palette = Me.PaletPrimer
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVPageCounter.TabIndex = 284
        Me.DGVPageCounter.Values.Text = "1 / 1"
        '
        'Pelanggan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.TAlamat)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVFirst)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.DGVLast)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.TTelepon)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.LBLNama)
        Me.Controls.Add(Me.TID)
        Me.Controls.Add(Me.LBLID)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pelanggan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTelepon As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTelepon As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TNama As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLNama As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TID As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLID As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TAlamat As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLAlamat As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents CNo As DataGridViewTextBoxColumn
    Friend WithEvents CNama As DataGridViewTextBoxColumn
    Friend WithEvents CAlamat As DataGridViewTextBoxColumn
    Friend WithEvents CTelepon As DataGridViewTextBoxColumn
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonLabel
End Class
