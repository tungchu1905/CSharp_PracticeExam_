<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nCov-19Infected.aspx.cs" Inherits="Qe3.nCov_19Infected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Label ID="lblcheckName" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:Label ID="lblCheckAge" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Sex"></asp:Label>
&nbsp;
            <asp:RadioButton ID="rbMale" runat="server" AutoPostBack="True" Text="Nam" OnCheckedChanged="rbMale_CheckedChanged" />
&nbsp;&nbsp;
            <asp:RadioButton ID="rbFemale" runat="server" AutoPostBack="True" Text="Nữ" OnCheckedChanged="rbFemale_CheckedChanged" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nation"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlNATION" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Province"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlprovince" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Traveled From"></asp:Label>
&nbsp;<asp:TextBox ID="txtTravel" runat="server"></asp:TextBox>
&nbsp;<asp:CheckBox ID="cbTravel" runat="server" AutoPostBack="True" Text="No Intertionnal Travel" OnCheckedChanged="cbTravel_CheckedChanged" />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Related To"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlRelated" runat="server">
            </asp:DropDownList>
            <asp:CheckBox ID="cbRelated" runat="server" AutoPostBack="True" Text="No Intertionnal Travel" OnCheckedChanged="cbRelated_CheckedChanged" />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add New Case" />

            <asp:Label ID="lblSuccess" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
