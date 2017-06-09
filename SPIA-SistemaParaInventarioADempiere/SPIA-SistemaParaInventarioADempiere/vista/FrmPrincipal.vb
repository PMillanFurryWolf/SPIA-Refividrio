Public Class FrmPrincipal

    Dim obj As New ConsultasDataView
    Private Sub AgregarUnEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUnEquipoToolStripMenuItem.Click
        Dim obj As New FrmAgregarEquipo
        obj.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim obj As New ConexionDB
        obj.CerrarConexion()
        Dispose()
        FrmLogin.txtUsuario.Text = ""
        FrmLogin.txtContrasena.Text = ""
        FrmLogin.Show()
    End Sub

    Private Sub AgregarConteosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarConteosToolStripMenuItem.Click
        FrmAgregarConteo.Show()
    End Sub

    Private Sub ConteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConteoToolStripMenuItem.Click

    End Sub

    Private Sub SincronziarConADempiereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SincronziarConADempiereToolStripMenuItem.Click
        Dim obj As New Sincroniza
        obj.Sincronizar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picEquipo.Click
        obj.ConsultarEquipo("")
        FrmConsultarEquipo.Show()

    End Sub

    Private Sub picConteo_Click(sender As Object, e As EventArgs) Handles picConteo.Click
        obj.ConsultarConteo()
        FrmConsultarConteo.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles picAsignarConteo.Click
        obj.ConsultarAsignacion()
        FrmAsignacionConteo.Show()
        FrmAsignacionConteo.TabAsignacion.SelectedIndex = 1
    End Sub

    Private Sub picZonas_Click(sender As Object, e As EventArgs) Handles picZonas.Click
        obj.ConsultarZonas()
        FrmConsultarZonas.Show()
    End Sub

    Private Sub picInventario_Click(sender As Object, e As EventArgs) Handles picInventario.Click
        FrmInventario.TabInventario.SelectedIndex = 1
        obj.ConsultarInventarios()
        FrmInventario.Show()
    End Sub

    Private Sub picProductosAlmacenados_Click(sender As Object, e As EventArgs) Handles picProductosAlmacenados.Click
        MsgBox("productosalmacenados")
    End Sub

    Private Sub picProdAdempiere_Click(sender As Object, e As EventArgs) Handles picProdAdempiere.Click
        FrmConsultaProdSincADP.Show()
        obj.ConsultarProductos()
    End Sub

    Private Sub AgregarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuariosToolStripMenuItem.Click
        obj.ConsultarUsuario()
        FrmAgregarUsuario.Show()
    End Sub

    Private Sub AgregarUnaZonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUnaZonaToolStripMenuItem.Click
        FrmAgregarZona.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub
End Class