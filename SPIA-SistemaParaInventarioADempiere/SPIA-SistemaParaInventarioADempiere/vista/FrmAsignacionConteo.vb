Imports Npgsql
Public Class FrmAsignacionConteo
    Dim objConex As New ConexionDB
    Dim objConsulta As New ConsultasDataView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        LlenarCombos()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub LlenarCombos()
        ConsultarEquipos()
        ConsultarZona()
        ConsultarConteo()
        ConsultarInventario()
    End Sub

    Private Sub ConsultarInventario()
        Dim query = "select nombreinventario from inventario"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader()
        While lector.Read
            CmbInventario.Items.Add(lector("nombreinventario"))
        End While
        objConex.CerrarConexion()
    End Sub
    Private Sub ConsultarConteo()
        Dim query = "select noconteo from conteo"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader()
        While lector.Read
            CmbConteo.Items.Add(lector("noconteo"))
        End While
        objConex.CerrarConexion()
    End Sub

    Private Sub ConsultarZona()
        Dim query = "select zona from zonas"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader()
        While lector.Read
            CmbZona.Items.Add(lector("zona"))
        End While
        objConex.CerrarConexion()
    End Sub

    Private Sub ConsultarEquipos()
        Dim query = "select nombreequipo from equipo"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader()
        While lector.Read
            CmbEquipo.Items.Add(lector("nombreequipo"))
        End While
        objConex.CerrarConexion()
    End Sub

    Private Sub CmbEquipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEquipo.SelectedIndexChanged
        RetornoEquipo()
    End Sub

    Private Function RetornoEquipo() As Integer
        Dim IdEquipo = 0
        Dim query As String = "select idequipo from equipo where nombreequipo='" & CmbEquipo.Text & "'"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader
        If lector.Read Then
            IdEquipo = lector("idequipo")
            objConex.CerrarConexion()
            Return IdEquipo
        End If
        Return IdEquipo
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If CmbConteo.SelectedIndex + 1 = 0 Or CmbEquipo.SelectedIndex + 1 = 0 Or CmbZona.SelectedIndex + 1 = 0 Or CmbInventario.SelectedIndex + 1 = 0 Then
            MsgBox("Favor de elegir la información de las listas", vbExclamation, "Atención")
        Else

            Dim objg As New GuardadoDB
            Dim fechaAsig As DateTime = DtInicio.Value
            Dim ff As String = fechaAsig.Year.ToString & "/" & fechaAsig.Month.ToString & "/" & fechaAsig.Day.ToString & " " & fechaAsig.Hour.ToString & ":" & fechaAsig.Minute.ToString & ":" & fechaAsig.Second.ToString
            objg.GuardarAsigConteo(RetornoEquipo(), RetornoZona(), RetornoConteo, RetornoInventario(), ff)

            DtgvAsigConteo.Refresh()
            objConsulta.ConsultarAsignacion()
            TabAsignacion.SelectedIndex = 1
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TabAsignacion.SelectedIndex = 1
    End Sub

    Private Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click
        TabAsignacion.SelectedIndex = 0
    End Sub

    Private Sub CmbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbZona.SelectedIndexChanged
        RetornoZona()
    End Sub
    Private Function RetornoZona() As Integer
        Dim idZona = 0
        Dim query As String = "select id_zona from zonas where zona='" & CmbZona.Text & "'"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader
        If lector.Read Then
            idZona = lector("id_zona")
            objConex.CerrarConexion()
            Return idZona
        End If
        Return idZona
    End Function

    Private Sub CmbConteo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbConteo.SelectedIndexChanged
        RetornoConteo()
    End Sub

    Private Function RetornoConteo() As Integer
        Dim idConteo = 0
        Dim query As String = "select idconteo from conteo where noconteo='" & CmbConteo.Text & "'"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader
        If lector.Read Then
            idConteo = lector("idconteo")
            objConex.CerrarConexion()
            Return idConteo
        End If
        Return idConteo
    End Function

    Private Sub CmbInventario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbInventario.SelectedIndexChanged
        RetornoInventario()
    End Sub

    Private Function RetornoInventario() As Integer
        Dim idInventario = 0
        Dim query As String = "select idinventario from inventario where nombreinventario='" & CmbInventario.Text & "'"
        Dim comando As New NpgsqlCommand(query, objConex.ConectarSPI())
        Dim lector As NpgsqlDataReader
        lector = comando.ExecuteReader
        If lector.Read Then
            idInventario = lector("idinventario")
            objConex.CerrarConexion()
            Return idInventario
        End If
        Return idInventario
    End Function
End Class