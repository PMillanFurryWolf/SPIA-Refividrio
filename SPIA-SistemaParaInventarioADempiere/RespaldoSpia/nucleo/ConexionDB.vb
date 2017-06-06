Imports Npgsql
Imports System.Xml
Public Class ConexionDB
    Dim pgConnection As NpgsqlConnection = New NpgsqlConnection
    Public Function ConectarSPI() As NpgsqlConnection
        'Conexión con SPI
        Try
            Dim m_xmlr As XmlTextReader
            m_xmlr = New XmlTextReader("conn\configSPI.xml")
            m_xmlr.WhitespaceHandling = WhitespaceHandling.None
            m_xmlr.Read()
            m_xmlr.Read()
            While Not m_xmlr.EOF
                m_xmlr.Read()
                If Not m_xmlr.IsStartElement() Then
                    Exit While
                End If
                Dim motor = m_xmlr.GetAttribute("motor")
                m_xmlr.Read()
                Dim user = m_xmlr.ReadElementString("usuarioS")
                Dim pw = m_xmlr.ReadElementString("contraS")
                Dim server = m_xmlr.ReadElementString("servidorS")
                Dim db = m_xmlr.ReadElementString("dbS")
                Dim port = m_xmlr.ReadElementString("puertoS")
                Dim searchpath = m_xmlr.ReadElementString("searchpathS")

                m_xmlr.Close()
                Dim ds As DataSet
                ds = New DataSet
                Dim pgConnectionString = New NpgsqlConnectionStringBuilder
                pgConnectionString.SearchPath = searchpath
                pgConnectionString.Port = port
                pgConnectionString.UserName = user
                pgConnectionString.Password = pw
                pgConnectionString.Database = db
                pgConnectionString.Host = server
                pgConnection.ConnectionString = pgConnectionString.ConnectionString
                pgConnection.Open()
                'MsgBox("conexion abierta SPI")
                Return pgConnection
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConexionDB.ConectarSPI()")
        End Try
        Return pgConnection
    End Function
    Public Function ConectarADP() As NpgsqlConnection
        'Conexión con Adempiere
        Try
            Dim m_xmlr As XmlTextReader
            m_xmlr = New XmlTextReader("conn\configADP.xml")
            m_xmlr.WhitespaceHandling = WhitespaceHandling.None
            m_xmlr.Read()
            m_xmlr.Read()
            While Not m_xmlr.EOF
                m_xmlr.Read()
                If Not m_xmlr.IsStartElement() Then
                    Exit While
                End If
                Dim motor = m_xmlr.GetAttribute("motor")
                m_xmlr.Read()
                Dim user = m_xmlr.ReadElementString("usuarioA")
                Dim pw = m_xmlr.ReadElementString("contraA")
                Dim server = m_xmlr.ReadElementString("servidorA")
                Dim db = m_xmlr.ReadElementString("dbA")
                Dim port = m_xmlr.ReadElementString("puertoA")
                Dim searchpath = m_xmlr.ReadElementString("searchpathA")

                m_xmlr.Close()
                Dim ds As DataSet
                ds = New DataSet
                Dim pgConnectionString = New NpgsqlConnectionStringBuilder
                pgConnectionString.SearchPath = searchpath
                pgConnectionString.Port = port
                pgConnectionString.UserName = user
                pgConnectionString.Password = pw
                pgConnectionString.Database = db
                pgConnectionString.Host = server
                pgConnection.ConnectionString = pgConnectionString.ConnectionString
                pgConnection.Open()
                'MsgBox("conexion abierta ADP")
                Return pgConnection
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ConexionDB.ConectarADP()")
        End Try
        Return pgConnection
    End Function
    Public Sub CerrarConexion()
        pgConnection.Close()
        'MsgBox("ConexionCerrada", vbExclamation, "ConexionDB.CerrarConexion()")
    End Sub
End Class
