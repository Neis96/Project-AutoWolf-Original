Public Class Loggin

   

    Private Sub UsuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)

    End Sub

    Private Sub ButtonIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIngreso.Click
        If Me.UsuarioTableAdapter.FillBy(Me.Database1DataSet.Usuario, TbUsuario.Text, TbContraseña.Text) Then
            Me.Hide()
            Inicio.Show()
            Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)
        Else
            MsgBox("el usuario o la contraseña es incorrecta")
        End If
    End Sub
End Class