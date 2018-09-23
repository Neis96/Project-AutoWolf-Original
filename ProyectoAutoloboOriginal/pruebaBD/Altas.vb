Public Class Altas

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If NombreTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            NombreTextBox.Focus()
        Else
            Me.Validate()
            Me.ChoferBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")

            Form1.ChoferTableAdapter.Fill(Form1.Database1DataSet.Chofer) 'actuliza el form principal

            Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer) 'Actuliza el form en el que estas

            Me.SociosBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            'MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("Id")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.ChoferBindingSource.AddNew()

            NombreTextBox.Focus()

        End If
    End Sub

    Private Sub ChoferBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ChoferBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Altas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.Database1DataSet.Chofer)

        Me.ChoferBindingSource.AddNew()
        Me.ViajesBindingSource.AddNew()
        Me.SociosBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If NombreTextBox1.Text = "" Then
            MsgBox("El campo esta vacio")
            NombreTextBox1.Focus()
        Else
            Me.Validate()
            Me.SociosBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")

            Form1.SociosTableAdapter.Fill(Form1.Database1DataSet.Socios)  'actuliza el form principal

            Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios) 'Actuliza el form en el que estas

            Me.SociosBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            ' MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("id")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.SociosBindingSource.AddNew()

            NombreTextBox.Focus()

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If NombreTextBox.Text = "" Then
            MsgBox("El campo esta vacio")
            NombreTextBox.Focus()
        Else
            Me.Validate()
            Me.SociosBindingSource.EndEdit()  'finalizo edicion

            Me.TableAdapterManager.UpdateAll(Me.Database1DataSet) 'guardo en disco

            MsgBox("Registro guardado con exito")

            'Home.StockTableAdapter.Fill(Home.VideoClubDataSet.Stock) 'actuliza el form principal

            Me.SociosTableAdapter.Fill(Me.Database1DataSet.Socios) 'Actuliza el form en el que estas

            Me.SociosBindingSource.MoveLast() 'ver ultimo agragado 

            'respetar siempre el orden de las instrucciones

            MsgBox("El codigo de socio es es: " & SociosBindingSource.Current("Registro")) 'te muestra el registro en el que estas parado
            'pasa el valor del ID a strig 'veo el dato que necesite

            Me.ViajesBindingSource.AddNew()

            NombreTextBox.Focus()

        End If
    End Sub
End Class