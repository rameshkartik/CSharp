<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Entity_ModelFirst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Verdana">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="EntityDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="UniversityName" HeaderText="UniversityName" SortExpression="UniversityName" />
                <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                <asp:TemplateField HeaderText="Colleges">
                    <ItemTemplate>
                        <asp:GridView ID="GridView2" runat="server" DataSource='<%# Eval("UColleges") %>' AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="CollegeName" HeaderText="CollegeName" />
                                <asp:BoundField DataField="PrincipalName" HeaderText="PrincipalName" />
                                <asp:BoundField DataField="NoOfDepts" HeaderText="NoOfDepts" />
                            </Columns>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
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
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=CollegeContainer" DefaultContainerName="CollegeContainer" EnableFlattening="False" EntitySetName="Universities" Include="UColleges"></asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
