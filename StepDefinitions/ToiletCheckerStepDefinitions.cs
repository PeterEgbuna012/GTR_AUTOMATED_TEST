using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;
using BindingAttribute = TechTalk.SpecFlow.BindingAttribute;
using GivenAttribute = TechTalk.SpecFlow.GivenAttribute;
using Table = TechTalk.SpecFlow.Table;

namespace GTR_AUTOMATED.StepDefinitions
{

    [Binding]
    public class ToiletCheckerStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly TCPOM pom;

        public ToiletCheckerStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new TCPOM(driver);
        }



        [Given("I sign as clean master")]
        public void GivenISignAsCleanMaster()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsCleanMaster();
            AllureLogger.SetUserLoginRole("clean master");
        }

        [Given("I open application Toilet Checker \\(MXR)")]
        public void GivenIOpenApplicationToiletCheckerMXR()
        {
            AllureLogger.LogStep("Open [Go To] menu Bar",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch application Toilet Checker (MXR)",
                pom.OpenApplicationToiletCheckerMXR);
        }

        [Given("I filter table Toilet Checker:")]
        public void GivenIFilterTableToiletChecker(Table table)
        {
            string ToiletChecker = table.Rows[0]["Toilet Checker"];
            AllureLogger.LogStep($"I filter table Asset Group: {ToiletChecker}", () =>
                pom.FilterTableToiletChecker(ToiletChecker));
        }
                     

        [Given("I select View Details arrow")]
        public void GivenISelectViewDetailsArrow()
        {
            AllureLogger.LogStep("I select View Details arrow",
              pom.SelectViewDetailsArrow);
        }

        [Given("I verify toilet number")]
        public void GivenIVerifyToiletNumber()
        {
            AllureLogger.LogStep("I verify toilet number",
               pom.VerifyToiletNumber);
        }

        [Given("I verify toilet description")]
        public void GivenIVerifyToiletDescription()
        {
            AllureLogger.LogStep("I verify toilet number",
              pom.VerifyToiletDescription);
        }

        [Given("I verify toilet Status")]
        public void GivenIVerifyToiletStatus()
        {
            AllureLogger.LogStep("I verify toilet number",
              pom.VerifyToiletStatus);
        }
        
        [Given("I verify toilet unavailability reason")]
        public void GivenIVerifyToiletUnavailabilityReason()
        {
            AllureLogger.LogStep("I verify toilet number",
              pom.VerifyToiletUnavailabilityReason);
        }

        [Given("I verify toilet locked")]
        public void GivenIVerifyToiletLocked()
        {
            AllureLogger.LogStep("I verify toilet locked",
              pom.VerifyToiletLocked);
        }

        [Given("I verify toilet checked date")]
        public void GivenIVerifyToiletCheckedDate()
        {
            AllureLogger.LogStep("I verify toilet locked",
              pom.VerifyToiletCheckedDate);
        }

        [Given("I select the Close Details arrow")]
        public void GivenISelectTheCloseDetailsArrow()
        {
            AllureLogger.LogStep("I select the Close Details arrow",
             pom.SelectTheCloseDetailsArrow);
        }

        [Given("I take screenshot of View Toilet Status")]
        public void GivenITakeScreenshotOfViewToiletStatus()
        {
            AllureLogger.LogStep("I take screenshot of View Toilet Status",
                pom.TakeScreenshotOfViewToiletStatus);
        }




        //Change status of a Toilet Asset Step Definitions 


        [Given("I select change toilet asset statuse button")]
        public void GivenISelectChangeToiletAssetStatuseButton()
        {
            AllureLogger.LogStep("I select change toilet asset statuse button",
              pom.SelectChangeToiletAssetStatuseButton);
        }

        [Given("I Click on the status dropdown")]
        public void GivenIClickOnTheStatusDropdown()
        {
            AllureLogger.LogStep("I Click on the status dropdown",
             pom.ClickOnTheStatusDropdown);
        }

        [Given("I select unavailable")]
        public void GivenISelectUnavailable()
        {
            AllureLogger.LogStep("I select unavailable",
             pom.SelectUnavailable);
        }

        [Given("I filter table Toilet Unavailable Reason:")]
        public void GivenIFilterTableToiletUnavailableReason(Table table)
        {
            string ToiletCheckerunavailableReason = table.Rows[0]["Toilet Checker"];
            AllureLogger.LogStep($"I filter table Asset Group: {ToiletCheckerunavailableReason}", () =>
                pom.FilterTableToiletUnavailableReason(ToiletCheckerunavailableReason));
        }
                   

        [Given("I press button ok")]
        public void GivenIPressButtonOk()
        {
            AllureLogger.LogStep("I press button ok",
              pom.PressButtonOk);
        }

        [Given("I select available")]
        public void GivenISelectAvailable()
        {
            AllureLogger.LogStep("I select available",
            pom.SelectAvailable);
        }


        [Given("I take screenshot of Change status of a Toilet Asset")]
        public void GivenITakeScreenshotOfChangeStatusOfAToiletAsset()
        {
            AllureLogger.LogStep("I take screenshot of Change status of a Toilet Asset",
                 pom.TakeScreenshotOfChangeStatusOfAToiletAsset);
        }


        //Lock/ Unlock a Toilet Asset Step Definitions


        [Given("I take screenshot of toilet Status Unlock")]
        public void GivenITakeScreenshotOfToiletStatusUnlock()
        {
            AllureLogger.LogStep("I take screenshot of toilet Status Unlock",
                pom.TakeScreenshotOfToiletStatusUnlock);
        }


        [Given("I press button Lock\\/Unlock a Toilet Asset")]
        public void GivenIPressButtonLockUnlockAToiletAsset()
        {
            AllureLogger.LogStep("I press button Lock\\/Unlock a Toilet Asset",
            pom.PressButtonLockUnlockAToiletAsset);
        }

        [Given("I enter following Toilet Checker data:")]
        public void GivenIEnterFollowingToiletCheckerData(Table table)
        {
            string Comment = table.Rows[0]["Comment"];
            AllureLogger.LogStep($"I enter following Toilet Checker data: {Comment}", () =>
                pom.EnterFollowingToiletCheckerData(Comment));
        }
        
        [Given("I press ok button")]
        public void GivenIPressOkButton()
        {
            AllureLogger.LogStep("I press ok button",
            pom.PressOkButton);
        }

        [Given("I press dialog button no")]
        public void GivenIPressDialogButtonNo()
        {
            AllureLogger.LogStep("I press dialog button no",
           pom.PressDialogButtonNo);
        }

        [Given("I press dialog button yes")]
        public void GivenIPressDialogButtonYes()
        {
            AllureLogger.LogStep("I press dialog button yes",
           pom.PressDialogButtonYes);
        }

        [Given("I take screenshot of Lock\\/ Unlock a Toilet Asset Test")]
        public void GivenITakeScreenshotOfLockUnlockAToiletAssetTest()
        {
            AllureLogger.LogStep("I take screenshot of Lock\\/ Unlock a Toilet Asset Test",
                 pom.TakeScreenshotOfChangeStatusOfAToiletAsset);
        }



        //Check audit logs Step Definitions

        [Given("I press button View Audit Log")]
        public void GivenIPressButtonViewAuditLog()
        {
            AllureLogger.LogStep("I press button View Audit Log",
           pom.PressButtonViewAuditLog);
        }

        [Given("I take screenshot of Audit Log")]
        public void GivenITakeScreenshotOfAuditLog()
        {
            AllureLogger.LogStep("I take screenshot of Audit Log",
                 pom.TakeScreenshotOfAuditLog);
        }

        [Given("I press OK button")]
        public void GivenIPressOKButton()
        {
            AllureLogger.LogStep("I press OK button",
                    pom.PressOKButton);
        }

        // Audit Log Updates Step Definitions

        [Given("I take screenshot of Audit Log Updates")]
        public void GivenITakeScreenshotOfAuditLogUpdates()
        {
            AllureLogger.LogStep("I take screenshot of Audit Log",
                 pom.TakeScreenshotOfAuditLogUpdates);
        }

        //Update status of  locked Toilet Asset Step Definitions

        [Given("I change toilet asset statuse button")]
        public void GivenIChangeToiletAssetStatuseButton()
        {
            AllureLogger.LogStep("I change toilet asset statuse button",
               pom.ChangeToiletAssetStatuseButton);
        }


        [Given("I press ok dialog system message button")]
        public void GivenIPressOkDialogSystemMessageButton()
        {
            AllureLogger.LogStep("I press ok dialog system message button",
           pom.PressOkDialogSystemMessageButton);
        }

        [Given("I take screenshot of Update status of  locked Toilet Asset Test")]
        public void GivenITakeScreenshotOfUpdateStatusOfLockedToiletAssetTest()
        {
            AllureLogger.LogStep("I take screenshot of Update status of  locked Toilet Asset Test",
                 pom.TakeScreenshotOfUpdateStatusOfLockedToiletAssetTest);
        }


        //Toilet Asset Setup Step Definitions

        [Given("I open application Assets\\(Tr)")]
        public void GivenIOpenApplicationAssetsTr()
        {
            AllureLogger.LogStep("Open [Go To] menu Bar",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Asset Menu Bar",
                pom.OpenAssetMenu);
            AllureLogger.LogStep("Launch application Asset (TR)",
                pom.OpenApplicationAssetTr);
        }

        [Given("I filter table Assets:")]
        public void GivenIFilterTableAssets(Table table)
        {
            string Asset = table.Rows[0]["Asset"];
            AllureLogger.LogStep($"I filter table Assets: {Asset}", () =>
                pom.FilterTableAssets(Asset));
        }
        
        [Given("I select no. {int} record from Assets table records")]
        public void GivenISelectNo_RecordFromAssetsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Location table records",
               () => pom.SelectNoRecordFromAssetsTableRecords(recordNumber));
        }

        [Given("I go to Tab Specifications")]
        public void GivenIGoToTabSpecifications()
        {
            AllureLogger.LogStep("I go to Tab Specifications",
            pom.GoToTabSpecifications);
        }

        [Given("I add new record in Specifications section")]
        public void GivenIAddNewRecordInSpecificationsSection()
        {
            AllureLogger.LogStep("I add new record in Specifications section",
                 pom.AddNewRecordInSpecificationsSection);
        }

        [Given("I open Select Value lookup for attribute field")]
        public void GivenIOpenSelectValueLookupForAttributeField()
        {
            AllureLogger.LogStep("I open Select Value lookup for attribute field",
            pom.OpenSelectValueLookupForAttributeField);
        }

        [Given("I select no. {int} record from attribute table records")]
        public void GivenISelectNo_RecordFromAttributeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from attribute table records",
               () => pom.SelectNoRecordFromAttributeTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup for alphanumeric value field")]
        public void GivenIOpenSelectValueLookupForAlphanumericValueField()
        {
            AllureLogger.LogStep("I open Select Value lookup for alphanumeric value field",
                 pom.OpenSelectValueLookupForAlphanumericValueField);
        }

        [Given("I select no. {int} record from alphanumeric value table records")]
        public void GivenISelectNo_RecordFromAlphanumericValueTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from alphanumeric table records",
               () => pom.SelectNoRecordFromAlphanumericValueTableRecords(recordNumber));
        }

        [Given("I take screenshot of Update status of Toilet Asset Setup Test")]
        public void GivenITakeScreenshotOfUpdateStatusOfToiletAssetSetupTest()
        {

            AllureLogger.LogStep("I take screenshot of Update status of Toilet Asset Setup Test",
                 pom.TakeScreenshotOfUpdateStatusOfToiletAssetSetupTest);
        }

        [Given("I take screenshot of Validate Toilet Asset Setup Test")]
        public void GivenITakeScreenshotOfValidateToiletAssetSetupTest()
        {

            AllureLogger.LogStep("I take screenshot of Validate Toilet Asset Setup Test",
                 pom.TakeScreenshotOfValidateToiletAssetSetupTest);
        }

        //View Clean Master Work orders Step Definitions

        [Given("I refresh Toilet Checker table records")]
        public void GivenIRefreshToiletCheckerTableRecords()
        {
            AllureLogger.LogStep("I refresh Toilet Checker table records",
               pom.RefreshToiletCheckerTableRecords);
        }

        [Given("I select no. {int} record from Toilet Checker table records")]
        public void GivenISelectNo_RecordFromToiletCheckerTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Toilet Checker table records",
               () => pom.SelectNoRecordFromToiletCheckerTableRecords(recordNumber));
        }

        [Given("I select View clean master work orders option")]
        public void GivenISelectViewCleanMasterWorkOrdersOption()
        {
            AllureLogger.LogStep("I select View clean master work orders option",
                pom.ViewCleanMasterWorkOrdersOption);
        }

        [Given("I select complete clean master task button")]
        public void GivenISelectCompleteCleanMasterTaskButton()
        {
            AllureLogger.LogStep("I select complete clean master task button",
              pom.SelectCompleteCleanMasterTaskButton);
        }

        [Given("I take screenshot of View Clean Master Work")]
        public void GivenITakeScreenshotOfViewCleanMasterWork()
        {
            AllureLogger.LogStep("I take screenshot of View Clean Master Work",
                  pom.TakeScreenshotOfViewCleanMasterWork);
        }

        [Given("I press ok")]
        public void GivenIPressOk()
        { 
             AllureLogger.LogStep("I press OK button",
                  pom.PressOk);
        }

        [Given("I take screenshot of View Clean Master Work orders Test")]
        public void GivenITakeScreenshotOfViewCleanMasterWorkOrdersTest()
        {
            AllureLogger.LogStep("I take screenshot of View Clean Master Work orders Test",
                 pom.TakeScreenshotOfViewCleanMasterWorkOrdersTest);
        }






    }
}