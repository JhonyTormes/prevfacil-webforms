<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PrevFacil.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login - PrevFácil Benefícios</title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
</head>
<body class="bg-light">
<form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center" style="margin-top: 100px;">
                <div class="col-md-4">
                    <div class="card shadow-sm p-4">
                        <div class="text-center mb-4">
                            <h3>PrevFácil Portal</h3>
                            <p class="text-muted">Acesse sua conta de associado</p>
                        </div>
                        
                        <div class="form-group mb-3">
                            <label for="txtInscricao">Número de Inscrição</label>
                            <asp:TextBox ID="txtInscricao" runat="server" CssClass="form-control" placeholder="Digite sua inscrição"></asp:TextBox>
                        </div>

                        <div class="form-group mb-4">
                            <label for="txtSenha">Senha</label>
                            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password" placeholder="Digite sua senha"></asp:TextBox>
                        </div>

                        <asp:Button ID="btnLogin" runat="server" Text="Entrar no Portal" CssClass="btn btn-primary w-100" OnClick="btnLogin_Click" />

                        <div class="mt-3 text-center">
                            <asp:Label ID="lblErro" runat="server" ForeColor="Red" Font-Size="Small" Visible="false"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
