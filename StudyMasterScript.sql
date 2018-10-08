CREATE DATABASE WEB
GO

USE WEB
GO

CREATE TABLE USER(
	userid int IDENTITY(1,1) NOT NULL,
	username varchar(50) NULL,
	password varchar(50) NULL,
	fullname nvarchar(50) NULL,
	gender char(1) NOT NULL,
	phonenumber varchar(50) NULL,
	email varchar(50) NULL,
	address nvarchar(50) NULL,
	userrole char(10) NULL,
	balance int NULL,
	last_login datetime NULL,
 	CONSTRAINT PK_USER PRIMARY KEY (userid ASC)
)
GO

ALTER TABLE USER ADD CONSTRAINT DF_USER_last_login DEFAULT (getdate()) FOR last_login
GO

ALTER TABLE USER ADD CONSTRAINT DF_USER_balance DEFAULT (0) FOR balance
GO

