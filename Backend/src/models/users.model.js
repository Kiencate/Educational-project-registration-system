'use strict';
const db = require('../conn/connect');
const mysql = require('mysql');

const Users = function(user){
    this.id = role.id;
    this.name = role.name;
    this.class = role.class;
    this.address = role.address;
    this.phone = role.phone;
    this.email = role.email;
    this.password = role.password;
    this.role = user.role;
}

Users.login = (loginInfo, result) => {
    db.query(`SELECT * FROM users where ID=${mysql.escape(loginInfo.username)} and password=${mysql.escape(loginInfo.password)} and role=${mysql.escape(loginInfo.role)}`, (err, user)=>{
        if(err || user.length == 0){
            return result({
                "checking": "false",
                "id": ""
            })
        }
        else{
            result({
                "checking": "true",
                "id": user[0].ID
            })
        }
    })
}

module.exports = Users;