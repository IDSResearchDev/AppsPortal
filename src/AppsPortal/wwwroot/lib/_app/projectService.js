!function(){function t(t){function e(){return t.get("http://localhost:8000/json/sampleJson.json").then(function(t){return t.data})}return{getProjectDetails:e}}t.$inject=["$http"],angular.module("HomePreview").factory("projectService",t)}();