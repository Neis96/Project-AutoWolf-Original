<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.BtnViajes = New System.Windows.Forms.Button()
        Me.BtnSocio = New System.Windows.Forms.Button()
        Me.BtnChoferes = New System.Windows.Forms.Button()
        Me.BtnVehiculos = New System.Windows.Forms.Button()
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ReservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.BtnReserva = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnViajes
        '
        Me.BtnViajes.Location = New System.Drawing.Point(29, 112)
        Me.BtnViajes.Name = "BtnViajes"
        Me.BtnViajes.Size = New System.Drawing.Size(132, 58)
        Me.BtnViajes.TabIndex = 0
        Me.BtnViajes.Text = "Viajes"
        Me.BtnViajes.UseVisualStyleBackColor = True
        '
        'BtnSocio
        '
        Me.BtnSocio.Location = New System.Drawing.Point(29, 203)
        Me.BtnSocio.Name = "BtnSocio"
        Me.BtnSocio.Size = New System.Drawing.Size(132, 59)
        Me.BtnSocio.TabIndex = 1
        Me.BtnSocio.Text = "Socio"
        Me.BtnSocio.UseVisualStyleBackColor = True
        '
        'BtnChoferes
        '
        Me.BtnChoferes.Location = New System.Drawing.Point(29, 297)
        Me.BtnChoferes.Name = "BtnChoferes"
        Me.BtnChoferes.Size = New System.Drawing.Size(132, 58)
        Me.BtnChoferes.TabIndex = 2
        Me.BtnChoferes.Text = "Choferes"
        Me.BtnChoferes.UseVisualStyleBackColor = True
        '
        'BtnVehiculos
        '
        Me.BtnVehiculos.Location = New System.Drawing.Point(29, 387)
        Me.BtnVehiculos.Name = "BtnVehiculos"
        Me.BtnVehiculos.Size = New System.Drawing.Size(132, 63)
        Me.BtnVehiculos.TabIndex = 3
        Me.BtnVehiculos.Text = "Vehiculos"
        Me.BtnVehiculos.UseVisualStyleBackColor = True
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservaBindingSource
        '
        Me.ReservaBindingSource.DataMember = "Reserva"
        Me.ReservaBindingSource.DataSource = Me.Database1DataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Nothing
        '
        'BtnReserva
        '
        Me.BtnReserva.Location = New System.Drawing.Point(196, 112)
        Me.BtnReserva.Name = "BtnReserva"
        Me.BtnReserva.Size = New System.Drawing.Size(124, 58)
        Me.BtnReserva.TabIndex = 7
        Me.BtnReserva.Text = "Reservas"
        Me.BtnReserva.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(820, 177)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(775, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 511)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnReserva)
        Me.Controls.Add(Me.BtnVehiculos)
        Me.Controls.Add(Me.BtnChoferes)
        Me.Controls.Add(Me.BtnSocio)
        Me.Controls.Add(Me.BtnViajes)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnViajes As System.Windows.Forms.Button
    Friend WithEvents BtnSocio As System.Windows.Forms.Button
    Friend WithEvents BtnChoferes As System.Windows.Forms.Button
    Friend WithEvents BtnVehiculos As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ReservaBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents ReservaTableAdapter As pruebaBD.Database1DataSetTableAdapters.ReservaTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnReserva As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
