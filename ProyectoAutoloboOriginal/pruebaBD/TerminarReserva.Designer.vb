<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminarReserva
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
        Dim IdVehiculosLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ViajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdSociosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_origenDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_destinoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Lugar_origenTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_destinoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.Id_choferComboBox = New System.Windows.Forms.ComboBox()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculoTableAdapter = New pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter()
        Me.Id_vehiculoComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        IdChoferLabel = New System.Windows.Forms.Label()
        IdSociosLabel = New System.Windows.Forms.Label()
        Fecha_origenLabel = New System.Windows.Forms.Label()
        Fecha_destinoLabel = New System.Windows.Forms.Label()
        Lugar_origenLabel = New System.Windows.Forms.Label()
        Lugar_destinoLabel = New System.Windows.Forms.Label()
        IdVehiculosLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(147, 269)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 0
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
        Me.TableAdapterManager.ChoferTableAdapter = Me.ChoferTableAdapter
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Me.VehiculoTableAdapter
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'ViajesDataGridView
        '
        Me.ViajesDataGridView.AutoGenerateColumns = False
        Me.ViajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11})
        Me.ViajesDataGridView.DataSource = Me.ViajesBindingSource
        Me.ViajesDataGridView.Location = New System.Drawing.Point(100, 62)
        Me.ViajesDataGridView.Name = "ViajesDataGridView"
        Me.ViajesDataGridView.Size = New System.Drawing.Size(610, 132)
        Me.ViajesDataGridView.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Registro"
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(67, 325)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 8
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdSociosLabel
        '
        IdSociosLabel.AutoSize = True
        IdSociosLabel.Location = New System.Drawing.Point(67, 299)
        IdSociosLabel.Name = "IdSociosLabel"
        IdSociosLabel.Size = New System.Drawing.Size(53, 13)
        IdSociosLabel.TabIndex = 10
        IdSociosLabel.Text = "id Socios:"
        '
        'IdSociosTextBox
        '
        Me.IdSociosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "idSocios", True))
        Me.IdSociosTextBox.Location = New System.Drawing.Point(147, 296)
        Me.IdSociosTextBox.Name = "IdSociosTextBox"
        Me.IdSociosTextBox.Size = New System.Drawing.Size(110, 20)
        Me.IdSociosTextBox.TabIndex = 11
        '
        'Fecha_origenLabel
        '
        Fecha_origenLabel.AutoSize = True
        Fecha_origenLabel.Location = New System.Drawing.Point(67, 381)
        Fecha_origenLabel.Name = "Fecha_origenLabel"
        Fecha_origenLabel.Size = New System.Drawing.Size(69, 13)
        Fecha_origenLabel.TabIndex = 12
        Fecha_origenLabel.Text = "fecha origen:"
        '
        'Fecha_origenDateTimePicker
        '
        Me.Fecha_origenDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_origen", True))
        Me.Fecha_origenDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Fecha_origenDateTimePicker.Location = New System.Drawing.Point(147, 378)
        Me.Fecha_origenDateTimePicker.Name = "Fecha_origenDateTimePicker"
        Me.Fecha_origenDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.Fecha_origenDateTimePicker.TabIndex = 13
        '
        'Fecha_destinoLabel
        '
        Fecha_destinoLabel.AutoSize = True
        Fecha_destinoLabel.Location = New System.Drawing.Point(67, 407)
        Fecha_destinoLabel.Name = "Fecha_destinoLabel"
        Fecha_destinoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_destinoLabel.TabIndex = 14
        Fecha_destinoLabel.Text = "fecha destino:"
        '
        'Fecha_destinoDateTimePicker
        '
        Me.Fecha_destinoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_destino", True))
        Me.Fecha_destinoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Fecha_destinoDateTimePicker.Location = New System.Drawing.Point(147, 404)
        Me.Fecha_destinoDateTimePicker.Name = "Fecha_destinoDateTimePicker"
        Me.Fecha_destinoDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.Fecha_destinoDateTimePicker.TabIndex = 15
        '
        'Lugar_origenLabel
        '
        Lugar_origenLabel.AutoSize = True
        Lugar_origenLabel.Location = New System.Drawing.Point(67, 436)
        Lugar_origenLabel.Name = "Lugar_origenLabel"
        Lugar_origenLabel.Size = New System.Drawing.Size(65, 13)
        Lugar_origenLabel.TabIndex = 18
        Lugar_origenLabel.Text = "lugar origen:"
        '
        'Lugar_origenTextBox
        '
        Me.Lugar_origenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_origen", True))
        Me.Lugar_origenTextBox.Location = New System.Drawing.Point(147, 433)
        Me.Lugar_origenTextBox.Name = "Lugar_origenTextBox"
        Me.Lugar_origenTextBox.Size = New System.Drawing.Size(110, 20)
        Me.Lugar_origenTextBox.TabIndex = 19
        '
        'Lugar_destinoLabel
        '
        Lugar_destinoLabel.AutoSize = True
        Lugar_destinoLabel.Location = New System.Drawing.Point(67, 462)
        Lugar_destinoLabel.Name = "Lugar_destinoLabel"
        Lugar_destinoLabel.Size = New System.Drawing.Size(70, 13)
        Lugar_destinoLabel.TabIndex = 20
        Lugar_destinoLabel.Text = "lugar destino:"
        '
        'Lugar_destinoTextBox
        '
        Me.Lugar_destinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_destino", True))
        Me.Lugar_destinoTextBox.Location = New System.Drawing.Point(147, 459)
        Me.Lugar_destinoTextBox.Name = "Lugar_destinoTextBox"
        Me.Lugar_destinoTextBox.Size = New System.Drawing.Size(110, 20)
        Me.Lugar_destinoTextBox.TabIndex = 21
        '
        'IdVehiculosLabel
        '
        IdVehiculosLabel.AutoSize = True
        IdVehiculosLabel.Location = New System.Drawing.Point(67, 354)
        IdVehiculosLabel.Name = "IdVehiculosLabel"
        IdVehiculosLabel.Size = New System.Drawing.Size(67, 13)
        IdVehiculosLabel.TabIndex = 22
        IdVehiculosLabel.Text = "id Vehiculos:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(67, 493)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 28
        EstadoLabel.Text = "Estado:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 487)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idSocios"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Socio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha_origen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha origen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha_destino"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fecha destino"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "lugar_origen"
        Me.DataGridViewTextBoxColumn7.HeaderText = "lugar origen"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "lugar_destino"
        Me.DataGridViewTextBoxColumn8.HeaderText = "lugar destino"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cta_cte"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cta cte"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(391, 280)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(112, 51)
        Me.BtnActualizar.TabIndex = 30
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(391, 351)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(112, 53)
        Me.BtnEliminar.TabIndex = 31
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "Chofer"
        Me.ChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'Id_choferComboBox
        '
        Me.Id_choferComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "id_chofer", True))
        Me.Id_choferComboBox.FormattingEnabled = True
        Me.Id_choferComboBox.Location = New System.Drawing.Point(147, 322)
        Me.Id_choferComboBox.Name = "Id_choferComboBox"
        Me.Id_choferComboBox.Size = New System.Drawing.Size(110, 21)
        Me.Id_choferComboBox.TabIndex = 32
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Database1DataSet
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'Id_vehiculoComboBox
        '
        Me.Id_vehiculoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "id_vehiculo", True))
        Me.Id_vehiculoComboBox.FormattingEnabled = True
        Me.Id_vehiculoComboBox.Location = New System.Drawing.Point(147, 351)
        Me.Id_vehiculoComboBox.Name = "Id_vehiculoComboBox"
        Me.Id_vehiculoComboBox.Size = New System.Drawing.Size(110, 21)
        Me.Id_vehiculoComboBox.TabIndex = 33
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(663, 468)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 62)
        Me.BtnVolver.TabIndex = 34
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'TerminarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 553)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.Id_vehiculoComboBox)
        Me.Controls.Add(Me.Id_choferComboBox)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(IdSociosLabel)
        Me.Controls.Add(Me.IdSociosTextBox)
        Me.Controls.Add(Fecha_origenLabel)
        Me.Controls.Add(Me.Fecha_origenDateTimePicker)
        Me.Controls.Add(Fecha_destinoLabel)
        Me.Controls.Add(Me.Fecha_destinoDateTimePicker)
        Me.Controls.Add(Lugar_origenLabel)
        Me.Controls.Add(Me.Lugar_origenTextBox)
        Me.Controls.Add(Lugar_destinoLabel)
        Me.Controls.Add(Me.Lugar_destinoTextBox)
        Me.Controls.Add(IdVehiculosLabel)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViajesDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "TerminarReserva"
        Me.Text = "TerminarReserva"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ViajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdSociosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_origenDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_destinoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lugar_origenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lugar_destinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents Id_choferComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Id_vehiculoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
End Class
