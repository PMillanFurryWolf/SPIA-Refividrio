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
            objConn.CerrarConexion()
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
            objConn.CerrarConexion()
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
            objConn.CerrarConexion()
        End Try
    End Sub

    Friend Sub ActualizarConteo(conteo As String, color As String, viejoConteo As String)
        Try
            Dim query = "update conteo set noconteo=" & conteo & ", color='" & color & "' where noconteo=" & viejoConteo
            Dim comando As New NpgsqlCommand(query, objConn.ConectarSPI())
            comando.ExecuteNonQuery()
            objConn.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Actualizar.ActualizarConteo(arg, arg, arg)")
            objConn.CerrarConexion()
        End Try
    End Sub

    Friend Sub ActualizarInventario(nombreinventario As String, inicio As Date, fin As Date, viejoinventario As String)
        Dim fechaInicioF As String = inicio.Year & "/" & inicio.Month & "/" & inicio.Day & " " & inicio.Hour & ":" & inicio.Minute & ":" & inicio.Second
        Dim fechaFinF As String = fin.Year & "/" & fin.Month & "/" & fin.Day & " " & fin.Hour & ":" & fin.Minute & ":" & fin.Second
        Try
            Dim query = "update inventario set nombreinventario='" & nombreinventario & "', 
           fechainicioinventario='" & fechaInicioF & "', fechafininventario='" & fechaFinF & "' where nombreinventario='" & viejoinventario & "'"
            Dim comando As New NpgsqlCommand(query, objConn.ConectarSPI())
            comando.ExecuteNonQuery()
            objConn.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Actualizar.ActualizarInventario(arg, arg, arg,arg)")
        objConn.CerrarConexion()
        End Try
    End Sub

    Friend Sub ActualizaZona(nombreZona As String, ubicacion As String, viejaZona As String)
        Try
            Dim query As String =
"update zonas set 
  zona='" & nombreZona & "',
  id_m_warehouse_almacen=(select id_m_warehouse_almacen from m_warehouse_almacen where nombrealmacen='" & ubicacion & "')
  where id_zona=(select id_zona from zonas where zona='" & viejaZona & "')"
            Console.WriteLine(query)
            Dim comando As New NpgsqlCommand(query, objConn.ConectarSPI())
            comando.ExecuteNonQuery()
            objConn.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Actualizar.ActualizarZona(arg, arg, arg)")
            objConn.CerrarConexion()
        End Try
    End Sub
End Class
