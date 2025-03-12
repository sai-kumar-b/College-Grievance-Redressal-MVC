<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLogin.aspx.cs" Inherits="Grievance_Cell_Project.StudentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
           margin-left:400px;
           margin-top:80px;
           width:40%;
        }
        .auto-style2 {
            height: 31px;
            text-align: center;
        }
        .auto-style5 {
            height: 45px;
        }
        .auto-style6 {
            font-size: large;
        }
        .auto-style8 {
            font-size: large;
            color: #66CCFF;
        }
        .auto-style9 {
            height: 39px;
            text-align: left;
        }
        .auto-style10 {
            font-size: x-large;
            height: 45px;
            color: #006600;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style12 {
            height: 31px;
            text-align: center;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong><span class="auto-style10">Welcome to KNR college of engineering Grievance Cell</span></strong></td>
            </tr>
            <tr>
                <td class="auto-style12" colspan="2"><strong>Login with student details.....</strong></td>
            </tr>
            <tr>
                <td>
                    <h4 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style6">Roll Number</span></h4>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td ><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style6"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password</span></strong></td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style6" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style11"><strong>
                    <asp:Button ID="btnLogin" runat="server" BackColor="#999966" CssClass="auto-style8" ForeColor="#FF0066" OnClick="btnLogin_Click" Text="Login" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2">
                    &nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/HomePage.aspx">&lt;=main_page</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
