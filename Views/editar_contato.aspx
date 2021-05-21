<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editar_contato.aspx.cs" Inherits="WebApplication1.Views.editarcontato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/editar_contato.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <asp:Button ID="btnLogout" runat="server" Text="Sair" OnClick="btnLogout_Click" />
        <div class="form">

        <div class="form-control btn-control">
            <asp:TextBox ID="editarBuscar" runat="server"></asp:TextBox>
            <asp:Button ID="editarBtnBuscar" runat="server" Text="Pesquisar" />
        </div>

        <div class="form-control">
            <label for="editarNome">Nome:</label>
            <asp:TextBox ID="editarNome" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="editarTelefone">Telefone:</label>
            <asp:TextBox ID="editarTelefone" runat="server" MaxLength="11"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="editarEmail">E-mail:</label>
            <asp:TextBox ID="editarEmail" runat="server"></asp:TextBox>
        </div>

        <div class="form-control">
            <label for="editarGrupo">Grupo:</label>
            <asp:TextBox ID="editarGrupo" runat="server"></asp:TextBox>
        </div>

        <div class="form-control btn-control">
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>

    </div>
    </form>
    <script>
        const editarTelefone = document.getElementById("editarTelefone");
        const editarEmail = document.getElementById("editarEmail");

        editarTelefone.addEventListener("keyup", (event) => {
            event.preventDefault();
            let valor;
            valor = editarTelefone.value.replace(/\D/g, "");
            editarTelefone.value = valor;
        });

        editarEmail.addEventListener("change", (event) => {
            event.preventDefault();
            let pattern = /^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/gi;
            let emailEstaOk = pattern.test(editarEmail.value);

            if (!emailEstaOk) {
                alert("Formato de e-mail inválido! verifique os dados e insira novamente")
                editarEmail.value = ""
            }
        });
    </script>
</body>
</html>
