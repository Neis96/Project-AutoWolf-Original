Public Class facturacion

    Private Sub ViajesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ViajesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub facturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)


        Me.ViajesBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click 'Botton de facturacion
        If IdComboBox.Text = "" Then
            MsgBox("El campo esta vacio")
            IdComboBox.Focus()
        Else
            Me.Validate()
            Me.ViajesBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            Form1.TableAdapterManager.UpdateAll(Form1.Database1DataSet)

            MsgBox("Registro guardado con exito")

            Form1.ViajesTableAdapter.Fill(Form1.Database1DataSet.Viajes) 'actuliza el form principal

            Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes) 'Actuliza el form en el que estas

            Me.ViajesBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            'MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("Registro")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.ViajesBindingSource.AddNew()

            IdComboBox.Focus()

        End If


    End Sub

    Private Sub IdChoferComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    
End Class