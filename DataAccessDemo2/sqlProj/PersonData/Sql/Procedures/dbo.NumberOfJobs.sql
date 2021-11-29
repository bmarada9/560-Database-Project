CREATE OR ALTER PROCEDURE dbo.NumberOfJobs
   @CompanyName NVARCHAR(128)
AS

SELECT J.JobName, J.JobType, J.AppDueDate, A.Major as MajorAccepted
FROM dbo.Company C 
inner join dbo.Job    J on J.CompanyID = C.CompanyID
inner join dbo.Apply  A on A.JobID  = J.JobID
inner join dbo.Person P on P.PersonID = A.PersonID 
WHERE C.[Name] = @CompanyName;
GO
