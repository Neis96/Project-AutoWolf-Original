Public Class Inicio

    Dim conexion As conexion = New conexion()
    Dim conexion2 As conexion = New conexion()

    Private Sub Inicio_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            viajes.ShowDialog()

        ElseIf e.KeyCode = Keys.F2 Then
            Socios.Show()

        ElseIf e.KeyCode = Keys.F3 Then
            choferes.Show()


        ElseIf e.KeyCode = Keys.F4 Then
            Vehiculos1.Show()




        End If

    End Sub


    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        'Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
        'conexion.conectar()
        MostrarDatos()
        ' mostrar2()


    End Sub

    Public Sub MostrarDatos()


        conexion.Consulta("SELECT REGISTRO, idChofer, idSocios ,fecha_origen, lugar_destino, estado FROM VIAJES where estado= 'En curso' ", "VIAJES")

        DgvEstado.DataSource = conexion.ds.Tables("VIAJES")
        conexion2.Consulta("SELECT REGISTRO, idSocios, fecha_origen, lugar_destino, reserva FROM VIAJES where reserva= 'si'", "VIAJES")
        DgvReserva.DataSource = conexion2.ds.Tables("viajes")
    End Sub

    

    Private Sub BtnViajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViajes.Click

        viajes.Show()

    End Sub

    Private Sub BtnSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSocio.Click

        Socios.Show()

    End Sub

    Private Sub BtnChoferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoferes.Click

        choferes.Show()

    End Sub

    Private Sub BtnVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehiculos.Click

        Vehiculos1.Show()

    End Sub

    Private Sub BtnReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'reservas.Show()

    End Sub

    Private Sub ResumenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenToolStripMenuItem1.Click
        Resumen.Show()

    End Sub

    Private Sub LiquidacionChoferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidacionChoferToolStripMenuItem.Click
        Liquidacion_Choferes.Show()

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click


    End Sub

    Private Sub DgvEstado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEstado.CellClick
        Dim fila As Integer
        fila = DgvEstado.CurrentCellAddress.Y 'saco la fila de donde hice click
        Finalizar_Viaje.TextBox1.Text = DgvEstado.Item(0, fila).Value() 'asigno al texbox1 del formulario ventas el valor del art

        Finalizar_Viaje.Show()

    End Sub

    Private Sub ViajesF1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViajesF1ToolStripMenuItem.Click

    End Sub

    Private Sub CrearUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearUsuariosToolStripMenuItem.Click
        RegistroUsuario.Show()

    End Sub

    Private Sub ModificarValoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarValoresToolStripMenuItem.Click
        Configuracion.Show()
    End Sub
End Class