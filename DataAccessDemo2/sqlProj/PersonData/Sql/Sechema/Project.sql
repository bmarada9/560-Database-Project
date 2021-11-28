IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'dbo'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Project] AUTHORIZATION [dbo]');
END;
