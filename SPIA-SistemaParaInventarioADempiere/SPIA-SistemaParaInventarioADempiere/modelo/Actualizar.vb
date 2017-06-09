Imports Npgsql
Public Class Actualizar
    Dim objConn As New ConexionDB
    Friend Sub ActualizarEquipo(ideq As String, neq As String, nres As String, nayud As String)
        Try
            Dim queryUpdate As String = "update equipo set nombreequipo='" & neq & "', nombreresponsable='" & nres & "', nombreayudante='" & nayud & "' where idequipo=" & ideq
            Dim comando As New NpgsqlCommand(queryUpdate, objConn.ConectarSPI())
            comando.ExecuteNonQuery()
            objConn.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Actualizar.ActualizarEquipo(arg, arg, arg, arg)")
        End Try
    End Sub

    Friend Sub ActualizarUsuario(id As String, usuario As String, contrasena As String)
        Try
            Dim queryUpdate As String = "update usuario set usuario='" & usuario & "', contrasena='" & contrasena & "' where id_usuario=" & id
            Dim comando As New NpgsqlCommand(queryUpdate, objConn.ConectarSPI())
            comando.ExecuteNonQuery()
            objConn.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Actualizar.ActualizarUsuario(arg, arg, arg, arg)")
        End Try
    End Sub
    Friend Sub ActualizarUsuarioLVL(id As String, usuario As String, contrasena As String, nivel As String)
        Try
            Dim queryUpdate As String = "update usuario set usuario='" & usuario & "', contrasena='" & contrasena & "', nivel='" & nivel & "' where id_usuario=" & id
            Console.WriteLine(queryUpdate)
            Dim comando As New NpgsqlCommand(queryUpdate, objConn.ConectarSPI())
            comando.ExecuteNonQuery()
            objConn.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Actualizar.ActualizarUsuarioLVL(arg, arg, arg, arg)")
        End Try
    End Sub
End Class
