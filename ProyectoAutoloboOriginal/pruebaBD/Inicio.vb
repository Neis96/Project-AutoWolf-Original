Public Class Inicio

    Dim conexion As conexion = New conexion()

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("SELECT REGISTRO, Finalizado, idChofer, idSocios ,fecha_origen, lugar_destino FROM VIAJES", "VIAJES")
        DgvEstado.DataSource = conexion.ds.Tables("VIAJES")
        conexion.Consulta("SELECT REGISTRO, Finalizado, idChofer, idSocios, fecha_origen, lugar_destino, reserva FROM VIAJES", "VIAJES")
        DgvReserva.DataSource = conexion.ds.Tables("viajes")
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

    Private Sub BtnReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReserva.Click

        'reservas.Show()

    End Sub

    Private Sub ResumenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenToolStripMenuItem1.Click
        Resumen.Show()

    End Sub

    Private Sub LiquidacionChoferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidacionChoferToolStripMenuItem.Click
        Liquidacion_Choferes.Show()

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Configuracion.Show()

    End Sub
End Class