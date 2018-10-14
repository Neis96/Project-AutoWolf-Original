Public Class choferes

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub choferes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Registro_Usuario = 2 Then
            Button1.Enabled = False
            Button2.Enabled = False
        End If
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)

    End Sub

    Private Sub ButtonSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSocios.Click
        If NombreTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            NombreTextBox.Focus()
        Else
            Me.Validate()
            Me.ChoferBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")



            Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer) 'Actuliza el form en el que estas

            Me.ChoferBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            'MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("Id")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.ChoferBindingSource.AddNew()

            NombreTextBox.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'eliminar
        Dim fila, codConsulta, aux As Integer
        codConsulta = InputBox("Ingrese codigo de consulta")
        fila = Me.ChoferBindingSource.Find("id", codConsulta)
        If fila = -1 Then
            'no se encuentra
            MsgBox("no se encontro")
        Else
            'lo encontro
            Me.ChoferBindingSource.Position = fila 'situo el puntero en la fila buscada
            aux = MsgBox("Quiere eliminar?" & codConsulta)
            If aux = 1 Then 'apreto si
                Me.ChoferBindingSource.RemoveCurrent() 'borra el registro donde estas situado
                Me.ChoferBindingSource.EndEdit() 'cierro bd
                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guarda 

                Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer) ' actualiza el form anterior


            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim direccion, nombre, apellido As String
        Dim telefono, dni, id As Integer
        direccion = DireccionTextBox.Text
        nombre = NombreTextBox.Text
        apellido = ApellidoTextBox.Text
        telefono = TelefonoTextBox.Text
        dni = DniTextBox.Text
        id = Id_choferTextBox.Text
        Me.ChoferTableAdapter.EsUnaCagada(telefono, direccion, dni, nombre, apellido, id)
    End Sub

    Private Sub DireccionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DireccionTextBox.TextChanged

    End Sub
End Class