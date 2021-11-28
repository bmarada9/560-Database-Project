IF OBJECT_ID(N'Project.School') IS NULL

begin 
create table Project.School(
[Name] NVARCHAR(128) NOT NULL,
SchoolID int not null, 
[Size] int not null, 
City NVARCHAR(128) NOT NULL, 
State NVARCHAR(128) NOT NULL, 
GraduateRate int, 
Mascot NVARCHAR(128) NOT NULL, 
TypeOfSchool bit not null, 
YearlyAvgTuitionInState int not null, 
YearlyAvgTuitionOutState int not null
);
end 

