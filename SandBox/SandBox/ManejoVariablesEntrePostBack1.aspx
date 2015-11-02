<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManejoVariablesEntrePostBack1.aspx.cs" Inherits="SandBox.ManejoVariablesEntrePostBack1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>PAGINA 1 - CREACION DE VARIABLES Y USO DE POSTBACK</h1>
        <h3>----------------------------------------------------</h3>
        <asp:Label ID="label_Cookie" runat="server" Text="Soy una label que coge valor de una Cookie y valgo "></asp:Label>
        <br /><asp:Label ID="label_Session" runat="server" Text="Soy una label que coge valor de una Session y valgo "></asp:Label>
        <br /><asp:Label ID="label_ViewState" runat="server" Text="Soy una label que coge valor de un ViewState y valgo "></asp:Label>
        <br /><asp:Label ID="label_PostBack" runat="server" Text="Soy una label que coge valor de una variable del postback y valgo "></asp:Label>
        <br />
        <br /><asp:Button ID="button_PostBack" runat="server" Text="Soy el que provoca PostBack y dolor de cabeza" />
        <br /><asp:Button ID="button_CambioPagina_Server" runat="server" Text="Yo me encargo de ir a la pagina 2 con Server.Transfer" OnClick="button_CambioPagina_Click_ServerTransfer" />
        <br /><asp:Button ID="button_CambioPagina_Redirect" runat="server" Text="Yo me encargo de ir a la pagina 2 con Response.Redirect" OnClick="button_CambioPagina_Click_ResponseRedirect" />
    </div>
    </form>
</body>
</html>
