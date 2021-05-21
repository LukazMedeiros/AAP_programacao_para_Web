<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="novo_contato.aspx.cs" Inherits="WebApplication1.Views.novocontato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/novo_contato.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <asp:Button ID="btnLogout" runat="server" Text="Sair" OnClick="btnLogout_Click" />
        <div class="form">

        <div class="form-control">
            <label for="novoNome">Nome:</label>
            <asp:TextBox ID="novoNome" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="novoTelefone">Telefone:</label>
            <asp:TextBox ID="novoTelefone" runat="server" MaxLength="11"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="novoEmail">E-mail:</label>
            <asp:TextBox ID="novoEmail" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="novoGrupo">Grupo:</label>
            <asp:TextBox ID="novoGrupo" runat="server"></asp:TextBox>
        </div>

        <div class="btn-control form-control">
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>

    </div>
    </form>
    <script>
        const novoTelefone = document.getElementById("novoTelefone");
        const novoEmail = document.getElementById("novoEmail");

         novoTelefone.addEventListener("keyup", (event) => {
            event.preventDefault();
            let valor;
            valor = novoTelefone.value.replace(/\D/g, "");
            novoTelefone.value = valor;
        });

        novoEmail.addEventListener("change", (event) => {
            event.preventDefault();
            let pattern = /^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/gi;
            let emailEstaOk = pattern.test(novoEmail.value);

            if (!emailEstaOk) {
                alert("Formato de e-mail inválido! verifique os dados e insira novamente")
                novoEmail.value = ""
            }
        });
    </script>
</body>
</html>
