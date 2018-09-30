<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas))
        Dim Nro_ReservaLabel As System.Windows.Forms.Label
        Dim Id_socioLabel As System.Windows.Forms.Label
        Dim SalidaLabel As System.Windows.Forms.Label
        Dim LlegadaLabel As System.Windows.Forms.Label
        Dim Hs_pedidoLabel As System.Windows.Forms.Label
        Dim Hs_salidaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ReservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservaTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ReservaTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ReservaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ReservaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ReservaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_ReservaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_socioTextBox = New System.Windows.Forms.TextBox()
        Me.SalidaTextBox = New System.Windows.Forms.TextBox()
        Me.LlegadaTextBox = New System.Windows.Forms.TextBox()
        Me.Hs_pedidoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hs_salidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Nro_ReservaLabel = New System.Windows.Forms.Label()
        Id_socioLabel = New System.Windows.Forms.Label()
        SalidaLabel = New System.Windows.Forms.Label()
        LlegadaLabel = New System.Windows.Forms.Label()
        Hs_pedidoLabel = New System.Windows.Forms.Label()
        Hs_salidaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReservaBindingNavigator.SuspendLayout()
        CType(Me.ReservaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(412, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservaBindingSource
        '
        Me.ReservaBindingSource.DataMember = "Reserva"
        Me.ReservaBindingSource.DataSource = Me.Database1DataSet
        '
        'ReservaTableAdapter
        '
        Me.ReservaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.ReservaTableAdapter = Me.ReservaTableAdapter
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'ReservaBindingNavigator
        '
        Me.ReservaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReservaBindingNavigator.BindingSource = Me.ReservaBindingSource
        Me.ReservaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReservaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReservaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReservaBindingNavigatorSaveItem})
        Me.ReservaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReservaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReservaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReservaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReservaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReservaBindingNavigator.Name = "ReservaBindingNavigator"
        Me.ReservaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReservaBindingNavigator.Size = New System.Drawing.Size(1034, 25)
        Me.ReservaBindingNavigator.TabIndex = 3
        Me.ReservaBindingNavigator.Text = "BindingNavigator1"
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
        'ReservaBindingNavigatorSaveItem
        '
        Me.ReservaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReservaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReservaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReservaBindingNavigatorSaveItem.Name = "ReservaBindingNavigatorSaveItem"
        Me.ReservaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ReservaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ReservaDataGridView
        '
        Me.ReservaDataGridView.AutoGenerateColumns = False
        Me.ReservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ReservaDataGridView.DataSource = Me.ReservaBindingSource
        Me.ReservaDataGridView.Location = New System.Drawing.Point(47, 325)
        Me.ReservaDataGridView.Name = "ReservaDataGridView"
        Me.ReservaDataGridView.Size = New System.Drawing.Size(748, 153)
        Me.ReservaDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nro_Reserva"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro_Reserva"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_socio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_socio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "salida"
        Me.DataGridViewTextBoxColumn3.HeaderText = "salida"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "llegada"
        Me.DataGridViewTextBoxColumn4.HeaderText = "llegada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "hs_pedido"
        Me.DataGridViewTextBoxColumn5.HeaderText = "hs_pedido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "hs_salida"
        Me.DataGridViewTextBoxColumn6.HeaderText = "hs_salida"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Nro_ReservaLabel
        '
        Nro_ReservaLabel.AutoSize = True
        Nro_ReservaLabel.Location = New System.Drawing.Point(76, 81)
        Nro_ReservaLabel.Name = "Nro_ReservaLabel"
        Nro_ReservaLabel.Size = New System.Drawing.Size(70, 13)
        Nro_ReservaLabel.TabIndex = 5
        Nro_ReservaLabel.Text = "Nro Reserva:"
        '
        'Nro_ReservaTextBox
        '
        Me.Nro_ReservaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaBindingSource, "Nro_Reserva", True))
        Me.Nro_ReservaTextBox.Location = New System.Drawing.Point(152, 78)
        Me.Nro_ReservaTextBox.Name = "Nro_ReservaTextBox"
        Me.Nro_ReservaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nro_ReservaTextBox.TabIndex = 6
        '
        'Id_socioLabel
        '
        Id_socioLabel.AutoSize = True
        Id_socioLabel.Location = New System.Drawing.Point(76, 107)
        Id_socioLabel.Name = "Id_socioLabel"
        Id_socioLabel.Size = New System.Drawing.Size(46, 13)
        Id_socioLabel.TabIndex = 7
        Id_socioLabel.Text = "id socio:"
        '
        'Id_socioTextBox
        '
        Me.Id_socioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaBindingSource, "id_socio", True))
        Me.Id_socioTextBox.Location = New System.Drawing.Point(152, 104)
        Me.Id_socioTextBox.Name = "Id_socioTextBox"
        Me.Id_socioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_socioTextBox.TabIndex = 8
        '
        'SalidaLabel
        '
        SalidaLabel.AutoSize = True
        SalidaLabel.Location = New System.Drawing.Point(76, 133)
        SalidaLabel.Name = "SalidaLabel"
        SalidaLabel.Size = New System.Drawing.Size(37, 13)
        SalidaLabel.TabIndex = 9
        SalidaLabel.Text = "salida:"
        '
        'SalidaTextBox
        '
        Me.SalidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaBindingSource, "salida", True))
        Me.SalidaTextBox.Location = New System.Drawing.Point(152, 130)
        Me.SalidaTextBox.Name = "SalidaTextBox"
        Me.SalidaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalidaTextBox.TabIndex = 10
        '
        'LlegadaLabel
        '
        LlegadaLabel.AutoSize = True
        LlegadaLabel.Location = New System.Drawing.Point(76, 159)
        LlegadaLabel.Name = "LlegadaLabel"
        LlegadaLabel.Size = New System.Drawing.Size(44, 13)
        LlegadaLabel.TabIndex = 11
        LlegadaLabel.Text = "llegada:"
        '
        'LlegadaTextBox
        '
        Me.LlegadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaBindingSource, "llegada", True))
        Me.LlegadaTextBox.Location = New System.Drawing.Point(152, 156)
        Me.LlegadaTextBox.Name = "LlegadaTextBox"
        Me.LlegadaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LlegadaTextBox.TabIndex = 12
        '
        'Hs_pedidoLabel
        '
        Hs_pedidoLabel.AutoSize = True
        Hs_pedidoLabel.Location = New System.Drawing.Point(76, 186)
        Hs_pedidoLabel.Name = "Hs_pedidoLabel"
        Hs_pedidoLabel.Size = New System.Drawing.Size(56, 13)
        Hs_pedidoLabel.TabIndex = 13
        Hs_pedidoLabel.Text = "hs pedido:"
        '
        'Hs_pedidoDateTimePicker
        '
        Me.Hs_pedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservaBindingSource, "hs_pedido", True))
        Me.Hs_pedidoDateTimePicker.Location = New System.Drawing.Point(152, 182)
        Me.Hs_pedidoDateTimePicker.Name = "Hs_pedidoDateTimePicker"
        Me.Hs_pedidoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Hs_pedidoDateTimePicker.TabIndex = 14
        '
        'Hs_salidaLabel
        '
        Hs_salidaLabel.AutoSize = True
        Hs_salidaLabel.Location = New System.Drawing.Point(76, 212)
        Hs_salidaLabel.Name = "Hs_salidaLabel"
        Hs_salidaLabel.Size = New System.Drawing.Size(51, 13)
        Hs_salidaLabel.TabIndex = 15
        Hs_salidaLabel.Text = "hs salida:"
        '
        'Hs_salidaDateTimePicker
        '
        Me.Hs_salidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservaBindingSource, "hs_salida", True))
        Me.Hs_salidaDateTimePicker.Location = New System.Drawing.Point(152, 208)
        Me.Hs_salidaDateTimePicker.Name = "Hs_salidaDateTimePicker"
        Me.Hs_salidaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Hs_salidaDateTimePicker.TabIndex = 16
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(76, 238)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 17
        FechaLabel.Text = "fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservaBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(152, 234)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 18
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(829, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 498)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Nro_ReservaLabel)
        Me.Controls.Add(Me.Nro_ReservaTextBox)
        Me.Controls.Add(Id_socioLabel)
        Me.Controls.Add(Me.Id_socioTextBox)
        Me.Controls.Add(SalidaLabel)
        Me.Controls.Add(Me.SalidaTextBox)
        Me.Controls.Add(LlegadaLabel)
        Me.Controls.Add(Me.LlegadaTextBox)
        Me.Controls.Add(Hs_pedidoLabel)
        Me.Controls.Add(Me.Hs_pedidoDateTimePicker)
        Me.Controls.Add(Hs_salidaLabel)
        Me.Controls.Add(Me.Hs_salidaDateTimePicker)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.ReservaDataGridView)
        Me.Controls.Add(Me.ReservaBindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "reservas"
        Me.Text = "reservas"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReservaBindingNavigator.ResumeLayout(False)
        Me.ReservaBindingNavigator.PerformLayout()
        CType(Me.ReservaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ReservaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservaTableAdapter As pruebaBD.Database1DataSetTableAdapters.ReservaTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReservaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ReservaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReservaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_ReservaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_socioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LlegadaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hs_pedidoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hs_salidaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
