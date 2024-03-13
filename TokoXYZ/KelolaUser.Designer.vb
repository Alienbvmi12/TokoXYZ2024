<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaUser
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tipe_user = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.telpon = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.MaskedTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 676)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Kelola User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Kelola Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(18, 331)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(149, 29)
        Me.Logout.TabIndex = 1
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(241, 168)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(226, 26)
        Me.nama.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipe User"
        '
        'tipe_user
        '
        Me.tipe_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipe_user.FormattingEnabled = True
        Me.tipe_user.Items.AddRange(New Object() {"Kasir", "Gudang"})
        Me.tipe_user.Location = New System.Drawing.Point(241, 108)
        Me.tipe_user.Name = "tipe_user"
        Me.tipe_user.Size = New System.Drawing.Size(226, 28)
        Me.tipe_user.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(241, 402)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(501, 235)
        Me.DataGridView1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kelola User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Telpon"
        '
        'telpon
        '
        Me.telpon.Location = New System.Drawing.Point(241, 232)
        Me.telpon.Mask = "000000000000000"
        Me.telpon.Name = "telpon"
        Me.telpon.Size = New System.Drawing.Size(226, 26)
        Me.telpon.TabIndex = 11
        Me.telpon.ValidatingType = GetType(Integer)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Alamat"
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(516, 108)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(226, 26)
        Me.alamat.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Username"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(516, 168)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(226, 26)
        Me.username.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(512, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Password"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(516, 232)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(226, 26)
        Me.password.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(241, 284)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(346, 284)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 29)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(451, 284)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 29)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(241, 357)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(182, 26)
        Me.search.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(237, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Search"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 400
        '
        'KelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 677)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.telpon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tipe_user)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "KelolaUser"
        Me.Text = "KelolaUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nama As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tipe_user As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents telpon As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents alamat As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents username As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents password As MaskedTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents search As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
End Class
