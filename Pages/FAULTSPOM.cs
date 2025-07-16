using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
    [Binding]
    public class FAULTSPOM
    {
        private readonly IWebDriver driver;
        public FAULTSPOM(IWebDriver drv) => driver = drv;


        public void RelationshipFieldHasValueFOLLOWUP() =>
          AllureLogger.LogStep("Relationship field has value FOLLOWUP", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(10000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#ma7e0763-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "FOLLOWUP"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "FOLLOWUP")
                  {
                      throw new Exception($"Expected status value FOLLOWUP but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is FOLLOWUP.");
              }
              catch (NoSuchElementException ex)
              {
                  Console.WriteLine("Error: Status field not found - " + ex.Message);
                  throw;
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Error: " + ex.Message);
                  throw;
              }

          });

          public void TakeScreenshotOfRaisingAFaultTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDFR-REG-001", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDFR-REG-001.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDFR-REG-001_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });






    }
}