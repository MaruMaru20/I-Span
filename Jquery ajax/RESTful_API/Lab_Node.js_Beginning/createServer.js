// var http = require("http");
// console.log("GO..");
// var host = "127.0.0.1";
// var port = 80;
// var sever = http.createServer((request, response) => {
//   console.log("Got a request: " + request.url);
//   response.writeHead(200, { "Content-type": "text/plain" });
//   response.end("Hello! I'm a Node.JS server.");
// });
// sever.listen(port, host, () => {
//   console.log("Ready");
// });

// var express = require("express");
// var webSever = express();
// webSever.use(express.static("./public"));
// webSever.listen(3000);

// webSever.get("/hihi/:who", (req, res) => {
//   res.send("hi!" + req.params.who);
// });
