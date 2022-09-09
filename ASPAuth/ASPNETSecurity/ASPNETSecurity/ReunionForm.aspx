<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReunionForm.aspx.cs" Inherits="ASPNETSecurity.ReunionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            margin-left: 93px;
            height: 524px;
        }
        .auto-style3 {
            width: 290px;
            height: 35px;
        }
        .auto-style4 {
            height: 35px;
        }
        .auto-style5 {
            width: 290px;
            height: 49px;
        }
        .auto-style6 {
            height: 49px;
        }
    </style>
</head>
<body style="background-color:darkmagenta">
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center;font-size:large">Reunion Form</h1>
            <h5 style="text-align:center">Time to rekindle some good ol' memories! See you soon!</h5>
            <hr />
        </div>
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label1" runat="server" BackColor="#FF9933" Font-Names="Cambria" Text="Date : 01-05-2022 | "></asp:Label>
            <asp:Label ID="Label2" runat="server" BackColor="#FF9933" Text=" Time : 6pm onwards | "></asp:Label>
            <asp:Label ID="Label3" runat="server" BackColor="#FF9933" Text="Address : Our garage "></asp:Label>
            <br />
        </div>
        <table class="auto-style1" border="0">
            <tr>
                <td class="auto-style3">
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Would you like to join us?" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;&nbsp;<asp:RadioButton ID="yesradio" runat="server" Text="Yes" />
&nbsp;
                    <asp:RadioButton ID="noradio" runat="server" Text="No" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Name"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="fntxt" runat="server" Width="111px"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fntxt" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="lntxt" runat="server" Width="114px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lntxt" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Phone"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="phonetxt" runat="server" TextMode="Phone" Width="201px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="phonetxt" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Your meal preference"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:RadioButton ID="vegradio" runat="server" Text="Vegetarian" />
                    <asp:RadioButton ID="nonvegradio" runat="server" Text="Non-Vegetarian" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" ForeColor="White" Text="What kind of games are you interested in?"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:CheckBoxList ID="gamecbl" runat="server">
                        <asp:ListItem>Indoor</asp:ListItem>
                        <asp:ListItem>Board</asp:ListItem>
                        <asp:ListItem>Ball Games</asp:ListItem>
                        <asp:ListItem>Outdoor</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;
                    <asp:Label ID="Label9" runat="server" ForeColor="White" Text="Do you have any questions?"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="quesTxt" runat="server" TextMode="MultiLine" Width="269px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="quesTxt" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;
        <asp:Label ID="output" runat="server" Text="Output" ForeColor="#FFFF66"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" BackColor="#660066" ForeColor="White" Text="Submit" OnClick="btnSubmit_Click" />
    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                </td>
                <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
