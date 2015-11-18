var http = require('http'),
 	express = require('express'),
 	path = require('path'),
 	cons = require('consolidate');

var app = express();

// Assign the swig engine to HTML files
app.engine('html', cons.swig);

// Set HTML as the default extension
app.set('view engine', 'html');

// Tells Express where we can find these HTMLs
app.set('views', __dirname + '/views');

app.set('port', process.env.PORT || 3000);

app.get('/squat/insert/:date&:time', function(req, res) {
	res.render('workoutinsert', {
		workoutdate: req.params.date,
		workouttime: req.params.time
	});
});

//app.use(express.static(path.join(__dirname, 'public')));

http.createServer(app).listen(app.get('port'), function() {
	console.log('Express server listening on port ' + app.get('port'));
})
