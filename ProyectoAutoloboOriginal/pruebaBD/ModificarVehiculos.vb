Public Class ModificarVehiculos

    Private Sub VehiculoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VehiculoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub ModificarVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)

    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Dim aceptar As String

        If DominioTextBox.Text = "" Then
            MsgBox("El campo de dominio esta vacio")
        Else
            aceptar = MsgBox("esta seguro que quiere modifica el registro?", vbQuestion + vbYesNo, "proceso")

            If aceptar = 6 Then
                Me.VehiculoTableAdapter.Modificar(ModeloTextBox.Text, MarcaTextBox.Text, AñoDateTimePicker.Text, DominioTextBox.Text, SeguroTextBox.Text, Venc_gnc_DateTimePicker.Text, Venc_vtvDateTimePicker.Text, ColorTextBox.Text, DueñoTextBox.Text, DominioTextBox.Text)
                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
                Vehiculos.VehiculoTableAdapter.Fill(Vehiculos1.Database1DataSet.Vehiculo)

            Else


            End If

        End If
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click

        Me.Close()

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim aceptar As String

        If DominioTextBox.Text = "" Then
            MsgBox("El campo de dominio esta vacio")
        Else
            aceptar = MsgBox("esta seguro que quiere eliminar el registro?", vbQuestion + vbYesNo, "proceso")

            If aceptar = 6 Then

                Me.VehiculoTableAdapter.eliminar(DominioTextBox.Text)
                Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
                Vehiculos.VehiculoTableAdapter.Fill(Vehiculos1.Database1DataSet.Vehiculo)
                Me.Close()

            Else


            End If

        End If


    End Sub
End Class