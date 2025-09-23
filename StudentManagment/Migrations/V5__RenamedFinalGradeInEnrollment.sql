BEGIN TRANSACTION;
DECLARE @var sysname;
SELECT @var = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Enrollments]') AND [c].[name] = N'Grade');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Enrollments] DROP CONSTRAINT [' + @var + '];');
ALTER TABLE [Enrollments] DROP COLUMN [Grade];

ALTER TABLE [Enrollments] ADD [FinalGrade] int NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250923143823_RenameGradeToFinalGrade', N'9.0.9');

COMMIT;
GO

