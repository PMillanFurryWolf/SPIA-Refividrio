Imports Npgsql

Public Class ConsultasDataView
    Public Sub ConsultarEquipo(nombre As String)
        Dim objConexion As New ConexionDB
        Try
            Dim buscarQuery As String = "Select idequipo, nombreequipo, nombreresponsable, nombreayudante,usuario.id_usuario, usuario, contrasena from equipo inner join usuario on equipo.id_usuario=usuario.id_usuario where nombreequipo Like '%" & nombre & "%'"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultarEquipo.dtvDatos.DataSource = dtDatos
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarEquipo()")
        End Try
    End Sub
    Public Sub ConsultarUsuario()
        Dim objConexion As New ConexionDB
        Try
            Dim buscarQuery As String = "Select * from usuario"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmAgregarUsuario.dtgvUsuario.DataSource = dtDatos
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarEquipo()")
        End Try
    End Sub
    Public Sub ConsultarConteo()
        Dim objConexion As New ConexionDB
        Try
            Dim buscarQuery As String = "Select noconteo, color from conteo"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultarConteo.dtgvConteo.DataSource = dtDatos
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarEquipo()")
        End Try
    End Sub
    Public Sub ConsultarProductos()
        Dim objConexion As New ConexionDB
        Try
            Dim buscarQuery As String = "SELECT m_product_id, claveproducto, descripcion, unidad FROM m_producto"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultaProdSincADP.dtgvProds.DataSource = dtDatos
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarProductos()")
        End Try
    End Sub
    Public Sub BuscarProductos(clave As String)
        Dim objConexion As New ConexionDB
        Try
            Dim buscarQuery As String = "SELECT claveproducto, descripcion, unidad FROM m_producto where claveproducto like'%" & clave & "%' or descripcion like '%" & clave & "%' or unidad like '%" & clave & "%'"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultaProdSincADP.dtgvBusqusquedaProd.DataSource = dtDatos
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarProductos()")
        End Try
    End Sub
    Public Sub ConsultarZonas()
        Dim objConexion As New ConexionDB
        Try
            Dim buscarQuery As String = "
        select
        idzona as id,
        zonas.nombrezona as nobrezona, 
        m_locator_ubicacion.codigoalmacen as ubicacion
        from zonas inner join m_locator_ubicacion
        on m_locator_ubicacion.id_m_locator_ubicacion=
        zonas.id_m_locator"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultarZonas.dtgvZonas.DataSource = dtDatos
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarProductos()")
        End Try
    End Sub
End Class
