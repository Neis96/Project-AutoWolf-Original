﻿Public Class Finalizar_Viaje

    'Const idValor As Integer = 1
    'Public valorKm As New DataColumn  = Me.ValoresTableAdapter.FillBy((Database1DataSet.Valores), idValor)
    'Public Minimo As Double = Me.ValoresTableAdapter.ValorMinimo((Database1DataSet.Valores), idValor)

    Private Sub Finalizar_Viaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Valores' Puede moverla o quitarla según sea necesario.
        Me.ValoresTableAdapter.Fill(Me.Database1DataSet.Valores)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
        'cargo el combobox
        ComboBox1.Items.Add("Reserva")
        ComboBox1.Items.Add("En curso")
        ComboBox1.Items.Add("Finalizado")
        ComboBox1.Text = "Seleccione el estado actual"

        HastaPick.Value = Now
        'TextBoxEstado.Text = "Finalizado"
        'TextBoxEstado.Enabled = False
        BtnTerminar.Enabled = False
        TextBox3.Text = ValoresBindingSource.Current("Minimo")
        TextValorKms.Text = ValoresBindingSource.Current("kms")
        TextValorKms.Enabled = False
        TextBox3.Enabled = False 'este es el textbox del valor minimo
        TextBox1.Enabled = False 'textbox de registro para que no sea modificable


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vista As New DataView
        vista.Table = Me.Database1DataSet.Viajes
        vista.RowFilter = "Registro = " & Val(Me.TextBox1.Text)
        Me.ViajesDataGridView.DataSource = vista 'ACTUALIZO LA GRILLA
    End Sub

    Private Sub BtnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTerminar.Click
        Dim fila, codConsulta, aux As Integer
        Dim total As Double
        'el total queda en comentarios hasta agregar funcionamiento
        Dim estado As String = ComboBox1.Text
        total = Val(TextBoxTotal.Text)
        codConsulta = Val(TextBox1.Text)
        fila = Me.ViajesBindingSource.Find("Registro", codConsulta)
        If fila = -1 Then
            MsgBox("no se encontro el viaje")
        Else
            'se encontro
            ViajesBindingSource.Position = fila ' muevo el cursor a la fila obtenida con nuestra variable "fila"
            aux = MsgBox("Desea finalizar el viaje(Recuerde que esta accion es definitiva, revise atentamente los datos):" & codConsulta, 32 + 1, "Finalizar")
            If aux = 1 Then
                Me.ViajesBindingSource.Current("Estado") = estado
                Me.ViajesBindingSource.Current("fecha_destino") = HastaPick.Value
                Me.ViajesBindingSource.Current("Total") = total
                'habilitar la linea de arriba cuando se agregue el total
                MsgBox("el viaje se ha finalizado con exito")
                Me.Validate()

                Me.ViajesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
                Me.ViajesTableAdapter.Fill(Me.Database1DataSet.Viajes)
                Inicio.ViajesTableAdapter.Fill(Inicio.Database1DataSet.Viajes)
                Me.Close()

            End If
        End If
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim TotalCalculado As Double
        If TextBoxKms.Text <> "" Then
            TotalCalculado = (Val(TextBoxKms.Text) * TextValorKms.Text) + TextBox3.Text
            TextBoxTotal.Text = TotalCalculado
            BtnTerminar.Enabled = True

        Else
            MsgBox("por favor ingrese la cantidad de Kms Realizados")
            Exit Sub
        End If





    End Sub
End Class