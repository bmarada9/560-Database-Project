CREATE OR ALTER PROCEDURE dbo.PopularSchool
   @CompanyName NVARCHAR(128)
AS

select S.[Name], S.Mascot, 
IIF(S.TypeOfSchool = 0, N'Public', N'Private') as EstablishmentType
from dbo.School S 
inner join dbo.Person  P on P.SchoolID  = S.SchoolID 
inner join dbo.Apply   A on A.PersonID  = P.PersonID
inner join dbo.Job     J on J.JobID     = A.JobID
inner join dbo.Company C on C.CompanyID = J.CompanyID

where C.[Name] = @CompanyName;
go

