Imports MySql.Data.MySqlClient

Public Class FormDashboard

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboard()
    End Sub

    Private Function Jumlah_Data(field As String, Operate As String, Nilai As String) As Integer

        Dim JumlahKaryawan As Integer = 0
        Try
            Konek()
            Dim query As String = "SELECT COUNT(*) AS jumlah_karyawan FROM karyawan WHERE " + field + " = @etnis AND contract_exp " + Operate + " CURDATE()"
            Using command As New MySqlCommand(query, Koneksi)
                command.Parameters.AddWithValue("@etnis", Nilai)

                JumlahKaryawan = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghubungkan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return JumlahKaryawan

    End Function

    Private Function Jumlah_Data_1(field As String, Nilai As String) As Integer

        Dim JumlahKaryawan As Integer = 0
        Try
            Konek()
            Dim query As String = "SELECT COUNT(*) AS jumlah_karyawan FROM karyawan WHERE " + field + " >= @nilaiumur"
            Using command As New MySqlCommand(query, Koneksi)
                command.Parameters.AddWithValue("@nilaiumur", Nilai)
                JumlahKaryawan = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghubungkan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return JumlahKaryawan

    End Function



    Private Sub UpdateDashboard()
        TextBoxEtnisPapua.Text = GetJumlahDataEtnisPapua().ToString()
        TextBoxEtnisNonPapua.Text = GetJumlahDataEtnisNonPapua().ToString()
        TextBoxSevenTribes.Text = GetJumlahDataSevenTribes().ToString()
        TextBoxMendekatiPensiun.Text = GetJumlahDataMendekatiPensiun().ToString()
    End Sub

    Private Function GetJumlahDataEtnisPapua() As Integer
        ' Ganti dengan query database yang sesuai
        Return Jumlah_Data("ethnic", ">=", "papua")
    End Function

    Private Function GetJumlahDataEtnisNonPapua() As Integer
        ' Ganti dengan query database yang sesuai
        Return Jumlah_Data("ethnic", ">=", "non papua")
    End Function

    Private Function GetJumlahDataSevenTribes() As Integer
        ' Ganti dengan query database yang sesuai
        Return Jumlah_Data("ethnic", ">=", "7 tribes")
    End Function

    Private Function GetJumlahDataMendekatiPensiun() As Integer
        ' Ganti dengan query database yang sesuai
        Return Jumlah_Data_1("ages", "55")
    End Function

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        UpdateDashboard()
    End Sub


End Class