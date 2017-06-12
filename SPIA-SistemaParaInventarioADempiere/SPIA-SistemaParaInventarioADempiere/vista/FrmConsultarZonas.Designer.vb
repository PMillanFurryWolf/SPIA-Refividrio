<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultarZonas
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
        Me.TabZona = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.dtgvZonas = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.BtnCodigoAlmacen = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtUbicacion = New System.Windows.Forms.TextBox()
        Me.TxtNombreZona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBuscarZona = New System.Windows.Forms.TextBox()
        Me.DtgvAlmacen = New System.Windows.Forms.DataGridView()
        Me.TabZona.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgvZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DtgvAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabZona
        '
        Me.TabZona.Controls.Add(Me.TabPage1)
        Me.TabZona.Controls.Add(Me.TabPage2)
        Me.TabZona.Controls.Add(Me.TabPage3)
        Me.TabZona.Location = New System.Drawing.Point(12, 12)
        Me.TabZona.Name = "TabZona"
        Me.TabZona.SelectedIndex = 0
        Me.TabZona.Size = New System.Drawing.Size(582, 279)
        Me.TabZona.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabZona.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnAgregar)
        Me.TabPage1.Controls.Add(Me.dtgvZonas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(574, 253)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Zonas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(246, 224)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(89, 23)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar Zona"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'dtgvZonas
        '
        Me.dtgvZonas.AllowUserToAddRows = False
        Me.dtgvZonas.AllowUserToDeleteRows = False
        Me.dtgvZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvZonas.Location = New System.Drawing.Point(3, 6)
        Me.dtgvZonas.Name = "dtgvZonas"
        Me.dtgvZonas.ReadOnly = True
        Me.dtgvZonas.Size = New System.Drawing.Size(565, 212)
        Me.dtgvZonas.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Lbl)
        Me.TabPage2.Controls.Add(Me.BtnCodigoAlmacen)
        Me.TabPage2.Controls.Add(Me.BtnEliminar)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtUbicacion)
        Me.TabPage2.Controls.Add(Me.TxtNombreZona)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(574, 253)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Selección"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(144, 160)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(39, 13)
        Me.Lbl.TabIndex = 9
        Me.Lbl.Text = "Label3"
        '
        'BtnCodigoAlmacen
        '
        Me.BtnCodigoAlmacen.Location = New System.Drawing.Point(411, 101)
        Me.BtnCodigoAlmacen.Name = "BtnCodigoAlmacen"
        Me.BtnCodigoAlmacen.Size = New System.Drawing.Size(28, 23)
        Me.BtnCodigoAlmacen.TabIndex = 8
        Me.BtnCodigoAlmacen.Text = "..."
        Me.BtnCodigoAlmacen.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(359, 199)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(193, 199)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 6
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtUbicacion
        '
        Me.TxtUbicacion.Location = New System.Drawing.Point(193, 103)
        Me.TxtUbicacion.Name = "TxtUbicacion"
        Me.TxtUbicacion.Size = New System.Drawing.Size(204, 20)
        Me.TxtUbicacion.TabIndex = 4
        '
        'TxtNombreZona
        '
        Me.TxtNombreZona.Location = New System.Drawing.Point(193, 46)
        Me.TxtNombreZona.Name = "TxtNombreZona"
        Me.TxtNombreZona.Size = New System.Drawing.Size(241, 20)
        Me.TxtNombreZona.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ubicación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la zona"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.TxtBuscarZona)
        Me.TabPage3.Controls.Add(Me.DtgvAlmacen)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(574, 253)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Almacenes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Almacén o clave"
        '
        'TxtBuscarZona
        '
        Me.TxtBuscarZona.Location = New System.Drawing.Point(155, 23)
        Me.TxtBuscarZona.Name = "TxtBuscarZona"
        Me.TxtBuscarZona.Size = New System.Drawing.Size(171, 20)
        Me.TxtBuscarZona.TabIndex = 1
        '
        'DtgvAlmacen
        '
        Me.DtgvAlmacen.AllowUserToAddRows = False
        Me.DtgvAlmacen.AllowUserToDeleteRows = False
        Me.DtgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvAlmacen.Location = New System.Drawing.Point(3, 49)
        Me.DtgvAlmacen.Name = "DtgvAlmacen"
        Me.DtgvAlmacen.ReadOnly = True
        Me.DtgvAlmacen.Size = New System.Drawing.Size(568, 201)
        Me.DtgvAlmacen.TabIndex = 0
        '
        'FrmConsultarZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(606, 303)
        Me.Controls.Add(Me.TabZona)
        Me.MaximizeBox = False
        Me.Name = "FrmConsultarZonas"
        Me.Text = "FrmConsultarZonas"
        Me.TabZona.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgvZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DtgvAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabZona As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtgvZonas As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtUbicacion As TextBox
    Friend WithEvents TxtNombreZona As TextBox
    Friend WithEvents BtnCodigoAlmacen As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Lbl As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBuscarZona As TextBox
    Friend WithEvents DtgvAlmacen As DataGridView
End Class
