<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CCIMS.UI.Form.ViewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Cities</title>
    <link href="../CSS/Reset/Reset.css" rel="stylesheet" />
    <link href="../../Bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/ViewCities.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-primary" id="wrapper">
            <div class="panel-heading">View Cities</div>
            <div class="panel-body">
                <div class="panel panel-info" id="viewCitiesPanel">
                    <div class="panel-heading">View Cities</div>
                    <div class="panel-body">
                        <table class="searchRadio">
                            <tr>
                                <td>
                                    <asp:RadioButton runat="server" ID="cityNameRadioButton" Text="City Name" GroupName="select" />
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="cityNameSearchTextBox" CssClass="form-control" placeholder="Type A City Name" type="text" Width="210px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton runat="server" ID="countryRadioButton" Text="Country" GroupName="select" />
                                </td>
                                <td>
                                    <asp:DropDownList runat="server" ID="countryDropDownList" Width="100%" Height="35px" />
                                </td>
                                <td>
                                    <asp:Button runat="server" ID="searchButton" CssClass="btn btn-info" Text="Search" OnClick="searchButton_Click" />
                                    <a href="Home.aspx" class="btn cancelButton btn-primary " role="button" id="buttonSize">Cancel</a>
                                    <asp:Label runat="server" ID="messageLabel"></asp:Label>
                                </td>
                            </tr>
                        </table>

                    </div>
                </div>

            </div>
            <div class="panel panel-success" id="gridViewPanel">
                <div class="panel-heading">Result In Gridview</div>
                <div class="panel-body">
                    <asp:GridView ID="viewCityGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AllowPaging="True" OnPageIndexChanging="viewCityGridView_PageIndexChanging" PageSize="3">
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

                            <asp:TemplateField HeaderText="No. Of Dwellers">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("Dwellers") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Location">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("Location") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Weather">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("Weather") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Country">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="About Country">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("AboutCountry") %>'></asp:Label>
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

