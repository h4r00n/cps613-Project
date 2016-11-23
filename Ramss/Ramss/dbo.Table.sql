CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL , 
    [courseCode] NCHAR(10) NOT NULL, 
    [courseName] NCHAR(10) NULL, 
    [preReq] NCHAR(10) NULL, 
    PRIMARY KEY ([courseCode])
)
