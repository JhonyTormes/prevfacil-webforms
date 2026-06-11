using PrevFacil.Web.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrevFacil.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioLogado"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                CarregarDadosDoAssociado();
            }
        }

        private void CarregarDadosDoAssociado()
        {
            PlanoPrevidencia meuPlano = new PlanoPrevidencia
            {
                NumeroInscricao = "1913.045.882",
                NomePlano = "Plano Pecúlio Ouro Tradicional",
                ValorContribuicaoMensal = 250.00m,
                SaldoAcumulado = 35420.50m,
                DataAdesao = DateTime.Now.AddYears(-5)
            };

            lblNomePlano.Text = meuPlano.NomePlano;
            lblInscricao.Text = meuPlano.NumeroInscricao;
            lblContribuicao.Text = meuPlano.ValorContribuicaoMensal.ToString("C");
            lblSaldo.Text = meuPlano.SaldoAcumulado.ToString("C");
        }
    }
}