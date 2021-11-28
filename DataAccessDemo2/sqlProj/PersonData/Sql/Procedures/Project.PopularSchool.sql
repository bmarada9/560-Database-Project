CREATE OR ALTER PROCEDURE Project.PopularSchool
   @CompanyName NVARCHAR(128)
AS

select S.[Name], S.Mascot, 
IFF(S.TypeOfSchool = 0, N'Public', 'Private') as EstablishmentType
from Project.School S 
inner join Project.Person  P on P.SchoolID  = S.SchoolID --We change this after
inner join Project.Apply   A on A.PersonID  = P.PersonID
inner join Project.Job     J on J.JobID     = A.JobID
inner join Project.Company C on C.CompanyID = J.CompanyID

where C.CompanyName = @CompanyName;
go

