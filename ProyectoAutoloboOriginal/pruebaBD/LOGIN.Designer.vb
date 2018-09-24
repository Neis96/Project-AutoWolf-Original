<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.AdministradorTextBox = New System.Windows.Forms.TextBox()
        Me.Usuarios_TextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñasTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_TextBox = New System.Windows.Forms.TextBox()
        Me.Apelllido_TextBox = New System.Windows.Forms.TextBox()
        Me.Buttonregistro = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
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
        Me.UsuarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsuarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        AdministradorLabel = New System.Windows.Forms.Label()
        Usuarios_Label = New System.Windows.Forms.Label()
        ContraseñasLabel = New System.Windows.Forms.Label()
        Nombre_Label = New System.Windows.Forms.Label()
        Apelllido_Label = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuarioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdministradorLabel
        '
        AdministradorLabel.AutoSize = True
        AdministradorLabel.Location = New System.Drawing.Point(184, 91)
        AdministradorLabel.Name = "AdministradorLabel"
        AdministradorLabel.Size = New System.Drawing.Size(72, 13)
        AdministradorLabel.TabIndex = 1
        AdministradorLabel.Text = "administrador:"
        '
        'Usuarios_Label
        '
        Usuarios_Label.AutoSize = True
        Usuarios_Label.Location = New System.Drawing.Point(184, 117)
        Usuarios_Label.Name = "Usuarios_Label"
        Usuarios_Label.Size = New System.Drawing.Size(52, 13)
        Usuarios_Label.TabIndex = 3
        Usuarios_Label.Text = "usuarios :"
        '
        'ContraseñasLabel
        '
        ContraseñasLabel.AutoSize = True
        ContraseñasLabel.Location = New System.Drawing.Point(184, 143)
        ContraseñasLabel.Name = "ContraseñasLabel"
        ContraseñasLabel.Size = New System.Drawing.Size(68, 13)
        ContraseñasLabel.TabIndex = 5
        ContraseñasLabel.Text = "contraseñas:"
        '
        'Nombre_Label
        '
        Nombre_Label.AutoSize = True
        Nombre_Label.Location = New System.Drawing.Point(184, 169)
        Nombre_Label.Name = "Nombre_Label"
        Nombre_Label.Size = New System.Drawing.Size(48, 13)
        Nombre_Label.TabIndex = 7
        Nombre_Label.Text = "nombre :"
        '
        'Apelllido_Label
        '
        Apelllido_Label.AutoSize = True
        Apelllido_Label.Location = New System.Drawing.Point(184, 195)
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
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'AdministradorTextBox
        '
        Me.AdministradorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "administrador", True))
        Me.AdministradorTextBox.Location = New System.Drawing.Point(262, 88)
        Me.AdministradorTextBox.Name = "AdministradorTextBox"
        Me.AdministradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdministradorTextBox.TabIndex = 2
        '
        'Usuarios_TextBox
        '
        Me.Usuarios_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "usuarios ", True))
        Me.Usuarios_TextBox.Location = New System.Drawing.Point(262, 114)
        Me.Usuarios_TextBox.Name = "Usuarios_TextBox"
        Me.Usuarios_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Usuarios_TextBox.TabIndex = 4
        '
        'ContraseñasTextBox
        '
        Me.ContraseñasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "contraseñas", True))
        Me.ContraseñasTextBox.Location = New System.Drawing.Point(262, 140)
        Me.ContraseñasTextBox.Name = "ContraseñasTextBox"
        Me.ContraseñasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñasTextBox.TabIndex = 6
        '
        'Nombre_TextBox
        '
        Me.Nombre_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombre ", True))
        Me.Nombre_TextBox.Location = New System.Drawing.Point(262, 166)
        Me.Nombre_TextBox.Name = "Nombre_TextBox"
        Me.Nombre_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_TextBox.TabIndex = 8
        '
        'Apelllido_TextBox
        '
        Me.Apelllido_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "apelllido ", True))
        Me.Apelllido_TextBox.Location = New System.Drawing.Point(262, 192)
        Me.Apelllido_TextBox.Name = "Apelllido_TextBox"
        Me.Apelllido_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apelllido_TextBox.TabIndex = 10
        '
        'Buttonregistro
        '
        Me.Buttonregistro.Location = New System.Drawing.Point(146, 288)
        Me.Buttonregistro.Name = "Buttonregistro"
        Me.Buttonregistro.Size = New System.Drawing.Size(75, 23)
        Me.Buttonregistro.TabIndex = 11
        Me.Buttonregistro.Text = "registrate"
        Me.Buttonregistro.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(286, 287)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 12
        Me.ButtonCancelar.Text = "cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'UsuarioBindingNavigatorSaveItem
        '
        Me.UsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsuarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuarioBindingNavigatorSaveItem.Name = "UsuarioBindingNavigatorSaveItem"
        Me.UsuarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsuarioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'UsuarioBindingNavigator
        '
        Me.UsuarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuarioBindingNavigator.BindingSource = Me.UsuarioBindingSource
        Me.UsuarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsuarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsuarioBindingNavigatorSaveItem})
        Me.UsuarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsuarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsuarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsuarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsuarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsuarioBindingNavigator.Name = "UsuarioBindingNavigator"
        Me.UsuarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsuarioBindingNavigator.Size = New System.Drawing.Size(583, 25)
        Me.UsuarioBindingNavigator.TabIndex = 0
        Me.UsuarioBindingNavigator.Text = "BindingNavigator1"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 502)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Buttonregistro)
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
        Me.Controls.Add(Me.UsuarioBindingNavigator)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuarioBindingNavigator.ResumeLayout(False)
        Me.UsuarioBindingNavigator.PerformLayout()
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
    Friend WithEvents Buttonregistro As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsuarioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsuarioBindingNavigator As System.Windows.Forms.BindingNavigator
End Class
