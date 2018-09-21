Public Class FormAltaChofer

    Private Sub ButtonhomeChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.ChoferBindingSource.EndEdit() ' finalizo edicion
        Me.TableAdapterManager.UpdateAll(Me.ProjectAutoWolfOriginalDataSet) 'actualizo en altas
        MsgBox("datos guardados")
        'Esta linea va para la consulta y que se actualice
        'FormConsulta.ChoferTableAdapter.Fill(Me.ProjectAutoWolfOriginalDataSet.Chofer)
        Me.ChoferBindingSource.MoveLast()
        MsgBox("El codigo de chofer es:" + Me.ChoferBindingSource.Current("id").ToString)
        'me muestra el ID CHOFER que se creo y me lo transforma a cadena usando .ToString
        Me.ChoferBindingSource.AddNew()
    End Sub

    Private Sub Chofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProjectAutoWolfOriginalDataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.ProjectAutoWolfOriginalDataSet.Chofer)
        'TODO: esta línea de código carga datos en la tabla 'ProjectAutoWolfOriginalDataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.ProjectAutoWolfOriginalDataSet.Chofer)

    End Sub

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        ' Me.ChoferBindingSource.EndEdit()
        '  Me.TableAdapterManager.UpdateAll(Me.ProjectAutoWolfOriginalDataSet)

    End Sub

    Private Sub ChoferBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectAutoWolfOriginalDataSet)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        FormInicio.Show()
        Me.Hide()

    End Sub
End Class