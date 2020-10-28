# Test driven development Dojo

## How we got here

```bash
   mkdir tests
   dotnet new xunit
   dotnet add package fluentassertions
   dotnet add package moq
   mkdir src
   mkdir domain
   dotnet new classlib
   dotnet new sln
   dotnet sln add tests/tests.csproj
   dotnet sln add src/domain/domain.csproj
   dotnet add reference ../src/domain/domain.csproj
   dotnet test
```
