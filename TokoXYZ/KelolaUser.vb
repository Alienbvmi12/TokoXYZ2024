Public Class KelolaUser
    Private id_user As Integer = 0
    Private Sub loadtb()
        DataGridView1.DataSource = Read("select * from tbl_user where tipe_user != 'Admin'")
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        KelolaLaporan.Show()
    End Sub

    Private Sub KelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtb()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If nama.Text = "" Or
            tipe_user.Text = "" Or
            telpon.Text = "" Or
            alamat.Text = "" Or
            username.Text = "" Or
            password.Text = "" Then
            MsgBox("Mohon isi seluruh field terlebih dahulu!!")
        Else
            SendOnly("insert into tbl_user (nama, telpon, alamat, username, password, tipe_user) values ('" & nama.Text & "', '" & telpon.Text & "', '" & alamat.Text & "', '" & username.Text & "', '" & password.Text & "', '" & tipe_user.Text & "')")
            id_user = 0
            loadtb()
            Log("Tambah User")
        End If

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If nama.Text = "" Or
            tipe_user.Text = "" Or
            telpon.Text = "" Or
            alamat.Text = "" Or
            username.Text = "" Or
            password.Text = "" Then
            MsgBox("Mohon isi seluruh field terlebih dahulu!!")
        Else
            SendOnly("update tbl_user set 
                        nama = '" & nama.Text & "',
                        telpon = '" & telpon.Text & "',  
                        alamat ='" & alamat.Text & "', 
                        username = '" & username.Text & "', 
                        password = '" & password.Text & "', 
                        tipe_user = '" & tipe_user.Text & "' where id_user='" & id_user & "'")
            Log("Edit User. Id: " & id_user)
            id_user = 0
            loadtb()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SendOnly("delete from tbl_user where id_user='" & id_user & "'")
        Log("Hapus User. Id: " & id_user)
        id_user = 0
        loadtb()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim idx = e.RowIndex
        If idx < 0 Then
            idx = 0
        End If
        Dim row As DataGridViewRow = DataGridView1.Rows(idx)

        id_user = row.Cells(0).Value
        tipe_user.Text = row.Cells(1).Value
        nama.Text = row.Cells(2).Value
        telpon.Text = row.Cells(4).Value
        alamat.Text = row.Cells(3).Value
        username.Text = row.Cells(5).Value
        password.Text = row.Cells(6).Value


    End Sub

    Private Sub search_KeyUp(sender As Object, e As KeyEventArgs) Handles search.KeyUp
        DataGridView1.DataSource = Read("select * from tbl_user where nama like '" & search.Text & "%' and tipe_user != 'Admin'")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If id_user = 0 Then
            Button4.Enabled = False
            Button5.Enabled = False
        Else
            Button4.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
        Log("Logout")
    End Sub
End Class