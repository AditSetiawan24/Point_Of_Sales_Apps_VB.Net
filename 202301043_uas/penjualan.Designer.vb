<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(penjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_karyawan_nama = New System.Windows.Forms.TextBox()
        Me.tb_karyawan_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_customer_id = New System.Windows.Forms.TextBox()
        Me.tb_customer_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.dgv_jual = New System.Windows.Forms.DataGridView()
        Me.Column_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_jml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_kembali = New System.Windows.Forms.Label()
        Me.tb_bayar = New System.Windows.Forms.TextBox()
        Me.cbb_metode_bayar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_idjual = New System.Windows.Forms.TextBox()
        Me.tb_id_detail_jual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_jual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(479, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Karyawan"
        '
        'tb_karyawan_nama
        '
        Me.tb_karyawan_nama.Location = New System.Drawing.Point(566, 17)
        Me.tb_karyawan_nama.Name = "tb_karyawan_nama"
        Me.tb_karyawan_nama.Size = New System.Drawing.Size(197, 26)
        Me.tb_karyawan_nama.TabIndex = 1
        '
        'tb_karyawan_id
        '
        Me.tb_karyawan_id.Location = New System.Drawing.Point(1129, 402)
        Me.tb_karyawan_id.Name = "tb_karyawan_id"
        Me.tb_karyawan_id.Size = New System.Drawing.Size(37, 26)
        Me.tb_karyawan_id.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(479, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer"
        '
        'tb_customer_id
        '
        Me.tb_customer_id.Location = New System.Drawing.Point(1129, 434)
        Me.tb_customer_id.Name = "tb_customer_id"
        Me.tb_customer_id.Size = New System.Drawing.Size(37, 26)
        Me.tb_customer_id.TabIndex = 5
        '
        'tb_customer_nama
        '
        Me.tb_customer_nama.Location = New System.Drawing.Point(566, 63)
        Me.tb_customer_nama.Name = "tb_customer_nama"
        Me.tb_customer_nama.Size = New System.Drawing.Size(197, 26)
        Me.tb_customer_nama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(882, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tanggal"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tanggal.Location = New System.Drawing.Point(966, 36)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(200, 26)
        Me.dtp_tanggal.TabIndex = 7
        '
        'dgv_jual
        '
        Me.dgv_jual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_id, Me.Column_nama, Me.Column_harga, Me.Column_jml, Me.Column_subtotal})
        Me.dgv_jual.Location = New System.Drawing.Point(17, 147)
        Me.dgv_jual.Name = "dgv_jual"
        Me.dgv_jual.RowHeadersWidth = 62
        Me.dgv_jual.RowTemplate.Height = 28
        Me.dgv_jual.Size = New System.Drawing.Size(1149, 249)
        Me.dgv_jual.TabIndex = 8
        '
        'Column_id
        '
        Me.Column_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_id.HeaderText = "ID Barang"
        Me.Column_id.MinimumWidth = 8
        Me.Column_id.Name = "Column_id"
        '
        'Column_nama
        '
        Me.Column_nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_nama.HeaderText = "Nama Barang"
        Me.Column_nama.MinimumWidth = 8
        Me.Column_nama.Name = "Column_nama"
        '
        'Column_harga
        '
        Me.Column_harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_harga.HeaderText = "Harga"
        Me.Column_harga.MinimumWidth = 8
        Me.Column_harga.Name = "Column_harga"
        '
        'Column_jml
        '
        Me.Column_jml.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_jml.HeaderText = "Jumlah"
        Me.Column_jml.MinimumWidth = 8
        Me.Column_jml.Name = "Column_jml"
        '
        'Column_subtotal
        '
        Me.Column_subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_subtotal.HeaderText = "Sub Total"
        Me.Column_subtotal.MinimumWidth = 8
        Me.Column_subtotal.Name = "Column_subtotal"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(124, 431)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(106, 46)
        Me.btn_simpan.TabIndex = 9
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_batal.ForeColor = System.Drawing.Color.White
        Me.btn_batal.Location = New System.Drawing.Point(250, 431)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(106, 46)
        Me.btn_batal.TabIndex = 10
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(891, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total : Rp. "
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(1010, 437)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(26, 29)
        Me.lb_total.TabIndex = 12
        Me.lb_total.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(608, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Bayar :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(576, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kembalian : Rp."
        '
        'lb_kembali
        '
        Me.lb_kembali.AutoSize = True
        Me.lb_kembali.ForeColor = System.Drawing.Color.White
        Me.lb_kembali.Location = New System.Drawing.Point(702, 470)
        Me.lb_kembali.Name = "lb_kembali"
        Me.lb_kembali.Size = New System.Drawing.Size(18, 20)
        Me.lb_kembali.TabIndex = 15
        Me.lb_kembali.Text = "0"
        '
        'tb_bayar
        '
        Me.tb_bayar.Location = New System.Drawing.Point(672, 417)
        Me.tb_bayar.Name = "tb_bayar"
        Me.tb_bayar.Size = New System.Drawing.Size(141, 26)
        Me.tb_bayar.TabIndex = 16
        '
        'cbb_metode_bayar
        '
        Me.cbb_metode_bayar.FormattingEnabled = True
        Me.cbb_metode_bayar.Items.AddRange(New Object() {"Tunai", "Transfer Bank"})
        Me.cbb_metode_bayar.Location = New System.Drawing.Point(966, 83)
        Me.cbb_metode_bayar.Name = "cbb_metode_bayar"
        Me.cbb_metode_bayar.Size = New System.Drawing.Size(200, 28)
        Me.cbb_metode_bayar.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(792, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Metode Pembayaran"
        '
        'tb_idjual
        '
        Me.tb_idjual.Location = New System.Drawing.Point(566, 104)
        Me.tb_idjual.Name = "tb_idjual"
        Me.tb_idjual.Size = New System.Drawing.Size(197, 26)
        Me.tb_idjual.TabIndex = 19
        '
        'tb_id_detail_jual
        '
        Me.tb_id_detail_jual.Location = New System.Drawing.Point(1129, 470)
        Me.tb_id_detail_jual.Name = "tb_id_detail_jual"
        Me.tb_id_detail_jual.Size = New System.Drawing.Size(37, 26)
        Me.tb_id_detail_jual.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(498, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Id Jual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Script MT Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(119, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Proud Of Your Hobby"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1178, 505)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_id_detail_jual)
        Me.Controls.Add(Me.tb_idjual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_metode_bayar)
        Me.Controls.Add(Me.tb_bayar)
        Me.Controls.Add(Me.lb_kembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgv_jual)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_customer_id)
        Me.Controls.Add(Me.tb_customer_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_karyawan_id)
        Me.Controls.Add(Me.tb_karyawan_nama)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "penjualan"
        CType(Me.dgv_jual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_karyawan_nama As TextBox
    Friend WithEvents tb_karyawan_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_customer_id As TextBox
    Friend WithEvents tb_customer_nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents dgv_jual As DataGridView
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_total As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_kembali As Label
    Friend WithEvents tb_bayar As TextBox
    Friend WithEvents Column_id As DataGridViewTextBoxColumn
    Friend WithEvents Column_nama As DataGridViewTextBoxColumn
    Friend WithEvents Column_harga As DataGridViewTextBoxColumn
    Friend WithEvents Column_jml As DataGridViewTextBoxColumn
    Friend WithEvents Column_subtotal As DataGridViewTextBoxColumn
    Friend WithEvents cbb_metode_bayar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_idjual As TextBox
    Friend WithEvents tb_id_detail_jual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
