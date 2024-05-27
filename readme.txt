1. Login (Staff/Manager)
    Merujuk pada Table Login
2. Dashboard
    Merujuk pada Table Karyawan, dengan ketentuan :
    a. jumlah data berdasarkan etnis, mengambil field ethnic dan contract_exp >= current_date
        etnis = non papua, papua, & 7 tribes
    b. jumlah data berdasarkan mendekati masa pensiun, mengambil field ages >= 55
3. Alur :
    a. Staff, Login -> sukses -> Form Utama (hanya field fi-no yang aktif)
    b. Admin, Login -> sukses -> Form Utama
    Pada Form Utama terdapat button Dashboard -> Dashboard
