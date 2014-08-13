app.controller('homeController', function ($scope, $http, $q, LoginService, $window, $location) {
    $scope.loggedIn = false;
    $scope.token = 'Not Logged In';
    $scope.login = function () {
        LoginService.processLogin($scope.user.username, $scope.user.password)
            .then(function () {
                $location.path('/Game')
                //$scope.token = $window.sessionStorage.getItem('token');
            }, function (status) {

                $scope.token = status;
            });
    };
})