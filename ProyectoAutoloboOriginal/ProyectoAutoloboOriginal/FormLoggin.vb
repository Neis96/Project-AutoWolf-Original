Public Class FormLoggin

    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            If usuarioRegistrado(TextUsuario.Text) = True Then
                Dim contra As String = contrasena(TextUsuario.Text)
                If contra.Equals(TextContrasena.Text) = True Then
                    FormInicio.ShowDialog()

                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + TextUsuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class