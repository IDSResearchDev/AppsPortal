//documentation-feature.js

(
function () {
    "use strict";

    angular.module("documentation-feature", ["ngRoute"])
        .config(function ($routeProvider) {
            $routeProvider.when("/", {
                controller: "documentFeatureController",
                //controllerAs: "vm",
                templateUrl: "/views/feature.html"
            });


            $routeProvider.when("/application/documentation", {
                controller: "documentFeatureController",
                //controllerAs: "vm",
                templateUrl: "/views/document.html"
            });


            $routeProvider.otherwise({ redirectTo: "/" });

        })
}());