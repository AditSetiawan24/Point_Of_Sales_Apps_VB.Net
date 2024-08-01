<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custom_order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custom_order))
        Me.tb_customer_id = New System.Windows.Forms.TextBox()
        Me.tb_customer_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_karyawan_id = New System.Windows.Forms.TextBox()
        Me.tb_karyawan_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbb_metode_bayar = New System.Windows.Forms.ComboBox()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbb_jenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbb_bahan = New System.Windows.Forms.ComboBox()
        Me.cbb_status = New System.Windows.Forms.ComboBox()
        Me.dgv_custom = New System.Windows.Forms.DataGridView()
        Me.desain_custom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jml_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan_cst = New System.Windows.Forms.Button()
        Me.tb_bayar = New System.Windows.Forms.TextBox()
        Me.lb_kembali = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_idcustomorder = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_customer_id
        '
        Me.tb_customer_id.Location = New System.Drawing.Point(1143, 443)
        Me.tb_customer_id.Name = "tb_customer_id"
        Me.tb_customer_id.Size = New System.Drawing.Size(11, 26)
        Me.tb_customer_id.TabIndex = 11
        '
        'tb_customer_nama
        '
        Me.tb_customer_nama.Location = New System.Drawing.Point(381, 75)
        Me.tb_customer_nama.Name = "tb_customer_nama"
        Me.tb_customer_nama.Size = New System.Drawing.Size(197, 26)
        Me.tb_customer_nama.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(294, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Customer"
        '
        'tb_karyawan_id
        '
        Me.tb_karyawan_id.Location = New System.Drawing.Point(1143, 393)
        Me.tb_karyawan_id.Name = "tb_karyawan_id"
        Me.tb_karyawan_id.Size = New System.Drawing.Size(11, 26)
        Me.tb_karyawan_id.TabIndex = 8
        '
        'tb_karyawan_nama
        '
        Me.tb_karyawan_nama.Location = New System.Drawing.Point(381, 25)
        Me.tb_karyawan_nama.Name = "tb_karyawan_nama"
        Me.tb_karyawan_nama.Size = New System.Drawing.Size(197, 26)
        Me.tb_karyawan_nama.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(294, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Karyawan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(615, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Metode Pembayaran"
        '
        'cbb_metode_bayar
        '
        Me.cbb_metode_bayar.FormattingEnabled = True
        Me.cbb_metode_bayar.Items.AddRange(New Object() {"Tunai", "Transfer Bank"})
        Me.cbb_metode_bayar.Location = New System.Drawing.Point(789, 75)
        Me.cbb_metode_bayar.Name = "cbb_metode_bayar"
        Me.cbb_metode_bayar.Size = New System.Drawing.Size(145, 28)
        Me.cbb_metode_bayar.TabIndex = 21
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tanggal.Location = New System.Drawing.Point(789, 22)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(145, 26)
        Me.dtp_tanggal.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(705, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(978, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Jenis"
        '
        'cbb_jenis
        '
        Me.cbb_jenis.FormattingEnabled = True
        Me.cbb_jenis.Items.AddRange(New Object() {"Figma Figure", "S.H.Figuarts", "Nendoroid", "Petite Chara", "Mecha"})
        Me.cbb_jenis.Location = New System.Drawing.Point(1031, 54)
        Me.cbb_jenis.Name = "cbb_jenis"
        Me.cbb_jenis.Size = New System.Drawing.Size(123, 28)
        Me.cbb_jenis.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(968, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Bahan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(969, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Status"
        '
        'cbb_bahan
        '
        Me.cbb_bahan.FormattingEnabled = True
        Me.cbb_bahan.Items.AddRange(New Object() {"ABS", "Vinyl PVC", "Resin", "Metal"})
        Me.cbb_bahan.Location = New System.Drawing.Point(1031, 96)
        Me.cbb_bahan.Name = "cbb_bahan"
        Me.cbb_bahan.Size = New System.Drawing.Size(123, 28)
        Me.cbb_bahan.TabIndex = 29
        '
        'cbb_status
        '
        Me.cbb_status.FormattingEnabled = True
        Me.cbb_status.Items.AddRange(New Object() {"Pending", "In Progress", "Completed"})
        Me.cbb_status.Location = New System.Drawing.Point(1031, 12)
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.Size = New System.Drawing.Size(123, 28)
        Me.cbb_status.TabIndex = 30
        '
        'dgv_custom
        '
        Me.dgv_custom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_custom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desain_custom, Me.jml_order, Me.total_hrg})
        Me.dgv_custom.Location = New System.Drawing.Point(15, 128)
        Me.dgv_custom.Name = "dgv_custom"
        Me.dgv_custom.RowHeadersWidth = 62
        Me.dgv_custom.RowTemplate.Height = 28
        Me.dgv_custom.Size = New System.Drawing.Size(1149, 249)
        Me.dgv_custom.TabIndex = 31
        '
        'desain_custom
        '
        Me.desain_custom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.desain_custom.HeaderText = "Design Custom"
        Me.desain_custom.MinimumWidth = 8
        Me.desain_custom.Name = "desain_custom"
        '
        'jml_order
        '
        Me.jml_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jml_order.HeaderText = "Jumlah Order"
        Me.jml_order.MinimumWidth = 8
        Me.jml_order.Name = "jml_order"
        '
        'total_hrg
        '
        Me.total_hrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.total_hrg.HeaderText = "Total Harga"
        Me.total_hrg.MinimumWidth = 8
        Me.total_hrg.Name = "total_hrg"
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_batal.ForeColor = System.Drawing.Color.White
        Me.btn_batal.Location = New System.Drawing.Point(175, 421)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(106, 46)
        Me.btn_batal.TabIndex = 33
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'btn_simpan_cst
        '
        Me.btn_simpan_cst.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_simpan_cst.ForeColor = System.Drawing.Color.White
        Me.btn_simpan_cst.Location = New System.Drawing.Point(49, 421)
        Me.btn_simpan_cst.Name = "btn_simpan_cst"
        Me.btn_simpan_cst.Size = New System.Drawing.Size(106, 46)
        Me.btn_simpan_cst.TabIndex = 32
        Me.btn_simpan_cst.Text = "Simpan"
        Me.btn_simpan_cst.UseVisualStyleBackColor = False
        '
        'tb_bayar
        '
        Me.tb_bayar.Location = New System.Drawing.Point(554, 399)
        Me.tb_bayar.Name = "tb_bayar"
        Me.tb_bayar.Size = New System.Drawing.Size(141, 26)
        Me.tb_bayar.TabIndex = 39
        '
        'lb_kembali
        '
        Me.lb_kembali.AutoSize = True
        Me.lb_kembali.ForeColor = System.Drawing.Color.White
        Me.lb_kembali.Location = New System.Drawing.Point(584, 449)
        Me.lb_kembali.Name = "lb_kembali"
        Me.lb_kembali.Size = New System.Drawing.Size(18, 20)
        Me.lb_kembali.TabIndex = 38
        Me.lb_kembali.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(458, 449)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Kembalian : Rp."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(490, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Bayar :"
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(968, 427)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(26, 29)
        Me.lb_total.TabIndex = 35
        Me.lb_total.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(818, 427)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 29)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Total : Rp. "
        '
        'tb_idcustomorder
        '
        Me.tb_idcustomorder.Location = New System.Drawing.Point(1066, 469)
        Me.tb_idcustomorder.Name = "tb_idcustomorder"
        Me.tb_idcustomorder.Size = New System.Drawing.Size(100, 26)
        Me.tb_idcustomorder.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Script MT Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(56, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 24)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Proud Of Your Hobby"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'custom_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1178, 505)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_idcustomorder)
        Me.Controls.Add(Me.tb_bayar)
        Me.Controls.Add(Me.lb_kembali)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan_cst)
        Me.Controls.Add(Me.dgv_custom)
        Me.Controls.Add(Me.cbb_status)
        Me.Controls.Add(Me.cbb_bahan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbb_jenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_metode_bayar)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_customer_id)
        Me.Controls.Add(Me.tb_customer_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_karyawan_id)
        Me.Controls.Add(Me.tb_karyawan_nama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "custom_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "custom_order"
        CType(Me.dgv_custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_customer_id As TextBox
    Friend WithEvents tb_customer_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_karyawan_id As TextBox
    Friend WithEvents tb_karyawan_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbb_metode_bayar As ComboBox
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbb_jenis As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbb_bahan As ComboBox
    Friend WithEvents cbb_status As ComboBox
    Friend WithEvents dgv_custom As DataGridView
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan_cst As Button
    Friend WithEvents tb_bayar As TextBox
    Friend WithEvents lb_kembali As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lb_total As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_idcustomorder As TextBox
    Friend WithEvents desain_custom As DataGridViewTextBoxColumn
    Friend WithEvents jml_order As DataGridViewTextBoxColumn
    Friend WithEvents total_hrg As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
