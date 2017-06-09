Imports Npgsql
Public Class Eliminar
    Dim objConexion As New ConexionDB
    Friend Sub EliminarEquipo(idequipo As String)
        Try
            Dim queryElim As String = "delete from equipo where idequipo=" & idequipo
            Dim comando As New NpgsqlCommand(queryElim, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Eliminar.EliminarEquipo(arg)")
        End Try
    End Sub

    Friend Sub EliminarUsuario(idusuario As String)
        Try
            Dim queryElim As String = "delete from usuario where id_usuario=" & idusuario
            Dim comando As New NpgsqlCommand(queryElim, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox("No se puede eliminar este usuario porque ya tiene asignado un equipo", vbExclamation, ex.Message())
        End Try

    End Sub
End Class
