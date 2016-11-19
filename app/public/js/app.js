(function () {

	var app = angular.module('App', ['daterangepicker']);

	app.controller('MainCtrl', function ($scope, $http) {

		$scope.loader = false;

		$scope.daterangepicker = true;

		$scope.currentData = [];

		$scope.data = [];

		function requests (startDate, endDate, callback) {

			var dates = { startDate: startDate, endDate: endDate };

			var req = { method: 'GET', url: '/api/test', params: dates };

			$http(req).then(function (response) {

				callback(null, response)

			}, function (err) {

				callback(err, [])

			});
		};

		var dates = [
			{ text: "Ayer", endDate: moment(), startDate: moment().subtract(1, 'days') },
			{ text: "Hace 7 dias", endDate: moment(), startDate: moment().subtract(6, 'days') },
			{ text: "Hace 14 dias", endDate: moment(), startDate: moment().subtract(13, 'days') },
			{ text: "Hace 30 dias", endDate: moment(), startDate: moment().subtract(29, 'days') }
		];

		angular.forEach(dates, function (value, key) {
			
			var startDate 	= moment(value.startDate).format("2015-MM-DD"),
				endDate 	= moment(value.endDate).format("2015-MM-DD");

			requests(startDate, endDate, function (err, response) {

				if (key == 0) {  $scope.currentData = response.data; pivotUI(); };

				$scope.opts.ranges[value.text] = [startDate, endDate];

				$scope.data.push({
					'text': value.text,
					'data': response.data,
					'startDate': startDate,
					'endDate': endDate
				})

			})

		});

		$scope.$watch('data', function (newData, oldData) {
			
			console.log(newData)

		}, true);

		function pivotUI () {
			$("#output").pivotUI(
			    $scope.currentData,
			    {
			        rows: ["DatabaseSource"],
			        cols: [""],
			    }, false, "es"
			);
		}

		$scope.date = {
	        startDate: moment().subtract(1, "days"),
	        endDate: moment()
	    };

	    $scope.opts = {
	        locale: {
	            applyClass: 'btn-green',
	            applyLabel: "Aplicar",
	            fromLabel: "De",
	            format: "YYYY-MM-DD",
	            toLabel: "a",
	            cancelLabel: 'Cancelar',
	            customRangeLabel: 'Rango',
	            "monthNames": [
		            "January",
		            "February",
		            "March",
		            "April",
		            "May",
		            "June",
		            "July",
		            "August",
		            "September",
		            "October",
		            "November",
		            "December"
		        ],
		        "daysOfWeek": [
		            "Dom",
		            "Lun",
		            "Mar",
		            "Mic",
		            "Jue",
		            "Vie",
		            "Sab"
		        ],
	        },
	        ranges: {},
	    };

	    $scope.$watch('date', function(date) {

	        var startDate 	= moment(date.startDate).format("YYYY-MM-DD");
	        var endDate 	= moment(date.endDate).format("YYYY-MM-DD");
	        var index 		= _.findKey($scope.data, { 'startDate': startDate, 'endDate': endDate });

	        $scope.currentData = [];

	        if ($scope.data.length > 0) {

	        	$scope.currentData = $scope.data[index].data;
	        }

	        // pivotUI();

	    }, false);


	});

})();