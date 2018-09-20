Public Class Loggin

    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboUsuario.Items.Add(admin)
        ComboUsuario.Items.Add(user1)
        ComboUsuario.Items.Add(user2)

    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Dim usuario As String
        Dim password As String
        usuario = ComboUsuario.SelectedItem
        password = TextPass.Text
        If password = "" Then
            MsgBox("No se ingreso una contraseña", MsgBoxStyle.Exclamation, "error")
        End If
    End Sub

    Private Sub TextPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPass.TextChanged
        
    End Sub
End Class