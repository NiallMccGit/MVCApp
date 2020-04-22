CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EmployeeID] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(100) NOT NULL 
)
