 CREATE DATABASE CRMDB
GO

USE CRMDB
GO

CREATE TABLE Customers
(
   Id INT IDENTITY(1,1) PRIMARY KEY,
   Name varchar(50) NOT NULL,
   LastName varchar(50) NOT NULL,
   Address varchar(255)
)
GO