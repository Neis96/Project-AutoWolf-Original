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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loggin))
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Textbox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Usuario1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Usuario1TableAdapter = New pruebaBD.Database1DataSetTableAdapters.Usuario1TableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonCancela = New System.Windows.Forms.Button()
        Me.ButtonIngreso = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.LiqCtaCtrTableAdapter = Nothing
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(212, 196)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Textbox1
        '
        Me.Textbox1.Location = New System.Drawing.Point(212, 142)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(100, 20)
        Me.Textbox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(178, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 105)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonCancela
        '
        Me.ButtonCancela.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonCancela.BackgroundImage = CType(resources.GetObject("ButtonCancela.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonCancela.FlatAppearance.BorderSize = 0
        Me.ButtonCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancela.Location = New System.Drawing.Point(300, 252)
        Me.ButtonCancela.Name = "ButtonCancela"
        Me.ButtonCancela.Size = New System.Drawing.Size(75, 91)
        Me.ButtonCancela.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.ButtonCancela, "SALIR")
        Me.ButtonCancela.UseVisualStyleBackColor = False
        '
        'ButtonIngreso
        '
        Me.ButtonIngreso.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonIngreso.BackgroundImage = CType(resources.GetObject("ButtonIngreso.BackgroundImage"), System.Drawing.Image)
        Me.ButtonIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonIngreso.FlatAppearance.BorderSize = 0
        Me.ButtonIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIngreso.Location = New System.Drawing.Point(110, 252)
        Me.ButtonIngreso.Name = "ButtonIngreso"
        Me.ButtonIngreso.Size = New System.Drawing.Size(75, 91)
        Me.ButtonIngreso.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ButtonIngreso, "INGRESAR")
        Me.ButtonIngreso.UseVisualStyleBackColor = False
        '
        'Loggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(513, 386)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
