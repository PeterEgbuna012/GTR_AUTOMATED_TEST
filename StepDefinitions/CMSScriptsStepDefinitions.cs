using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class CMSScriptsStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly CMSSCRIPTSPOM pom;

        public CMSScriptsStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new CMSSCRIPTSPOM(driver);

        }


        [Given("I sign as training manager")]
        public void GivenISignAsTrainingManager()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsTrainingManager();
            AllureLogger.SetUserLoginRole("training manager");
        }

        [Given("I open application Qualifications")]
        public void GivenIOpenApplicationQualifications()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu Button",
                pom.AdministrationMenuButton);
            AllureLogger.LogStep("Resources Menu Button",
                pom.ResourcesMenuButton);
            AllureLogger.LogStep("Launch Application Qualifications",
                pom.OpenApplicationQualifications);
        }

        [Given("I select New Qualification")]
        public void GivenISelectNewQualification()
        {
            AllureLogger.LogStep("I select New Qualification",
                pom.SelectNewQualification);
        }

        [Given("I enter Qualifications Details:")]
        public void GivenIEnterQualificationsDetails(Table table)
        {
            string QualificationCode = table.Rows[0]["Qualification Code"];
            string QualificationDescription = table.Rows[0]["Qualification Description"];
            pom.FilterTableQuickWorkOrder(QualificationCode, QualificationDescription);
        }

        [Given("I open Select Value lookup of Qualification Type field")]
        public void GivenIOpenSelectValueLookupOfQualificationTypeField()
        {
            throw new PendingStepException();
        }

        [Given("I select no. {int} record from Qualification Type table records")]
        public void GivenISelectNo_RecordFromQualificationTypeTableRecords(int p0)
        {
            throw new PendingStepException();
        }

        [Given("I enter following:")]
        public void GivenIEnterFollowing(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Given("I open Select Value lookup of Duration Period field")]
        public void GivenIOpenSelectValueLookupOfDurationPeriodField()
        {
            throw new PendingStepException();
        }

        [Given("I select Years from the list")]
        public void GivenISelectYearsFromTheList()
        {
            throw new PendingStepException();
        }

        [Given("I enter Required Use Length:")]
        public void GivenIEnterRequiredUseLength(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Given("I open Select Value lookup of Required Use Period field")]
        public void GivenIOpenSelectValueLookupOfRequiredUsePeriodField()
        {
            throw new PendingStepException();
        }

        [Given("I select MONTHS from the list")]
        public void GivenISelectMONTHSFromTheList()
        {
            throw new PendingStepException();
        }

        [Given("I select New Row under the Required Craft and Skill Level section")]
        public void GivenISelectNewRowUnderTheRequiredCraftAndSkillLevelSection()
        {
            throw new PendingStepException();
        }

        [Given("I choose Select Value from Detail Menu of Craft field")]
        public void GivenIChooseSelectValueFromDetailMenuOfCraftField()
        {
            throw new PendingStepException();
        }

        [Given("I enter Craft and Skill Level:")]
        public void GivenIEnterCraftAndSkillLevel(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Given("I take screenshot of Craft Skill-Level")]
        public void GivenITakeScreenshotOfCraftSkill_Level()
        {
            throw new PendingStepException();
        }

        [Given("I delete Craft Skill-Level")]
        public void GivenIDeleteCraftSkill_Level()
        {
            throw new PendingStepException();
        }

        [Given("I change qualifications change status inactive")]
        public void GivenIChangeQualificationsChangeStatusInactive()
        {
            throw new PendingStepException();
        }

        [Given("I verify status is INACTIVE")]
        public void GivenIVerifyStatusIsINACTIVE()
        {
            throw new PendingStepException();
        }

        [Given("I select Ok Button")]
        public void GivenISelectOkButton()
        {
            throw new PendingStepException();
        }

        [Given("I take screenshot of Creation of a Qualification Test")]
        public void GivenITakeScreenshotOfCreationOfAQualificationTest()
        {
            throw new PendingStepException();
        }

        [Given("I filter table Qualifications:")]
        public void GivenIFilterTableQualifications(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Given("I select no. {int} record from Qualification table records")]
        public void GivenISelectNo_RecordFromQualificationTableRecords(int p0)
        {
            throw new PendingStepException();
        }

        [Given("I select delete Craft Skill-Level")]
        public void GivenISelectDeleteCraftSkill_Level()
        {
            throw new PendingStepException();
        }

        [Given("I select delete Qualifications")]
        public void GivenISelectDeleteQualifications()
        {
            throw new PendingStepException();
        }

        [Given("I press Yes dialog button")]
        public void GivenIPressYesDialogButton()
        {
            throw new PendingStepException();
        }

        [Given("I refresh table records")]
        public void GivenIRefreshTableRecords()
        {
            throw new PendingStepException();
        }

        [Given("I verify table has no records")]
        public void GivenIVerifyTableHasNoRecords()
        {
            throw new PendingStepException();
        }

        [Given("I take screenshot of Delete Qualification Test")]
        public void GivenITakeScreenshotOfDeleteQualificationTest()
        {
            throw new PendingStepException();
        }








    }
}