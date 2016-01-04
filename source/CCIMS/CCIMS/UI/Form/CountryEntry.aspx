<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CCIMS.UI.Form.CountryEntry" %>

<%@ Register TagPrefix="RTE" Namespace="RTE" Assembly="RichTextEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Country Entry</title>
    <link href="../CSS/Reset/Reset.css" rel="stylesheet" />
    <link href="../../Bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/CountryEntry.css" rel="stylesheet" />
    <%--<link href="../../richtexteditor/styles/richtexteditor.css" rel="stylesheet" />--%>
</head>
<body>

    <form id="form1" runat="server">
        <div class="panel panel-primary" id="wrapper">
            <div class="panel-heading">Country Entry</div>
            <div class="panel-body">
                <div class="panel panel-info" id="countryFormPanel">
                    <div class="panel-heading">Country Entry Form</div>
                    <div class="panel-body">
                        <table>
                            <tr>
                                <td>Name</td>
                                <td>
                                    <asp:TextBox runat="server" ID="countryNameTextBox" CssClass="form-control" placeholder="Type A Country Name" Width="210px" /></td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>About</td>
                                <td>
                                    <br />
                                    <RTE:Editor ID="countryEntryEditor" ContentCss="example.css" runat="server" Width="760px" Height="400px" />
                                    <br />
                                </td>
                            </tr>

                            <tr>
                                <td></td>
                                <td>
                                    <div class="button">
                                        <asp:Button runat="server" ID="saveButton" CssClass="btn btn-info" Text="Save" OnClick="saveButton_Click" />
                                        <a href="Home.aspx" class="btn cancelButton btn-primary" role="button">Cancel</a>
                                        <asp:Label runat="server" ID="messageLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>

                        </table>
                    </div>
                </div><br/>
                <div class="panel panel-primary" id="gridViewPanel">
                    <div class="panel-heading">Result In Gridview</div>
                    <div class="panel-body">
                        <asp:GridView ID="countryEntryGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
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
                                <asp:TemplateField HeaderText="About">
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='<%#Eval("About") %>'></asp:Label>
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
        </div>
    </form>
</body>
</html>
