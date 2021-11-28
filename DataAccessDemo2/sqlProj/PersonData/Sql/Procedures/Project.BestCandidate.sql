CREATE OR ALTER PROCEDURE Project.BestCandidate
	@CompanyName NVARCHAR(128)
AS

select J.Name as Job Title, 
P.FirstName as [First] Name ,
P.LadtName as [Last] Name, 
D.Major, 
Dense_Rank() over (PARTITION by P.GPA order by P.LastName and P.FirstName) as GPA 
from Project.Job J 
inner join Project.Degree D on D.JobID = J.JobID
inner join Project.Apply  A on A.JobID = J.JobID
inner join Project.Person P on P.PersonID = A.PersonID
where CompanyName = @CompanyName and P.Major = D.Major
go