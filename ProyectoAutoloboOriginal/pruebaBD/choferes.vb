Public Class choferes

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChoferBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub choferes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)

    End Sub

    Private Sub ButtonSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSocios.Click
        If NombreTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            NombreTextBox.Focus()
        Else
            Me.Validate()
            Me.ChoferBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")



            Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer) 'Actuliza el form en el que estas

            Me.ChoferBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            'MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("Id")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.ChoferBindingSource.AddNew()

            NombreTextBox.Focus()
        End If
    End Sub
End Class