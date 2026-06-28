using System;
using System.Web.UI;
using PrevFacil.Web.Business;

namespace PrevFacil.Web
{
    public partial class Simulador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSimular_Click(object sender, EventArgs e)
        {
            if (Session["UsuarioLogado"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            lblErro.Visible = false;

            if (!Page.IsValid)
            {
                return;
            }

            if (!decimal.TryParse(txtValorMensal.Text, out decimal valorMensal) || valorMensal <= 0)
            {
                lblErro.Text = "Valor mensal inválido. Digite um número positivo.";
                lblErro.Visible = true;
                return;
            }

            if (!int.TryParse(txtAnos.Text, out int anos) || anos < 1 || anos > 100)
            {
                lblErro.Text = "Número de anos inválido. Digite um valor entre 1 e 100.";
                lblErro.Visible = true;
                return;
            }

            int totalMeses = anos * 12;

            SimuladorService simulador = new SimuladorService();
            decimal saldoFinal = simulador.SimularSaldoFuturo(valorMensal, totalMeses);

            lblTempoResultado.Text = anos.ToString();
            lblSaldoResultado.Text = saldoFinal.ToString("C");

            pnlResultado.Visible = true;
        }
    }
}