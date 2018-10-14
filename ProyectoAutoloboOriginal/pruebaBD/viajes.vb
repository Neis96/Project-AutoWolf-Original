Public Class viajes
    Dim conexion As New conexion
    ' instancio dataTable
    '  Private dtViaje As New Database1DataSet.ViajesDataTable
    ' instancio el tableAdapter
    '  Private taViaje As New Database1DataSetTableAdapters.ViajesTableAdapter
    ' instanciamos una fila
    'Private fila As Database1DataSet.ViajesRow


    Private Sub viajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
        ' Me.dtViaje = Me.taViaje.GetData
        Me.ViajesBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'boton guardar

        Dim cta, reserva, estado, Lorigen, Ldestino As String ', agregar
        Dim chofer, socios, auto As Integer
        chofer = ComboBoxChofer.Text
        socios = ComboBoxSocios.Text
        auto = ComboBoxVehiculo.Text
        Lorigen = Lugar_origenTextBox.Text
        Ldestino = Lugar_destinoTextBox.Text
        'estado = "no"

        If CheckBoxReserva.Checked Then 'aca pregunto si es una reserva

            reserva = "si"
            estado = "Reserva"

        Else
            reserva = "no"
            estado = "En curso"
        End If
        If CheckCta.Checked Then 'aca pregunto por la cta cte

            cta = "si"

        Else
            cta = "no"
        End If


        'agregar = "insert into datos values (" & chofer & "," & socios & "," & auto & ",'" & Fecha_origenDateTimePicker.Value & "','" & Fecha_destinoDateTimePicker.Value & "'," & TotalTextBox.Text & ",'" & Lorigen & "','" & Ldestino & "','" & reserva & "','" & estado & "')"
        'If (conexion.insertar(agregar)) Then
        '    MsgBox("datos agregados")
        '    Inicio.MostrarDatos()
        'Else
        '    MsgBox("error")
        'End If

        Me.ViajesBindingSource.Current("IdChofer") = Val(ComboBoxChofer.Text)
        Me.ViajesBindingSource.Current("idSocios") = Val(ComboBoxSocios.Text)
        Me.ViajesBindingSource.Current("idVehiculos") = Val(ComboBoxVehiculo.Text)
        Me.ViajesBindingSource.Current("fecha_origen") = DestinoPick.Value
        Me.ViajesBindingSource.Current("fecha_destino") = OrigenPick.Value
        'Me.ViajesBindingSource.Current("total") = Val(TotalTextBox.Text)
        Me.ViajesBindingSource.Current("lugar_origen") = Lugar_origenTextBox.Text
        Me.ViajesBindingSource.Current("lugar_destino") = Lugar_destinoTextBox.Text
        Me.ViajesBindingSource.Current("Reserva") = reserva
        Me.ViajesBindingSource.Current("Cta_cte") = cta
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
        Me.ViajesBindingSource.AddNew() 'preparo para seguir cargando
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Inicio.Show()
        Me.Close()

    End Sub

    Private Sub Fecha_origenDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigenPick.ValueChanged


    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Socios.Show()
    End Sub
End Class