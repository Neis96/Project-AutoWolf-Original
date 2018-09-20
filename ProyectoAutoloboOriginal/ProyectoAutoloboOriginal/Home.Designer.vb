<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionChoferesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionCCorrienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.GestionToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1005, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.NueToolStripMenuItem, Me.NuevaReservaToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Socio"
        '
        'NueToolStripMenuItem
        '
        Me.NueToolStripMenuItem.Name = "NueToolStripMenuItem"
        Me.NueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NueToolStripMenuItem.Text = "Nuevo Viaje"
        '
        'NuevaReservaToolStripMenuItem
        '
        Me.NuevaReservaToolStripMenuItem.Name = "NuevaReservaToolStripMenuItem"
        Me.NuevaReservaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaReservaToolStripMenuItem.Text = "Nueva Reserva"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ResumenToolStripMenuItem
        '
        Me.ResumenToolStripMenuItem.Name = "ResumenToolStripMenuItem"
        Me.ResumenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResumenToolStripMenuItem.Text = "Resumen"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionChoferesToolStripMenuItem, Me.LiquidacionCCorrienteToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'LiquidacionChoferesToolStripMenuItem
        '
        Me.LiquidacionChoferesToolStripMenuItem.Name = "LiquidacionChoferesToolStripMenuItem"
        Me.LiquidacionChoferesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LiquidacionChoferesToolStripMenuItem.Text = "Liquidacion Choferes"
        '
        'LiquidacionCCorrienteToolStripMenuItem
        '
        Me.LiquidacionCCorrienteToolStripMenuItem.Name = "LiquidacionCCorrienteToolStripMenuItem"
        Me.LiquidacionCCorrienteToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LiquidacionCCorrienteToolStripMenuItem.Text = "Liquidacion C.Corriente"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuiaToolStripMenuItem, Me.ContactosToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'GuiaToolStripMenuItem
        '
        Me.GuiaToolStripMenuItem.Name = "GuiaToolStripMenuItem"
        Me.GuiaToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.GuiaToolStripMenuItem.Text = "Guia"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(814, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(814, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 431)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaReservaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiquidacionChoferesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiquidacionCCorrienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    'Friend WithEvents PrimeraBdDataSet As ProyectoAutoloboOriginal.primeraBdDataSet
    'Friend WithEvents VehiculoTableAdapter As ProyectoAutoloboOriginal.primeraBdDataSetTableAdapters.vehiculoTableAdapter
    ' Friend WithEvents TableAdapterManager As ProyectoAutoloboOriginal.primeraBdDataSetTableAdapters.TableAdapterManager

End Class
