BEGIN TRANSACTION;
ALTER TABLE [Students] ADD [DateOfBirth] date NOT NULL DEFAULT '0001-01-01';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250923140325_AddDateOfBirthToStudent', N'9.0.9');

COMMIT;
GO

