<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resumen
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
        Me.DgvChofer = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.DgvAgencia = New System.Windows.Forms.DataGridView()
        Me.LiquidacionChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiquidacionChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter()
        Me.LiquidacionChoferDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResumenRemiseriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenRemiseriaTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ResumenRemiseriaTableAdapter()
        Me.ResumenRemiseriaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvChofer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvAgencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionChoferDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenRemiseriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenRemiseriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvChofer
        '
        Me.DgvChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvChofer.Location = New System.Drawing.Point(47, 56)
        Me.DgvChofer.Name = "DgvChofer"
        Me.DgvChofer.Size = New System.Drawing.Size(342, 204)
        Me.DgvChofer.TabIndex = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'DgvAgencia
        '
        Me.DgvAgencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAgencia.Location = New System.Drawing.Point(47, 316)
        Me.DgvAgencia.Name = "DgvAgencia"
        Me.DgvAgencia.Size = New System.Drawing.Size(342, 150)
        Me.DgvAgencia.TabIndex = 1
        '
        'LiquidacionChoferBindingSource
        '
        Me.LiquidacionChoferBindingSource.DataMember = "LiquidacionChofer"
        Me.LiquidacionChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'LiquidacionChoferTableAdapter
        '
        Me.LiquidacionChoferTableAdapter.ClearBeforeFill = True
        '
        'LiquidacionChoferDataGridView
        '
        Me.LiquidacionChoferDataGridView.AutoGenerateColumns = False
        Me.LiquidacionChoferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LiquidacionChoferDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LiquidacionChoferDataGridView.DataSource = Me.LiquidacionChoferBindingSource
        Me.LiquidacionChoferDataGridView.Location = New System.Drawing.Point(459, 40)
        Me.LiquidacionChoferDataGridView.Name = "LiquidacionChoferDataGridView"
        Me.LiquidacionChoferDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.LiquidacionChoferDataGridView.TabIndex = 3
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Desde"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Desde"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Hasta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hasta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_chofer"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_chofer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ResumenRemiseriaBindingSource
        '
        Me.ResumenRemiseriaBindingSource.DataMember = "ResumenRemiseria"
        Me.ResumenRemiseriaBindingSource.DataSource = Me.Database1DataSet
        '
        'ResumenRemiseriaTableAdapter
        '
        Me.ResumenRemiseriaTableAdapter.ClearBeforeFill = True
        '
        'ResumenRemiseriaDataGridView
        '
        Me.ResumenRemiseriaDataGridView.AutoGenerateColumns = False
        Me.ResumenRemiseriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResumenRemiseriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ResumenRemiseriaDataGridView.DataSource = Me.ResumenRemiseriaBindingSource
        Me.ResumenRemiseriaDataGridView.Location = New System.Drawing.Point(459, 293)
        Me.ResumenRemiseriaDataGridView.Name = "ResumenRemiseriaDataGridView"
        Me.ResumenRemiseriaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ResumenRemiseriaDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Registro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Resumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 599)
        Me.Controls.Add(Me.ResumenRemiseriaDataGridView)
        Me.Controls.Add(Me.LiquidacionChoferDataGridView)
        Me.Controls.Add(Me.DgvAgencia)
        Me.Controls.Add(Me.DgvChofer)
        Me.Name = "Resumen"
        Me.Text = "Resumen"
        CType(Me.DgvChofer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvAgencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionChoferDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenRemiseriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenRemiseriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DgvChofer As System.Windows.Forms.DataGridView
    Friend WithEvents DgvAgencia As System.Windows.Forms.DataGridView
    Friend WithEvents LiquidacionChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LiquidacionChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.LiquidacionChoferTableAdapter
    Friend WithEvents LiquidacionChoferDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResumenRemiseriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenRemiseriaTableAdapter As pruebaBD.Database1DataSetTableAdapters.ResumenRemiseriaTableAdapter
    Friend WithEvents ResumenRemiseriaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
