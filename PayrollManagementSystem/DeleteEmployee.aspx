<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DeleteEmployee.aspx.cs" Inherits="PayrollManagement.DeleteEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            border: 1px solid #000000;
            background-color: #00FFFF;
            text-align:center
        }
        .auto-style3 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Delete an Employee</h1>
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">Enter Employee Id</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="output" runat="server"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
            &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminHome.aspx">Go to Home</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
