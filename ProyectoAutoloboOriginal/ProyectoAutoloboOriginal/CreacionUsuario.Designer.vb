<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreacionUsuario
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContrasenaLabel As System.Windows.Forms.Label
        Me.ProjectAutoWolfOriginalDataSet = New ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContrasenaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContrasenaLabel = New System.Windows.Forms.Label()
        CType(Me.ProjectAutoWolfOriginalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectAutoWolfOriginalDataSet
        '
        Me.ProjectAutoWolfOriginalDataSet.DataSetName = "ProjectAutoWolfOriginalDataSet"
        Me.ProjectAutoWolfOriginalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ProjectAutoWolfOriginalDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(6, 36)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(99, 13)
        UsuarioLabel.TabIndex = 1
        UsuarioLabel.Text = "Nombre de usuario:"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(143, 33)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 2
        '
        'ContrasenaLabel
        '
        ContrasenaLabel.AutoSize = True
        ContrasenaLabel.Location = New System.Drawing.Point(6, 77)
        ContrasenaLabel.Name = "ContrasenaLabel"
        ContrasenaLabel.Size = New System.Drawing.Size(64, 13)
        ContrasenaLabel.TabIndex = 3
        ContrasenaLabel.Text = "Contraseña:"
        '
        'ContrasenaTextBox
        '
        Me.ContrasenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contrasena", True))
        Me.ContrasenaTextBox.Location = New System.Drawing.Point(143, 77)
        Me.ContrasenaTextBox.Name = "ContrasenaTextBox"
        Me.ContrasenaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContrasenaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContrasenaTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 52)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nuevo Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCrear)
        Me.GroupBox1.Controls.Add(UsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.UsuarioTextBox)
        Me.GroupBox1.Controls.Add(ContrasenaLabel)
        Me.GroupBox1.Controls.Add(Me.ContrasenaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 195)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo"
        '
        'BtnCrear
        '
        Me.BtnCrear.Location = New System.Drawing.Point(65, 130)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(120, 42)
        Me.BtnCrear.TabIndex = 5
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(351, 20)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(283, 140)
        Me.UsuariosDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Contrasena"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Contrasena"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'CreacionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 531)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreacionUsuario"
        Me.Text = "CreacionUsuario"
        CType(Me.ProjectAutoWolfOriginalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProjectAutoWolfOriginalDataSet As ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoAutoloboOriginal.ProjectAutoWolfOriginalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContrasenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCrear As System.Windows.Forms.Button
    Friend WithEvents UsuariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
