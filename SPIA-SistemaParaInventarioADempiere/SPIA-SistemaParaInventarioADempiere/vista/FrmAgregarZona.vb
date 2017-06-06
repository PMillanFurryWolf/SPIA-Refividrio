Imports Npgsql
Public Class FrmAgregarZona
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LlenarCombo()
    End Sub
    Public Sub LlenarCombo()
        Dim objConexion As New ConexionDB
        Try
            Dim comando As New NpgsqlCommand("select * from m_locator_ubicacion", objConexion.ConectarSPI())
            Dim lector As NpgsqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                CmbUbicacion.Items.Add(lector("codigoalmacen"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "FrmAgregarZona.LlenarCombo()")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If TxtNombreZona.Text.Trim = "" Or CmbUbicacion.SelectedIndex + 1 = 0 Then
            MsgBox("Favor de no dejar campos vacíos", vbExclamation, "Atención")
        Else
            Dim objG As New GuardadoDB()
            objG.GuardarZona(TxtNombreZona.Text, ActualizarCombo())
            FrmConsultarZonas.dtgvZonas.Refresh()
            Dim objCon As New ConsultasDataView
            objCon.ConsultarZonas()

        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Public Sub CmbUbicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUbicacion.SelectedIndexChanged
        ActualizarCombo()
    End Sub

    Friend Function ActualizarCombo() As Integer
        Dim objConn As New ConexionDB
        Dim valor As Integer = 0
        Dim queryCombo As String = "select id_m_locator_ubicacion from m_locator_ubicacion where codigoalmacen='" & CmbUbicacion.Text & "'"
        Dim comando As New NpgsqlCommand(queryCombo, objConn.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader()
        If lector.Read() Then
            valor = lector("id_m_locator_ubicacion")
        End If
        Return valor
    End Function
End Class