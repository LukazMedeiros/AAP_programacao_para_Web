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

        protected void editarBtnBuscar_Click(object sender, EventArgs e)
        {
            List<string> resposta = new List<string>();
            try
            {
                ContatoController controller = new ContatoController();
                resposta = controller.Pesquisar(editarBuscar.Text, Session["login"].ToString());
                if (resposta[0] == "Contato não encontrado")
                {
                    editarNome.Text = "";
                    editarTelefone.Text = "";
                    editarEmail.Text = "";
                    editarGrupo.Text = "";
                    Response.Write("<script>alert('Contato não localizado!')</script>");
                }
                else
                {
                    contatoID.Text = resposta[0].ToString();
                    editarNome.Text = resposta[1].ToString();
                    editarTelefone.Text = resposta[2].ToString();
                    editarEmail.Text = resposta[3].ToString();
                    editarGrupo.Text = resposta[4].ToString();
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                //throw erro;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ContatoModel contato = new ContatoModel(editarNome.Text, editarTelefone.Text, editarEmail.Text, editarGrupo.Text, Session["login"].ToString());
                contato.Id = int.Parse(contatoID.Text);
                ContatoController controller = new ContatoController();
                bool resposta = controller.Atualizar(contato);
                if (resposta)
                {
                    Response.Write("<script>alert('Contato atualizado com sucesso!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('erro ao atualizar contato!')</script>");
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                //throw erro;
            }
        }
    }
}