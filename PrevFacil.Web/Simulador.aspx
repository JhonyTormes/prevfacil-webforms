<%@ Page Title="Simulador de Previdência" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Simulador.aspx.cs" Inherits="PrevFacil.Web.Simulador" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top: 30px;">
        <div class="col-md-6">
            <div class="card" style="padding: 20px; border: 1px solid #ddd; border-radius: 4px;">
                <div class="card-body">
                    <h3 class="card-title">Simulador de Futuro</h3>
                    <p class="text-muted">Projete o saldo da sua previdência com base no valor de contribuição.</p>
                    <hr />

                    <div class="form-group" style="margin-bottom: 15px;">
                        <label for="txtValorMensal">Quanto você quer investir por mês?</label>
                        <asp:TextBox ID="txtValorMensal" runat="server" CssClass="form-control" TextMode="Number" placeholder="Ex: 250"></asp:TextBox>
                    </div>

                    <div class="form-group" style="margin-bottom: 25px;">
                        <label for="txtAnos">Por quantos anos pretende poupar?</label>
                        <asp:TextBox ID="txtAnos" runat="server" CssClass="form-control" TextMode="Number" placeholder="Ex: 10"></asp:TextBox>
                    </div>

                    <asp:Button ID="btnSimular" runat="server" Text="Calcular Projeção" CssClass="btn btn-primary" OnClick="btnSimular_Click" />
                </div>
            </div>
        </div>

        <div class="col-md-6">
            <asp:Panel ID="pnlResultado" runat="server" Visible="false" CssClass="alert alert-success" style="margin-top: 0px; padding: 20px;">
                <h4>Resultado da Simulação:</h4>
                <hr />
                <p style="font-size: 18px;">
                    Se você poupar durante <strong><asp:Label ID="lblTempoResultado" runat="server"></asp:Label> anos</strong>, 
                    seu saldo estimado no futuro será de:
                </p>
                <h2 style="color: #155724; font-weight: bold;">
                    <asp:Label ID="lblSaldoResultado" runat="server"></asp:Label>
                </h2>
                <small class="text-muted">*Cálculo baseado em uma taxa simulada de 0.5% ao mês capitalizada diariamente.</small>
            </asp:Panel>
        </div>
    </div>

</asp:Content>