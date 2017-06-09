<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.txtoolUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txttoolNivel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txttoolEquipo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtToolTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarConteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnaZonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SincronizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SincronziarConADempiereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picProdAdempiere = New System.Windows.Forms.PictureBox()
        Me.picProductosAlmacenados = New System.Windows.Forms.PictureBox()
        Me.picInventario = New System.Windows.Forms.PictureBox()
        Me.picZonas = New System.Windows.Forms.PictureBox()
        Me.picAsignarConteo = New System.Windows.Forms.PictureBox()
        Me.picConteo = New System.Windows.Forms.PictureBox()
        Me.picEquipo = New System.Windows.Forms.PictureBox()
        Me.StatusStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProdAdempiere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProductosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsignarConteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picConteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip2
        '
        Me.StatusStrip2.AutoSize = False
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtoolUsuario, Me.txttoolNivel, Me.txttoolEquipo, Me.txtToolTime})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(373, 22)
        Me.StatusStrip2.Stretch = False
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.TabStop = True
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'txtoolUsuario
        '
        Me.txtoolUsuario.Name = "txtoolUsuario"
        Me.txtoolUsuario.Size = New System.Drawing.Size(46, 17)
        Me.txtoolUsuario.Text = "usuario"
        '
        'txttoolNivel
        '
        Me.txttoolNivel.Name = "txttoolNivel"
        Me.txttoolNivel.Size = New System.Drawing.Size(32, 17)
        Me.txttoolNivel.Text = "nivel"
        '
        'txttoolEquipo
        '
        Me.txttoolEquipo.Name = "txttoolEquipo"
        Me.txttoolEquipo.Size = New System.Drawing.Size(44, 17)
        Me.txttoolEquipo.Text = "equipo"
        '
        'txtToolTime
        '
        Me.txtToolTime.Name = "txtToolTime"
        Me.txtToolTime.Size = New System.Drawing.Size(31, 17)
        Me.txtToolTime.Text = "time"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.GestiónToolStripMenuItem, Me.TareaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(373, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuariosToolStripMenuItem, Me.AgregarUnEquipoToolStripMenuItem, Me.AgregarConteosToolStripMenuItem, Me.AgregarUnaZonaToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'AgregarUsuariosToolStripMenuItem
        '
        Me.AgregarUsuariosToolStripMenuItem.Name = "AgregarUsuariosToolStripMenuItem"
        Me.AgregarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgregarUsuariosToolStripMenuItem.Text = "Agregar usuarios"
        '
        'AgregarUnEquipoToolStripMenuItem
        '
        Me.AgregarUnEquipoToolStripMenuItem.Name = "AgregarUnEquipoToolStripMenuItem"
        Me.AgregarUnEquipoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgregarUnEquipoToolStripMenuItem.Text = "Agregar un equipo"
        '
        'AgregarConteosToolStripMenuItem
        '
        Me.AgregarConteosToolStripMenuItem.Name = "AgregarConteosToolStripMenuItem"
        Me.AgregarConteosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgregarConteosToolStripMenuItem.Text = "Agregar conteos"
        '
        'AgregarUnaZonaToolStripMenuItem
        '
        Me.AgregarUnaZonaToolStripMenuItem.Name = "AgregarUnaZonaToolStripMenuItem"
        Me.AgregarUnaZonaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgregarUnaZonaToolStripMenuItem.Text = "Agregar una zona"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EquipoToolStripMenuItem, Me.ConteoToolStripMenuItem})
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'EquipoToolStripMenuItem
        '
        Me.EquipoToolStripMenuItem.Name = "EquipoToolStripMenuItem"
        Me.EquipoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EquipoToolStripMenuItem.Text = "Equipo"
        '
        'ConteoToolStripMenuItem
        '
        Me.ConteoToolStripMenuItem.Name = "ConteoToolStripMenuItem"
        Me.ConteoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ConteoToolStripMenuItem.Text = "Conteo"
        '
        'TareaToolStripMenuItem
        '
        Me.TareaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SincronizaciónToolStripMenuItem})
        Me.TareaToolStripMenuItem.Name = "TareaToolStripMenuItem"
        Me.TareaToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.TareaToolStripMenuItem.Text = "Tarea"
        '
        'SincronizaciónToolStripMenuItem
        '
        Me.SincronizaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SincronziarConADempiereToolStripMenuItem, Me.SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem})
        Me.SincronizaciónToolStripMenuItem.Name = "SincronizaciónToolStripMenuItem"
        Me.SincronizaciónToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SincronizaciónToolStripMenuItem.Text = "Sincronización"
        '
        'SincronziarConADempiereToolStripMenuItem
        '
        Me.SincronziarConADempiereToolStripMenuItem.Name = "SincronziarConADempiereToolStripMenuItem"
        Me.SincronziarConADempiereToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.SincronziarConADempiereToolStripMenuItem.Text = "Sincronziar con ADempiere"
        '
        'SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem
        '
        Me.SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem.Name = "SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem"
        Me.SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem.Text = "Sincronizar información de inventario a Adempiere"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Conteo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Zonas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Asignación de conteo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Inventario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Productos escaneados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Productos Adempiere"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(261, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Conteo Final"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.conteoFinal
        Me.PictureBox1.Location = New System.Drawing.Point(242, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'picProdAdempiere
        '
        Me.picProdAdempiere.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.ProductosAdempiere
        Me.picProdAdempiere.Location = New System.Drawing.Point(12, 338)
        Me.picProdAdempiere.Name = "picProdAdempiere"
        Me.picProdAdempiere.Size = New System.Drawing.Size(118, 103)
        Me.picProdAdempiere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProdAdempiere.TabIndex = 15
        Me.picProdAdempiere.TabStop = False
        '
        'picProductosAlmacenados
        '
        Me.picProductosAlmacenados.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.productosalmacenados
        Me.picProductosAlmacenados.Location = New System.Drawing.Point(136, 340)
        Me.picProductosAlmacenados.Name = "picProductosAlmacenados"
        Me.picProductosAlmacenados.Size = New System.Drawing.Size(110, 101)
        Me.picProductosAlmacenados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProductosAlmacenados.TabIndex = 8
        Me.picProductosAlmacenados.TabStop = False
        '
        'picInventario
        '
        Me.picInventario.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.inventario
        Me.picInventario.Location = New System.Drawing.Point(12, 181)
        Me.picInventario.Name = "picInventario"
        Me.picInventario.Size = New System.Drawing.Size(106, 101)
        Me.picInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInventario.TabIndex = 7
        Me.picInventario.TabStop = False
        '
        'picZonas
        '
        Me.picZonas.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.zonas
        Me.picZonas.Location = New System.Drawing.Point(124, 27)
        Me.picZonas.Name = "picZonas"
        Me.picZonas.Size = New System.Drawing.Size(109, 103)
        Me.picZonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picZonas.TabIndex = 6
        Me.picZonas.TabStop = False
        '
        'picAsignarConteo
        '
        Me.picAsignarConteo.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.asignarconteo
        Me.picAsignarConteo.Location = New System.Drawing.Point(124, 179)
        Me.picAsignarConteo.Name = "picAsignarConteo"
        Me.picAsignarConteo.Size = New System.Drawing.Size(112, 103)
        Me.picAsignarConteo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsignarConteo.TabIndex = 5
        Me.picAsignarConteo.TabStop = False
        '
        'picConteo
        '
        Me.picConteo.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.conteos
        Me.picConteo.Location = New System.Drawing.Point(244, 27)
        Me.picConteo.Name = "picConteo"
        Me.picConteo.Size = New System.Drawing.Size(110, 103)
        Me.picConteo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picConteo.TabIndex = 4
        Me.picConteo.TabStop = False
        '
        'picEquipo
        '
        Me.picEquipo.Image = Global.SPIA_SistemaParaInventarioADempiere.My.Resources.Resources.equipos
        Me.picEquipo.Location = New System.Drawing.Point(12, 27)
        Me.picEquipo.Name = "picEquipo"
        Me.picEquipo.Size = New System.Drawing.Size(106, 103)
        Me.picEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEquipo.TabIndex = 3
        Me.picEquipo.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(373, 550)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picProdAdempiere)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picProductosAlmacenados)
        Me.Controls.Add(Me.picInventario)
        Me.Controls.Add(Me.picZonas)
        Me.Controls.Add(Me.picAsignarConteo)
        Me.Controls.Add(Me.picConteo)
        Me.Controls.Add(Me.picEquipo)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProdAdempiere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProductosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsignarConteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picConteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents txtoolUsuario As ToolStripStatusLabel
    Friend WithEvents txttoolNivel As ToolStripStatusLabel
    Friend WithEvents txttoolEquipo As ToolStripStatusLabel
    Friend WithEvents txtToolTime As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TareaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnEquipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SincronizaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SincronziarConADempiereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarConteosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConteoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SincronizarInformaciónDeInventarioAAdempiereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picEquipo As PictureBox
    Friend WithEvents picConteo As PictureBox
    Friend WithEvents picAsignarConteo As PictureBox
    Friend WithEvents picZonas As PictureBox
    Friend WithEvents picInventario As PictureBox
    Friend WithEvents picProductosAlmacenados As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picProdAdempiere As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AgregarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnaZonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
End Class
