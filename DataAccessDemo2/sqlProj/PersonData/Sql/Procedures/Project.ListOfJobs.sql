CREATE OR ALTER PROCEDURE dbo.ListOfJobs
	@DegreeName NVARCHAR(128)
AS

SELECT C.CompanyName, ((.MinimumSalary + J.MaxSalary)/2) as AverageSalary  J.JobType
from dbo.Degree D 
right outer join dbo.Job J on J.JobID = D.JobID
inner join dbo.Company C on C.CompanyID = J.CompanyID
where D.DegreeName = @DegreeName
GO