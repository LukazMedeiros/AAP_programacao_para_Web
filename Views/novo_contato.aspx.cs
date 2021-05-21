using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controllers;
using WebApplication1.Models;

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

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ContatoModel contato = new ContatoModel(novoNome.Text, novoTelefone.Text, novoEmail.Text, novoGrupo.Text, Session["login"].ToString());
                ContatoController controller = new ContatoController();
                bool resposta = controller.Inserir(contato);
                if (true)
                {
                    Response.Write("<script>alert('Novo contato inseridos!')</script>");
                    novoNome.Text = "";
                    novoTelefone.Text = "";
                    novoEmail.Text = "";
                    novoGrupo.Text = "";
                }
                else
                {
                    Response.Write("<script>alert('Erro ao inserir novo contato!')</script>");
                }
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}