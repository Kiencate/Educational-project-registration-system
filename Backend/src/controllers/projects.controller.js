'use strict';
const ProjectAsgns = require('../models/projectAsgns.model');
const Projects = require('../models/projects.model');
const Teacher = require('../models/teachers.model');
const db = require('../conn/connect');
// Projects.
exports.createProject = (req, res) => {
    var projectInfo = req.body;
    if (projectInfo) {
        ProjectAsgns.registerProj(projectInfo)
    }
}
exports.getProject = (req, res) => {
    var type = req.params.type;
    var id = req.params.id;
    var projects = [];
    ProjectAsgns.getIdProjectbyIdTeacher(id, (ProjectId) => {
        if (ProjectId.length == 0) return res.json(projects);
        for (let i = 0; i < ProjectId.length; i++) {
            Projects.getByTypeId({ 'type': type, "id": ProjectId[i].ID }, (project) => {
                // console.log(project[0]);
                projects.push(project[0]);
                if (i == ProjectId.length - 1) { return res.json(projects); }
            })
        }

    });
}

exports.getProjectbyIDteacher = (req, res) => {
    var type = req.params.type;
    var id = req.params.id;
    var projects = [];
    Teacher.getIdinTeacherTable(id, (TeacherID) => {
        ProjectAsgns.getIdProjectbyIdTeacher(TeacherID[0].ID, (ProjectId) => {
            if (ProjectId.length == 0) return res.json(projects);
            for (let i = 0; i < ProjectId.length; i++) {
                Projects.getByTypeId({ 'type': type, "id": ProjectId[i].ID }, (project) => {
                    // console.log(project[0]);
                    projects.push(project[0]);
                    if (i == ProjectId.length - 1) { return res.json(projects); }
                })
            }

        });
    }
    )
}

exports.getAll = (req, res) => { 
    db.query(`SELECT * FROM projects WHERE type = 'projectFinal'`, (err, projects) => {
        if(err){
            return null;
        }
        else {
            return res.json(projects) ;  
        }
    })
}


