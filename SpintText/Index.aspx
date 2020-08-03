<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Index.aspx.vb" Inherits="SpintText.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2 class="text-center">¿Qué es un spinner de Texto?</h2><br />
        <p>
            Un spin o spintax (Realmente nunca he sabido diferenciar cuál es la forma correcto de decirlo) es un texto que se va generando de forma automática en función de una serie de variables que nosotros mismos proporcionamos.<br />

            Te pondré un ejemplo que seguro que así lo verás más claro:<br />

            Si tenemos el siguiente spintax: “Esto es un {Archivo} legal”.Entonces todo lo que se encuentra entre { } son los denominados TITULOS, en ete ejemplo "Archivo", donde en ellos almacenaremos todas las palabras que podremos utilizarcuando generemos uno o varios textos, en este caso  “documento” y “texto”.<br />

            Bien, al poner a funcionar el spinner se podrán generar las siguientes dos frases (ya que solo contamos con dos variables):<br />
        </p>
        <ul>
            <li>“Esto es un documento legal”</li>
            <li>“Esto es un texto legal”</li>  
        </ul>

    </div>
</asp:Content>
