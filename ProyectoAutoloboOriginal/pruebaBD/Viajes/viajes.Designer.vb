<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viajes
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
        Dim IdChoferLabel As System.Windows.Forms.Label
        Dim IdSociosLabel As System.Windows.Forms.Label
        Dim Fecha_origenLabel As System.Windows.Forms.Label
        Dim Fecha_destinoLabel As System.Windows.Forms.Label
        Dim Lugar_origenLabel As System.Windows.Forms.Label
        Dim Lugar_destinoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.OrigenPick = New System.Windows.Forms.DateTimePicker()
        Me.DestinoPick = New System.Windows.Forms.DateTimePicker()
        Me.Lugar_origenTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_destinoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxChofer = New System.Windows.Forms.ComboBox()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxSocios = New System.Windows.Forms.ComboBox()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxVehiculo = New System.Windows.Forms.ComboBox()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.SociosTableAdapter = New pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter()
        Me.VehiculoTableAdapter = New pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter()
        Me.CheckBoxReserva = New System.Windows.Forms.CheckBox()
        Me.CheckCta = New System.Windows.Forms.CheckBox()
        Me.NombreSocios = New System.Windows.Forms.TextBox()
        Me.NombreChofer = New System.Windows.Forms.TextBox()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IdChoferLabel = New System.Windows.Forms.Label()
        IdSociosLabel = New System.Windows.Forms.Label()
        Fecha_origenLabel = New System.Windows.Forms.Label()
        Fecha_destinoLabel = New System.Windows.Forms.Label()
        Lugar_origenLabel = New System.Windows.Forms.Label()
        Lugar_destinoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdChoferLabel.Location = New System.Drawing.Point(32, 62)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(79, 17)
        IdChoferLabel.TabIndex = 3
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdSociosLabel
        '
        IdSociosLabel.AutoSize = True
        IdSociosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdSociosLabel.Location = New System.Drawing.Point(32, 96)
        IdSociosLabel.Name = "IdSociosLabel"
        IdSociosLabel.Size = New System.Drawing.Size(79, 17)
        IdSociosLabel.TabIndex = 5
        IdSociosLabel.Text = "id Socios:"
        '
        'Fecha_origenLabel
        '
        Fecha_origenLabel.AutoSize = True
        Fecha_origenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_origenLabel.Location = New System.Drawing.Point(32, 162)
        Fecha_origenLabel.Name = "Fecha_origenLabel"
        Fecha_origenLabel.Size = New System.Drawing.Size(104, 17)
        Fecha_origenLabel.TabIndex = 7
        Fecha_origenLabel.Text = "fecha origen:"
        '
        'Fecha_destinoLabel
        '
        Fecha_destinoLabel.AutoSize = True
        Fecha_destinoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_destinoLabel.Location = New System.Drawing.Point(32, 188)
        Fecha_destinoLabel.Name = "Fecha_destinoLabel"
        Fecha_destinoLabel.Size = New System.Drawing.Size(111, 17)
        Fecha_destinoLabel.TabIndex = 9
        Fecha_destinoLabel.Text = "fecha destino:"
        '
        'Lugar_origenLabel
        '
        Lugar_origenLabel.AutoSize = True
        Lugar_origenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lugar_origenLabel.Location = New System.Drawing.Point(32, 215)
        Lugar_origenLabel.Name = "Lugar_origenLabel"
        Lugar_origenLabel.Size = New System.Drawing.Size(101, 17)
        Lugar_origenLabel.TabIndex = 13
        Lugar_origenLabel.Text = "lugar origen:"
        '
        'Lugar_destinoLabel
        '
        Lugar_destinoLabel.AutoSize = True
        Lugar_destinoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lugar_destinoLabel.Location = New System.Drawing.Point(32, 244)
        Lugar_destinoLabel.Name = "Lugar_destinoLabel"
        Lugar_destinoLabel.Size = New System.Drawing.Size(108, 17)
        Lugar_destinoLabel.TabIndex = 15
        Lugar_destinoLabel.Text = "lugar destino:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(278, 96)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(122, 17)
        NombreLabel.TabIndex = 27
        NombreLabel.Text = "Nombre Socios:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel1.Location = New System.Drawing.Point(278, 62)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(120, 17)
        NombreLabel1.TabIndex = 28
        NombreLabel1.Text = "Nombre chofer:"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DominioLabel.Location = New System.Drawing.Point(278, 129)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(76, 17)
        DominioLabel.TabIndex = 29
        DominioLabel.Text = " Dominio:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "Viajes"
        Me.ViajesBindingSource.DataSource = Me.Database1DataSet
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
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
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'OrigenPick
        '
        Me.OrigenPick.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_origen", True))
        Me.OrigenPick.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.OrigenPick.Location = New System.Drawing.Point(146, 161)
        Me.OrigenPick.Name = "OrigenPick"
        Me.OrigenPick.Size = New System.Drawing.Size(105, 20)
        Me.OrigenPick.TabIndex = 8
        '
        'DestinoPick
        '
        Me.DestinoPick.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_destino", True))
        Me.DestinoPick.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DestinoPick.Location = New System.Drawing.Point(146, 187)
        Me.DestinoPick.Name = "DestinoPick"
        Me.DestinoPick.Size = New System.Drawing.Size(105, 20)
        Me.DestinoPick.TabIndex = 10
        '
        'Lugar_origenTextBox
        '
        Me.Lugar_origenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_origen", True))
        Me.Lugar_origenTextBox.Location = New System.Drawing.Point(146, 218)
        Me.Lugar_origenTextBox.Name = "Lugar_origenTextBox"
        Me.Lugar_origenTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Lugar_origenTextBox.TabIndex = 14
        '
        'Lugar_destinoTextBox
        '
        Me.Lugar_destinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_destino", True))
        Me.Lugar_destinoTextBox.Location = New System.Drawing.Point(146, 244)
        Me.Lugar_destinoTextBox.Name = "Lugar_destinoTextBox"
        Me.Lugar_destinoTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Lugar_destinoTextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_más_2_matemáticas_80
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(134, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 86)
        Me.Button1.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Button1, "AGREGAR")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_izquierda_en_círculo_2_64
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(532, 37)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 79)
        Me.Button4.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.Button4, "VOLVER")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "id Vehiculo:"
        '
        'ComboBoxChofer
        '
        Me.ComboBoxChofer.DataSource = Me.ChoferBindingSource
        Me.ComboBoxChofer.DisplayMember = "id_chofer"
        Me.ComboBoxChofer.FormattingEnabled = True
        Me.ComboBoxChofer.Location = New System.Drawing.Point(146, 62)
        Me.ComboBoxChofer.Name = "ComboBoxChofer"
        Me.ComboBoxChofer.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxChofer.TabIndex = 23
        Me.ComboBoxChofer.ValueMember = "id_chofer"
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "Chofer"
        Me.ChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'ComboBoxSocios
        '
        Me.ComboBoxSocios.DataSource = Me.SociosBindingSource
        Me.ComboBoxSocios.DisplayMember = "id_socio"
        Me.ComboBoxSocios.FormattingEnabled = True
        Me.ComboBoxSocios.Location = New System.Drawing.Point(146, 96)
        Me.ComboBoxSocios.Name = "ComboBoxSocios"
        Me.ComboBoxSocios.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxSocios.TabIndex = 24
        Me.ComboBoxSocios.ValueMember = "id_socio"
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "Socios"
        Me.SociosBindingSource.DataSource = Me.Database1DataSet
        '
        'ComboBoxVehiculo
        '
        Me.ComboBoxVehiculo.DataSource = Me.VehiculoBindingSource
        Me.ComboBoxVehiculo.DisplayMember = "id_vehiculo"
        Me.ComboBoxVehiculo.FormattingEnabled = True
        Me.ComboBoxVehiculo.Location = New System.Drawing.Point(146, 129)
        Me.ComboBoxVehiculo.Name = "ComboBoxVehiculo"
        Me.ComboBoxVehiculo.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxVehiculo.TabIndex = 25
        Me.ComboBoxVehiculo.ValueMember = "id_vehiculo"
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Database1DataSet
        '
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'CheckBoxReserva
        '
        Me.CheckBoxReserva.AutoSize = True
        Me.CheckBoxReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxReserva.Location = New System.Drawing.Point(266, 219)
        Me.CheckBoxReserva.Name = "CheckBoxReserva"
        Me.CheckBoxReserva.Size = New System.Drawing.Size(87, 21)
        Me.CheckBoxReserva.TabIndex = 26
        Me.CheckBoxReserva.Text = "Reserva"
        Me.CheckBoxReserva.UseVisualStyleBackColor = True
        '
        'CheckCta
        '
        Me.CheckCta.AutoSize = True
        Me.CheckCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCta.Location = New System.Drawing.Point(266, 244)
        Me.CheckCta.Name = "CheckCta"
        Me.CheckCta.Size = New System.Drawing.Size(80, 21)
        Me.CheckCta.TabIndex = 27
        Me.CheckCta.Text = "Cta Cte"
        Me.CheckCta.UseVisualStyleBackColor = True
        '
        'NombreSocios
        '
        Me.NombreSocios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "nombre", True))
        Me.NombreSocios.Enabled = False
        Me.NombreSocios.Location = New System.Drawing.Point(404, 95)
        Me.NombreSocios.Name = "NombreSocios"
        Me.NombreSocios.Size = New System.Drawing.Size(100, 20)
        Me.NombreSocios.TabIndex = 28
        '
        'NombreChofer
        '
        Me.NombreChofer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "nombre", True))
        Me.NombreChofer.Enabled = False
        Me.NombreChofer.Location = New System.Drawing.Point(404, 61)
        Me.NombreChofer.Name = "NombreChofer"
        Me.NombreChofer.Size = New System.Drawing.Size(100, 20)
        Me.NombreChofer.TabIndex = 29
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Enabled = False
        Me.DominioTextBox.Location = New System.Drawing.Point(404, 128)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DominioTextBox.TabIndex = 30
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_agregar_usuario_grupo_mujer_hombre_64
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(281, 337)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(105, 86)
        Me.BtnNuevo.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "NUEVO USUARIO")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(664, 482)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(Me.DominioTextBox)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreChofer)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreSocios)
        Me.Controls.Add(Me.CheckCta)
        Me.Controls.Add(Me.CheckBoxReserva)
        Me.Controls.Add(Me.ComboBoxVehiculo)
        Me.Controls.Add(Me.ComboBoxSocios)
        Me.Controls.Add(Me.ComboBoxChofer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(IdSociosLabel)
        Me.Controls.Add(Fecha_origenLabel)
        Me.Controls.Add(Me.OrigenPick)
        Me.Controls.Add(Fecha_destinoLabel)
        Me.Controls.Add(Me.DestinoPick)
        Me.Controls.Add(Lugar_origenLabel)
        Me.Controls.Add(Me.Lugar_origenTextBox)
        Me.Controls.Add(Lugar_destinoLabel)
        Me.Controls.Add(Me.Lugar_destinoTextBox)
        Me.Name = "viajes"
        Me.Text = "viajes"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrigenPick As System.Windows.Forms.DateTimePicker
    Friend WithEvents DestinoPick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lugar_origenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lugar_destinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxChofer As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxSocios As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents SociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SociosTableAdapter As pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents CheckBoxReserva As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCta As System.Windows.Forms.CheckBox
    Friend WithEvents NombreSocios As System.Windows.Forms.TextBox
    Friend WithEvents NombreChofer As System.Windows.Forms.TextBox
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
