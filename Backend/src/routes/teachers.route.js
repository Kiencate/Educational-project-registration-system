'use strict';
const express = require('express');
const router = express.Router();
const teacherControler = require('../controllers/teachers.controller');

router.get('/get/:id', teacherControler.getTeacher);
router.get('/getAll',teacherControler.getAll);
router.get('/getTeacherbyProject/:id',teacherControler.getTeacherbyProject);
module.exports = router;