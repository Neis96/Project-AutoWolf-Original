Public Class viajes

    Private Sub ViajesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub viajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'boton guardar
        Dim reserva As String
        If CheckBoxReserva.Checked Then
            reserva = "si"
        Else
            reserva = "no"
        End If
        Me.ViajesBindingSource.Current("IdChofer") = Val(ComboBoxChofer.SelectedItem)
        Me.ViajesBindingSource.Current("idSocios") = Val(ComboBoxSocios.SelectedItem)
        Me.ViajesBindingSource.Current("idVehiculos") = Val(ComboBoxVehiculo.SelectedItem)
        Me.ViajesBindingSource.Current("fecha_origen") = Fecha_destinoDateTimePicker.Value
        Me.ViajesBindingSource.Current("fecha_destino") = Fecha_origenDateTimePicker.Value
        Me.ViajesBindingSource.Current("total") = Val(TotalTextBox.Text)
        Me.ViajesBindingSource.EndEdit()
        '    Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)
        '  Me.StockTableAdapter.Fill(Me.FarmaciaDataSet.stock) 'actualizo en este formulario
        '   Form1.StockTableAdapter.Fill(Form1.FarmaciaDataSet.stock) 'actualizo en formulario principal
        '   Me.StockBindingSource.AddNew() 'preparo para seguir cargando
    End Sub
End Class