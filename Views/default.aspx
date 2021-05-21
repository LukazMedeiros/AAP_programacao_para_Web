<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/base.css" rel="stylesheet" />
    <link href="../Styles/index.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="form">
            <div class="form-control">
                <label for="txbLogin">Login:</label>
                <asp:TextBox ID="txbLogin" runat="server" required></asp:TextBox>
            </div>
            <div class="form-control">
                <label for="txbPassword">Senha:</label>
                <asp:TextBox ID="txbPassword" runat="server" TextMode="Password" required></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
            </div>
        <p>Não possui login? <span><a href="cadastro.aspx">Cadastre-se</a></span></p>
    </div>
    </form>
</body>
</html>
