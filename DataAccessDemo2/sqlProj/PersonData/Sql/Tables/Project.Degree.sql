IF OBJECT_ID(N'dbo.Degree') IS NULL
BEGIN 
CREATE table dbo.Degree(
DegreeID INT NOT NULL primary key,
Major NVARCHAR(128) NOT NULL,
JobID int  foreign key 
	REFERENCES dbo.Job(JobID)
);
end
