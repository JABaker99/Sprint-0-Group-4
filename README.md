# Sprint-0-Group-4

## Code Coverage Report

This project includes automated tests and supports generating an HTML
code coverage report using Visual Studio and .NET tools.

### Step 1: Generate Coverage XML (Visual Studio)

1. Open the solution in Visual Studio.
2. Open the test project: `Test-Sprint-0-Group-4`.
3. Click **Run Tests** to ensure all tests pass.
4. In the top menu, go to: Test → Analyze Code Coverage for All Tests
5. When the results appear, click: Show Code Coverage Results
6. In the Code Coverage Results window, click: Export → Export to XML
7. Save the file as: Coverage.xml


### Step 2: Generate HTML Report

#### Install coverage tool (only required once)
```bash
dotnet tool install --global dotnet-reportgenerator-globaltool
```
#### Generate HTML Coverage Report
```bash
reportgenerator -reports:"./TestResults/Coverage.xml" -targetdir:"./CoverageReport" -reporttypes:Html
```
#### Open the HTML Coverage Report
```bash
start ./CoverageReport/index.html
