Public Class Titulos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dts As New Cls_Titulo
            dts.Nombre = txtTitulo.Text
            dts.Descripcion = txtDescripcion.Text

            If dts.Insert(dts) Then
                Dim S As Sinonimos

                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "alertIns", "alert('El registro se guardó correctamente');", True)
            End If
        Catch ex As Exception

        End Try


    End Sub
End Class