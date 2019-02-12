using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpotifyWebAppAutomation.Extensions
{
    public static class WebDriverExtensions
    {
        public static bool IsElementFoundByPresent(this IWebDriver driver, By by, int? timeout = null)
        {
            if (timeout == null)
            {
                timeout = 15;
            }

            try
            {
                return driver.IsElementDisplayed(by, (int)timeout);
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                return false;
            }
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int? timeoutInSeconds = null)
        {
            return driver.WaitForElementDisplayed(by, timeoutInSeconds);
        }

        public static IWebElement WaitForElementDisplayed(this IWebDriver driver, By by, int? timeoutInSeconds = null)
        {
            if (timeoutInSeconds <= 0)
            {
                timeoutInSeconds = 5;
            }

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(x => x.FindElement(by).Displayed))
            {
                return driver.FindElement(by);
            }
            else
            {
                return null;
            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By by, int timeoutInSeconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            return wait.Until(x => x.FindElement(by).Displayed);
        }
    }
}