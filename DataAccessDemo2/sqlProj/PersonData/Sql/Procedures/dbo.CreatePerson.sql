CREATE OR ALTER PROCEDURE dbo.CreatePerson
	@FirstName NVARCHAR(128),
	@LastName int,
	@Major NVARCHAR(128),
	@GPA Numeric(3,2)
	@Graduated bit,
	@PhoneNumber VARCHAR(1024), 
	@Email NVARCHAR(128),
	@SchoolName NVARCHAR(128), 
	@ExpectedSalary int,
	@Comments NVARCHAR(1024)
	as 
	
IF Not Exists 
(
	INSERT dbo.Person(FirstName,LastName,Major,GPA,Graduated,PhoneNumber,Email,ExpectedSalary,Comments)
	values(@FirstName,@LastName,@Major,@GPA,@Graduated,@PhoneNumber,@Email,@SchoolName,@ExpectedSalary,@Comments);
	Insert dbo.School([Name])
	values(@SchoolName);
)