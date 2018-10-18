<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socios
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.ButAgregar = New System.Windows.Forms.Button()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SociosTableAdapter = New pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.TextBoxtelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxdireccion = New System.Windows.Forms.TextBox()
        Me.TextBoxDni = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxNombr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxconsultasocio = New System.Windows.Forms.TextBox()
        Me.SociosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(37, 34)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 31
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(37, 60)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 32
        ApellidoLabel.Text = "apellido:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(37, 86)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(24, 13)
        DniLabel.TabIndex = 33
        DniLabel.Text = "dni:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(37, 112)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 34
        DireccionLabel.Text = "direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(37, 139)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 35
        TelefonoLabel.Text = "telefono:"
        '
        'ButAgregar
        '
        Me.ButAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButAgregar.Location = New System.Drawing.Point(225, 69)
        Me.ButAgregar.Name = "ButAgregar"
        Me.ButAgregar.Size = New System.Drawing.Size(119, 30)
        Me.ButAgregar.TabIndex = 0
        Me.ButAgregar.Text = "Agregar"
        Me.ButAgregar.UseVisualStyleBackColor = True
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "Socios"
        Me.SociosBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(563, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 40)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Me.SociosTableAdapter
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario1TableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'TextBoxtelefono
        '
        Me.TextBoxtelefono.Location = New System.Drawing.Point(88, 136)
        Me.TextBoxtelefono.Name = "TextBoxtelefono"
        Me.TextBoxtelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxtelefono.TabIndex = 43
        '
        'TextBoxdireccion
        '
        Me.TextBoxdireccion.Location = New System.Drawing.Point(88, 110)
        Me.TextBoxdireccion.Name = "TextBoxdireccion"
        Me.TextBoxdireccion.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxdireccion.TabIndex = 42
        '
        'TextBoxDni
        '
        Me.TextBoxDni.Location = New System.Drawing.Point(88, 84)
        Me.TextBoxDni.Name = "TextBoxDni"
        Me.TextBoxDni.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDni.TabIndex = 41
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(88, 58)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxApellido.TabIndex = 40
        '
        'TextBoxNombr
        '
        Me.TextBoxNombr.Location = New System.Drawing.Point(88, 31)
        Me.TextBoxNombr.Name = "TextBoxNombr"
        Me.TextBoxNombr.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombr.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Label1"
        '
        'TextBoxconsultasocio
        '
        Me.TextBoxconsultasocio.Location = New System.Drawing.Point(82, 213)
        Me.TextBoxconsultasocio.Name = "TextBoxconsultasocio"
        Me.TextBoxconsultasocio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxconsultasocio.TabIndex = 37
        '
        'SociosDataGridView
        '
        Me.SociosDataGridView.AutoGenerateColumns = False
        Me.SociosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SociosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.SociosDataGridView.DataSource = Me.SociosBindingSource
        Me.SociosDataGridView.Location = New System.Drawing.Point(12, 243)
        Me.SociosDataGridView.Name = "SociosDataGridView"
        Me.SociosDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.SociosDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_socio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_socio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dni"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dni"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn6.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 24)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 482)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBoxtelefono)
        Me.Controls.Add(Me.TextBoxdireccion)
        Me.Controls.Add(Me.TextBoxDni)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.TextBoxNombr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxconsultasocio)
        Me.Controls.Add(Me.SociosDataGridView)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButAgregar)
        Me.Name = "Socios"
        Me.Text = "Nuevo Socio"
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButAgregar As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents SociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SociosTableAdapter As pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBoxtelefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxdireccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDni As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxApellido As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxconsultasocio As System.Windows.Forms.TextBox
    Friend WithEvents SociosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
