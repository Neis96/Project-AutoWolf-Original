Public Class Resumen_Chofer

    Private Sub LiquidacionChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LiquidacionChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Resumen_Chofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiquidacionChofer' Puede moverla o quitarla según sea necesario.
        Me.LiquidacionChoferTableAdapter.Fill(Me.Database1DataSet.LiquidacionChofer)

        DateTimePickerDesde.Value = Now
        DateTimePickerHasta.Value = Now

    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click

        Dim i As Integer
        Dim ConsultaCodigo, estado As String '
        estado = "Finalizado"
        ConsultaCodigo = ComboBoxDueno.Text
        i = 0
        If ConsultaCodigo <> "" And IsNumeric(ConsultaCodigo) Then
            Do
                If ChoferBindingSource.Current("id_chofer") = ConsultaCodigo Then



                    Me.LiquidacionChoferTableAdapter.Consulta((Me.Database1DataSet.LiquidacionChofer), ConsultaCodigo, CDate(DateTimePickerDesde.Value), CDate(DateTimePickerHasta.Value))

                    TextBoxNombre.Text = ChoferBindingSource.Current("nombre")


                    'LabelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") 'no hace falta

                    Exit Sub


                End If
                i = i + 1


            Loop Until i = ChoferBindingSource.Count
            MsgBox("No se encontro al chofer")
        Else
            MsgBox("El campo ID chofer esta vacio o se ingreso un dato no numerico")

        End If
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click

        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow


        For Each fila In LiquidacionChoferDataGridView.Rows

            total += Convert.ToDouble(fila.Cells("DataGridViewTextBoxColumn4").Value)
        Next

        TextBoxTotal.Text = Str(total)


    End Sub
End Class