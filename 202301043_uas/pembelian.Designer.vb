<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pembelian))
        Me.tb_supplyer_id = New System.Windows.Forms.TextBox()
        Me.tb_supplyer_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_karyawan_id = New System.Windows.Forms.TextBox()
        Me.tb_karyawan_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_beli = New System.Windows.Forms.DataGridView()
        Me.Column_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_jml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_idbeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_id_detail_beli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_beli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_supplyer_id
        '
        Me.tb_supplyer_id.Location = New System.Drawing.Point(333, 442)
        Me.tb_supplyer_id.Name = "tb_supplyer_id"
        Me.tb_supplyer_id.Size = New System.Drawing.Size(197, 26)
        Me.tb_supplyer_id.TabIndex = 11
        '
        'tb_supplyer_nama
        '
        Me.tb_supplyer_nama.Location = New System.Drawing.Point(564, 70)
        Me.tb_supplyer_nama.Name = "tb_supplyer_nama"
        Me.tb_supplyer_nama.Size = New System.Drawing.Size(197, 26)
        Me.tb_supplyer_nama.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(477, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Supplyer"
        '
        'tb_karyawan_id
        '
        Me.tb_karyawan_id.Location = New System.Drawing.Point(333, 392)
        Me.tb_karyawan_id.Name = "tb_karyawan_id"
        Me.tb_karyawan_id.Size = New System.Drawing.Size(197, 26)
        Me.tb_karyawan_id.TabIndex = 8
        '
        'tb_karyawan_nama
        '
        Me.tb_karyawan_nama.Location = New System.Drawing.Point(564, 20)
        Me.tb_karyawan_nama.Name = "tb_karyawan_nama"
        Me.tb_karyawan_nama.Size = New System.Drawing.Size(197, 26)
        Me.tb_karyawan_nama.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(477, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Karyawan"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tanggal.Location = New System.Drawing.Point(951, 17)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(200, 26)
        Me.dtp_tanggal.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(867, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal"
        '
        'dgv_beli
        '
        Me.dgv_beli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_beli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_id, Me.Column_nama, Me.Column_harga, Me.Column_jml, Me.Column_subtotal})
        Me.dgv_beli.Location = New System.Drawing.Point(15, 128)
        Me.dgv_beli.Name = "dgv_beli"
        Me.dgv_beli.RowHeadersWidth = 62
        Me.dgv_beli.RowTemplate.Height = 28
        Me.dgv_beli.Size = New System.Drawing.Size(1149, 249)
        Me.dgv_beli.TabIndex = 14
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
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_batal.ForeColor = System.Drawing.Color.White
        Me.btn_batal.Location = New System.Drawing.Point(142, 422)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(106, 46)
        Me.btn_batal.TabIndex = 16
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(16, 422)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(106, 46)
        Me.btn_simpan.TabIndex = 15
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(797, 422)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(26, 29)
        Me.lb_total.TabIndex = 18
        Me.lb_total.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(678, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total : Rp. "
        '
        'tb_idbeli
        '
        Me.tb_idbeli.Location = New System.Drawing.Point(951, 76)
        Me.tb_idbeli.Name = "tb_idbeli"
        Me.tb_idbeli.Size = New System.Drawing.Size(95, 26)
        Me.tb_idbeli.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(874, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Id Beli"
        '
        'tb_id_detail_beli
        '
        Me.tb_id_detail_beli.Location = New System.Drawing.Point(1069, 383)
        Me.tb_id_detail_beli.Name = "tb_id_detail_beli"
        Me.tb_id_detail_beli.Size = New System.Drawing.Size(95, 26)
        Me.tb_id_detail_beli.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Script MT Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(138, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Proud Of Your Hobby"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1178, 505)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_id_detail_beli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_idbeli)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgv_beli)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_supplyer_id)
        Me.Controls.Add(Me.tb_supplyer_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_karyawan_id)
        Me.Controls.Add(Me.tb_karyawan_nama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pembelian"
        CType(Me.dgv_beli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_supplyer_id As TextBox
    Friend WithEvents tb_supplyer_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_karyawan_id As TextBox
    Friend WithEvents tb_karyawan_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_beli As DataGridView
    Friend WithEvents Column_id As DataGridViewTextBoxColumn
    Friend WithEvents Column_nama As DataGridViewTextBoxColumn
    Friend WithEvents Column_harga As DataGridViewTextBoxColumn
    Friend WithEvents Column_jml As DataGridViewTextBoxColumn
    Friend WithEvents Column_subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents lb_total As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_idbeli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_id_detail_beli As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
