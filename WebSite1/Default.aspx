<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 33%;
        }
        .auto-style2 {
            width: 93px;
        }
        .auto-style3 {
            width: 290px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>WEB KHÔNG TÊN<br />
        </strong>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Số thứ nhất:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Số thứ hai:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Số thứ ba:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Số thứ tư:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Số thứ năm:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt5" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:TextBox ID="txtKq" runat="server" ReadOnly="True" Width="247px"></asp:TextBox>
        <br />
        <br />
        <div>
        <asp:Button ID="btnMax" runat="server" OnClick="btnMax_Click" Text="Max" />
&nbsp;<asp:Button ID="btnMin" runat="server" OnClick="btnMin_Click" Text="Min" />
&nbsp;<asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="Sum" />
&nbsp;<asp:Button ID="btnAve" runat="server" OnClick="btnAve_Click" Text="Avarage" />

        </div>
        <div style="margin-top: 5px">
        <asp:Button ID="btnSoLe" runat="server" OnClick="btnSoLe_Click" Text="Số lẻ" />
&nbsp;<asp:Button ID="btnSoChan" runat="server" OnClick="btnSoChan_Click" Text="Số chẵn" />
&nbsp;<asp:Button ID="btnSNT" runat="server" OnClick="btnSNT_Click" Text="Số nguyên tố" />
         </div>
    </div>
    </form>
</body>
</html>
