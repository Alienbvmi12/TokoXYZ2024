Public Class Admin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
        Log("Logout")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        KelolaUser.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        KelolaLaporan.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = Read("select id_log, username, waktu, aktivitas from tbl_log left join tbl_user on tbl_log.id_user = tbl_user.id_user where waktu between '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & " 00:00:00' and '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & " 23:59:59'")
        DataGridView1.Columns.Item("waktu").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:dd"
    End Sub
End Class