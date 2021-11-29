IF OBJECT_ID(N'dbo.Apply') IS NULL
BEGIN 
CREATE TABLE dbo.Apply(
ApplyID int not null identity(1,1) primary key,  
JobID int not null foreign key 
	 REFERENCES dbo.Job(JobID),
PersonID int not null foreign key 
	 REFERENCES dbo.Person(PersonID),
DateApply DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()), 
GPA Numeric(3,2) not null,
Graduated Bit not null, 
); 
end 