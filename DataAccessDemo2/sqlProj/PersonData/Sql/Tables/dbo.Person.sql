IF OBJECT_ID(N'dbo.Person') IS NULL
BEGIN 
CREATE TABLE dbo.Person(
PersonID int not null primary key,
FirstName NVARCHAR(128) NOT NULL, 
LastName NVARCHAR(128) NOT NULL,
GPA Numeric(3,2) not null, 
Major NVARCHAR(128) NOT NULL,
Graduated Bit not null,
PhoneNumber int not null, 
Email NVARCHAR(128) NOT NULL,
SchoolID int not null foreign key 
	REFERENCES dbo.School(SchoolID),
ExpectedSalary int not null, 
Comments NVARCHAR(1024) NOT NULL
); 
end 