using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using SeleniumSpecflow.Driver;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.BDD.StepDefinition
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly IObjectContainer objectContainer;
        private readonly FeatureContext featureContext;
        private readonly ScenarioContext scenarioContext;

        //For context injections
        public Hooks(IObjectContainer objectContainer, FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.objectContainer = objectContainer;
            this.featureContext = featureContext;
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var appSettings = ConfigurationManager.AppSettings;

            var browser = appSettings["browser"];
            var headless = bool.Parse(appSettings["headless"]);
            var implicitWait = int.Parse(appSettings["implicitWait"]);
            var Url = appSettings["Url"];

            IWebDriver driver = FactoryBuilder.GetFactory(browser).SetHeadless(headless).GetDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Url);
            objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver driver = objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }

    }
}
