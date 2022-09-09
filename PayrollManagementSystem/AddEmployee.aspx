<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="PayrollManagement.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            border: 1px solid #000000;
            background-color: #C0C0C0;
            text-align:center;
        }
        .auto-style3 {
            height: 46px;
        }
        .auto-style4 {
            height: 44px;
        }
        .auto-style5 {
            height: 43px;
        }
        .auto-style6 {
            height: 40px;
        }
        .auto-style7 {
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Add a new Employee</h1>
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">Employee Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtename" ErrorMessage="Enter your name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Department Name</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddDept" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>IT</asp:ListItem>
                    <asp:ListItem>ACCOUNTS</asp:ListItem>
                    <asp:ListItem>HR</asp:ListItem>
                    <asp:ListItem>ADMIN</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style5">EmailId</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtmail" ErrorMessage="Enter your email"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mobile Number</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtphone" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtphone" ErrorMessage="Enter your Number"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Location</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtloc" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style7">Designation</td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddDesg" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>ANALYST</asp:ListItem>
                    <asp:ListItem>MANAGER</asp:ListItem>
                    <asp:ListItem>ASST MANAGER</asp:ListItem>
                    <asp:ListItem>JR STAFF</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="output" runat="server"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnAdd" runat="server" Text="Add Employee" OnClick="btnAdd_Click" />
                </td>
            <td class="auto-style6">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminHome.aspx">Home Page</asp:HyperLink>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
