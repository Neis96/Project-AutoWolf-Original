Public Class Resumen

    Dim conexion As conexion = New conexion()
    Dim conexion2 As conexion = New conexion()

    Private Sub LiquidacionChoferBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.LiquidacionChoferBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)


    End Sub

    Public Sub MostrarResumen()

        conexion.Consulta("SELECT Registro, id_chofer, Nombre, Desde, Hasta, Monto FROM LiquidacionChofer", "LiquidacionChofer")
        DgvChofer.DataSource = conexion.ds.Tables("LiquidacionChofer")
        conexion2.Consulta("SELECT Registro, Fecha, Monto FROM ResumenRemiseria", "ResumenRemiseria")
        DgvAgencia.DataSource = conexion2.ds.Tables("ResumenRemiseria")

    End Sub

    Private Sub Resumen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.ResumenRemiseria' Puede moverla o quitarla según sea necesario.
        'Me.ResumenRemiseriaTableAdapter.Fill(Me.Database1DataSet.ResumenRemiseria)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiquidacionChofer' Puede moverla o quitarla según sea necesario.
        ' Me.LiquidacionChoferTableAdapter.Fill(Me.Database1DataSet.LiquidacionChofer)

        MostrarResumen()

    End Sub
End Class