Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module CONEXION_BIBLIOTECA

    ' ACA DEBES REEMPLAZAR (localdb)\MSSQLLocalDB y la clave por tu configuración real de SQL Server '
    Public CONEXION As New SqlConnection(
    "Server=localhost\SQLEXPRESS;Database=DB_CRUD_VB_SQLSERVER_BIBLIOTECJA_ASPNET;User Id=sa;Password=@Jhair5223;"
       )

    Public Sub CONECTAR_BIBLIOTECA()
        Try
            ' se verifica si la conexion esta cerrada’
            If CONEXION.State = ConnectionState.Closed Then
                CONEXION.Open() ' abrimos la conexion ‘ 
            End If
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION A LA BASE DE DATOS" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR DE CONEXION")
        End Try
    End Sub

    Public Sub DESCONECTAR_BIBLIOTECA()
        Try
            ' cerrar la conexion solo si esta abierta, pa evitar errores 
            If CONEXION.State = ConnectionState.Open Then
                CONEXION.Close() ' cerramos para liberar recursos, IMPORTANTE NUNCA dejarla abierta
            End If
        Catch ex As Exception
            MsgBox("ERROR AL DESCONECTAR DE LA BASE DE DATOS" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR DE CONEXION")
        End Try
    End Sub


End Module