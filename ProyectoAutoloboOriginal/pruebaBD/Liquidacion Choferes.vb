Public Class Liquidacion_Choferes

    Private Sub ViajesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Liquidacion_Choferes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.ResumenRemiseria' Puede moverla o quitarla según sea necesario.
        Me.ResumenRemiseriaTableAdapter.Fill(Me.Database1DataSet.ResumenRemiseria)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiquidacionChofer' Puede moverla o quitarla según sea necesario.
        Me.LiquidacionChoferTableAdapter.Fill(Me.Database1DataSet.LiquidacionChofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Valores' Puede moverla o quitarla según sea necesario.
        Me.ValoresTableAdapter.Fill(Me.Database1DataSet.Valores)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)

        ComboBoxDueno.Text = ""

        Me.LiquidacionChoferBindingSource.AddNew()
        ' Resumen.LiquidacionChoferBindingSource.AddNew()
        '  Resumen.ResumenRemiseriaBindingSource.AddNew()
        Me.ResumenRemiseriaBindingSource.AddNew()
    End Sub

    Private Sub BtnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultar.Click

        'Dim i As Integer
        Dim estado As String 'ConsultaCodigo,
        estado = "Finalizado"
        'ConsultaCodigo = ComboBoxDueno.Text
        'i = 0
        'If ConsultaCodigo <> "" And IsNumeric(ConsultaCodigo) Then
        '    Do
        '        If ChoferBindingSource.Current("cod_chofer") = ConsultaCodigo Then


        Me.ViajesTableAdapter.FillBy((Me.Database1DataSet.Viajes), ComboBoxDueno.Text, estado, CDate(DateTimePickerDesde.Value), CDate(DateTimePickerHasta.Value))

        'TextBoxNombre.Text = ChoferBindingSource.Current("nombre")

        'LabelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") 'no hace falta

        'Exit Sub


        '        End If
        'i = i + 1


        '    Loop Until i = ChoferBindingSource.Count
        'MsgBox("No se encontro al chofer")
        'Else
        'MsgBox("El campo ID chofer esta vacio")

        'End If

    End Sub

    Private Sub BtnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalcular.Click

        Dim total As Double = 0
        Dim totAgencia, totChofer As Double
        Dim fila As DataGridViewRow = New DataGridViewRow
        Dim porcentjeChof, porcentajeAgenc As Double

        If CheckBoxDueno.Checked Then

            porcentjeChof = TextBoxPorcent.Text
            porcentajeAgenc = 100 - porcentjeChof

            For Each fila In ViajesDataGridView.Rows

                total += Convert.ToDouble(fila.Cells("DataGridViewTextBoxColumn6").Value)
            Next

            totAgencia = total * porcentajeAgenc / 100
            totChofer = total * porcentjeChof / 100

            TextBoxTotal.Text = Str(total)
            TextBoxTotAgencia.Text = Str(totAgencia)
            TextBoxTotChofer.Text = Str(totChofer)
        Else

            porcentjeChof = TextBoxPorcent.Text
            porcentajeAgenc = 100 - porcentjeChof

            For Each fila In ViajesDataGridView.Rows

                total += Convert.ToDouble(fila.Cells("DataGridViewTextBoxColumn6").Value)
            Next

            totAgencia = total * porcentajeAgenc / 100
            totChofer = total * porcentjeChof / 100

            TextBoxTotal.Text = Str(total)
            TextBoxTotAgencia.Text = Str(totAgencia)
            TextBoxTotChofer.Text = Str(totChofer)


        End If

    End Sub

    Private Sub CheckBoxDueno_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxDueno.CheckedChanged

        If CheckBoxDueno.Checked Then

            TextBoxPorcent.Text = ValoresBindingSource.Current("Dueño")

        Else

            TextBoxPorcent.Text = ValoresBindingSource.Current("remiseria")

        End If
    End Sub

    Private Sub BtnLiquidar_Click(sender As System.Object, e As System.EventArgs) Handles BtnLiquidar.Click


        'Dim nombre, idChofer As String
        'Dim total, totAgencia, totChofer As Double
        'Dim desde, hasta, fechaLiq As Date
        'total = TextBoxTotal.Text
        'totAgencia = TextBoxTotAgencia.Text
        'totChofer = TextBoxTotChofer.Text
        'desde =
        'hasta =
        'nombre = TextBoxNombre.Text
        'fechaLiq =  ' nose si hace falta el atributo fechaliq en la tabla liqchofer con la fecha en la que se genero la liq del chofer para hacer los consultas en el otro form
        'idChofer = ComboBoxDueno.Text




        Me.LiquidacionChoferBindingSource.Current("id_chofer") = Val(ComboBoxDueno.Text)
        'Me.LiquidacionChoferBindingSource.Current("fecha_liq") = fechaLiq
        Me.LiquidacionChoferBindingSource.Current("Desde") = DateTimePickerDesde.Value
        Me.LiquidacionChoferBindingSource.Current("Hasta") = DateTimePickerHasta.Value
        Me.LiquidacionChoferBindingSource.Current("Monto") = Val(TextBoxTotChofer.Text)
        Me.LiquidacionChoferBindingSource.Current("Nombre") = TextBoxNombre.Text



        '.LiquidacionChoferTableAdapter.Fill(.Database1DataSet.LiquidacionChofer) 'aca actualiza el form resumen liq chofer

        'Me.ResumenRemiseriaBindingSource.Current("fecha_liq") = fechaLiq
        'Me.ResumenRemiseriaBindingSource.Current("desde") = desde
        Me.ResumenRemiseriaBindingSource.Current("Fecha") = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
        Me.ResumenRemiseriaBindingSource.Current("Monto") = Val(TextBoxTotAgencia.Text)


        Me.Validate()
        Me.LiquidacionChoferBindingSource.Current.EndEdit()
        Me.ResumenRemiseriaBindingSource.Current.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        Resumen.TableAdapterManager.UpdateAll(Resumen.Database1DataSet)

        Me.LiquidacionChoferTableAdapter.Fill(Me.Database1DataSet.LiquidacionChofer)
        Me.ResumenRemiseriaTableAdapter.Fill(Me.Database1DataSet.ResumenRemiseria)


        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        'Resumen.LiquidacionChoferTableAdapter.Fill(Resumen.Database1DataSet.LiquidacionChofer)
        'Resumen.ResumenRemiseriaTableAdapter.Fill(Resumen.Database1DataSet.ResumenRemiseria) 'del otro  otro archivo no usar


        'Me.ResumenRemiseriaBindingSource.MoveLast()
        'Me.LiquidacionChoferBindingSource.MoveLast()


        MsgBox("Se liquido con exito")

        Me.LiquidacionChoferBindingSource.AddNew()

        Me.ResumenRemiseriaBindingSource.AddNew()

        'TextBoxTotal.Text = ""
        'TextBoxTotAgencia.Text = ""
        'TextBoxTotChofer.Text = ""
        'ComboBoxDueno.Text = ""
        'TextBoxNombre.Text = ""


        'else
        'MsgBox("El campo id chofer esta vacio")
        'ComboBoxDueno.Focus()

        'End If



    End Sub
End Class