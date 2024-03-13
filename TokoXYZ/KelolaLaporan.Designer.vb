<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaLaporan
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 833)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(249, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(660, 198)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Laporan Penjualan"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(249, 359)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(660, 302)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(771, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Generate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanggal Awal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(249, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2024, 3, 13, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tanggal Akhir"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(455, 110)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 9
        Me.DateTimePicker2.Value = New Date(2024, 3, 13, 0, 0, 0, 0)
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(661, 107)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 29)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Filter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'KelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 700)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "KelolaLaporan"
        Me.Text = "KelolaLaporan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button4 As Button
End Class
