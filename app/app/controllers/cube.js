var express = require('express'),
	router 	= express.Router(),
	config	= require('../../config');

var db = require('../db');

router.get('/range', function (req, res) {

	var collection = db.get().collection(config.collection);

	var startDate 	= new Date(req.query.startDate + "T00:00:00");
	var endDate 	= new Date(req.query.endDate + "T23:59:59"); 

	var cursor = collection.aggregate([ { $match: { fecha: { $gte: startDate, $lt: endDate } } } ], { allowDiskUse: true, cursor: { batchSize: 100000 } }).toArray(function (err, docs) {
		res.json(docs);
	});

	/* collection.aggregate([ { $match: {} } ], { "_id":0 }, { allowDiskUse: true }).toArray(function (err, docs) {
		// { $match: { fecha: { $gte: new Date("2015-01-01"), $lte: new Date("2015-01-31") } } }
		res.json(docs);
	}) */
});

module.exports = router;