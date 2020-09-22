<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Net.WebForm2" %>

<!DOCTYPE html>
<script runat="server">
    void Button1_Click(Object sender, EventArgs e){
        lblMessage.Text = "Hi " + txtName.Text + "! Greetings and Good day.";
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>APS.NET Sing-File Page Demo</title>
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
