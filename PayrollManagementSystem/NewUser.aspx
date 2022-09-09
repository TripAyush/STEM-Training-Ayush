<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="PayrollManagement.NewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000000;
            background-color: lightcoral;
        }
        .auto-style4 {
            width: 148px;
            height: 40px;
        }
        .auto-style5 {
            width: 380px;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
        .auto-style7 {
            width: 148px;
            height: 44px;
        }
        .auto-style8 {
            width: 380px;
            height: 44px;
        }
        .auto-style9 {
            height: 44px;
        }
        .auto-style10 {
            width: 148px;
            height: 45px;
        }
        .auto-style11 {
            width: 380px;
            height: 45px;
        }
        .auto-style12 {
            height: 45px;
        }
        .auto-style13 {
            width: 148px;
            height: 46px;
        }
        .auto-style14 {
            width: 380px;
            height: 46px;
        }
        .auto-style15 {
            height: 46px;
        }
    </style>
</head>
<body>
    <h1 style="text-align:center">New User Registration</h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="text-align:center">
                <tr>
                    <td class="auto-style4">User Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtuname" ErrorMessage="Please Enter Your Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">User Role</td>
                    <td class="auto-style8">
                        <asp:RadioButton ID="rbadmin" runat="server" GroupName="Role" Text="Admin" />
                        <asp:RadioButton ID="rbemployee" runat="server" GroupName="Role" Text="Employee" />
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Password</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd" ErrorMessage="Please Enter Your Password"></asp:RequiredFieldValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Confirm Password</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtcpwd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtcpwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="output" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="btnNewUser" runat="server" Text="Register" OnClick="btnNewUser_Click" />
                    </td>
                    <td class="auto-style15">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
