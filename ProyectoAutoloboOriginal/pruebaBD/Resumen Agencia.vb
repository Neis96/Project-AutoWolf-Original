Public Class Resumen_Agencia

    Private Sub ResumenRemiseriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ResumenRemiseriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Resumen_Agencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.ResumenRemiseria' Puede moverla o quitarla según sea necesario.
        Me.ResumenRemiseriaTableAdapter.Fill(Me.Database1DataSet.ResumenRemiseria)

    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click

        Me.ResumenRemiseriaTableAdapter.consultarem((Me.Database1DataSet.ResumenRemiseria), CDate(DateTimePickerDesde.Value), CDate(DateTimePickerHasta.Value))

    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click

        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow


        For Each fila In ResumenRemiseriaDataGridView.Rows

            total += Convert.ToDouble(fila.Cells("DataGridViewTextBoxColumn3").Value)
        Next

        TextBoxTotal.Text = Str(total)

    End Sub
End Class