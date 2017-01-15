CREATE TABLE [dbo].[Meal]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [Price] NUMERIC(18, 2) NOT NULL, 
    [Active] BIT NOT NULL
)
