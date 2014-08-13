var app = angular.module('Jenga', ['ngRoute']);
app.config(function ($routeProvider, $httpProvider) {
    $routeProvider.when('/', {
        templateUrl: '/app/views/home.html',
        controller: 'homeController'
    })
    $routeProvider.when('/Game', {
        templateUrl: '/app/views/Game.html',
        controller: 'homeController'
    })

    $httpProvider.interceptors.push('AuthInterceptor');
})