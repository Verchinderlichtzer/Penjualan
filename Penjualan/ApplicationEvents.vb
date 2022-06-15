Imports System.Globalization, System.IO
Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not Directory.Exists(Path) Then
                Directory.CreateDirectory(Path)
            End If
            If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("WindowsNoEditor").GetValue("SavedBinaries") Is Nothing Then
                Computer.Registry.SetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedBinaries", "None")
            End If
            If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("WindowsNoEditor").GetValue("SavedTheme") Is Nothing Then
                Computer.Registry.SetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedTheme", "0")
            End If
            If Not File.Exists(Path & "\Ill.accdb") Then 'MS Access
                Try
                    Computer.FileSystem.MoveFile(Application.Info.DirectoryPath & "\Ill.accdb", Path & "\Ill.accdb")
                Catch ex As Exception
                    MsgBox("...")
                End Try
            End If
            Koneksi()
            Dim id = New CultureInfo("id-ID")
            CultureInfo.DefaultThreadCurrentCulture = id
            CultureInfo.DefaultThreadCurrentUICulture = id
            Warna = Computer.Registry.GetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedTheme", Nothing)
            Try
                UserAktif = DecodeUsername(Computer.Registry.GetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedBinaries", Nothing))
                QR("SELECT Username FROM TBLUser WHERE Username = '" & DecodeUsername(Computer.Registry.GetValue("HKEY_CURRENT_USER\WindowsNoEditor", "SavedBinaries", Nothing)) & "'")
                Application.MainForm = MainF
            Catch ex As Exception
                Application.MainForm = Login
            End Try
        End Sub
    End Class
End Namespace
