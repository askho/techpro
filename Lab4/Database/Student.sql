CREATE TABLE [dbo].[Student]
(
	[StudentID] INT NOT NULL IDENTITY PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Birthday] DATE NULL, 
    [ProgramID] INT NULL, 
    CONSTRAINT [FK_Student_Program] FOREIGN KEY ([ProgramID]) REFERENCES [Programs]([ProgramID])
)
