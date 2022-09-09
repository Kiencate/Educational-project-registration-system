var mysql = require('mysql');
require("dotenv/config");

var connection = mysql.createConnection({
    host: 'localhost',
    user: 'root', 
    password: '201120', 
    database: 'LTNC'
});

connection.connect((err, connection) => {
    if(err) console.log("Connect fail to database!");
})

module.exports = connection;