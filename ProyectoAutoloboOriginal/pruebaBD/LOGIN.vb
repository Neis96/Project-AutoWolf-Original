Public Class LOGIN

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub LOGIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)

    End Sub

    Private Sub Buttonregistro_Click(sender As System.Object, e As System.EventArgs) Handles Buttonregistro.Click
        Me.UsuarioTableAdapter.Insert(AdministradorTextBox.Text, Usuarios_TextBox.Text, ContraseñasTextBox.Text, Nombre_TextBox.Text, Apelllido_TextBox.Text) 'este para cargar en la base de datos nuevos ususario 
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)



    End Sub

    Private Sub ButtonCancelar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Hide()
        loggin_inicial.Show()


    End Sub
End Class