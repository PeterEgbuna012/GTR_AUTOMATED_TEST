using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using Reqnroll.Bindings;
using System.Data;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;
using BindingAttribute = Reqnroll.BindingAttribute;
using GivenAttribute = TechTalk.SpecFlow.GivenAttribute;
using PendingStepException = TechTalk.SpecFlow.PendingStepException;
using Table = TechTalk.SpecFlow.Table;
using ThenAttribute = TechTalk.SpecFlow.ThenAttribute;
using WhenAttribute = TechTalk.SpecFlow.WhenAttribute;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public class PMWorkOrderStepDefinitions
    {       
        
            private readonly IWebDriver driver;
            private readonly PMWOPOM pom;

            public PMWorkOrderStepDefinitions(IWebDriver drv)
            {
                driver = drv;
                pom = new PMWOPOM(driver);
            }

        [Given("I sign in as teamlead")]
        public void GivenISignInAsTeamlead()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsMaintainerTeamLeader();
            AllureLogger.SetUserLoginRole("teamlead");
        }


        [When("I open application Preventive Maintenance, Preventative Maintenance \\(BRDA)")]
        public void WhenIOpenApplicationPreventiveMaintenancePreventativeMaintenanceBRDA()
        {
            AllureLogger.LogStep("Open GoTO Menu Bar",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Preventive Maintenance Menu",
                pom.OpenPreventiveMaintenance);
            AllureLogger.LogStep("Launch PreventativeMaintenance (BRDA)",
                pom.OpenPreventativeMaintenanceBRDA);
        }

        [When("I create new record")]
        public void WhenICreateNewRecord()
        {
            AllureLogger.LogStep("I create new record",
              pom.CreateNewRecord);
        }

        [When("I set PM Description field to {string}")]
        public void WhenISetPMDescriptionFieldTo(string text)
        {
            AllureLogger.LogStep($"Set PM description to '{text}'",
              () => SafeActions.EnterText(driver,
                      By.CssSelector("#maa8ad01-tb2"),
                      text,
                      "PM description"));
        }

        [When("I choose Select Value from Detail Menu of Asset Group field")]
        public void WhenIChooseSelectValueFromDetailMenuOfAssetGroupField()
        {
            AllureLogger.LogStep("Detail Menu Of Asset Group Field",
                pom.DetailMenuOfAssetGroupField);
            AllureLogger.LogStep("Select Value Option",
                pom.SelectValueOption);
        }

        [When("I filter table Asset Group:")]
        public void WhenIFilterTableAssetGroup(Table table)
        {
            string assetGroup = table.Rows[0]["Asset Group"];
            AllureLogger.LogStep($"I filter table Asset Group: {assetGroup}", () =>
                pom.FilterByAssetGroup(assetGroup));
        }

        [When("I select no. {int} record from Asset table records")]
        public void WhenISelectNo_RecordFromAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Asset table records",
              () => pom.SelectNoRecordFromAssetTableRecords(recordNumber));
        }

        [When("I set Lead Time Days field to {string}")]
        public void WhenISetLeadTimeDaysFieldTo(string text)
        {
            AllureLogger.LogStep($"Set Lead Time Days to '{text}'",
             () => SafeActions.EnterText(driver,
                     By.CssSelector("#m97f7d5e0-tb"),
                     text,
                     "Lead Time Days"));
        }

        [When("I set Include this PM in the Forecast[Checkbox] field to False")]
        public void WhenISetIncludeThisPMInTheForecastCheckboxFieldToFalse()
        {
            AllureLogger.LogStep("I set Include this PM in the Forecast[Checkbox] field to False",
             pom.SetIncludeThisPMInTheForecastCheckboxFieldToFalse);
        }

        [When("I open Select Value lookup for Work Type field")]
        public void WhenIOpenSelectValueLookupForWorkTypeField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Work Type field",
              pom.OpenSelectValueLookupForWorkTypeField);
        }

        [When("I filter table:")]
        public void WhenIFilterTable(Table table)
        {
            string worktype = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I filter table Work Type: {worktype}", () =>
                pom.FilterTable(worktype));
        }

        [When("I select no.{int} record PM from table")]
        public void WhenISelectNo_RecordPMFromTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from PM table records",
             () => pom.SelectNoRecordPMFromTable(recordNumber));
        }

        [When("I set Priority field to {string}")]
        public void WhenISetPriorityFieldTo(string text)
        {
            AllureLogger.LogStep($"Set Priority to '{text}'",
            () => SafeActions.EnterText(driver,
                    By.CssSelector("#mfdf7abab-tb"),
                    text,
                    "Priority field"));
            
        }

        [When("I set Interruptible [Checkbox] field to true")]
        public void WhenISetInterruptibleCheckboxFieldToTrue()
        {
            AllureLogger.LogStep("I set Interruptible [Checkbox] field to true",
            pom.SetInterruptibleCheckboxFieldToTrue);
        }

        [When("I set Owner Group field to {string}")]
        public void WhenISetOwnerGroupFieldTo(string text)
        {
            AllureLogger.LogStep($"Set  Owner Group to '{text}'",
           () => SafeActions.EnterText(driver,
                   By.CssSelector("#m37a8def-tb"),
                   text,
                   " Owner Group field"));
        }

        [When("I set GL Account field to {string}")]
        public void WhenISetGLAccountFieldTo(string text)
        {
            AllureLogger.LogStep($"Set GL Account to '{text}'",
           () => SafeActions.EnterText(driver,
                   By.CssSelector("#m7dcbf152-tb"),
                   text,
                   "GL Account field"));
        }

        [When("I save record")]
        public void WhenISaveRecord()
        {
            AllureLogger.LogStep("I Save CM Record",
              pom.ISaveCMRecord);
        }

        [When("I press Change Status button")]
        public void WhenIPressChangeStatusButton()
        {
            AllureLogger.LogStep("I press Change Status button",
              pom.PressChangeStatusButton);
        }

        [When("I press the dropdown new status button")]
        public void WhenIPressTheDropdownNewStatusButton()
        {
            AllureLogger.LogStep("I press the dropdown new status button",
             pom.PressTheDropdownNewStatusButton);
        }

        [When("I select active status")]
        public void WhenISelectActiveStatus()
        {
            AllureLogger.LogStep("I select active status",
            pom.SelectActiveStatus);
        }

        [When("I set Roll New Status to All Child PMs[Checkbox] field to True")]
        public void WhenISetRollNewStatusToAllChildPMsCheckboxFieldToTrue()
        {
            AllureLogger.LogStep("I set Roll New Status to All Child PMs [Checkbox] field to true",
            pom.SetRollNewStatusToAllChildPMsCheckboxFieldToTrue);
        }

        [When("I press dialog button OK")]
        public void WhenIPressDialogButtonOK()
        {
            AllureLogger.LogStep("I press dialog button OK",
             pom.PressDialogButtonOK);
        }
                        

        [Then("field Status has value ACTIVE")]
        public void ThenFieldStatusHasValueACTIVE()
        {
            AllureLogger.LogStep("field Status has value ACTIVE",
              pom.FieldStatusHasValueACTIVE);
        }

        [Then("I take screenshot of Create a PM test")]
        public void ThenITakeScreenshotOfCreateAPMTest()
        {
            AllureLogger.LogStep("I take screenshot of Create a PM test",
                pom.TakeScreenshotOfCreateAPMTest);
        }


        //Generating an Ad Hoc PM Work Order Step Definitions

        [Then("I take screenshot of Generating an Ad Hoc PM Work Order test scenario one")]
        public void ThenITakeScreenshotOfGeneratingAnAdHocPMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Generating an Ad Hoc PM Work Order test scenario one",
               pom.TakeScreenshotOfGeneratingAnAdHocPMWorkOrderTestScenarioone);
        }



        [When("I filter table PMs:")]
        public void WhenIFilterTablePMs(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string parent = table.Rows[0]["Parent"];

            pom.FilterPMTable(description, status, parent);
        }

        [When("I select no. {int} record from PMs table")]
        public void WhenISelectNo_RecordFromPMsTable(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from PMs table records",
            () => pom.SelectNo_RecordFromPMsTable(recordNumber));
        }

        [When("I select action Generate Work Orders")]
        public void WhenISelectActionGenerateWorkOrders()
        {
            AllureLogger.LogStep("select action",
               pom.SelectAction);

            AllureLogger.LogStep("Generate Work Orders",
              pom.GenerateWorkOrders);
        }

        [When("I set Use Frequency Criteria[Checkbox] field to false")]
        public void WhenISetUseFrequencyCriteriaCheckboxFieldToFalse()
        {
            AllureLogger.LogStep("I set Use Frequency Criteria [Checkbox] field to false",
           pom.SetUseFrequencyCriteriaCheckboxFieldToFalse);
        }
        
        [When("I press the button OK")]
        public void WhenIPressTheButtonOK()
        {
            AllureLogger.LogStep("I press the button OK",
             pom.PressTheButtonOK);
        }

        [When("the message appears BMXAA{int}I")]
        public void WhenTheMessageAppearsBMXAAI(int BMXAA3208I)
        {
            AllureLogger.LogStep($"Verify message popup appears with code BMXAA{BMXAA3208I}I", () =>
            {
                pom.MessageAppearsBMXAAI($"BMXAA{BMXAA3208I}I");
            });
        }
                     

        [When("I press the button Ok")]
        public void WhenIPressTheButtonOk()
        {
            AllureLogger.LogStep("I press the button OK",
             pom.PressTheButtonOk);
        }

        [When("I take screenshot of Generating an Ad Hoc PM Work Order test scenario two")]
        public void WhenITakeScreenshotOfGeneratingAnAdHocPMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Generating an Ad Hoc PM Work Order test scenario two",
               pom.TakeScreenshotOfGeneratingAnAdHocPMWorkOrderTestScenarioTwo);
        }


        // Assigning a PM Work Order Task Step Definitions


        [When("I filter table PM:")]
        public void WhenIFilterTablePM(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string workType = table.Rows[0]["Work Type"]; 

            pom.FilterTablePM(description, status, workType);
        }
        
        [When("I go to Assignments Tab")]
        public void WhenIGoToAssignmentsTab()
        {
            AllureLogger.LogStep("I go to Assignments Tab",
            pom.GoToAssignmentsTab);
        }

        [When("I add new row in Assignments Tab")]
        public void WhenIAddNewRowInAssignmentsTab()
        {
            AllureLogger.LogStep("I add new row in Assignments Tab",
             pom.AddNewRowInAssignmentsTab);
        }

        [When("I open Select Value lookup for Labor field")]
        public void WhenIOpenSelectValueLookupForLaborField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Labor field",
             pom.SelectValueLookupForLaborField);
        }

        [When("I set {string} as Labor")]
        public void WhenISetAsLabor(string text)
        {
            AllureLogger.LogStep($"I set Labor to '{text}'", () =>
            {
                By laborFilterLocator = By.CssSelector("#m825a12a1_tfrow_\\[C\\:0\\]_txt-tb");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement laborField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(laborFilterLocator));

                laborField.Click();
                laborField.Clear();
                laborField.SendKeys(text);
                laborField.SendKeys(Keys.Enter);
            });
        }

        [When("I select no. {int} record from Labor table records")]
        public void WhenISelectNo_RecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Labor table records",
           () => pom.SelectNoRecordFromLaborTableRecords(recordNumber));
        }

        [When("I select no. {int} from Labor table records")]
        public void WhenISelectNo_FromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Labor table records",
          () => pom.SelectNoFromLaborTableRecords(recordNumber));
        }


        [Then("I take screenshot of Assigning a PM Work Order Task Scenario one")]
        public void ThenITakeScreenshotOfAssigningAPMWorkOrderTaskScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a PM Work Order Task Scenario one",
                pom.TakeScreenshotOfAssigningAPMWorkOrderTaskScenarioOne);
        }

        [When("I take screenshot of Assigning a PM Work Order Task Scenario two")]
        public void WhenITakeScreenshotOfAssigningAPMWorkOrderTaskScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a PM Work Order Task Scenario two",
                pom.TakeScreenshotOfAssigningAPMWorkOrderTaskScenarioTwo);
        }

        [When("I take screenshot of Assigning a PM Work Order Task Scenario three")]
        public void WhenITakeScreenshotOfAssigningAPMWorkOrderTaskScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a PM Work Order Task Scenario three",
                 pom.TakeScreenshotOfAssigningAPMWorkOrderTaskScenarioThree);
        }


        //Complete a PM Work Order Task Step Definitions


        [Then("I take screenshot of Complete a PM Work Order Task scenario one")]
        public void ThenITakeScreenshotOfCompleteAPMWorkOrderTaskScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Complete a PM Work Order Task scenario one",
                pom.TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioOne);
        }

        [When("I take screenshot of Complete a PM Work Order Task Scenario two")]
        public void WhenITakeScreenshotOfCompleteAPMWorkOrderTaskScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Complete a PM Work Order Task Scenario two",
                pom.TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioTwo);
        }

        [When("I take screenshot of Complete a PM Work Order Task Scenario three")]
        public void WhenITakeScreenshotOfCompleteAPMWorkOrderTaskScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Complete a PM Work Order Task Scenario three",
                pom.TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioThree);
        }

        [When("I press route the workflow button")]
        public void WhenIPressRouteTheWorkflowButton()
        {
            AllureLogger.LogStep("I press route the workflow button",
           pom.PressRouteTheWorkflowButton);
        }

        [When("I set \\(Radio) field to Start Work order")]
        public void WhenISetRadioFieldToStartWorkOrder()
        {
            AllureLogger.LogStep("I set (Radio) field to Start Work order",
           pom.SetRadioFieldToStartWorkOrder);
        }

        [When("I press Ok dialog button")]
        public void WhenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I press Ok dialog button",
           pom.PressOkDialogButton);
        }

        [When("I return to Maintainer Start Center")]
        public void WhenIReturnToMaintainerStartCenter()
        {
            AllureLogger.LogStep("I return to Maintainer Start Center",
           pom.ReturnToMaintainerStartCenter);
        }

        [When("I open application Work Order Tracking BRDA from Favorite Menu")]
        public void WhenIOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu()
        {
            AllureLogger.LogStep("I open application Work Order Tracking BRDA from Favorite Menu",
              pom.IOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu);
        }

        [When("I set \\(Radio) field to Complete Work Assignment")]
        public void WhenISetRadioFieldToCompleteWorkAssignment()
        {
            AllureLogger.LogStep("I set (Radio) field to Complete Work Assignment",
            pom.SetRadioFieldToCompleteWorkAssignment);
        }

        [When("I press dialog button Ok")]
        public void WhenIPressDialogButtonOk()
        {
            AllureLogger.LogStep("I press Ok dialog button",
           pom.PressDialogButtonOk);
        }

        [When("I press dialog button Close")]
        public void WhenIPressDialogButtonClose()
        {
            AllureLogger.LogStep("I press dialog button Close",
            pom.PressDialogButtonClose);
        }

        [When("I go to Tab actuals")]
        public void WhenIGoToTabActuals()
        {
            AllureLogger.LogStep("I go to Tab actuals",
            pom.GoToTabActuals);
        }

        [When("I add new row in Labor Tab")]
        public void WhenIAddNewRowInLaborTab()
        {
            AllureLogger.LogStep("I add new row in Labor Tab",
             pom.AddNewRowInLaborTab);
        }

        [When("I choose select Value from Detail Menu of Labor field")]
        public void WhenIChooseSelectValueFromDetailMenuOfLaborField()
        {
            AllureLogger.LogStep("I select value of labor field",
              pom.SelectValueOfLaborField);

            AllureLogger.LogStep("I select detail menu of labor field",
               pom.ChooseDetailMenuOfLaborField);
        }

        [When("I filter table Labor:")]
        public void WhenIFilterTableLabor(Table table)
        {
            string Labor = table.Rows[0]["Labor"];
            AllureLogger.LogStep($"I filter table Labor: {Labor}", () =>
                pom.FilterTableLabor(Labor));
        }

        [When("I set Start and End time")]
        public void WhenISetStartAndEndTime()
        {
            AllureLogger.LogStep("I select Start and End time",
              pom.ISetStartAndEndTime);
        }

        [Then("Status field has value COMP-WREV")]
        public void ThenStatusFieldHasValueCOMP_WREV()
        {
            AllureLogger.LogStep("Status field has value COMP-WREV",
              pom.StatusFieldHasValueCOMP_WREV);
        }

        [Then("I take screenshot of Complete a PM Work Order Task scenario four")]
        public void ThenITakeScreenshotOfCompleteAPMWorkOrderTaskScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Complete a PM Work Order Task scenario four",
                 pom.TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioFour);
        }


        //Approve a PM Work Order Task Step Definitions

        [Then("I take screenshot of Approve a PM Work Order Task scenario one")]
        public void ThenITakeScreenshotOfApproveAPMWorkOrderTaskScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Approve a PM Work Order Task scenario one",
                pom.TakeScreenshotOfApproveAPMWorkOrderTaskScenarioOne);
        }

        [When("I take screenshot of Approve a PM Work Order Task Scenario two")]
        public void WhenITakeScreenshotOfApproveAPMWorkOrderTaskScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Approve a PM Work Order Task Scenario two",
                pom.TakeScreenshotOfApproveAPMWorkOrderTaskScenariotwo);
        }

        [When("I take screenshot of Approve a PM Work Order Task Scenario three")]
        public void WhenITakeScreenshotOfApproveAPMWorkOrderTaskScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Approve a PM Work Order Task scenario three",
               pom.TakeScreenshotOfApproveAPMWorkOrderTaskScenariothree);
        }

        [Then("I take screenshot of Approve a PM Work Order Task scenario four")]
        public void ThenITakeScreenshotOfApproveAPMWorkOrderTaskScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Approve a PM Work Order Task scenario four",
               pom.TakeScreenshotOfApproveAPMWorkOrderTaskScenariofour);
        }

        [When("I set \\(Radio) field Approve Work")]
        public void WhenISetRadioFieldApproveWork()
        {
            AllureLogger.LogStep("I set (Radio) field Approve Work",
           pom.SetRadioFieldApproveWork);
        }

        [When("I press OK dialog button")]
        public void WhenIPressOKDialogButton()
        {
            AllureLogger.LogStep("I press OK dialog button",
            pom.PressOKDialogButton);
        }


        [When("Status field has value COMP")]
        public void WhenStatusFieldHasValueCOMP()
        {
            AllureLogger.LogStep("Status field has value COMP",
             pom.StatusFieldHasValueCOMP);
        }

        [When("I take screenshot of Approve a PM Work Order Task test scenario five")]
        public void WhenITakeScreenshotOfApproveAPMWorkOrderTaskTestScenarioFive()
        {
            AllureLogger.LogStep("I take screenshot of Approve a PM Work Order Task scenario five",
              pom.TakeScreenshotOfApproveAPMWorkOrderTaskScenariofive);
        }





    }
}