Public Class Socios

    Private Sub SociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Socios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Registro_Usuario = 2 Then
            Button2.Enabled = False
        End If

        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        ' Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)



    End Sub

    Private Sub ButAgregar_Click(sender As System.Object, e As System.EventArgs) Handles ButAgregar.Click


        Dim Nombre, Apellido, Dni, direccion, telefono As String
        Nombre = TextBoxNombr.Text
        Apellido = TextBoxApellido.Text
        Dni = TextBoxDni.Text
        direccion = TextBoxdireccion.Text
        telefono = TextBoxtelefono.Text

        If TextBoxDni.Text <> "" Then
            If Len(TextBoxDni.Text) = 8 Then

                If TextBoxNombr.Text <> "" Then
                    If TextBoxApellido.Text <> "" Then
                        If TextBoxdireccion.Text <> "" Then
                            If TextBoxtelefono.Text <> "" Then
                                If Len(TextBoxtelefono.Text) >= 8 And Len(TextBoxtelefono.Text) <= 10 Then

                                    Me.SociosBindingSource.Current("nombre") = Nombre
                                    Me.SociosBindingSource.Current("apellido") = Apellido
                                    Me.SociosBindingSource.Current("dni") = Dni
                                    Me.SociosBindingSource.Current("direccion") = direccion
                                    Me.SociosBindingSource.Current("telefono") = telefono


                                    Me.Validate()
                                    Me.SociosBindingSource.Current.EndEdit() 'finalizo edicion

                                    Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

                                    MsgBox("Registro guardado con exito")


                                    Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios) 'Actuliza el form en el que estas


                                    'respetar siempre el orden de las instrucciones


                                    'pasa el valor del ID a strig 'veo el dato que necesite

                                    Me.SociosBindingSource.AddNew() 'Para agregar el sig


                                    TextBoxtelefono.Text = ""
                                    TextBoxDni.Text = ""
                                    TextBoxdireccion.Text = ""
                                    TextBoxApellido.Text = ""
                                    TextBoxNombr.Text = ""
                                    TextBoxDni.Focus()
                                Else
                                    MsgBox("El campo le faltan digitos")
                                    TextBoxtelefono.Focus()

                                End If
                            Else
                                MsgBox("El campo telefono esta vacio")
                                TextBoxtelefono.Focus()

                            End If
                        Else
                            MsgBox("El campo direccion esta vacio")
                            TextBoxdireccion.Focus()

                        End If
                    Else
                        MsgBox("El campo apellido esta vacio")
                        TextBoxApellido.Focus()

                    End If
                Else
                    MsgBox("El campo nombre esta vacio")
                    TextBoxNombr.Focus()

                End If

            Else
                MsgBox("El campo Dni le falta digitos")
                TextBoxDni.Focus()

            End If
        Else
            MsgBox("El campo Dni esta vacio")
            TextBoxDni.Focus()

        End If




    End Sub

    Private Sub ButConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.SociosTableAdapter.FillBy((Me.Database1DataSet.Socios), TextBoxconsultasocio.Text)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ModificarSocios.Show()




    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBoxconsultasocio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxconsultasocio.TextChanged

        'If IsNumeric(TextBoxConsulta.Text) Then
        Dim vista As New DataView 'tipo de dato de la grilla
        vista.Table = Me.Database1DataSet.Socios
        vista.RowFilter = "Convert (dni,System.String) like  '" & TextBoxconsultasocio.Text & "%'"
        Me.SociosDataGridView.DataSource = vista 'actualizo la grilla
        'Else
        'MsgBox("el valor que se ingreso no es numerico")
        'End If


    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click




        Dim fila As Integer
        If TextBoxconsultasocio.Text <> "" Then
            fila = Me.SociosBindingSource.Find("dni", TextBoxconsultasocio.Text)


            If fila <> -1 Then

                ModificarSocios.Show()
                ModificarSocios.SociosTableAdapter.FillBy((ModificarSocios.Database1DataSet.Socios), TextBoxconsultasocio.Text)
                ModificarSocios.DniTextBox.Focus()

                'textbox si quiero que me muestre en los dos



            Else
                MsgBox("El registro no se encotro")
            End If
        Else
            MsgBox("El campo esta vacio")
        End If


    End Sub
End Class