//documentFeatureController


(function () {

    //"use strict";

    angular.module("documentation-feature")
           .controller("documentFeatureController", documentFeatureController);

    function documentFeatureController($scope, project) {
        //var vm = this;
        //vm.errorMessage = "";

        $scope.sampledata = "wo0o0o0opppp.";

        function onProject(data){
            $scope.ProjectDetails = data;
        }

        function onError(reason){
            $scope.Error = reason;
        }

        project.getProjectDetails().then(onProject, onError);

    }

}());