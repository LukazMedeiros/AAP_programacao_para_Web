using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class novocontato : System.Web.UI.Page
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
            novoNome.Text = "";
            novoTelefone.Text = "";
            novoEmail.Text = "";
            novoGrupo.Text = "";
            Response.Redirect("menu.aspx");
        }
    }
}