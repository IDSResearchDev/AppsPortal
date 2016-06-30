(function () {

	angular.module("HomePreview", ["ngRoute"])
		.config(function ($routeProvider) {
			$routeProvider
              .when("/", {
              	controller: "projectHomePreviewController",
				templateUrl: "/views/projHomePreview.html"
              })
              
              .otherwise({ redirectTo: "/" });

		});

}());