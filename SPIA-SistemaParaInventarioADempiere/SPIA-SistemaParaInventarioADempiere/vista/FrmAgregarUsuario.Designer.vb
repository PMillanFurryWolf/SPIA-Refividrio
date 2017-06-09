<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.TabUsuario = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtgvUsuario = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LbId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtContrasenaUp = New System.Windows.Forms.TextBox()
        Me.TxtUsuarioUp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbNivelUp = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TabUsuario.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(179, 37)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(216, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(179, 83)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(216, 20)
        Me.txtContrasena.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(206, 177)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nivel"
        '
        'cmbNivel
        '
        Me.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Location = New System.Drawing.Point(179, 129)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(216, 21)
        Me.cmbNivel.TabIndex = 6
        '
        'TabUsuario
        '
        Me.TabUsuario.Controls.Add(Me.TabPage1)
        Me.TabUsuario.Controls.Add(Me.TabPage2)
        Me.TabUsuario.Controls.Add(Me.TabPage3)
        Me.TabUsuario.Location = New System.Drawing.Point(12, 12)
        Me.TabUsuario.Name = "TabUsuario"
        Me.TabUsuario.SelectedIndex = 0
        Me.TabUsuario.Size = New System.Drawing.Size(491, 254)
        Me.TabUsuario.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabUsuario.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtUsuario)
        Me.TabPage1.Controls.Add(Me.cmbNivel)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtContrasena)
        Me.TabPage1.Controls.Add(Me.btnAgregar)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(483, 228)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgvUsuario)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(483, 228)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colección"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtgvUsuario
        '
        Me.dtgvUsuario.AllowUserToAddRows = False
        Me.dtgvUsuario.AllowUserToDeleteRows = False
        Me.dtgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvUsuario.Location = New System.Drawing.Point(3, 6)
        Me.dtgvUsuario.Name = "dtgvUsuario"
        Me.dtgvUsuario.ReadOnly = True
        Me.dtgvUsuario.Size = New System.Drawing.Size(474, 216)
        Me.dtgvUsuario.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnEliminar)
        Me.TabPage3.Controls.Add(Me.CmbNivelUp)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.LbId)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.BtnActualizar)
        Me.TabPage3.Controls.Add(Me.TxtContrasenaUp)
        Me.TabPage3.Controls.Add(Me.TxtUsuarioUp)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(483, 228)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Seleccion"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LbId
        '
        Me.LbId.AutoSize = True
        Me.LbId.Location = New System.Drawing.Point(78, 54)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(18, 13)
        Me.LbId.TabIndex = 5
        Me.LbId.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuario"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(173, 169)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(85, 23)
        Me.BtnActualizar.TabIndex = 2
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtContrasenaUp
        '
        Me.TxtContrasenaUp.Location = New System.Drawing.Point(173, 91)
        Me.TxtContrasenaUp.Name = "TxtContrasenaUp"
        Me.TxtContrasenaUp.Size = New System.Drawing.Size(221, 20)
        Me.TxtContrasenaUp.TabIndex = 1
        '
        'TxtUsuarioUp
        '
        Me.TxtUsuarioUp.Location = New System.Drawing.Point(173, 54)
        Me.TxtUsuarioUp.Name = "TxtUsuarioUp"
        Me.TxtUsuarioUp.Size = New System.Drawing.Size(221, 20)
        Me.TxtUsuarioUp.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nivel"
        '
        'CmbNivelUp
        '
        Me.CmbNivelUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNivelUp.FormattingEnabled = True
        Me.CmbNivelUp.Location = New System.Drawing.Point(173, 127)
        Me.CmbNivelUp.Name = "CmbNivelUp"
        Me.CmbNivelUp.Size = New System.Drawing.Size(221, 21)
        Me.CmbNivelUp.TabIndex = 7
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(307, 169)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 23)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 281)
        Me.Controls.Add(Me.TabUsuario)
        Me.Name = "FrmAgregarUsuario"
        Me.Text = "Agregar usuario"
        Me.TabUsuario.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbNivel As ComboBox
    Friend WithEvents TabUsuario As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtgvUsuario As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LbId As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtContrasenaUp As TextBox
    Friend WithEvents TxtUsuarioUp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbNivelUp As ComboBox
    Friend WithEvents BtnEliminar As Button
End Class
