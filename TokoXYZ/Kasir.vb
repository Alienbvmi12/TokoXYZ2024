Public Class Kasir
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class