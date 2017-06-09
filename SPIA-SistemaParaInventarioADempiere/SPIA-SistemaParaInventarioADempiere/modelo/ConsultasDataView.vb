Imports Npgsql

Public Class ConsultasDataView
    Dim objConexion As New ConexionDB
    Public Sub ConsultarEquipo(nombre As String)
        Try
            Dim buscarQuery As String = "Select idequipo, nombreequipo, nombreresponsable, nombreayudante,usuario.id_usuario, usuario, contrasena from equipo inner join usuario on equipo.id_usuario=usuario.id_usuario where nombreequipo Like '%" & nombre & "%'"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultarEquipo.dtvDatos.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarEquipo()")
        End Try
    End Sub
    Public Sub ConsultarUsuario()
        Try
            Dim buscarQuery As String = "Select * from usuario"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmAgregarUsuario.dtgvUsuario.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarUsuario()")
        End Try
    End Sub
    Public Sub ConsultarConteo()
        Try
            Dim buscarQuery As String = "Select noconteo, color from conteo"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultarConteo.dtgvConteo.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarConteo()")
        End Try
    End Sub
    Public Sub ConsultarProductos()
        Try
            Dim buscarQuery As String = "SELECT m_product_id, claveproducto, descripcion, unidad FROM m_producto"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultaProdSincADP.dtgvProds.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarProductos()")
        End Try
    End Sub
    Public Sub BuscarProductos(clave As String)
        Try
            Dim buscarQuery As String = "SELECT claveproducto, descripcion, unidad FROM m_producto where claveproducto like'%" & clave & "%' or descripcion like '%" & clave & "%' or unidad like '%" & clave & "%'"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultaProdSincADP.dtgvBusqusquedaProd.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.BuscarProductos(arg)")
        End Try
    End Sub
    Public Sub ConsultarZonas()

        Try
            Dim buscarQuery As String = "
            select zona, m_warehouse_almacen.codigoalmancen, m_warehouse_almacen.nombrealmacen from zonas inner join m_warehouse_almacen on zonas.id_m_warehouse_almacen=m_warehouse_almacen.id_m_warehouse_almacen"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmConsultarZonas.dtgvZonas.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarZonas()")
        End Try
    End Sub
    Public Sub BuscarAlmacen(clave As String)

        Try
            Dim buscarQuery As String = "select nombrealmacen, codigoalmancen from m_warehouse_almacen where nombrealmacen like'%" & clave & "%' or codigoalmancen like '%" & clave & "%'"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmAgregarZona.DtgvAlmacen.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.BuscarAlmacen(arg)")
        End Try
    End Sub
    Public Sub ConsultarAlmacen()

        Try
            Dim buscarQuery As String = "select nombrealmacen, codigoalmancen from m_warehouse_almacen"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmAgregarZona.DtgvAlmacen.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.ConsultarAlmacen()")
        End Try
    End Sub
    Public Sub ConsultarInventarios()
        Try
            Dim buscarQuery As String = "select nombreinventario as Nombre, fechainicioinventario as Inicio, fechafininventario as Final from inventario"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmInventario.DtvgInventario.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.Inventarios()")
        End Try
    End Sub
    Public Sub ConsultarAsignacion()
        Try
            Dim buscarQuery As String = "
select 
e.nombreequipo,
z.zona, 
con.noconteo, 
inv.nombreinventario
from
 asignacionconteo ass 
 inner join equipo e on e.idequipo=ass.idequipo
 inner join zonas z on z.id_zona=ass.idzona
 inner join conteo con on con.idconteo=ass.idconteo
 inner join inventario inv on inv.idinventario=ass.idinventario                
"
            Dim dtDatos As New DataTable
            Dim mdaDatos As New NpgsqlDataAdapter(buscarQuery, objConexion.ConectarSPI())
            mdaDatos.Fill(dtDatos)
            FrmAsignacionConteo.DtgvAsigConteo.DataSource = dtDatos
            objConexion.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConsultasDataView.Inventarios()")
        End Try
    End Sub
End Class
