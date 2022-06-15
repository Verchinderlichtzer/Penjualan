<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Terlapor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Terlapor))
        Me.RV = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RV
        '
        Me.RV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RV.DocumentMapWidth = 20
        Me.RV.Location = New System.Drawing.Point(0, 0)
        Me.RV.Name = "RV"
        Me.RV.ServerReport.BearerToken = Nothing
        Me.RV.Size = New System.Drawing.Size(800, 450)
        Me.RV.TabIndex = 0
        '
        'Terlapor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RV)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Terlapor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terlapor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RV As Microsoft.Reporting.WinForms.ReportViewer
End Class
