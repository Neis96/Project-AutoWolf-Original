<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liquidacion_Choferes
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
        Me.ViajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxDueno = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDueno = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxTotChofer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTotAgencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLiquidar = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPorcent = New System.Windows.Forms.TextBox()
        Me.ValoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValoresTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ValoresTableAdapter()
        Me.LiquidacionChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiquidacionChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter()
        Me.ResumenRemiseriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenRemiseriaTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ResumenRemiseriaTableAdapter()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenRemiseriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViajesDataGridView
        '
        Me.ViajesDataGridView.AutoGenerateColumns = False
        Me.ViajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ViajesDataGridView.DataSource = Me.ViajesBindingSource
        Me.ViajesDataGridView.Location = New System.Drawing.Point(59, 220)
        Me.ViajesDataGridView.Name = "ViajesDataGridView"
        Me.ViajesDataGridView.Size = New System.Drawing.Size(1243, 287)
        Me.ViajesDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Chofer"
        '
        'CheckBoxDueno
        '
        Me.CheckBoxDueno.AutoSize = True
        Me.CheckBoxDueno.Location = New System.Drawing.Point(59, 142)
        Me.CheckBoxDueno.Name = "CheckBoxDueno"
        Me.CheckBoxDueno.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxDueno.TabIndex = 6
        Me.CheckBoxDueno.Text = "Dueño"
        Me.CheckBoxDueno.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hasta"
        '
        'ComboBoxDueno
        '
        Me.ComboBoxDueno.FormattingEnabled = True
        Me.ComboBoxDueno.Location = New System.Drawing.Point(115, 39)
        Me.ComboBoxDueno.Name = "ComboBoxDueno"
        Me.ComboBoxDueno.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDueno.TabIndex = 14
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(327, 40)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePickerDesde.TabIndex = 15
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(324, 79)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePickerHasta.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Total:"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(96, 177)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotal.TabIndex = 18
        '
        'TextBoxTotChofer
        '
        Me.TextBoxTotChofer.Location = New System.Drawing.Point(267, 177)
        Me.TextBoxTotChofer.Name = "TextBoxTotChofer"
        Me.TextBoxTotChofer.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotChofer.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Chofer:"
        '
        'TextBoxTotAgencia
        '
        Me.TextBoxTotAgencia.Location = New System.Drawing.Point(433, 177)
        Me.TextBoxTotAgencia.Name = "TextBoxTotAgencia"
        Me.TextBoxTotAgencia.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotAgencia.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Agencia:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(115, 79)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxNombre.TabIndex = 23
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(477, 43)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 24
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(477, 81)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 25
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnLiquidar
        '
        Me.BtnLiquidar.Location = New System.Drawing.Point(595, 70)
        Me.BtnLiquidar.Name = "BtnLiquidar"
        Me.BtnLiquidar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLiquidar.TabIndex = 26
        Me.BtnLiquidar.Text = "Liquidar"
        Me.BtnLiquidar.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idVehiculos"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idVehiculos"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Reserva"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Reserva"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cta_cte"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cta_cte"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
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
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Porcentaje"
        '
        'TextBoxPorcent
        '
        Me.TextBoxPorcent.Location = New System.Drawing.Point(115, 114)
        Me.TextBoxPorcent.Name = "TextBoxPorcent"
        Me.TextBoxPorcent.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxPorcent.TabIndex = 28
        '
        'ValoresBindingSource
        '
        Me.ValoresBindingSource.DataMember = "Valores"
        Me.ValoresBindingSource.DataSource = Me.Database1DataSet
        '
        'ValoresTableAdapter
        '
        Me.ValoresTableAdapter.ClearBeforeFill = True
        '
        'LiquidacionChoferBindingSource
        '
        Me.LiquidacionChoferBindingSource.DataMember = "LiquidacionChofer"
        Me.LiquidacionChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'LiquidacionChoferTableAdapter
        '
        Me.LiquidacionChoferTableAdapter.ClearBeforeFill = True
        '
        'ResumenRemiseriaBindingSource
        '
        Me.ResumenRemiseriaBindingSource.DataMember = "ResumenRemiseria"
        Me.ResumenRemiseriaBindingSource.DataSource = Me.Database1DataSet
        '
        'ResumenRemiseriaTableAdapter
        '
        Me.ResumenRemiseriaTableAdapter.ClearBeforeFill = True
        '
        'Liquidacion_Choferes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 527)
        Me.Controls.Add(Me.TextBoxPorcent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnLiquidar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxTotAgencia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxTotChofer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePickerHasta)
        Me.Controls.Add(Me.DateTimePickerDesde)
        Me.Controls.Add(Me.ComboBoxDueno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxDueno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViajesDataGridView)
        Me.Name = "Liquidacion_Choferes"
        Me.Text = "Liquidacion_Choferes"
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenRemiseriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ViajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDueno As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDueno As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotChofer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnLiquidar As System.Windows.Forms.Button
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPorcent As System.Windows.Forms.TextBox
    Friend WithEvents ValoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValoresTableAdapter As pruebaBD.Database1DataSetTableAdapters.ValoresTableAdapter
    Friend WithEvents LiquidacionChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LiquidacionChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter
    Friend WithEvents ResumenRemiseriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenRemiseriaTableAdapter As pruebaBD.Database1DataSetTableAdapters.ResumenRemiseriaTableAdapter
End Class
