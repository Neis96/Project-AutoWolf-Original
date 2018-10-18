Public Class Loggin

   

    Private Sub UsuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.UsuarioBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario1' Puede moverla o quitarla según sea necesario.
        Me.Usuario1TableAdapter.Fill(Me.Database1DataSet.Usuario1)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        'Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)
        Textbox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub ButtonIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub ButtonIngreso_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonIngreso.Click

        If Textbox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Todos los campos tienen que estar completos", "Ingreso")
            Textbox1.Text = ""
            TextBox2.Text = ""
            Textbox1.Focus()
        Else
            Dim consulta As Integer
            consulta = Me.Usuario1BindingSource.Find("id_usuario", Textbox1.Text)
            If consulta = -1 Then
                MsgBox("El usuario ingresado no existe", vbExclamation, "Ingreso")
                Textbox1.Text = ""
                TextBox2.Text = ""
                Textbox1.Focus()
            Else
                Me.Usuario1BindingSource.Position = consulta
                If Me.Usuario1BindingSource.Current("Contraseña") = TextBox2.Text Then
                    If Me.Usuario1BindingSource.Current("tipo") = "Usuario Normal" Then

                        Registro_Usuario = 2
                    Else
                        Registro_Usuario = 1
                    End If

                    Inicio.Show()
                    Textbox1.Text = ""
                    TextBox2.Text = ""
                    Me.Hide()

                Else

                    TextBox2.Text = ""
                    TextBox2.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub ButtonCancela_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancela.Click

        Close()

    End Sub
End Class