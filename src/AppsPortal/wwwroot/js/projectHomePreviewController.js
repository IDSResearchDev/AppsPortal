(function () {

	angular.module("HomePreview")
		.controller("projectHomePreviewController", projectHomePreviewController);

	function projectHomePreviewController($scope, projectService) {


		function onProject(data) {
			$scope.ProjectDetails = data;
		}

		function onError(reason) {
			$scope.Error = reason;
		}

		projectService.getProjectDetails().then(onProject, onError);

	}


}());