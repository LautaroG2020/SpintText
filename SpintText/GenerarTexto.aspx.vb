Public Class GenerarTexto
    Inherits System.Web.UI.Page
    Dim ds As New DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim funcT As New Cls_Titulo
        Dim funcS As New Sinonimos
        Dim dtT As Integer
        Dim dtS As New DataTable
        Dim texto As String = txtOriginal.Text

        dtT = funcT.BuscarTitulo(texto)
        dtS = funcS.LoadGrid(dtT)

        Dim texto1 As String = "saludo"
        Dim resultado As String

        resultado = Replace(texto, "{" + texto1 + "}", "Hola")


        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "alertIns", "alert('" + resultado + "');", True)
    End Sub
End Class