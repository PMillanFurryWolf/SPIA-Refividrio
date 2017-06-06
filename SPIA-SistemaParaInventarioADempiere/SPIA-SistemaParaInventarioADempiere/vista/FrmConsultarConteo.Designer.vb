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
        Me.tcConsultaConteo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtgvConteo = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAgregarConteo = New System.Windows.Forms.Button()
        Me.tcConsultaConteo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgvConteo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcConsultaConteo
        '
        Me.tcConsultaConteo.Controls.Add(Me.TabPage1)
        Me.tcConsultaConteo.Controls.Add(Me.TabPage2)
        Me.tcConsultaConteo.Location = New System.Drawing.Point(12, 12)
        Me.tcConsultaConteo.Name = "tcConsultaConteo"
        Me.tcConsultaConteo.SelectedIndex = 0
        Me.tcConsultaConteo.Size = New System.Drawing.Size(416, 307)
        Me.tcConsultaConteo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tcConsultaConteo.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAgregarConteo)
        Me.TabPage1.Controls.Add(Me.dtgvConteo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(408, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conteos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtgvConteo
        '
        Me.dtgvConteo.AllowUserToAddRows = False
        Me.dtgvConteo.AllowUserToDeleteRows = False
        Me.dtgvConteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvConteo.Location = New System.Drawing.Point(3, 0)
        Me.dtgvConteo.Name = "dtgvConteo"
        Me.dtgvConteo.Size = New System.Drawing.Size(400, 216)
        Me.dtgvConteo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(642, 225)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "selección"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'FrmConsultarConteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 331)
        Me.Controls.Add(Me.tcConsultaConteo)
        Me.Name = "FrmConsultarConteo"
        Me.Text = "FrmConsultarConteo"
        Me.tcConsultaConteo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgvConteo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcConsultaConteo As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtgvConteo As DataGridView
    Friend WithEvents btnAgregarConteo As Button
End Class
