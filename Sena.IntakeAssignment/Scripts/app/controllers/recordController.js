(function () {
    'use strict';

    angular
        .module('app')
        .controller('recordController', recordController);

    recordController.$inject = ['$scope', 'recordService']; 

    function recordController($scope, recordService) {
        $scope.record = {
            'artist': 'wewe',
            'albumTitle': 'ff',
            'catalogueNumber': 'ff',
            'title': '',
            'year': '',
            'isrcCode': false
        };

        // load record list
        recordService
            .getRecords()
            .success(function (result) {
                $scope.RecordList = result;
            });

        // edit record information
        $scope.editRecord = function () {
            recordService.updateRecord();
        }

        // get selected record
        $scope.getSelectedRecord = function (id) {
            //var result = 
            //    $.grep($scope.RecordList, function(e){ 
            //        return e.id == id; 
            //    });
            var result = null;
            $scope.record = result || $scope.record;
        }

    }
})();
