using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumSpecflow.Model.Pages
{
    public class MainPage
    {
        //To have a driver to use for the page
        public IWebDriver driver;

        // represents one field of the page
        public IWebElement Username => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/input[1]"));
        public IWebElement Password => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/input[2]"));
        public IWebElement Loginbutton => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/button"));
        public IWebElement Logoutbutton => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/ul/li[3]/a"));

        public IWebElement Profile => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/ul/li[2]/a"));
        public IWebElement Logout => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/ul/li[3]/a"));
        public IWebElement InvalidUser => driver.FindElement(By.XPath("/html/body/my-app/header/nav/div/my-login/div/form/div/span"));
        public IWebElement PopMake => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[1]/div/a/img"));
        public IWebElement Model => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[2]/div/div/table/thead/tr/th[2]/a"));
        public IWebElement Rank => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[2]/div/div/table/thead/tr/th[3]/a"));
        public IWebElement Votes => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-make/div/div[2]/div/div/table/thead/tr/th[4]/a"));
        public IWebElement PopModel => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[2]/div/a/img"));
        public IWebElement Specification => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[1]/div/h4"));
        public IWebElement Overall => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[3]/div/a/img"));
        public IWebElement Engine => driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table/thead/tr/th[6]/a"));

        //For when the page is created, it could use a web driver
        public MainPage(IWebDriver _driver)
        {
            driver = _driver;
        }


    }
}
