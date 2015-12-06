(function () {
    angular.module('SafeWater8')
        .service('loginService', ['$http', 'templateService', function ($http, templateService) {
            var self = this;

            self.login = function (username, password, callback) {
                var data = 'grant_type=password&username=' + username + '&password=' + password;

                $http.post('/token', data, {
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded'
                    }
                }).success(function (result) {
                    //var accessToken = result.access_token;
                    $http.defaults.headers.common.Authorization = 'Bearer ' + result.access_token;
                    templateService.user = username;                  
                    callback();
                }).error(function (xhr) {
                    templateService.user = null;
                });
            };
        }]);
})();