using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controllers;

namespace WebApplication1.Views
{
    public partial class pesquisar2 : System.Web.UI.Page
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
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("editar_contato.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> resposta = new List<string>();
            try
            {
                ContatoController controller = new ContatoController();
                resposta = controller.Pesquisar(txbSearch.Text, Session["login"].ToString());
                if (resposta[0] != "Contato não encontrado")
                {
                    bool confirmacao = controller.Excluir(int.Parse(contatoID.Text));
                    if (confirmacao)
                    {
                        Response.Write("<script>alert('Contato excluido com sucesso!')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Erro ao excluir o contato')</script>");
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                //throw erro;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> resposta = new List<string>();
            try
            {
                ContatoController controller = new ContatoController();
                resposta = controller.Pesquisar(txbSearch.Text, Session["login"].ToString());
                if (resposta[0] == "Contato não encontrado")
                {
                    contatoNome.Text = "";
                    contatoTelefone.Text = "";
                    contatoEmail.Text = "";
                    contatoGrupo.Text = "";
                    Response.Write("<script>alert('Contato não localizado!')</script>");
                }
                else
                {
                    contatoID.Text = resposta[0].ToString();
                    contatoNome.Text = resposta[1].ToString();
                    contatoTelefone.Text = resposta[2].ToString();
                    contatoEmail.Text = resposta[3].ToString();
                    contatoGrupo.Text = resposta[4].ToString();
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