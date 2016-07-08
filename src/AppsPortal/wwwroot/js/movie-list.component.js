(function() {
    "use strict";

    var module = angular.module("documentation-feature");

    function fetchProjects($http) {
        return $http.get("http://localhost:8000/json/sampleJson.json")
            .then(function (response) {
                return response.data
            });
    }

    function controller($http){
        var model = this;
        model.projects = [];

        model.$onInit = function () {
            fetchProjects($http).then(function(projects) {
                model.projects = projects;
            });
        };
    }

    module.component("movieList", {
        //template: "<div> <h1>{{model.message}}</h1> <input type="+ "text" +" ng-model="+"model.message"+"> <button ng-click="+"model.changeMessage()"+"> Change Message</button>"+
        //    " </div>",

        templateUrl: "/views/movie-list.component.html",

        controllerAs: "model",
        controller: ["$http", controller]
        
    });

}());