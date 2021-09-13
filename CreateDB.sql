USE master
GO

IF (EXISTS (SELECT name FROM master.dbo.sysdatabases 
WHERE name = 'UddataPlusPlusMaria'))
BEGIN
    ALTER database UddataPlusPlusMaria set single_user with rollback immediate
    DROP database UddataPlusPlusMaria
END
GO

CREATE DATABASE UddataPlusPlusMaria
GO
USE UddataPlusPlusMaria
GO

--Create new table STUDENT
CREATE TABLE Student (
Id INT IDENTITY(1,1) PRIMARY KEY,
PersonName NVARCHAR(255),
Grade INT,
Warnings INT,
--Subjects NVARCHAR (255),
)

--Create new table TEACHER
CREATE TABLE Teacher(
Id INT IDENTITY(1,1) PRIMARY KEY,
PersonName NVARCHAR(255),
MemberOfTheCoffeeClub BIT,
)

SELECT * FROM Student
SELECT * FROM Teacher