CREATE OR ALTER PROCEDURE Project.NumberOfJobs
   @CompanyName NVARCHAR(128)
AS

SELECT J.JobName, J.JobType, J.AppDueDate, A.Major as Major Accepted
FROM Project.Company C 
inner join Project.Job    J on J.CompanyID = C.CompanyID
inner join Project.Apply  A on A.JobID  = J.JobID
inner join Project.Person P on P.PersonID = A.PersonID 
WHERE C.CompanyName = @CompanyName;
GO
