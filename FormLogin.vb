Imports MySql.Data.MySqlClient

Public Class FormLogin
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Tambahkan handler untuk event click di sini
        AddHandler btnLogin.Click, AddressOf btnLogin_Click
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        ' Ambil username dan password dari TextBox
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Connection string to the database

        ' Dim connectionString As String = "server=your_server;userid=your_user;password=your_password;database=your_database"

        ' Query to check for the username and password
        Dim query As String = "SELECT status FROM table_login WHERE username = @username AND passwd = @password"

        ' Using block to ensure the connection is closed properly
        ' Using connection As New MySqlConnection(connectionString)
        Try
            ' Open the connection
            Konek()

            ' Create the command
            Using command As New MySqlCommand(query, Koneksi)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                ' Execute the command and get the result
                Dim status As String = Convert.ToString(command.ExecuteScalar())
                ' Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Check if the result is greater than 0, meaning a match was found
                If Not String.IsNullOrEmpty(status) Then
                    ' Jika login berhasil, set DialogResult ke OK dan tutup form
                    Me.Tag = status
                    Me.DialogResult = DialogResult.OK
                    Me.Hide()
                Else
                    ' Jika login gagal, tampilkan pesan kesalahan
                    MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = DialogResult.Cancel
                End If
            End Using

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("Terjadi kesalahan saat menghubungkan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel
        End Try
        ' End Using
        Diskonek()
    End Sub

End Class