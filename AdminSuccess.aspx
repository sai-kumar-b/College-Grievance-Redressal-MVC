<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSuccess.aspx.cs" Inherits="Grievance_Cell_Project.AdminSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
             width: 50%;
             margin-left:350px;
             margin-top:100px;
        }
        .auto-style10 {
            font-size: x-large;
            height: 45px;
            color: #006600;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style13 {
            color: #0066FF;
            font-size: x-large;
        }
        .auto-style14 {
            font-size: x-large;
            text-decoration: underline;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2" class="auto-style11"><strong><span class="auto-style10">Welcome to KNR college of engineering Grievance Cell</span></strong></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2"><strong><span class="auto-style13">=&gt;</span><asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style14" ForeColor="Blue" NavigateUrl="~/StudentsSection.aspx">Students Section</asp:HyperLink>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2"><strong><span class="auto-style13">&nbsp;&nbsp; =&gt;</span><asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style14" ForeColor="Blue" NavigateUrl="~/EmplooyeSection_Admin.aspx">Employees Section</asp:HyperLink>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2"><strong><span class="auto-style13">&nbsp;&nbsp;&nbsp; =&gt;</span><asp:HyperLink ID="HyperLink3" runat="server" CssClass="auto-style14" ForeColor="Blue" NavigateUrl="~/CompliantsSection.aspx">Compliants Section</asp:HyperLink>
                        </strong></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
