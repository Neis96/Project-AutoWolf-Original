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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viajes))
        Dim RegistroLabel As System.Windows.Forms.Label
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
        Me.ViajesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ViajesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistroTextBox = New System.Windows.Forms.TextBox()
        Me.IdChoferTextBox = New System.Windows.Forms.TextBox()
        Me.IdSociosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_origenDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_destinoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_origenTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_destinoTextBox = New System.Windows.Forms.TextBox()
        Me.ViajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        RegistroLabel = New System.Windows.Forms.Label()
        IdChoferLabel = New System.Windows.Forms.Label()
        IdSociosLabel = New System.Windows.Forms.Label()
        Fecha_origenLabel = New System.Windows.Forms.Label()
        Fecha_destinoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Lugar_origenLabel = New System.Windows.Forms.Label()
        Lugar_destinoLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViajesBindingNavigator.SuspendLayout()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        ' Me.TableAdapterManager.ReservaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'ViajesBindingNavigator
        '
        Me.ViajesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ViajesBindingNavigator.BindingSource = Me.ViajesBindingSource
        Me.ViajesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ViajesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ViajesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ViajesBindingNavigatorSaveItem})
        Me.ViajesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ViajesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ViajesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ViajesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ViajesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ViajesBindingNavigator.Name = "ViajesBindingNavigator"
        Me.ViajesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ViajesBindingNavigator.Size = New System.Drawing.Size(975, 25)
        Me.ViajesBindingNavigator.TabIndex = 0
        Me.ViajesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ViajesBindingNavigatorSaveItem
        '
        Me.ViajesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViajesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ViajesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ViajesBindingNavigatorSaveItem.Name = "ViajesBindingNavigatorSaveItem"
        Me.ViajesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ViajesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'RegistroLabel
        '
        RegistroLabel.AutoSize = True
        RegistroLabel.Location = New System.Drawing.Point(66, 55)
        RegistroLabel.Name = "RegistroLabel"
        RegistroLabel.Size = New System.Drawing.Size(49, 13)
        RegistroLabel.TabIndex = 1
        RegistroLabel.Text = "Registro:"
        '
        'RegistroTextBox
        '
        Me.RegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "Registro", True))
        Me.RegistroTextBox.Location = New System.Drawing.Point(146, 52)
        Me.RegistroTextBox.Name = "RegistroTextBox"
        Me.RegistroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RegistroTextBox.TabIndex = 2
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(66, 81)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 3
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdChoferTextBox
        '
        Me.IdChoferTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "idChofer", True))
        Me.IdChoferTextBox.Location = New System.Drawing.Point(146, 78)
        Me.IdChoferTextBox.Name = "IdChoferTextBox"
        Me.IdChoferTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdChoferTextBox.TabIndex = 4
        '
        'IdSociosLabel
        '
        IdSociosLabel.AutoSize = True
        IdSociosLabel.Location = New System.Drawing.Point(66, 107)
        IdSociosLabel.Name = "IdSociosLabel"
        IdSociosLabel.Size = New System.Drawing.Size(53, 13)
        IdSociosLabel.TabIndex = 5
        IdSociosLabel.Text = "id Socios:"
        '
        'IdSociosTextBox
        '
        Me.IdSociosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "idSocios", True))
        Me.IdSociosTextBox.Location = New System.Drawing.Point(146, 104)
        Me.IdSociosTextBox.Name = "IdSociosTextBox"
        Me.IdSociosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdSociosTextBox.TabIndex = 6
        '
        'Fecha_origenLabel
        '
        Fecha_origenLabel.AutoSize = True
        Fecha_origenLabel.Location = New System.Drawing.Point(66, 134)
        Fecha_origenLabel.Name = "Fecha_origenLabel"
        Fecha_origenLabel.Size = New System.Drawing.Size(69, 13)
        Fecha_origenLabel.TabIndex = 7
        Fecha_origenLabel.Text = "fecha origen:"
        '
        'Fecha_origenDateTimePicker
        '
        Me.Fecha_origenDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_origen", True))
        Me.Fecha_origenDateTimePicker.Location = New System.Drawing.Point(146, 130)
        Me.Fecha_origenDateTimePicker.Name = "Fecha_origenDateTimePicker"
        Me.Fecha_origenDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_origenDateTimePicker.TabIndex = 8
        '
        'Fecha_destinoLabel
        '
        Fecha_destinoLabel.AutoSize = True
        Fecha_destinoLabel.Location = New System.Drawing.Point(66, 160)
        Fecha_destinoLabel.Name = "Fecha_destinoLabel"
        Fecha_destinoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_destinoLabel.TabIndex = 9
        Fecha_destinoLabel.Text = "fecha destino:"
        '
        'Fecha_destinoDateTimePicker
        '
        Me.Fecha_destinoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_destino", True))
        Me.Fecha_destinoDateTimePicker.Location = New System.Drawing.Point(146, 156)
        Me.Fecha_destinoDateTimePicker.Name = "Fecha_destinoDateTimePicker"
        Me.Fecha_destinoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_destinoDateTimePicker.TabIndex = 10
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(66, 185)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 11
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(146, 182)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 12
        '
        'Lugar_origenLabel
        '
        Lugar_origenLabel.AutoSize = True
        Lugar_origenLabel.Location = New System.Drawing.Point(66, 211)
        Lugar_origenLabel.Name = "Lugar_origenLabel"
        Lugar_origenLabel.Size = New System.Drawing.Size(65, 13)
        Lugar_origenLabel.TabIndex = 13
        Lugar_origenLabel.Text = "lugar origen:"
        '
        'Lugar_origenTextBox
        '
        Me.Lugar_origenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_origen", True))
        Me.Lugar_origenTextBox.Location = New System.Drawing.Point(146, 208)
        Me.Lugar_origenTextBox.Name = "Lugar_origenTextBox"
        Me.Lugar_origenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Lugar_origenTextBox.TabIndex = 14
        '
        'Lugar_destinoLabel
        '
        Lugar_destinoLabel.AutoSize = True
        Lugar_destinoLabel.Location = New System.Drawing.Point(66, 237)
        Lugar_destinoLabel.Name = "Lugar_destinoLabel"
        Lugar_destinoLabel.Size = New System.Drawing.Size(70, 13)
        Lugar_destinoLabel.TabIndex = 15
        Lugar_destinoLabel.Text = "lugar destino:"
        '
        'Lugar_destinoTextBox
        '
        Me.Lugar_destinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "lugar_destino", True))
        Me.Lugar_destinoTextBox.Location = New System.Drawing.Point(146, 234)
        Me.Lugar_destinoTextBox.Name = "Lugar_destinoTextBox"
        Me.Lugar_destinoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Lugar_destinoTextBox.TabIndex = 16
        '
        'ViajesDataGridView
        '
        Me.ViajesDataGridView.AutoGenerateColumns = False
        Me.ViajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ViajesDataGridView.DataSource = Me.ViajesBindingSource
        Me.ViajesDataGridView.Location = New System.Drawing.Point(37, 318)
        Me.ViajesDataGridView.Name = "ViajesDataGridView"
        Me.ViajesDataGridView.Size = New System.Drawing.Size(851, 220)
        Me.ViajesDataGridView.TabIndex = 17
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(434, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(556, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(434, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(826, 45)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 570)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ViajesDataGridView)
        Me.Controls.Add(RegistroLabel)
        Me.Controls.Add(Me.RegistroTextBox)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(Me.IdChoferTextBox)
        Me.Controls.Add(IdSociosLabel)
        Me.Controls.Add(Me.IdSociosTextBox)
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
        Me.Controls.Add(Me.ViajesBindingNavigator)
        Me.Name = "viajes"
        Me.Text = "viajes"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViajesBindingNavigator.ResumeLayout(False)
        Me.ViajesBindingNavigator.PerformLayout()
        CType(Me.ViajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ViajesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ViajesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RegistroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdChoferTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdSociosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_origenDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_destinoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lugar_origenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lugar_destinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
