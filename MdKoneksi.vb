Imports MySql.Data.MySqlClient
Module MdKoneksi
    Dim constring = "Server=localhost; Database=redpath; User=root; Password="
    Public Koneksi As New MySqlConnection(constring)

    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader

    Public Ketemu As Boolean = False

    Public Sub Konek()

        Try
            If Not Koneksi Is Nothing Then Koneksi.close()
            Koneksi.Open()
            ' MsgBox("Koneksi Berhasil Dilakukan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Diskonek()
        Koneksi.close()
        Return Koneksi
    End Function
End Module
