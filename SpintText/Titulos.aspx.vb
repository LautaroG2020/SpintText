Public Class Titulos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim dts As New Cls_Titulo
            Dim sin As New Sinonimos
            Dim i As Integer
            dts.Nombre = txtTitulo.Text
            dts.Descripcion = txtDescripcion.Text
            i = dts.Insert(dts)
            sin.Sinonimo = txtSinonimos.Text
            sin.IDTitulo = i
            sin.Insert(sin)

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "alertIns", "alert('El registro se guardó correctamente');", True)

        Catch ex As Exception

        End Try


    End Sub
End Class