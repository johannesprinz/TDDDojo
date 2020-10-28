# Test driven development Dojo

## Getting started

This project is designed to be edited in [VS Code](https://code.visualstudio.com/) using the [Remote Container](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) extension which requires [Docker](https://www.docker.com/products/docker-desktop). Once you have the above three dependencies installed, get latest and reopen the repository in a container.

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
