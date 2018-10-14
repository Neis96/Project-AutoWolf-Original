Public Class Socios

    Private Sub SociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SociosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Socios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Registro_Usuario = 2 Then
            Button2.Enabled = False
        End If
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)

    End Sub

    Private Sub ButAgregar_Click(sender As System.Object, e As System.EventArgs) Handles ButAgregar.Click
        If NombreTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            NombreTextBox.Focus()
        Else

            Me.SociosBindingSource.EndEdit() 'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")



            Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios) 'Actuliza el form en el que estas

            Me.SociosBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            Me.SociosBindingSource.AddNew() 'Para agregar el sig

            NombreTextBox.Focus()

        End If
    End Sub

    Private Sub ButConsulta_Click(sender As System.Object, e As System.EventArgs) Handles ButConsulta.Click
        Me.SociosTableAdapter.FillBy((Me.Database1DataSet.Socios), TextBoxconsultasocio.Text)


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        ModificarSocios.Show()



            
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class