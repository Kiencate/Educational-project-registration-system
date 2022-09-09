'use strict';
const ProjectAsgns = require('../models/projectAsgns.model');

exports.createProject = (req, res) => {
    var projectInfo = req.body
    if (projectInfo) {
        ProjectAsgns.registerProj(projectInfo)
    }
}
exports.studentAssign = (req, res) => {
    var projectInfo = req.body
    if (projectInfo) {
        ProjectAsgns.studentAssign(projectInfo)
    }
}

exports.getStudentAssign = (req, res) => {
    var info = req.params
    if (info) {
        ProjectAsgns.getStudentProject(info,(result)=> {return res.json(result);})
    }
}


