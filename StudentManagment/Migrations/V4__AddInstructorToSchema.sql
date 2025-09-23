BEGIN TRANSACTION;
ALTER TABLE [Courses] ADD [InstructorId] int NULL;

CREATE TABLE [Instructor] (
    [InstructorId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [HireDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Instructor] PRIMARY KEY ([InstructorId])
);

CREATE INDEX [IX_Courses_InstructorId] ON [Courses] ([InstructorId]);

ALTER TABLE [Courses] ADD CONSTRAINT [FK_Courses_Instructor_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructor] ([InstructorId]) ON DELETE SET NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250923142244_AddInstructorToSchema', N'9.0.9');

COMMIT;
GO

