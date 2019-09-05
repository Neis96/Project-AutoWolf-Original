Public Class TerminarReserva

    Private Sub ViajesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TerminarReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
        ComboBox1.Items.Add("Reserva")
        ComboBox1.Items.Add("En curso")
        ComboBox1.Items.Add("Finalizado")
        TextBox1.Enabled = False
        IdSociosTextBox.Enabled = False
        Fecha_origenDateTimePicker.Value = Now
        Fecha_destinoDateTimePicker.Value = Now
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Dim reserva, estado, Lorigen, Ldestino As String ', agregar
        Dim chofer, auto As Integer
        chofer = Id_choferComboBox.SelectedItem
        auto = Id_vehiculoComboBox.SelectedItem
        Lorigen = Lugar_origenTextBox.Text
        Ldestino = Lugar_destinoTextBox.Text
       


        If ComboBox1.SelectedItem = "Reserva" Then

            reserva = "si"
            estado = ComboBox1.SelectedItem
        ElseIf ComboBox1.SelectedItem = "En curso" Then
            reserva = "no"
            estado = ComboBox1.SelectedItem
        ElseIf ComboBox1.SelectedItem = "Finalizado" Then
            reserva = "no"
            estado = ComboBox1.SelectedItem
            If Id_choferComboBox.Text <> "" Then
                If Id_vehiculoComboBox.Text <> "" Then
                    If Lugar_origenTextBox.Text <> "" Then
                        If Lugar_destinoTextBox.Text <> "" Then



                            Me.ViajesBindingSource.Current("IdChofer") = chofer
                            'Me.ViajesBindingSource.Current("idSocios") = Val(ComboBoxSocios.Text)
                            Me.ViajesBindingSource.Current("idVehiculos") = auto
                            Me.ViajesBindingSource.Current("fecha_origen") = Fecha_origenDateTimePicker.Value
                            Me.ViajesBindingSource.Current("fecha_destino") = Fecha_destinoDateTimePicker.Value
                            'Me.ViajesBindingSource.Current("total") = Val(TotalTextBox.Text)
                            Me.ViajesBindingSource.Current("lugar_origen") = Lugar_origenTextBox.Text
                            Me.ViajesBindingSource.Current("lugar_destino") = Lugar_destinoTextBox.Text
                            Me.ViajesBindingSource.Current("Reserva") = reserva
                            'Me.ViajesBindingSource.Current("Cta_cte") = cta
                            Me.ViajesBindingSource.Current("Estado") = estado
                            MsgBox("datos guardados")
                            Me.ViajesBindingSource.EndEdit()
                            ' 
                            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
                            Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes) 'actualizo en este formulario
                            ' Inicio.ViajesTableAdapter.Fill(Inicio.Database1DataSet.Viajes)
                            'conexion.actualizar("VIAJES")
                            Inicio.MostrarDatos()

                            'conexion.da.Fill(conexion.ds)
                            'Inicio.StockTableAdapter.Fill(Inicio.Database1DataSet.Viajes) 'actualizo en formulario principal
                            'Me.ViajesBindingSource.AddNew() 'preparo para seguir cargando
                        Else
                            MsgBox("El campo destino se encuentra vacion")
                        End If
                    Else
                        MsgBox("El campo origen se encuentra vacion")
                    End If
                Else
                    MsgBox("Debe seleccionar un vehiculo")

                End If
            Else
                MsgBox("Debe seleccionar un chofer")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vista As New DataView
        vista.Table = Me.Database1DataSet.Viajes
        vista.RowFilter = "Registro = " & Val(Me.TextBox1.Text)
        Me.ViajesDataGridView.DataSource = vista 'ACTUALIZO LA GRILLA
    End Sub

    Private Sub BtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEliminar.Click
        Dim fila, codConsulta, aux As Integer
        codConsulta = TextBox1.Text
        fila = Me.ViajesBindingSource.Find("Registro", codConsulta)
        If fila = -1 Then
            'no se encuentra
            MsgBox("no se encontro")
        Else
            'lo encontro
            Me.ViajesBindingSource.Position = fila 'situo el puntero en la fila buscada
            aux = MsgBox("Quiere eliminar?" & "" & codConsulta)
            If aux = 1 Then 'apreto si
                Me.ViajesBindingSource.RemoveCurrent() 'borra el registro donde estas situado
                Me.ViajesBindingSource.EndEdit() 'cierro bd
                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guarda 

                Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes) ' actualiza el form anterior


            End If
        End If
    End Sub
End Class