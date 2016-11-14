(function () {

	var app = angular.module('App', []);

	app.controller('MainCtrl', function ($scope, $http) {

		$scope.loader = true;

		$http
			.get('/api/test')
			.success(function (data) {

				$scope.data = data;

				if (!$scope.data) {
					
					alert("No hay datos para mostrar")
				
				} else {

					pivotUI();
				}

				$scope.loader = false;

			});

		function pivotUI () {

			$("#output").pivotUI(
			    $scope.data,
			    {
			        rows: ["DatabaseSource"],
			        cols: ["grupo01"],
			    }, false, "es"
			);
		}

	});

})();