<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaChofer
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
        Dim DniLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Venc_regLabel As System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ProjectAutoWolfOriginalDataSet = New ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSet()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.ChoferTableAdapter()
        Me.TableAdapterManager = New ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.TableAdapterManager()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Venc_regDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnVolver = New System.Windows.Forms.Button()
        DniLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Venc_regLabel = New System.Windows.Forms.Label()
        CType(Me.ProjectAutoWolfOriginalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(89, 312)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(124, 44)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'ProjectAutoWolfOriginalDataSet
        '
        Me.ProjectAutoWolfOriginalDataSet.DataSetName = "ProjectAutoWolfOriginalDataSet"
        Me.ProjectAutoWolfOriginalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "Chofer"
        Me.ChoferBindingSource.DataSource = Me.ProjectAutoWolfOriginalDataSet
        '
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Me.ChoferTableAdapter
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(111, 52)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(26, 13)
        DniLabel.TabIndex = 4
        DniLabel.Text = "Dni:"
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(170, 49)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DniTextBox.TabIndex = 5
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(111, 88)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(170, 85)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 7
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(111, 124)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 8
        ApellidoLabel.Text = "Apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(170, 121)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidoTextBox.TabIndex = 9
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(111, 159)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 10
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(170, 156)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox.TabIndex = 11
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(110, 197)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 12
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(169, 194)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoTextBox.TabIndex = 13
        '
        'Venc_regLabel
        '
        Venc_regLabel.AutoSize = True
        Venc_regLabel.Location = New System.Drawing.Point(111, 233)
        Venc_regLabel.Name = "Venc_regLabel"
        Venc_regLabel.Size = New System.Drawing.Size(53, 13)
        Venc_regLabel.TabIndex = 14
        Venc_regLabel.Text = "Venc reg:"
        '
        'Venc_regDateTimePicker
        '
        Me.Venc_regDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChoferBindingSource, "venc_reg", True))
        Me.Venc_regDateTimePicker.Location = New System.Drawing.Point(170, 229)
        Me.Venc_regDateTimePicker.Name = "Venc_regDateTimePicker"
        Me.Venc_regDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Venc_regDateTimePicker.TabIndex = 15
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(323, 312)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(124, 44)
        Me.BtnVolver.TabIndex = 16
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FormAltaChofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 400)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Venc_regLabel)
        Me.Controls.Add(Me.Venc_regDateTimePicker)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FormAltaChofer"
        Me.Text = "Chofer"
        CType(Me.ProjectAutoWolfOriginalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents ProjectAutoWolfOriginalDataSet As ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSet
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Venc_regDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
End Class
