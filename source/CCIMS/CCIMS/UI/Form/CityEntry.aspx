<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CCIMS.UI.Form.CityEntry" %>

<%@ Register TagPrefix="RTE" Namespace="RTE" Assembly="RichTextEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>City Entry</title>
    <link href="../CSS/Reset/Reset.css" rel="stylesheet" />
    <link href="../../Bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/CityEntry.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-primary" id="wrapper">
            <div class="panel-heading">City Entry</div>
            <div class="panel-body">
                <div class="panel panel-info" id="cityEntryPanel">
                    <div class="panel-heading">City Entry Form</div>
                    <div class="panel-body">
                        <table>
                            <tr>
                                <td>Name</td>
                                <td>
                                    <asp:TextBox runat="server" ID="cityNameTextBox" CssClass="form-control" placeholder="Type A City Name" Width="210px" />
                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>About</td>
                                <td>
                                    <br />
                                    <RTE:Editor ID="cityEntryEditor" ContentCss="example.css" runat="server" Width="760px" Height="400px" />
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table>
                            <tr>
                                <td>No. Of Dwellers</td>
                                <td>
                                    <asp:TextBox runat="server" ID="noOfDwellersTextBox" CssClass="form-control" placeholder="Only Number" type="number" Width="210px" /><br />
                                </td>
                            </tr>
                            <tr>
                                <td>Location</td>
                                <td>
                                    <asp:TextBox runat="server" ID="locationTextBox" CssClass="form-control" placeholder="Location" type="text" Width="210px" /><br />
                                </td>
                            </tr>
                            <tr>
                                <td>Weathers</td>
                                <td>
                                    <asp:TextBox runat="server" ID="weatherTextBox" CssClass="form-control" placeholder="weather" type="text" Width="210px" /><br />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="messageLabel"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>Country</td>
                                <td>
                                    <asp:DropDownList runat="server" ID="countryDropDownList" /></td>
                                <td>
                                    <div class="button">
                                        <asp:Button runat="server" ID="saveButton" CssClass="btn btn-info" Text="Save" OnClick="saveButton_Click" />
                                        <a href="Home.aspx" class="btn cancelButton btn-primary" role="button">Cancel</a>
                                    </div>
                                </td>
                            </tr>
                        </table>

                    </div>
                </div>
            </div>

            <div class="panel panel-primary" id="gridViewPanel">
                <div class="panel-heading">Result In Gridview</div>
                <div class="panel-body">
                    <asp:GridView ID="cityEntryGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="758px" >
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL#">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="No. Of Dwellers">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("Dwellers") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Country">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
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
    </form>
</body>
</html>
