Public Class Inicio

    Private Sub ReservaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ReservaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Database1DataSet.Reserva)

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

        reservas.Show()

    End Sub

    Private Sub ResumenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenToolStripMenuItem.Click

        Resumen.Show()

    End Sub

    Private Sub LiquidacionChoferesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidacionChoferesToolStripMenuItem.Click

        Liquidacion_Choferes.Show()

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click

        Ayuda.Show()

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click

        Configuracion.Show()

    End Sub
End Class