Public Class FrmAgregarConteo
    Public Sub New()
        InitializeComponent()
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
        TxtColor.Enabled = False
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim indiceC1 As Integer = cmbConteo.SelectedIndex + 1

        If indiceC1 = 0 Or TxtColor.Text.Trim = "" Then
            MsgBox("Seleccione un color y un conteo", vbExclamation, "Atención")
        Else
            Dim objGC As New GuardadoDB
            Dim objCons As New ConsultasDataView
            objGC.GuardarConteo(cmbConteo.Text, TxtColor.Text)
            Dispose()
            FrmConsultarConteo.dtgvConteo.Refresh()
            objCons.ConsultarConteo()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub BtnElegir_Click(sender As Object, e As EventArgs) Handles BtnElegir.Click
        ColorDialog1.ShowDialog()
        PicBxColor.BackColor = ColorDialog1.Color
        TxtColor.Text = ColorDialog1.Color.Name
    End Sub
End Class