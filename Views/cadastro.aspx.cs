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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cadastroConfSenha_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void cadastroSalvar_Click(object sender, EventArgs e)
        {
            if (cadastroNome.Text == "")
            {
                Response.Write("<script>alert('Verifique o nome inserido')</script>");
            }
            else if (cadastroEmail.Text == "")
            {
                Response.Write("<script>alert('Verifique o e-mail inserido')</script>");
            }
            else if (cadastroSenha.Text.Length < 6)
            {
                Response.Write("<script>alert('Verifique a senha inserida! Ela deve conter no mínimo 6 caracteres</script>");
            }
            else if (cadastroSenha.Text != cadastroConfSenha.Text)
            {
                Response.Write("<script>alert('Verifique a senha inserida! os campos de senha devem ser iguais</script>");
            }
            else
            {
                try
                {
                    UsuarioModel usuario = new UsuarioModel(cadastroNome.Text, cadastroEmail.Text, cadastroSenha.Text);
                    UsuarioController controller = new UsuarioController();
                    bool resposta = controller.Inserir(usuario);
                    if (resposta)
                    {
                        Response.Write("<script>alert('Usuário cadastrado com sucesso!')</script>");
                        cadastroNome.Text = "";
                        cadastroEmail.Text = "";
                        cadastroSenha.Text = "";
                        cadastroConfSenha.Text = "";
                    }
                    else
                    {
                        Response.Write("<script>alert('Erro ao cadastrar usuário!')</script>");
                        cadastroNome.Text = "";
                        cadastroEmail.Text = "";
                        cadastroSenha.Text = "";
                        cadastroConfSenha.Text = "";
                    }
                }
                catch (Exception erro)
                {
                    Response.Write("<script>alert('Erro ao cadastrar usuário!')</script>");
                    Console.WriteLine(erro);
                }
            }
        }
    }
}