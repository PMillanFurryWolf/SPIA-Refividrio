<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarZona
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreZona = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TxtUbicacion = New System.Windows.Forms.TextBox()
        Me.TabZona = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBuscadorAlmacen = New System.Windows.Forms.TextBox()
        Me.DtgvAlmacen = New System.Windows.Forms.DataGridView()
        Me.BtnUbc = New System.Windows.Forms.Button()
        Me.TabZona.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DtgvAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la zona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ubicación"
        '
        'TxtNombreZona
        '
        Me.TxtNombreZona.Location = New System.Drawing.Point(136, 23)
        Me.TxtNombreZona.Name = "TxtNombreZona"
        Me.TxtNombreZona.Size = New System.Drawing.Size(223, 20)
        Me.TxtNombreZona.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(136, 146)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(242, 146)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'TxtUbicacion
        '
        Me.TxtUbicacion.Location = New System.Drawing.Point(136, 77)
        Me.TxtUbicacion.Name = "TxtUbicacion"
        Me.TxtUbicacion.Size = New System.Drawing.Size(181, 20)
        Me.TxtUbicacion.TabIndex = 8
        '
        'TabZona
        '
        Me.TabZona.Controls.Add(Me.TabPage1)
        Me.TabZona.Controls.Add(Me.TabPage2)
        Me.TabZona.Location = New System.Drawing.Point(12, 12)
        Me.TabZona.Name = "TabZona"
        Me.TabZona.SelectedIndex = 0
        Me.TabZona.Size = New System.Drawing.Size(444, 239)
        Me.TabZona.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabZona.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUbc)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtUbicacion)
        Me.TabPage1.Controls.Add(Me.TxtNombreZona)
        Me.TabPage1.Controls.Add(Me.btnCancelar)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(436, 213)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtBuscadorAlmacen)
        Me.TabPage2.Controls.Add(Me.DtgvAlmacen)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(436, 213)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Almacenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clave o nombre de almacén"
        '
        'TxtBuscadorAlmacen
        '
        Me.TxtBuscadorAlmacen.Location = New System.Drawing.Point(189, 18)
        Me.TxtBuscadorAlmacen.Name = "TxtBuscadorAlmacen"
        Me.TxtBuscadorAlmacen.Size = New System.Drawing.Size(193, 20)
        Me.TxtBuscadorAlmacen.TabIndex = 1
        '
        'DtgvAlmacen
        '
        Me.DtgvAlmacen.AllowUserToAddRows = False
        Me.DtgvAlmacen.AllowUserToDeleteRows = False
        Me.DtgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvAlmacen.Location = New System.Drawing.Point(6, 44)
        Me.DtgvAlmacen.Name = "DtgvAlmacen"
        Me.DtgvAlmacen.ReadOnly = True
        Me.DtgvAlmacen.Size = New System.Drawing.Size(424, 163)
        Me.DtgvAlmacen.TabIndex = 0
        '
        'BtnUbc
        '
        Me.BtnUbc.Location = New System.Drawing.Point(323, 77)
        Me.BtnUbc.Name = "BtnUbc"
        Me.BtnUbc.Size = New System.Drawing.Size(36, 21)
        Me.BtnUbc.TabIndex = 9
        Me.BtnUbc.Text = "..."
        Me.BtnUbc.UseVisualStyleBackColor = True
        '
        'FrmAgregarZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 265)
        Me.Controls.Add(Me.TabZona)
        Me.Name = "FrmAgregarZona"
        Me.Text = "FrmAgregarZona"
        Me.TabZona.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DtgvAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreZona As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents TxtUbicacion As TextBox
    Friend WithEvents TabZona As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DtgvAlmacen As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBuscadorAlmacen As TextBox
    Friend WithEvents BtnUbc As Button
End Class
