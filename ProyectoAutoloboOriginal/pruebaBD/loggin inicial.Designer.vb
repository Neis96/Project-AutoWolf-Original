<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loggin_inicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loggin_inicial))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.USUARIO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.AdministradorTextBox = New System.Windows.Forms.TextBox()
        Me.Usuarios_TextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñasTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_TextBox = New System.Windows.Forms.TextBox()
        Me.Apelllido_TextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        AdministradorLabel = New System.Windows.Forms.Label()
        Usuarios_Label = New System.Windows.Forms.Label()
        ContraseñasLabel = New System.Windows.Forms.Label()
        Nombre_Label = New System.Windows.Forms.Label()
        Apelllido_Label = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdministradorLabel
        '
        AdministradorLabel.AutoSize = True
        AdministradorLabel.Location = New System.Drawing.Point(49, 362)
        AdministradorLabel.Name = "AdministradorLabel"
        AdministradorLabel.Size = New System.Drawing.Size(72, 13)
        AdministradorLabel.TabIndex = 7
        AdministradorLabel.Text = "administrador:"
        AdministradorLabel.Visible = False
        '
        'Usuarios_Label
        '
        Usuarios_Label.AutoSize = True
        Usuarios_Label.Location = New System.Drawing.Point(49, 388)
        Usuarios_Label.Name = "Usuarios_Label"
        Usuarios_Label.Size = New System.Drawing.Size(52, 13)
        Usuarios_Label.TabIndex = 9
        Usuarios_Label.Text = "usuarios :"
        Usuarios_Label.Visible = False
        '
        'ContraseñasLabel
        '
        ContraseñasLabel.AutoSize = True
        ContraseñasLabel.Location = New System.Drawing.Point(49, 414)
        ContraseñasLabel.Name = "ContraseñasLabel"
        ContraseñasLabel.Size = New System.Drawing.Size(68, 13)
        ContraseñasLabel.TabIndex = 11
        ContraseñasLabel.Text = "contraseñas:"
        ContraseñasLabel.Visible = False
        '
        'Nombre_Label
        '
        Nombre_Label.AutoSize = True
        Nombre_Label.Location = New System.Drawing.Point(49, 440)
        Nombre_Label.Name = "Nombre_Label"
        Nombre_Label.Size = New System.Drawing.Size(48, 13)
        Nombre_Label.TabIndex = 13
        Nombre_Label.Text = "nombre :"
        Nombre_Label.Visible = False
        '
        'Apelllido_Label
        '
        Apelllido_Label.AutoSize = True
        Apelllido_Label.Location = New System.Drawing.Point(49, 466)
        Apelllido_Label.Name = "Apelllido_Label"
        Apelllido_Label.Size = New System.Drawing.Size(51, 13)
        Apelllido_Label.TabIndex = 15
        Apelllido_Label.Text = "apelllido :"
        Apelllido_Label.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Resistrarse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'USUARIO
        '
        Me.USUARIO.AutoSize = True
        Me.USUARIO.Location = New System.Drawing.Point(124, 176)
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.Size = New System.Drawing.Size(41, 13)
        Me.USUARIO.TabIndex = 2
        Me.USUARIO.Text = "usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(203, 173)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(203, 230)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
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
        Me.AdministradorTextBox.Location = New System.Drawing.Point(127, 359)
        Me.AdministradorTextBox.Name = "AdministradorTextBox"
        Me.AdministradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdministradorTextBox.TabIndex = 8
        Me.AdministradorTextBox.Visible = False
        '
        'Usuarios_TextBox
        '
        Me.Usuarios_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "usuarios ", True))
        Me.Usuarios_TextBox.Location = New System.Drawing.Point(127, 385)
        Me.Usuarios_TextBox.Name = "Usuarios_TextBox"
        Me.Usuarios_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Usuarios_TextBox.TabIndex = 10
        Me.Usuarios_TextBox.Visible = False
        '
        'ContraseñasTextBox
        '
        Me.ContraseñasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "contraseñas", True))
        Me.ContraseñasTextBox.Location = New System.Drawing.Point(127, 411)
        Me.ContraseñasTextBox.Name = "ContraseñasTextBox"
        Me.ContraseñasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñasTextBox.TabIndex = 12
        Me.ContraseñasTextBox.Visible = False
        '
        'Nombre_TextBox
        '
        Me.Nombre_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombre ", True))
        Me.Nombre_TextBox.Location = New System.Drawing.Point(127, 437)
        Me.Nombre_TextBox.Name = "Nombre_TextBox"
        Me.Nombre_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_TextBox.TabIndex = 14
        Me.Nombre_TextBox.Visible = False
        '
        'Apelllido_TextBox
        '
        Me.Apelllido_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "apelllido ", True))
        Me.Apelllido_TextBox.Location = New System.Drawing.Point(127, 463)
        Me.Apelllido_TextBox.Name = "Apelllido_TextBox"
        Me.Apelllido_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apelllido_TextBox.TabIndex = 16
        Me.Apelllido_TextBox.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(171, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 134)
        Me.Button3.TabIndex = 17
        Me.Button3.UseVisualStyleBackColor = False
        '
        'loggin_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(511, 503)
        Me.Controls.Add(Me.Button3)
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
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.USUARIO)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "loggin_inicial"
        Me.Text = "loggin_inicial"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents USUARIO As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdministradorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Usuarios_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apelllido_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
