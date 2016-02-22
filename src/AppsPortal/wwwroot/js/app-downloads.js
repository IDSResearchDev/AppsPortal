// app-downloads.js

(function () {

    "use strict";

    angular.module("app-downloads", ["simpleControls", "ngRoute"])
           .config(function ($routeProvider) {

               $routeProvider.when("/", {
                   controller: "downloadController",
                   controllerAs: "vm",
                   templateUrl: "/views/downloadView.html"
               });

               $routeProvider.otherwise({ redirectTo: "/" });
           });
})();