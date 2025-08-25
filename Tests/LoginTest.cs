using NUnit.Framework;
using QA_Automation_CSharp.Drivers;
using QA_Automation_CSharp.Pages;
using OpenQA.Selenium;

namespace QA_Automation_CSharp.Tests
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        [SetUp]
        public void SetUp()
        {
            _driver = WebDriverFactory.CreateChromeDriver();
            _driver.Navigate().GoToUrl("https://example.com/login");
            _loginPage = new LoginPage(_driver);
        }

        [Test]
        public void ValidLogin_ShouldNavigateToHomepage()
        {
            _loginPage.EnterUsername("testuser");
            _loginPage.EnterPassword("password123");
            _loginPage.ClickLogin();

            Assert.AreEqual("Home Page", _driver.Title);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
