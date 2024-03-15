Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Reflection

Public Class Kasir
    Private total As Integer
    Private kembalian As Integer
    Private kodeTransaksi As String
    Private tanggalTransaksi As Date
    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menu.Items.Clear()

        Dim dt As DataTable = Read("select concat(kode_barang, ' - ', nama_barang) as menu from tbl_barang")
        For idx = 0 To dt.Rows.Count - 1
            menu.Items.Add(dt(idx).Item("menu"))
        Next
        nama_kasir.Text = User.nama
        transaksiBaru()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles nama_kasir.Click

    End Sub

    Private Sub transaksiBaru()
        total = 0
        kembalian = 0
        menu.Text = ""
        harga_satuan.Text = ""
        qty.Text = ""
        subtotal.Text = ""
        DataGridView1.Rows.Clear()
        Bayar.Text = ""
        tanggalTransaksi = Date.Now
        Button2.Enabled = True
        generateKodeTransaksi()
    End Sub

    Private Sub generateKodeTransaksi()
        kodeTransaksi = DateTime.Now.ToString("yyyyMMddHHmmss")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        transaksiBaru()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        If menu.Text = "" Or harga_satuan.Text = "" Or qty.Text = "" Or qty.Text = "0" Or subtotal.Text = "" Then
            MsgBox("Mohon isi seluruh field terlebih dahulu!!")
        Else
            Dim dt As New DataGridViewRow
            Dim barang = menu.Text.Split("-")

            Dim exec = True
            For index = 0 To DataGridView1.Rows.Count - 1
                Dim row = DataGridView1.Rows(index)
                If row.Cells(0).Value = barang(0) Then
                    row.Cells(3).Value = Integer.Parse(row.Cells(3).Value) + Integer.Parse(qty.Text)
                    row.Cells(4).Value = Integer.Parse(row.Cells(2).Value) * Integer.Parse(row.Cells(3).Value)
                    exec = False
                End If
            Next

            If exec Then
                dt.CreateCells(DataGridView1)
                dt.Cells(0).Value = barang(0)
                dt.Cells(1).Value = barang(1)
                dt.Cells(2).Value = harga_satuan.Text
                dt.Cells(3).Value = qty.Text
                dt.Cells(4).Value = subtotal.Text
                DataGridView1.Rows.Add(dt)
            End If
        End If
    End Sub

    Private Sub menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles menu.SelectedIndexChanged
        Dim dt As DataTable = Read("select harga_satuan from tbl_barang where kode_barang='" & menu.Text.Split("-")(0) & "'")
        harga_satuan.Text = dt(0).Item(0)
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total = 0
        nama_kasir.Text = User.nama
        If qty.Text <> "" And harga_satuan.Text <> "" Then
            subtotal.Text = Integer.Parse(qty.Text) * Integer.Parse(harga_satuan.Text)
        Else
            subtotal.Text = ""
        End If

        Dim tbl As DataGridViewRowCollection = DataGridView1.Rows
        For index = 0 To tbl.Count - 1
            total += tbl(index).Cells(4).Value
        Next
        If Bayar.Text <> "" Then
            kembalian = Integer.Parse(Bayar.Text) - total
        End If
        TotalLabel.Text = total.ToString("C", CultureInfo.GetCultureInfo("id-ID"))
        KembalianLabel.Text = kembalian.ToString("C", CultureInfo.GetCultureInfo("id-ID"))
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub KembalianLabel_Click(sender As Object, e As EventArgs) Handles KembalianLabel.Click

    End Sub

    Private Sub TotalLabel_Click(sender As Object, e As EventArgs) Handles TotalLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If kembalian < 0 Or Bayar.Text = "" Then
            MsgBox("Uang tidak cukup!!")
        Else
            MsgBox("Pembayaran berhasil!!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res = MessageBox.Show("Apakah anda yakin untuk menyimpan transaksi ini?", "confirm", MessageBoxButtons.YesNo)
        Dim dt As DataGridViewRowCollection = DataGridView1.Rows
        For index = 0 To dt.Count - 1
            Dim id_barang As DataTable = Read("select id_barang from tbl_barang where kode_barang='" & dt(index).Cells(0).Value & "'")
            SendOnly("insert into tbl_transaksi 
                    (no_transaksi, tanggal_transaksi, total_bayar, id_user, id_barang, qty, harga_satuan)
                    values (
                    '" & kodeTransaksi & "',
                    '" & tanggalTransaksi & "',
                    '" & Integer.Parse(Bayar.Text) & "',
                    '" & User.id & "',
                    '" & id_barang(0).Item(0) & "',
                    '" & dt(index).Cells(3).Value & "',
                    '" & dt(index).Cells(2).Value & "')", False, False)
        Next
        MsgBox("Berhasil menyimpan transaksi ke database!!")
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim y = 280 + (DataGridView1.Rows.Count * 15)
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("custom", 300, y)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set Font
        Dim f10 As New Font("Arial", 10, FontStyle.Regular)
        Dim f10b As New Font("Arial", 10, FontStyle.Bold)
        Dim f14 As New Font("Aria", 14, FontStyle.Bold)

        ' Set Margin
        Dim marginCenter As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim marginRight As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width
        Dim marginTotal As Integer = marginCenter / 1.5

        ' Set Text Alignment
        Dim alignCenter As New StringFormat
        Dim alignRight As New StringFormat
        alignCenter.Alignment = StringAlignment.Center
        alignRight.Alignment = StringAlignment.Far

        ' Section Separator Line
        Dim line As String = "----------------------------------------------------------------"

        ' Writing the layout
        e.Graphics.DrawString("TOKO XYZ", f14, Brushes.Black, marginCenter, 5, alignCenter)
        e.Graphics.DrawString("Jl. Kebebasan No. 13", f10b, Brushes.Black, marginCenter, 25, alignCenter)
        e.Graphics.DrawString("Hp : 081224018645", f10b, Brushes.Black, marginCenter, 40, alignCenter)

        e.Graphics.DrawString("No. Transaksi", f10b, Brushes.Black, 0, 80)
        e.Graphics.DrawString("Tanggal", f10b, Brushes.Black, 0, 95)
        e.Graphics.DrawString("Kasir", f10b, Brushes.Black, 0, 110)

        e.Graphics.DrawString(" : " & kodeTransaksi, f10b, Brushes.Black, marginCenter / 1.5, 80)
        e.Graphics.DrawString(" : " & tanggalTransaksi, f10b, Brushes.Black, marginCenter / 1.5, 95)
        e.Graphics.DrawString(" : " & User.id & " - " & User.nama, f10b, Brushes.Black, marginCenter / 1.5, 110)

        e.Graphics.DrawString(line, f10b, Brushes.Black, 0, 130)

        Dim my = 135
        Dim totalQTY = 0
        Dim dt As DataGridViewRowCollection = DataGridView1.Rows

        For index = 0 To dt.Count - 1
            my += 15
            e.Graphics.DrawString(dt(index).Cells(1).Value, f10, Brushes.Black, 0, my)
            e.Graphics.DrawString(dt(index).Cells(3).Value & " x " & dt(index).Cells(2).Value, f10, Brushes.Black, marginRight, my, alignRight)
            totalQTY += Integer.Parse(dt(index).Cells(3).Value)
        Next

        e.Graphics.DrawString(line, f10b, Brushes.Black, 0, my + 20)

        e.Graphics.DrawString("Total Qty", f10b, Brushes.Black, 0, my + 40)
        e.Graphics.DrawString("Total    ", f10b, Brushes.Black, 0, my + 55)
        e.Graphics.DrawString("Bayar    ", f10b, Brushes.Black, 0, my + 70)
        e.Graphics.DrawString("Kembalian", f10b, Brushes.Black, 0, my + 85)

        e.Graphics.DrawString(" : " & totalQTY.ToString(), f10b, Brushes.Black, marginCenter / 1.5, my + 40)
        e.Graphics.DrawString(" : " & total.ToString("C", CultureInfo.GetCultureInfo("id-ID")), f10b, Brushes.Black, marginCenter / 1.5, my + 55)
        e.Graphics.DrawString(" : " & Integer.Parse(Bayar.Text).ToString("C", CultureInfo.GetCultureInfo("id-ID")), f10b, Brushes.Black, marginCenter / 1.5, my + 70)
        e.Graphics.DrawString(" : " & kembalian.ToString("C", CultureInfo.GetCultureInfo("id-ID")), f10b, Brushes.Black, marginCenter / 1.5, my + 85)
    End Sub

End Class