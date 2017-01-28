(function () {
    'use strict';

    angular
        .module('app')
        .factory('recordService', recordService);

    recordService.$inject = ['$http'];

    function recordService($http) {
        var service = {
            getRecords: getRecords,
            addRecord: addRecord
        };

        return service;

        function getRecords() {
            return $http.get('GetRecords');
        }

        function addRecord() {
            return $http.post('UpdateRecord');
        }
    }
})();