<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gudang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.MaskedTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.satuan = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama_barang = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.harga_satuan = New System.Windows.Forms.MaskedTextBox()
        Me.expired_date = New System.Windows.Forms.DateTimePicker()
        Me.jumlah_barang = New System.Windows.Forms.MaskedTextBox()
        Me.kode_barang = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 689)
        Me.Panel1.TabIndex = 0
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(57, 267)
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
        Me.Label1.Location = New System.Drawing.Point(39, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gudang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(249, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Search"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(253, 369)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(182, 26)
        Me.search.TabIndex = 40
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(463, 296)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 29)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(358, 296)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 29)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(253, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 29)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(524, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Harga Per Satuan (Rp)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(524, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Satuan"
        '
        'satuan
        '
        Me.satuan.Location = New System.Drawing.Point(528, 180)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(226, 26)
        Me.satuan.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(524, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Jumlah Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Expired Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 32)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Kelola Barang"
        '
        'nama_barang
        '
        Me.nama_barang.Location = New System.Drawing.Point(253, 180)
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Size = New System.Drawing.Size(226, 26)
        Me.nama_barang.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Kode Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(253, 414)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(501, 235)
        Me.DataGridView1.TabIndex = 25
        '
        'harga_satuan
        '
        Me.harga_satuan.Location = New System.Drawing.Point(528, 244)
        Me.harga_satuan.Mask = "00000000000000000000"
        Me.harga_satuan.Name = "harga_satuan"
        Me.harga_satuan.Size = New System.Drawing.Size(226, 26)
        Me.harga_satuan.TabIndex = 42
        Me.harga_satuan.ValidatingType = GetType(Integer)
        '
        'expired_date
        '
        Me.expired_date.CustomFormat = "dd/MM/yyyy"
        Me.expired_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.expired_date.Location = New System.Drawing.Point(253, 244)
        Me.expired_date.Name = "expired_date"
        Me.expired_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.expired_date.Size = New System.Drawing.Size(226, 26)
        Me.expired_date.TabIndex = 43
        Me.expired_date.Value = New Date(2024, 3, 13, 0, 0, 0, 0)
        '
        'jumlah_barang
        '
        Me.jumlah_barang.Location = New System.Drawing.Point(528, 120)
        Me.jumlah_barang.Mask = "00000000000000000000"
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Size = New System.Drawing.Size(226, 26)
        Me.jumlah_barang.TabIndex = 44
        Me.jumlah_barang.ValidatingType = GetType(Integer)
        '
        'kode_barang
        '
        Me.kode_barang.Location = New System.Drawing.Point(253, 120)
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Size = New System.Drawing.Size(226, 26)
        Me.kode_barang.TabIndex = 45
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 400
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 29)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 686)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kode_barang)
        Me.Controls.Add(Me.jumlah_barang)
        Me.Controls.Add(Me.expired_date)
        Me.Controls.Add(Me.harga_satuan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nama_barang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Gudang"
        Me.Text = "Gudang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Logout As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents search As MaskedTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents satuan As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nama_barang As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents harga_satuan As MaskedTextBox
    Friend WithEvents expired_date As DateTimePicker
    Friend WithEvents jumlah_barang As MaskedTextBox
    Friend WithEvents kode_barang As MaskedTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
