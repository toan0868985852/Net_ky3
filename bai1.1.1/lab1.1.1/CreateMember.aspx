<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="lab1._1._1.CreateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="iblMessage" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Gender:
            <asp:DropDownList ID="drpGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Fale</asp:ListItem>
            </asp:DropDownList>
            <br />
            Membership Fee:
            <asp:TextBox ID="txtfees" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
