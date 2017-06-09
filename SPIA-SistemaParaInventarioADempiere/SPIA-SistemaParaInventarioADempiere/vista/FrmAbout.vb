Public Class FrmAbout
    Private contador As Integer = 1
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        TextBox1.Enabled = False
        TextBox1.Text = "Sistema para Inventaios en ERP ADempiere" & vbCrLf & "Ing.Pedro Ramos Millán " & vbCrLf & "Versión 1.0"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        contador = contador + 1
        If contador = 7 Then
            contador = 1
            MsgBox("Moving on and getting over: 🐺AnisosLupus.🐺", vbInformation, "🐺Hidden message from a furry wolf.🐺")
        End If
    End Sub
End Class