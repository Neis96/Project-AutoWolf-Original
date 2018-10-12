Public Class RegistroUsuario

    Private Sub UsuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub RegistroUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.UsuarioTableAdapter.insertar(Usuarios_TextBox.Text, ContraseñasTextBox.Text, Nombre_TextBox.Text, Apelllido_TextBox.Text, AdministradorTextBox.Text)
        Me.Hide()
        Inicio.Show()
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)

        MsgBox("se ha registrado con exito")

    End Sub

    Private Sub ButtEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtEliminar.Click
        'Me.UsuarioTableAdapter.borrar(Usuarios_TextBox.Text)
        'Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)
        'eliminar
        'Dim fila, Usuario, aux As Integer
        'codConsulta = InputBox("Ingrese codigo de consulta")
        'fila = Me.UsuarioBindingSource.Find("Usuario", )
        'If fila = -1 Then
        'no se encuentra
        'MsgBox("no se encontro")
        'Else
        'lo encontro
        'Me.UsuarioBindingSource.Position = fila 'situo el puntero en la fila buscada
        'aux = MsgBox("Quiere eliminar?" & codConsulta)
        'If aux = 1 Then 'apreto si
        'Me.UsuarioBindingSource.RemoveCurrent() 'borra el registro donde estas situado
        'Me.UsuarioBindingSource.EndEdit() 'cierro bd
        'Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guarda 

        'Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario) ' actualiza el form anterior


        'End If
        'End If


    End Sub
End Class