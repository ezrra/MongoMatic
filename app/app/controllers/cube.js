var express = require('express'),
	router = express.Router();

var db = require('../db');

router.get('/test', function (req, res) {

	// res.json({ test: 'test' });
	var collection = db.get().collection('seisMeses');
	// .sort({ fecha: 1 })
	collection.find({}, { "_id":0 }).toArray(function (err, docs) {

		if (err) {

			console.log('ERROR!!!')

			res.json([])
		}

		res.json(docs);
	})
});

module.exports = router;