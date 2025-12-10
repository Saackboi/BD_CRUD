Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module CONEXION_BIBLIOTECA

    Public CONEXION As New SqlConnection("Server=localhost; Database=DB_CRUD_VB_SQLSERVER_BIBLIOTECJA_ASPNET;User Id=kevin;Password=12345")

    Public Sub CONECTAR_BIBLIOTECA()
        Try
            ' Se verifica si la conexion esta cerrada
            If CONEXION.State = ConnectionState.Closed Then
                CONEXION.Open() ' Abrimos la conexion
            End If
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION A LA BASE DE DATOS" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR DE CONEXION")
        End Try
    End Sub

    Public Sub DESCONECTAR_BIBLIOTECA()
        Try
            ' Cerrar la conexion solo si esta abierta, pa evitar errores
            If CONEXION.State = ConnectionState.Open Then
                CONEXION.Close() ' Cerramos para liberar recursos, IMPORTANTE NUNCA dejarla abierta
            End If
        Catch ex As Exception
            MsgBox("ERROR AL DESCONECTAR DE LA BASE DE DATOS" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR DE CONEXION")
        End Try
    End Sub

End Module
