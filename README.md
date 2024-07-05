# How to recreate

mkdir ageCalculator
cd ageCalculator
dotnet new sln
dotnet new xunit -o AgeCalc.Tests
dotnet new classlib -o AgeCalc
dotnet sln add ./AgeCalc.Tests/AgeCalc.Tests.csproj
dotnet sln add ./AgeCalc/AgeCalc.csproj
dotnet add ./AgeCalc.Tests/AgeCalc.Tests.csproj reference ./AgeCalc/AgeCalc.csproj
dotnet add  ./AgeCalc.Tests/AgeCalc.Tests.csproj package FluentAssertions
dotnet build
dotnet test
code .