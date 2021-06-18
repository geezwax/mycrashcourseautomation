using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflow.Model.Pages;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.BDD.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        //To have a driver to use for the Steps
        public IWebDriver driver;

        //For when the Steps is created, it could use a web driver
        public LoginSteps(IWebDriver _driver)
        {
            driver = _driver;
        }

        [Given(@"that user has valid login")]
        public void GivenThatUserHasValidLogin()
        {
            MainPage mainPage = new MainPage(driver);

            mainPage.Username.SendKeys("fritzoliver");
            mainPage.Password.SendKeys("Fritzoliver1!");
            mainPage.Loginbutton.Click();
        }
        

        [Then(@"successful login")]
        public void ThenSuccessfulLogin()
        {
            MainPage mainPage = new MainPage(driver);

            Assert.IsTrue(mainPage.Profile.Displayed);
            Assert.IsTrue(mainPage.Logout.Displayed);
        }

        [Given(@"that user has invalid login")]
        public void GivenThatUserHasInvalidLogin()
        {
            MainPage mainPage = new MainPage(driver);

            mainPage.Username.SendKeys("fritzoliver");
            mainPage.Password.SendKeys("Fritzoliver");
            mainPage.Loginbutton.Click();
        }

        [Then(@"failed login")]
        public void ThenFailedLogin()
        {
            MainPage mainPage = new MainPage(driver);

            Assert.IsTrue(mainPage.InvalidUser.Displayed);
        }
        [Given(@"that user has clicked Logout")]
        public void GivenThatUserHasClickedLogout()
        {
            MainPage mainPage = new MainPage(driver);

            mainPage.Logoutbutton.Click();
        }

        [Then(@"successful logout")]
        public void ThenSuccessfulLogout()
        {
            MainPage mainPage = new MainPage(driver);

            Assert.IsTrue(mainPage.Loginbutton.Displayed);
        }
    }
}

