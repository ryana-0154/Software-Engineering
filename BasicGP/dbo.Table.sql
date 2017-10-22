CREATE TABLE [dbo].[patient]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First name] NCHAR(10) NULL, 
    [Last name] NCHAR(10) NULL, 
    [Phone number] INT NULL, 
    [address] NTEXT NULL
)
