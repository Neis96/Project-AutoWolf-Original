<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarChofer
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
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Id_choferLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ChoferDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_choferComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Id_choferLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(48, 345)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(72, 17)
        TelefonoLabel.TabIndex = 1
        TelefonoLabel.Text = "telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(48, 371)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(79, 17)
        DireccionLabel.TabIndex = 3
        DireccionLabel.Text = "direccion:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DniLabel.Location = New System.Drawing.Point(48, 397)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(35, 17)
        DniLabel.TabIndex = 5
        DniLabel.Text = "dni:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(48, 423)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(67, 17)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(48, 449)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(70, 17)
        ApellidoLabel.TabIndex = 9
        ApellidoLabel.Text = "apellido:"
        '
        'Id_choferLabel
        '
        Id_choferLabel.AutoSize = True
        Id_choferLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_choferLabel.Location = New System.Drawing.Point(48, 318)
        Id_choferLabel.Name = "Id_choferLabel"
        Id_choferLabel.Size = New System.Drawing.Size(77, 17)
        Id_choferLabel.TabIndex = 11
        Id_choferLabel.Text = "id chofer:"
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
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
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
        'ChoferDataGridView
        '
        Me.ChoferDataGridView.AutoGenerateColumns = False
        Me.ChoferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChoferDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ChoferDataGridView.DataSource = Me.ChoferBindingSource
        Me.ChoferDataGridView.Location = New System.Drawing.Point(30, 56)
        Me.ChoferDataGridView.Name = "ChoferDataGridView"
        Me.ChoferDataGridView.Size = New System.Drawing.Size(658, 220)
        Me.ChoferDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_chofer"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_chofer"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn5.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dni"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dni"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn1.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(131, 344)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TelefonoTextBox.TabIndex = 2
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(131, 370)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DireccionTextBox.TabIndex = 4
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(131, 396)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DniTextBox.TabIndex = 6
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(131, 422)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NombreTextBox.TabIndex = 8
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(131, 448)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ApellidoTextBox.TabIndex = 10
        '
        'Id_choferComboBox
        '
        Me.Id_choferComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "id_chofer", True))
        Me.Id_choferComboBox.FormattingEnabled = True
        Me.Id_choferComboBox.Location = New System.Drawing.Point(131, 317)
        Me.Id_choferComboBox.Name = "Id_choferComboBox"
        Me.Id_choferComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Id_choferComboBox.TabIndex = 12
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_editar_archivo_64
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(366, 321)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(74, 69)
        Me.BtnModificar.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "MODIFICAR")
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_basura_64
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(551, 317)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(105, 69)
        Me.BtnEliminar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "ELIMINAR")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_izquierda_en_círculo_2_64
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnVolver.FlatAppearance.BorderSize = 0
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Location = New System.Drawing.Point(581, 451)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 72)
        Me.BtnVolver.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BtnVolver, "VOLVER")
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'ModificarChofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(719, 563)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Id_choferLabel)
        Me.Controls.Add(Me.Id_choferComboBox)
        Me.Controls.Add(Me.ChoferDataGridView)
        Me.Name = "ModificarChofer"
        Me.Text = "ModificarChofer"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChoferDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_choferComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
