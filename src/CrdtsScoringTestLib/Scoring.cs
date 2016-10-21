using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace CrdtsScoringTestLib
{
    public class Scoring : IDisposable
    {
        private IWebDriver driver;

        public Scoring()
        {
            driver = new InternetExplorerDriver();
        }

        public void wait(int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }

        public void loadUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IList<IWebElement> test()
        {
            return driver.FindElements(By.ClassName("ChildSelectedItem"));
        }

        public IWebElement test1()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.Id("aspnetForm")));
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
