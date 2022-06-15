<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Konfirmasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Konfirmasi))
        Me.PanelKonfirmasi = New Krypton.Toolkit.KryptonGroup()
        Me.T2 = New Krypton.Toolkit.KryptonTextBox()
        Me.T1 = New Krypton.Toolkit.KryptonTextBox()
        Me.PBIcon = New System.Windows.Forms.PictureBox()
        Me.TDeskripsi = New Krypton.Toolkit.KryptonTextBox()
        Me.BTNYa = New Krypton.Toolkit.KryptonButton()
        Me.LBLTitle = New Krypton.Toolkit.KryptonLabel()
        Me.BTNTidak = New Krypton.Toolkit.KryptonButton()
        CType(Me.PanelKonfirmasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelKonfirmasi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKonfirmasi.Panel.SuspendLayout()
        Me.PanelKonfirmasi.SuspendLayout()
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelKonfirmasi
        '
        Me.PanelKonfirmasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonfirmasi.Location = New System.Drawing.Point(0, 0)
        Me.PanelKonfirmasi.Name = "PanelKonfirmasi"
        '
        'PanelKonfirmasi.Panel
        '
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.T2)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.T1)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.PBIcon)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.TDeskripsi)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.BTNYa)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.LBLTitle)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.BTNTidak)
        Me.PanelKonfirmasi.Size = New System.Drawing.Size(450, 160)
        Me.PanelKonfirmasi.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.PanelKonfirmasi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelKonfirmasi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PanelKonfirmasi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelKonfirmasi.StateCommon.Border.Width = 3
        Me.PanelKonfirmasi.TabIndex = 135
        '
        'T2
        '
        Me.T2.AlwaysActive = False
        Me.T2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.T2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.T2.CueHint.Color1 = System.Drawing.Color.Gray
        Me.T2.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.T2.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.T2.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.T2.Location = New System.Drawing.Point(65, 73)
        Me.T2.MaxLength = 100
        Me.T2.Name = "T2"
        Me.T2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.T2.Size = New System.Drawing.Size(373, 29)
        Me.T2.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.T2.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.T2.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.T2.StateActive.Border.Rounding = 0!
        Me.T2.StateActive.Border.Width = 1
        Me.T2.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.T2.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.T2.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.T2.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.T2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.T2.StateCommon.Border.Rounding = 0!
        Me.T2.StateCommon.Border.Width = 1
        Me.T2.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.T2.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.T2.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.T2.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.T2.StateDisabled.Border.Rounding = 0!
        Me.T2.StateDisabled.Border.Width = 0
        Me.T2.TabIndex = 1
        Me.T2.UseSystemPasswordChar = True
        Me.T2.Visible = False
        '
        'T1
        '
        Me.T1.AlwaysActive = False
        Me.T1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.T1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.T1.CueHint.Color1 = System.Drawing.Color.Gray
        Me.T1.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.T1.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.T1.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.T1.Location = New System.Drawing.Point(65, 38)
        Me.T1.MaxLength = 100
        Me.T1.Name = "T1"
        Me.T1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.T1.Size = New System.Drawing.Size(373, 29)
        Me.T1.StateActive.Border.Color1 = System.Drawing.Color.Silver
        Me.T1.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.T1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.T1.StateActive.Border.Rounding = 0!
        Me.T1.StateActive.Border.Width = 1
        Me.T1.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.T1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.T1.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.T1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.T1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.T1.StateCommon.Border.Rounding = 0!
        Me.T1.StateCommon.Border.Width = 1
        Me.T1.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.T1.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.T1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.T1.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.T1.StateDisabled.Border.Rounding = 0!
        Me.T1.StateDisabled.Border.Width = 0
        Me.T1.TabIndex = 0
        Me.T1.UseSystemPasswordChar = True
        Me.T1.Visible = False
        '
        'PBIcon
        '
        Me.PBIcon.Image = Global.Penjualan.My.Resources.Resources.question_merah
        Me.PBIcon.Location = New System.Drawing.Point(10, 10)
        Me.PBIcon.Name = "PBIcon"
        Me.PBIcon.Size = New System.Drawing.Size(48, 48)
        Me.PBIcon.TabIndex = 128
        Me.PBIcon.TabStop = False
        '
        'TDeskripsi
        '
        Me.TDeskripsi.AlwaysActive = False
        Me.TDeskripsi.Enabled = False
        Me.TDeskripsi.Location = New System.Drawing.Point(65, 38)
        Me.TDeskripsi.MaxLength = 255
        Me.TDeskripsi.Multiline = True
        Me.TDeskripsi.Name = "TDeskripsi"
        Me.TDeskripsi.Size = New System.Drawing.Size(376, 72)
        Me.TDeskripsi.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TDeskripsi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDeskripsi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TDeskripsi.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.TDeskripsi.TabIndex = 4
        Me.TDeskripsi.Text = "."
        '
        'BTNYa
        '
        Me.BTNYa.Location = New System.Drawing.Point(194, 121)
        Me.BTNYa.Name = "BTNYa"
        Me.BTNYa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNYa.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNYa.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNYa.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNYa.Size = New System.Drawing.Size(119, 27)
        Me.BTNYa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BTNYa.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNYa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNYa.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNYa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNYa.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Gadugi", 12.0!)
        Me.BTNYa.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BTNYa.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNYa.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNYa.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNYa.TabIndex = 2
        Me.BTNYa.Values.Text = "Ya"
        '
        'LBLTitle
        '
        Me.LBLTitle.Location = New System.Drawing.Point(62, 10)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(18, 24)
        Me.LBLTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.LBLTitle.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTitle.TabIndex = 5
        Me.LBLTitle.Values.Text = "-"
        '
        'BTNTidak
        '
        Me.BTNTidak.Location = New System.Drawing.Point(319, 121)
        Me.BTNTidak.Name = "BTNTidak"
        Me.BTNTidak.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNTidak.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTidak.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTidak.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNTidak.Size = New System.Drawing.Size(119, 27)
        Me.BTNTidak.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BTNTidak.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTidak.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTidak.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNTidak.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNTidak.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Gadugi", 12.0!)
        Me.BTNTidak.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BTNTidak.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNTidak.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNTidak.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNTidak.TabIndex = 3
        Me.BTNTidak.Values.Text = "Tidak"
        '
        'Konfirmasi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 160)
        Me.Controls.Add(Me.PanelKonfirmasi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Konfirmasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfirmasi"
        CType(Me.PanelKonfirmasi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKonfirmasi.Panel.ResumeLayout(False)
        Me.PanelKonfirmasi.Panel.PerformLayout()
        CType(Me.PanelKonfirmasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKonfirmasi.ResumeLayout(False)
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelKonfirmasi As Krypton.Toolkit.KryptonGroup
    Friend WithEvents PBIcon As PictureBox
    Friend WithEvents TDeskripsi As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BTNYa As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNTidak As Krypton.Toolkit.KryptonButton
    Friend WithEvents T2 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents T1 As Krypton.Toolkit.KryptonTextBox
End Class
