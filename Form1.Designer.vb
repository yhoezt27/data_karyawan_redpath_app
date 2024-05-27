<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        tfi = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        tri = New TextBox()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        temployee = New TextBox()
        temp1 = New TextBox()
        temp2 = New TextBox()
        tethnic = New TextBox()
        ttribes = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        tages = New TextBox()
        treligon = New TextBox()
        tdependant = New TextBox()
        tpoh = New TextBox()
        tpoo = New TextBox()
        tpot = New TextBox()
        cedu = New ComboBox()
        cgender = New ComboBox()
        cmarital = New ComboBox()
        ddob = New DateTimePicker()
        ddoh = New DateTimePicker()
        dcontract = New DateTimePicker()
        Label20 = New Label()
        Label21 = New Label()
        tactual = New TextBox()
        tactual2 = New TextBox()
        bkosong = New Button()
        bsimpan = New Button()
        bhapus = New Button()
        bkeluar = New Button()
        Label22 = New Label()
        tplace = New TextBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        btnDash = New Button()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tfi
        ' 
        tfi.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tfi.Location = New Point(60, 102)
        tfi.Margin = New Padding(3, 2, 3, 2)
        tfi.Name = "tfi"
        tfi.Size = New Size(139, 20)
        tfi.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 13)
        Label1.TabIndex = 1
        Label1.Text = "FI. No :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 13)
        Label2.TabIndex = 2
        Label2.Text = "RI. No :"
        ' 
        ' tri
        ' 
        tri.Location = New Point(60, 129)
        tri.Margin = New Padding(3, 2, 3, 2)
        tri.Name = "tri"
        tri.Size = New Size(139, 20)
        tri.TabIndex = 3
        ' 
        ' DGV
        ' 
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column21, Column22})
        DGV.Location = New Point(2, 209)
        DGV.Margin = New Padding(3, 2, 3, 2)
        DGV.Name = "DGV"
        DGV.Size = New Size(1369, 497)
        DGV.TabIndex = 4
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "FI.No"
        Column1.Name = "Column1"
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "RI.No"
        Column2.Name = "Column2"
        Column2.Width = 90
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Employee Name"
        Column3.Name = "Column3"
        Column3.Width = 170
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Education"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Emp Status1"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Emp Status2"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Ethnic"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Tribes"
        Column8.Name = "Column8"
        Column8.Width = 120
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Gender"
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Place Of Birth"
        Column10.Name = "Column10"
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "D.O.B"
        Column11.Name = "Column11"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Ages"
        Column12.Name = "Column12"
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Religion"
        Column13.Name = "Column13"
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Marital Status"
        Column14.Name = "Column14"
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Dependant"
        Column15.Name = "Column15"
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "P.O.H"
        Column16.Name = "Column16"
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "P.O.O"
        Column17.Name = "Column17"
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "P.O.T"
        Column18.Name = "Column18"
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "DOH"
        Column19.Name = "Column19"
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "Contract Exp."
        Column20.Name = "Column20"
        ' 
        ' Column21
        ' 
        Column21.HeaderText = "Actual Classification"
        Column21.Name = "Column21"
        ' 
        ' Column22
        ' 
        Column22.HeaderText = "Actual Work Location"
        Column22.Name = "Column22"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(208, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 13)
        Label3.TabIndex = 5
        Label3.Text = "Employee Name :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(237, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 13)
        Label4.TabIndex = 6
        Label4.Text = "Education :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(222, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 13)
        Label5.TabIndex = 7
        Label5.Text = "Emp Status 1 :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(222, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 13)
        Label6.TabIndex = 8
        Label6.Text = "Emp Status 2 :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(255, 121)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 13)
        Label7.TabIndex = 9
        Label7.Text = "Ethnic :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(246, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 13)
        Label8.TabIndex = 10
        Label8.Text = "TRIBES :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(469, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 13)
        Label9.TabIndex = 11
        Label9.Text = "Gender :"
        ' 
        ' temployee
        ' 
        temployee.Location = New Point(304, 5)
        temployee.Margin = New Padding(3, 2, 3, 2)
        temployee.Name = "temployee"
        temployee.Size = New Size(104, 20)
        temployee.TabIndex = 12
        ' 
        ' temp1
        ' 
        temp1.Location = New Point(304, 62)
        temp1.Margin = New Padding(3, 2, 3, 2)
        temp1.Name = "temp1"
        temp1.Size = New Size(104, 20)
        temp1.TabIndex = 14
        ' 
        ' temp2
        ' 
        temp2.Location = New Point(304, 90)
        temp2.Margin = New Padding(3, 2, 3, 2)
        temp2.Name = "temp2"
        temp2.Size = New Size(104, 20)
        temp2.TabIndex = 15
        ' 
        ' tethnic
        ' 
        tethnic.Location = New Point(304, 118)
        tethnic.Margin = New Padding(3, 2, 3, 2)
        tethnic.Name = "tethnic"
        tethnic.Size = New Size(104, 20)
        tethnic.TabIndex = 16
        ' 
        ' ttribes
        ' 
        ttribes.Location = New Point(304, 147)
        ttribes.Margin = New Padding(3, 2, 3, 2)
        ttribes.Name = "ttribes"
        ttribes.Size = New Size(104, 20)
        ttribes.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(478, 65)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 13)
        Label10.TabIndex = 19
        Label10.Text = "D.O.B :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(483, 91)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 13)
        Label11.TabIndex = 20
        Label11.Text = "Ages :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(469, 119)
        Label12.Name = "Label12"
        Label12.Size = New Size(51, 13)
        Label12.TabIndex = 21
        Label12.Text = "Religion :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(443, 146)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 13)
        Label13.TabIndex = 22
        Label13.Text = "Marital Status :"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(736, 14)
        Label14.Name = "Label14"
        Label14.Size = New Size(66, 13)
        Label14.TabIndex = 23
        Label14.Text = "Dependant :"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(760, 41)
        Label15.Name = "Label15"
        Label15.Size = New Size(42, 13)
        Label15.TabIndex = 24
        Label15.Text = "P.O.H :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(761, 68)
        Label16.Name = "Label16"
        Label16.Size = New Size(42, 13)
        Label16.TabIndex = 25
        Label16.Text = "P.O.O :"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(761, 95)
        Label17.Name = "Label17"
        Label17.Size = New Size(41, 13)
        Label17.TabIndex = 26
        Label17.Text = "P.O.T :"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(762, 122)
        Label18.Name = "Label18"
        Label18.Size = New Size(43, 13)
        Label18.TabIndex = 27
        Label18.Text = "D.O.H :"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(731, 149)
        Label19.Name = "Label19"
        Label19.Size = New Size(74, 13)
        Label19.TabIndex = 28
        Label19.Text = "Contract Exp :"
        ' 
        ' tages
        ' 
        tages.Location = New Point(526, 88)
        tages.Margin = New Padding(3, 2, 3, 2)
        tages.Name = "tages"
        tages.Size = New Size(106, 20)
        tages.TabIndex = 30
        ' 
        ' treligon
        ' 
        treligon.Location = New Point(526, 115)
        treligon.Margin = New Padding(3, 2, 3, 2)
        treligon.Name = "treligon"
        treligon.Size = New Size(106, 20)
        treligon.TabIndex = 31
        ' 
        ' tdependant
        ' 
        tdependant.Location = New Point(812, 11)
        tdependant.Margin = New Padding(3, 2, 3, 2)
        tdependant.Name = "tdependant"
        tdependant.Size = New Size(106, 20)
        tdependant.TabIndex = 33
        ' 
        ' tpoh
        ' 
        tpoh.Location = New Point(812, 37)
        tpoh.Margin = New Padding(3, 2, 3, 2)
        tpoh.Name = "tpoh"
        tpoh.Size = New Size(106, 20)
        tpoh.TabIndex = 34
        ' 
        ' tpoo
        ' 
        tpoo.Location = New Point(812, 65)
        tpoo.Margin = New Padding(3, 2, 3, 2)
        tpoo.Multiline = True
        tpoo.Name = "tpoo"
        tpoo.Size = New Size(106, 17)
        tpoo.TabIndex = 35
        ' 
        ' tpot
        ' 
        tpot.Location = New Point(812, 90)
        tpot.Margin = New Padding(3, 2, 3, 2)
        tpot.Multiline = True
        tpot.Name = "tpot"
        tpot.Size = New Size(106, 18)
        tpot.TabIndex = 36
        ' 
        ' cedu
        ' 
        cedu.FormattingEnabled = True
        cedu.Items.AddRange(New Object() {"SD", "SMP", "SMA / SMK", "S1", "S2"})
        cedu.Location = New Point(304, 33)
        cedu.Margin = New Padding(3, 2, 3, 2)
        cedu.Name = "cedu"
        cedu.Size = New Size(104, 21)
        cedu.TabIndex = 39
        ' 
        ' cgender
        ' 
        cgender.FormattingEnabled = True
        cgender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        cgender.Location = New Point(526, 8)
        cgender.Margin = New Padding(3, 2, 3, 2)
        cgender.Name = "cgender"
        cgender.Size = New Size(104, 21)
        cgender.TabIndex = 40
        ' 
        ' cmarital
        ' 
        cmarital.FormattingEnabled = True
        cmarital.Items.AddRange(New Object() {"S", "M+0", "M+1", "M+2", "M+3"})
        cmarital.Location = New Point(526, 143)
        cmarital.Margin = New Padding(3, 2, 3, 2)
        cmarital.Name = "cmarital"
        cmarital.Size = New Size(106, 21)
        cmarital.TabIndex = 41
        ' 
        ' ddob
        ' 
        ddob.CustomFormat = "yyyy/MM/dd"
        ddob.Format = DateTimePickerFormat.Custom
        ddob.Location = New Point(526, 61)
        ddob.Margin = New Padding(3, 2, 3, 2)
        ddob.Name = "ddob"
        ddob.Size = New Size(106, 20)
        ddob.TabIndex = 42
        ' 
        ' ddoh
        ' 
        ddoh.CustomFormat = "yyyy/MM/dd"
        ddoh.Format = DateTimePickerFormat.Custom
        ddoh.Location = New Point(812, 119)
        ddoh.Margin = New Padding(3, 2, 3, 2)
        ddoh.Name = "ddoh"
        ddoh.Size = New Size(106, 20)
        ddoh.TabIndex = 43
        ' 
        ' dcontract
        ' 
        dcontract.CustomFormat = "yyyy/MM/dd"
        dcontract.Format = DateTimePickerFormat.Custom
        dcontract.Location = New Point(812, 146)
        dcontract.Margin = New Padding(3, 2, 3, 2)
        dcontract.Name = "dcontract"
        dcontract.Size = New Size(106, 20)
        dcontract.TabIndex = 44
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(995, 31)
        Label20.Name = "Label20"
        Label20.Size = New Size(107, 13)
        Label20.TabIndex = 45
        Label20.Text = "Actual Classification :"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(986, 95)
        Label21.Name = "Label21"
        Label21.Size = New Size(116, 13)
        Label21.TabIndex = 46
        Label21.Text = "Actual Work Location :"
        ' 
        ' tactual
        ' 
        tactual.Location = New Point(1108, 11)
        tactual.Margin = New Padding(3, 2, 3, 2)
        tactual.Multiline = True
        tactual.Name = "tactual"
        tactual.Size = New Size(158, 59)
        tactual.TabIndex = 47
        ' 
        ' tactual2
        ' 
        tactual2.Location = New Point(1108, 78)
        tactual2.Margin = New Padding(3, 2, 3, 2)
        tactual2.Multiline = True
        tactual2.Name = "tactual2"
        tactual2.Size = New Size(158, 57)
        tactual2.TabIndex = 48
        ' 
        ' bkosong
        ' 
        bkosong.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bkosong.Location = New Point(995, 159)
        bkosong.Margin = New Padding(3, 2, 3, 2)
        bkosong.Name = "bkosong"
        bkosong.Size = New Size(80, 37)
        bkosong.TabIndex = 49
        bkosong.Text = "Kosongkan"
        bkosong.UseVisualStyleBackColor = True
        ' 
        ' bsimpan
        ' 
        bsimpan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bsimpan.Location = New Point(1081, 159)
        bsimpan.Margin = New Padding(3, 2, 3, 2)
        bsimpan.Name = "bsimpan"
        bsimpan.Size = New Size(80, 37)
        bsimpan.TabIndex = 50
        bsimpan.Text = "Simpan"
        bsimpan.UseVisualStyleBackColor = True
        ' 
        ' bhapus
        ' 
        bhapus.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bhapus.Location = New Point(1167, 159)
        bhapus.Margin = New Padding(3, 2, 3, 2)
        bhapus.Name = "bhapus"
        bhapus.Size = New Size(80, 37)
        bhapus.TabIndex = 51
        bhapus.Text = "Hapus"
        bhapus.UseVisualStyleBackColor = True
        ' 
        ' bkeluar
        ' 
        bkeluar.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bkeluar.Location = New Point(1253, 159)
        bkeluar.Margin = New Padding(3, 2, 3, 2)
        bkeluar.Name = "bkeluar"
        bkeluar.Size = New Size(80, 37)
        bkeluar.TabIndex = 52
        bkeluar.Text = "Keluar"
        bkeluar.UseVisualStyleBackColor = True
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(443, 37)
        Label22.Name = "Label22"
        Label22.Size = New Size(78, 13)
        Label22.TabIndex = 53
        Label22.Text = "Place Of Birth :"
        ' 
        ' tplace
        ' 
        tplace.Location = New Point(526, 34)
        tplace.Margin = New Padding(3, 2, 3, 2)
        tplace.Name = "tplace"
        tplace.Size = New Size(104, 20)
        tplace.TabIndex = 54
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(2, 175)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 29)
        Button1.TabIndex = 56
        Button1.Text = "Export"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnDash
        ' 
        btnDash.Location = New Point(95, 175)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(87, 29)
        btnDash.TabIndex = 57
        btnDash.Text = "Dashboard"
        btnDash.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(btnDash)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(tplace)
        Controls.Add(Label22)
        Controls.Add(bkeluar)
        Controls.Add(bhapus)
        Controls.Add(bsimpan)
        Controls.Add(bkosong)
        Controls.Add(tactual2)
        Controls.Add(tactual)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(dcontract)
        Controls.Add(ddoh)
        Controls.Add(ddob)
        Controls.Add(cmarital)
        Controls.Add(cgender)
        Controls.Add(cedu)
        Controls.Add(tpot)
        Controls.Add(tpoo)
        Controls.Add(tpoh)
        Controls.Add(tdependant)
        Controls.Add(treligon)
        Controls.Add(tages)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(ttribes)
        Controls.Add(tethnic)
        Controls.Add(temp2)
        Controls.Add(temp1)
        Controls.Add(temployee)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DGV)
        Controls.Add(tri)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tfi)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "EMPLOYEE FORM  PT. REDPATH INDONESIA"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tfi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tri As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents temployee As TextBox
    Friend WithEvents temp1 As TextBox
    Friend WithEvents temp2 As TextBox
    Friend WithEvents tethnic As TextBox
    Friend WithEvents ttribes As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tages As TextBox
    Friend WithEvents treligon As TextBox
    Friend WithEvents tdependant As TextBox
    Friend WithEvents tpoh As TextBox
    Friend WithEvents tpoo As TextBox
    Friend WithEvents tpot As TextBox
    Friend WithEvents cedu As ComboBox
    Friend WithEvents cgender As ComboBox
    Friend WithEvents cmarital As ComboBox
    Friend WithEvents ddob As DateTimePicker
    Friend WithEvents ddoh As DateTimePicker
    Friend WithEvents dcontract As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tactual As TextBox
    Friend WithEvents tactual2 As TextBox
    Friend WithEvents bkosong As Button
    Friend WithEvents bsimpan As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents bkeluar As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents tplace As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnDash As Button

End Class
