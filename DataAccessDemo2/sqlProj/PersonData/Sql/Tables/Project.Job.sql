IF OBJECT_ID(N'Project.Job') IS NULL
BEGIN 
CREATE TABLE Project.Job(
[Name] NVARCHAR(128) NOT NULL,
MinmumSalary int not null,
CompanyID int not null FOREIGN KEY
      REFERENCES Project.Company(CompanyID),
JobID int not null primary key, 
GPA Numeric(3,2) not null,
SupervisorLastName NVARCHAR(128) NOT NULL, 
JobType NVARCHAR(128) NOT NULL,
AppDueDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
MaxSalary int not null
); 
end 