# Continous Integration and Unit Testing

## As a attendee I want to install a development toolset so that I can develop efficiently
The following tools are installed and have been executed:
- .NET Core SDK (2.1 or higher)
- Git (e.g. Git for Windows)
- Visual Studio 2017/2019 (or Visual Studio Code alternatively)
- Optional: ReSharper


## As a attendee I want to setup a my repository and project so that I can attend the exercises and commit my changes
- Create a fork on Azure DevOps from the [repository](https://dev.azure.com/NagarroAT/Training%20ICAgile/_git/icagile-programming)
- Create a local clone and switch to the branch “01-CI_and_Unit_testing”
- Start the IDE and open the provided solution (CSharp/csharp.sln)
- Check that the project is built correctly in the integrated environment


## As a attendee I want to create Build Pipeline so that I can practice Continuous Integration
- Create a new build pipeline “\<your-name\> exercise-01” for the branch mentioned branch from your forked repository
- Create a trigger for continuous integration
- Commit and push a change locally and run the job


## As a attendee I want to implement enough Unit Tests for the Gilded Rose
- Implement as many Unit Tests as necessary for the class GildedRose
- Checkout the branch “01-CI_and_Unit_Testing” in your git repository
- Implement your tests in the provided template GildedRoseTest
- Measure the achieved code coverage with the Visual Studio Code Coverage Analyzer Tool (Visual Studio Enterprise only)
- Commit your changes and execute the tests in your Azure DevOps Pipeline
- Make sure there is a test report for the unit tests is generated
- Constraint: Do not alter the code of the classes GildedRose or Item!

