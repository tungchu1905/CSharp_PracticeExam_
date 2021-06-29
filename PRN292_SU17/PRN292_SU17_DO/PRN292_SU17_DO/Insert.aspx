<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="PRN292_SU17_DO.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Detail ID:
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            Detail Name:
            <asp:TextBox ID="txtDeName" runat="server"></asp:TextBox>
            <br />
            MasterName:
            <asp:DropDownList ID="ddlMaName" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnUpdate_Click" Text="Insert" />
        </div>
    </form>
</body>
</html>
