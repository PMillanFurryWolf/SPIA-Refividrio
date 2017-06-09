Imports Npgsql
Public Class Sincroniza
    Public Sub Sincronizar()
        SincronizarM_warehouse()
    End Sub
    Private Sub SincronizarAd_client()
        Dim objConexionADP As New ConexionDB
        Dim objConexionSPIA As New ConexionDB
        Try
            Dim queryConsulta As String = "select * from ad_client"
            Dim lector As NpgsqlDataReader
            Dim comandoADP As New NpgsqlCommand()
            comandoADP.CommandText = queryConsulta
            comandoADP.Connection = objConexionADP.ConectarADP()
            lector = comandoADP.ExecuteReader()
            Dim queryInsert As String = ""
            Dim comandoSPI As New NpgsqlCommand()
            comandoSPI.Connection = objConexionSPIA.ConectarSPI()
            While lector.Read()
                Try
                    queryInsert = "insert into ad_client_empresa(ad_client_id, nombre, descripcion)values('" & lector("ad_client_id") & "','" & lector("value") & "','" & lector("name") & "')"
                    comandoSPI.CommandText = queryInsert
                    comandoSPI.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Sincroniza.SincronizarAd_client()")
                End Try
            End While
            MsgBox("FinAdOrg")
            SincronizarAdOrg()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Sincroniza.SincronizarAd_client()")
        End Try
    End Sub
    Public Sub SincronizarAdOrg()
        Dim objConexionADP As New ConexionDB
        Dim objConexionSPIA As New ConexionDB
        Try
            Dim queryConsulta As String = "select * from ad_org"
            Dim lector As NpgsqlDataReader
            Dim comandoADP As New NpgsqlCommand()
            comandoADP.CommandText = queryConsulta
            comandoADP.Connection = objConexionADP.ConectarADP()
            lector = comandoADP.ExecuteReader()
            Dim queryInsert As String = ""
            Dim comandoSPI As New NpgsqlCommand()
            comandoSPI.Connection = objConexionSPIA.ConectarSPI()
            While lector.Read()
                Try
                    queryInsert = "insert into ad_org_sucursal(ad_org_id, codigosucursal, nombresucursal)values('" & lector("ad_org_id") & "','" & lector("value") & "','" & lector("name") & "')"
                    comandoSPI.CommandText = queryInsert
                    comandoSPI.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Sincroniza.SincronizarAd_ORG()")
                End Try
            End While
            MsgBox("FinAdOrg")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Sincroniza.SincronizarAd_ORG()")
        End Try
    End Sub
    Public Sub SincronizarProducto()
        Dim objConexionAdp As New ConexionDB
        Dim objConexionSPIA As New ConexionDB
        Dim lector As NpgsqlDataReader
        Try
            Dim queryConsulta As String = "
            SELECT m_product_id as idproducto, c_uom.name as unidad, value as claveproducto, m_product.name as descripcion 
            FROM m_product 
            left join
            c_uom on c_uom.c_uom_id=m_product.c_uom_id
            where m_product.isActive='Y' and m_product.ad_client_id=1000000"
            Dim comando As New NpgsqlCommand()
            comando.CommandText = queryConsulta
            comando.Connection = objConexionAdp.ConectarADP()
            lector = comando.ExecuteReader()
            Dim queryInsert As String = ""
            Dim comandoSPI As New NpgsqlCommand()
            comandoSPI.Connection = objConexionSPIA.ConectarSPI()
            While lector.Read()
                Try
                    Console.WriteLine(lector("claveproducto"))
                    queryInsert = "insert into m_producto(m_product_id, claveproducto, descripcion, unidad) values('" & lector("idproducto") & "','" & lector("claveproducto") & "','" & lector("descripcion") & "','" & lector("unidad") & "')"
                    comandoSPI.CommandText = queryInsert
                    comandoSPI.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Sincroniza.SicronizarProducto()")
                End Try
            End While
            lector.Close()
            MsgBox("FinProds")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Sincroniza.SicronizarProducto()")
        End Try
    End Sub
    Public Sub SincronizarM_warehouse()
        Dim objConexionADP As New ConexionDB
        Dim objConexionSPIA As New ConexionDB
        Try
            Dim queryConsulta As String = "select * from m_warehouse"
            Dim lector As NpgsqlDataReader
            Dim comandoADP As New NpgsqlCommand()
            comandoADP.CommandText = queryConsulta
            comandoADP.Connection = objConexionADP.ConectarADP()
            lector = comandoADP.ExecuteReader()
            Dim queryInsert As String = ""
            Dim comandoSPI As New NpgsqlCommand()
            comandoSPI.Connection = objConexionSPIA.ConectarSPI()
            While lector.Read()
                Try
                    queryInsert = "INSERT INTO spi.m_warehouse_almacen(m_warehouse_id, codigoalmancen, nombrealmacen)
	                VALUES ('" & lector("m_warehouse_id") & "', '" & lector("value") & "', '" & lector("name") & "');"
                    comandoSPI.CommandText = queryInsert
                    comandoSPI.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Sincroniza.SincronizarM_warehouse()")
                End Try
            End While
            MsgBox("FinMwarehouse")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Sincroniza.SincronizarM_warehouse()")
        End Try
    End Sub
End Class
