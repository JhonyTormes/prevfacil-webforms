<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrevFacil.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="margin-top: 20px;">
        <h2>Bem-vindo ao Portal PrevFácil</h2>
        <p class="lead">Confira abaixo o resumo do seu plano de previdência complementar.</p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-default" style="padding: 20px; border: 1px solid #ddd; border-radius: 4px;">
                <h3>Dados do seu Plano</h3>
                <hr />
                <p><strong>Plano:</strong> <asp:Label ID="lblNomePlano" runat="server" Text="---"></asp:Label></p>
                <p><strong>Inscrição:</strong> <asp:Label ID="lblInscricao" runat="server" Text="---"></asp:Label></p>
                <p><strong>Contribuição Mensal:</strong> <asp:Label ID="lblContribuicao" runat="server" Text="---"></asp:Label></p>
                <p><strong>Saldo Total Acumulado:</strong> <asp:Label ID="lblSaldo" runat="server" Font-Bold="true" ForeColor="Green" Text="---"></asp:Label></p>
            </div>
        </div>
    </div>

</asp:Content>
