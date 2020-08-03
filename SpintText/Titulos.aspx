<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="Titulos.aspx.vb" Inherits="SpintText.Titulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="text-center">
            <h2>Generar un nuevo Título</h2>
            <p>Estos títulos son los indicadores que utilizaremos para crear otras opciones a la hora de generar textos.</p>
            <hr />
        </div>

        <div class="row">
            <div class="col-sm-5">
                <div class="form-group">
                    <div class="col-sm-4 col-form-label-sm">
                        <asp:Label Text="Nombre:" runat="server" Width="100%" ForeColor="#E15119" />
                    </div>
                    <div class="col-sm-8" style="max-width: 100%;">
                        <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="col-sm-7">
                <div class="form-group">
                    <div class="col-sm-4 col-form-label-sm">
                        <asp:Label Text="Descripción:" runat="server" Width="100%" ForeColor="#E15119" />
                    </div>
                    <div class="col-sm-8" style="max-width: 100%;">
                        <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                <div class="form-group">
                    <div class="col-sm-4 col-form-label-sm">
                        <asp:Label Text="Sinónimos:" runat="server" Width="100%" ForeColor="#E15119" />
                    </div>
                    <div class="col-md-8" style="max-width: 100%;">
                        <asp:TextBox ID="txtSinonimos" CssClass="form-control" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                        <small id="emailHelp" class="form-text text-muted">*Palabras que se remplazaran en el Titulo cuando se crea el nuevo texto.</small>
                    </div>
                </div>
            </div>
        </div>

        <div class="row text-center">
            <div class="col-sm-12">
                <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>

</asp:Content>
