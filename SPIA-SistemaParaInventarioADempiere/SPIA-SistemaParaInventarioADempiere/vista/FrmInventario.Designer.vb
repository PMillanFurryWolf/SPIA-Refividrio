﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventario
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
        Me.TabInventario = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.FechaFinInventario = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicioInventario = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombreInventario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DtvgInventario = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.DtFinUp = New System.Windows.Forms.DateTimePicker()
        Me.DtInicioUP = New System.Windows.Forms.DateTimePicker()
        Me.TxtNomInventarioUP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.TabInventario.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DtvgInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabInventario
        '
        Me.TabInventario.Controls.Add(Me.TabPage1)
        Me.TabInventario.Controls.Add(Me.TabPage2)
        Me.TabInventario.Controls.Add(Me.TabPage3)
        Me.TabInventario.Location = New System.Drawing.Point(12, 28)
        Me.TabInventario.Name = "TabInventario"
        Me.TabInventario.SelectedIndex = 0
        Me.TabInventario.Size = New System.Drawing.Size(497, 328)
        Me.TabInventario.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabInventario.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.FechaFinInventario)
        Me.TabPage1.Controls.Add(Me.FechaInicioInventario)
        Me.TabPage1.Controls.Add(Me.TxtNombreInventario)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(489, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(331, 229)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(195, 229)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FechaFinInventario
        '
        Me.FechaFinInventario.Location = New System.Drawing.Point(195, 160)
        Me.FechaFinInventario.Name = "FechaFinInventario"
        Me.FechaFinInventario.Size = New System.Drawing.Size(211, 20)
        Me.FechaFinInventario.TabIndex = 5
        '
        'FechaInicioInventario
        '
        Me.FechaInicioInventario.Location = New System.Drawing.Point(195, 111)
        Me.FechaInicioInventario.Name = "FechaInicioInventario"
        Me.FechaInicioInventario.Size = New System.Drawing.Size(211, 20)
        Me.FechaInicioInventario.TabIndex = 4
        '
        'TxtNombreInventario
        '
        Me.TxtNombreInventario.Location = New System.Drawing.Point(195, 54)
        Me.TxtNombreInventario.Name = "TxtNombreInventario"
        Me.TxtNombreInventario.Size = New System.Drawing.Size(211, 20)
        Me.TxtNombreInventario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fin de inventario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio de inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de inventario"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DtvgInventario)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(489, 302)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Coleccion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DtvgInventario
        '
        Me.DtvgInventario.AllowUserToAddRows = False
        Me.DtvgInventario.AllowUserToDeleteRows = False
        Me.DtvgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvgInventario.Location = New System.Drawing.Point(6, 6)
        Me.DtvgInventario.Name = "DtvgInventario"
        Me.DtvgInventario.ReadOnly = True
        Me.DtvgInventario.Size = New System.Drawing.Size(477, 244)
        Me.DtvgInventario.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbl)
        Me.TabPage3.Controls.Add(Me.BtnEliminar)
        Me.TabPage3.Controls.Add(Me.BtnActualizar)
        Me.TabPage3.Controls.Add(Me.DtFinUp)
        Me.TabPage3.Controls.Add(Me.DtInicioUP)
        Me.TabPage3.Controls.Add(Me.TxtNomInventarioUP)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(489, 302)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Seleccion"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(333, 227)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 15
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(197, 227)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 14
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'DtFinUp
        '
        Me.DtFinUp.Location = New System.Drawing.Point(197, 158)
        Me.DtFinUp.Name = "DtFinUp"
        Me.DtFinUp.Size = New System.Drawing.Size(211, 20)
        Me.DtFinUp.TabIndex = 13
        '
        'DtInicioUP
        '
        Me.DtInicioUP.Location = New System.Drawing.Point(197, 109)
        Me.DtInicioUP.Name = "DtInicioUP"
        Me.DtInicioUP.Size = New System.Drawing.Size(211, 20)
        Me.DtInicioUP.TabIndex = 12
        '
        'TxtNomInventarioUP
        '
        Me.TxtNomInventarioUP.Location = New System.Drawing.Point(197, 52)
        Me.TxtNomInventarioUP.Name = "TxtNomInventarioUP"
        Me.TxtNomInventarioUP.Size = New System.Drawing.Size(211, 20)
        Me.TxtNomInventarioUP.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fin de inventario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Inicio de inventario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre de inventario"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(75, 236)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 16
        Me.lbl.Text = "Label7"
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(514, 378)
        Me.Controls.Add(Me.TabInventario)
        Me.MaximizeBox = False
        Me.Name = "FrmInventario"
        Me.Text = "FrmInventario"
        Me.TabInventario.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DtvgInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabInventario As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents FechaFinInventario As DateTimePicker
    Friend WithEvents FechaInicioInventario As DateTimePicker
    Friend WithEvents TxtNombreInventario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DtvgInventario As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents DtFinUp As DateTimePicker
    Friend WithEvents DtInicioUP As DateTimePicker
    Friend WithEvents TxtNomInventarioUP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl As Label
End Class
