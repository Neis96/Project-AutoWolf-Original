Public Class ResumenCtaCte

    Private Sub LiqCtaCtrBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LiqCtaCtrBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub ResumenCtaCte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.LiqCtaCtr' Puede moverla o quitarla según sea necesario.
        Me.LiqCtaCtrTableAdapter.Fill(Me.Database1DataSet.LiqCtaCtr)

        'Pongo los time picker en hora
        DesdePick.Value = Now
        HastaPick.Value = Now

    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Dim idSocio As Integer = Val(Socio.Text)




        Me.LiqCtaCtrTableAdapter.ConsultaCta((Me.Database1DataSet.LiqCtaCtr), idSocio, DesdePick.Value, HastaPick.Value)
    End Sub
End Class