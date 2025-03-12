<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Grievance_Cell_Project.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            margin-left:330px;
            margin-top:100px;
            border: 2px solid red;
            border-radius: 10px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style4 {
            color: #0066CC;
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style5 {
            font-weight: normal;
            font-size: large;
            text-align: center;
            color: #003366;
        }
        .div1
        {
            
         }
        }
        .auto-style6 {
            font-size: large;
            color: #9966FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <strong><span class="auto-style4">Welcome to KNR college of engineering Grievance Cell</span></strong></td>
            </tr>
            <tr>
                <td colspan="3">
                    <h4 class="auto-style5"><strong>Select type of login</strong></h4>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>
                    <asp:Button ID="btnStudent" runat="server" BackColor="#99CCFF" CssClass="auto-style6" ForeColor="#009900" Text="Student" OnClick="btnStudent_Click" />
                    </strong></td>
                <td class="auto-style2"><strong>
                    <asp:Button ID="btnHOD" runat="server" BackColor="#99CCFF" CssClass="auto-style6" ForeColor="#009900" Text="HOD" OnClick="btnHOD_Click" />
                    </strong></td>
                <td class="auto-style2"><strong>
                    <asp:Button ID="btnAdmin" runat="server" BackColor="#99CCFF" CssClass="auto-style6" ForeColor="#009900" Text="Admin" OnClick="btnAdmin_Click" />
                    </strong></td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
