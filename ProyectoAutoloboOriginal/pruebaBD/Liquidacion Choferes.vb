Public Class Liquidacion_Choferes

    Private Sub ViajesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Liquidacion_Choferes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)

    End Sub
End Class