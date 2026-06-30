<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Erro.aspx.cs" Inherits="PrevFacil.Web.Erro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Erro - PrevFácil Benefícios</title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center" style="margin-top: 100px;">
                <div class="col-md-6">
                    <div class="card shadow-sm p-4 text-center">
                        <div class="mb-4">
                            <h2 class="text-danger">Ops! Algo deu errado.</h2>
                            <p class="text-muted">Ocorreu um erro inesperado. Nossa equipe já foi notificada.</p>
                        </div>

                        <asp:Label ID="lblDetalhe" runat="server" CssClass="alert alert-danger" Visible="false" />

                        <div class="mt-4">
                            <a runat="server" href="~/" class="btn btn-primary">Voltar à Página Inicial</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
