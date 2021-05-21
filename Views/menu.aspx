<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="WebApplication1.Views.menu2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/menu.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <asp:Button ID="btnLogout" runat="server" Text="Sair" OnClick="btnLogout_Click" />

        <section class="card" data-tilt>
        <h2>Editar</h2>
        <p>pesquise por um contato e edite suas informações.</p>
        <a href="editar_contato.aspx" class="button">ir <img src="../Assets/arrow-right.svg" alt="ir" /></a>
    </section>

    <section class="card" data-tilt>
        <h2>Novo contato</h2>
        <p>cadastre novos contatos.</p>
        <a href="novo_contato.aspx" class="button">ir <img src="../Assets/arrow-right.svg" alt="ir" /></a>
    </section>

    <section class="card" data-tilt>
        <h2>Contato</h2>
        <p>Listar contatos cadastrados.</p>
        <a href="pesquisar.aspx" class="button">ir <img src="../Assets/arrow-right.svg" alt="ir" /></a>
    </section>

    <section class="card" data-tilt>
        <h2>Minha conta</h2>
        <p>Altere seus dados cadastrais.</p>
        <a href="alterar_dados.aspx" class="button">ir <img src="../Assets/arrow-right.svg" alt="ir" /></a>
    </section>

    <script src="../Scripts/vanillatilt.js"></script>

    <script type="text/javascript">
      VanillaTilt.init(document.querySelectorAll(".card"), {
        max: 25,
        speed: 400,
        glare: true,
        "max-glare": 1,
      });
    </script>

    </form>
</body>
</html>
