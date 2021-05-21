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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("default.aspx");
            }
            else
            {

            }
        }

        protected void dadosCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["login"] = null;
            Response.Redirect("default.aspx");
        }

        protected void dadosSalvar_Click(object sender, EventArgs e)
        {
            if (dadosNome.Text == "")
            {
                Response.Write("<script>alert('Verifique o nome inserido')</script>");
            }
            else if (dadosEmail.Text == "")
            {
                Response.Write("<script>alert('Verifique o e-mail inserido')</script>");
            }
            else if (dadosSenha.Text.Length < 6)
            {
                Response.Write("<script>alert('Verifique a senha inserida! Ela deve conter no mínimo 6 caracteres</script>");
            }
            else if (dadosSenha.Text != dadosConfSenha.Text)
            {
                Response.Write("<script>alert('Verifique a senha inserida! os campos de senha devem ser iguais</script>");
            }
            else
            {
                try
                {
                    UsuarioModel usuario = new UsuarioModel(dadosNome.Text, dadosEmail.Text, dadosSenha.Text);
                    usuario.Id = int.Parse(Session["login"].ToString());
                    UsuarioController controller = new UsuarioController();
                    bool resposta = controller.Alterar(usuario);
                    if (resposta)
                    {
                        Response.Write("<script>alert('Usuário alterado com sucesso!')</script>");
                        dadosNome.Text = "";
                        dadosEmail.Text = "";
                        dadosSenha.Text = "";
                        dadosConfSenha.Text = "";
                    }
                    else
                    {
                        Response.Write("<script>alert('Erro ao alterar o cadastro do usuário!')</script>");
                        dadosNome.Text = "";
                        dadosEmail.Text = "";
                        dadosSenha.Text = "";
                        dadosConfSenha.Text = "";
                    }
                }
                catch (Exception erro)
                {

                    throw erro;
                }
            }
        }
    }
}