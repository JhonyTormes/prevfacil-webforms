using System;

namespace PrevFacil.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsarioLogado"] != null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Simulando por enquanto, depois vou implementar a autenticação real
            string inscricaoValida = "1913.045.882";
            string senhaValida = "Teste123";

            if (txtInscricao.Text == inscricaoValida && txtSenha.Text == senhaValida)
            {
                Session["UsuarioLogado"] = "Usuario Teste";
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lblErro.Text = "Inscrição ou senha inválidos.";
                lblErro.Visible = true;
            }
        }
    }
}