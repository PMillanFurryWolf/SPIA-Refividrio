Imports Npgsql
Public Class ValidaUsuario
    Dim reader As NpgsqlDataReader
    Dim objConexion As New ConexionDB
    Public Sub ValidarUsuario(usuario As String, contrasena As String)
        Try
            Dim cmd As New NpgsqlCommand("select * From usuario left Join equipo On equipo.id_usuario=usuario.id_usuario where usuario=@user AND contrasena=@pass", objConexion.ConectarSPI)
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 32).Value = usuario
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = contrasena
            reader = cmd.ExecuteReader()
            If reader.Read Then
                If reader("nivel") = "administrador" Then
                    FrmLogin.Hide()
                    FrmPrincipal.txttoolNivel.Text = reader("nivel")
                    FrmPrincipal.txtoolUsuario.Text = reader("usuario")
                    FrmPrincipal.Show()
                    objConexion.CerrarConexion()
                    reader.Close()
                ElseIf reader("nivel") = "equipo" Then
                    MsgBox("Módulo de equipos en desarrollo")
                    FrmLogin.Hide()
                    FrmEquipo.Show()
                    objConexion.CerrarConexion()
                    reader.Close()
                End If
                FrmPrincipal.txttoolEquipo.Text = Environment.MachineName
                FrmPrincipal.txtToolTime.Text = DateTime.Now()
            Else
                MsgBox("El usuario no está registrado en el sistema", vbCritical, "Usuario no existe")
                FrmLogin.txtUsuario.Text = ""
                FrmLogin.txtContrasena.Text = ""
                objConexion.CerrarConexion()
                reader.Close()
            End If
        Catch ex As Exception
            reader.Close()
            MsgBox(ex.Message, vbCritical, "ValidaUsuario.ValidarUsuario1(a,a)")
        End Try
    End Sub
End Class
