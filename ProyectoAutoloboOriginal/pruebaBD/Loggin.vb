Public Class Loggin

   

    Private Sub UsuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)

    End Sub

    Private Sub ButtonIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIngreso.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Todos los campos tienen que estar completos", "Ingreso")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        Else
            Dim consulta As Integer
            consulta = Me.UsuarioBindingSource.Find("id_Usuario", Textbox1.Text)
            If consulta = -1 Then
                MsgBox("El usuario ingresado no existe", vbExclamation, "Ingreso")
                Textbox1.Text = ""
                TextBox2.Text = ""
                Textbox1.Focus()
            Else
                Me.UsuarioBindingSource.Position = consulta
                If Me.UsuarioBindingSource.Current("Contraseña") = TextBox2.Text Then
                    If Me.UsuarioBindingSource.Current("tipo") = "Usuario Normal" Then

                        Registro_Usuario = 2
                    Else
                        Registro_Usuario = 1
                    End If
                    Inicio.Show()
                    Me.Hide()
                Else

                    TextBox2.Text = ""
                    TextBox2.Focus()
                End If
            End If
        End If
    End Sub
End Class