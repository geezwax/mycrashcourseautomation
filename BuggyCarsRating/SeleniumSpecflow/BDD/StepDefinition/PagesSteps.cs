using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflow.Model.Pages;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.BDD.StepDefinition
{
    [Binding]
    public class PagesSteps
    {
        //To have a driver to use for the Steps
        public IWebDriver driver;

        //For when the Steps is created, it could use a web driver
        public PagesSteps(IWebDriver _driver)
        {
            driver = _driver;
        }
        [Given(@"the user clicks on Popmake")]
        public void GivenTheUserClicksOnPopmake()
        {
            MainPage mainPage = new MainPage(driver);

            mainPage.PopMake.Click();
        }
        
        [Given(@"the user clicks on Popmodel")]
        public void GivenTheUserClicksOnPopmodel()
        {
            MainPage mainPage = new MainPage(driver);

            mainPage.PopModel.Click();
        }
        
        [Given(@"the user clicks on Overall")]
        public void GivenTheUserClicksOnOverall()
        {
            MainPage mainPage = new MainPage(driver);

            mainPage.Overall.Click();
        }
        
        [Then(@"user is in Popmake page")]
        public void ThenUserIsInPopmakePage()
        {
            MainPage mainPage = new MainPage(driver);

            Assert.IsTrue(mainPage.Model.Displayed);
            Assert.IsTrue(mainPage.Rank.Displayed);
            Assert.IsTrue(mainPage.Votes.Displayed);
        }
        
        [Then(@"user is in Popmodel page")]
        public void ThenUserIsInPopmodelPage()
        {
            MainPage mainPage = new MainPage(driver);

            Assert.IsTrue(mainPage.Specification.Displayed);
        }
        
        [Then(@"user is in Overall page")]
        public void ThenUserIsInOverallPage()
        {
            MainPage mainPage = new MainPage(driver);

            Assert.IsTrue(mainPage.Engine.Displayed);
        }
    }
}
