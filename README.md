# learnfy
A udemy like application built with .NET and React


## Build

```bash
dotnet build
```

## Format

```bash
dotnet format
```

## Run Project

```bash
dotnet run
```

## Entity database migration

```bash

dotnet ef migrations add [name of migration] -p [Name of project where migration will live] -s [Name of startup project] 
## example: dotnet ef migrations add firstMigration -p Infrastructure -s API

```

## Project Structure

- Web Api
  - Is our main project with all business logic and controller.
- Entity
  - We store all our model properties and interfaces.
- Infrastructure
  - Taking care of our database related methods, such as store context such as database creation.
  - Database migrations
