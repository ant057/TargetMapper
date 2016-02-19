'use strict';

var targetApp = angular.module('targetApp', ['ngRoute'])
         .config(function ($routeProvider) {

             $routeProvider.when('/UpdateReferenceMapping',
                 {
                     templateUrl: 'ReferenceMap/UpdateReferenceMapping.html',
                     controller: 'ReferenceMappingController'
                 })
         });