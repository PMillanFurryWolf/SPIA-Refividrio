<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignacionConteo
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
        Me.TabAsignacion = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbInventario = New System.Windows.Forms.ComboBox()
        Me.CmbConteo = New System.Windows.Forms.ComboBox()
        Me.DtInicio = New System.Windows.Forms.DateTimePicker()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbZona = New System.Windows.Forms.ComboBox()
        Me.CmbEquipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.DtgvAsigConteo = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabAsignacion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DtgvAsigConteo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAsignacion
        '
        Me.TabAsignacion.Controls.Add(Me.TabPage1)
        Me.TabAsignacion.Controls.Add(Me.TabPage2)
        Me.TabAsignacion.Controls.Add(Me.TabPage3)
        Me.TabAsignacion.Location = New System.Drawing.Point(12, 12)
        Me.TabAsignacion.Name = "TabAsignacion"
        Me.TabAsignacion.SelectedIndex = 0
        Me.TabAsignacion.Size = New System.Drawing.Size(794, 393)
        Me.TabAsignacion.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabAsignacion.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CmbInventario)
        Me.TabPage1.Controls.Add(Me.CmbConteo)
        Me.TabPage1.Controls.Add(Me.DtInicio)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.BtnAceptar)
        Me.TabPage1.Controls.Add(Me.CmbZona)
        Me.TabPage1.Controls.Add(Me.CmbEquipo)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(786, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fecha de asignación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Inventario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Conteo"
        '
        'CmbInventario
        '
        Me.CmbInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInventario.FormattingEnabled = True
        Me.CmbInventario.Location = New System.Drawing.Point(467, 84)
        Me.CmbInventario.Name = "CmbInventario"
        Me.CmbInventario.Size = New System.Drawing.Size(200, 21)
        Me.CmbInventario.TabIndex = 12
        '
        'CmbConteo
        '
        Me.CmbConteo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConteo.FormattingEnabled = True
        Me.CmbConteo.Location = New System.Drawing.Point(467, 37)
        Me.CmbConteo.Name = "CmbConteo"
        Me.CmbConteo.Size = New System.Drawing.Size(200, 21)
        Me.CmbConteo.TabIndex = 11
        '
        'DtInicio
        '
        Me.DtInicio.Location = New System.Drawing.Point(347, 140)
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.Size = New System.Drawing.Size(200, 20)
        Me.DtInicio.TabIndex = 10
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(418, 262)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(309, 262)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbZona
        '
        Me.CmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbZona.FormattingEnabled = True
        Me.CmbZona.Location = New System.Drawing.Point(184, 84)
        Me.CmbZona.Name = "CmbZona"
        Me.CmbZona.Size = New System.Drawing.Size(200, 21)
        Me.CmbZona.TabIndex = 5
        '
        'CmbEquipo
        '
        Me.CmbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEquipo.FormattingEnabled = True
        Me.CmbEquipo.Location = New System.Drawing.Point(184, 37)
        Me.CmbEquipo.Name = "CmbEquipo"
        Me.CmbEquipo.Size = New System.Drawing.Size(200, 21)
        Me.CmbEquipo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Zona"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipo"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnAsignar)
        Me.TabPage2.Controls.Add(Me.DtgvAsigConteo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(786, 367)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colección"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Location = New System.Drawing.Point(353, 312)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAsignar.TabIndex = 9
        Me.BtnAsignar.Text = "Asignar"
        Me.BtnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnAsignar.UseVisualStyleBackColor = True
        '
        'DtgvAsigConteo
        '
        Me.DtgvAsigConteo.AllowUserToAddRows = False
        Me.DtgvAsigConteo.AllowUserToDeleteRows = False
        Me.DtgvAsigConteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvAsigConteo.Location = New System.Drawing.Point(6, 19)
        Me.DtgvAsigConteo.Name = "DtgvAsigConteo"
        Me.DtgvAsigConteo.ReadOnly = True
        Me.DtgvAsigConteo.Size = New System.Drawing.Size(774, 264)
        Me.DtgvAsigConteo.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(786, 367)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Selección"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FrmAsignacionConteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 417)
        Me.Controls.Add(Me.TabAsignacion)
        Me.Name = "FrmAsignacionConteo"
        Me.Text = "FrmAsignacionConteo"
        Me.TabAsignacion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DtgvAsigConteo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAsignacion As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbInventario As ComboBox
    Friend WithEvents CmbConteo As ComboBox
    Friend WithEvents DtInicio As DateTimePicker
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents CmbZona As ComboBox
    Friend WithEvents CmbEquipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtgvAsigConteo As DataGridView
    Friend WithEvents BtnAsignar As Button
End Class
