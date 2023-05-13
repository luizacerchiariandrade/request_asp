<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WRespSalárioMin.aspx.cs" Inherits="AspModulo2.WRespSalárioMin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1> Cálculo do salário mínimo </h1>
    <form id="form1" runat="server">
        <p> 
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </p>
        <div>
            <asp:Label ID="lbResultado" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/wFormSalario.aspx" Text="Voltar" />
        </div>
    </form>
</body>
</html>
