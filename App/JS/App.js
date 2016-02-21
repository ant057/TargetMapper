'use strict';

var targetApp = angular.module('targetApp', ['ngRoute'])
         .config(function ($routeProvider) {

             $routeProvider.when('/ReferenceMapping',
                 {
                     templateUrl: 'ReferenceMap/ReferenceMapping.html',
                     controller: 'ReferenceMappingController'
                 })
         });