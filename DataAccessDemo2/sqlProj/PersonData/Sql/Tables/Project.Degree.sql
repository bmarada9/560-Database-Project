IF OBJECT_ID(N'Project.Degree') IS NULL
BEGIN 
CREATE table Project.Degree(
DegreeID INT NOT NULL primary key,
Major NVARCHAR(128) NOT NULL,
JobID int  foreign key 
	REFERENCES Project.Job(JobID)
);
end
