<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="WebApplication1.Views.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/cadastro.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="form">

        <div class="form-control">
            <label for="cadastroNome">Nome:</label>
            <asp:TextBox ID="cadastroNome" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="cadastroEmail">E-mail:</label>
            <asp:TextBox ID="cadastroEmail" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="cadastroSenha">Senha:</label>
            <asp:TextBox ID="cadastroSenha" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="cadastroConfSenha">Confirme a senha:</label>
            <asp:TextBox ID="cadastroConfSenha" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div class="btn-control">
            <asp:Button ID="cadastroSalvar" runat="server" Text="Salvar" />
            <asp:Button ID="cadastroCancelar" runat="server" Text="Cancelar" OnClick="cadastroConfSenha_Click"/>
        </div>

    </div>
    </form>

    <script>
        const cadastroEmail = document.getElementById("cadastroEmail");
        const cadastroSenha = document.getElementById("cadastroSenha");
        const cadastroConfSenha = document.getElementById("cadastroConfSenha");

        cadastroEmail.addEventListener("change", (event) => {
            event.preventDefault();
            let pattern = /^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/gi;
            let emailEstaOk = pattern.test(cadastroEmail.value);

            if (!emailEstaOk) {
                alert("Formato de e-mail inválido! verifique os dados e insira novamente")
                cadastroEmail.value = ""
            }
        });

        cadastroConfSenha.addEventListener("keyup", (event) => {
            event.preventDefault()
            if (cadastroConfSenha.value !== cadastroSenha.value) {
                cadastroSenha.style.cssText = `box-shadow: 0px 0px 20px rgba(255, 0, 0, 1) !important;`;
                cadastroConfSenha.style.cssText = `box-shadow: 0px 0px 20px rgba(255, 0, 0, 1) !important;`;
            } else {
                cadastroSenha.style.cssText = `box-shadow: 5px 5px 20px rgba(0, 0, 0, 0.5) !important;`;
                cadastroConfSenha.style.cssText = `box-shadow: 5px 5px 20px rgba(0, 0, 0, 0.5) !important;`;
            }
        });
    </script>

</body>
</html>
