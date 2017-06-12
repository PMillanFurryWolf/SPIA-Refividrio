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
            MsgBox("Este equipo ya está asignado a un conteo", vbExclamation, ex.Message)
            objConexion.CerrarConexion()
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
            objConexion.CerrarConexion()
        End Try

    End Sub

    Friend Sub EliminarZona(v As String)
        Try
            Dim query = "delete from zonas where zona='" & v & "'"
            Dim comando As New NpgsqlCommand(query, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
            objConexion.CerrarConexion()
        End Try

    End Sub

    Friend Sub EliminarConteo(text As String)
        Try
            Dim query = "delete from conteo where noconteo=" & text
            Dim comando As New NpgsqlCommand(query, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical, "Eliminar.EliminarConteo(arg)")
            objConexion.CerrarConexion()
        End Try
    End Sub

    Friend Sub EliminarInventario(text As String)
        Try
            Dim query = "delete from inventario where nombreinventario='" & text & "'"
            Dim comando As New NpgsqlCommand(query, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message(), vbCritical, "Eliminar.EliminarInventario(arg)")
            objConexion.CerrarConexion()
        End Try
    End Sub
End Class
