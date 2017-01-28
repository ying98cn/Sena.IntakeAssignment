(function () {
    'use strict';

    angular
        .module('app')
        .controller('recordController', recordController);

    recordController.$inject = ['$scope', 'recordService']; 

    function recordController($scope, recordService) {
        $scope.title = 'recordController';

        recordService
            .getRecords()
            .success(function (result) {
                $scope.RecordList = result;
            });

    }
})();
