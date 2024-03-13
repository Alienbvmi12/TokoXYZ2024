Public Class Gudang
    Private id_barang As Integer = 0
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If id_barang = 0 Then
            Button4.Enabled = False
            Button5.Enabled = False
        Else
            Button4.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub loadtb()
        DataGridView1.DataSource = Read("select * from tbl_barang")
    End Sub

    Private Sub Gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtb()
    End Sub

    Private Sub search_KeyUp(sender As Object, e As KeyEventArgs) Handles search.KeyUp
        DataGridView1.DataSource = Read("select * from tbl_barang where nama_barang like '" & search.Text & "%'")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If kode_barang.Text = "" Or
            nama_barang.Text = "" Or
            jumlah_barang.Text = "" Or
            satuan.Text = "" Or
            harga_satuan.Text = "" Then
            MsgBox("Mohon isi seluruh field terlebih dahulu!!")
        Else
            SendOnly("insert into tbl_barang (kode_barang, nama_barang, expired_date, jumlah_barang, satuan, harga_satuan) 
                        values ('" & kode_barang.Text & "', '" & nama_barang.Text & "', '" & expired_date.Value.ToString("yyyy-MM-dd") & "', '" & jumlah_barang.Text & "', '" & satuan.Text & "', '" & harga_satuan.Text & "')")
            Log("Tambah Barang")
            loadtb()
            cls()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim idx = e.RowIndex
        If idx < 0 Then
            idx = 0
        End If

        Dim row As DataGridViewRow = DataGridView1.Rows(idx)

        id_barang = row.Cells(0).Value
        kode_barang.Text = row.Cells(1).Value
        nama_barang.Text = row.Cells(2).Value
        expired_date.Value = row.Cells(3).Value
        jumlah_barang.Text = row.Cells(4).Value
        satuan.Text = row.Cells(5).Value
        harga_satuan.Text = row.Cells(6).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If kode_barang.Text = "" Or
            nama_barang.Text = "" Or
            jumlah_barang.Text = "" Or
            satuan.Text = "" Or
            harga_satuan.Text = "" Then
            MsgBox("Mohon isi seluruh field terlebih dahulu!!")
        Else
            SendOnly("update tbl_barang set kode_barang='" & kode_barang.Text & "', nama_barang='" & nama_barang.Text & "', expired_date='" & expired_date.Value.ToString("yyyy-MM-dd") & "', jumlah_barang='" & jumlah_barang.Text & "', satuan='" & satuan.Text & "', harga_satuan='" & harga_satuan.Text & "' where id_barang='" & id_barang & "'")
            Log("Edit Barang. Id: " & id_barang)
            id_barang = 0
            loadtb()
            cls()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SendOnly("delete from tbl_barang where id_barang='" & id_barang & "'")
        Log("Hapus Barang. Id: " & id_barang)
        id_barang = 0
        loadtb()
        cls()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        cls()
    End Sub

    Private Sub cls()
        id_barang = 0
        kode_barang.Text = ""
        nama_barang.Text = ""
        jumlah_barang.Text = ""
        satuan.Text = ""
        harga_satuan.Text = ""
    End Sub
End Class