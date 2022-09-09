<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardExample.aspx.cs" Inherits="RegistrationForm.WizardExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CC99FF" BorderColor="Maroon" DataKeyNames="email" DataSourceID="SqlDataSource2" Height="218px" Width="461px">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="Qualification" HeaderText="Qualification" SortExpression="Qualification" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Skills" HeaderText="Skills" SortExpression="Skills" />
                    <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                    <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:StemDBAyushConnectionString %>" DeleteCommand="DELETE FROM [RegTable] WHERE [email] = @original_email AND [Name] = @original_Name AND [Address] = @original_Address AND [Password] = @original_Password AND (([Gender] = @original_Gender) OR ([Gender] IS NULL AND @original_Gender IS NULL)) AND (([Qualification] = @original_Qualification) OR ([Qualification] IS NULL AND @original_Qualification IS NULL)) AND [City] = @original_City AND (([Skills] = @original_Skills) OR ([Skills] IS NULL AND @original_Skills IS NULL)) AND (([age] = @original_age) OR ([age] IS NULL AND @original_age IS NULL))" InsertCommand="INSERT INTO [RegTable] ([Name], [Address], [Password], [Gender], [Qualification], [City], [Skills], [age], [email]) VALUES (@Name, @Address, @Password, @Gender, @Qualification, @City, @Skills, @age, @email)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [RegTable]" UpdateCommand="UPDATE [RegTable] SET [Name] = @Name, [Address] = @Address, [Password] = @Password, [Gender] = @Gender, [Qualification] = @Qualification, [City] = @City, [Skills] = @Skills, [age] = @age WHERE [email] = @original_email AND [Name] = @original_Name AND [Address] = @original_Address AND [Password] = @original_Password AND (([Gender] = @original_Gender) OR ([Gender] IS NULL AND @original_Gender IS NULL)) AND (([Qualification] = @original_Qualification) OR ([Qualification] IS NULL AND @original_Qualification IS NULL)) AND [City] = @original_City AND (([Skills] = @original_Skills) OR ([Skills] IS NULL AND @original_Skills IS NULL)) AND (([age] = @original_age) OR ([age] IS NULL AND @original_age IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_email" Type="String" />
                    <asp:Parameter Name="original_Name" Type="String" />
                    <asp:Parameter Name="original_Address" Type="String" />
                    <asp:Parameter Name="original_Password" Type="String" />
                    <asp:Parameter Name="original_Gender" Type="String" />
                    <asp:Parameter Name="original_Qualification" Type="String" />
                    <asp:Parameter Name="original_City" Type="String" />
                    <asp:Parameter Name="original_Skills" Type="String" />
                    <asp:Parameter Name="original_age" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Gender" Type="String" />
                    <asp:Parameter Name="Qualification" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Skills" Type="String" />
                    <asp:Parameter Name="age" Type="Int32" />
                    <asp:Parameter Name="email" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Gender" Type="String" />
                    <asp:Parameter Name="Qualification" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Skills" Type="String" />
                    <asp:Parameter Name="age" Type="Int32" />
                    <asp:Parameter Name="original_email" Type="String" />
                    <asp:Parameter Name="original_Name" Type="String" />
                    <asp:Parameter Name="original_Address" Type="String" />
                    <asp:Parameter Name="original_Password" Type="String" />
                    <asp:Parameter Name="original_Gender" Type="String" />
                    <asp:Parameter Name="original_Qualification" Type="String" />
                    <asp:Parameter Name="original_City" Type="String" />
                    <asp:Parameter Name="original_Skills" Type="String" />
                    <asp:Parameter Name="original_age" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
