(function() {

    angular.module("documentation-feature")
        .factory("project", project);

    function project($http) {

        function getProjectDetails() {
            return $http.get("http://localhost:8000/json/sampleJson.json")
                .then(function(response) {
                    return response.data;
            });
        }

        return { getProjectDetails: getProjectDetails };
    }

}());