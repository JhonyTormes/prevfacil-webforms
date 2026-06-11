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

            if (string.IsNullOrEmpty(txtValorMensal.Text) || string.IsNullOrEmpty(txtAnos.Text))
            {
                return;
            }

            decimal valorMensal = Convert.ToDecimal(txtValorMensal.Text);
            int anos = Convert.ToInt32(txtAnos.Text);
            int totalMeses = anos * 12;

            SimuladorService simulador = new SimuladorService();
            decimal saldoFinal = simulador.SimularSaldoFuturo(valorMensal, totalMeses);

            lblTempoResultado.Text = anos.ToString();
            lblSaldoResultado.Text = saldoFinal.ToString("C");

            pnlResultado.Visible = true;
        }
    }
}