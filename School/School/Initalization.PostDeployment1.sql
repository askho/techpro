/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
MERGE INTO Course AS Target 
USING (VALUES 
        (1, 'Economics', 3), 
        (2, 'Literature', 3), 
        (3, 'Chemistry', 4)
) 
AS Source (CourseID, CourseName, CourseCredit) 
ON Target.CourseID = Source.CourseID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (CourseName, CourseCredit) 
VALUES (CourseName, CourseCredit);

MERGE INTO Student AS Target 
USING (VALUES 
        (1, 'Ho', 'Leon', null, 1), 
        (2, 'Christiansen', 'Jens', null, 1), 
        (3, 'Morishita', 'Andrew', null, 1),
		(4, 'Le', 'Duy', null, 1)
) 
AS Source (StudentID, LastName, FirstName, Birthday, ProgramID) 
ON Target.StudentID = Source.StudentID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (LastName, FirstName, Birthday, ProgramID) 
VALUES (LastName, FirstName, Birthday, ProgramID);

MERGE INTO Program AS Target 
USING (VALUES 
        (1, 'CST'), 
        (2, 'CIT'), 
        (3, 'CISA')
) 
AS Source (ProgramID, ProgramName) 
ON Target.ProgramID = Source.ProgramID
WHEN NOT MATCHED BY TARGET THEN 
INSERT (ProgramName) 
VALUES (ProgramName);

MERGE INTO CourseRegistration AS Target 
USING (VALUES 
        (1, 1, 1, 4), 
        (2, 2, 1, 4), 
        (3, 3, 1, 4),
		(4, 2, 2, 4)
) 
AS Source (CourseRegistrationID, CourseID, StudentID, Grade) 
ON Target.CourseRegistrationID = Source.CourseRegistrationID
WHEN NOT MATCHED BY TARGET THEN 
INSERT (CourseID, StudentID, Grade) 
VALUES (CourseID, StudentID, Grade);