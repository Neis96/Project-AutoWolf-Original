Public Class Configuracion
    Dim valordueno As New conexion
    Dim valorRemo As New conexion
    Dim valorKms As New conexion
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()


    End Sub

    Public Sub mostrar()
        valordueno.Consulta("SELECT DUEÑO FROM VALORES WHERE ID= 1", "Valores")
        TextDueno.Text = Val(valordueno.ds.Tables("Valores"))
        valorRemo.Consulta("Select remiseria from valores where id= 1", "valores")
        TextRemo.Text = Val(valorRemo.ds.Tables("Valores"))
        valorKms.Consulta("select kms from valores where id= 1", "valores")
        TextKms.Text = Val(valorKms.ds.Tables("valores"))

    End Sub
End Class