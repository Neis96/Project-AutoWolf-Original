﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajesF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosF2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoferesF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionChoferToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionChoferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionCtaCteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarChoferesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarValoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionCtaCteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvEstado = New System.Windows.Forms.DataGridView()
        Me.DgvReserva = New System.Windows.Forms.DataGridView()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnVehiculos = New System.Windows.Forms.Button()
        Me.BtnChoferes = New System.Windows.Forms.Button()
        Me.BtnSocio = New System.Windows.Forms.Button()
        Me.BtnViajes = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.ResumenToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1054, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajesF1ToolStripMenuItem, Me.SociosF2ToolStripMenuItem, Me.ChoferesF3ToolStripMenuItem, Me.VehiculosF4ToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ViajesF1ToolStripMenuItem
        '
        Me.ViajesF1ToolStripMenuItem.Name = "ViajesF1ToolStripMenuItem"
        Me.ViajesF1ToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ViajesF1ToolStripMenuItem.Text = "Viajes F1"
        '
        'SociosF2ToolStripMenuItem
        '
        Me.SociosF2ToolStripMenuItem.Name = "SociosF2ToolStripMenuItem"
        Me.SociosF2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SociosF2ToolStripMenuItem.Text = "Socios     F2"
        '
        'ChoferesF3ToolStripMenuItem
        '
        Me.ChoferesF3ToolStripMenuItem.Name = "ChoferesF3ToolStripMenuItem"
        Me.ChoferesF3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChoferesF3ToolStripMenuItem.Text = "Choferes F3"
        '
        'VehiculosF4ToolStripMenuItem
        '
        Me.VehiculosF4ToolStripMenuItem.Name = "VehiculosF4ToolStripMenuItem"
        Me.VehiculosF4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VehiculosF4ToolStripMenuItem.Text = "Vehiculos F4"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenToolStripMenuItem1})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ResumenToolStripMenuItem1
        '
        Me.ResumenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionChoferToolStripMenuItem1, Me.AgenciaToolStripMenuItem})
        Me.ResumenToolStripMenuItem1.Name = "ResumenToolStripMenuItem1"
        Me.ResumenToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.ResumenToolStripMenuItem1.Text = "Resumen"
        '
        'LiquidacionChoferToolStripMenuItem1
        '
        Me.LiquidacionChoferToolStripMenuItem1.Name = "LiquidacionChoferToolStripMenuItem1"
        Me.LiquidacionChoferToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.LiquidacionChoferToolStripMenuItem1.Text = "Liquidacion chofer"
        '
        'AgenciaToolStripMenuItem
        '
        Me.AgenciaToolStripMenuItem.Name = "AgenciaToolStripMenuItem"
        Me.AgenciaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgenciaToolStripMenuItem.Text = "Agencia"
        '
        'ResumenToolStripMenuItem
        '
        Me.ResumenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionChoferToolStripMenuItem, Me.LiquidacionCtaCteToolStripMenuItem, Me.ModificarChoferesToolStripMenuItem})
        Me.ResumenToolStripMenuItem.Name = "ResumenToolStripMenuItem"
        Me.ResumenToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ResumenToolStripMenuItem.Text = "Gestion"
        '
        'LiquidacionChoferToolStripMenuItem
        '
        Me.LiquidacionChoferToolStripMenuItem.Name = "LiquidacionChoferToolStripMenuItem"
        Me.LiquidacionChoferToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LiquidacionChoferToolStripMenuItem.Text = "Liquidacion chofer"
        '
        'LiquidacionCtaCteToolStripMenuItem
        '
        Me.LiquidacionCtaCteToolStripMenuItem.Name = "LiquidacionCtaCteToolStripMenuItem"
        Me.LiquidacionCtaCteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LiquidacionCtaCteToolStripMenuItem.Text = "Liquidacion Cta Cte"
        '
        'ModificarChoferesToolStripMenuItem
        '
        Me.ModificarChoferesToolStripMenuItem.Name = "ModificarChoferesToolStripMenuItem"
        Me.ModificarChoferesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ModificarChoferesToolStripMenuItem.Text = "Modificar Choferes"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem, Me.ContactoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuariosToolStripMenuItem, Me.ModificarValoresToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'CrearUsuariosToolStripMenuItem
        '
        Me.CrearUsuariosToolStripMenuItem.Name = "CrearUsuariosToolStripMenuItem"
        Me.CrearUsuariosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CrearUsuariosToolStripMenuItem.Text = "Crear Usuarios"
        '
        'ModificarValoresToolStripMenuItem
        '
        Me.ModificarValoresToolStripMenuItem.Name = "ModificarValoresToolStripMenuItem"
        Me.ModificarValoresToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModificarValoresToolStripMenuItem.Text = "Modificar Valores"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'LiquidacionCtaCteToolStripMenuItem1
        '
        Me.LiquidacionCtaCteToolStripMenuItem1.Name = "LiquidacionCtaCteToolStripMenuItem1"
        Me.LiquidacionCtaCteToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.LiquidacionCtaCteToolStripMenuItem1.Text = "Liquidacion Cta Cte"
        '
        'DgvEstado
        '
        Me.DgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstado.Location = New System.Drawing.Point(260, 87)
        Me.DgvEstado.Name = "DgvEstado"
        Me.DgvEstado.Size = New System.Drawing.Size(627, 222)
        Me.DgvEstado.TabIndex = 11
        '
        'DgvReserva
        '
        Me.DgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReserva.Location = New System.Drawing.Point(260, 357)
        Me.DgvReserva.Name = "DgvReserva"
        Me.DgvReserva.Size = New System.Drawing.Size(627, 215)
        Me.DgvReserva.TabIndex = 12
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "Viajes"
        Me.ViajesBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario1TableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_señal_de_salida_filled_100
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(924, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 109)
        Me.Button1.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button1, "SALIR")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnVehiculos
        '
        Me.BtnVehiculos.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_volante_64
        Me.BtnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnVehiculos.FlatAppearance.BorderSize = 0
        Me.BtnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVehiculos.Location = New System.Drawing.Point(29, 458)
        Me.BtnVehiculos.Name = "BtnVehiculos"
        Me.BtnVehiculos.Size = New System.Drawing.Size(104, 81)
        Me.BtnVehiculos.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnVehiculos, "VEHICULOS")
        Me.BtnVehiculos.UseVisualStyleBackColor = True
        '
        'BtnChoferes
        '
        Me.BtnChoferes.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_conductor_80
        Me.BtnChoferes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnChoferes.FlatAppearance.BorderSize = 0
        Me.BtnChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChoferes.Location = New System.Drawing.Point(29, 329)
        Me.BtnChoferes.Name = "BtnChoferes"
        Me.BtnChoferes.Size = New System.Drawing.Size(104, 85)
        Me.BtnChoferes.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnChoferes, "CHOFERES")
        Me.BtnChoferes.UseVisualStyleBackColor = True
        '
        'BtnSocio
        '
        Me.BtnSocio.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_agregar_usuario_grupo_mujer_hombre_64
        Me.BtnSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSocio.FlatAppearance.BorderSize = 0
        Me.BtnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSocio.Location = New System.Drawing.Point(29, 225)
        Me.BtnSocio.Name = "BtnSocio"
        Me.BtnSocio.Size = New System.Drawing.Size(104, 84)
        Me.BtnSocio.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnSocio, "SOCIOS")
        Me.BtnSocio.UseVisualStyleBackColor = True
        '
        'BtnViajes
        '
        Me.BtnViajes.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_garaje_80
        Me.BtnViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnViajes.FlatAppearance.BorderSize = 0
        Me.BtnViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViajes.Location = New System.Drawing.Point(29, 106)
        Me.BtnViajes.Name = "BtnViajes"
        Me.BtnViajes.Size = New System.Drawing.Size(104, 101)
        Me.BtnViajes.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnViajes, "VIAJES")
        Me.BtnViajes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Viajes en curso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 31)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Reservas"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 31)
        Me.Label3.TabIndex = 16
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1054, 627)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvReserva)
        Me.Controls.Add(Me.DgvEstado)
        Me.Controls.Add(Me.BtnVehiculos)
        Me.Controls.Add(Me.BtnChoferes)
        Me.Controls.Add(Me.BtnSocio)
        Me.Controls.Add(Me.BtnViajes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvReserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnViajes As System.Windows.Forms.Button
    Friend WithEvents BtnSocio As System.Windows.Forms.Button
    Friend WithEvents BtnChoferes As System.Windows.Forms.Button
    Friend WithEvents BtnVehiculos As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ReservaBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiquidacionChoferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DgvEstado As System.Windows.Forms.DataGridView
    Friend WithEvents DgvReserva As System.Windows.Forms.DataGridView
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents ViajesF1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SociosF2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChoferesF3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculosF4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarValoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents LiquidacionCtaCteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiquidacionCtaCteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarChoferesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents LiquidacionChoferToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
