<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pesquisar.aspx.cs" Inherits="WebApplication1.Views.pesquisar2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/pesquisar.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <asp:Button ID="btnLogout" runat="server" Text="Sair" OnClick="btnLogout_Click" />
         <div class="form">
    
        <div class="form-control btn-control">
            <asp:TextBox ID="txbSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Pesquisar" />
        </div>

        <div class="table-card">
            <table>
                <caption>Contato</caption>
                <thead>
                </thead>
                <tbody>
                    <tr>
                        <td>Nome:</td>
                        <td><asp:Label ID="contatoNome" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Telefone:</td>
                        <td><asp:Label ID="contatoTelefone" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>E-mail:</td>
                        <td><asp:Label ID="contatoEmail" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Grupo:</td>
                        <td><asp:Label ID="contatoGrupo" runat="server" Text=""></asp:Label></td>
                    </tr>
                </tbody>
            </table>
        </div>

        <div class="btn-control form-control">
            <asp:Button ID="btnEdit" runat="server" Text="Editar" OnClick="btnEdit_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Voltar" OnClick="btnBack_Click" />
        </div>

    </div>
    </form>
</body>
</html>
