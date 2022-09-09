<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="BankingProject.NewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #008000;
            background-color: #00CC00;
        }
        .auto-style3 {
            width: 358px;
            height: 45px;
        }
        .auto-style4 {
            height: 45px;
        }
        .auto-style5 {
            width: 358px;
            height: 42px;
        }
        .auto-style6 {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="text-align:center">
                <tr>
                    <td class="auto-style3">CUSTOMER ID</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtcid" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">ACCOUNT TYPE</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Current</asp:ListItem>
                            <asp:ListItem>Savings</asp:ListItem>
                            <asp:ListItem>Fixed Deposit</asp:ListItem>
                            <asp:ListItem>Loan</asp:ListItem>
                            <asp:ListItem>Recurring Deposit</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">ACCOUNT STATUS</td>
                    <td class="auto-style4">
                        <asp:RadioButton ID="ractive" runat="server" GroupName="Status" Text="Active" />
                        <asp:RadioButton ID="rinactive" runat="server" GroupName="Status" Text="Inactive" />
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="output" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnNewAcc" runat="server" Text="Create Account" OnClick="btnNewAcc_Click" style="height: 26px" />
                    </td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home Page</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
