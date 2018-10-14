<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnViajes = New System.Windows.Forms.Button()
        Me.BtnSocio = New System.Windows.Forms.Button()
        Me.BtnChoferes = New System.Windows.Forms.Button()
        Me.BtnVehiculos = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajesF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosF2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoferesF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionChoferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarValoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvEstado = New System.Windows.Forms.DataGridView()
        Me.DgvReserva = New System.Windows.Forms.DataGridView()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.LiquidacionChoferToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnViajes
        '
        Me.BtnViajes.Location = New System.Drawing.Point(29, 147)
        Me.BtnViajes.Name = "BtnViajes"
        Me.BtnViajes.Size = New System.Drawing.Size(132, 58)
        Me.BtnViajes.TabIndex = 0
        Me.BtnViajes.Text = "Viajes"
        Me.BtnViajes.UseVisualStyleBackColor = True
        '
        'BtnSocio
        '
        Me.BtnSocio.Location = New System.Drawing.Point(29, 235)
        Me.BtnSocio.Name = "BtnSocio"
        Me.BtnSocio.Size = New System.Drawing.Size(132, 59)
        Me.BtnSocio.TabIndex = 1
        Me.BtnSocio.Text = "Socio"
        Me.BtnSocio.UseVisualStyleBackColor = True
        '
        'BtnChoferes
        '
        Me.BtnChoferes.Location = New System.Drawing.Point(29, 325)
        Me.BtnChoferes.Name = "BtnChoferes"
        Me.BtnChoferes.Size = New System.Drawing.Size(132, 58)
        Me.BtnChoferes.TabIndex = 2
        Me.BtnChoferes.Text = "Choferes"
        Me.BtnChoferes.UseVisualStyleBackColor = True
        '
        'BtnVehiculos
        '
        Me.BtnVehiculos.Location = New System.Drawing.Point(29, 413)
        Me.BtnVehiculos.Name = "BtnVehiculos"
        Me.BtnVehiculos.Size = New System.Drawing.Size(132, 63)
        Me.BtnVehiculos.TabIndex = 3
        Me.BtnVehiculos.Text = "Vehiculos"
        Me.BtnVehiculos.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.ResumenToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 24)
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
        Me.ViajesF1ToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ViajesF1ToolStripMenuItem.Text = "Viajes F1"
        '
        'SociosF2ToolStripMenuItem
        '
        Me.SociosF2ToolStripMenuItem.Name = "SociosF2ToolStripMenuItem"
        Me.SociosF2ToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SociosF2ToolStripMenuItem.Text = "Socios     F2"
        '
        'ChoferesF3ToolStripMenuItem
        '
        Me.ChoferesF3ToolStripMenuItem.Name = "ChoferesF3ToolStripMenuItem"
        Me.ChoferesF3ToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ChoferesF3ToolStripMenuItem.Text = "Choferes F3"
        '
        'VehiculosF4ToolStripMenuItem
        '
        Me.VehiculosF4ToolStripMenuItem.Name = "VehiculosF4ToolStripMenuItem"
        Me.VehiculosF4ToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.VehiculosF4ToolStripMenuItem.Text = "Vehiculos F4"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenToolStripMenuItem1})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ResumenToolStripMenuItem1
        '
        Me.ResumenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionChoferToolStripMenuItem1, Me.AgenciaToolStripMenuItem})
        Me.ResumenToolStripMenuItem1.Name = "ResumenToolStripMenuItem1"
        Me.ResumenToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ResumenToolStripMenuItem1.Text = "Resumen"
        '
        'ResumenToolStripMenuItem
        '
        Me.ResumenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionChoferToolStripMenuItem})
        Me.ResumenToolStripMenuItem.Name = "ResumenToolStripMenuItem"
        Me.ResumenToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ResumenToolStripMenuItem.Text = "Gestion"
        '
        'LiquidacionChoferToolStripMenuItem
        '
        Me.LiquidacionChoferToolStripMenuItem.Name = "LiquidacionChoferToolStripMenuItem"
        Me.LiquidacionChoferToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LiquidacionChoferToolStripMenuItem.Text = "Liquidacion chofer"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuariosToolStripMenuItem, Me.ModificarValoresToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'CrearUsuariosToolStripMenuItem
        '
        Me.CrearUsuariosToolStripMenuItem.Name = "CrearUsuariosToolStripMenuItem"
        Me.CrearUsuariosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CrearUsuariosToolStripMenuItem.Text = "Crear Usuarios"
        '
        'ModificarValoresToolStripMenuItem
        '
        Me.ModificarValoresToolStripMenuItem.Name = "ModificarValoresToolStripMenuItem"
        Me.ModificarValoresToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModificarValoresToolStripMenuItem.Text = "Modificar Valores"
        '
        'DgvEstado
        '
        Me.DgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstado.Location = New System.Drawing.Point(218, 378)
        Me.DgvEstado.Name = "DgvEstado"
        Me.DgvEstado.Size = New System.Drawing.Size(525, 242)
        Me.DgvEstado.TabIndex = 11
        '
        'DgvReserva
        '
        Me.DgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReserva.Location = New System.Drawing.Point(785, 137)
        Me.DgvReserva.Name = "DgvReserva"
        Me.DgvReserva.Size = New System.Drawing.Size(422, 354)
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
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
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
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 632)
        Me.Controls.Add(Me.DgvReserva)
        Me.Controls.Add(Me.DgvEstado)
        Me.Controls.Add(Me.BtnVehiculos)
        Me.Controls.Add(Me.BtnChoferes)
        Me.Controls.Add(Me.BtnSocio)
        Me.Controls.Add(Me.BtnViajes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
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
    Friend WithEvents LiquidacionChoferToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
