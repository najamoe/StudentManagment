IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Instructor] (
    [InstructorId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [HireDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Instructor] PRIMARY KEY ([InstructorId])
);

CREATE TABLE [Students] (
    [StudentId] int NOT NULL IDENTITY,
    [Firstname] nvarchar(max) NOT NULL,
    [MiddleName] nvarchar(max) NULL,
    [Lastname] nvarchar(max) NOT NULL,
    [DateOfBirth] date NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [EnrollmentDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([StudentId])
);

CREATE TABLE [Courses] (
    [CourseId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Credits] decimal(5,2) NOT NULL,
    [InstructorId] int NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY ([CourseId]),
    CONSTRAINT [FK_Courses_Instructor_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructor] ([InstructorId]) ON DELETE SET NULL
);

CREATE TABLE [Departments] (
    [DepartmentId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [budget] int NOT NULL,
    [StartDate] date NOT NULL,
    [DepartmentHeadId] int NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([DepartmentId]),
    CONSTRAINT [FK_Departments_Instructor_DepartmentHeadId] FOREIGN KEY ([DepartmentHeadId]) REFERENCES [Instructor] ([InstructorId]) ON DELETE SET NULL
);

CREATE TABLE [Enrollments] (
    [EnrollmentId] int NOT NULL IDENTITY,
    [StudentId] int NOT NULL,
    [CourseId] int NOT NULL,
    [FinalGrade] int NULL,
    CONSTRAINT [PK_Enrollments] PRIMARY KEY ([EnrollmentId]),
    CONSTRAINT [FK_Enrollments_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Enrollments_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([StudentId]) ON DELETE CASCADE
);

CREATE INDEX [IX_Courses_InstructorId] ON [Courses] ([InstructorId]);

CREATE UNIQUE INDEX [IX_Departments_DepartmentHeadId] ON [Departments] ([DepartmentHeadId]) WHERE [DepartmentHeadId] IS NOT NULL;

CREATE INDEX [IX_Enrollments_CourseId] ON [Enrollments] ([CourseId]);

CREATE INDEX [IX_Enrollments_StudentId] ON [Enrollments] ([StudentId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250929074338_FinalSchema', N'9.0.9');

COMMIT;
GO

