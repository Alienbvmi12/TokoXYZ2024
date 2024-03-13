
Imports System.Data.SqlClient

Module Koneksi
    Dim ConStr = "Data Source=DESKTOP-QUDHRFQ;Initial Catalog=lks_toko;Integrated Security=True"
    Dim Koneksi = New SqlConnection(ConStr)
    Dim Command As SqlCommand
    Dim Reader As SqlDataReader
    Public User As New UserData

    Public Function Read(query As String)
        Try
            Koneksi.Open()
            Command = New SqlCommand(query, Koneksi)
            Reader = Command.ExecuteReader()
            Dim datable As New DataTable
            datable.Load(Reader)
            Reader.Close()
            Koneksi.Close()
            Return datable
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
            Koneksi.Close()
            Return False
        End Try
    End Function

    Public Sub SendOnly(query As String, Optional showDialog As Boolean = True, Optional confirm As Boolean = True, Optional Msg As String = "Operation Success!!")
        If confirm Then
            Dim res = MessageBox.Show("Apakah Anda Yakin?", "Confirm", MessageBoxButtons.YesNo)
            If res = DialogResult.Yes Then
                Try
                    Koneksi.Open()
                    Command = New SqlCommand(query, Koneksi)
                    Command.ExecuteNonQuery()
                    If showDialog Then
                        MsgBox(Msg)
                    End If
                    Koneksi.Close()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                    Koneksi.Close()
                End Try
            End If
        Else
            Try
                Koneksi.Open()
                Command = New SqlCommand(query, Koneksi)
                Command.ExecuteNonQuery()
                If showDialog Then
                    MsgBox(Msg)
                End If
                Koneksi.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Koneksi.Close()
            End Try
        End If
    End Sub

    Public Sub Log(msg As String)
        SendOnly("insert into tbl_log (waktu, aktivitas, id_user) values ('" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & msg & "', '" & User.id & "')", False, False)
    End Sub
End Module
