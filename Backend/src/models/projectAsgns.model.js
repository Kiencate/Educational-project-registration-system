'use strict';
const db = require('../conn/connect');
const mysql = require('mysql');
const Projects = require('../models/projects.model');

const ProjectAsgns = function (projectAsgn) {
    this.teacherId = projectAsgn.teacherId;
    this.projectId = projectAsgn.projectId;
}

ProjectAsgns.registerProj = (projectInfo, result) => {
    projectInfo.forEach(element => {
        db.query(`SELECT id FROM teachers WHERE userID=${mysql.escape(element["ID"])}`, (err, idTeacher) => {
            if (err) return;
            else {
                db.query(`SELECT projectId FROM projectassignment WHERE teacherId=?`, idTeacher[0].id, (err, ProjectId) => {
                    if (err) return;
                    else {
                        Projects.deleteProjectTeacher(ProjectId);
                        Projects.createProject({ "name": element.name, "type": element.type, "numStudent": element.numStudent }, (idProj) => {
                            db.query(`INSERT INTO projectassignment SET ?`, {
                                "teacherId": idTeacher[0].id,
                                "projectId": idProj
                            }, (err, res) => {
                                if (err) console.log("Insert to project assign fail!");
                                else {
                                    return
                                }
                            })
                        })
                    }
                })

            }
        })
    });
}

ProjectAsgns.getIdProjectbyIdTeacher = (TeacherId, result) => {
    db.query(`SELECT * FROM projectassignment WHERE teacherID=${mysql.escape(TeacherId)}`, function (err, ProjectIds) {
        if (err) {
            result(null);
        }
        else {
            result(ProjectIds);
        }
    })
}

ProjectAsgns.studentAssign = (projectInfo, result) => {
    projectInfo.forEach(element => {
        db.query(`SELECT id FROM students WHERE userID=${mysql.escape(element.IDstudent)}`, (err, idStudent) => {
            if (err) return;
            else {
                db.query(`delete FROM studentprojasgn WHERE studentId=?`, idStudent[0].id, (err, res) => {
                    db.query("insert into studentprojasgn SET?", { "studentId": idStudent[0].id, "projectId": element.IDproject }, (err, student) => { return })
                })

            }
        })
    });
}

ProjectAsgns.getStudentProject = (info, result) => {
    var projects = []
    db.query(`SELECT * FROM students WHERE userID =${mysql.escape(info.id)}`, (err, IDstudent) => {
        db.query("SELECT * FROM studentprojasgn WHERE studentId=?", IDstudent[0].ID, (err, IDproject) => {
            for (let i = 0; i < IDproject.length; i++) {
                db.query(`SELECT * FROM projects WHERE ID = ${mysql.escape(IDproject[i].projectId)} and type = ${mysql.escape(info.type)}`, (err, projectID) => {
                    db.query("SELECT * FROM projectassignment where projectId =?", projectID[0].ID, (err, project) => {
                        projects.push(project[0]);
                        if (i == IDproject.length - 1) result(projects);
                    })
                })
            }
        })

    })

}


module.exports = ProjectAsgns