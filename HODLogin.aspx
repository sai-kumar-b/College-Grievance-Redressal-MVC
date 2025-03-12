<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HODLogin.aspx.cs" Inherits="Grievance_Cell_Project.HODLogin" %>

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
            height: 45px;
            text-align: center;
            font-size: x-large;
            color: #336600;
            text-decoration: underline;
        }
        .auto-style4 {
            font-size: x-large;
            height: 45px;
        }
        .auto-style6 {
            font-size: large;
        }
        .auto-style5 {
            height: 45px;
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
            height: 48px;
        }
       
        .auto-style11 {
            height: 45px;
            text-align: center;
            font-size: large;
            color: #333300;
            text-decoration: underline;
        }
       
    </style>
</head>
<body style="background-image:url()">
    <form id="form2" runat="server">
        <table class="auto-style1" >
            <tr>
                <td class="auto-style2" colspan="2"><strong>Welcome to KNR college of engineering Grievance Cell</strong></td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="2"><strong>Login with Employee details.....</strong></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <h4 class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; Employee Id</h4>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6" Width="187px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style6">Password</span></strong></td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style6" Width="189px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnLogin" runat="server" BackColor="#999966" CssClass="auto-style8" ForeColor="#FF0066" Text="Login" OnClick="btnLogin_Click" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2">
                    <strong>
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/HomePage.aspx">&lt;=main_page</asp:HyperLink>
                    &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red"></asp:Label>
                    </strong>
                </td>
            </tr>
        </table>
    </form>

</body>
</html>
