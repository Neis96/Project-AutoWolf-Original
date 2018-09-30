Public Class reservas

    Private Sub ReservaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReservaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub reservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Database1DataSet.Reserva)

    End Sub
End Class