'use strict';
const db = require('../conn/connect');
const mysql = require('mysql');

const Projects = function(project){
    this.name = project.name;
    this.type = project.type;
}

Projects.createProject = (newProject, result) => {
    db.query(`INSERT INTO projects SET ?`, newProject, (err, res) => {
        if(err) return;
        else{
            result(res.insertId);
        }
    })
}

Projects.deleteProjectTeacher = (idProject,result) => {
    for(let i = 0; i < idProject.length; i++) {
        db.query("delete from projectassignment where projectId = ?" , idProject[i].projectId , (err, res) => {})
        db.query("delete from studentprojasgn where projectId = ?" , idProject[i].projectId , (err, res) => {})
        db.query("delete from projects where ID = ?" , idProject[i].projectId , (err, res) => {})
        
    }

}
Projects.deleteProjectStudent = (idProject,result) => {
    for(let i = 0; i < idProject.length; i++) {
        db.query("delete from studentprojasgn where projectId = ?" , idProject[i].projectId , (err, res) => {})
    }

}

Projects.getByTypeId = function({"type":type,"id":id}, result){
    db.query(`SELECT * FROM projects WHERE type=${mysql.escape(type)} and id=${mysql.escape(id)}`, function(err, Projects){
        if(err){
            result(null);
            console.log("err");
        }
        else {
            result(Projects);
        }
    })
}








module.exports = Projects