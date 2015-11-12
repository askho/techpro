CREATE TABLE [dbo].[CourseRegistration]
(
	[CourseRegistrationID] INT NOT NULL IDENTITY PRIMARY KEY, 
    [CourseID] INT NULL, 
    [StudentID] INT NULL, 
    [Grade] INT NULL,
	CONSTRAINT [FK_COURSEREGISTRATION_Student] FOREIGN KEY ([StudentID]) REFERENCES [Student]([StudentID]), 
    CONSTRAINT [FK_CourseRegistration_Course] FOREIGN KEY ([CourseID]) REFERENCES [Course]([CourseID])
	

)
