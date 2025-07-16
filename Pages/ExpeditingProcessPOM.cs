using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
    [Binding]
    public sealed class ExpeditingProcessPOM
    {

        private readonly IWebDriver driver;
        public ExpeditingProcessPOM(IWebDriver drv) => driver = drv;

        public void OpenGoToMenu() =>
            AllureLogger.LogStep("Open [Go To] menu", () =>
                SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                  "Go To button"));

        public void AdministrationMenu() =>
            AllureLogger.LogStep("Administration Menu", () =>
                SafeActions.Click(driver, By.Id("menu0_SETUP_MODULE_a_tnode"),
                                  "Administration Menu"));

        public void OrganizationsTRApplication() =>
            AllureLogger.LogStep("Launch Organizations (TR)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_SETUP_MODULE_sub_changeapp_PLUSTORG_a_tnode"),
                    "Launch Organizations (TR)"));

        public void RequisitionDescription(string Organizations) =>
        AllureLogger.LogStep($"I filter Organizations table with Organizations = '{Organizations}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Adjust column indices as per actual table structure:
            // Description = column 2 → C:2
            // Status = column 10 → C:10

            By OrganizationsFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

            IWebElement OrganizationsFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(OrganizationsFilterLocator));
            OrganizationsFilter.Click();
            OrganizationsFilter.Clear();
            OrganizationsFilter.SendKeys(Organizations);
            OrganizationsFilter.SendKeys(Keys.Enter);

        });


        public void SelectNoRecordFromCompanyTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Organizations Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Organizations Table Records");
            });

        }

        public void FilterTableCompanyField(string Description) =>
       AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Description}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

           // Adjust column indices as per actual table structure:
           // Description = column 2 → C:2
           // Status = column 10 → C:10

           By DescriptionFilterLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:2\\]_txt-tb");

           IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionFilterLocator));
           DescriptionFilter.Click();
           DescriptionFilter.Clear();
           DescriptionFilter.SendKeys(Description);
           DescriptionFilter.SendKeys(Keys.Enter);

       });


        public void SelectAction() =>
      AllureLogger.LogStep("I Select Action", () =>
          SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-img"),
                            "I Select Action"));

        public void ExpediteOptions() =>
       AllureLogger.LogStep("Expedite Options", () =>
           SafeActions.Click(driver, By.Id("menu0_MXREXPORG_OPTION_a_tnode"),
                             "Expedite Options"));


         public void EnterFollowingExpediteOptionsData(string StoreLeadTime, string storebuffday) =>
       AllureLogger.LogStep($"I filter CM Work Order table with Description = '{StoreLeadTime}', Details = '{storebuffday}','", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

           // Adjust column indices as per actual table structure:
           // Description = column 2 → C:2
           // Status = column 10 → C:10

           By StoreLeadFilterLocator = By.CssSelector("#m502a3678-tb");
           By storebuffdayFilterLocator = By.CssSelector("#m574a8b0d-tb");

           IWebElement StoreLeadTimeFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(StoreLeadFilterLocator));
           StoreLeadTimeFilter.Click();
           StoreLeadTimeFilter.Clear();
           StoreLeadTimeFilter.SendKeys(StoreLeadTime);
           
           IWebElement storebuffdayFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(storebuffdayFilterLocator));
           storebuffdayFilter.Click();
           storebuffdayFilter.Clear();
           storebuffdayFilter.SendKeys(storebuffday);
            
       });



        public void SubmitRecord() =>
           AllureLogger.LogStep("I Submit Record", () =>
               SafeActions.Click(driver, By.CssSelector("#mddd70bb0-pb"),
                                 "I Submit Record"));

        public void TakeScreenshotOfAmendInventoryDefaultsForExpeditingProcessTest() =>
           AllureLogger.LogStep("Capture Screenshot for GTR-UAT-EXP-001", () =>
           {
               try
               {
                   var takescreenshot = new TakeScreenShotPOM(driver);
                   string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-EXP-001.png";

                   takescreenshot.TakeScreenshot(driver, successPath);
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"Screenshot failed: {ex.Message}");

                   // Attempt fallback screenshot on failure
                   var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-EXP-001_Failure.png";
                   var takescreenshot = new TakeScreenShotPOM(driver);

                   takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                   // Optional: Rethrow if test should fail
                   throw new Exception("Test failed while taking screenshot.", ex);
               }
           });

        public void ReturnToMaintainerStartCenter() =>
           AllureLogger.LogStep("I return to Maintainer Start Center", () =>
               SafeActions.Click(driver, By.CssSelector("#titlebar-tb_homeButton"),
                                 "I return to Maintainer Start Center"));




    }
}