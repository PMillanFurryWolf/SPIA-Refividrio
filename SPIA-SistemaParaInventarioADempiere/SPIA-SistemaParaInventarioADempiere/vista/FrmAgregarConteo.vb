Public Class FrmAgregarConteo
    Public Sub New()
        InitializeComponent()

        Dim arregloColores(9) As String

        arregloColores(0) = "Verde"
        arregloColores(1) = "Naranja"
        arregloColores(2) = "Azul"
        arregloColores(3) = "Rojo"
        arregloColores(4) = "Rosa"
        arregloColores(5) = "Morado"
        arregloColores(6) = "Negro"
        arregloColores(7) = "Café"
        arregloColores(8) = "Magenta"
        arregloColores(9) = "Gris"

        For Each color As String In arregloColores
            cmbColor.Items.Add(color)
        Next
        Dim arregloConteos(7) As Integer
        arregloConteos(0) = 1
        arregloConteos(1) = 2
        arregloConteos(2) = 3
        arregloConteos(3) = 4
        arregloConteos(4) = 5
        arregloConteos(5) = 6
        arregloConteos(6) = 7
        arregloConteos(7) = 8

        For Each conteo As String In arregloConteos
            cmbConteo.Items.Add(conteo)
        Next
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim indiceC1 As Integer = cmbConteo.SelectedIndex + 1
        Dim indiceC2 As Integer = cmbColor.SelectedIndex + 1

        If indiceC1 = 0 Or indiceC2 = 0 Then
            MsgBox("Seleccione un color y un conteo", vbExclamation, "Atención")
        Else
            Dim objGC As New GuardadoDB
            Dim objCons As New ConsultasDataView
            objGC.GuardarConteo(cmbConteo.Text, cmbColor.Text)
            Hide()
            FrmConsultarConteo.dtgvConteo.Refresh()
            objCons.ConsultarConteo()
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub FrmAgregarConteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class