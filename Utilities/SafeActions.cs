using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading.Tasks;

namespace GTR_AUTOMATED.Utilities
{
    /// <summary>
    /// Provides resilient Selenium interactions with retries and Allure hooks.
    /// </summary>
    public static class SafeActions
    {
        /* ---------- Basics ---------- */

        public static void Click(IWebDriver driver, By by, string humanName,
                                 int timeoutSec = 50, int retries = 2) =>
            Execute(humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec, ExpectedConditions.ElementToBeClickable);
                el.Click();
            });

        public static void EnterText(IWebDriver driver, By by, string text,
                                     string humanName, int timeoutSec = 50,
                                     int retries = 2) =>
            Execute(humanName, retries, () =>
            {
                var el = Wait(driver, by, timeoutSec,
                              ExpectedConditions.ElementIsVisible);
                el.Clear();
                el.SendKeys(text);
            });

        /* ---------- Helpers ---------- */

        private static IWebElement Wait(IWebDriver driver, By by, int timeout,
                                        Func<By, Func<IWebDriver, IWebElement>> condition)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            return wait.Until(condition(by));
        }

        private static void Execute(string description, int retries, Action body)
        {
            int attempt = 0;
            while (true)
            {
                try
                {
                    body();
                    return;
                }
                catch (Exception ex)
                {
                    if (++attempt > retries)
                    {
                        AllureLogger.LogError(ex, description);
                        throw;
                    }
                    Task.Delay(5000).Wait();
                }
            }
        }
              


        public static void ClearAndEnterText(IWebDriver driver,By locator, string text,string description)
        {
            AllureLogger.LogStep(description, () =>
            {
                var element = driver.FindElement(locator);
                element.Clear();
                element.SendKeys(text);
            });
        }


    }
}
