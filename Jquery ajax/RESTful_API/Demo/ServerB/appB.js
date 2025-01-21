var express = require("express");
var app = express();
app.listen(5000);

// npm install cors  SOP 跨域
var cors = require("cors"); 
app.use(cors());  // access-control-allow-origin: *

app.get("/getData", function (req, res) {
    // res.set("access-control-allow-origin","*");
    res.send(' {"id": 3, "qty": 200 } ')
})
