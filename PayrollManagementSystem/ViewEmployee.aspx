<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs" Inherits="PayrollManagement.ViewEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">View Employee Record
    </h1>
    <asp:Label ID="Label1" runat="server" Text="Enter Employee ID"></asp:Label>
&nbsp;
<asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
    &nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminHome.aspx">Go to Home</asp:HyperLink>
    <br />
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpID" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="EmpID" HeaderText="EmpID" InsertVisible="False" ReadOnly="True" SortExpression="EmpID" />
        <asp:BoundField DataField="Empname" HeaderText="Empname" SortExpression="Empname" />
        <asp:BoundField DataField="Dept" HeaderText="Dept" SortExpression="Dept" />
        <asp:BoundField DataField="EmailId" HeaderText="EmailId" SortExpression="EmailId" />
        <asp:BoundField DataField="MobNo" HeaderText="MobNo" SortExpression="MobNo" />
        <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
        <asp:BoundField DataField="Desg" HeaderText="Desg" SortExpression="Desg" />
    </Columns>
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollConnectionString %>" SelectCommand="SELECT * FROM [Employee] WHERE ([EmpID] = @EmpID)">
    <SelectParameters>
        <asp:ControlParameter ControlID="txtempid" Name="EmpID" PropertyName="Text" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
&nbsp;
</asp:Content>
