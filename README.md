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

## Entity database migration

```bash

dotnet ef migrations add [name of migration] -p [Name of project where migration will live] -s [Name of startup project] 
## example: dotnet ef migrations add firstMigration -p Infrastructure -s API

```
