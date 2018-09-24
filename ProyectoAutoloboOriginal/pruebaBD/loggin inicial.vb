Public Class loggin_inicial


    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub loggin_inicial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Database1DataSet.Usuario)
       

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.UsuarioTableAdapter.FillBy(Me.Database1DataSet.Usuario, TextBox1.Text, TextBox2.Text) Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("la constraseña es incorrecta")

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LOGIN.Show()
    End Sub
End Class
