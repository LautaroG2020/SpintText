Imports System.Data.SqlClient

Public Class Cls_Titulo
    Inherits Cls_Conexion
    Dim cmd As New SqlCommand 'Variable para enviar consultas a la base de datos
    Event msgErrorTitulo(descripcion As String)

    Dim _idtitulo As Integer
    Dim _nombre, _descripcion As String

#Region "Propiedades"
    Public Property IDTitulo() As Integer
        Get
            Return _idtitulo
        End Get
        Set(value As Integer)
            _idtitulo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
#End Region

#Region "constructores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal _idtitulo As Integer, ByVal _nombre As String, ByVal _descripcion As String)
        IDTitulo = _idtitulo
        Nombre = _nombre
        _descripcion = _descripcion
    End Sub
#End Region



    Public Function LoadGrid() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select * from Titulo")
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
            RaiseEvent msgErrorTitulo(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function


    Public Function Insert(ByVal dts As Cls_Titulo) As Integer
        Try
            Conectado()
            cmd = New SqlCommand("insert into Titulo(Nombre, Descripcion)" & "values(@Nombre, @Descripcion)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            'Enviamos todos los parametros que se reciben
            cmd.Parameters.AddWithValue("@Nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@Descripcion", dts.Descripcion)

            If cmd.ExecuteNonQuery() > 0 Then
                Dim r As SqlCommand
                r = New SqlCommand("Select @@IDENTITY", conn)
                Return r.ExecuteScalar()
            Else
                Return False
            End If
        Catch ex As Exception
            RaiseEvent msgErrorTitulo("Error: " & ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

    Public Function BuscarTitulo(ByVal textoOriginal As String) As Integer
        Try
            Conectado()
            cmd = New SqlCommand("select IDTitulo from Titulo where Nombre LIKE " + textoOriginal + "")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            If cmd.ExecuteNonQuery Then
                Dim r As SqlCommand
                r = New SqlCommand("Select @@IDENTITY", conn)
                Return r.ExecuteScalar()
            Else
                Return False
            End If

        Catch ex As Exception
            RaiseEvent msgErrorTitulo("Error : " + ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

End Class
