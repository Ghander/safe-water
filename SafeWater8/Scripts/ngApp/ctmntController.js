(function () {

    angular.module('SafeWater8')
    .controller('ctmntController',  function ($location) {
        var vm = this;

        vm.move = function () {
            $location.path('ctmntList/')
        }

            
     
    });
})();