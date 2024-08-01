<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan_custom_order
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_total_custom = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(359, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LAPORAN CUSTOM ORDER"
        '
        'lb_total_custom
        '
        Me.lb_total_custom.AutoSize = True
        Me.lb_total_custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_custom.ForeColor = System.Drawing.Color.White
        Me.lb_total_custom.Location = New System.Drawing.Point(976, 450)
        Me.lb_total_custom.Name = "lb_total_custom"
        Me.lb_total_custom.Size = New System.Drawing.Size(24, 25)
        Me.lb_total_custom.TabIndex = 9
        Me.lb_total_custom.Text = "0"
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.ForeColor = System.Drawing.Color.White
        Me.l.Location = New System.Drawing.Point(643, 450)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(294, 25)
        Me.l.TabIndex = 8
        Me.l.Text = "Total Penjualan Custom : Rp."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1154, 355)
        Me.DataGridView1.TabIndex = 10
        '
        'laporan_custom_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1178, 505)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lb_total_custom)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.Label1)
        Me.Name = "laporan_custom_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "laporan_custom_order"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lb_total_custom As Label
    Friend WithEvents l As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
