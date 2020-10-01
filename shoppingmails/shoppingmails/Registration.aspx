<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="shoppingmails.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table>
            <tr>
                <td colspan="2">
                    <h2>User Registration</h2>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Email</b>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Valid Email Format" ControlToValidate="txtEmail" ForeColor="Red" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>User Name</b>
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" 
                        ErrorMessage="Username is required" ForeColor="Red" 
                        ControlToValidate="txtUserName" 
                        Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Password</b>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
                        ErrorMessage="Password is required" ForeColor="Red"
                        ControlToValidate="txtPassword" 
                        Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Comfim Password</b>
                </td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" 
                        runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidatorConfirmPassword" 
                        runat="server"
                        ErrorMessage="Password and ConfirmPassword must match" 
                        ForeColor="Red" 
                        ControlToValidate="txtConfirmPassword"
                        ControlToCompare="txtPassword" 
                        Display="Dynamic" Operator="Equal" 
                        Type="String" Text="*"></asp:CompareValidator>
                </td>
            </tr>
             <tr>
                 <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click"/>
                 </td>
             </tr>
             <tr>
                 <td>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail" Display="Dynamic" Text="Page Errors"></asp:RequiredFieldValidator>
                     <br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Username is required" ForeColor="Red" ControlToValidate="txtUsername" Display="Dynamic" Text="Error message 1."></asp:RequiredFieldValidator>
                     <br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password is required" ForeColor="Red" ControlToValidate="txtPassword" Display="Dynamic" Text="Error message 2."></asp:RequiredFieldValidator>--%>
                     <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Page Error"/>
                 </td>
             </tr>
             <tr>
                 <td>
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>
                 </td>
             </tr>
        </table>

    </form>
</body>
</html>
