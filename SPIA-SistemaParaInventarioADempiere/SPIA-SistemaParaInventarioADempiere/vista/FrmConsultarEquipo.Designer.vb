<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultarEquipo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtvDatos = New System.Windows.Forms.DataGridView()
        Me.TabEquipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAgregarEquipo = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LblId = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtNombreAyud = New System.Windows.Forms.TextBox()
        Me.TxtNombreRes = New System.Windows.Forms.TextBox()
        Me.TxtEquipo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblIdUsuario = New System.Windows.Forms.Label()
        CType(Me.dtvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEquipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtvDatos
        '
        Me.dtvDatos.AllowUserToAddRows = False
        Me.dtvDatos.AllowUserToDeleteRows = False
        Me.dtvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtvDatos.Location = New System.Drawing.Point(12, 9)
        Me.dtvDatos.Name = "dtvDatos"
        Me.dtvDatos.ReadOnly = True
        Me.dtvDatos.Size = New System.Drawing.Size(490, 196)
        Me.dtvDatos.TabIndex = 0
        '
        'TabEquipos
        '
        Me.TabEquipos.Controls.Add(Me.TabPage1)
        Me.TabEquipos.Controls.Add(Me.TabPage2)
        Me.TabEquipos.Location = New System.Drawing.Point(12, 12)
        Me.TabEquipos.Name = "TabEquipos"
        Me.TabEquipos.SelectedIndex = 0
        Me.TabEquipos.Size = New System.Drawing.Size(524, 326)
        Me.TabEquipos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabEquipos.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAgregarEquipo)
        Me.TabPage1.Controls.Add(Me.dtvDatos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(516, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Equipos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAgregarEquipo
        '
        Me.btnAgregarEquipo.Location = New System.Drawing.Point(221, 246)
        Me.btnAgregarEquipo.Name = "btnAgregarEquipo"
        Me.btnAgregarEquipo.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarEquipo.TabIndex = 3
        Me.btnAgregarEquipo.Text = "Agregar Equipo"
        Me.btnAgregarEquipo.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LblIdUsuario)
        Me.TabPage2.Controls.Add(Me.LblId)
        Me.TabPage2.Controls.Add(Me.BtnEliminar)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtContrasena)
        Me.TabPage2.Controls.Add(Me.TxtUsuario)
        Me.TabPage2.Controls.Add(Me.TxtNombreAyud)
        Me.TabPage2.Controls.Add(Me.TxtNombreRes)
        Me.TabPage2.Controls.Add(Me.TxtEquipo)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(516, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Selección"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(80, 38)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(18, 13)
        Me.LblId.TabIndex = 12
        Me.LblId.Text = "ID"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(395, 256)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(199, 256)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Location = New System.Drawing.Point(199, 205)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(271, 20)
        Me.TxtContrasena.TabIndex = 9
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(199, 165)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(271, 20)
        Me.TxtUsuario.TabIndex = 8
        '
        'TxtNombreAyud
        '
        Me.TxtNombreAyud.Location = New System.Drawing.Point(199, 122)
        Me.TxtNombreAyud.Name = "TxtNombreAyud"
        Me.TxtNombreAyud.Size = New System.Drawing.Size(271, 20)
        Me.TxtNombreAyud.TabIndex = 7
        '
        'TxtNombreRes
        '
        Me.TxtNombreRes.Location = New System.Drawing.Point(199, 80)
        Me.TxtNombreRes.Name = "TxtNombreRes"
        Me.TxtNombreRes.Size = New System.Drawing.Size(271, 20)
        Me.TxtNombreRes.TabIndex = 6
        '
        'TxtEquipo
        '
        Me.TxtEquipo.Location = New System.Drawing.Point(199, 38)
        Me.TxtEquipo.Name = "TxtEquipo"
        Me.TxtEquipo.Size = New System.Drawing.Size(271, 20)
        Me.TxtEquipo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Ayudante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Responsable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipo"
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.AutoSize = True
        Me.LblIdUsuario.Location = New System.Drawing.Point(80, 172)
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(18, 13)
        Me.LblIdUsuario.TabIndex = 13
        Me.LblIdUsuario.Text = "ID"
        '
        'FrmConsultarEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(551, 367)
        Me.Controls.Add(Me.TabEquipos)
        Me.MaximizeBox = False
        Me.Name = "FrmConsultarEquipo"
        Me.Text = "FrmConsultarEquipo"
        CType(Me.dtvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEquipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtvDatos As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabEquipos As TabControl
    Friend WithEvents btnAgregarEquipo As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtNombreAyud As TextBox
    Friend WithEvents TxtNombreRes As TextBox
    Friend WithEvents TxtEquipo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblId As Label
    Friend WithEvents LblIdUsuario As Label
End Class
