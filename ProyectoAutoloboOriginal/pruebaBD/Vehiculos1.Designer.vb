<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehiculos1
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
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Dim SeguroLabel As System.Windows.Forms.Label
        Dim Venc_gnc_Label As System.Windows.Forms.Label
        Dim Venc_vtvLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim DueñoLabel As System.Windows.Forms.Label
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.VehiculoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehiculoTableAdapter = New pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.DateTimePickerVtv = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerAno = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerGnc = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxSeguro = New System.Windows.Forms.TextBox()
        Me.TextBoxDueno = New System.Windows.Forms.TextBox()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.TextBoxDominio = New System.Windows.Forms.TextBox()
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        SeguroLabel = New System.Windows.Forms.Label()
        Venc_gnc_Label = New System.Windows.Forms.Label()
        Venc_vtvLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        DueñoLabel = New System.Windows.Forms.Label()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxConsulta
        '
        Me.TextBoxConsulta.Location = New System.Drawing.Point(133, 324)
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        Me.TextBoxConsulta.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxConsulta.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Consultar por dominio:"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(979, 62)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 31
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(384, 322)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 29
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(243, 168)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(139, 60)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehiculoDataGridView
        '
        Me.VehiculoDataGridView.AutoGenerateColumns = False
        Me.VehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiculoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.VehiculoDataGridView.DataSource = Me.VehiculoBindingSource
        Me.VehiculoDataGridView.Location = New System.Drawing.Point(12, 369)
        Me.VehiculoDataGridView.Name = "VehiculoDataGridView"
        Me.VehiculoDataGridView.Size = New System.Drawing.Size(1049, 220)
        Me.VehiculoDataGridView.TabIndex = 52
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "id_vehiculo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "id_vehiculo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dominio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "dominio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "año"
        Me.DataGridViewTextBoxColumn3.HeaderText = "año"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "color"
        Me.DataGridViewTextBoxColumn8.HeaderText = "color"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "dueño"
        Me.DataGridViewTextBoxColumn9.HeaderText = "dueño"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "seguro"
        Me.DataGridViewTextBoxColumn5.HeaderText = "seguro"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "venc_gnc "
        Me.DataGridViewTextBoxColumn6.HeaderText = "venc_gnc "
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "venc_vtv"
        Me.DataGridViewTextBoxColumn7.HeaderText = "venc_vtv"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Me.VehiculoTableAdapter
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Location = New System.Drawing.Point(284, 322)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsulta.TabIndex = 70
        Me.BtnConsulta.Text = "Consultar"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'DateTimePickerVtv
        '
        Me.DateTimePickerVtv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerVtv.Location = New System.Drawing.Point(282, 98)
        Me.DateTimePickerVtv.Name = "DateTimePickerVtv"
        Me.DateTimePickerVtv.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePickerVtv.TabIndex = 115
        '
        'DateTimePickerAno
        '
        Me.DateTimePickerAno.CustomFormat = "yyyy"
        Me.DateTimePickerAno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerAno.Location = New System.Drawing.Point(83, 153)
        Me.DateTimePickerAno.Name = "DateTimePickerAno"
        Me.DateTimePickerAno.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePickerAno.TabIndex = 114
        '
        'DateTimePickerGnc
        '
        Me.DateTimePickerGnc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerGnc.Location = New System.Drawing.Point(282, 72)
        Me.DateTimePickerGnc.Name = "DateTimePickerGnc"
        Me.DateTimePickerGnc.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePickerGnc.TabIndex = 113
        '
        'TextBoxSeguro
        '
        Me.TextBoxSeguro.Location = New System.Drawing.Point(282, 46)
        Me.TextBoxSeguro.Name = "TextBoxSeguro"
        Me.TextBoxSeguro.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSeguro.TabIndex = 112
        '
        'TextBoxDueno
        '
        Me.TextBoxDueno.Location = New System.Drawing.Point(83, 208)
        Me.TextBoxDueno.Name = "TextBoxDueno"
        Me.TextBoxDueno.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDueno.TabIndex = 111
        '
        'TextBoxColor
        '
        Me.TextBoxColor.Location = New System.Drawing.Point(83, 181)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxColor.TabIndex = 110
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(83, 120)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxModelo.TabIndex = 109
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(83, 82)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMarca.TabIndex = 108
        '
        'TextBoxDominio
        '
        Me.TextBoxDominio.Location = New System.Drawing.Point(83, 49)
        Me.TextBoxDominio.Name = "TextBoxDominio"
        Me.TextBoxDominio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDominio.TabIndex = 107
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(32, 120)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 98
        ModeloLabel.Text = "modelo:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(30, 82)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 99
        MarcaLabel.Text = "marca:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(32, 153)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(28, 13)
        AñoLabel.TabIndex = 100
        AñoLabel.Text = "año:"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Location = New System.Drawing.Point(30, 49)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(46, 13)
        DominioLabel.TabIndex = 101
        DominioLabel.Text = "dominio:"
        '
        'SeguroLabel
        '
        SeguroLabel.AutoSize = True
        SeguroLabel.Location = New System.Drawing.Point(224, 49)
        SeguroLabel.Name = "SeguroLabel"
        SeguroLabel.Size = New System.Drawing.Size(42, 13)
        SeguroLabel.TabIndex = 102
        SeguroLabel.Text = "seguro:"
        '
        'Venc_gnc_Label
        '
        Venc_gnc_Label.AutoSize = True
        Venc_gnc_Label.Location = New System.Drawing.Point(224, 78)
        Venc_gnc_Label.Name = "Venc_gnc_Label"
        Venc_gnc_Label.Size = New System.Drawing.Size(58, 13)
        Venc_gnc_Label.TabIndex = 103
        Venc_gnc_Label.Text = "venc gnc :"
        '
        'Venc_vtvLabel
        '
        Venc_vtvLabel.AutoSize = True
        Venc_vtvLabel.Location = New System.Drawing.Point(224, 98)
        Venc_vtvLabel.Name = "Venc_vtvLabel"
        Venc_vtvLabel.Size = New System.Drawing.Size(52, 13)
        Venc_vtvLabel.TabIndex = 104
        Venc_vtvLabel.Text = "venc vtv:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(32, 181)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(33, 13)
        ColorLabel.TabIndex = 105
        ColorLabel.Text = "color:"
        '
        'DueñoLabel
        '
        DueñoLabel.AutoSize = True
        DueñoLabel.Location = New System.Drawing.Point(32, 207)
        DueñoLabel.Name = "DueñoLabel"
        DueñoLabel.Size = New System.Drawing.Size(40, 13)
        DueñoLabel.TabIndex = 106
        DueñoLabel.Text = "dueño:"
        '
        'Vehiculos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 601)
        Me.Controls.Add(Me.DateTimePickerVtv)
        Me.Controls.Add(Me.DateTimePickerAno)
        Me.Controls.Add(Me.DateTimePickerGnc)
        Me.Controls.Add(Me.TextBoxSeguro)
        Me.Controls.Add(Me.TextBoxDueno)
        Me.Controls.Add(Me.TextBoxColor)
        Me.Controls.Add(Me.TextBoxModelo)
        Me.Controls.Add(Me.TextBoxMarca)
        Me.Controls.Add(Me.TextBoxDominio)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(SeguroLabel)
        Me.Controls.Add(Venc_gnc_Label)
        Me.Controls.Add(Venc_vtvLabel)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(DueñoLabel)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.VehiculoDataGridView)
        Me.Controls.Add(Me.TextBoxConsulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "Vehiculos1"
        Me.Text = "Vehiculos1"
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiculoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePickerVtv As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerAno As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerGnc As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxSeguro As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDueno As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxColor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxModelo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMarca As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDominio As System.Windows.Forms.TextBox
End Class
