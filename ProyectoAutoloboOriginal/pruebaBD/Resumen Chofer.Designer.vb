<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resumen_Chofer
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
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxDueno = New System.Windows.Forms.ComboBox()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LiquidacionChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiquidacionChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.LiquidacionChoferDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionChoferDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_calculadora_filled_50
        Me.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCalcular.FlatAppearance.BorderSize = 0
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Location = New System.Drawing.Point(477, 112)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 49)
        Me.BtnCalcular.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.BtnCalcular, "CALCULAR")
        Me.BtnCalcular.UseCompatibleTextRendering = True
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_google_web_search_64
        Me.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnConsultar.FlatAppearance.BorderSize = 0
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Location = New System.Drawing.Point(477, 20)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 62)
        Me.BtnConsultar.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.BtnConsultar, "CONSULTAR")
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Enabled = False
        Me.TextBoxTotal.Location = New System.Drawing.Point(80, 112)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotal.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Total:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxNombre.Location = New System.Drawing.Point(80, 62)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.ReadOnly = True
        Me.TextBoxNombre.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxNombre.TabIndex = 43
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.DateTimePickerHasta.Enabled = False
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(268, 62)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(147, 20)
        Me.DateTimePickerHasta.TabIndex = 42
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(271, 23)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(75, 20)
        Me.DateTimePickerDesde.TabIndex = 41
        '
        'ComboBoxDueno
        '
        Me.ComboBoxDueno.DataSource = Me.ChoferBindingSource
        Me.ComboBoxDueno.DisplayMember = "id_chofer"
        Me.ComboBoxDueno.FormattingEnabled = True
        Me.ComboBoxDueno.Location = New System.Drawing.Point(80, 22)
        Me.ComboBoxDueno.Name = "ComboBoxDueno"
        Me.ComboBoxDueno.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDueno.TabIndex = 40
        Me.ComboBoxDueno.ValueMember = "id_chofer"
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "Chofer"
        Me.ChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID Chofer"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Me.ChoferTableAdapter
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Me.LiquidacionChoferTableAdapter
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
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'LiquidacionChoferDataGridView
        '
        Me.LiquidacionChoferDataGridView.AutoGenerateColumns = False
        Me.LiquidacionChoferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LiquidacionChoferDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LiquidacionChoferDataGridView.DataSource = Me.LiquidacionChoferBindingSource
        Me.LiquidacionChoferDataGridView.Location = New System.Drawing.Point(25, 192)
        Me.LiquidacionChoferDataGridView.Name = "LiquidacionChoferDataGridView"
        Me.LiquidacionChoferDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.LiquidacionChoferDataGridView.TabIndex = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_chofer"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_chofer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Desde"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Desde"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Hasta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hasta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Resumen_Chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(709, 435)
        Me.Controls.Add(Me.LiquidacionChoferDataGridView)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.DateTimePickerHasta)
        Me.Controls.Add(Me.DateTimePickerDesde)
        Me.Controls.Add(Me.ComboBoxDueno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resumen_Chofer"
        Me.Text = "Resumen_Chofer"
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionChoferDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxDueno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents LiquidacionChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LiquidacionChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LiquidacionChoferDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
