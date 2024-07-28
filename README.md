# CustomerServer

### Getting started

the project source is ready to use we just need to make sure everything is in place 😊

- you need to make sure [dotnet ef cli tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools) is installed
- database ConnectionString you can find one for a local database in [application settings](./CustomerServer/Server/appsettings.Development.json)
- now you can just update the database by running `./update_database.bat` and run the local build `./run.bat`

### Commands

- Running the project `./run.bat`
- Building the project `./build.bat`
- Adding migration `./add_migration.bat MigrationName` **Don't use spaces**
- Updating the database `./update_database.bat`
