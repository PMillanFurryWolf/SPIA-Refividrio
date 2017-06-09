Public Class FrmLogin
    Dim obja As New ValidaUsuario
    Dim objConn As New ConexionDB
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If txtUsuario.Text.Trim = "" Or txtContrasena.Text.Trim = "" Then
            MsgBox("No dejar campos vacíos", vbExclamation, "Campos vacíos")
        Else
            obja.ValidarUsuario(txtUsuario.Text, txtContrasena.Text)
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
    Private Sub txtContrasena_KeyPress(ByVal sender As Object,
                ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtUsuario.Text.Trim = "" Or txtContrasena.Text.Trim = "" Then
                MsgBox("No dejar campos vacíos", vbExclamation, "Campos vacíos")
            Else
                obja.ValidarUsuario(txtUsuario.Text, txtContrasena.Text)
            End If
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmAbout.Show()
    End Sub

End Class
