// 以 Express 建立 Web 伺服器
var express = require("express");
var app = express();

// 以 body-parser 模組協助 Express 解析表單與JSON資料
var bodyParser = require('body-parser');
app.use( express.json() );
app.use( express.urlencoded({extended: false}) );

// Web 伺服器的靜態檔案置於 public 資料夾
app.use( express.static( "public" ) );

// 以 express-session 管理狀態資訊
var session = require('express-session');
app.use(session({
    secret: 'secretKey',
    resave: false,
    saveUninitialized: true
}));

// 指定 esj 為 Express 的畫面處理引擎
app.set('view engine', 'ejs');
app.engine('html', require('ejs').renderFile);
app.set('views', __dirname + '/view');

// 一切就緒，開始接受用戶端連線
app.listen(80);
console.log("Web伺服器就緒，開始接受用戶端連線.");
console.log("「Ctrl + C」可結束伺服器程式.");

var sql = require('mssql');

// 準備連線參數
var config = {
    user:'class',
    password:'8877',
    server:'127.0.0.1\\SQLEXPRESS',
    port:1433,
    database:'newsDb',
    options: {
        encrypt: false,
        trustServerCertificate: true
    }
};
 
//connect to your database
sql.connect(config, 
    function (err) {
        console.log(err);
    }
)

app.get("/home/news", async function (request, response) {
	var x = await sql.connect(config);
	const result = await sql.query("select * from news");
	response.send(JSON.stringify(result.recordset));
})





app.post("/home/news", async function (request, response) {
	var x = await sql.connect(config);
	var commandText = `insert into news (title, ymd) values (
		'${request.body.title}', 
		'${request.body.ymd}'
		)`;
	const result = await sql.query(commandText);
	response.send("Row Inserted"); 
})