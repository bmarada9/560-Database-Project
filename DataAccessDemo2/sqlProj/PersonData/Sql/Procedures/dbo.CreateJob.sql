CREATE OR ALTER PROCEDURE dbo.CreateJob
	@JobName NVARCHAR(128),
	@MinmumSalary int,
	@CompanyName NVARCHAR(128),
	@SupervisorLastName NVARCHAR(128),
	@JobType NVARCHAR(128),
	@AppDueDate DATETIMEOFFSET,
	@DegreeMajorAccepted 
	as 
	
IF Not Exists 
(
	INSERT dbo.Job([Name],MinmumSalary,SupervisorLastName,JobType,AppDueDate)
	values(@JobName,@MinmumSalary,@SupervisorLastName,@JobType,@AppDueDate);
	Insert dbo.Company([Name])
	values(@CompanyName);
	Insert dbo.Degree(Major)
	values(@DegreeMajorAccepted)
)
	