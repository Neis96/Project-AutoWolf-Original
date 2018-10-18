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
        Dim TipoLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtEliminar = New System.Windows.Forms.Button()
        Me.ComboBoxtipo = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.Usuario1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usuario1TableAdapter = New pruebaBD.Database1DataSetTableAdapters.Usuario1TableAdapter()
        Me.Usuario1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TipoLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(111, 187)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(27, 13)
        TipoLabel.TabIndex = 27
        TipoLabel.Text = "tipo:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(88, 139)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(63, 13)
        ContraseñaLabel.TabIndex = 28
        ContraseñaLabel.Text = "contraseña:"
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Location = New System.Drawing.Point(83, 90)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(55, 13)
        Id_usuarioLabel.TabIndex = 29
        Id_usuarioLabel.Text = "id usuario:"
        '
        'ComboBoxtipo
        '
        Me.ComboBoxtipo.FormattingEnabled = True
        Me.ComboBoxtipo.Location = New System.Drawing.Point(173, 179)
        Me.ComboBoxtipo.Name = "ComboBoxtipo"
        Me.ComboBoxtipo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxtipo.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(173, 132)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
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
        Me.TableAdapterManager.Usuario1TableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'Usuario1BindingSource
        '
        Me.Usuario1BindingSource.DataMember = "Usuario1"
        Me.Usuario1BindingSource.DataSource = Me.Database1DataSet
        '
        'Usuario1TableAdapter
        '
        Me.Usuario1TableAdapter.ClearBeforeFill = True
        '
        'Usuario1DataGridView
        '
        Me.Usuario1DataGridView.AutoGenerateColumns = False
        Me.Usuario1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Usuario1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Usuario1DataGridView.DataSource = Me.Usuario1BindingSource
        Me.Usuario1DataGridView.Location = New System.Drawing.Point(62, 343)
        Me.Usuario1DataGridView.Name = "Usuario1DataGridView"
        Me.Usuario1DataGridView.Size = New System.Drawing.Size(351, 220)
        Me.Usuario1DataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "contraseña"
        Me.DataGridViewTextBoxColumn2.HeaderText = "contraseña"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'RegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 621)
        Me.Controls.Add(Me.Usuario1DataGridView)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Id_usuarioLabel)
        Me.Controls.Add(Me.ComboBoxtipo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Name = "RegistroUsuario"
        Me.Text = "RegistroUsuario"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtEliminar As System.Windows.Forms.Button
    Friend WithEvents ComboBoxtipo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Usuario1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usuario1TableAdapter As pruebaBD.Database1DataSetTableAdapters.Usuario1TableAdapter
    Friend WithEvents Usuario1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
