(function () {
    angular.module('SafeWater8')
    .controller('CtmntListController', function (ctmntService, $location) {
        var vm = this;

        vm.ctmnts = ctmntService.list();

//        vm.add = function () {
//        ctmntService.add(vm.newCtmnt)
//}

        
    });
})();