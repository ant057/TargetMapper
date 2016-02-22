targetApp.factory('referenceMappingData', function ($http, $log, $resource) {

    var resource = $resource('http://localhost:51872/ReferenceMapping/:id', { id: '@id' });

    return  {
        getData: function () {
            //return $http({
            //    method: 'GET',
            //    url: 'http://localhost:62284/event/1'
            //});

            return resource.get({ id: 1 });
        },

        update: function (rowData) {
            $log.log(rowData);
            $log.log('this is updating..but what is??');
        }
    };
});