var express = require('express'),
	router 	= express.Router(),
	config	= require('../../config');

var db = require('../db');

router.get('/range', function (req, res) {

	/**
	 * DEBUG: http://localhost:3000/api/range?startDate=2015-12-30&endDate=2015-12-30
	 */

	var dataCollection 		= db.get().collection(config.dataCollection);
	var groupsCollection 	= db.get().collection(config.groupsCollection);

	var startDate 			= new Date(req.query.startDate + "T00:00:00");
	var endDate 			= new Date(req.query.endDate + "T23:59:59");

	var projection 			= { "_id": 0  };

	groupsCollection.find({}, { _id: 0}, function (err, groupsData) {

		groupsData.toArray(function (err, groups) {

			for (var key in groups) {
				var obj = groups[key];
				for (var prop in obj) {
					projection[obj[prop]] = "$" + prop;
				}
			}

			dataCollection.aggregate([
					{ $match: { fecha: { $gte: startDate, $lt: endDate } } }, 
					{ $project: projection } 
				], 	{ allowDiskUse: true, cursor: { batchSize: 100000 } }).toArray(function (err, data) {

				res.json(data);
			});

		});
		
	});

});

module.exports = router;