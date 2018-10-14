Public Class Resumen

    Dim ResumenChofer As conexion = New conexion()
    Dim ResumenRemiseria As conexion = New conexion()

    Private Sub LiquidacionChoferBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.LiquidacionChoferBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)


    End Sub

    Public Sub MostrarResumen()

        ResumenChofer.Consulta("SELECT Registro, id_chofer, Nombre, Desde, Hasta, Monto FROM LiquidacionChofer", "LiquidacionChofer")
        DgvChofer.DataSource = ResumenChofer.ds.Tables("LiquidacionChofer")
        ResumenRemiseria.Consulta("SELECT Registro, Fecha, Monto FROM ResumenRemiseria", "ResumenRemiseria")
        DgvAgencia.DataSource = ResumenRemiseria.ds.Tables("ResumenRemiseria")

    End Sub

    Private Sub Resumen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.ResumenRemiseria' Puede moverla o quitarla según sea necesario.
        Me.ResumenRemiseriaTableAdapter.Fill(Me.Database1DataSet.ResumenRemiseria)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiquidacionChofer' Puede moverla o quitarla según sea necesario.
        Me.LiquidacionChoferTableAdapter.Fill(Me.Database1DataSet.LiquidacionChofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.ResumenRemiseria' Puede moverla o quitarla según sea necesario.
        'Me.ResumenRemiseriaTableAdapter.Fill(Me.Database1DataSet.ResumenRemiseria)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiquidacionChofer' Puede moverla o quitarla según sea necesario.
        ' Me.LiquidacionChoferTableAdapter.Fill(Me.Database1DataSet.LiquidacionChofer)

        MostrarResumen()

    End Sub

    Private Sub LiquidacionChoferBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LiquidacionChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class