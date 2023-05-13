<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wFormSalario.aspx.cs" Inherits="AspModulo2.wFormSalario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Informe o salario bruto"></asp:Label>
            <br />
            <asp:TextBox ID="txbSalario" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Percentual de desconto"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="radioDesconto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButton">
                <asp:ListItem Selected="True">10</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>Outro</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:TextBox ID="txbOutro" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/WRespSalárioMin.aspx" Text="Enviar dados" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WRespSalárioMin.aspx?Nome=Previdência">Pesquisar Produto Get Url</asp:HyperLink>
        </div>
    </form>
</body>
</html>
