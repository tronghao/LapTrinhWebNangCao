<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="ax + b =0"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="a"></asp:Label>
&nbsp;<asp:TextBox ID="txtA1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="b"></asp:Label>
&nbsp;<asp:TextBox ID="txtB1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnGiai1" runat="server" Text="Giải" />
&nbsp;
        <asp:Label ID="txtKq1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="ax^2 + bx + c = 0"></asp:Label>
        <br />
        a
        <asp:TextBox ID="txtA2" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <br />
        b
        <asp:TextBox ID="txtB2" runat="server"></asp:TextBox>
        <br />
        c
        <asp:TextBox ID="txtC2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnGiai2" runat="server" Text="Giải" />
&nbsp;
        <asp:Label ID="txtKq2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
