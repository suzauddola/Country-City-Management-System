<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountries.aspx.cs" Inherits="CCIMS.UI.Form.ViewCountries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Countries</title>
    <link href="../CSS/Reset/Reset.css" rel="stylesheet" />
    <link href="../../Bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/ViewCountries.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">


        <div class="panel panel-primary" id="wrapper">
            <div class="panel-heading">View Countries</div>
            <div class="panel-body">
                <div class="panel panel-info" id="searchPanel">
                    <div class="panel-heading">Search Criteria</div>
                    <div class="panel-body">
                        <div class="form-inline">
                            <div class="form-group">
                                <label for="countryName">Name</label>
                                <asp:TextBox runat="server" ID="searchCountryByNameTextBox" CssClass="form-control" placeholder="Type A Country Name" type="text" Width="210px" />

                            </div>
                            <asp:Button runat="server" ID="searchButton" CssClass="btn btn-info" Text="Search" OnClick="searchButton_Click" />
                            <a href="Home.aspx" class="btn cancelButton btn-primary" role="button">Cancel</a>
                            <asp:Label runat="server" ID="messageLabel"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="panel panel-success" id="gridViewPanel">
                    <div class="panel-heading">Result in GridView</div>
                    <div class="panel-body">
                        <asp:GridView ID="viewCountryGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AllowPaging="True" OnPageIndexChanging="viewCountryGridView_PageIndexChanging" PageSize="3">
                            <AlternatingRowStyle BackColor="#F7F7F7" />
                            <Columns>
                                <asp:TemplateField HeaderText="SL#">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="City Name">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="About">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("About") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="No. Of Cities">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("NoCities") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="No. Of Dwellers">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("NoCityDwellers") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <SortedAscendingCellStyle BackColor="#F4F4FD" />
                            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                            <SortedDescendingCellStyle BackColor="#D8D8F0" />
                            <SortedDescendingHeaderStyle BackColor="#3E3277" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
            <div class="container" id="pagination">
                <ul class="pagination">
                    <li class="disabled"><a href="">&laquo;</a></li>
                    <li class="active"><a href="">1</a></li>
                    <li><a href="">2</a></li>
                    <li><a href="">3</a></li>
                    <li><a href="">&raquo;</a></li>
                </ul>
            </div>
        </div>


    </form>

</body>
</html>
