Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Cls_Conexion

    Protected conn As New SqlConnection
    Event msgError(descripcion As String)

    Public Function Conectado(Optional cadenaConexion = Nothing)
        Dim cadena As String
        If cadenaConexion = Nothing Then
            cadena = ConfigurationManager.ConnectionStrings("SpintText.My.MySettings.SpinTextoConnectionString").ConnectionString
        Else
            cadena = cadenaConexion
        End If

        Try
            conn = New SqlConnection(cadena)
            conn.Open()
            Return True
        Catch ex As Exception
            RaiseEvent msgError(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectado()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            RaiseEvent msgError(ex.Message)
            Return False
        End Try
    End Function

End Class
