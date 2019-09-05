Public Class ModificarSocios

    Private Sub SociosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub


    Private Sub SociosBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub


    Private Sub SociosBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub ModificarSocios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)

    End Sub

    Private Sub TextBoxConsulata2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Butconsulta2_Click(sender As System.Object, e As System.EventArgs)
        'Me.SociosTableAdapter.FillBy((Me.Database1DataSet.Socios), TextBoxConsulata2.Text)
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        'Socios.SociosTableAdapter.Fill(Socios.Database1DataSet.Socios)

    End Sub

    Private Sub ButModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButModificar.Click

        Dim aceptar As String

        If DniTextBox.Text = "" Then
            MsgBox("El campo de dominio esta vacio")
        Else
            aceptar = MsgBox("esta seguro que quiere modifica el registro?", vbQuestion + vbYesNo, "proceso")


            If aceptar = 6 Then
                Me.SociosTableAdapter.EditarSocios(NombreTextBox.Text, ApellidoTextBox.Text, DniTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, DniTextBox.Text)
                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
                Socios.SociosTableAdapter.Fill(Socios.Database1DataSet.Socios)


            Else


            End If

        End If


    End Sub

    Private Sub ButVolver_Click(sender As System.Object, e As System.EventArgs) Handles ButVolver.Click
        Me.Close()
    End Sub

    Private Sub ButEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButEliminar.Click

        Dim aceptar As String

        If DniTextBox.Text = "" Then
            MsgBox("El campo de dominio esta vacio")
        Else
            aceptar = MsgBox("esta seguro que quiere modifica el registro?", vbQuestion + vbYesNo, "proceso")


            If aceptar = 6 Then
                Me.SociosTableAdapter.EliminarSocio(DniTextBox.Text)
                Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)
                Socios.SociosTableAdapter.Fill(Socios.Database1DataSet.Socios)

            Else


            End If

        End If

    End Sub
End Class