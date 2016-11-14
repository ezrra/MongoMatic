var express = require('express'),
	router = express.Router();


var db = require('../db');

router.get('/test', function (req, res) {

	// res.json({ test: 'test' });

	var collection = db.get().collection('unDia');
	// .sort({ fecha: 1 })
	collection.find({}, { "_id":0 }).toArray(function (err, docs) {

		res.json(docs);
	})
});

module.exports = router;