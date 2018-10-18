<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liquidacion_Chofer
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
        Me.ComboBoxDueno = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxPorcent = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnLiquidar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxTotAgencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTotChofer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxDueno = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.LiquidacionChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter()
        Me.ResumenRemiseriaTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ResumenRemiseriaTableAdapter()
        Me.ValoresTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ValoresTableAdapter()
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.LiquidacionChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenRemiseriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenRemiseriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxDueno
        '
        Me.ComboBoxDueno.DisplayMember = "id_chofer"
        Me.ComboBoxDueno.FormattingEnabled = True
        Me.ComboBoxDueno.Location = New System.Drawing.Point(86, 27)
        Me.ComboBoxDueno.Name = "ComboBoxDueno"
        Me.ComboBoxDueno.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDueno.TabIndex = 50
        Me.ComboBoxDueno.ValueMember = "id_chofer"
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.DateTimePickerHasta.Enabled = False
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(278, 66)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(147, 20)
        Me.DateTimePickerHasta.TabIndex = 49
        '
        'TextBoxPorcent
        '
        Me.TextBoxPorcent.Location = New System.Drawing.Point(86, 102)
        Me.TextBoxPorcent.Name = "TextBoxPorcent"
        Me.TextBoxPorcent.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxPorcent.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Porcentaje"
        '
        'BtnLiquidar
        '
        Me.BtnLiquidar.Location = New System.Drawing.Point(552, 163)
        Me.BtnLiquidar.Name = "BtnLiquidar"
        Me.BtnLiquidar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLiquidar.TabIndex = 46
        Me.BtnLiquidar.Text = "Liquidar"
        Me.BtnLiquidar.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(448, 69)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 45
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(448, 31)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 44
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxNombre.Location = New System.Drawing.Point(86, 67)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxNombre.TabIndex = 43
        '
        'TextBoxTotAgencia
        '
        Me.TextBoxTotAgencia.Enabled = False
        Me.TextBoxTotAgencia.Location = New System.Drawing.Point(404, 165)
        Me.TextBoxTotAgencia.Name = "TextBoxTotAgencia"
        Me.TextBoxTotAgencia.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotAgencia.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Agencia:"
        '
        'TextBoxTotChofer
        '
        Me.TextBoxTotChofer.Enabled = False
        Me.TextBoxTotChofer.Location = New System.Drawing.Point(238, 165)
        Me.TextBoxTotChofer.Name = "TextBoxTotChofer"
        Me.TextBoxTotChofer.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotChofer.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Chofer:"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Enabled = False
        Me.TextBoxTotal.Location = New System.Drawing.Point(67, 165)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotal.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Total:"
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(281, 27)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePickerDesde.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre"
        '
        'CheckBoxDueno
        '
        Me.CheckBoxDueno.AutoSize = True
        Me.CheckBoxDueno.Location = New System.Drawing.Point(30, 130)
        Me.CheckBoxDueno.Name = "CheckBoxDueno"
        Me.CheckBoxDueno.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxDueno.TabIndex = 32
        Me.CheckBoxDueno.Text = "Dueño"
        Me.CheckBoxDueno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ID Chofer"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Me.ChoferTableAdapter
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Me.LiquidacionChoferTableAdapter
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Me.ResumenRemiseriaTableAdapter
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Me.ValoresTableAdapter
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'LiquidacionChoferTableAdapter
        '
        Me.LiquidacionChoferTableAdapter.ClearBeforeFill = True
        '
        'ResumenRemiseriaTableAdapter
        '
        Me.ResumenRemiseriaTableAdapter.ClearBeforeFill = True
        '
        'ValoresTableAdapter
        '
        Me.ValoresTableAdapter.ClearBeforeFill = True
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'LiquidacionChoferBindingSource
        '
        Me.LiquidacionChoferBindingSource.DataMember = "LiquidacionChofer"
        Me.LiquidacionChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'ResumenRemiseriaBindingSource
        '
        Me.ResumenRemiseriaBindingSource.DataMember = "ResumenRemiseria"
        Me.ResumenRemiseriaBindingSource.DataSource = Me.Database1DataSet
        '
        'ValoresBindingSource
        '
        Me.ValoresBindingSource.DataMember = "Valores"
        Me.ValoresBindingSource.DataSource = Me.Database1DataSet
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "Viajes"
        Me.ViajesBindingSource.DataSource = Me.Database1DataSet
        '
        'ViajesDataGridView
        '
        Me.ViajesDataGridView.AutoGenerateColumns = False
        Me.ViajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn12})
        Me.ViajesDataGridView.DataSource = Me.ViajesBindingSource
        Me.ViajesDataGridView.Location = New System.Drawing.Point(14, 212)
        Me.ViajesDataGridView.Name = "ViajesDataGridView"
        Me.ViajesDataGridView.Size = New System.Drawing.Size(744, 287)
        Me.ViajesDataGridView.TabIndex = 51
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
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idVehiculos"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idVehiculos"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
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
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Liquidacion_Chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 518)
        Me.Controls.Add(Me.ViajesDataGridView)
        Me.Controls.Add(Me.ComboBoxDueno)
        Me.Controls.Add(Me.DateTimePickerHasta)
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
        Me.Controls.Add(Me.DateTimePickerDesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxDueno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Liquidacion_Chofer"
        Me.Text = "Liquidacion_Chofer"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenRemiseriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxDueno As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxPorcent As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnLiquidar As System.Windows.Forms.Button
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotChofer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDueno As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LiquidacionChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter
    Friend WithEvents LiquidacionChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenRemiseriaTableAdapter As pruebaBD.Database1DataSetTableAdapters.ResumenRemiseriaTableAdapter
    Friend WithEvents ResumenRemiseriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValoresTableAdapter As pruebaBD.Database1DataSetTableAdapters.ValoresTableAdapter
    Friend WithEvents ValoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
