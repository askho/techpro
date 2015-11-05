CREATE TABLE [dbo].[Student] (
    [StudentID]      INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [Birthday] DATETIME      NULL,
    [ProgramID] INT NULL, 
    PRIMARY KEY CLUSTERED ([StudentID] ASC), 
    CONSTRAINT [FK_Student_ToProgram] FOREIGN KEY (ProgramID) REFERENCES [Program]([ProgramID])
)
