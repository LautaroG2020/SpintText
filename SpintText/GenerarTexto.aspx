<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home.Master" CodeBehind="GenerarTexto.aspx.vb" Inherits="SpintText.GenerarTexto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="text-center">
            <h2>Generar Textos</h2>
            <p>No te olvides de utilizar los Titulos en { } para generar nuevos textos.</p>
            <hr />
        </div>
    </div>

    <div class="row">
        <div class="col-sm-6">
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="text-center">
                        <asp:Label Text="Texto Original" runat="server" ForeColor="#E15119" />
                    </div>
                    <br />
                    <asp:TextBox ID="txtOriginal" CssClass="form-control" runat="server" TextMode="MultiLine" Width=""></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="col-sm-6">
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="text-center">
                        <asp:Label Text="Textos creados" runat="server" ForeColor="#E15119" />
                    </div>
                    <br />
                     <asp:TextBox ID="txtTextoNuevo" CssClass="form-control" runat="server" TextMode="MultiLine" Width=""></asp:TextBox>
                </div>
            </div>
        </div>
    </div>

    <div class="row text-center">
            <div class="col-sm-12">
                <asp:Button ID="Button1" runat="server" Text="Crear Textos" CssClass="btn btn-primary" />
            </div>
        </div>

    
        
    
    
</asp:Content>
