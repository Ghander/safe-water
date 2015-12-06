(function () {

    angular.module('SafeWater8')
    .service('ctmntService', ['$resource', function ($resource) {
        var self = this;

        var Ctmnt = $resource('api/contaminants/:id');

        self.list = function () {
            return Ctmnt.query();
        }

        self.add = function (ctmnt, callback) {
            var newCtmnt = new Ctmnt({
                name: ctmnt.name,
                healtheffects: ctmnt.healtheffects,
                soource: ctmnt.source
            });
            newCtmnt.$save();
        };
        self.delete = function (ctmnt, callback) {
            ctmnt.$remove({ id: ctmnt.id }, callback);
        };
    }]);
})();