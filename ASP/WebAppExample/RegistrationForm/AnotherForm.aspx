<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnotherForm.aspx.cs" Inherits="RegistrationForm.AnotherForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 2px solid #660066;
        }
        table{
            background-color:aquamarine;
        }
        .auto-style3 {
            width: 75px;
        }
        .auto-style5 {
            width: 398px;
        }
        .auto-style7 {
            width: 75px;
            height: 95px;
        }
        .auto-style8 {
            width: 398px;
            height: 95px;
        }
        .auto-style9 {
            height: 95px;
        }
        .auto-style10 {
            width: 75px;
            height: 45px;
        }
        .auto-style11 {
            width: 398px;
            height: 45px;
        }
        .auto-style12 {
            height: 45px;
        }
        .auto-style13 {
            width: 75px;
            height: 55px;
        }
        .auto-style14 {
            width: 398px;
            height: 55px;
        }
        .auto-style15 {
            height: 55px;
        }
        .auto-style16 {
            width: 75px;
            height: 60px;
        }
        .auto-style17 {
            width: 398px;
            height: 60px;
        }
        .auto-style18 {
            height: 60px;
        }
        .auto-style19 {
            width: 75px;
            height: 47px;
        }
        .auto-style20 {
            width: 398px;
            height: 47px;
        }
        .auto-style21 {
            height: 47px;
        }
        .auto-style22 {
            width: 75px;
            height: 49px;
        }
        .auto-style23 {
            width: 398px;
            height: 49px;
        }
        .auto-style24 {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">Name</td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Name cannot be blank"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Address</td>
                <td class="auto-style17">
                    <asp:TextBox ID="txtaddr" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtaddr" ErrorMessage="RequiredFieldValidator">Address cannot be blank</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp; Retype Password<asp:TextBox ID="txtrpwd" runat="server" style="margin-left: 8px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpass" ErrorMessage="Password cannot be empty"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtrpwd" ControlToValidate="txtpass" ErrorMessage="Please retype the same password as original"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">Gender</td>
                <td class="auto-style20">
                    <asp:RadioButton ID="txtradio1" runat="server" GroupName="gender" OnCheckedChanged="txtradio1_CheckedChanged" Text="Male" />
                    <asp:RadioButton ID="txtradio2" runat="server" GroupName="gender" OnCheckedChanged="txtradio2_CheckedChanged" Text="Female" />
                </td>
                <td class="auto-style21"></td>
            </tr>
            <tr>
                <td class="auto-style10">Qualification</td>
                <td class="auto-style11">
                    <asp:CheckBoxList ID="cblist" runat="server" AutoPostBack="True">
                        <asp:ListItem>B Tech</asp:ListItem>
                        <asp:ListItem>M Tech</asp:ListItem>
                        <asp:ListItem>MBA</asp:ListItem>
                        <asp:ListItem>MCA</asp:ListItem>
                        <asp:ListItem>LLB</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style10">City</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="True">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Chennai</asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Chandigarh</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlcity" ErrorMessage="Please select a city" InitialValue="Select"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Skillsets</td>
                <td class="auto-style5">
                    <asp:ListBox ID="lbskills" runat="server" AutoPostBack="True" SelectionMode="Multiple">
                        <asp:ListItem>C#</asp:ListItem>
                        <asp:ListItem>Javascript</asp:ListItem>
                        <asp:ListItem>Typescript</asp:ListItem>
                        <asp:ListItem>React</asp:ListItem>
                        <asp:ListItem>Angular</asp:ListItem>
                        <asp:ListItem>ASP</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    Age</td>
                <td class="auto-style23">
                    <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" ErrorMessage="Please enter a valid age" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    Email</td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" style="height: 26px" />
                </td>
                <td class="auto-style23">
                    <asp:Button ID="reset" runat="server" OnClick="reset_Click" Text="Reset" CausesValidation="False" />
                </td>
                <td class="auto-style24">
                    <asp:Label ID="output" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <asp:GridView ID="GridView1" runat="server" BackColor="#FFFF99">
        </asp:GridView>
        <asp:Button ID="btnSelect" runat="server" CausesValidation="False" OnClick="btnSelect_Click" Text="Select" />
        <asp:GridView ID="GridView2" runat="server" BackColor="#9999FF" BorderColor="#660066" BorderStyle="Dashed">
        </asp:GridView>
        <asp:Button ID="selectDS" runat="server" CausesValidation="False" OnClick="selectDS_Click" Text="SelectDS" />
    </form>
</body>
</html>
