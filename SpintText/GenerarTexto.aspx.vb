Public Class GenerarTexto
    Inherits System.Web.UI.Page
    Dim ds As New DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim funcT As New Cls_Titulo
        Dim funcS As New Sinonimos
        Dim dtTitulos As DataTable
        Dim dtS As New DataTable
        Dim texto As String = txtOriginal.Text
        Dim resultado As String

        Dim palabras As List(Of String)

        'Se extrae una lista con todos los titulos que hay en el texto
        palabras = GetTitulosFromText(texto)

        'Traigo una tabla con todos los datos de cada titulo encontrado
        dtTitulos = funcT.GetTitulos(palabras)


        resultado = texto
        'Recorro los titulos y busco sus sinonimos
        For Each row As DataRow In dtTitulos.Rows
            dtS = funcS.LoadGrid(row("IDTitulo"))

            'Una vez tengo la tabla de los sinonimos de un titulo, lo reemplazo en el texto
            'En este caso yo lo reemplazo por la primer row, pero deberia ser aleatorio, INVESTIGAR.
            resultado = resultado.Replace("{" + row("Nombre") + "}", dtS.Rows(0)("Sinonimo"))

        Next

        txtTextoNuevo.Text = resultado
    End Sub

    Private Function GetTitulosFromText(ByVal text As String) As List(Of String)
        Dim re As New Regex("\{([^{}]+)\}*") 'Expresion regular que trae un listado de palabras o frases entre llaves
        GetTitulosFromText = New List(Of String)

        'Recorro todas las coincidencias encontradas y las agrego a una lista
        For Each m As Match In re.Matches(text)
            GetTitulosFromText.Add(m.Value.Replace("{", "").Replace("}", ""))
        Next

        Return GetTitulosFromText.Distinct().ToList() 'Distinct quita los repetidos de la lista.
    End Function
End Class