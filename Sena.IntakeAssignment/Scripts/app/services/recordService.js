(function () {
    'use strict';

    angular
        .module('app')
        .factory('recordService', recordService);

    recordService.$inject = ['$http'];

    function recordService($http) {
        var service = {
            getRecords: getRecords,
            editRecord: editRecord
        };

        return service;

        function getRecords() {
            return $http.get('GetRecords');
        }

        function editRecord(editedRecord) {
            return $http.post('UpdateRecord', editedRecord);
        }
    }
})();