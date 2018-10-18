<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenCtaCte
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
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.LiqCtaCtrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiqCtaCtrTableAdapter = New pruebaBD.Database1DataSetTableAdapters.LiqCtaCtrTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.Socio = New System.Windows.Forms.TextBox()
        Me.DesdePick = New System.Windows.Forms.DateTimePicker()
        Me.HastaPick = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LiqCtaCtrDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiqCtaCtrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiqCtaCtrDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LiqCtaCtrBindingSource
        '
        Me.LiqCtaCtrBindingSource.DataMember = "LiqCtaCtr"
        Me.LiqCtaCtrBindingSource.DataSource = Me.Database1DataSet
        '
        'LiqCtaCtrTableAdapter
        '
        Me.LiqCtaCtrTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Me.LiqCtaCtrTableAdapter
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario1TableAdapter = Nothing
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'BtnConsulta
        '
        Me.BtnConsulta.BackgroundImage = Global.pruebaBD.My.Resources.Resources.icons8_google_web_search_64
        Me.BtnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnConsulta.FlatAppearance.BorderSize = 0
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsulta.Location = New System.Drawing.Point(236, 228)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(105, 75)
        Me.BtnConsulta.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnConsulta, "CONSULTAR")
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'Socio
        '
        Me.Socio.Location = New System.Drawing.Point(302, 94)
        Me.Socio.Name = "Socio"
        Me.Socio.Size = New System.Drawing.Size(79, 20)
        Me.Socio.TabIndex = 3
        '
        'DesdePick
        '
        Me.DesdePick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DesdePick.Location = New System.Drawing.Point(302, 134)
        Me.DesdePick.Name = "DesdePick"
        Me.DesdePick.Size = New System.Drawing.Size(79, 20)
        Me.DesdePick.TabIndex = 4
        '
        'HastaPick
        '
        Me.HastaPick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HastaPick.Location = New System.Drawing.Point(302, 174)
        Me.HastaPick.Name = "HastaPick"
        Me.HastaPick.Size = New System.Drawing.Size(79, 20)
        Me.HastaPick.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id socio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hasta"
        '
        'LiqCtaCtrDataGridView
        '
        Me.LiqCtaCtrDataGridView.AutoGenerateColumns = False
        Me.LiqCtaCtrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LiqCtaCtrDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.LiqCtaCtrDataGridView.DataSource = Me.LiqCtaCtrBindingSource
        Me.LiqCtaCtrDataGridView.Location = New System.Drawing.Point(12, 338)
        Me.LiqCtaCtrDataGridView.Name = "LiqCtaCtrDataGridView"
        Me.LiqCtaCtrDataGridView.Size = New System.Drawing.Size(542, 268)
        Me.LiqCtaCtrDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Socio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Socio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Desde "
        Me.DataGridViewTextBoxColumn3.HeaderText = "Desde "
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hasta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hasta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ResumenCtaCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(566, 618)
        Me.Controls.Add(Me.LiqCtaCtrDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HastaPick)
        Me.Controls.Add(Me.DesdePick)
        Me.Controls.Add(Me.Socio)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Name = "ResumenCtaCte"
        Me.Text = "ResumenCtaCte"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiqCtaCtrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiqCtaCtrDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents LiqCtaCtrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LiqCtaCtrTableAdapter As pruebaBD.Database1DataSetTableAdapters.LiqCtaCtrTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents Socio As System.Windows.Forms.TextBox
    Friend WithEvents DesdePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents HastaPick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LiqCtaCtrDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
