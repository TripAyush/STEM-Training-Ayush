<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SalaryGeneration.aspx.cs" Inherits="PayrollManagement.SalaryGeneration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            border: 1px solid #800000;
            background-color: #FFCCFF;
            text-align:center;
        }
        .auto-style3 {
            height: 40px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1 style="text-align:center">Generate Salary</h1>
    </div>
    <div>
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="empID" runat="server" Text="Employee ID"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtempid" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                Enter Designation</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddldesg" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>ANALYST</asp:ListItem>
                    <asp:ListItem>MANAGER</asp:ListItem>
                    <asp:ListItem>ASST MANAGER</asp:ListItem>
                    <asp:ListItem>JR STAFF</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                Enter Salary</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="output" runat="server"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Button ID="btnsalary" runat="server" Text="Generate Salary" OnClick="btnsalary_Click" />
            &nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminHome.aspx">Go to Home</asp:HyperLink>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
