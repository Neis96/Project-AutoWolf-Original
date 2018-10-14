Imports System.Data
Imports System.Data.SqlServerCe

Public Class conexion
    Public conexion As New SqlCeConnection("Data Source=C:\Users\user\Desktop\GITKRAKEN\Project-AutoWolf-Original\ProyectoAutoloboOriginal\pruebaBD\bin\Debug\PruebaLocalConeccion.sdf")
    Private cmb As SqlCeCommandBuilder
    Public ds As DataSet = New Database1DataSet() 'C:\Users\user\Desktop\GITKRAKEN\Project-AutoWolf-Original\ProyectoAutoloboOriginal\pruebaBD\bin\Debug\PruebaLocalConeccion.sdf
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
        ds.Tables.Clear()

        da = New SqlCeDataAdapter(sql, conexion)
        cmb = New SqlCeCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub

    'Public Sub actualizar(ByRef tabla As String)
    '    ' da = New SqlCeDataAdapter()
    '    'da.Fill(ds, tabla)
    'End Sub


    'Function insertar(ByVal sql)
    '    conexion.Open()
    '    comando = New SqlCeCommand(sql, conexion)
    '    Dim i As Integer = comando.ExecuteNonQuery()
    '    conexion.Close()
    '    If i > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

End Class
