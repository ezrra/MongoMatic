(function () {

	var app = angular.module('App', []);

	app.controller('MainCtrl', function ($scope, $http) {

		$scope.loader = true;

		var renderers = $.extend($.pivotUtilities.renderers, $.pivotUtilities.gchart_renderers, $.pivotUtilities.d3_renderers);

		$http.get('/api/test')
			.success(function (data) {

				$scope.data = data;

				pivotUI();

				$scope.loader = false;

			});

		function pivotUI () {

			$("#output").pivotUI(
			    $scope.data,
			    {
			    	// renderers: renderers,
			        rows: ["grupo01", "grupo03"],
			        cols: ["grupo02"],
			        // rendererName: "Table"
			    }, false, "es"
			);

			// $('table').addClass('table table-striped');
		}

	});

	// angular.

})();