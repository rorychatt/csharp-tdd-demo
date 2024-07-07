# How to recreate

```
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
```

1. **`mkdir ageCalculator`**
   - This command creates a new directory called `ageCalculator`. This will be the root directory for your project.

2. **`cd ageCalculator`**
   - This changes the current working directory to the newly created `ageCalculator` directory.

3. **`dotnet new sln`**
   - This initializes a new .NET solution file (`.sln`) in the current directory. A solution file organizes multiple projects into a single solution.

4. **`dotnet new xunit -o AgeCalc.Tests`**
   - This creates a new xUnit test project in a directory named `AgeCalc.Tests`. The `-o` option specifies the output directory. xUnit is a popular testing framework for .NET.

5. **`dotnet new classlib -o AgeCalc`**
   - This creates a new .NET class library project in a directory named `AgeCalc`. This will contain the code for your age calculator.

6. **`dotnet sln add ./AgeCalc.Tests/AgeCalc.Tests.csproj`**
   - This adds the `AgeCalc.Tests` project to the solution file. The path points to the project file (`.csproj`) within the `AgeCalc.Tests` directory.

7. **`dotnet sln add ./AgeCalc/AgeCalc.csproj`**
   - This adds the `AgeCalc` class library project to the solution file. The path points to the project file (`.csproj`) within the `AgeCalc` directory.

8. **`dotnet add ./AgeCalc.Tests/AgeCalc.Tests.csproj reference ./AgeCalc/AgeCalc.csproj`**
   - This adds a project reference in the `AgeCalc.Tests` project to the `AgeCalc` project. This means the test project can access and test the classes and methods defined in the `AgeCalc` class library.

9. **`dotnet add ./AgeCalc.Tests/AgeCalc.Tests.csproj package FluentAssertions`**
   - This adds the `FluentAssertions` NuGet package to the `AgeCalc.Tests` project. `FluentAssertions` is a library that allows you to write more readable and maintainable assertions in your tests.

10. **`dotnet build`**
    - This command builds the solution, compiling all the projects in the solution. It ensures that there are no compilation errors and that all dependencies are correctly referenced.

11. **`dotnet test`**
    - This command runs all the tests in the solution. It compiles the test projects and executes the tests, reporting the results.

12. **`code .`**
    - This command opens the current directory in Visual Studio Code (if it is installed on your system). This allows you to start editing your code and running your tests from within the VS Code IDE.

By following these commands, you have set up a structured .NET solution with a class library for your age calculator and a corresponding xUnit test project to test the library. This setup promotes a clean separation of concerns and makes it easy to manage and test your code.