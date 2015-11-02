<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManejoVariablesEntrePostBack1.aspx.cs" Inherits="SandBox.ManejoVariablesEntrePostBack1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
        <h1>PAGINA 1 - CREACION DE VARIABLES Y USO DE POSTBACK</h1>
        <h3>----------------------------------------------------</h3>
        <div style="width:45%; float:left">
            <asp:Label ID="label_Cookie" runat="server" Text="Soy una label que coge valor de una Cookie y valgo "></asp:Label>
            <br /><asp:Label ID="label_Session" runat="server" Text="Soy una label que coge valor de una Session y valgo "></asp:Label>
            <br /><br /><asp:Button ID="button_PostBack" runat="server" Text="Soy el que provoca PostBack y dolor de cabeza" Width="100%" BackColor="Gray"/>
            <br /><br /><u>Lista de Botones PostBack</u><br />
            <br /><asp:Button ID="button_A" runat="server" Text="Pulsame" BackColor="Gray"/>
            <br /><asp:Button ID="button_B" runat="server" Text="Pulsame" BackColor="Gray"/>
            
            <br /><br /><u>Usando un treeView</u><br />
            <br /><asp:TreeView ID="treeViewPredefinido" runat="server">
                <Nodes>
                    <asp:TreeNode Text="Rama Creada en HTML" Value="Rama Creada en HTML">
                        <asp:TreeNode Text="Hoja Estatica 1" Value="Hoja Estatica 1"></asp:TreeNode>
                        <asp:TreeNode Text="Hoja Estatica 2" Value="Hoja Estatica 2"></asp:TreeNode>
                        <asp:TreeNode Text="Hoja Estatica 3" Value="Hoja Estatica 3"></asp:TreeNode>
                    </asp:TreeNode>                
                </Nodes>
            </asp:TreeView>
        <br /><asp:Label ID="label_Tree" runat="server" Text="Hoja del tree pulsada: "></asp:Label>
        </div>
        <div style="width:45%;float:left; margin-left:2%">
            <asp:Label ID="label_ViewState" runat="server" Text="Soy una label que coge valor de un ViewState y valgo "></asp:Label>
            <br /><asp:Label ID="label_PostBack" runat="server" Text="Soy una label que coge valor de una variable del postback y valgo "></asp:Label>
            <br /><br /><asp:Button ID="button_CambioPagina_Server" runat="server" Text="Yo me encargo de ir a la pagina 2 con Server.Transfer" OnClick="button_CambioPagina_Click_ServerTransfer" Width="100%" BackColor="Gray"/>
            <br /><asp:Button ID="button_CambioPagina_Redirect" runat="server" Text="Yo me encargo de ir a la pagina 2 con Response.Redirect" OnClick="button_CambioPagina_Click_ResponseRedirect" Width="100%" BackColor="Gray"/>
            <br /><br /><asp:Button ID="button_C" runat="server" Text="Pulsame" BackColor="Gray"/>
            <br /><asp:Button ID="button_D" runat="server" Text="Pulsame" BackColor="Gray"/>
            <br /><br /><asp:Table ID="tabla_Predefinida" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" BorderWidth="1px">Celda Estatica 1</asp:TableCell>
                    <asp:TableCell runat="server" BorderWidth="1px">Celda Estatica 2</asp:TableCell>
                    <asp:TableCell runat="server" BorderWidth="1px">Celda Estatica 3</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <br /><br /><asp:TextBox ID="cajaInfo" runat="server" TextMode="MultiLine" Width="100%" Height="150px"></asp:TextBox>        
    </div>
    </form>
</body>
</html>
