<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CCIMS.UI.Form.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CCIMS/Home</title>
    <link href="../CSS/Reset/Reset.css" rel="stylesheet" />
    <link href="../../Bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/Home.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-success" id="wrapper">
            <div class="panel-heading">Welcome To City Country Information</div>
            <div class="panel-body">
                <div class="panel panel-primary" id="entryPanel">
                    <div class="panel-heading">For Entry Only</div>
                    <div class="panel-body">
                        <div id="buttonAlaignment">
                            <a href="CountryEntry.aspx" class="btn btn-primary" role="button" id="button">Click The Button For Country Entry</a><br />
                            <br />
                            <a href="CityEntry.aspx" class="btn btn-primary" role="button" id="button">Click The Button For City Entry</a>
                        </div>

                    </div>
                </div>
            </div>
            <div class="panel panel-info" id="viewPanelr">
                <div class="panel-heading">For View Only</div>
                <div class="panel-body">
                    <div id="buttonAlaignment">
                        <a href="ViewCities.aspx" class="btn btn-info" role="button" id="button">Click The Button For View Cities</a><br />
                        <br />
                        <a href="ViewCountries.aspx" class="btn btn-info" role="button" id="button">Click The Button For View Countries</a>
                    </div>
                </div>
            </div>
           </div>
         

    </form>
</body>
</html>
