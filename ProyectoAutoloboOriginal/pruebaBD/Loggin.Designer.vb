<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loggin
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
        Me.ButtonIngreso = New System.Windows.Forms.Button()
        Me.ButtonCancela = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.TbContraseña = New System.Windows.Forms.TextBox()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonIngreso
        '
        Me.ButtonIngreso.Location = New System.Drawing.Point(129, 283)
        Me.ButtonIngreso.Name = "ButtonIngreso"
        Me.ButtonIngreso.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngreso.TabIndex = 0
        Me.ButtonIngreso.Text = "Ingresar"
        Me.ButtonIngreso.UseVisualStyleBackColor = True
        '
        'ButtonCancela
        '
        Me.ButtonCancela.Location = New System.Drawing.Point(294, 283)
        Me.ButtonCancela.Name = "ButtonCancela"
        Me.ButtonCancela.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancela.TabIndex = 1
        Me.ButtonCancela.Text = "salir"
        Me.ButtonCancela.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'TbUsuario
        '
        Me.TbUsuario.Location = New System.Drawing.Point(205, 112)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TbUsuario.TabIndex = 4
        '
        'TbContraseña
        '
        Me.TbContraseña.Location = New System.Drawing.Point(205, 176)
        Me.TbContraseña.Name = "TbContraseña"
        Me.TbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TbContraseña.TabIndex = 5
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
        'Loggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 386)
        Me.Controls.Add(Me.TbContraseña)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancela)
        Me.Controls.Add(Me.ButtonIngreso)
        Me.Name = "Loggin"
        Me.Text = "Loggin"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonIngreso As System.Windows.Forms.Button
    Friend WithEvents ButtonCancela As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TbContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As pruebaBD.Database1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
End Class
