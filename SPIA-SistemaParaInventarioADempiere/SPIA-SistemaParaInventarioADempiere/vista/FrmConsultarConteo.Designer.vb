<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarConteo
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
        Me.TabConteo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAgregarConteo = New System.Windows.Forms.Button()
        Me.dtgvConteo = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtConteo = New System.Windows.Forms.TextBox()
        Me.PicBxColor = New System.Windows.Forms.PictureBox()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.BtnElegir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabConteo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgvConteo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PicBxColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConteo
        '
        Me.TabConteo.Controls.Add(Me.TabPage1)
        Me.TabConteo.Controls.Add(Me.TabPage2)
        Me.TabConteo.Location = New System.Drawing.Point(12, 12)
        Me.TabConteo.Name = "TabConteo"
        Me.TabConteo.SelectedIndex = 0
        Me.TabConteo.Size = New System.Drawing.Size(416, 255)
        Me.TabConteo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabConteo.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btnAgregarConteo)
        Me.TabPage1.Controls.Add(Me.dtgvConteo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(408, 229)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conteos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAgregarConteo
        '
        Me.btnAgregarConteo.Location = New System.Drawing.Point(149, 232)
        Me.btnAgregarConteo.Name = "btnAgregarConteo"
        Me.btnAgregarConteo.Size = New System.Drawing.Size(99, 23)
        Me.btnAgregarConteo.TabIndex = 2
        Me.btnAgregarConteo.Text = "Agregar conteo"
        Me.btnAgregarConteo.UseVisualStyleBackColor = True
        '
        'dtgvConteo
        '
        Me.dtgvConteo.AllowUserToAddRows = False
        Me.dtgvConteo.AllowUserToDeleteRows = False
        Me.dtgvConteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvConteo.Location = New System.Drawing.Point(3, 0)
        Me.dtgvConteo.Name = "dtgvConteo"
        Me.dtgvConteo.ReadOnly = True
        Me.dtgvConteo.Size = New System.Drawing.Size(400, 194)
        Me.dtgvConteo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtConteo)
        Me.TabPage2.Controls.Add(Me.PicBxColor)
        Me.TabPage2.Controls.Add(Me.TxtColor)
        Me.TabPage2.Controls.Add(Me.BtnElegir)
        Me.TabPage2.Controls.Add(Me.BtnEliminar)
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.lbl)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(408, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "selección"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtConteo
        '
        Me.TxtConteo.Location = New System.Drawing.Point(98, 24)
        Me.TxtConteo.Name = "TxtConteo"
        Me.TxtConteo.Size = New System.Drawing.Size(247, 20)
        Me.TxtConteo.TabIndex = 14
        '
        'PicBxColor
        '
        Me.PicBxColor.Location = New System.Drawing.Point(287, 77)
        Me.PicBxColor.Name = "PicBxColor"
        Me.PicBxColor.Size = New System.Drawing.Size(23, 23)
        Me.PicBxColor.TabIndex = 13
        Me.PicBxColor.TabStop = False
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(98, 79)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(183, 20)
        Me.TxtColor.TabIndex = 12
        '
        'BtnElegir
        '
        Me.BtnElegir.Location = New System.Drawing.Point(319, 77)
        Me.BtnElegir.Name = "BtnElegir"
        Me.BtnElegir.Size = New System.Drawing.Size(26, 23)
        Me.BtnElegir.TabIndex = 11
        Me.BtnElegir.Text = "..."
        Me.BtnElegir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(247, 177)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(106, 177)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(196, 135)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(17, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "lbl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conteo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmConsultarConteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(436, 279)
        Me.Controls.Add(Me.TabConteo)
        Me.MaximizeBox = False
        Me.Name = "FrmConsultarConteo"
        Me.Text = "FrmConsultarConteo"
        Me.TabConteo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgvConteo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PicBxColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabConteo As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtgvConteo As DataGridView
    Friend WithEvents btnAgregarConteo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents BtnElegir As Button
    Friend WithEvents PicBxColor As PictureBox
    Friend WithEvents TxtConteo As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
End Class
