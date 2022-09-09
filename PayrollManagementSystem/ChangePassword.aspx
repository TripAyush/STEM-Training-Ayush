<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="PayrollManagement.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000080;
            background-color: #99CCFF;
            text-align:center;
        }
        .auto-style2 {
            height: 45px;
        }
        .auto-style3 {
            height: 55px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Change Password</h1>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Enter User ID</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtuid" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Enter your User ID" ControlToValidate="txtuid"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Enter New Password</td>
            <td class="auto-style2">
                <asp:TextBox ID="newpass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter a new password" ControlToValidate="newpass"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Confirm New Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="confirmpass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Mismatch" ControlToCompare="newpass" ControlToValidate="confirmpass"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="output" runat="server"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:Button ID="changeBtn" runat="server" Text="Change Password" OnClick="changeBtn_Click" Width="145px" />
            </td>
            <td class="auto-style2">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/EmployeeHome.aspx">Go back to Home</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
