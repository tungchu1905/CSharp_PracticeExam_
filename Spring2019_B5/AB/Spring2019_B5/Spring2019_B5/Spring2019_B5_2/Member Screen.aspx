<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member Screen.aspx.cs" Inherits="Spring2019_B5_2.Member_Screen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Region"></asp:Label>
            :
            <asp:DropDownList ID="ddlRegion" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged" Width="158px">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Corporation"></asp:Label>
            <asp:DropDownList ID="ddlCorp" runat="server" Height="17px" Width="154px">
            </asp:DropDownList>
            <br />
            FirstName<asp:TextBox ID="txtFirst" runat="server" Width="179px"></asp:TextBox>
            <br />
            LastName<asp:TextBox ID="txtLast" runat="server" Height="22px" Width="177px"></asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add member" />
            <br />
            <asp:Label ID="lblSuccess" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
