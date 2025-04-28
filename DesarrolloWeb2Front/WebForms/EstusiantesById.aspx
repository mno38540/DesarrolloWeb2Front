<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstusiantesById.aspx.cs" Inherits="DesarrolloWeb2Front.WebForms.EstusiantesById" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo Estudiante&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
            <br />
            Identificacion<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;Nombre&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp; Apellido
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Direccion
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;Telefono&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
