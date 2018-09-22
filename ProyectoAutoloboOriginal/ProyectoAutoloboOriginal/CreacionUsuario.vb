Public Class CreacionUsuario

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectAutoWolfOriginalDataSet)

    End Sub

    Private Sub CreacionUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProjectAutoWolfOriginalDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ProjectAutoWolfOriginalDataSet.Usuarios)
        Me.UsuariosBindingSource.AddNew()
    End Sub

    Private Sub UsuariosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellContentClick

    End Sub

    Private Sub BtnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrear.Click
        Dim usuario, contrasenia As String
        usuario = RTrim(UsuarioTextBox.Text)
        contrasenia = RTrim(ContrasenaTextBox.Text)
        Me.UsuariosBindingSource.EndEdit() ' finalizo edicion


        Me.TableAdapterManager.UpdateAll(Me.ProjectAutoWolfOriginalDataSet) 'actualizo en altas
        MsgBox("datos guardados")
        ' Principal.StockTableAdapter.Fill(Principal.FerreteriaDataSet.Stock) 'actualiza el dataSet del formulario principal
        Me.UsuariosBindingSource.MoveLast()
        MsgBox("Se ha creado exitosamente el usuario" + Me.UsuariosBindingSource.Current("Usuario").ToString)
        'me muestra el usuario que se creo y me lo transforma a cadena usando .ToString
        'Me.UsuariosBindingSource.AddNew()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class