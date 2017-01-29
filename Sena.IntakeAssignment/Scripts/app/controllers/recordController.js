(function () {
    'use strict';

    angular
        .module('app')
        .controller('recordController', recordController);

    recordController.$inject = ['$scope', '$log', 'ngDialog', 'recordService'];

    function recordController($scope, $log, ngDialog, recordService) {
        $scope.init = function () {
            getRecords();
        }

        $scope.record = {
            'artist': '',
            'albumTitle': '',
            'catalogueNumber': '',
            'title': '',
            'year': '',
            'isrcCode': ''
        };

        // load record list
        function getRecords() {
            recordService
                .getRecords()
                .success(function (result) {
                    $scope.RecordList = result;
                })
                .error(function (result) {
                    $log.error('something went wrong when getting records due to ', error)
                });
        }

        // show the edit record dialog when the user clicks on the Edit button
        $scope.showEditRecordDialog = function (record) {
            $scope.editRecord = angular.copy(record) || $scope.record;

            ngDialog.openConfirm({
                template: '/Templates/editRecordDialog.html',
                className: 'ngdialog-theme-default',
                closeByDocument: true,
                scope: $scope
            }).then(function (editedRecord) { // the save button is clicked
                recordService.editRecord(editedRecord)
                .success(function (result) {
                    if (result.error) {
                        $log.error(error);
                    } else {
                        $log.debug('Record is updated.');
                        getRecords();
                    }
                })
                .error(function (error) {
                    $log.error('Unable to edit record: ' + error.message);
                });
            }, function () { // the cancel button is clicked
                $log.debug('Cancel button is clicked.');
            });
        }

    }
})();
