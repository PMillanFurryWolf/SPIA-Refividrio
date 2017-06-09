Public Class FrmEquipo
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Hide()
        FrmLogin.txtUsuario.Text = ""
        FrmLogin.txtContrasena.Text = ""
        FrmLogin.Show()
    End Sub
    Private Sub FrmEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub
End Class