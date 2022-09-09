'use strict';
const db = require('../conn/connect');
const mysql = require('mysql');

const Teachers = function (teacher) {
    this.id = teacher.id;
    this.labroom = teacher.labroom;
}

Teachers.getById = (id, result) => {
    db.query(`SELECT * FROM teachers WHERE userID=${mysql.escape(id)}`, (err, teacher) => {
        if (err) {
            result(null);
        }
        else if (teacher.length == 0) { result(null); }
        else {

            db.query(`SELECT * FROM users WHERE ID=${mysql.escape(teacher[0].userID)}`, (err, infoTeacher) => {
                if (err) console.log(err)
                else {
                    infoTeacher[0]['labroom'] = teacher[0].labRoom;
                    delete infoTeacher[0]['password'];
                    result(infoTeacher);
                }
            })
        }
    })
}

Teachers.getIdinTeacherTable = (userID, result) => {
    db.query(`SELECT * FROM teachers WHERE userID=${mysql.escape(userID)}`, (err, id) => {
        if (err) {
            result(null);
        }
        else {
            result(id);
        }
    })

}

module.exports = Teachers;