Public Class LiquidacionCta

    Dim vista As conexion = New conexion()
    Dim cta As String = "si"

    Private Sub LiquidacionCta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiqCtaCtr' Puede moverla o quitarla según sea necesario.
        Me.LiqCtaCtrTableAdapter.Fill(Me.Database1DataSet.LiqCtaCtr)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
        'Dim HoraActual As Date = dateNow
        Me.LiqCtaCtrBindingSource.AddNew()
        DatePickHasta.Value = Now
        'TimePickDesde.Value = Now
        Me.ViajesTableAdapter.FillBy2((Me.Database1DataSet.Viajes), cta)
        'mostrar()

    End Sub

    'Public Sub mostrar()
    '    vista.Consulta("select registro, idsocios ,fecha_origen, fecha_destino, total ,lugar_origen, lugar_destino, cta_cte FROM viajes where cta_cte= 'si' AND estado = 'Finalizado'", "viajes")
    '    ' DgvViajesCta.DataSource = vista.ds.Tables("Viajes")

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        'Boton Consultar
        'Dim tabla As conexion = New DataTable
        Dim estado As String
        'cta = "si"
        estado = "finalizado"
        Dim socio As Integer = Val(TextSocio.Text)
        Me.ViajesTableAdapter.FillBy1((Me.Database1DataSet.Viajes), socio, cta, estado, TimePickDesde.Value, DatePickHasta.Value)
        'mostrar()


        'vista.Consulta("Select registro, idsocios ,fecha_origen, fecha_destino, total ,lugar_origen, lugar_destino, cta_cte FROM viajes where cta_cte= 'si' AND estado = 'Finalizado' AND idSocios=" & socio & "," + "AND fecha_destino BETWEEN" + CDate(TimePickDesde.Value) + "," + CDate(DatePickHasta.Value), "Viajes")
        ' DgvViajesCta.DataSource = vista.ds.Tables("viajes")
    End Sub

    Private Sub ViajesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow
        For Each fila In Viajes2DataGridView.Rows

            total += Convert.ToDouble(fila.Cells("DataGridViewTextBoxColumn6").Value)
        Next fila

        TextBoxTotal.Text = total

    End Sub

    Private Sub BtnLiquidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLiquidar.Click


        Me.LiqCtaCtrBindingSource.Current("id_Socio") = Val(TextSocio.Text)
        Me.LiqCtaCtrBindingSource.Current("Desde") = TimePickDesde.Value
        Me.LiqCtaCtrBindingSource.Current("Hasta") = DatePickHasta.Value
        Me.LiqCtaCtrBindingSource.Current("Monto") = Val(TextBoxTotal.Text)
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Me.Validate()
        Me.LiqCtaCtrBindingSource.EndEdit()
        ResumenCtaCte.LiqCtaCtrTableAdapter.Fill(ResumenCtaCte.Database1DataSet.LiqCtaCtr)


    End Sub
End Class