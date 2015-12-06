(function () {
    angular.module('SafeWater8')
        .controller('loginController', function(loginService, $location){
        var vm = this;

        vm.login = function () {
            loginService.login(vm.username, vm.password, function () {

                $location.path('/');
            });
        };
    });
})();
