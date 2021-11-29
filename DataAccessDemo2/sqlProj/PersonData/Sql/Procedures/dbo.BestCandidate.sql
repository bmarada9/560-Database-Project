CREATE OR ALTER PROCEDURE dbo.BestCandidate
	@CompanyName NVARCHAR(128)
AS

select J.Name as JobTitle, 
P.FirstName as FirstName ,
P.LastName as LastName, 
D.Major, 
Dense_Rank() over (PARTITION by P.GPA order by P.LastName) as GPA 
from dbo.Job J 
inner join dbo.Degree D on D.JobID = J.JobID
inner join dbo.Apply A on A.JobID = J.JobID
inner join dbo.Person P on P.PersonID = A.PersonID
inner join dbo.Company C on C.CompanyID = J.CompanyID
where C.[Name] = @CompanyName and P.Major = D.Major
go