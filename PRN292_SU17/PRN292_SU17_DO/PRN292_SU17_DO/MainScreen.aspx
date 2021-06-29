<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainScreen.aspx.cs" Inherits="PRN292_SU17_DO.MainScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Detail Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Master:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlMaster" runat="server" Width="137px" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" Text="Filter" />
            <br />
            <asp:GridView ID="gvDummy" AutoPostBack="True" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                <Columns>
                    <asp:BoundField DataField="detail_id" HeaderText="ID" SortExpression="detail_id" />
                    <asp:BoundField DataField="detail_name" HeaderText="Name" SortExpression="detail_name" />
                    <asp:BoundField DataField="master_name" HeaderText="Master" SortExpression="master_name" />
                    <asp:HyperLinkField DataNavigateUrlFields="detail_id" DataNavigateUrlFormatString="Edit.aspx?id={0}" HeaderText="Edit" Text="Edit" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
        </div>
    </form>
</body>
</html>
