Imports System.Data
Imports System.Data.SqlServerCe

Public Class conexion
    Public conexion As New SqlCeConnection("Data Source=C:\Users\thoma\Desktop\thom\programacion\Ejercicios visual\krak\Project-AutoWolf-Original\ProyectoAutoloboOriginal\pruebaBD\PruebaLocalConeccion.sdf")
    Private cmb As SqlCeCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlCeDataAdapter
    Public comando As SqlCeCommand




    Public Sub conectar()
        Try
            conexion.Open()
            MsgBox("conectado")
        Catch ex As Exception
            MsgBox("error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Clear()

        da = New SqlCeDataAdapter(sql, conexion)
        cmb = New SqlCeCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub
End Class
