// 透過fs模組去創建html
// fs 有讀檔案及寫檔案的功能
// fs.writeFile()
// fs.readFile()
//同步功能:sync  EX:fs.readFileSync()

// methodasync()  //step by step
fs.writeFile("hihi.html",
    "<html><body><h2>Hello!</h2></body></html>",
    function(error){
        if (error){
        console.log("Error");
        }else
        console.log("Done");
    }
);
console.log("finish");

// methodsync()   //two task same time
var fs = require("fs");
console.log("OK GOGO");
var fs = require("fs");
console.log("Starting...");
fs.writeFileSync("./world.html", 
  "<html><body><h1>Hello! World.</h1></body></html>");
console.log("已建立檔案.");


//read file
var fs = require("fs");
console.log("Starting...");
var data = fs.readFileSync("./world.html");
console.log("file content: " + data);


