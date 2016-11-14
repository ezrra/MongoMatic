var express = require('express'),
	router 	= express.Router(),
	config	= require('../../config');

var db = require('../db');

router.get('/test', function (req, res) {

	var collection = db.get().collection(config.collection);

	collection.find({}, { "_id":0 }).toArray(function (err, docs) {

		if (err) {

			res.json([])
		}

		res.json(docs);
	})
});

module.exports = router;