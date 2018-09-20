<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chofer
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
        Me.ButtonhomeChofer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonhomeChofer
        '
        Me.ButtonhomeChofer.Location = New System.Drawing.Point(677, 32)
        Me.ButtonhomeChofer.Name = "ButtonhomeChofer"
        Me.ButtonhomeChofer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonhomeChofer.TabIndex = 0
        Me.ButtonhomeChofer.Text = "Button1"
        Me.ButtonhomeChofer.UseVisualStyleBackColor = True
        '
        'Chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 374)
        Me.Controls.Add(Me.ButtonhomeChofer)
        Me.Name = "Chofer"
        Me.Text = "Chofer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonhomeChofer As System.Windows.Forms.Button
End Class
