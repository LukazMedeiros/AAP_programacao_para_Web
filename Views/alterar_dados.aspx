<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alterar_dados.aspx.cs" Inherits="WebApplication1.Views.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/editar_dados.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <asp:Button ID="btnLogout" runat="server" Text="Sair" OnClick="btnLogout_Click"/>
         <div class="form">

        <div class="form-control">
            <label for="dadosNome">Nome:</label>
            <asp:TextBox ID="dadosNome" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="dadosEmail">E-mail:</label>
            <asp:TextBox ID="dadosEmail" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="dadosSenha">Senha:</label>
            <asp:TextBox ID="dadosSenha" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="dadosConfSenha">Confirme a senha:</label>
            <asp:TextBox ID="dadosConfSenha" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div class="btn-control">
            <asp:Button ID="dadosSalvar" runat="server" Text="Salvar" OnClick="dadosSalvar_Click" />
            <asp:Button ID="dadosCancelar" runat="server" Text="Cancelar" OnClick="dadosCancelar_Click"/>
        </div>
    </div>
    </form>

    <script>
         const dadosEmail = document.getElementById("dadosEmail");
         const dadosSenha = document.getElementById("dadosSenha");
         const dadosConfSenha = document.getElementById("dadosConfSenha");

         dadosEmail.addEventListener("change", (event) => {
             event.preventDefault();
             let pattern = /^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/gi;
             let emailEstaOk = pattern.test(dadosEmail.value);

             if (!emailEstaOk) {
                 alert("Formato de e-mail inválido! verifique os dados e insira novamente")
                 dadosEmail.value = ""
             }
         });

         dadosConfSenha.addEventListener("keyup", (event) => {
             event.preventDefault()
             if (dadosConfSenha.value !== dadosSenha.value) {
                 dadosSenha.style.cssText = `box-shadow: 0px 0px 20px rgba(255, 0, 0, 1) !important;`;
                 dadosConfSenha.style.cssText = `box-shadow: 0px 0px 20px rgba(255, 0, 0, 1) !important;`;
             } else {
                 dadosSenha.style.cssText = `box-shadow: 5px 5px 20px rgba(0, 0, 0, 0.5) !important;`;
                 dadosConfSenha.style.cssText = `box-shadow: 5px 5px 20px rgba(0, 0, 0, 0.5) !important;`;
             }
         });
    </script>

</body>
</html>
