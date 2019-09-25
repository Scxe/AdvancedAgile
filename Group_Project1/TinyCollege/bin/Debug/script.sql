USE [master]

IF DB_ID(N'StudentDB') IS NOT NULL DROP DATABASE StudentDB;

CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

CREATE SCHEMA [TinyCollege] AUTHORIZATION [dbo];
GO

CREATE TABLE TinyCollege.coursesDB(
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Title] [nvarchar](50) NOT NULL,
    [Semester] [nvarchar](50) NOT NULL,
)
GO

CREATE TABLE TinyCollege.enrollmentDB(
    [studentName] [NVARCHAR](50) NOT NULL,
    [coursesTitle] [NVARCHAR](50) NOT NULL,
)
GO

CREATE TABLE TinyCollege.studentDB(
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
)
GO
