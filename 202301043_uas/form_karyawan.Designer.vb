<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_karyawan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_karyawan))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_id_kar = New System.Windows.Forms.TextBox()
        Me.tb_nama_kar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_email_kar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_alamat_kar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_no_kar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_usname_kar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_pass_kar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hps = New System.Windows.Forms.Button()
        Me.cbb_gender_kar = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 174)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(897, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'tb_id_kar
        '
        Me.tb_id_kar.Location = New System.Drawing.Point(70, 81)
        Me.tb_id_kar.Name = "tb_id_kar"
        Me.tb_id_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_id_kar.TabIndex = 2
        '
        'tb_nama_kar
        '
        Me.tb_nama_kar.Location = New System.Drawing.Point(70, 122)
        Me.tb_nama_kar.Name = "tb_nama_kar"
        Me.tb_nama_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_nama_kar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'tb_email_kar
        '
        Me.tb_email_kar.Location = New System.Drawing.Point(407, 71)
        Me.tb_email_kar.Name = "tb_email_kar"
        Me.tb_email_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_email_kar.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(355, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'tb_alamat_kar
        '
        Me.tb_alamat_kar.Location = New System.Drawing.Point(720, 21)
        Me.tb_alamat_kar.Name = "tb_alamat_kar"
        Me.tb_alamat_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_alamat_kar.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(650, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'tb_no_kar
        '
        Me.tb_no_kar.Location = New System.Drawing.Point(407, 21)
        Me.tb_no_kar.Name = "tb_no_kar"
        Me.tb_no_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_no_kar.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(337, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. Telp"
        '
        'tb_usname_kar
        '
        Me.tb_usname_kar.Location = New System.Drawing.Point(720, 73)
        Me.tb_usname_kar.Name = "tb_usname_kar"
        Me.tb_usname_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_usname_kar.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(620, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "User Name"
        '
        'tb_pass_kar
        '
        Me.tb_pass_kar.Location = New System.Drawing.Point(720, 122)
        Me.tb_pass_kar.Name = "tb_pass_kar"
        Me.tb_pass_kar.Size = New System.Drawing.Size(189, 26)
        Me.tb_pass_kar.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(625, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Password"
        '
        'btn_clr
        '
        Me.btn_clr.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_clr.ForeColor = System.Drawing.Color.White
        Me.btn_clr.Location = New System.Drawing.Point(137, 497)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(103, 40)
        Me.btn_clr.TabIndex = 17
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_tambah.ForeColor = System.Drawing.Color.White
        Me.btn_tambah.Location = New System.Drawing.Point(318, 497)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(103, 40)
        Me.btn_tambah.TabIndex = 18
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(499, 497)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(103, 40)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_hps
        '
        Me.btn_hps.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_hps.ForeColor = System.Drawing.Color.White
        Me.btn_hps.Location = New System.Drawing.Point(680, 497)
        Me.btn_hps.Name = "btn_hps"
        Me.btn_hps.Size = New System.Drawing.Size(103, 40)
        Me.btn_hps.TabIndex = 20
        Me.btn_hps.Text = "Hapus"
        Me.btn_hps.UseVisualStyleBackColor = False
        '
        'cbb_gender_kar
        '
        Me.cbb_gender_kar.FormattingEnabled = True
        Me.cbb_gender_kar.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbb_gender_kar.Location = New System.Drawing.Point(437, 122)
        Me.cbb_gender_kar.Name = "cbb_gender_kar"
        Me.cbb_gender_kar.Size = New System.Drawing.Size(137, 28)
        Me.cbb_gender_kar.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(297, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Script MT Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(57, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 24)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Proud Of Your Hobby"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(70, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'form_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(921, 563)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbb_gender_kar)
        Me.Controls.Add(Me.btn_hps)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.tb_pass_kar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_usname_kar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_no_kar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_alamat_kar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_email_kar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama_kar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_id_kar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "form_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_karyawan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_id_kar As TextBox
    Friend WithEvents tb_nama_kar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_email_kar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_alamat_kar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_no_kar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_usname_kar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_pass_kar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_clr As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hps As Button
    Friend WithEvents cbb_gender_kar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
