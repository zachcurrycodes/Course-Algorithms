//var myApp = angular.module('myApp', []);

//myApp.controller('myAppCtrl', function ($scope) {
//    $scope.firstName = "John";
//    $scope.lastName = "Doe";
//    $scope.somestring = 'test string';
//    //$scope.employeeModel = Model;
//});



function myAngularJStest(scope, http) {
    scope.allusers = '';
    //$scope.somestring = 'test string';

    var abc;
    scope.update = function (p1) {
        http({
            url: 'AngularTest/UpdateData?p1=' + p1,
            method: 'GET'
        }).then(function (data) {
            scope.somestring = data.data.extra;
            scope.employeeModel = data.data;
            abc = data;
            console.log(abc);
        });
    };

    scope.findIt = function () {
        http.get("https://api.github.com/users/KirinDave").then(onFindComplete);
    };

    var onFindComplete = function (response) {
        scope.user = response.data;
        http.get(scope.user.repos_url).then(onFindAllComplete);
    };

    var onFindAllComplete = function (response) {
        scope.allusers = response.data;
    }

}





