using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenQA.Selenium;
using Reqnroll;
using TechTalk.SpecFlow;
using BindingAttribute = Reqnroll.BindingAttribute;
using GivenAttribute = Reqnroll.GivenAttribute;
using PendingStepException = Reqnroll.PendingStepException;
using Table = TechTalk.SpecFlow.Table;
using ThenAttribute = Reqnroll.ThenAttribute;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class ExpeditingProcessStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly ExpeditingProcessPOM pom;

        public ExpeditingProcessStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new ExpeditingProcessPOM(driver);

        }


        [Given("I sign as maximo administrator")]
        public void GivenISignAsMaximoAdministrator()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsMaximoadministrator();
            AllureLogger.SetUserLoginRole("Maximo Administrator");
        }

        [Given("I open application Organizations \\(Tr)")]
        public void GivenIOpenApplicationOrganizationsTr()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu",
                pom.AdministrationMenu);
            AllureLogger.LogStep("Launch Organizations TR",
                pom.OrganizationsTRApplication);
        }

        [Given("I filter table Organizations \\(Tr):")]
        public void GivenIFilterTableOrganizationsTr(Table table)
        {
            string Organizations = table.Rows[0]["Description"];


            pom.RequisitionDescription(Organizations);
        }

        [Given("I select no. {int} record from Organizations \\(Tr) table records")]
        public void GivenISelectNo_RecordFromOrganizationsTrTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Organizations table records",
              () => pom.SelectNoRecordFromCompanyTableRecord(recordNumber));
        }


        [Given("I Select  Actions Expedite Options")]
        public void GivenISelectActionsExpediteOptions()
        {
            AllureLogger.LogStep("I select action",
              pom.SelectAction);
            AllureLogger.LogStep("Expedite Options",
               pom.ExpediteOptions);
        }

        [Given("I enter following Expedite Options data:")]
        public void GivenIEnterFollowingExpediteOptionsData(Table table)
        {
            string StoreLeadTime = table.Rows[0]["Store Lead Time"];
            string storebuffday = table.Rows[0]["store buff day"];


            pom.EnterFollowingExpediteOptionsData(StoreLeadTime, storebuffday);
        }

        [Given("I submit record")]
        public void GivenISubmitRecord()
        {
            AllureLogger.LogStep("I Submit Record",
              pom.SubmitRecord);
        }

        [Given("I take screenshot of Amend Inventory Defaults for Expediting Process Test")]
        public void GivenITakeScreenshotOfAmendInventoryDefaultsForExpeditingProcessTest()
        {
            AllureLogger.LogStep("I take screenshot of Amend Inventory Defaults for Expediting Process Test",
               pom.TakeScreenshotOfAmendInventoryDefaultsForExpeditingProcessTest);
        }
                

        [Then("I return to Maintainer Start Center")]
        public void ThenIReturnToMaintainerStartCenter()
        {
           AllureLogger.LogStep("I return to Maintainer Start Center",
              pom.ReturnToMaintainerStartCenter);
        }



    }
}