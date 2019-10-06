SELECT * FROM TinyCollege.studentDB;

SELECT * FROM TinyCollege.coursesDB;

SELECT * FROM TinyCollege.enrollmentDB;

/* INSERT INTO TinyCollege.enrollmentDB(studentName, coursesTitle, studentId, courseId) SELECT Name, Title, studentId, courseId FROM TinyCollege.studentDB, TinyCollege.coursesDB WHERE studentDB.studentId = (SELECT studentId FROM TinyCollege.studentDB WHERE Name = 'Fake Student') AND coursesDB.courseId = 2; */
