using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace GTR_AUTOMATED.Pages
{
    [Binding]
    public sealed class CMSSCRIPTSPOM
    {

        private readonly IWebDriver driver;
        public CMSSCRIPTSPOM(IWebDriver drv) => driver = drv;



             public void OpenGoToMenu() =>
            AllureLogger.LogStep("Open [Go To] menu", () =>
                SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                  "Open [Go To] menu"));

             public void AdministrationMenuButton() =>
            AllureLogger.LogStep("Administration Menu Button", () =>
                SafeActions.Click(driver, By.Id("menu0_SETUP_MODULE_a_tnode"),
                                  "Administration Menu Button"));

            public void ResourcesMenuButton() =>
            AllureLogger.LogStep("Resources Menu Button", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_SETUP_MODULE_sub_MOD10041_HEADER_a_tnode"),
                    "Resources Menu Button"));

         public void OpenApplicationQualifications() =>
            AllureLogger.LogStep("Launch Application Qualifications", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_SETUP_MODULE_sub_MOD10041_HEADER_sub_changeapp_QUAL_a_tnode"),
                    "Launch Application Qualifications"));

        public void SelectNewQualification() =>
           AllureLogger.LogStep("I select New Qualification", () =>
               SafeActions.Click(driver,
                   By.Id("toolactions_INSERT-tbb_image"),
                   "I select New Qualification"));

         public void FilterTableQuickWorkOrder(string QualificationCode, string QualificationDescription) =>
        AllureLogger.LogStep($"I enter Qualifications Details Qualification Code = '{QualificationCode}', Qualification Description = '{QualificationDescription}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Adjust column indexes if needed
            By QualificationCodeFilterLocator = By.CssSelector("#mf1565c60-tb");
            By QualificationDescriptionLocator = By.CssSelector("#mf1565c60-tb2");
           
            // Description filter
            IWebElement QualificationCodeFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(QualificationCodeFilterLocator));
            QualificationCodeFilter.Click();
            QualificationCodeFilter.Clear();
            QualificationCodeFilter.SendKeys(QualificationCode);

            // Status filter
            IWebElement QualificationDescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(QualificationDescriptionLocator));
            QualificationDescriptionFilter.Click();
            QualificationDescriptionFilter.Clear();
            QualificationDescriptionFilter.SendKeys(QualificationDescription);
                        
        });


    }
}