# QA-Automation-CSharp

A modular UI automation framework using **C#**, **Selenium**, and **NUnit**.

## 🚀 Tech Stack

- C# (.NET 6.0)
- Selenium WebDriver
- NUnit
- ChromeDriver

## 📁 Project Structure


Pages/ → Page Object Model classes
Drivers/ → WebDriver setup
Tests/ → NUnit test cases



## ✅ How to Run

### Using CLI:

```bash
dotnet restore
dotnet test



Using Visual Studio:
  Open QA-Automation-CSharp.csproj
  Build solution
  Run tests via Test Explorer



    Test 1:
[Test]
public void ValidLogin_ShouldNavigateToHomepage()
{
    _loginPage.EnterUsername("testuser");
    _loginPage.EnterPassword("password123");
    _loginPage.ClickLogin();
    Assert.AreEqual("Home Page", _driver.Title);
}



Output
Test results shown in CLI or Visual Studio. Add HTML report generation with NUnit plugins if needed.






---
## 🔁 CI/CD Integration

A GitHub Actions workflow is provided to run all **C# NUnit UI tests** in this repo automatically.

### ✅ Workflow: `.github/workflows/ci.yml`
```yaml
on: [push, pull_request]
jobs:
  test:
    runs-on: windows-latest
    steps:
      - uses: actions/checkout@v3
      - uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '6.0.x'
      - run: dotnet restore
      - run: dotnet test

