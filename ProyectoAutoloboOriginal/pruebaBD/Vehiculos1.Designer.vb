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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehiculos1))
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.VehiculoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VehiculoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VehiculoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.SeguroTextBox = New System.Windows.Forms.TextBox()
        Me.Venc_gnc_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Venc_vtvDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.DueñoTextBox = New System.Windows.Forms.TextBox()
        Me.VehiculoTableAdapter = New pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.BtnConsulta = New System.Windows.Forms.Button()
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
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        SeguroLabel = New System.Windows.Forms.Label()
        Venc_gnc_Label = New System.Windows.Forms.Label()
        Venc_vtvLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        DueñoLabel = New System.Windows.Forms.Label()
        CType(Me.VehiculoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehiculoBindingNavigator.SuspendLayout()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(27, 130)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 52
        ModeloLabel.Text = "modelo:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(25, 92)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 54
        MarcaLabel.Text = "marca:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(27, 163)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(28, 13)
        AñoLabel.TabIndex = 56
        AñoLabel.Text = "año:"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Location = New System.Drawing.Point(25, 59)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(46, 13)
        DominioLabel.TabIndex = 58
        DominioLabel.Text = "dominio:"
        '
        'SeguroLabel
        '
        SeguroLabel.AutoSize = True
        SeguroLabel.Location = New System.Drawing.Point(317, 59)
        SeguroLabel.Name = "SeguroLabel"
        SeguroLabel.Size = New System.Drawing.Size(42, 13)
        SeguroLabel.TabIndex = 60
        SeguroLabel.Text = "seguro:"
        '
        'Venc_gnc_Label
        '
        Venc_gnc_Label.AutoSize = True
        Venc_gnc_Label.Location = New System.Drawing.Point(317, 86)
        Venc_gnc_Label.Name = "Venc_gnc_Label"
        Venc_gnc_Label.Size = New System.Drawing.Size(58, 13)
        Venc_gnc_Label.TabIndex = 62
        Venc_gnc_Label.Text = "venc gnc :"
        '
        'Venc_vtvLabel
        '
        Venc_vtvLabel.AutoSize = True
        Venc_vtvLabel.Location = New System.Drawing.Point(317, 112)
        Venc_vtvLabel.Name = "Venc_vtvLabel"
        Venc_vtvLabel.Size = New System.Drawing.Size(52, 13)
        Venc_vtvLabel.TabIndex = 64
        Venc_vtvLabel.Text = "venc vtv:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(27, 191)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(33, 13)
        ColorLabel.TabIndex = 66
        ColorLabel.Text = "color:"
        '
        'DueñoLabel
        '
        DueñoLabel.AutoSize = True
        DueñoLabel.Location = New System.Drawing.Point(27, 217)
        DueñoLabel.Name = "DueñoLabel"
        DueñoLabel.Size = New System.Drawing.Size(40, 13)
        DueñoLabel.TabIndex = 68
        DueñoLabel.Text = "dueño:"
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
        Me.BtnAgregar.Location = New System.Drawing.Point(370, 174)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(139, 60)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'VehiculoBindingNavigator
        '
        Me.VehiculoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VehiculoBindingNavigator.BindingSource = Me.VehiculoBindingSource
        Me.VehiculoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VehiculoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VehiculoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VehiculoBindingNavigatorSaveItem})
        Me.VehiculoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VehiculoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehiculoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehiculoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehiculoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehiculoBindingNavigator.Name = "VehiculoBindingNavigator"
        Me.VehiculoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VehiculoBindingNavigator.Size = New System.Drawing.Size(1082, 25)
        Me.VehiculoBindingNavigator.TabIndex = 52
        Me.VehiculoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VehiculoBindingNavigatorSaveItem
        '
        Me.VehiculoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehiculoBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehiculoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehiculoBindingNavigatorSaveItem.Name = "VehiculoBindingNavigatorSaveItem"
        Me.VehiculoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VehiculoBindingNavigatorSaveItem.Text = "Guardar datos"
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
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(94, 127)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(194, 20)
        Me.ModeloTextBox.TabIndex = 53
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(92, 89)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(194, 20)
        Me.MarcaTextBox.TabIndex = 55
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(94, 159)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(194, 20)
        Me.AñoDateTimePicker.TabIndex = 57
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Location = New System.Drawing.Point(92, 56)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(194, 20)
        Me.DominioTextBox.TabIndex = 59
        '
        'SeguroTextBox
        '
        Me.SeguroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "seguro", True))
        Me.SeguroTextBox.Location = New System.Drawing.Point(384, 56)
        Me.SeguroTextBox.Name = "SeguroTextBox"
        Me.SeguroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SeguroTextBox.TabIndex = 61
        '
        'Venc_gnc_DateTimePicker
        '
        Me.Venc_gnc_DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "venc_gnc ", True))
        Me.Venc_gnc_DateTimePicker.Location = New System.Drawing.Point(384, 82)
        Me.Venc_gnc_DateTimePicker.Name = "Venc_gnc_DateTimePicker"
        Me.Venc_gnc_DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Venc_gnc_DateTimePicker.TabIndex = 63
        '
        'Venc_vtvDateTimePicker
        '
        Me.Venc_vtvDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "venc_vtv", True))
        Me.Venc_vtvDateTimePicker.Location = New System.Drawing.Point(384, 108)
        Me.Venc_vtvDateTimePicker.Name = "Venc_vtvDateTimePicker"
        Me.Venc_vtvDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Venc_vtvDateTimePicker.TabIndex = 65
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(94, 188)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 67
        '
        'DueñoTextBox
        '
        Me.DueñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dueño", True))
        Me.DueñoTextBox.Location = New System.Drawing.Point(94, 214)
        Me.DueñoTextBox.Name = "DueñoTextBox"
        Me.DueñoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DueñoTextBox.TabIndex = 69
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        ' Me.TableAdapterManager.ReservaTableAdapter = Nothing
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
        'Vehiculos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 601)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(Me.DominioTextBox)
        Me.Controls.Add(SeguroLabel)
        Me.Controls.Add(Me.SeguroTextBox)
        Me.Controls.Add(Venc_gnc_Label)
        Me.Controls.Add(Me.Venc_gnc_DateTimePicker)
        Me.Controls.Add(Venc_vtvLabel)
        Me.Controls.Add(Me.Venc_vtvDateTimePicker)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(DueñoLabel)
        Me.Controls.Add(Me.DueñoTextBox)
        Me.Controls.Add(Me.VehiculoDataGridView)
        Me.Controls.Add(Me.VehiculoBindingNavigator)
        Me.Controls.Add(Me.TextBoxConsulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "Vehiculos1"
        Me.Text = "Vehiculos1"
        CType(Me.VehiculoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehiculoBindingNavigator.ResumeLayout(False)
        Me.VehiculoBindingNavigator.PerformLayout()
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
    Friend WithEvents VehiculoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VehiculoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VehiculoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeguroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Venc_gnc_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Venc_vtvDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DueñoTextBox As System.Windows.Forms.TextBox
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
End Class
