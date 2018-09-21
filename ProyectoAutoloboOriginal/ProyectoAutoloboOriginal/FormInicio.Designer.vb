<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoferesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtaCorrienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.GestionToolStripMenuItem, Me.SociosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(543, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SocioToolStripMenuItem, Me.ViajeToolStripMenuItem, Me.ReservaToolStripMenuItem, Me.ChoferToolStripMenuItem, Me.VehiculoToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'SocioToolStripMenuItem
        '
        Me.SocioToolStripMenuItem.Name = "SocioToolStripMenuItem"
        Me.SocioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SocioToolStripMenuItem.Text = "Socio"
        '
        'ViajeToolStripMenuItem
        '
        Me.ViajeToolStripMenuItem.Name = "ViajeToolStripMenuItem"
        Me.ViajeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViajeToolStripMenuItem.Text = "Viaje"
        '
        'ReservaToolStripMenuItem
        '
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReservaToolStripMenuItem.Text = "Reserva"
        '
        'ChoferToolStripMenuItem
        '
        Me.ChoferToolStripMenuItem.Name = "ChoferToolStripMenuItem"
        Me.ChoferToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChoferToolStripMenuItem.Text = "Chofer"
        '
        'VehiculoToolStripMenuItem
        '
        Me.VehiculoToolStripMenuItem.Name = "VehiculoToolStripMenuItem"
        Me.VehiculoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VehiculoToolStripMenuItem.Text = "Vehiculo"
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
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'LiquidacionToolStripMenuItem
        '
        Me.LiquidacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChoferesToolStripMenuItem, Me.CtaCorrienteToolStripMenuItem})
        Me.LiquidacionToolStripMenuItem.Name = "LiquidacionToolStripMenuItem"
        Me.LiquidacionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LiquidacionToolStripMenuItem.Text = "Liquidacion"
        '
        'ChoferesToolStripMenuItem
        '
        Me.ChoferesToolStripMenuItem.Name = "ChoferesToolStripMenuItem"
        Me.ChoferesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ChoferesToolStripMenuItem.Text = "Choferes"
        '
        'CtaCorrienteToolStripMenuItem
        '
        Me.CtaCorrienteToolStripMenuItem.Name = "CtaCorrienteToolStripMenuItem"
        Me.CtaCorrienteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CtaCorrienteToolStripMenuItem.Text = "Cta Corriente"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuiaToolStripMenuItem, Me.ContactoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'GuiaToolStripMenuItem
        '
        Me.GuiaToolStripMenuItem.Name = "GuiaToolStripMenuItem"
        Me.GuiaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuiaToolStripMenuItem.Text = "Guia"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 347)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChoferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiquidacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChoferesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtaCorrienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
