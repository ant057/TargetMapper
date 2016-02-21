'use strict';

targetApp.controller('ReferenceMappingController',
    function ReferenceMappingController($scope, $log, referenceMappingData) {

        $scope.something = 'my butt hurts';

        $scope.companyCode = referenceMappingData.tableData;

        $scope.updateRow = function (rowData, form) {
            if (form.$valid) {
                referenceMappingData.update(rowData);
            }
        }
    }
);