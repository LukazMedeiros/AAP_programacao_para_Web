using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class editarcontato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("default.aspx");
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["login"] = null;
            Response.Redirect("default.aspx");
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            editarBuscar.Text = "";
            editarNome.Text = "";
            editarTelefone.Text = "";
            editarEmail.Text = "";
            editarGrupo.Text = "";

            Response.Redirect("menu.aspx");
        }
    }
}