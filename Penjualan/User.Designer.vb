<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.CUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.A2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.B1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.B2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVFirst = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVLast = New Krypton.Toolkit.KryptonButton()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.TPassword = New Krypton.Toolkit.KryptonTextBox()
        Me.Password = New Krypton.Toolkit.KryptonLabel()
        Me.TUsername = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLUsername = New Krypton.Toolkit.KryptonLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonLabel()
        Me.DGVIndikator = New Krypton.Toolkit.KryptonDataGridView()
        Me.CNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVIndikator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUsername, Me.A1, Me.A2, Me.B1, Me.B2, Me.C})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 75)
        Me.DGV.Name = "DGV"
        Me.DGV.Palette = Me.PaletPrimer
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(924, 432)
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
        Me.DGV.TabIndex = 2
        '
        'CUsername
        '
        Me.CUsername.HeaderText = "Username"
        Me.CUsername.Name = "CUsername"
        Me.CUsername.ReadOnly = True
        Me.CUsername.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CUsername.Width = 743
        '
        'A1
        '
        Me.A1.FalseValue = "0"
        Me.A1.HeaderText = "A1"
        Me.A1.Name = "A1"
        Me.A1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.A1.TrueValue = "-1"
        Me.A1.Width = 36
        '
        'A2
        '
        Me.A2.FalseValue = "0"
        Me.A2.HeaderText = "A2"
        Me.A2.Name = "A2"
        Me.A2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.A2.TrueValue = "-1"
        Me.A2.Width = 36
        '
        'B1
        '
        Me.B1.FalseValue = "0"
        Me.B1.HeaderText = "B1"
        Me.B1.Name = "B1"
        Me.B1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.B1.TrueValue = "-1"
        Me.B1.Width = 36
        '
        'B2
        '
        Me.B2.FalseValue = "0"
        Me.B2.HeaderText = "B2"
        Me.B2.Name = "B2"
        Me.B2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.B2.TrueValue = "-1"
        Me.B2.Width = 36
        '
        'C
        '
        Me.C.FalseValue = "0"
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        Me.C.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.C.TrueValue = "-1"
        Me.C.Width = 36
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
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(391, 513)
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
        Me.DGVPrev.TabIndex = 275
        Me.DGVPrev.Values.Text = "‹"
        '
        'DGVFirst
        '
        Me.DGVFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVFirst.Enabled = False
        Me.DGVFirst.Location = New System.Drawing.Point(364, 513)
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
        Me.DGVFirst.TabIndex = 274
        Me.DGVFirst.Values.Text = "«"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(525, 513)
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
        Me.DGVNext.TabIndex = 276
        Me.DGVNext.Values.Text = "›"
        '
        'DGVLast
        '
        Me.DGVLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVLast.Enabled = False
        Me.DGVLast.Location = New System.Drawing.Point(552, 513)
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
        Me.BTNSimpan.TabIndex = 4
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
        Me.BTNHapus.TabIndex = 5
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
        Me.BTNClear.TabIndex = 6
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
        Me.TCariData.CueHint.CueHintText = "Cari user..."
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
        Me.TCariData.TabIndex = 3
        '
        'TPassword
        '
        Me.TPassword.AlwaysActive = False
        Me.TPassword.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPassword.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPassword.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPassword.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TPassword.Location = New System.Drawing.Point(106, 40)
        Me.TPassword.MaxLength = 100
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Palette = Me.PaletPrimer
        Me.TPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TPassword.Size = New System.Drawing.Size(449, 29)
        Me.TPassword.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TPassword.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPassword.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateActive.Border.Rounding = 0!
        Me.TPassword.StateActive.Border.Width = 1
        Me.TPassword.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPassword.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.TPassword.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateCommon.Border.Rounding = 0!
        Me.TPassword.StateCommon.Border.Width = 1
        Me.TPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPassword.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPassword.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateDisabled.Border.Rounding = 0!
        Me.TPassword.StateDisabled.Border.Width = 0
        Me.TPassword.TabIndex = 1
        Me.TPassword.UseSystemPasswordChar = True
        '
        'Password
        '
        Me.Password.AutoSize = False
        Me.Password.Location = New System.Drawing.Point(8, 40)
        Me.Password.Name = "Password"
        Me.Password.Palette = Me.PaletPrimer
        Me.Password.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Password.Size = New System.Drawing.Size(92, 26)
        Me.Password.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Password.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Password.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.Password.TabIndex = 272
        Me.Password.Values.Text = "Password"
        '
        'TUsername
        '
        Me.TUsername.AlwaysActive = False
        Me.TUsername.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TUsername.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TUsername.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TUsername.Location = New System.Drawing.Point(106, 8)
        Me.TUsername.MaxLength = 100
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Palette = Me.PaletPrimer
        Me.TUsername.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TUsername.Size = New System.Drawing.Size(449, 29)
        Me.TUsername.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.TUsername.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateActive.Border.Rounding = 0!
        Me.TUsername.StateActive.Border.Width = 1
        Me.TUsername.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TUsername.TabIndex = 0
        '
        'LBLUsername
        '
        Me.LBLUsername.AutoSize = False
        Me.LBLUsername.Location = New System.Drawing.Point(8, 8)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Palette = Me.PaletPrimer
        Me.LBLUsername.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLUsername.Size = New System.Drawing.Size(92, 26)
        Me.LBLUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUsername.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUsername.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUsername.TabIndex = 273
        Me.LBLUsername.Values.Text = "Username"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AutoSize = False
        Me.DGVPageCounter.Cursor = System.Windows.Forms.Cursors.Help
        Me.DGVPageCounter.Location = New System.Drawing.Point(418, 513)
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.Palette = Me.PaletPrimer
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVPageCounter.Size = New System.Drawing.Size(104, 24)
        Me.DGVPageCounter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPageCounter.StateCommon.ShortText.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.DGVPageCounter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVPageCounter.TabIndex = 279
        Me.DGVPageCounter.Values.Text = "1 / 1"
        '
        'DGVIndikator
        '
        Me.DGVIndikator.AllowUserToAddRows = False
        Me.DGVIndikator.AllowUserToDeleteRows = False
        Me.DGVIndikator.AllowUserToResizeColumns = False
        Me.DGVIndikator.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVIndikator.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVIndikator.ColumnHeadersHeight = 27
        Me.DGVIndikator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVIndikator.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNo, Me.CNama})
        Me.DGVIndikator.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVIndikator.HideOuterBorders = True
        Me.DGVIndikator.Location = New System.Drawing.Point(938, 75)
        Me.DGVIndikator.Name = "DGVIndikator"
        Me.DGVIndikator.Palette = Me.PaletPrimer
        Me.DGVIndikator.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.DGVIndikator.ReadOnly = True
        Me.DGVIndikator.RowHeadersVisible = False
        Me.DGVIndikator.RowTemplate.Height = 27
        Me.DGVIndikator.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVIndikator.Size = New System.Drawing.Size(165, 432)
        Me.DGVIndikator.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVIndikator.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGVIndikator.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVIndikator.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVIndikator.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGVIndikator.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVIndikator.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVIndikator.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVIndikator.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVIndikator.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGVIndikator.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVIndikator.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVIndikator.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVIndikator.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVIndikator.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVIndikator.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGVIndikator.TabIndex = 280
        '
        'CNo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.CNo.HeaderText = "Kode"
        Me.CNo.Name = "CNo"
        Me.CNo.ReadOnly = True
        Me.CNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNo.Width = 42
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama Form"
        Me.CNama.Name = "CNama"
        Me.CNama.ReadOnly = True
        Me.CNama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNama.Width = 122
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.AutoSize = False
        Me.KryptonLabel1.Location = New System.Drawing.Point(974, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Palette = Me.PaletPrimer
        Me.KryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(92, 26)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.KryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel1.TabIndex = 281
        Me.KryptonLabel1.Values.Text = "Indikator"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.AutoSize = False
        Me.KryptonLabel2.Location = New System.Drawing.Point(938, 43)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Palette = Me.PaletPrimer
        Me.KryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel2.Size = New System.Drawing.Size(165, 26)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.KryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel2.TabIndex = 282
        Me.KryptonLabel2.Values.Text = "1 = Read | 2 = Edit"
        '
        'User
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 638)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.DGVIndikator)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVFirst)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.DGVLast)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.TUsername)
        Me.Controls.Add(Me.LBLUsername)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVIndikator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVFirst As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVLast As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Password As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLUsername As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGVIndikator As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CUsername As DataGridViewTextBoxColumn
    Friend WithEvents A1 As DataGridViewCheckBoxColumn
    Friend WithEvents A2 As DataGridViewCheckBoxColumn
    Friend WithEvents B1 As DataGridViewCheckBoxColumn
    Friend WithEvents B2 As DataGridViewCheckBoxColumn
    Friend WithEvents C As DataGridViewCheckBoxColumn
    Friend WithEvents CNo As DataGridViewTextBoxColumn
    Friend WithEvents CNama As DataGridViewTextBoxColumn
End Class
