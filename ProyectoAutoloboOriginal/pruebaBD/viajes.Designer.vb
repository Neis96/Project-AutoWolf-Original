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
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Lugar_origenLabel As System.Windows.Forms.Label
        Dim Lugar_destinoLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.Fecha_origenDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_destinoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_origenTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_destinoTextBox = New System.Windows.Forms.TextBox()
        Me.ViajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVehiculos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        IdChoferLabel = New System.Windows.Forms.Label()
        IdSociosLabel = New System.Windows.Forms.Label()
        Fecha_origenLabel = New System.Windows.Forms.Label()
        Fecha_destinoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Lugar_origenLabel = New System.Windows.Forms.Label()
        Lugar_destinoLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(66, 46)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 3
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdSociosLabel
        '
        IdSociosLabel.AutoSize = True
        IdSociosLabel.Location = New System.Drawing.Point(66, 72)
        IdSociosLabel.Name = "IdSociosLabel"
        IdSociosLabel.Size = New System.Drawing.Size(53, 13)
        IdSociosLabel.TabIndex = 5
        IdSociosLabel.Text = "id Socios:"
        '
        'Fecha_origenLabel
        '
        Fecha_origenLabel.AutoSize = True
        Fecha_origenLabel.Location = New System.Drawing.Point(67, 138)
        Fecha_origenLabel.Name = "Fecha_origenLabel"
        Fecha_origenLabel.Size = New System.Drawing.Size(69, 13)
        Fecha_origenLabel.TabIndex = 7
        Fecha_origenLabel.Text = "fecha origen:"
        '
        'Fecha_destinoLabel
        '
        Fecha_destinoLabel.AutoSize = True
        Fecha_destinoLabel.Location = New System.Drawing.Point(67, 164)
        Fecha_destinoLabel.Name = "Fecha_destinoLabel"
        Fecha_destinoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_destinoLabel.TabIndex = 9
        Fecha_destinoLabel.Text = "fecha destino:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(66, 199)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 11
        TotalLabel.Text = "Total:"
        '
        'Lugar_origenLabel
        '
        Lugar_origenLabel.AutoSize = True
        Lugar_origenLabel.Location = New System.Drawing.Point(66, 225)
        Lugar_origenLabel.Name = "Lugar_origenLabel"
        Lugar_origenLabel.Size = New System.Drawing.Size(65, 13)
        Lugar_origenLabel.TabIndex = 13
        Lugar_origenLabel.Text = "lugar origen:"
        '
        'Lugar_destinoLabel
        '
        Lugar_destinoLabel.AutoSize = True
        Lugar_destinoLabel.Location = New System.Drawing.Point(66, 251)
        Lugar_destinoLabel.Name = "Lugar_destinoLabel"
        Lugar_destinoLabel.Size = New System.Drawing.Size(70, 13)
        Lugar_destinoLabel.TabIndex = 15
        Lugar_destinoLabel.Text = "lugar destino:"
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
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'Fecha_origenDateTimePicker
        '
        Me.Fecha_origenDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_origen", True))
        Me.Fecha_origenDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Fecha_origenDateTimePicker.Location = New System.Drawing.Point(147, 134)
        Me.Fecha_origenDateTimePicker.Name = "Fecha_origenDateTimePicker"
        Me.Fecha_origenDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Fecha_origenDateTimePicker.TabIndex = 8
        '
        'Fecha_destinoDateTimePicker
        '
        Me.Fecha_destinoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_destino", True))
        Me.Fecha_destinoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Fecha_destinoDateTimePicker.Location = New System.Drawing.Point(147, 160)
        Me.Fecha_destinoDateTimePicker.Name = "Fecha_destinoDateTimePicker"
        Me.Fecha_destinoDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Fecha_destinoDateTimePicker.TabIndex = 10
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(146, 196)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(106, 20)
        Me.TotalTextBox.TabIndex = 12
        '
        'Lugar_origenTextBox
        '
        Me.Lugar_origenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_origen", True))
        Me.Lugar_origenTextBox.Location = New System.Drawing.Point(146, 222)
        Me.Lugar_origenTextBox.Name = "Lugar_origenTextBox"
        Me.Lugar_origenTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Lugar_origenTextBox.TabIndex = 14
        '
        'Lugar_destinoTextBox
        '
        Me.Lugar_destinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_destino", True))
        Me.Lugar_destinoTextBox.Location = New System.Drawing.Point(146, 248)
        Me.Lugar_destinoTextBox.Name = "Lugar_destinoTextBox"
        Me.Lugar_destinoTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Lugar_destinoTextBox.TabIndex = 16
        '
        'ViajesDataGridView
        '
        Me.ViajesDataGridView.AutoGenerateColumns = False
        Me.ViajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.idVehiculos, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ViajesDataGridView.DataSource = Me.ViajesBindingSource
        Me.ViajesDataGridView.Location = New System.Drawing.Point(12, 325)
        Me.ViajesDataGridView.Name = "ViajesDataGridView"
        Me.ViajesDataGridView.Size = New System.Drawing.Size(973, 220)
        Me.ViajesDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'idVehiculos
        '
        Me.idVehiculos.DataPropertyName = "idVehiculos"
        Me.idVehiculos.HeaderText = "idVehiculos"
        Me.idVehiculos.Name = "idVehiculos"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idChofer"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idChofer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idSocios"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idSocios"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha_origen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha_origen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha_destino"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fecha_destino"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "lugar_origen"
        Me.DataGridViewTextBoxColumn7.HeaderText = "lugar_origen"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "lugar_destino"
        Me.DataGridViewTextBoxColumn8.HeaderText = "lugar_destino"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(640, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(751, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(751, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "id Vehiculo:"
        '
        'ComboBoxChofer
        '
        Me.ComboBoxChofer.DataSource = Me.ChoferBindingSource
        Me.ComboBoxChofer.DisplayMember = "id_chofer"
        Me.ComboBoxChofer.FormattingEnabled = True
        Me.ComboBoxChofer.Location = New System.Drawing.Point(146, 42)
        Me.ComboBoxChofer.Name = "ComboBoxChofer"
        Me.ComboBoxChofer.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxChofer.TabIndex = 23
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
        Me.ComboBoxSocios.Location = New System.Drawing.Point(146, 69)
        Me.ComboBoxSocios.Name = "ComboBoxSocios"
        Me.ComboBoxSocios.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxSocios.TabIndex = 24
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
        Me.ComboBoxVehiculo.Location = New System.Drawing.Point(146, 97)
        Me.ComboBoxVehiculo.Name = "ComboBoxVehiculo"
        Me.ComboBoxVehiculo.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxVehiculo.TabIndex = 25
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
        Me.CheckBoxReserva.Location = New System.Drawing.Point(320, 176)
        Me.CheckBoxReserva.Name = "CheckBoxReserva"
        Me.CheckBoxReserva.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxReserva.TabIndex = 26
        Me.CheckBoxReserva.Text = "Reserva"
        Me.CheckBoxReserva.UseVisualStyleBackColor = True
        '
        'viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.CheckBoxReserva)
        Me.Controls.Add(Me.ComboBoxVehiculo)
        Me.Controls.Add(Me.ComboBoxSocios)
        Me.Controls.Add(Me.ComboBoxChofer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ViajesDataGridView)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(IdSociosLabel)
        Me.Controls.Add(Fecha_origenLabel)
        Me.Controls.Add(Me.Fecha_origenDateTimePicker)
        Me.Controls.Add(Fecha_destinoLabel)
        Me.Controls.Add(Me.Fecha_destinoDateTimePicker)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Lugar_origenLabel)
        Me.Controls.Add(Me.Lugar_origenTextBox)
        Me.Controls.Add(Lugar_destinoLabel)
        Me.Controls.Add(Me.Lugar_destinoTextBox)
        Me.Name = "viajes"
        Me.Text = "viajes"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Fecha_origenDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_destinoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lugar_origenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lugar_destinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idVehiculos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
