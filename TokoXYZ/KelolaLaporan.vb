Imports System.ComponentModel

Public Class KelolaLaporan
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value
        DateTimePicker2.Value = DateTimePicker1.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.DataSource = Read("Select no_transaksi as [No Transaksi], tanggal_transaksi as [Tanggal Transaksi], sum(qty * harga_satuan) as [Total Pembayaran], nama as [Nama Kasir] from tbl_transaksi left join tbl_user on tbl_transaksi.id_user = tbl_user.id_user where tanggal_transaksi between '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "' group by no_transaksi, tanggal_transaksi, nama")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        KelolaUser.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Chart1.Series.Clear()
        Chart1.Series.Add("Omset")
        Dim dt As DataTable = Read("Select tanggal_transaksi, sum(qty * harga_satuan) as [total] from tbl_transaksi where tanggal_transaksi between '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "' group by tanggal_transaksi")
        For idx As Integer = 0 To dt.Rows.Count - 1
            Chart1.Series("Omset").Points.AddXY(dt(idx).Item("tanggal_transaksi"), dt(idx).Item("total"))
        Next
        Chart1.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
        Log("Logout")
    End Sub
End Class