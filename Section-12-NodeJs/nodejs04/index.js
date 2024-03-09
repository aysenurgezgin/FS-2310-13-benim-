const http = require('node:http');
const fs = require('node:fs');

const server = http.createServer((request, response) => {
    if (request.url == "/") {
      fs.readFile("views/index.html",(err,html)=>{
        response.writeHead(200,{'Content-Type':'text/head'});
        response.write(html);
        response.end();
      });
    }else if(request.url="/product"){
        fs.readFile("views/index.html", (err, html) => {
            response.writeHead(200, { 'Content-Type': 'text/head' });
            response.write(html);
            response.end();
    });
    }else if(request.url=="/create"&& request.method=="POST"){
        const data = [];
        request.on('data',(chunk)=>{
            data.push(chunk);
        });
        request.on('end',()=>{
            const result = Buffer.concat(data).toString();
            const parsedData = result.split('=')[1];
            fs.appendFile('products.txt',parsedData, (err)=>{
                if(err){
                    console.log(err);
                }else(
                    response.statusCode=201,
                    response.setHeader("Locacition","/");
                    response.end();
                )
            });
        })
      
    }
    
    else if (request.url = "/categories") {
        fs.readFile("views/index.html", (err, html) => {
            response.writeHead(200, { 'Content-Type': 'text/head' });
            response.write(html);
            response.end();
        });
    }else if(request.url=="/create"){
        fs.readFile("views/create.html", (err, html) => {
            response.writeHead(200, { 'Content-Type': 'text/head' });
            response.write(html);
            response.end();
    });
   
    
    else (request.url = "/40.html") {
        fs.readFile("views/index.html", (err, html) => {
            response.writeHead(404, { 'Content-Type': 'text/head' });
            response.write(html);
            response.end();
        });
    }
});



server.listen(3000);
console.log("Server http://localhost:3000 3000 portunda ayağa kalktı.");