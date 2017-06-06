<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProdSincADP
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
        Me.dtgvProds = New System.Windows.Forms.DataGridView()
        Me.TabProds = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.dtgvBusqusquedaProd = New System.Windows.Forms.DataGridView()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        CType(Me.dtgvProds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProds.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgvBusqusquedaProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvProds
        '
        Me.dtgvProds.AllowUserToAddRows = False
        Me.dtgvProds.AllowUserToDeleteRows = False
        Me.dtgvProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvProds.Location = New System.Drawing.Point(6, 6)
        Me.dtgvProds.Name = "dtgvProds"
        Me.dtgvProds.Size = New System.Drawing.Size(630, 273)
        Me.dtgvProds.TabIndex = 0
        '
        'TabProds
        '
        Me.TabProds.Controls.Add(Me.TabPage1)
        Me.TabProds.Controls.Add(Me.TabPage2)
        Me.TabProds.Location = New System.Drawing.Point(12, 12)
        Me.TabProds.Name = "TabProds"
        Me.TabProds.SelectedIndex = 0
        Me.TabProds.Size = New System.Drawing.Size(659, 322)
        Me.TabProds.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabProds.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtgvProds)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(651, 296)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Colección"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.BtnCopiar)
        Me.TabPage2.Controls.Add(Me.dtgvBusqusquedaProd)
        Me.TabPage2.Controls.Add(Me.txtBuscador)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(651, 296)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Búsqueda"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave o nombre de producto"
        '
        'BtnCopiar
        '
        Me.BtnCopiar.Location = New System.Drawing.Point(249, 248)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(130, 23)
        Me.BtnCopiar.TabIndex = 2
        Me.BtnCopiar.Text = "Copiar a portapapeles"
        Me.BtnCopiar.UseVisualStyleBackColor = True
        '
        'dtgvBusqusquedaProd
        '
        Me.dtgvBusqusquedaProd.AllowUserToAddRows = False
        Me.dtgvBusqusquedaProd.AllowUserToDeleteRows = False
        Me.dtgvBusqusquedaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvBusqusquedaProd.Location = New System.Drawing.Point(23, 76)
        Me.dtgvBusqusquedaProd.Name = "dtgvBusqusquedaProd"
        Me.dtgvBusqusquedaProd.ReadOnly = True
        Me.dtgvBusqusquedaProd.Size = New System.Drawing.Size(612, 150)
        Me.dtgvBusqusquedaProd.TabIndex = 1
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(276, 31)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(207, 20)
        Me.txtBuscador.TabIndex = 0
        '
        'FrmConsultaProdSincADP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 347)
        Me.Controls.Add(Me.TabProds)
        Me.Name = "FrmConsultaProdSincADP"
        Me.Text = "FrmConsultaProdSincADP"
        CType(Me.dtgvProds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProds.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgvBusqusquedaProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvProds As DataGridView
    Friend WithEvents TabProds As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnCopiar As Button
    Friend WithEvents dtgvBusqusquedaProd As DataGridView
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Label1 As Label
End Class
