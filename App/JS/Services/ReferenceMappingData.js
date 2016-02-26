targetApp.factory('referenceMappingData', function ($http, $log, $resource) {

    var host = location.protocol + '//' + location.host;

    var resource = $resource(host + '/TargetMapperData/api/ReferenceMapping/:id', { id: '@id' });
    var putResource = $resource(host + '/TargetMapperData/api/ReferenceMapping/:id', { id: '@id' }, { 'update': {method:'PUT'}});

    return  {
        getData: function (table) {
            
            return resource.get({ id: table });
        },

        getDataHTTP: function(){

            return $http({
                method: 'GET',
                url: 'http://localhost:40611/TargetMapperData/api/ReferenceMapping/CompanyCode'
            });
        },

        updateData: function (table, rowData) {

                $log.log('updating..');
                $log.log(rowData);

                return putResource.update({ id: table }, rowData);
        }
    }
});