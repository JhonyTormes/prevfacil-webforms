using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace PrevFacil.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            if (ex != null)
            {
                Application["ErroMensagem"] = ex.Message;
                System.Diagnostics.Trace.TraceError($"Erro não tratado: {ex}");

                Server.ClearError();
                Response.Redirect("~/Erro.aspx");
            }
        }
    }
}