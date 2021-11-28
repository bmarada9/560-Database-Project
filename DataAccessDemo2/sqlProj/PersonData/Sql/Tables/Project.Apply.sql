IF OBJECT_ID(N'Project.Apply') IS NULL
BEGIN 
CREATE TABLE Project.Apply(
ApplyID int not identity(1,1) primary key  
JobID int not null foreign key 
	 REFERENCES Project.Job(JobID),
PersonID int not null foreign key 
	 REFERENCES Project.Person(PersonID),
DateApply DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()), 
GPA Numeric(3,2) not null,
Graduated Bit not null, 
); 
end 