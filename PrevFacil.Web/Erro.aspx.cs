using System;

namespace PrevFacil.Web
{
    public partial class Erro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mensagem = Application["ErroMensagem"] as string;
            if (!string.IsNullOrEmpty(mensagem))
            {
                lblDetalhe.Text = mensagem;
                lblDetalhe.Visible = true;
            }
        }
    }
}
