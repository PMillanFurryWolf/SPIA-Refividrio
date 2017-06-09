<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarConteo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarConteo))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbConteo = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnElegir = New System.Windows.Forms.Button()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.PicBxColor = New System.Windows.Forms.PictureBox()
        CType(Me.PicBxColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(107, 126)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(244, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Conteo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Color"
        '
        'cmbConteo
        '
        Me.cmbConteo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConteo.FormattingEnabled = True
        Me.cmbConteo.Location = New System.Drawing.Point(107, 24)
        Me.cmbConteo.Name = "cmbConteo"
        Me.cmbConteo.Size = New System.Drawing.Size(247, 21)
        Me.cmbConteo.TabIndex = 6
        '
        'BtnElegir
        '
        Me.BtnElegir.Location = New System.Drawing.Point(328, 77)
        Me.BtnElegir.Name = "BtnElegir"
        Me.BtnElegir.Size = New System.Drawing.Size(26, 23)
        Me.BtnElegir.TabIndex = 7
        Me.BtnElegir.Text = "..."
        Me.BtnElegir.UseVisualStyleBackColor = True
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(107, 79)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(183, 20)
        Me.TxtColor.TabIndex = 8
        '
        'PicBxColor
        '
        Me.PicBxColor.Location = New System.Drawing.Point(296, 77)
        Me.PicBxColor.Name = "PicBxColor"
        Me.PicBxColor.Size = New System.Drawing.Size(23, 23)
        Me.PicBxColor.TabIndex = 9
        Me.PicBxColor.TabStop = False
        '
        'FrmAgregarConteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(396, 171)
        Me.Controls.Add(Me.PicBxColor)
        Me.Controls.Add(Me.TxtColor)
        Me.Controls.Add(Me.BtnElegir)
        Me.Controls.Add(Me.cmbConteo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAgregarConteo"
        Me.Text = "FrmAgregarConteo"
        CType(Me.PicBxColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbConteo As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnElegir As Button
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents PicBxColor As PictureBox
End Class
