Param(
   [string] $Server = "mssql.cs.ksu.edu",
   [string] $Database = "chererra543; userId = cherrera543; password = burntbook177419;"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
# & ".\Scripts\DropDatabase.ps1" -Database $Database
# & ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Schemas\dbo.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\dbo.Person.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\dbo.Apply.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\dbo.Company.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\dbo.Degree.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\dbo.Job.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Tables\dbo.School.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Procedures\dbo.BestCandidate.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Procedures\dbo.ListOfJobs.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Procedures\dbo.NumberOfJobs.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Procedures\dbo.PopularSchool.sql"


Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Data\dbo.CreateJob.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "sqlProj\PersonData\Sql\Data\dbo.CreatePerson.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
