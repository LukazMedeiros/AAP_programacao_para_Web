using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controllers;

namespace WebApplication1.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<string> resposta = new List<string>();
            
            Session["login"] = null;

            try
            {
                UsuarioController usuario = new UsuarioController();
                resposta = usuario.Pesquisar(txbLogin.Text);
                if (resposta[0] == "Usuário não encontrado")
                {
                    Response.Write("<script>alert('Usuário não localizado!')</script>");
                }
                else if (resposta[3] != txbPassword.Text)
                {
                    Response.Write("<script>alert('Usuário ou senha incorreta!')</script>");
                }
                else
                {
                    Session["login"] = resposta[0].ToString();
                    Session["usuario"] = resposta[1].ToString();
                    Session["email"] = resposta[2].ToString();
                    Response.Redirect("menu.aspx");
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