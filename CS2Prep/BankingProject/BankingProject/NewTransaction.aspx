<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTransaction.aspx.cs" Inherits="BankingProject.NewTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #DEBA84;
            background-color: #FFE4C4;
        }
        .auto-style3 {
            width: 400px;
            height: 35px;
        }
        .auto-style4 {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Customer ID : "></asp:Label>
&nbsp;
            <asp:TextBox ID="txtcid" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Go To Home</asp:HyperLink>
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="AccountNo" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="AccountNo" HeaderText="AccountNo" InsertVisible="False" ReadOnly="True" SortExpression="AccountNo" />
                <asp:BoundField DataField="CustId" HeaderText="CustId" SortExpression="CustId" />
                <asp:BoundField DataField="AccountType" HeaderText="AccountType" SortExpression="AccountType" />
                <asp:BoundField DataField="Balance" HeaderText="Balance" SortExpression="Balance" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btn1" runat="server" Text="Choose Account" OnClick="btn1_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <hr />
        <h1>Transaction</h1>
        <div style="background-color:bisque">
            <table class="auto-style1" style="text-align:center">
                <tr>
                    <td class="auto-style3">Enter Account ID</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="accid" runat="server" Width="160px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Select Transaction Type</td>
                    <td class="auto-style4">
                        <asp:RadioButtonList ID="rbtt" runat="server" RepeatDirection="Horizontal" Width="552px">
                            <asp:ListItem>Withdraw</asp:ListItem>
                            <asp:ListItem>Deposit</asp:ListItem>
                            <asp:ListItem>Fund Transfer</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Enter Transaction Amount</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tamount" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="output" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnTransact" runat="server" OnClick="btnTransact_Click" Text="Make Transaction" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StemDBConnectionString %>" SelectCommand="SELECT * FROM [Accounts] WHERE ([CustId] = @CustId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtcid" Name="CustId" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
