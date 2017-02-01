"use strict";

// Declare app level module which depends on filters, and services
var app = angular.module("myApp", [
    "ngRoute",
    "ngResource"
]);

app.config(["$routeProvider", function ($routeProvider) {
    //$routeProvider.when('/Index', { templateUrl: 'Index.html', controller: 'CountryCtrl' });
    //$routeProvider.when('/create', { templateUrl: 'partials/create.html', controller: 'CreateCtrl' });
    //$routeProvider.when('/edit/:id', { templateUrl: 'partials/edit.html', controller: 'EditCtrl' });
    //$routeProvider.when('/details/:id', { templateUrl: 'partials/details.html', controller: 'DetailsCtrl' });
    //$routeProvider.when('/delete/:id', { templateUrl: 'partials/delete.html', controller: 'DeleteCtrl' });
    $routeProvider.otherwise({ redirectTo: "" });
}]);