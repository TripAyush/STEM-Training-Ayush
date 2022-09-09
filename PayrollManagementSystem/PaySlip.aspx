<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="PaySlip.aspx.cs" Inherits="PayrollManagement.PaySlip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">View Payslip</h1>
    <asp:Label ID="Label1" runat="server" Text="Enter Employee ID"></asp:Label>
&nbsp;
<asp:TextBox ID="txtempid" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/EmployeeHome.aspx">Go to Home</asp:HyperLink>
    <br />
    <br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="SalaryID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="SalaryID" HeaderText="SalaryID" InsertVisible="False" ReadOnly="True" SortExpression="SalaryID" />
        <asp:BoundField DataField="EmpID" HeaderText="EmpID" SortExpression="EmpID" />
        <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
        <asp:BoundField DataField="Desg" HeaderText="Desg" SortExpression="Desg" />
        <asp:BoundField DataField="SalaryDate" HeaderText="SalaryDate" SortExpression="SalaryDate" />
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollConnectionString3 %>" SelectCommand="SELECT * FROM [SalaryInfo] WHERE ([EmpID] = @EmpID)">
    <SelectParameters>
        <asp:ControlParameter ControlID="txtempid" Name="EmpID" PropertyName="Text" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
<br />
</asp:Content>
