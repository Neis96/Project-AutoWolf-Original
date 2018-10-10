<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TextDueno = New System.Windows.Forms.TextBox()
        Me.TextRemo = New System.Windows.Forms.TextBox()
        Me.TextKms = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ValoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValoresTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ValoresTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.DueñoTextBox = New System.Windows.Forms.TextBox()
        Me.RemiseriaTextBox = New System.Windows.Forms.TextBox()
        Me.KmsTextBox = New System.Windows.Forms.TextBox()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(88, 303)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TextDueno
        '
        Me.TextDueno.Location = New System.Drawing.Point(537, 74)
        Me.TextDueno.Name = "TextDueno"
        Me.TextDueno.Size = New System.Drawing.Size(100, 20)
        Me.TextDueno.TabIndex = 1
        '
        'TextRemo
        '
        Me.TextRemo.Location = New System.Drawing.Point(537, 133)
        Me.TextRemo.Name = "TextRemo"
        Me.TextRemo.Size = New System.Drawing.Size(100, 20)
        Me.TextRemo.TabIndex = 2
        '
        'TextKms
        '
        Me.TextKms.Location = New System.Drawing.Point(537, 194)
        Me.TextKms.Name = "TextKms"
        Me.TextKms.Size = New System.Drawing.Size(100, 20)
        Me.TextKms.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dueño %"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remiseria %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor kms"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ValoresBindingSource
        '
        Me.ValoresBindingSource.DataMember = "Valores"
        Me.ValoresBindingSource.DataSource = Me.Database1DataSet
        '
        'ValoresTableAdapter
        '
        Me.ValoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Me.ValoresTableAdapter
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'DueñoTextBox
        '
        Me.DueñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ValoresBindingSource, "dueño", True))
        Me.DueñoTextBox.Location = New System.Drawing.Point(103, 78)
        Me.DueñoTextBox.Name = "DueñoTextBox"
        Me.DueñoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DueñoTextBox.TabIndex = 10
        '
        'RemiseriaTextBox
        '
        Me.RemiseriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ValoresBindingSource, "remiseria", True))
        Me.RemiseriaTextBox.Location = New System.Drawing.Point(103, 137)
        Me.RemiseriaTextBox.Name = "RemiseriaTextBox"
        Me.RemiseriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RemiseriaTextBox.TabIndex = 12
        '
        'KmsTextBox
        '
        Me.KmsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ValoresBindingSource, "kms", True))
        Me.KmsTextBox.Location = New System.Drawing.Point(103, 198)
        Me.KmsTextBox.Name = "KmsTextBox"
        Me.KmsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KmsTextBox.TabIndex = 14
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 505)
        Me.Controls.Add(Me.DueñoTextBox)
        Me.Controls.Add(Me.RemiseriaTextBox)
        Me.Controls.Add(Me.KmsTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextKms)
        Me.Controls.Add(Me.TextRemo)
        Me.Controls.Add(Me.TextDueno)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TextDueno As System.Windows.Forms.TextBox
    Friend WithEvents TextRemo As System.Windows.Forms.TextBox
    Friend WithEvents TextKms As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ValoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValoresTableAdapter As pruebaBD.Database1DataSetTableAdapters.ValoresTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DueñoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemiseriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KmsTextBox As System.Windows.Forms.TextBox
End Class
