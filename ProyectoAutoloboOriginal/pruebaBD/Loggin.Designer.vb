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
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Textbox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancela = New System.Windows.Forms.Button()
        Me.ButtonIngreso = New System.Windows.Forms.Button()
        Me.Usuario1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usuario1TableAdapter = New pruebaBD.Database1DataSetTableAdapters.Usuario1TableAdapter()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionChoferTableAdapter = Nothing
        Me.TableAdapterManager.ResumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.TablaDeTurnoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuario1TableAdapter = Nothing
        Me.TableAdapterManager.ValoresTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(212, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Textbox1
        '
        Me.Textbox1.Location = New System.Drawing.Point(212, 96)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(100, 20)
        Me.Textbox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'ButtonCancela
        '
        Me.ButtonCancela.Location = New System.Drawing.Point(301, 267)
        Me.ButtonCancela.Name = "ButtonCancela"
        Me.ButtonCancela.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancela.TabIndex = 7
        Me.ButtonCancela.Text = "salir"
        Me.ButtonCancela.UseVisualStyleBackColor = True
        '
        'ButtonIngreso
        '
        Me.ButtonIngreso.Location = New System.Drawing.Point(136, 267)
        Me.ButtonIngreso.Name = "ButtonIngreso"
        Me.ButtonIngreso.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngreso.TabIndex = 6
        Me.ButtonIngreso.Text = "Ingresar"
        Me.ButtonIngreso.UseVisualStyleBackColor = True
        '
        'Usuario1BindingSource
        '
        Me.Usuario1BindingSource.DataMember = "Usuario1"
        Me.Usuario1BindingSource.DataSource = Me.Database1DataSet
        '
        'Usuario1TableAdapter
        '
        Me.Usuario1TableAdapter.ClearBeforeFill = True
        '
        'Loggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 386)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancela)
        Me.Controls.Add(Me.ButtonIngreso)
        Me.Name = "Loggin"
        Me.Text = "Loggin"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Textbox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancela As System.Windows.Forms.Button
    Friend WithEvents ButtonIngreso As System.Windows.Forms.Button
    Friend WithEvents Usuario1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Usuario1TableAdapter As pruebaBD.Database1DataSetTableAdapters.Usuario1TableAdapter
End Class
