<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVehiculos
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
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Dim SeguroLabel As System.Windows.Forms.Label
        Dim Venc_gnc_Label As System.Windows.Forms.Label
        Dim Venc_vtvLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim DueñoLabel As System.Windows.Forms.Label
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.SeguroTextBox = New System.Windows.Forms.TextBox()
        Me.Venc_gnc_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Venc_vtvDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.DueñoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.VehiculoTableAdapter = New pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        SeguroLabel = New System.Windows.Forms.Label()
        Venc_gnc_Label = New System.Windows.Forms.Label()
        Venc_vtvLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        DueñoLabel = New System.Windows.Forms.Label()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModeloLabel.Location = New System.Drawing.Point(21, 148)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(65, 17)
        ModeloLabel.TabIndex = 1
        ModeloLabel.Text = "modelo:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(21, 122)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(57, 17)
        MarcaLabel.TabIndex = 3
        MarcaLabel.Text = "marca:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AñoLabel.Location = New System.Drawing.Point(21, 175)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(40, 17)
        AñoLabel.TabIndex = 5
        AñoLabel.Text = "año:"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DominioLabel.Location = New System.Drawing.Point(21, 96)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(69, 17)
        DominioLabel.TabIndex = 7
        DominioLabel.Text = "dominio:"
        '
        'SeguroLabel
        '
        SeguroLabel.AutoSize = True
        SeguroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeguroLabel.Location = New System.Drawing.Point(328, 91)
        SeguroLabel.Name = "SeguroLabel"
        SeguroLabel.Size = New System.Drawing.Size(63, 17)
        SeguroLabel.TabIndex = 9
        SeguroLabel.Text = "seguro:"
        '
        'Venc_gnc_Label
        '
        Venc_gnc_Label.AutoSize = True
        Venc_gnc_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Venc_gnc_Label.Location = New System.Drawing.Point(328, 118)
        Venc_gnc_Label.Name = "Venc_gnc_Label"
        Venc_gnc_Label.Size = New System.Drawing.Size(83, 17)
        Venc_gnc_Label.TabIndex = 11
        Venc_gnc_Label.Text = "venc gnc :"
        '
        'Venc_vtvLabel
        '
        Venc_vtvLabel.AutoSize = True
        Venc_vtvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Venc_vtvLabel.Location = New System.Drawing.Point(328, 144)
        Venc_vtvLabel.Name = "Venc_vtvLabel"
        Venc_vtvLabel.Size = New System.Drawing.Size(73, 17)
        Venc_vtvLabel.TabIndex = 13
        Venc_vtvLabel.Text = "venc vtv:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(21, 208)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(49, 17)
        ColorLabel.TabIndex = 15
        ColorLabel.Text = "color:"
        '
        'DueñoLabel
        '
        DueñoLabel.AutoSize = True
        DueñoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DueñoLabel.Location = New System.Drawing.Point(21, 234)
        DueñoLabel.Name = "DueñoLabel"
        DueñoLabel.Size = New System.Drawing.Size(58, 17)
        DueñoLabel.TabIndex = 17
        DueñoLabel.Text = "dueño:"
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(88, 145)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ModeloTextBox.TabIndex = 2
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(88, 119)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MarcaTextBox.TabIndex = 4
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(88, 171)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AñoDateTimePicker.TabIndex = 6
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Location = New System.Drawing.Point(88, 93)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DominioTextBox.TabIndex = 8
        '
        'SeguroTextBox
        '
        Me.SeguroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "seguro", True))
        Me.SeguroTextBox.Location = New System.Drawing.Point(422, 91)
        Me.SeguroTextBox.Name = "SeguroTextBox"
        Me.SeguroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SeguroTextBox.TabIndex = 10
        '
        'Venc_gnc_DateTimePicker
        '
        Me.Venc_gnc_DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "venc_gnc ", True))
        Me.Venc_gnc_DateTimePicker.Location = New System.Drawing.Point(422, 117)
        Me.Venc_gnc_DateTimePicker.Name = "Venc_gnc_DateTimePicker"
        Me.Venc_gnc_DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Venc_gnc_DateTimePicker.TabIndex = 12
        '
        'Venc_vtvDateTimePicker
        '
        Me.Venc_vtvDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "venc_vtv", True))
        Me.Venc_vtvDateTimePicker.Location = New System.Drawing.Point(422, 143)
        Me.Venc_vtvDateTimePicker.Name = "Venc_vtvDateTimePicker"
        Me.Venc_vtvDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Venc_vtvDateTimePicker.TabIndex = 14
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(88, 205)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 16
        '
        'DueñoTextBox
        '
        Me.DueñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dueño", True))
        Me.DueñoTextBox.Location = New System.Drawing.Point(88, 231)
        Me.DueñoTextBox.Name = "DueñoTextBox"
        Me.DueñoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DueñoTextBox.TabIndex = 18
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnVolver.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_izquierda_en_círculo_2_64
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnVolver.FlatAppearance.BorderSize = 0
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Location = New System.Drawing.Point(482, 308)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(119, 72)
        Me.BtnVolver.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.BtnVolver, "VOLVER")
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Me.VehiculoTableAdapter
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_basura_64
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(285, 308)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(119, 72)
        Me.BtnEliminar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "ELIMINAR")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnModificar.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_editar_archivo_64
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(88, 308)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(123, 72)
        Me.BtnModificar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "MODIFICAR")
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'ModificarVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(748, 426)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(Me.DominioTextBox)
        Me.Controls.Add(SeguroLabel)
        Me.Controls.Add(Me.SeguroTextBox)
        Me.Controls.Add(Venc_gnc_Label)
        Me.Controls.Add(Me.Venc_gnc_DateTimePicker)
        Me.Controls.Add(Venc_vtvLabel)
        Me.Controls.Add(Me.Venc_vtvDateTimePicker)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(DueñoLabel)
        Me.Controls.Add(Me.DueñoTextBox)
        Me.Name = "ModificarVehiculos"
        Me.Text = "ModificarVehiculos"
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeguroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Venc_gnc_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Venc_vtvDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DueñoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
