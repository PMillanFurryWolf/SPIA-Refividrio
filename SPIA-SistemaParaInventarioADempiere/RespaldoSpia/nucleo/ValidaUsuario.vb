Imports Npgsql

Public Class ValidaUsuario
    Dim pgCommand As NpgsqlCommand = New NpgsqlCommand
    Dim reader As NpgsqlDataReader
    Dim objConexion As New ConexionDB

    Public Sub ValidarUsuario(usuario As String, contrasena As String)
        Try
            pgCommand = New NpgsqlCommand("select * from usuario where usuario='" & usuario & "' and contrasena='" & contrasena & "'", objConexion.ConectarSPI)
            reader = pgCommand.ExecuteReader()
            If reader.Read Then
                FrmLogin.Hide()
                If reader("tipoUsuario") = "administrador" Then
                    FrmPrincipal.txttoolNivel.Text = reader("tipoUsuario")
                    FrmPrincipal.txtoolUsuario.Text = reader("usuario")
                    FrmPrincipal.Show()
                ElseIf reader("tipoUsuario") = "equipo" Then
                    FrmPrincipal.txttoolNivel.Text = reader("tipoUsuario")
                    FrmPrincipal.txtoolUsuario.Text = reader("tipoUsuario")
                    FrmPrincipal.Show()
                End If
                FrmPrincipal.txttoolEquipo.Text = Environment.MachineName
                FrmPrincipal.txtToolTime.Text = DateTime.Now()
            Else
                MsgBox("El usuario no está registrado en el sistema", vbCritical, "Usuario no existe")
                FrmLogin.txtUsuario.Text = ""
                FrmLogin.txtContrasena.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ValidaUsuario.ValidarUsuario(a,a)")
        End Try
    End Sub
End Class
