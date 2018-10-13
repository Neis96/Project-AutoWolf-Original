<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroUsuario
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
        Dim AdministradorLabel As System.Windows.Forms.Label
        Dim Usuarios_Label As System.Windows.Forms.Label
        Dim ContraseñasLabel As System.Windows.Forms.Label
        Dim Nombre_Label As System.Windows.Forms.Label
        Dim Apelllido_Label As System.Windows.Forms.Label
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.AdministradorTextBox = New System.Windows.Forms.TextBox()
        Me.Usuarios_TextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñasTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_TextBox = New System.Windows.Forms.TextBox()
        Me.Apelllido_TextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtEliminar = New System.Windows.Forms.Button()
        Me.UsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AdministradorLabel = New System.Windows.Forms.Label()
        Usuarios_Label = New System.Windows.Forms.Label()
        ContraseñasLabel = New System.Windows.Forms.Label()
        Nombre_Label = New System.Windows.Forms.Label()
        Apelllido_Label = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdministradorLabel
        '
        AdministradorLabel.AutoSize = True
        AdministradorLabel.Location = New System.Drawing.Point(109, 92)
        AdministradorLabel.Name = "AdministradorLabel"
        AdministradorLabel.Size = New System.Drawing.Size(72, 13)
        AdministradorLabel.TabIndex = 1
        AdministradorLabel.Text = "administrador:"
        '
        'Usuarios_Label
        '
        Usuarios_Label.AutoSize = True
        Usuarios_Label.Location = New System.Drawing.Point(109, 118)
        Usuarios_Label.Name = "Usuarios_Label"
        Usuarios_Label.Size = New System.Drawing.Size(52, 13)
        Usuarios_Label.TabIndex = 3
        Usuarios_Label.Text = "usuarios :"
        '
        'ContraseñasLabel
        '
        ContraseñasLabel.AutoSize = True
        ContraseñasLabel.Location = New System.Drawing.Point(109, 144)
        ContraseñasLabel.Name = "ContraseñasLabel"
        ContraseñasLabel.Size = New System.Drawing.Size(68, 13)
        ContraseñasLabel.TabIndex = 5
        ContraseñasLabel.Text = "contraseñas:"
        '
        'Nombre_Label
        '
        Nombre_Label.AutoSize = True
        Nombre_Label.Location = New System.Drawing.Point(109, 170)
        Nombre_Label.Name = "Nombre_Label"
        Nombre_Label.Size = New System.Drawing.Size(48, 13)
        Nombre_Label.TabIndex = 7
        Nombre_Label.Text = "nombre :"
        '
        'Apelllido_Label
        '
        Apelllido_Label.AutoSize = True
        Apelllido_Label.Location = New System.Drawing.Point(109, 196)
        Apelllido_Label.Name = "Apelllido_Label"
        Apelllido_Label.Size = New System.Drawing.Size(51, 13)
        Apelllido_Label.TabIndex = 9
        Apelllido_Label.Text = "apelllido :"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.Database1DataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'AdministradorTextBox
        '
        Me.AdministradorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "administrador", True))
        Me.AdministradorTextBox.Location = New System.Drawing.Point(187, 89)
        Me.AdministradorTextBox.Name = "AdministradorTextBox"
        Me.AdministradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdministradorTextBox.TabIndex = 2
        '
        'Usuarios_TextBox
        '
        Me.Usuarios_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "usuarios ", True))
        Me.Usuarios_TextBox.Location = New System.Drawing.Point(187, 115)
        Me.Usuarios_TextBox.Name = "Usuarios_TextBox"
        Me.Usuarios_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Usuarios_TextBox.TabIndex = 4
        '
        'ContraseñasTextBox
        '
        Me.ContraseñasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "contraseñas", True))
        Me.ContraseñasTextBox.Location = New System.Drawing.Point(187, 141)
        Me.ContraseñasTextBox.Name = "ContraseñasTextBox"
        Me.ContraseñasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñasTextBox.TabIndex = 6
        '
        'Nombre_TextBox
        '
        Me.Nombre_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombre ", True))
        Me.Nombre_TextBox.Location = New System.Drawing.Point(187, 167)
        Me.Nombre_TextBox.Name = "Nombre_TextBox"
        Me.Nombre_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_TextBox.TabIndex = 8
        '
        'Apelllido_TextBox
        '
        Me.Apelllido_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "apelllido ", True))
        Me.Apelllido_TextBox.Location = New System.Drawing.Point(187, 193)
        Me.Apelllido_TextBox.Name = "Apelllido_TextBox"
        Me.Apelllido_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apelllido_TextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtEliminar
        '
        Me.ButtEliminar.Location = New System.Drawing.Point(239, 260)
        Me.ButtEliminar.Name = "ButtEliminar"
        Me.ButtEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtEliminar.TabIndex = 12
        Me.ButtEliminar.Text = "Eliminar"
        Me.ButtEliminar.UseVisualStyleBackColor = True
        '
        'UsuarioDataGridView
        '
        Me.UsuarioDataGridView.AutoGenerateColumns = False
        Me.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.UsuarioDataGridView.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGridView.Location = New System.Drawing.Point(14, 319)
        Me.UsuarioDataGridView.Name = "UsuarioDataGridView"
        Me.UsuarioDataGridView.Size = New System.Drawing.Size(547, 220)
        Me.UsuarioDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "administrador"
        Me.DataGridViewTextBoxColumn1.HeaderText = "administrador"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "usuarios "
        Me.DataGridViewTextBoxColumn2.HeaderText = "usuarios "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "contraseñas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "contraseñas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre "
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre "
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "apelllido "
        Me.DataGridViewTextBoxColumn5.HeaderText = "apelllido "
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'RegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 596)
        Me.Controls.Add(Me.UsuarioDataGridView)
        Me.Controls.Add(Me.ButtEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(AdministradorLabel)
        Me.Controls.Add(Me.AdministradorTextBox)
        Me.Controls.Add(Usuarios_Label)
        Me.Controls.Add(Me.Usuarios_TextBox)
        Me.Controls.Add(ContraseñasLabel)
        Me.Controls.Add(Me.ContraseñasTextBox)
        Me.Controls.Add(Nombre_Label)
        Me.Controls.Add(Me.Nombre_TextBox)
        Me.Controls.Add(Apelllido_Label)
        Me.Controls.Add(Me.Apelllido_TextBox)
        Me.Name = "RegistroUsuario"
        Me.Text = "RegistroUsuario"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdministradorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Usuarios_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apelllido_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtEliminar As System.Windows.Forms.Button
    Friend WithEvents UsuarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
