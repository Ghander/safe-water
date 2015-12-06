(function () {
    angular.module("SafeWater8", ['ngRoute', 'ui.bootstrap', 'ngResource', 'ngAnimate'])
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider
            /*
                .when('url/:urlParam1', {
                    templateUrl: '/url/to/template.html',
                    controller: 'BlahController',
                    controllerAs: 'vm'
                })
            */
                .when('/', {
                    templateUrl: '/ngViews/contaminantDemo.html',
                    controller: 'CtmntController',
                    controllerAs: 'vm'
                })
                .when('/ctmntList', {
                    templateUrl: '/ngViews/ctmntList.html',
                    controller: 'ctmntListController',
                    controllerAs: 'vm'
                })
                .when('/waterLogin', {
                    templateUrl: '/ngViews/waterLogin.html',
                    controller: 'loginController',
                    controllerAs: 'vm'
                })
                .otherwise({
                    templateUrl: '/ngViews/notFound.html'
                });
        }]);
})();