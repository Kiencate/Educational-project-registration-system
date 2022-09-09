'use strict';
const db = require('../conn/connect');
const Teachers = require('../models/teachers.model');

exports.getTeacher = (req, res) => {
    var id = req.params.id;
    Teachers.getById(id, (teacher)=>{
        return res.json(teacher);
    })
}

exports.getAll = (req, res) => { 
    db.query(`SELECT * FROM users WHERE role = 'teacher'`, (err, teacher) => {
        if(err){
            return null;
        }
        else {
            return res.json(teacher) ;  
        }
    })
}

exports.getTeacherbyProject = (req, res) => {
    var id = req.params.id;
    var teachers = [];
    db.query(`SELECT * FROM projectassignment WHERE projectId = ?`,id, (err, teacher) => {
        if(err){
            return null;
        }
        else {
            for(let i= 0; i < teacher.length; i++) {
                db.query(`SELECT * FROM teachers where ID=?`,teacher[i].teacherId,(err,teacherID) =>{
                    db.query(`SELECT * FROM users WHERE ID=?`,teacherID[0].userID, (err,teacherInfo) => {
                        teachers.push(teacherInfo[0]);
                        if (i == teacher.length-1) { 
                            return res.json(teachers) ;
                        }
                        
                    })
                    
                })
            }
              
        }
    })  
}
