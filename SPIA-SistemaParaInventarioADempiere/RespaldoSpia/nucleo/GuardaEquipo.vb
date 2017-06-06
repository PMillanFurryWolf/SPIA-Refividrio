Imports Npgsql
Public Class GuardaEquipo
    Dim objConexion As New ConexionDB
    Public Sub GuardarEquipo(neq As String, contra As String, nres As String, nayud As String)
        Try
            Dim queryAgregaEquipo As String = "insert into equipo(nombreequipo,nombreresponsable,nombreayudante,contrasena)values('" & neq & "','" & nres & "','" & nayud & "','" & contra & "')"
            Dim comando As New NpgsqlCommand(queryAgregaEquipo, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
            GuardarUsuarioEquipo(neq, contra)
            MsgBox("Insertado")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GuardaEquipo.GuardarEquipo(a,b,c,d)")
            objConexion.CerrarConexion()
        End Try

    End Sub
    Private Sub GuardarUsuarioEquipo(usu As String, contra As String)
        Dim queryInsUsuario As String = "insert into usuario(usuario,contrasena,tipousuario) values('" & usu & "','" & contra & "','equipo')"
        Dim comando As New NpgsqlCommand(queryInsUsuario, objConexion.ConectarSPI())
        comando.ExecuteNonQuery()
    End Sub
End Class
