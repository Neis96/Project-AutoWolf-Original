Public Class ModificarChofer

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub ModificarChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)

    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Dim chofer As Integer
        chofer = Id_choferComboBox.SelectedItem
        If Id_choferComboBox.Text = "" Then
            MsgBox("Porfavor seleccione el ID correspondiente antes de modificar")
        Else
            Me.ChoferBindingSource.Current("id_chofer") = chofer
            Me.Validate()
            Me.ChoferBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

        End If
   
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim fila, codConsulta, aux As Integer
        codConsulta = Id_choferComboBox.SelectedItem
        fila = Me.ChoferBindingSource.Find("id_chofer", codConsulta)
        If fila = -1 Then
            'no se encuentra
            MsgBox("no se encontro")
        Else
            'lo encontro
            Me.ChoferBindingSource.Position = fila 'situo el puntero en la fila buscada
            aux = MsgBox("Quiere eliminar?" & "" & codConsulta)
            If aux = 1 Then 'apreto si
                Me.ChoferBindingSource.RemoveCurrent() 'borra el registro donde estas situado
                Me.ChoferBindingSource.EndEdit() 'cierro bd
                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guarda 

                Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer) ' actualiza el form anterior


            End If
        End If

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Inicio.Show()
        Me.Close()

    End Sub
End Class