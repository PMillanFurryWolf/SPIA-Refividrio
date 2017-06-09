Public Class FrmInventario
    Dim objConsultas As New ConsultasDataView
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim fechaInicio As DateTime = FechaInicioInventario.Value
        Dim fechaFin As DateTime = FechaFinInventario.Value
        Dim nombreInventario As String = TxtNombreInventario.Text
        Dim objGuardado As New GuardadoDB
        If nombreInventario.Trim = "" Then
            MsgBox("Favor de completar todos los campos", vbExclamation, "Atención")
        Else
            Dim fechainiciof As String = fechaInicio.Year.ToString & "/" & fechaInicio.Month.ToString & "/" & fechaInicio.Day.ToString & " " & fechaInicio.Hour.ToString & ":" & fechaInicio.Minute.ToString & ":" & fechaInicio.Second.ToString
            Dim fechaFinf As String = fechaFin.Year.ToString & "/" & fechaFin.Month.ToString & "/" & fechaFin.Day.ToString & " " & fechaFin.Hour.ToString & ":" & fechaFin.Minute.ToString & ":" & fechaFin.Second.ToString
            objGuardado.GuardarInventario(nombreInventario, fechainiciof, fechaFinf)
            TabInventario.SelectedIndex = 1
            DtvgInventario.Refresh()
            objConsultas.ConsultarInventarios()
            TxtNombreInventario.Text = ""
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TabInventario.SelectedIndex = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabInventario.SelectedIndex = 0
    End Sub
End Class