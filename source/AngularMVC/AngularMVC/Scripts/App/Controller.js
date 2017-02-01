"user strict";

app.factory("Country", ["$resource", function ($resource) {
    var resource = $resource("http://localhost:50939/Country/LoadCountries");
    return resource;
}]);
app.factory("City",["$resource", function ($resource) {
        var resource = $resource("http://localhost:50939/City/LoadCities");
        return resource;
    }
]);

app.controller("countryCtrl", ["$scope", "Country", function ($scope, Country) {

    $scope.Title = "Country";
    $scope.Heading = "Country List";
    $scope.Countries = [];

    Country.get(function (response) {
        $scope.Countries = response.Data;
    });

}]);

app.controller("cityCtrl", ["$scope", "City", function ($scope, City) {

    $scope.Title = "City";
    $scope.Heading = "City List";
    $scope.Cities = [];

    City.get(function (response) {
        $scope.Cities = response.Data;
    });

}])