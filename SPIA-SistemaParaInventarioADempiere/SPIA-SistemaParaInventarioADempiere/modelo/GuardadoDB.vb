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
            MsgBox(ex.Message, vbCritical, "GuardaConteo.GuardarConteo(a,b)")
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
    Public Sub GuardarZona(nombreZona As String, id_m_locator As Integer)
        Try
            Dim queryInsZona As String = "insert into zonas(nombrezona, id_m_locator)values('" & nombreZona & "'," & id_m_locator & ")"
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