'use strict';
const express = require('express');
const router = express.Router();
const projectAsgnsController = require('../controllers/projectAsgns.controller');
const projectController = require('../controllers/projects.controller');

router.post('/createProject', projectAsgnsController.createProject);
router.get('/:type/:id', projectController.getProject);
router.get('/byid/:type/:id', projectController.getProjectbyIDteacher);
router.get('/byidStudent/:type/:id', projectAsgnsController.getStudentAssign);

router.post('/student', projectAsgnsController.studentAssign);
router.get('/getAll', projectController.getAll);

module.exports = router;