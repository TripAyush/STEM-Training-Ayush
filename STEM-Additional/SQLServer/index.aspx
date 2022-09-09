<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaOrderForm.aspx.cs" Inherits="PizzaInfo.PizzaOrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center">Luigi's Pizzas</h1>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Date : "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtdate" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Phone : "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncustomer" runat="server" CausesValidation="False" Enabled="False" Text="Find Customer" />
    </form>
</body>
</html>
