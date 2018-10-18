<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarSocios
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
        Me.ButModificar = New System.Windows.Forms.Button()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ButEliminar = New System.Windows.Forms.Button()
        Me.ButVolver = New System.Windows.Forms.Button()
        Me.SociosTableAdapter = New pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButModificar
        '
        Me.ButModificar.Location = New System.Drawing.Point(53, 242)
        Me.ButModificar.Name = "ButModificar"
        Me.ButModificar.Size = New System.Drawing.Size(141, 23)
        Me.ButModificar.TabIndex = 0
        Me.ButModificar.Text = "Modificar"
        Me.ButModificar.UseVisualStyleBackColor = True
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
        'ButEliminar
        '
        Me.ButEliminar.Location = New System.Drawing.Point(264, 242)
        Me.ButEliminar.Name = "ButEliminar"
        Me.ButEliminar.Size = New System.Drawing.Size(141, 23)
        Me.ButEliminar.TabIndex = 16
        Me.ButEliminar.Text = "Eliminar"
        Me.ButEliminar.UseVisualStyleBackColor = True
        '
        'ButVolver
        '
        Me.ButVolver.Location = New System.Drawing.Point(317, 14)
        Me.ButVolver.Name = "ButVolver"
        Me.ButVolver.Size = New System.Drawing.Size(88, 38)
        Me.ButVolver.TabIndex = 18
        Me.ButVolver.Text = "Volver"
        Me.ButVolver.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(51, 123)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 19
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(110, 120)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 20
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(51, 97)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 21
        ApellidoLabel.Text = "apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(110, 94)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 22
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(51, 71)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(24, 13)
        DniLabel.TabIndex = 23
        DniLabel.Text = "dni:"
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(110, 68)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox.TabIndex = 24
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(51, 149)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 25
        DireccionLabel.Text = "direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(110, 146)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 26
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(51, 175)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 27
        TelefonoLabel.Text = "telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(110, 172)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 28
        '
        'ModificarSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 307)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.ButVolver)
        Me.Controls.Add(Me.ButEliminar)
        Me.Controls.Add(Me.ButModificar)
        Me.Name = "ModificarSocios"
        Me.Text = "ModificarSocios"
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButModificar As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents SociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SociosTableAdapter As pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ButEliminar As System.Windows.Forms.Button
    Friend WithEvents ButVolver As System.Windows.Forms.Button
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
End Class
