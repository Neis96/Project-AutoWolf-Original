﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaVehiculo
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
        Me.ButtonHomeVehiculo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonHomeVehiculo
        '
        Me.ButtonHomeVehiculo.Location = New System.Drawing.Point(545, 24)
        Me.ButtonHomeVehiculo.Name = "ButtonHomeVehiculo"
        Me.ButtonHomeVehiculo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHomeVehiculo.TabIndex = 0
        Me.ButtonHomeVehiculo.Text = "Button1"
        Me.ButtonHomeVehiculo.UseVisualStyleBackColor = True
        '
        'vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 383)
        Me.Controls.Add(Me.ButtonHomeVehiculo)
        Me.Name = "vehiculo"
        Me.Text = "vehiculo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonHomeVehiculo As System.Windows.Forms.Button
End Class
