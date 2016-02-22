'use strict';

targetApp.controller('ReferenceMappingController',
    function ReferenceMappingController($scope, $log, referenceMappingData) {

        referenceMappingData.getData()
            .$promise
            .then(function (companyCode) { $scope.companyCode = companyCode; console.log(companyCode); })
            .catch(function (response) { console.log(response); }
            );

        $scope.something = 'my butt hurts';

        //$scope.companyCode = referenceMappingData.tableData;

        $scope.updateRow = function (rowData, form) {
            if (form.$valid) {
                referenceMappingData.update(rowData);
            }
        }
    }
);