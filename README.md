## Student managment system
### Database migration with change-based migrations using ef migrations

Each migration is created on its own branch. 
The migrations (e.g add column or alter a column) was created with "dotnet ef migrations add + dotnet ef database update"
After each migration, a branch was created for creating the sql file containing the recent changes. 

### Database migration with state-based migration using ef migrations

After all schema changes were applied using the change-based approach,  
a state-based migration was generated to describe the **final desired schema**.

In a state-based migration, the goal is not to replay each incremental step,  
but instead to ensure that the database matches the **current model**.  

This was done using the `dotnet ef migrations script` command, which generates a full SQL script that creates the schema in its latest state.  
The script can be applied to a fresh database and will build all tables, columns, keys, and relationships exactly as they are defined in the final model.

- **Change-based** = step-by-step migrations (e.g. add column, rename column).  
- **State-based** = one script that describes the complete schema at its final state.  

The state-based script (FinalSchema) was generated after completing all assignments, so it contains:
- Student table (with `MiddleName`, `DateOfBirth`)  
- Enrollment table (with `FinalGrade`)  
- Instructor and Department relations  
- Course table with foreign key to Instructor and decimal Credits  
