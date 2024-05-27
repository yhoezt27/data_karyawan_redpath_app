
Imports MySql.Data.MySqlClient
Public Class Form1


    Public Sub New(ByVal isStaff As Boolean)
        InitializeComponent()
        Me.isStaff = isStaff
        InitializeForm()
    End Sub

    Private isStaff As Boolean
    Sub TampilData()
        Konek()
        da = New MySqlDataAdapter("select * from karyawan", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        DGV.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            DGV.Rows.Add(dt.Rows(i).Item(0))
            DGV.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            DGV.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            DGV.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            DGV.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
            DGV.Rows(i).Cells(5).Value = dt.Rows(i).Item(5)
            DGV.Rows(i).Cells(6).Value = dt.Rows(i).Item(6)
            DGV.Rows(i).Cells(7).Value = dt.Rows(i).Item(7)
            DGV.Rows(i).Cells(8).Value = dt.Rows(i).Item(8)
            DGV.Rows(i).Cells(9).Value = dt.Rows(i).Item(9)
            DGV.Rows(i).Cells(10).Value = dt.Rows(i).Item(10)
            DGV.Rows(i).Cells(11).Value = dt.Rows(i).Item(11)
            DGV.Rows(i).Cells(12).Value = dt.Rows(i).Item(12)
            DGV.Rows(i).Cells(13).Value = dt.Rows(i).Item(13)
            DGV.Rows(i).Cells(14).Value = dt.Rows(i).Item(14)
            DGV.Rows(i).Cells(15).Value = dt.Rows(i).Item(15)
            DGV.Rows(i).Cells(16).Value = dt.Rows(i).Item(16)
            DGV.Rows(i).Cells(17).Value = dt.Rows(i).Item(17)
            DGV.Rows(i).Cells(18).Value = dt.Rows(i).Item(18)
            DGV.Rows(i).Cells(19).Value = dt.Rows(i).Item(19)
            DGV.Rows(i).Cells(20).Value = dt.Rows(i).Item(20)
            DGV.Rows(i).Cells(21).Value = dt.Rows(i).Item(21)



        Next



        Diskonek()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isStaff Then
            TampilData()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub bkeluar_Click(sender As Object, e As EventArgs) Handles bkeluar.Click
        ' If isStaff Then
        Application.Exit()
        ' Else
        ' Me.Close()
        ' End If

    End Sub

    Private Sub bkosong_Click(sender As Object, e As EventArgs) Handles bkosong.Click
        tfi.Text = ""
        tri.Text = ""
        temployee.Text = ""
        cedu.Text = ""
        temp1.Text = ""
        temp2.Text = ""
        tethnic.Text = ""
        ttribes.Text = ""
        cgender.Text = ""
        tplace.Text = ""
        ddob.Text = ""
        tages.Text = ""
        treligon.Text = ""
        cmarital.Text = ""
        tdependant.Text = ""
        tpoh.Text = ""
        tpoo.Text = ""
        tpot.Text = ""
        ddoh.Text = ""
        dcontract.Text = ""
        tactual.Text = ""
        tactual2.Text = ""
        tfi.Focus()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click

        'Uji jika Ketemu = true, maka edit data, selain itu simpan baru
        If Ketemu = True Then
            'Ubah data
            Try
                Konek()

                cmd = New MySqlCommand("UPDATE karyawan SET ri_no = '" & tri.Text & "', employee_name = '" & temployee.Text & "', education = '" & cedu.Text & "', emp_status1 = '" & temp1.Text & "', emp_status2 = '" & temp2.Text & "', ethnic = '" & tethnic.Text & "', tribes = '" & ttribes.Text & "', gender = '" & cgender.Text & "', place_of_birth = '" & tplace.Text & "', dob = '" & ddob.Text & "', ages = '" & tages.Text & "', religion = '" & treligon.Text & "', marital_status = '" & cmarital.Text & "', dependant = '" & tdependant.Text & "', poh = '" & tpoh.Text & "', poo = '" & tpoo.Text & "', pot = '" & tpot.Text & "', doh = '" & ddoh.Text & "', contract_exp = '" & dcontract.Text & "', actual_classification = '" & tactual.Text & "', actual_worklocation = '" & tactual2.Text & "' WHERE fi_no = '" & tfi.Text & "' ", Koneksi)

                cmd.ExecuteNonQuery()
                MsgBox("Ubah Data Sukses")
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            'SImpan Baru
            Try
                Konek()

                cmd = New MySqlCommand("Insert Into karyawan (fi_no, ri_no, employee_name, education, emp_status1, emp_status2, ethnic, tribes, gender, place_of_birth, dob, ages, religion, marital_status, dependant, poh, poo, pot, doh, contract_exp, actual_classification, actual_worklocation) VALUES ( '" & tfi.Text & "','" & tri.Text & "','" & temployee.Text & "','" & cedu.Text & "','" & temp1.Text & "','" & temp2.Text & "','" & tethnic.Text & "','" & ttribes.Text & "','" & cgender.Text & "','" & tplace.Text & "','" & ddob.Text & "','" & tages.Text & "','" & treligon.Text & "','" & cmarital.Text & "','" & tdependant.Text & "','" & tpoh.Text & "','" & tpoo.Text & "','" & tpot.Text & "','" & ddoh.Text & "','" & dcontract.Text & "','" & tactual.Text & "','" & tactual2.Text & "') ", Koneksi)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses")
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If



        TampilData()
        bkosong_Click(sender, e)


    End Sub

    Private Sub tfi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tfi.KeyPress
        If e.KeyChar = Chr(13) Then
            Konek()

            cmd = New MySqlCommand("SELECT * FROM karyawan WHERE fi_no = '" & tfi.Text & "' ", Koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tfi.Text = dr.Item(0)
                tri.Text = dr.Item(1)
                temployee.Text = dr.Item(2)
                cedu.Text = dr.Item(3)
                temp1.Text = dr.Item(4)
                temp2.Text = dr.Item(5)
                tethnic.Text = dr.Item(6)
                ttribes.Text = dr.Item(7)
                cgender.Text = dr.Item(8)
                tplace.Text = dr.Item(9)
                ddob.Text = dr.Item(10)
                tages.Text = dr.Item(11)
                treligon.Text = dr.Item(12)
                cmarital.Text = dr.Item(13)
                tdependant.Text = dr.Item(14)
                tpoh.Text = dr.Item(15)
                tpoo.Text = dr.Item(16)
                tpot.Text = dr.Item(17)
                ddoh.Text = dr.Item(18)
                dcontract.Text = dr.Item(19)
                tactual.Text = dr.Item(20)
                tactual2.Text = dr.Item(21)
                MsgBox("Data Ditemukan")
                Ketemu = True
            Else
                MsgBox("Maaf Data Tidak Ditemukan")
                tfi.Focus()
                Ketemu = False
            End If

            Diskonek()

        End If
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click

        If Ketemu = True Then

            Try
                Konek()

                If MessageBox.Show("Apakah yakin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then


                    cmd = New MySqlCommand("DELETE FROM karyawan WHERE fi_no = '" & tfi.Text & "' ", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil")
                    TampilData()
                    bkosong_Click(sender, e)

                End If

                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dim Form_Dash As New FormDashboard()
        Form_Dash.ShowDialog()
        Me.Close()

    End Sub


    Private Sub relaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub




    Private Sub InitializeForm()
        If isStaff Then
            ' Disable beberapa bagian di form jika user adalah Staff
            ' ButtonAdminFeature.Enabled = False , sebagai contoh
            ' Lakukan disable lainnya jika diperlukan
            bsimpan.Enabled = False
            bhapus.Enabled = False
            tri.Enabled = False
            temployee.Enabled = False
            cedu.Enabled = False
            temp1.Enabled = False
            temp2.Enabled = False
            tethnic.Enabled = False
            ttribes.Enabled = False
            cgender.Enabled = False
            tplace.Enabled = False
            ddob.Enabled = False
            tages.Enabled = False
            treligon.Enabled = False
            cmarital.Enabled = False
            tdependant.Enabled = False
            tpoh.Enabled = False
            tpoo.Enabled = False
            tpot.Enabled = False
            ddoh.Enabled = False
            dcontract.Enabled = False
            tactual.Enabled = False
            tactual2.Enabled = False
            btnDash.Enabled = False

            ' bkosong.Enabled = False
            ' bkeluar.Enabled = False

        End If
    End Sub

End Class