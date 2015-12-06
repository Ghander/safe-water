(function () {
    angular.module('SafeWater8')
    .controller('TemplateController', function (templateService) {
        var vm = this;
        Object.defineProperty(vm, 'user', {
            get: function () {
                return templateService.user;
            }
        });
    })
    .service("templateService", function () {
    });
})();