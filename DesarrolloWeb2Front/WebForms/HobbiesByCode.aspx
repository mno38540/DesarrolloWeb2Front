<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HobbiesByCode.aspx.cs" Inherits="DesarrolloWeb2Front.WebForms.HobbiesByCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo del Hobbie:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
            <br />
            <br />
            ID<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            NOMBRE<br />
            <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
            <br />
            <br />
            DESCIPCION<br />
            <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
