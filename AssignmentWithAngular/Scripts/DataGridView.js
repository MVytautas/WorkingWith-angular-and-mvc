var app = angular.module('myApp', ['ngResource']);
app.controller('myCtrl', function ($scope, $resource) {

    var Users = $resource('/api/tables');
    $scope.users = Users.query(function () {
        console.log(user);
    });


});