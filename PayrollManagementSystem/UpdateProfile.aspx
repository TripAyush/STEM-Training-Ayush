<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="PayrollManagement.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000000;
            background-color: cornflowerblue;
            text-align:center;
        }
        .auto-style3 {
            width: 275px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 275px;
            height: 41px;
        }
        .auto-style6 {
            height: 41px;
        }
        .auto-style7 {
            height: 40px;
            width: 302px;
        }
        .auto-style8 {
            height: 41px;
            width: 302px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Update your profile</h1>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Update Your Name</td>
            <td class="auto-style7"><asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style3">Update Your Email</td>
            <td class="auto-style7"><asp:TextBox ID="txtmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style3">Update Your Mobile Number</td>
            <td class="auto-style7"><asp:TextBox ID="txtpn" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style3">Update Your Location</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtloc" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">Enter your EmployeeID</td>
            <td>
                <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtempid"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="output" runat="server"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/EmployeeHome.aspx">Go to Home</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
