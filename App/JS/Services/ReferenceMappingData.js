targetApp.factory('referenceMappingData', function ($http, $log) {

    return  {
        tableData: {
            "tableName": "Company Code",
            "data": [
                {
                    "id": 10001,
                    "sourceSystemCode": "24",
                    "sourceSystemDesc": "ARGONAUT MIDWEST INSURANCE COMPANY",
                    "targetSystemCode": "24",
                    "targetSystemDesc": "ARGONAUT MIDWEST INSURANCE COMPANY"
                },
                {
                    "id": 10002,
                    "sourceSystemCode": "23",
                    "sourceSystemDesc": "ARGONAUT INSURANCE COMPANY",
                    "targetSystemCode": "23",
                    "targetSystemDesc": "ARGONAUT INSURANCE COMPANY"
                },
                {
                    "id": 10003,
                    "sourceSystemCode": "01", 
                    "sourceSystemDesc": "COLONY INSURANCE COMPANY",
                    "targetSystemCode": "01",
                    "targetSystemDesc": "COLONY INSURANCE COMPANY"
                }
            ]
        },

        update: function (rowData) {
            $log.log(rowData);
            $log.log('this is updating..but what is??');
        }
    };
});