Public Class Vehiculos1


    Private Sub VehiculoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehiculoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Vehiculos1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        Me.VehiculoBindingSource.AddNew()

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If DominioTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            DominioTextBox.Focus()
        Else

            Me.VehiculoBindingSource.EndEdit() 'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")



            Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo) 'Actuliza el form en el que estas

            Me.VehiculoBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            Me.VehiculoBindingSource.AddNew() 'Para agregar el sig

            DominioTextBox.Focus()

        End If

    End Sub

    Private Sub TextBoxConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxConsulta.TextChanged

        

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click

        Me.Close()

    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click

        Me.VehiculoTableAdapter.FillBy((Me.Database1DataSet.Vehiculo), TextBoxConsulta.Text)



    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click

        Dim fila As Integer
        If TextBoxConsulta.Text <> "" Then
            fila = Me.VehiculoBindingSource.Find("dominio", TextBoxConsulta.Text)


            If fila <> -1 Then

                ModificarVehiculos.Show()


                'textbox si quiero que me muestre en los dos
                


            Else
                MsgBox("El registro no se encotro")
            End If
        Else
            MsgBox("El campo esta vacio")
        End If

    End Sub

    Private Sub VehiculoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VehiculoDataGridView.CellContentClick

        'no utilizar

    End Sub
End Class