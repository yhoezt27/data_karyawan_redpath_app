Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication

        Private userStatus As String
        Private maxLoginAttems As Integer = 3
        Private LoginAttems As Integer = 0
        Private loginSuccessful As Boolean = False

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            While LoginAttems < maxLoginAttems AndAlso Not loginSuccessful
                Dim loginForm As New FormLogin()
                If loginForm.ShowDialog() = DialogResult.OK Then
                    loginSuccessful = True
                    userStatus = loginForm.Tag.ToString()
                Else
                    LoginAttems += 1
                End If
            End While

            If loginSuccessful Then
                If userStatus = "admin" Then
                    ' Tampilkan form_dashboard jika status admin
                    Dim FormData1 As New Form1(False)
                    FormData1.ShowDialog()
                ElseIf userStatus = "staff" Then
                    ' Tampilkan form_data jika status staff
                    Dim FormData As New Form1(True)
                    FormData.ShowDialog()

                End If
                FormLogin.Close()
            Else
                ' Jika login gagal setelah beberapa kali percobaan, tutup aplikasi
                MessageBox.Show("Login gagal setelah " & maxLoginAttems & " kali percobaan. Aplikasi akan ditutup.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.MainForm = Nothing
                Environment.Exit(0)
            End If
        End Sub
    End Class
End Namespace
