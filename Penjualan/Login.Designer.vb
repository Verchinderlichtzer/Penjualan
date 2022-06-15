<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TUsername = New Krypton.Toolkit.KryptonTextBox()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.BTNLogin = New Krypton.Toolkit.KryptonButton()
        Me.BTNBatal = New Krypton.Toolkit.KryptonButton()
        Me.TPassword = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLLogin = New Krypton.Toolkit.KryptonLabel()
        Me.CBCookies = New Krypton.Toolkit.KryptonCheckBox()
        Me.PBGambar = New System.Windows.Forms.PictureBox()
        Me.LBLTelepon = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TUsername
        '
        Me.TUsername.AlwaysActive = False
        Me.TUsername.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TUsername.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TUsername.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TUsername.Location = New System.Drawing.Point(224, 69)
        Me.TUsername.MaxLength = 100
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Palette = Me.PaletPrimer
        Me.TUsername.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TUsername.Size = New System.Drawing.Size(298, 29)
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
        'BTNLogin
        '
        Me.BTNLogin.Enabled = False
        Me.BTNLogin.Location = New System.Drawing.Point(224, 200)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNLogin.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogin.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogin.Palette = Me.PaletPrimer
        Me.BTNLogin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNLogin.Size = New System.Drawing.Size(146, 30)
        Me.BTNLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNLogin.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogin.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNLogin.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLogin.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BTNLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNLogin.TabIndex = 3
        Me.BTNLogin.Values.Text = "Login"
        '
        'BTNBatal
        '
        Me.BTNBatal.Location = New System.Drawing.Point(376, 200)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNBatal.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBatal.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBatal.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBatal.Palette = Me.PaletPrimer
        Me.BTNBatal.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.BTNBatal.Size = New System.Drawing.Size(146, 30)
        Me.BTNBatal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BTNBatal.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBatal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBatal.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBatal.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNBatal.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBatal.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNBatal.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNBatal.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNBatal.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BTNBatal.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BTNBatal.TabIndex = 4
        Me.BTNBatal.Values.Text = "Batal"
        '
        'TPassword
        '
        Me.TPassword.AlwaysActive = False
        Me.TPassword.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPassword.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPassword.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPassword.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TPassword.Location = New System.Drawing.Point(224, 133)
        Me.TPassword.MaxLength = 100
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Palette = Me.PaletPrimer
        Me.TPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TPassword.Size = New System.Drawing.Size(298, 29)
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
        'LBLLogin
        '
        Me.LBLLogin.Location = New System.Drawing.Point(313, 0)
        Me.LBLLogin.Name = "LBLLogin"
        Me.LBLLogin.Palette = Me.PaletPrimer
        Me.LBLLogin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLLogin.Size = New System.Drawing.Size(120, 42)
        Me.LBLLogin.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLLogin.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLogin.StateCommon.ShortText.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLogin.TabIndex = 258
        Me.LBLLogin.Values.Text = "Login"
        '
        'CBCookies
        '
        Me.CBCookies.Location = New System.Drawing.Point(224, 168)
        Me.CBCookies.Name = "CBCookies"
        Me.CBCookies.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBCookies.Palette = Me.PaletPrimer
        Me.CBCookies.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBCookies.Size = New System.Drawing.Size(138, 26)
        Me.CBCookies.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBCookies.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBCookies.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBCookies.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBCookies.TabIndex = 2
        Me.CBCookies.Values.Text = "Ingatkan Saya"
        '
        'PBGambar
        '
        Me.PBGambar.Location = New System.Drawing.Point(12, 19)
        Me.PBGambar.Name = "PBGambar"
        Me.PBGambar.Size = New System.Drawing.Size(200, 200)
        Me.PBGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBGambar.TabIndex = 261
        Me.PBGambar.TabStop = False
        '
        'LBLTelepon
        '
        Me.LBLTelepon.AutoSize = False
        Me.LBLTelepon.Location = New System.Drawing.Point(224, 40)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Palette = Me.PaletPrimer
        Me.LBLTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.LBLTelepon.Size = New System.Drawing.Size(92, 26)
        Me.LBLTelepon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTelepon.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTelepon.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTelepon.TabIndex = 262
        Me.LBLTelepon.Values.Text = "Username"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.AutoSize = False
        Me.KryptonLabel1.Location = New System.Drawing.Point(224, 104)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Palette = Me.PaletPrimer
        Me.KryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(92, 26)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.KryptonLabel1.TabIndex = 263
        Me.KryptonLabel1.Values.Text = "Password"
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(530, 238)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.CBCookies)
        Me.Controls.Add(Me.PBGambar)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.TUsername)
        Me.Controls.Add(Me.LBLLogin)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BTNLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNBatal As Krypton.Toolkit.KryptonButton
    Friend WithEvents PBGambar As PictureBox
    Friend WithEvents TPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLLogin As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents CBCookies As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LBLTelepon As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
End Class
