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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(127, 139)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(67, 17)
        NombreLabel.TabIndex = 19
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(127, 113)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(70, 17)
        ApellidoLabel.TabIndex = 21
        ApellidoLabel.Text = "apellido:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DniLabel.Location = New System.Drawing.Point(129, 87)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(35, 17)
        DniLabel.TabIndex = 23
        DniLabel.Text = "dni:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(127, 165)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(79, 17)
        DireccionLabel.TabIndex = 25
        DireccionLabel.Text = "direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(127, 191)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(72, 17)
        TelefonoLabel.TabIndex = 27
        TelefonoLabel.Text = "telefono:"
        '
        'ButModificar
        '
        Me.ButModificar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_editar_archivo_64
        Me.ButModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButModificar.FlatAppearance.BorderSize = 0
        Me.ButModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButModificar.Location = New System.Drawing.Point(139, 247)
        Me.ButModificar.Name = "ButModificar"
        Me.ButModificar.Size = New System.Drawing.Size(80, 78)
        Me.ButModificar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ButModificar, "MODIFICAR")
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
        Me.ButEliminar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_basura_64
        Me.ButEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButEliminar.FlatAppearance.BorderSize = 0
        Me.ButEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButEliminar.Location = New System.Drawing.Point(292, 243)
        Me.ButEliminar.Name = "ButEliminar"
        Me.ButEliminar.Size = New System.Drawing.Size(78, 78)
        Me.ButEliminar.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.ButEliminar, "ELIMINAR")
        Me.ButEliminar.UseVisualStyleBackColor = True
        '
        'ButVolver
        '
        Me.ButVolver.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_izquierda_en_círculo_2_64
        Me.ButVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButVolver.FlatAppearance.BorderSize = 0
        Me.ButVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButVolver.Location = New System.Drawing.Point(12, 12)
        Me.ButVolver.Name = "ButVolver"
        Me.ButVolver.Size = New System.Drawing.Size(88, 70)
        Me.ButVolver.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.ButVolver, "VOLVER")
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
        Me.TableAdapterManager.Usuario1TableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(206, 139)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 20
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(206, 113)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 22
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(206, 87)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox.TabIndex = 24
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(206, 165)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 26
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(206, 191)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 28
        '
        'ModificarSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(437, 370)
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
