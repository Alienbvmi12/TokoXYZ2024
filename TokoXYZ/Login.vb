Public Class Login
    Dim dt As DataTable
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Mohon isi field terlebih dahulu!!")
        Else
            dt = Read("select * from tbl_user where username='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'")
            If (dt.Rows.Count > 0) Then
                If dt(0).Item("tipe_user") = "Admin" Then
                    MsgBox("Admin")
                    Admin.Show()
                    Me.Hide()
                ElseIf dt(0).Item("tipe_user") = "Gudang" Then
                    MsgBox("Gudang")
                    Gudang.Show()
                    Me.Hide()
                ElseIf dt(0).Item("tipe_user") = "Kasir" Then
                    MsgBox("Kasir")
                    Kasir.Show()
                    Me.Hide()
                End If
                User.id = dt(0).Item("id_user")
                User.nama = dt(0).Item("nama")
                User.username = dt(0).Item("username")
                User.tipe_user = dt(0).Item("tipe_user")
                Log("Login")
            Else
                MsgBox("Username atau password salah")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub
End Class
