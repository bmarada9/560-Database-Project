IF OBJECT_ID(N'dbo.Company') IS NULL

begin
CREATE TABLE dbo.Company (
[Name] NVARCHAR(128) NOT NULL,
CompanyID INT NOT NULL primary key, 
Size int not null,
State NVARCHAR(128) NOT NULL,
Country NVARCHAR(128) NOT NULL,
CeoFirstName NVARCHAR(128) NOT NULL,
CeoLastName NVARCHAR(128) NOT NULL,
YearEstablished int not null, 
NetWorth int not null,
url NVARCHAR(128) NOT NULL
);
end 
 