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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.dtvDatos.BackgroundColor = System.Drawing.SystemColors.HotTrack
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "nombreayu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombrerespo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "equipo"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
