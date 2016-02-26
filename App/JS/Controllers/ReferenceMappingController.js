
targetApp.controller('ReferenceMappingController',
    function ReferenceMappingController($scope, $log, referenceMappingData) {

        $scope.tableDiv = true;
        $scope.loading = false;

        $scope.searchChanged = function () {
            $scope.updateResult = false;
        };

        $scope.getTableData = function (table) {

            $scope.tableDiv = true;
            $scope.loading = true;
            $scope.searchText = '';
            $scope.updateResult = false;

            //$('#tableDiv').

            referenceMappingData.getData(table)
                .$promise
                .then(function (response) {
                    $scope.companyCode = response;
                    $scope.tableDiv = false;
                    $scope.loading = false;
                })
                .catch(function (response) {
                    console.log(response);
                });
                
        };

        $scope.something = 'something';

        $scope.updateRow = function (table, rowData, form) {
            if (window.confirm("Are you sure you want to update\n" + table + " ID:" + rowData.id)) {
                if (form.$valid) {
                    $scope.loading = true;
                    $scope.updateResult = false;
                    referenceMappingData.updateData(table, rowData)
                    .$promise
                    .then(function (response) {
                        $scope.updateResult = true;
                        $scope.loading = false;
                        if (response.returnValue == 1) {
                            $scope.updateClass = 'alert-success';
                            $scope.updatePhrase = 'Update Successful!';
                        } else {
                            $log.log(response);
                            $scope.updateClass = 'alert-danger';
                            $scope.updatePhrase = 'Update Unsuccessful! Changes Not Committed.';
                        }
                    })
                    .catch(function (response) {
                        $log.log(response);
                        $scope.updateResult = true;
                        $scope.updateClass = 'alert-danger';
                        $scope.updatePhrase = 'Update Unsuccessful! Changes Not Committed.';
                    });
                }
            }
        };

    }
);