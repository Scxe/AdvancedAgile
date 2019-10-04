USE [master]

IF DB_ID(N'StudentDB') IS NOT NULL DROP DATABASE StudentDB;

CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

CREATE SCHEMA [TinyCollege] AUTHORIZATION [dbo];
GO

CREATE TABLE TinyCollege.studentDB(
    [studentId] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
	CONSTRAINT pk_studentDB PRIMARY KEY (studentId)
)
GO

CREATE TABLE TinyCollege.coursesDB(
    [courseId] [int] IDENTITY(1,1) NOT NULL,
    [Title] [nvarchar](50) NOT NULL,
    [Semester] [nvarchar](50) NOT NULL,
	CONSTRAINT pk_coursesDB PRIMARY KEY (courseId)
)
GO

CREATE TABLE TinyCollege.enrollmentDB(
    [studentName] [NVARCHAR](50) NOT NULL,
    [coursesTitle] [NVARCHAR](50) NOT NULL,
	[studentId] [int] NOT NULL,
	[courseId] [int] NOT NULL,
	CONSTRAINT pk_enrollmentDB PRIMARY KEY (studentId, courseId),
	CONSTRAINT fk_enrollmentDB_studentDB FOREIGN KEY (studentId) REFERENCES TinyCollege.studentDB(studentId),
	CONSTRAINT fk_enrollmentDB_coursesDB FOREIGN KEY (courseId) REFERENCES TinyCollege.coursesDB(courseId)
)
GO
