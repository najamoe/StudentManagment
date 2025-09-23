BEGIN TRANSACTION;
CREATE TABLE [Departments] (
    [DepartmentId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [budget] int NOT NULL,
    [StartDate] date NOT NULL,
    [DepartmentHeadId] int NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([DepartmentId]),
    CONSTRAINT [FK_Departments_Instructor_DepartmentHeadId] FOREIGN KEY ([DepartmentHeadId]) REFERENCES [Instructor] ([InstructorId]) ON DELETE SET NULL
);

CREATE UNIQUE INDEX [IX_Departments_DepartmentHeadId] ON [Departments] ([DepartmentHeadId]) WHERE [DepartmentHeadId] IS NOT NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250923151319_AddedDepartmentToSchema', N'9.0.9');

COMMIT;
GO

