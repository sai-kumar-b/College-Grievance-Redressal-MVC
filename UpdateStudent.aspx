<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudent.aspx.cs" Inherits="Grievance_Cell_Project.UpdateStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
            margin-left:400px;
            margin-top:60px;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: center;
            color: #336600;
        }
        .auto-style3 {
            font-size: large;
            width: 412px;
        }
        .auto-style4 {
            font-size: large;
            height: 35px;
            width: 412px;
        }
        .auto-style5 {
            height: 35px;
            width: 376px;
        }
        .auto-style6 {
            width: 376px;
        }
        .auto-style7 {
            font-size: large;
            font-weight: bold;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style9 {
            text-align: right;
        }
        .auto-style10 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="2" class="auto-style2"><strong>Update Your Details From Below.....!</strong></td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style9" >
                        <strong>
                        <asp:Button ID="btnLogOut" runat="server" BackColor="#006600" CssClass="auto-style4" ForeColor="Red" OnClick="btnLogOut_Click" style="height: 35px" Text="Logout" Width="90px" />
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Roll Number</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtRollNumber" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Department</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtDepartment" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtName" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mobile Number</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMobileNo" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Year</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtYear" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style8">
                        <strong>
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" CssClass="auto-style7" />
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style8">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style10" ForeColor="Blue" NavigateUrl="~/RaiseCompliant.aspx">Home_Page</asp:HyperLink>
                        </em>&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>

            <br />
            <br />
            <br />
          
        </div>
         <div class="div2" align="center">
 <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True">
</asp:GridView>
 </div>
        
    </form>
</body>
</html>
