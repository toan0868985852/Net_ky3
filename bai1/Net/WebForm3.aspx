<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm3.aspx.vb" Inherits="Net.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP .net Code Behind Page Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label
                runat="server"
                Text="Please Enter Your Name"/>
            <asp:TextBox ID="txtName" runat="server"/>
            <asp:Button ID="btnSubmit"
                Text="Submit"
                runat="server"
                onclick="btnSubmit_Click" />
            <br />
            <hr />
            <asp:Label runat="server" id="lblMessage"/>
        </div>
    </form>
</body>
</html>
