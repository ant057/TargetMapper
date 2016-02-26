'use strict';

var targetApp = angular.module('targetApp', ['ngRoute', 'ngResource'])
         .config(function ($routeProvider) {

             $routeProvider.when('/ReferenceMapping',
                 {
                     templateUrl: 'ReferenceMap/ReferenceMapping.html',
                     controller: 'ReferenceMappingController'
                 })
         });
