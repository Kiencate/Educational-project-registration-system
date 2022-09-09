'use strict';
const express = require('express');
const router = express.Router();
const studentControler = require('../controllers/students.controller');

router.get('/:id', studentControler.getStudent);
router.get('/getStudentbyProject/:id', studentControler.getStudentbyProject);
module.exports = router;