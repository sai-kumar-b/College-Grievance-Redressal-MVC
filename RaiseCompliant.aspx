<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RaiseCompliant.aspx.cs" Inherits="Grievance_Cell_Project.RaiseCompliant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">      
        .auto-style2 {
            height: 52px;
        }
        .auto-style3 {
            font-size: large;
            text-align: center;
            color: #009933;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style6 {
            height: 52px;
            font-size: large;
        }
        .auto-style7 {
            height: 31px;
            font-size: medium;
            text-align: center;
            color: #333300;
        }
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" align="center" width="50%">
                <tr>
                    <td colspan="2" class="auto-style3"><strong>Raise Compliant from below.....!</strong></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Profile" BackColor="#999966" CssClass="auto-style9" Width="134px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Student Id</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" CssClass="auto-style5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Compliant Type</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style5">
                            <asp:ListItem>Generic</asp:ListItem>
                            <asp:ListItem Value="Department">Department</asp:ListItem>
                            <asp:ListItem>Library</asp:ListItem>
                            <asp:ListItem>Transport</asp:ListItem>
                            <asp:ListItem>Accounts</asp:ListItem>
                            <asp:ListItem>Administration</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Write your compliant</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ControlToValidate="TextBox1" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style4">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" ValidationGroup="Submit" CssClass="auto-style5" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style7">
                        <strong>See your previous compliants below...</strong></td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnPending" runat="server" OnClick="btnPending_Click" Text="Pending Complaints" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSolved" runat="server" OnClick="btnSolved_Click" Text="Solved Complaints" />
                        <strong>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLogOut" runat="server" BackColor="#006600" CssClass="auto-style4" ForeColor="Red" OnClick="btnLogOut_Click" style="height: 35px" Text="Logout" Width="90px" />
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style4">
                        <strong>
                        <asp:Label ID="lblMsg" runat="server" CssClass="auto-style1" ForeColor="Red"></asp:Label>
                        </strong>
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" align="center" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
