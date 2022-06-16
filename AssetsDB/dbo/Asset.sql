CREATE TABLE [dbo].[Asset]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Status] BIT NOT NULL, 
    [registration_date] DATE DEFAULT getdate() NOT NULL, 
    [Name] NVARCHAR(50) NULL
    
)
