Imports Npgsql
Public Class ValidarEquiposZonas
    Dim objg As New GuardadoDB
    Dim objConn As New ConexionDB
    Dim estado As Boolean = False
    Public Function ExisteEquipoEnZona(idequipo As Integer, idzona As Integer, idconteo As Integer) As Boolean
        Dim query = "select * from asignacionconteo where idequipo=" & idequipo & " and idzona=" & idzona & " and idconteo=" & idconteo
        Dim Comando As New NpgsqlCommand(query, objConn.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = Comando.ExecuteReader()
        If lector.Read Then
            estado = True
            objConn.CerrarConexion()
        Else
            estado = False
            objConn.CerrarConexion()
        End If
        Return estado
    End Function
End Class
