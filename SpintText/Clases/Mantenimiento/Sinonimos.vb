Imports System.Data.SqlClient

Public Class Sinonimos
    Inherits Cls_Conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos
    Event msgErrorSinonimo(descripcion As String)

    Dim _idsinonimo, _idtitulo As Integer
    Dim _sinonimo As String


#Region "Propiedades"

    Public Property IDSinonimo() As Integer
        Get
            Return _idsinonimo
        End Get
        Set(value As Integer)
            _idsinonimo = value
        End Set
    End Property

    Public Property IDTitulo() As Integer
        Get
            Return _idtitulo
        End Get
        Set(value As Integer)
            _idtitulo = value
        End Set
    End Property

    Public Property Sinonimo() As String
        Get
            Return _sinonimo
        End Get
        Set(value As String)
            _sinonimo = value
        End Set
    End Property

#End Region

#Region "constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal _idsinonimo As Integer, ByVal _idtitutlo As Integer, ByVal sinonimo As String)
        IDSinonimo = _idsinonimo
        IDTitulo = _idtitutlo
        sinonimo = _sinonimo
    End Sub
#End Region

    Public Function LoadGrid(ByVal id As Integer) As DataTable
        Try
            Conectado()
            Dim cmd = New SqlCommand("select * from Sinonimo where IDTitulo = " + id + "")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            RaiseEvent msgErrorSinonimo("Erro: " & ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function

    Public Function Insert(ByVal dts As Sinonimos)
        Try
            Conectado()
            Dim cmd = New SqlCommand("insert into Sinonimo(Sinonimo, IDTitulo)" & "values(@Sinonimo, @IDTitulo)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn


            'Enviamos todos a los parametros que se reciben
            cmd.Parameters.AddWithValue("@Sinonimo", dts.Sinonimo)
            cmd.Parameters.AddWithValue("@IDTitulo", dts.IDTitulo)

            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            RaiseEvent msgErrorSinonimo("Error: " & ex.Message)
            Return False
        End Try
    End Function

End Class
