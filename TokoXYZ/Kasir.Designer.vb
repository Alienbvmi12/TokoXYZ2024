<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.MaskedTextBox()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.harga_satuan = New System.Windows.Forms.MaskedTextBox()
        Me.qty = New System.Windows.Forms.MaskedTextBox()
        Me.Bayar = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.nama_kasir = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.KembalianLabel = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(61, 269)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(75, 29)
        Me.Logout.TabIndex = 1
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kasir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 639)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_barang, Me.nama_barang, Me.harga_satuan2, Me.qty2, Me.subtotal2})
        Me.DataGridView1.Location = New System.Drawing.Point(251, 266)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(501, 198)
        Me.DataGridView1.TabIndex = 2
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.MinimumWidth = 8
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        Me.kode_barang.Width = 150
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.MinimumWidth = 8
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.ReadOnly = True
        Me.nama_barang.Width = 150
        '
        'harga_satuan2
        '
        Me.harga_satuan2.HeaderText = "Harga Satuan"
        Me.harga_satuan2.MinimumWidth = 8
        Me.harga_satuan2.Name = "harga_satuan2"
        Me.harga_satuan2.ReadOnly = True
        Me.harga_satuan2.Width = 150
        '
        'qty2
        '
        Me.qty2.HeaderText = "Qty"
        Me.qty2.MinimumWidth = 8
        Me.qty2.Name = "qty2"
        Me.qty2.ReadOnly = True
        Me.qty2.Width = 150
        '
        'subtotal2
        '
        Me.subtotal2.HeaderText = "Subtotal"
        Me.subtotal2.MinimumWidth = 8
        Me.subtotal2.Name = "subtotal2"
        Me.subtotal2.ReadOnly = True
        Me.subtotal2.Width = 150
        '
        'menu
        '
        Me.menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.menu.FormattingEnabled = True
        Me.menu.Location = New System.Drawing.Point(251, 110)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(233, 28)
        Me.menu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pilih Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Harga Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(515, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Qty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Harga"
        '
        'subtotal
        '
        Me.subtotal.Enabled = False
        Me.subtotal.Location = New System.Drawing.Point(519, 174)
        Me.subtotal.Mask = "00000000000000000000"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(233, 26)
        Me.subtotal.TabIndex = 9
        '
        'Tambah
        '
        Me.Tambah.Location = New System.Drawing.Point(519, 216)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(107, 29)
        Me.Tambah.TabIndex = 2
        Me.Tambah.Text = "Tambah"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(632, 216)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(120, 29)
        Me.Reset.TabIndex = 11
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'harga_satuan
        '
        Me.harga_satuan.Enabled = False
        Me.harga_satuan.Location = New System.Drawing.Point(251, 174)
        Me.harga_satuan.Mask = "00000000000000000000"
        Me.harga_satuan.Name = "harga_satuan"
        Me.harga_satuan.Size = New System.Drawing.Size(233, 26)
        Me.harga_satuan.TabIndex = 12
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(519, 112)
        Me.qty.Mask = "00000000000000000000"
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(233, 26)
        Me.qty.TabIndex = 13
        '
        'Bayar
        '
        Me.Bayar.Location = New System.Drawing.Point(251, 516)
        Me.Bayar.Mask = "00000000000000000000"
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(233, 26)
        Me.Bayar.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Harga  "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 29)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 580)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kembalian   "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(632, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 29)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(519, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 29)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(519, 516)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 29)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Transaksi Baru"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'nama_kasir
        '
        Me.nama_kasir.AutoSize = True
        Me.nama_kasir.BackColor = System.Drawing.Color.Tomato
        Me.nama_kasir.Location = New System.Drawing.Point(649, 43)
        Me.nama_kasir.Name = "nama_kasir"
        Me.nama_kasir.Size = New System.Drawing.Size(45, 20)
        Me.nama_kasir.TabIndex = 21
        Me.nama_kasir.Text = "Nami"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(245, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 32)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Form Transaksi"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(335, 493)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TotalLabel.Size = New System.Drawing.Size(149, 20)
        Me.TotalLabel.TabIndex = 22
        Me.TotalLabel.Text = "Rp. 999.999.999,00"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'KembalianLabel
        '
        Me.KembalianLabel.AutoSize = True
        Me.KembalianLabel.Location = New System.Drawing.Point(335, 580)
        Me.KembalianLabel.Name = "KembalianLabel"
        Me.KembalianLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.KembalianLabel.Size = New System.Drawing.Size(149, 20)
        Me.KembalianLabel.TabIndex = 23
        Me.KembalianLabel.Text = "Rp. 999.999.999,00"
        Me.KembalianLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 635)
        Me.Controls.Add(Me.KembalianLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nama_kasir)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bayar)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.harga_satuan)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Kasir"
        Me.Text = "Kasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents menu As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents subtotal As MaskedTextBox
    Friend WithEvents Tambah As Button
    Friend WithEvents Reset As Button
    Friend WithEvents qty As MaskedTextBox
    Friend WithEvents Bayar As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents nama_kasir As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan2 As DataGridViewTextBoxColumn
    Friend WithEvents qty2 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal2 As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan As MaskedTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TotalLabel As Label
    Friend WithEvents KembalianLabel As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
