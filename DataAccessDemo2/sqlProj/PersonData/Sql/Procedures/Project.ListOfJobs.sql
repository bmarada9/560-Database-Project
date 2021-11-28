CREATE OR ALTER PROCEDURE Project.ListOfJobs
	@DegreeName NVARCHAR(128)
AS

SELECT C.CompanyName, ((.MinmumSalary + J.MaxSalary)/2) as AverageSalary  J.JobType
from Project.Degree D 
right outer join Project.Job J on J.JobID = D.JobID
inner join Project.Company C on C.CompanyID = J.CompanyID
where D.DegreeName = @DegreeName