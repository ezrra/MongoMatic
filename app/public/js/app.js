(function () {

	var app = angular.module('App', []);

	app.controller('MainCtrl', function ($scope, $http) {

		$scope.loader = true;

		var dates = {
			startDate: '2016-01-01',
			endDate: '2016-01-31'
		};

		var req = {
			method: 'GET',
		 	url: '/api/test',
		 	params: dates
		}

		$http(req).then(function (response) {

			$scope.data = response.data;

			console.log(response)

			if ($scope.data.length == 0) {
				
				alert("No hay datos para mostrar")
			
			} else {

				pivotUI();
			}

			$scope.loader = false;

		}, function (err) {

			console.log(err);

		});

		function pivotUI () {

			$("#output").pivotUI(
			    $scope.data,
			    {
			        rows: ["DatabaseSource"],
			        cols: [""],
			    }, false, "es"
			);
		}

	});

})();