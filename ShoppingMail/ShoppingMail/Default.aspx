<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShoppingMail.Default" %>
<%@ Register Src="~/UserControl/leftMessage.ascx" TagPrefix="ucl" TagName="leftMessage"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ucl:leftMessage runat="server" ID="LeftMessage" />
        </div>
        <h3>Welcome!! Go for Shopping</h3>
        <div>
        </div>
    </form>
</body>
</html>
