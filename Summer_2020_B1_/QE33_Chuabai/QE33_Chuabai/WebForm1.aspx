<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QE33_Chuabai.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlDate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDate_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:PlaceHolder ID="phTeachingSchedule" runat="server"></asp:PlaceHolder>
            <br />
        </div>
    </form>
</body>
</html>
