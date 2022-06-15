<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Header = New System.Windows.Forms.Panel()
        Me.LBLTitle = New Krypton.Toolkit.KryptonLabel()
        Me.Sidebar = New Krypton.Toolkit.KryptonPanel()
        Me.BTNLogout = New Krypton.Toolkit.KryptonButton()
        Me.BTNLaporan = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNCatatan = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLLainnya = New Krypton.Toolkit.KryptonLabel()
        Me.BTNTransaksi = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLPeminjaman = New Krypton.Toolkit.KryptonLabel()
        Me.BTNPelanggan = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNBarang = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNUser = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLFile = New Krypton.Toolkit.KryptonLabel()
        Me.Thumbnail = New Krypton.Toolkit.KryptonCheckButton()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Header.SuspendLayout()
        CType(Me.Sidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(159, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1111, 638)
        Me.PanelForm.TabIndex = 138
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Header.Controls.Add(Me.LBLTitle)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(159, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1111, 40)
        Me.Header.TabIndex = 137
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = False
        Me.LBLTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLTitle.Location = New System.Drawing.Point(0, 0)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Palette = Me.PaletPrimer
        Me.LBLTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTitle.Size = New System.Drawing.Size(1111, 40)
        Me.LBLTitle.StateCommon.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.LBLTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.LBLTitle.TabIndex = 133
        Me.LBLTitle.Values.Text = "Title"
        '
        'Sidebar
        '
        Me.Sidebar.Controls.Add(Me.BTNLogout)
        Me.Sidebar.Controls.Add(Me.BTNLaporan)
        Me.Sidebar.Controls.Add(Me.BTNCatatan)
        Me.Sidebar.Controls.Add(Me.LBLLainnya)
        Me.Sidebar.Controls.Add(Me.BTNTransaksi)
        Me.Sidebar.Controls.Add(Me.LBLPeminjaman)
        Me.Sidebar.Controls.Add(Me.BTNPelanggan)
        Me.Sidebar.Controls.Add(Me.BTNBarang)
        Me.Sidebar.Controls.Add(Me.BTNUser)
        Me.Sidebar.Controls.Add(Me.LBLFile)
        Me.Sidebar.Controls.Add(Me.Thumbnail)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Palette = Me.PaletPrimer
        Me.Sidebar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Sidebar.Size = New System.Drawing.Size(159, 678)
        Me.Sidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Sidebar.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Sidebar.TabIndex = 888
        '
        'BTNLogout
        '
        Me.BTNLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNLogout.Location = New System.Drawing.Point(0, 458)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNLogout.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogout.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogout.Palette = Me.PaletPrimer
        Me.BTNLogout.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNLogout.Size = New System.Drawing.Size(159, 40)
        Me.BTNLogout.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNLogout.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogout.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogout.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLogout.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLogout.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogout.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLogout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNLogout.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNLogout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNLogout.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNLogout.TabIndex = 7
        Me.BTNLogout.Values.Image = Global.Penjualan.My.Resources.Resources.logout_default
        Me.BTNLogout.Values.Text = "Logout"
        '
        'BTNLaporan
        '
        Me.BTNLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNLaporan.Location = New System.Drawing.Point(0, 418)
        Me.BTNLaporan.Name = "BTNLaporan"
        Me.BTNLaporan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNLaporan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLaporan.Palette = Me.PaletPrimer
        Me.BTNLaporan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNLaporan.Size = New System.Drawing.Size(159, 40)
        Me.BTNLaporan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNLaporan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNLaporan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNLaporan.StateCommon.Border.Rounding = 0!
        Me.BTNLaporan.StateCommon.Border.Width = 2
        Me.BTNLaporan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLaporan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLaporan.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNLaporan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNLaporan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLaporan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLaporan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNLaporan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTNLaporan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNLaporan.StateDisabled.Border.Rounding = 0!
        Me.BTNLaporan.StateDisabled.Border.Width = 2
        Me.BTNLaporan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BTNLaporan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNLaporan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLaporan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLaporan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNLaporan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StatePressed.Border.Rounding = 0!
        Me.BTNLaporan.StatePressed.Border.Width = 2
        Me.BTNLaporan.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLaporan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNLaporan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLaporan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNLaporan.TabIndex = 6
        Me.BTNLaporan.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.laporan_default
        Me.BTNLaporan.Values.Text = "Laporan"
        '
        'BTNCatatan
        '
        Me.BTNCatatan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCatatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNCatatan.Location = New System.Drawing.Point(0, 378)
        Me.BTNCatatan.Name = "BTNCatatan"
        Me.BTNCatatan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNCatatan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCatatan.Palette = Me.PaletPrimer
        Me.BTNCatatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNCatatan.Size = New System.Drawing.Size(159, 40)
        Me.BTNCatatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNCatatan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNCatatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNCatatan.StateCommon.Border.Rounding = 0!
        Me.BTNCatatan.StateCommon.Border.Width = 2
        Me.BTNCatatan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCatatan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCatatan.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNCatatan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNCatatan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCatatan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCatatan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNCatatan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTNCatatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNCatatan.StateDisabled.Border.Rounding = 0!
        Me.BTNCatatan.StateDisabled.Border.Width = 2
        Me.BTNCatatan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BTNCatatan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNCatatan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNCatatan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StatePressed.Border.Rounding = 0!
        Me.BTNCatatan.StatePressed.Border.Width = 2
        Me.BTNCatatan.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNCatatan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCatatan.TabIndex = 5
        Me.BTNCatatan.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.catatan_default
        Me.BTNCatatan.Values.Text = "Catatan"
        '
        'LBLLainnya
        '
        Me.LBLLainnya.AutoSize = False
        Me.LBLLainnya.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLLainnya.Location = New System.Drawing.Point(0, 348)
        Me.LBLLainnya.Name = "LBLLainnya"
        Me.LBLLainnya.Palette = Me.PaletPrimer
        Me.LBLLainnya.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLLainnya.Size = New System.Drawing.Size(159, 30)
        Me.LBLLainnya.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.LBLLainnya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLainnya.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLainnya.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLLainnya.TabIndex = 57
        Me.LBLLainnya.Values.Text = "Lainnya"
        '
        'BTNTransaksi
        '
        Me.BTNTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNTransaksi.Location = New System.Drawing.Point(0, 308)
        Me.BTNTransaksi.Name = "BTNTransaksi"
        Me.BTNTransaksi.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNTransaksi.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTransaksi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTransaksi.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNTransaksi.Palette = Me.PaletPrimer
        Me.BTNTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNTransaksi.Size = New System.Drawing.Size(159, 40)
        Me.BTNTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNTransaksi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNTransaksi.StateCommon.Border.Rounding = 0!
        Me.BTNTransaksi.StateCommon.Border.Width = 2
        Me.BTNTransaksi.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNTransaksi.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNTransaksi.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNTransaksi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNTransaksi.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTransaksi.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNTransaksi.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNTransaksi.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTransaksi.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTNTransaksi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNTransaksi.StateDisabled.Border.Rounding = 0!
        Me.BTNTransaksi.StateDisabled.Border.Width = 2
        Me.BTNTransaksi.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BTNTransaksi.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNTransaksi.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTransaksi.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTransaksi.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNTransaksi.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNTransaksi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNTransaksi.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTransaksi.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTransaksi.StatePressed.Border.Rounding = 0!
        Me.BTNTransaksi.StatePressed.Border.Width = 2
        Me.BTNTransaksi.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNTransaksi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNTransaksi.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTransaksi.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTransaksi.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNTransaksi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNTransaksi.TabIndex = 4
        Me.BTNTransaksi.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.transaksi_default
        Me.BTNTransaksi.Values.Text = "Transaksi"
        '
        'LBLPeminjaman
        '
        Me.LBLPeminjaman.AutoSize = False
        Me.LBLPeminjaman.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLPeminjaman.Location = New System.Drawing.Point(0, 278)
        Me.LBLPeminjaman.Name = "LBLPeminjaman"
        Me.LBLPeminjaman.Palette = Me.PaletPrimer
        Me.LBLPeminjaman.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLPeminjaman.Size = New System.Drawing.Size(159, 30)
        Me.LBLPeminjaman.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.LBLPeminjaman.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPeminjaman.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPeminjaman.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLPeminjaman.TabIndex = 55
        Me.LBLPeminjaman.Values.Text = "Transaksi"
        '
        'BTNPelanggan
        '
        Me.BTNPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPelanggan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNPelanggan.Location = New System.Drawing.Point(0, 238)
        Me.BTNPelanggan.Name = "BTNPelanggan"
        Me.BTNPelanggan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNPelanggan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPelanggan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPelanggan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNPelanggan.Palette = Me.PaletPrimer
        Me.BTNPelanggan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNPelanggan.Size = New System.Drawing.Size(159, 40)
        Me.BTNPelanggan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNPelanggan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPelanggan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNPelanggan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNPelanggan.StateCommon.Border.Rounding = 0!
        Me.BTNPelanggan.StateCommon.Border.Width = 2
        Me.BTNPelanggan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNPelanggan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNPelanggan.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNPelanggan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNPelanggan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPelanggan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNPelanggan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNPelanggan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPelanggan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTNPelanggan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNPelanggan.StateDisabled.Border.Rounding = 0!
        Me.BTNPelanggan.StateDisabled.Border.Width = 2
        Me.BTNPelanggan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BTNPelanggan.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNPelanggan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPelanggan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPelanggan.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNPelanggan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNPelanggan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNPelanggan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPelanggan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPelanggan.StatePressed.Border.Rounding = 0!
        Me.BTNPelanggan.StatePressed.Border.Width = 2
        Me.BTNPelanggan.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNPelanggan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNPelanggan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPelanggan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPelanggan.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNPelanggan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNPelanggan.TabIndex = 3
        Me.BTNPelanggan.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.pelanggan_default
        Me.BTNPelanggan.Values.Text = "Pelanggan"
        '
        'BTNBarang
        '
        Me.BTNBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNBarang.Location = New System.Drawing.Point(0, 198)
        Me.BTNBarang.Name = "BTNBarang"
        Me.BTNBarang.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNBarang.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBarang.Palette = Me.PaletPrimer
        Me.BTNBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNBarang.Size = New System.Drawing.Size(159, 40)
        Me.BTNBarang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNBarang.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNBarang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNBarang.StateCommon.Border.Rounding = 0!
        Me.BTNBarang.StateCommon.Border.Width = 2
        Me.BTNBarang.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBarang.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNBarang.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNBarang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNBarang.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBarang.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNBarang.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNBarang.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTNBarang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNBarang.StateDisabled.Border.Rounding = 0!
        Me.BTNBarang.StateDisabled.Border.Width = 2
        Me.BTNBarang.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BTNBarang.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNBarang.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBarang.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNBarang.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNBarang.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StatePressed.Border.Rounding = 0!
        Me.BTNBarang.StatePressed.Border.Width = 2
        Me.BTNBarang.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBarang.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNBarang.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBarang.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNBarang.TabIndex = 2
        Me.BTNBarang.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.barang_default
        Me.BTNBarang.Values.Text = "Barang"
        '
        'BTNUser
        '
        Me.BTNUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNUser.Location = New System.Drawing.Point(0, 158)
        Me.BTNUser.Name = "BTNUser"
        Me.BTNUser.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNUser.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNUser.Palette = Me.PaletPrimer
        Me.BTNUser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNUser.Size = New System.Drawing.Size(159, 40)
        Me.BTNUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNUser.StateCommon.Border.Rounding = 0!
        Me.BTNUser.StateCommon.Border.Width = 2
        Me.BTNUser.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNUser.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNUser.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNUser.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUser.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNUser.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTNUser.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNUser.StateDisabled.Border.Rounding = 0!
        Me.BTNUser.StateDisabled.Border.Width = 2
        Me.BTNUser.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BTNUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BTNUser.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BTNUser.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StatePressed.Border.Rounding = 0!
        Me.BTNUser.StatePressed.Border.Width = 2
        Me.BTNUser.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.BTNUser.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNUser.TabIndex = 1
        Me.BTNUser.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.user_default
        Me.BTNUser.Values.Text = "User"
        '
        'LBLFile
        '
        Me.LBLFile.AutoSize = False
        Me.LBLFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLFile.Location = New System.Drawing.Point(0, 128)
        Me.LBLFile.Name = "LBLFile"
        Me.LBLFile.Palette = Me.PaletPrimer
        Me.LBLFile.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLFile.Size = New System.Drawing.Size(159, 30)
        Me.LBLFile.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.LBLFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFile.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFile.TabIndex = 38
        Me.LBLFile.Values.Text = "File"
        '
        'Thumbnail
        '
        Me.Thumbnail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Thumbnail.Dock = System.Windows.Forms.DockStyle.Top
        Me.Thumbnail.Location = New System.Drawing.Point(0, 0)
        Me.Thumbnail.Name = "Thumbnail"
        Me.Thumbnail.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Thumbnail.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Thumbnail.Palette = Me.PaletPrimer
        Me.Thumbnail.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.Thumbnail.Size = New System.Drawing.Size(159, 128)
        Me.Thumbnail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Thumbnail.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Thumbnail.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.Thumbnail.TabIndex = 0
        Me.Thumbnail.Values.Image = Global.Penjualan.My.Resources.Resources.thumbnail_tracking
        Me.Thumbnail.Values.ImageStates.ImageNormal = Global.Penjualan.My.Resources.Resources.thumbnail_default
        Me.Thumbnail.Values.Text = ""
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
        'PaletSekunder
        '
        Me.PaletSekunder.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletSekunder.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.PaletSekunder.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PaletSekunder.GridStyles.GridCommon.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PaletSekunder.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.Common = CType(resources.GetObject("resource.Common2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled2"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled3"), System.Drawing.Image)
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
        'MainF
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1270, 678)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Sidebar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1286, 717)
        Me.MinimumSize = New System.Drawing.Size(1286, 717)
        Me.Name = "MainF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.Header.ResumeLayout(False)
        CType(Me.Sidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents LBLTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Sidebar As Krypton.Toolkit.KryptonPanel
    Friend WithEvents LBLFile As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Thumbnail As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents BTNUser As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNLogout As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNLaporan As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNCatatan As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLLainnya As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNTransaksi As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLPeminjaman As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNPelanggan As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNBarang As Krypton.Toolkit.KryptonCheckButton
End Class
