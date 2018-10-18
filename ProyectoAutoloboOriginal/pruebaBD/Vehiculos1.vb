Public Class Vehiculos1


    Private Sub VehiculoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VehiculoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Vehiculos1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Registro_Usuario = 2 Then
            BtnModificar.Enabled = False
        End If


        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        Me.VehiculoBindingSource.AddNew()

        DateTimePickerGnc.Value = Now
        DateTimePickerVtv.Value = Now
        DateTimePickerAno.Value = Now


    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        Dim dominio, marca, modelo, año, color, dueño, seguro, vtv, gnc, FechaHoy As String
        dominio = UCase(TextBoxDominio.Text)
        marca = TextBoxMarca.Text
        modelo = TextBoxModelo.Text
        año = DateTimePickerAno.Text
        color = TextBoxColor.Text
        dueño = TextBoxDueno.Text
        seguro = TextBoxSeguro.Text
        vtv = DateTimePickerGnc.Text
        gnc = DateTimePickerGnc.Text
        FechaHoy = Now
        If TextBoxDominio.Text <> "" Then
            If Len(TextBoxDominio.Text) >= 6 And Len(TextBoxDominio.Text) <= 7 Then

                If TextBoxMarca.Text <> "" Then
                    If TextBoxModelo.Text <> "" Then
                        If DateTimePickerAno.Text <> "" Then
                            If TextBoxColor.Text <> "" Then
                                If TextBoxDueno.Text <> "" Then
                                    If TextBoxSeguro.Text <> "" Then
                                        If DateTimePickerVtv.Value > FechaHoy Then
                                            If DateTimePickerGnc.Value > FechaHoy Then

                                                Me.VehiculoBindingSource.Current("dominio") = dominio
                                                Me.VehiculoBindingSource.Current("marca") = marca
                                                Me.VehiculoBindingSource.Current("modelo") = modelo
                                                Me.VehiculoBindingSource.Current("año") = año
                                                Me.VehiculoBindingSource.Current("color") = color
                                                Me.VehiculoBindingSource.Current("dueño") = dueño
                                                Me.VehiculoBindingSource.Current("seguro") = seguro
                                                Me.VehiculoBindingSource.Current("venc_gnc ") = gnc
                                                Me.VehiculoBindingSource.Current("venc_vtv") = vtv

                                                Me.Validate()
                                                Me.VehiculoBindingSource.Current.EndEdit() 'finalizo edicion

                                                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

                                                MsgBox("Registro guardado con exito")


                                                Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo) 'Actuliza el form en el que estas


                                                'respetar siempre el orden de las instrucciones


                                                'pasa el valor del ID a strig 'veo el dato que necesite


                                                Me.VehiculoBindingSource.AddNew() 'Para agregar el sig

                                                TextBoxDominio.Text = ""
                                                TextBoxMarca.Text = ""
                                                TextBoxModelo.Text = ""
                                                TextBoxColor.Text = ""
                                                TextBoxDueno.Text = ""
                                                TextBoxSeguro.Text = ""
                                                TextBoxDominio.Focus()

                                            Else

                                                MsgBox("La fecha de GNC es menor a la fecha del dia")
                                                DateTimePickerGnc.Focus()


                                            End If

                                        Else
                                            MsgBox("La fecha de VTV es menor a la fecha del dia")
                                            DateTimePickerVtv.Focus()


                                        End If
                                        Else
                                            MsgBox("El campo Seguro esta vacio")
                                            TextBoxSeguro.Focus()

                                        End If
                                    Else
                                        MsgBox("El campo dueño esta vacio")
                                        TextBoxDueno.Focus()

                                    End If
                                Else
                                    MsgBox("El campo color esta vacio")
                                    TextBoxColor.Focus()

                                End If
                            Else
                                MsgBox("El campo año esta vacio")
                                DateTimePickerAno.Focus()

                            End If
                        Else
                            MsgBox("El campo del modelo esta vacio")
                            TextBoxModelo.Focus()

                        End If

                    Else
                        MsgBox("El campo marca esta vacio")
                        TextBoxMarca.Focus()

                    End If
                Else
                    MsgBox("El campo dominio no contiene la cantidad de caracteres validos")
                    TextBoxDominio.Focus()

                End If
            Else
                MsgBox("El campo de dominio esta vacio")
                TextBoxDominio.Focus()
            End If

    End Sub

    Private Sub TextBoxConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxConsulta.TextChanged


        Dim vista As New DataView 'tipo de dato de la grilla
        vista.Table = Me.Database1DataSet.Vehiculo
        vista.RowFilter = "Convert (dominio,System.String) like  '" & TextBoxConsulta.Text & "%'"
        Me.VehiculoDataGridView.DataSource = vista 'actualizo la grilla


        'If TextBoxConsulta.Text = "" Then
        '    Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        'End If
        'no logro hacer que funcione la consulta en textbox

        'Dim vista As New DataView 'tipo de dato de la grilla
        'Dim consulta As String
        'consulta = TextBoxConsulta.Text

        'vista.Table = Me.Database1DataSet.Vehiculo
        'vista.RowFilter = "dominio = " & consulta

        'Me.VehiculoDataGridView.DataSource = vista 'actualizo la grilla

        

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click

        Me.Close()

    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If TextBoxConsulta.Text <> "" Then
        '    If Len(TextBoxConsulta.Text) >= 6 And Len(TextBoxConsulta.Text) <= 7 Then

        '        Me.VehiculoTableAdapter.FillBy((Me.Database1DataSet.Vehiculo), TextBoxConsulta.Text)

        '    Else
        '        MsgBox("El dominio consultado no contiene la cantidad de caracteres validos")
        '    End If
        'Else
        '    MsgBox("El campo de consulta esta vacio")

        'End If



    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click

        Dim fila As Integer
        If TextBoxConsulta.Text <> "" Then
            fila = Me.VehiculoBindingSource.Find("dominio", TextBoxConsulta.Text)


            If fila <> -1 Then

                ModificarVehiculos.Show()
                ModificarVehiculos.VehiculoTableAdapter.FillBy((ModificarVehiculos.Database1DataSet.Vehiculo), TextBoxConsulta.Text)
                ModificarVehiculos.DominioTextBox.Focus()

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