'use strict';
const Students = require('../models/students.model');
const db = require('../conn/connect');
exports.getStudent = (req, res) => {
    var id = req.params.id;
    Students.getById(id, (student) => {
        return res.json(student);
    })
}

exports.getStudentbyProject = (req, res) => {
    var id = req.params.id;
    var students = [];
    db.query(`SELECT * FROM studentprojasgn WHERE projectId = ?`, id, (err, student) => {
        if (err) {
            return null;
        }
        else {
            
            if (student.length == 0) { return res.json(null); }
            else {
                for (let i = 0; i < student.length; i++) {
                    db.query(`SELECT * FROM students where ID=?`, student[i].studentId, (err, studentID) => {
                        db.query(`SELECT * FROM users WHERE ID=?`, studentID[0].userID, (err, studentInfo) => {
                            students.push(studentInfo[0]);
                            if (i == student.length - 1) {
                                return res.json(students);
                            }

                        })

                    })
                }
            }
        }
    })
}
