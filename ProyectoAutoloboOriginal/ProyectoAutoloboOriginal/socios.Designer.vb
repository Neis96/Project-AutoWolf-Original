<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bottonhomesocios
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
        Me.Buttonhomesocios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Buttonhomesocios
        '
        Me.Buttonhomesocios.Location = New System.Drawing.Point(705, 23)
        Me.Buttonhomesocios.Name = "Buttonhomesocios"
        Me.Buttonhomesocios.Size = New System.Drawing.Size(75, 23)
        Me.Buttonhomesocios.TabIndex = 0
        Me.Buttonhomesocios.Text = "Button1"
        Me.Buttonhomesocios.UseVisualStyleBackColor = True
        '
        'bottonhomesocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 381)
        Me.Controls.Add(Me.Buttonhomesocios)
        Me.Name = "bottonhomesocios"
        Me.Text = "socios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttonhomesocios As System.Windows.Forms.Button
End Class
