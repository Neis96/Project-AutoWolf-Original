Public Class Vehiculos

    Private Sub VehiculoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehiculoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Vehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo)
        Me.VehiculoBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If DominioTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            DominioTextBox.Focus()
        Else
            Me.Validate()
            Me.VehiculoBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")

            Me.VehiculoTableAdapter.Fill(Me.Database1DataSet.Vehiculo) 'Actuliza el form en el que estas

            Me.VehiculoBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            'MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("Id")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.VehiculoBindingSource.AddNew()

            DominioTextBox.Focus()
        End If
    End Sub

    Private Sub TextBoxConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxConsulta.TextChanged

        Dim vista As New DataView 'tipo de dato de la grilla
        vista.Table = Me.Database1DataSet.Vehiculo
        vista.RowFilter = "dominio = " & (TextBoxConsulta.Text)
        Me.VehiculoBindingSource.DataSource = vista 'actualizo la grilla

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click


    End Sub
End Class