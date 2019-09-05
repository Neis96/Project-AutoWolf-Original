Public Class Configuracion
    Dim valordueno As New conexion
    Dim valorRemo As New conexion
    Dim valorKms As New conexion
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Valores' Puede moverla o quitarla según sea necesario.
        Me.ValoresTableAdapter.Fill(Me.Database1DataSet.Valores)
        'mostrar()
        'este evento se ejcuta cuando hay un cambio en el texbox
        Dim vista As New DataView
        vista.Table = Me.Database1DataSet.Valores
        vista.RowFilter = "Id = 1 "
        Me.ValoresBindingSource.DataSource = vista 'ACTUALIZO LA GRILLA

    End Sub

    'Public Sub mostrar()
    '    valordueno.Consulta("SELECT DUEÑO FROM VALORES WHERE ID= 1", "Valores")
    '    TextDueno.Text = Val(valordueno.ds.Tables("Valores"))
    '    valorRemo.Consulta("Select remiseria from valores where id= 1", "valores")
    '    TextRemo.Text = Val(valorRemo.ds.Tables("Valores"))
    '    valorKms.Consulta("select kms from valores where id= 1", "valores")
    '    TextKms.Text = Val(valorKms.ds.Tables("valores"))

    'End Sub

    Private Sub ValoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ValoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class