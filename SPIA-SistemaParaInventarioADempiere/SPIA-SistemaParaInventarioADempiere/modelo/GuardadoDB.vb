Imports Npgsql
Public Class GuardadoDB
    Dim objConexion As New ConexionDB
    Public Sub GuardarConteo(conteo As Integer, color As String)
        Try
            Dim query As String = "insert into conteo(noconteo, color) values(" & conteo & ", '" & color & "')"
            Dim comando As New NpgsqlCommand(query, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox("Este conteo ya se ha creado, seleccione un conteo diferente", vbExclamation, "Atención")
            'MsgBox(ex.Message, vbCritical, "GuardaConteo.GuardarConteo(a,b)")
            objConexion.CerrarConexion()
        End Try
    End Sub

    Public Sub GuardarEquipo(neq As String, contra As String, nres As String, nayud As String, idEquipo As Integer)
        Try
            Dim queryAgregaEquipo As String = "insert into equipo(nombreequipo,nombreresponsable,nombreayudante, id_usuario)values('" & neq & "','" & nres & "','" & nayud & "' , " & idEquipo & ")"
            Dim comando As New NpgsqlCommand(queryAgregaEquipo, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
            FrmAgregarEquipo.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GuardaEquipo.GuardarEquipo(a,b,c,d)")
            objConexion.CerrarConexion()
        End Try
    End Sub
    Public Sub GuardarUsuario(usu As String, contra As String, nivel As String)
        Try
            Dim queryInsUsuario As String = "insert into usuario(usuario,contrasena,nivel) values('" & usu & "','" & contra & "','" & nivel & "')"
            Dim comando As New NpgsqlCommand(queryInsUsuario, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
            FrmAgregarUsuario.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GuardaEquipo.GuardarUsuario(a,b,c)")
            objConexion.CerrarConexion()
        End Try
    End Sub
    Public Sub GuardarZona(nombreZona As String, clave As String)
        Try
            Dim queryInsZona As String = "insert into zonas(id_m_warehouse_almacen, zona) values((select id_m_warehouse_almacen from m_warehouse_almacen where nombrealmacen='" & clave & "' or codigoalmancen='" & clave & "'), '" & nombreZona & "')"
            Dim comando As New NpgsqlCommand(queryInsZona, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
            FrmAgregarZona.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GuardadoDB.GuardarZona(arg, arg)")
            objConexion.CerrarConexion()
        End Try
    End Sub

    Public Sub GuardarAsigConteo(v1 As Integer, v2 As Integer, v3 As Integer, v4 As Integer, v5 As String)
        Try
            Dim queryInsert = "insert into asignacionconteo (fechaasignacion,idequipo,idzona,idconteo,idinventario) values('" & v5 & "'," & v1 & "," & v2 & ", " & v3 & "," & v4 & ")"
            Dim comando As New NpgsqlCommand(queryInsert, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GuardadoDB.GuardarAsigConteo(arg, arg,arg,arg,arg)")
            objConexion.CerrarConexion()
        End Try
    End Sub

    Public Sub GuardarInventario(nombreZona As String, fechaini As String, fechaFin As String)
        Try
            Dim queryInsZona As String = "insert into inventario (nombreinventario, fechainicioinventario, fechafininventario) values('" & nombreZona & "','" & fechaini & "','" & fechaFin & "')"
            Dim comando As New NpgsqlCommand(queryInsZona, objConexion.ConectarSPI())
            comando.ExecuteNonQuery()
            objConexion.CerrarConexion()
            FrmAgregarZona.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GuardadoDB.GuardarZona(arg, arg)")
            objConexion.CerrarConexion()
        End Try
    End Sub
End Class