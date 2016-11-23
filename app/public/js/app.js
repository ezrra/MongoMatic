(function () {

	var app = angular.module('App', ['daterangepicker', 'ngAnimate']);

	app.controller('MainCtrl', function ($scope, $http, $q) {

		moment.locale('es');

		$scope.loader = false;

		$scope.currentData = [];

		$scope.data = [];

		$scope.daterangepickerMsg = true;

		$scope.daterangepicker = true;

		var days = [];
		/* {
			date: "2016-11-22",
			text: "Ayer",
			data: [{}]
		} */

		$scope.opts = {
	        locale: {
	            applyClass: 'btn-green',
	            applyLabel: "Aplicar",
	            fromLabel: "De",
	            format: "YYYY-MM-DD",
	            toLabel: "a",
	            cancelLabel: 'Cancelar',
	            customRangeLabel: 'Rango',
	            "monthNames": ["January","February","March","April","May","June","July","August","September","October","November","December"
		        ],
		        "daysOfWeek": ["Dom","Lun","Mar","Mic","Jue","Vie","Sab"],
	        },
	        ranges: {},
	    };

		

		function daysToArray (startDay, endDate) {

			var i = 0;
			var days = [];
			var date = moment(startDay).format("YYYY-MM-DD");
			var endDate = moment(endDate).format("YYYY-MM-DD");
			var startDay = moment(startDay).format("YYYY-MM-DD");
			
			while (date < endDate) {
				date = moment(startDay).add(i, 'day').format("YYYY-MM-DD");
				days.push(moment(date).format("YYYY-MM-DD"));
				i++;
			}

			return days;
		}

		var dates = [
			{ text: "Ayer", endDate: moment().subtract(1, 'days').format("2015-MM-DD 23:59:59"), startDate: moment().subtract(1, 'days').format("2015-MM-DD 00:00:00") },
			{ text: "Hace 7 dias", endDate: moment().subtract(1, 'days').format("2015-MM-DD 23:59:59"), startDate: moment().subtract(7, 'days').format("2015-MM-DD 00:00:00") },
			/*
			{ text: "Hace 14 dias", endDate: moment(), startDate: moment().subtract(13, 'days') },
			{ text: "Hace 30 dias", endDate: moment(), startDate: moment().subtract(29, 'days') }
			*/
		];

		function request (startDate, endDate, callback) {

			var dates = { startDate: startDate, endDate: endDate };

			var req = { method: 'GET', url: '/api/test', params: dates };

			$http(req).then(function (response) {

				callback(null, response)

			}, function (err) {

				callback(err, [])

			});
		};

		function allDays (date, callback) {

			var dates = { startDate: date, endDate: date };

			var req = { method: 'GET', url: '/api/test', params: dates };

			$http(req).then(function (response) {

				callback(null, response)

			}, function (err) {

				callback(err, [])

			});

		}

		var startDate 		= moment(dates[dates.length - 1].startDate);
		var endDate 		= moment(dates[0].endDate);
		var daysArray 		= daysToArray(startDate, endDate);

		var daysArrayLength = daysArray.length - 1;

		angular.forEach(daysArray, function (date, index) {

			request(date, date, function (err, response) {

				days.push({
					date: date,
					data: response.data,
				});

				if (index == daysArrayLength) {
					
					checkDates()

				}

			})

		})

		function checkDates () {


			angular.forEach(days, function (day, key) {

				// console.log(day)

				var amount = [];

				angular.forEach(dates, function (date, index) {

					if (moment(day.date).isBetween(date.startDate, date.endDate, null, '[]')) {
						// console.log(day.date)
						// console.log(date)

						amount.push(day.data)

						// dates[index].data.push(day.data)
					}

				})

				dates[key].data = amount;

				console.log('----------')
			})

			console.log(dates)

			// console.log(dates)

			/*angular.forEach(dates, function (date, index) {

				// console.log(date)

				// $scope.data.push(date);

				console.log(date)

				angular.forEach(days, function (day, key) {

					// console.log(day)
					

					if (!moment(day.date).isBetween(date.startDate, date.endDate, null, '[]')) {
						
					}
					
			// 		var startDate 	= moment(value1.startDate).format("2015-MM-DD"),
			// 			endDate 	= moment(value1.endDate).format("2015-MM-DD"),
			// 			date 		= moment(value.date).format("YYYY-MM-DD");

			// 			// console.log(value)
			// 		// console.log(startDate + " ** " + endDate + " --- " + date)

			// 		// console.log(moment(date).isBetween(startDate, endDate, null, '[]'))

			// 		if (!moment(date).isBetween(startDate, endDate, null, '[]')) {

			// 			// console.log(dates)
			// 		}

				})

			})*/
			
		}

		angular.forEach(dates, function (value, key) {
			
			/*var startDate 	= moment(value.startDate).format("2015-MM-DD"),
				endDate 	= moment(value.endDate).format("2015-MM-DD");*/

			// console.log(value)

			// var _days = daysArray(startDate, endDate);

			// console.log(_days)

			angular.forEach(days, function (date, index) {

				// console.log(date)

				// var index = _.findIndex(days, { 'date': date });

				// console.log(index)

				if (index > -1) {

					/*$scope.data.push({
						'text': value.text,
						'data': days[index].data,
						'startDate': startDate,
						'endDate': endDate
					});*/

				} else {

					/*request(date, date)
						.then(function (data) {

							days.push({
								date: date,
								data: data,
							});

							console.log(data)

							request()
						})*/

					

					// request(val, val, function (err, response) {

						/*days.push({
							date: val,
							data: response.data,
						});

						$scope.data.push({
							'text': value.text,
							'data': response.data,
							'startDate': startDate,
							'endDate': endDate
						}); */

						/* if (key == 0) {

							$scope.currentData = {
								'text': value.text,
								'data': response.data,
								'startDate': startDate,
								'endDate': endDate
							}

							pivotUI();
						}; */

						/* $scope.data.push({
							'text': value.text,
							'data': response.data,
							'startDate': startDate,
							'endDate': endDate
						}); */

						/*

						if (dates.length == $scope.data.length) {
							$scope.daterangepicker = true;
							$scope.daterangepickerMsg = false;
						} */

					// })
				}
				
			})
	
			// $scope.opts.ranges[value.text] = [startDate, endDate];

			// ================================

			/* request(startDate, endDate, function (err, response) {

				if (key == 0) {

					$scope.currentData = {
						'text': value.text,
						'data': response.data,
						'startDate': startDate,
						'endDate': endDate
					}

					pivotUI();
				};

				$scope.opts.ranges[value.text] = [startDate, endDate];

				$scope.data.push({
					'text': value.text,
					'data': response.data,
					'startDate': startDate,
					'endDate': endDate
				});

				if (dates.length == $scope.data.length) {
					$scope.daterangepicker = true;
					$scope.daterangepickerMsg = false;
				}

			}) */

		});

		$scope.$watch('data', function (newData, oldData) {
			
		}, true);

		function pivotUI () {
			$("#output").pivotUI(
			    $scope.currentData.data,
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

	    

	    $scope.$watch('date', function(date) {

	    	// console.log($scope.data)

	        var startDate 	= moment(date.startDate).format("YYYY-MM-DD");
	        var endDate 	= moment(date.endDate).format("YYYY-MM-DD");
	        var index 		= _.findKey($scope.data, { 'startDate': startDate, 'endDate': endDate });

	        $scope.currentData = [];

	        if ($scope.data.length > 0 && $scope.data[index]) {

	        	$scope.currentData = {
					'text': $scope.data[index].text,
					'data': $scope.data[index].data,
					'startDate': $scope.data[index].startDate,
					'endDate': $scope.data[index].endDate
				}

				// console.log($scope.data[index])

	        	// $scope.currentData = $scope.data[index];

	        	pivotUI();
	        }

	        // pivotUI();

	    }, false);


	});

})();