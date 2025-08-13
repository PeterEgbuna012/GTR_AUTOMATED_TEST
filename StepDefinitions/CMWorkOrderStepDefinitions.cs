using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Reqnroll;
using Reqnroll.Bindings;
using System.Collections.Generic;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;
using BindingAttribute = TechTalk.SpecFlow.BindingAttribute;
using GivenAttribute = TechTalk.SpecFlow.GivenAttribute;
using Table = TechTalk.SpecFlow.Table;
using ThenAttribute = TechTalk.SpecFlow.ThenAttribute;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public class CMWorkOrderStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly CMWOPOM pom;

        public CMWorkOrderStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new CMWOPOM(driver);
        }

        [Given("I sign as maxadmin")]
        public void GivenISignInAsMaxadmin() =>
        AllureLogger.LogStep("Sign in as maxadmin", () =>
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsMaxAdmin();
            AllureLogger.SetUserLoginRole("maxadmin");
        });

        
        [Given("I sign as teamlead")]
        public void GivenISignAsTeamlead()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsMaintainerTeamLeader();
            AllureLogger.SetUserLoginRole("teamlead");
        }

        [Given("I sign as maintainer teamlead")]
        public void GivenISignAsMaintainerTeamlead()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsTeamLeaderMaintainer();
            AllureLogger.SetUserLoginRole("maintainer teamlead");
        }


        [Given("I open application Work Order Tracking \\(BRDA)")]
        public void GivenIOpenApplicationWorkOrderTrackingBRDA()
        {
            AllureLogger.LogStep("Open Work Order Tracking (BRDA)",
                pom.OpenGoToMenu);   
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Tracking screen",
                pom.OpenWorkOrderTrackingBRDA);
        }

        [Given("I select create new record")]
        public void GivenISelectCreateNewRecord()
        {
            AllureLogger.LogStep("Click [New Record]",
                 pom.ClickCreateNewRecord);
        }

        
        [Given("I choose Select Value from Detail Menu of Location field")]
        public void GivenIChooseSelectValueFromDetailMenuOfLocationField()
        {
            AllureLogger.LogStep("Detail Menu Of Location Field",
                 pom.DetailMenuOfLocationField);
            AllureLogger.LogStep("Select Value Option",
                pom.SelectValueOption);
        }
        
        [Given("I filter table Location:")]
        public void GivenIFilterTableLocation(Table table)
        {
            string location = table.Rows[0]["Location"];
            AllureLogger.LogStep($"I filter table Location: {location}", () =>
                pom.FilterTableLocation(location));
        }

        [Given("I select no. {int} from Location table records")]
        public void GivenISelectNo_FromLocationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from Location table records",
              () => pom.SelectNoFromLocationTableRecords(recordNumber));
        }
                      

        [Given("I select no. {int} record from Location table records")]
        public void GivenISelectNo_RecordFromLocationTableRecords(int recordNumber)
        {

            AllureLogger.LogStep($"I select no.{recordNumber} record from Location table records",
              () => pom.ISelectNo_RecordFromLocationTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup for Work Type field")]
        public void GivenIOpenSelectValueLookupForWorkTypeField()
        {
            AllureLogger.LogStep("I Select Value lookup for Work Type field",
                pom.SelectValueLookupForWorkTypeField);
        }

        [Given("I filter table Work Type:")]
        public void GivenIFilterTableWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Type"];
            AllureLogger.LogStep($"I filter table Work Type: {WorkType}", () =>
                pom.FilterTableWorkType(WorkType));
        }

        [Given("I select no. {int} from Work Type table records")]
        public void GivenISelectNo_FromWorkTypeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Type table records",
            () => pom.SelectNoFromWorkTypeTableRecords(recordNumber));
        }



        [Given("I choose Select Value from Detail Menu of Repair Facility")]
        public void GivenIChooseSelectValueFromDetailMenuOfRepairFacility()
        {
            AllureLogger.LogStep("Detail Menu Of Repair Facility",
                  pom.DetailMenuOfRepairFacility);
            AllureLogger.LogStep("Select Value Option Of Repair Facility",
                pom.SelectValueOptionOfRepairFacility);
        }

        [Given("I filter table Repair Facility:")]
        public void GivenIFilterTableRepairFacility(Table table)
        {
            string RepairFacility = table.Rows[0]["Repair Facility"];
            AllureLogger.LogStep($"I filter table Repair Facility: {RepairFacility}", () =>
                pom.FilterTableRepairFacility(RepairFacility));
        }
                      

        [Given("I select no. {int} record from Repair Facility table records")]
        public void GivenISelectNo_RecordFromRepairFacilityTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Location table records",
              () => pom.ISelectNo_RecordFromRepairFacilityTableRecords(p0));
        }

        [Given("I open Select Value lookup for Priority field")]
        public void GivenIOpenSelectValueLookupForPriorityField()
        {
            AllureLogger.LogStep("I Select Value lookup for Work Type field",
               pom.OpenSelectValueLookupForPriorityField);
        }

        [Given("I filter table Priority field:")]
        public void GivenIFilterTablePriorityField(Table table)
        {
            string RepairFacility = table.Rows[0]["Value"];
            AllureLogger.LogStep($"I filter table Priority: {RepairFacility}", () =>
                pom.FilterTablePriorityField(RepairFacility));
        }
                       

        [Given("I select no. {int} record from Priority table records")]
        public void GivenISelectNo_RecordFromPriorityTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Priority table records",
             () => pom.GivenISelectPriority(p0));
        }
        
        [Given("I Scheduled Start Date to today's date")]
        public void GivenIScheduledStartDateToTodaysDate()
        {
            AllureLogger.LogStep("I Set Scheduled Start",
                pom.SetScheduledStart);
        }


        [Given("I save CM record")]
        public void GivenISaveCMRecord()
        {
            AllureLogger.LogStep("I Save CM Record",
               pom.ISaveCMRecord);
        }

        [Given("I verify CM work order generated")]
        public void GivenIVerifyCMWorkOrderGenerated()
        {

            AllureLogger.LogStep("I Verify Generated Work Order Number",
               pom.VerifyCMWorkOrderGenerated);
        }


        [Given("I verify generated work order number")]
        public void GivenIVerifyGeneratedWorkOrderNumber()
        {
            AllureLogger.LogStep("I Verify Generated Work Order Number",
               pom.VerifyGeneratedWorkOrderNumber);
        }

        [Given("I take screenshot of Assigning a CM Work Order Test Scenario one")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a CM Work Order Test Scenario one",
               pom.TakeScreenshotOfAssigningACMWorkOrderTestScenarioOne);
        }

        [Given("I take screenshot of Assigning a CM Work Order Test Scenario two")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Assigning a CM Work Order Test Scenario two",
               pom.TakeScreenshotOfAssigningACMWorkOrderTestScenariotwo);
        }


        [Given("I take screenshot of Create a CM Work Order test")]
        public void GivenITakeScreenshotOfCreateACMWorkOrderTest()
        {
            AllureLogger.LogStep("I Take Screenshot Of Create A CM Work Order Test",
                pom.ITakeScreenshotOfCreateACMWorkOrderTest);
        }


        // Assigning a CM Work Order Step Definitions 

        
        [Given("I open application Work Order Tracking BRDA from Favorite Menu")]
        public void GivenIOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu()
        {
            AllureLogger.LogStep("I open application Work Order Tracking BRDA from Favorite Menu",
               pom.IOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu);
        }
                                

        [Given("I select no. {int} record from CM Work Order table records")]
        public void GivenISelectNo_RecordFromCMWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} from CM Work Order table records",
              () => pom.ISelectCMWorkOrderFromTableRecords(recordNumber));
        }


        [Given("I press route the workflow button")]
        public void GivenIPressRouteTheWorkflowButton()
        {
            AllureLogger.LogStep("I press route the workflow button",
              pom.PressRouteTheWorkflowButton);
        }

        [Given("I set \\(Radio) field to Accept this Work Order into the Work Bank")]
        public void GivenISetRadioFieldToAcceptThisWorkOrderIntoTheWorkBank()
        {
            AllureLogger.LogStep("I set (Radio) field to Accept this Work Order into the Work Bank",
              pom.ISetRadioFieldToAcceptThisWorkOrderIntoTheWorkBank);
        }

        [Given("I select dialog button ok")]
        public void GivenISelectDialogButtonOk()
        {
            AllureLogger.LogStep("I select dialog button ok",
               pom.ISelectDialogButtonOk);
        }

        [Given("I set \\(Radio) field to Send Work for Execution")]
        public void GivenISetRadioFieldToSendWorkForExecution()
        {
            AllureLogger.LogStep("I set (Radio) field to Send Work for Execution",
              pom.ISetRadioFieldToSendWorkForExecution);
        }

        [Given("I select Ok dialog button")]
        public void GivenISelectOkDialogButton()
        {
            AllureLogger.LogStep("I select dialog button ok",
              pom.ISelectOkDialogButton);
        }

        [Given("I go to Assignments Tab")]
        public void GivenIGoToAssignmentsTab()
        {
            AllureLogger.LogStep("I go to Assignments Tab",
             pom.IGoToAssignmentsTab);
        }

        [Given("I add new row in Assignments Tab")]
        public void GivenIAddNewRowInAssignmentsTab()
        {
            AllureLogger.LogStep("I add new row in Assignments Tab",
             pom.AddNewRowInAssignmentsTab);
        }

        [Given("I open Select Value lookup for Labor field")]
        public void GivenIOpenSelectValueLookupForLaborField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Labor field",
             pom.OpenSelectValueLookupForLaborField);
        }

        [Given("I filter table Labor:")]
        public void GivenIFilterTableLabor(Table table)
        {
            string Labor = table.Rows[0]["Labor"];
            AllureLogger.LogStep($"I filter table Labor: {Labor}", () =>
                pom.FilterTableLabor(Labor));
        }
        
        [Given("I select no. {int} record from Labor table records")]
        public void GivenISelectNo_RecordFromLaborTableRecords(int p1)
        {
            AllureLogger.LogStep($"I select no.{p1} record from Labor table records",
              () => pom.ISelectLabor(p1));
        }

        [Given("I pree Ok dialog system message button")]
        public void GivenIPreeOkDialogSystemMessageButton()
        {
            AllureLogger.LogStep("I pree Ok dialog system message button",
                pom.IPreeOkDialogSystemMessageButton);
        }


        [Given("I save record")]
        public void GivenISaveRecord()
        {
            AllureLogger.LogStep("I Save CM Record",
                pom.ISaveRecord);
        }

        [Given("I verify Rejecting an CM Work Order generated number")]
        public void GivenIVerifyRejectingAnCMWorkOrderGeneratedNumber()
        {
            AllureLogger.LogStep("I verify Rejecting an CM Work Order generated number",
               pom.VerifyRejectingAnCMWorkOrderGeneratedNumber);
        }


        [Given("I verify assigned work order details")]
        public void GivenIVerifyAssignedWorkOrderDetails()
        {
            AllureLogger.LogStep("I Verify Generated Work Order Number",
               pom.VerifyAssignedWorkOrderDetails);
        }



        [Given("I take screenshot of Assigning a CM Work Order")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrder()
        {
            AllureLogger.LogStep("I Take Screenshot Of Create A CM Work Order Test",
                pom.ITakeScreenshotOfAssigningACMWorkOrder);
        }


        [Given("I take screenshot of Assigning a CM Work Order test")]
        public void GivenITakeScreenshotOfAssigningACMWorkOrderTest()
        {
            AllureLogger.LogStep("I Take Screenshot Of Create A CM Work Order Test",
                pom.ITakeScreenshotOfAssigningACMWorkOrderTest);
        }

        [Given("I take screenshot of Creating a Found it Fixed it Work Order test Scenario one")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioone()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario one",
               pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioone);
        }


        [Given("I take screenshot of Creating a Found it Fixed it Work Order test Scenario two")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario two",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioTwo);
        }

        [Then("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three")]
        public void ThenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenariothree);
        }


        // Creating a Found it Fixed it Work Order Step Definitions


        [Given("I open application Quick Work Order Tracking \\(BRDA)")]
        public void GivenIOpenApplicationQuickWorkOrderTrackingBRDA()
        {
            AllureLogger.LogStep("Open Work Order Tracking (BRDA)",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Tracking screen",
                pom.QuickWorkOrderTrackingBRDA);
        }

        [Given("I filter table Quick Work Order:")]
        public void GivenIFilterTableQuickWorkOrder(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string workType = table.Rows[0]["Work Type"];
            pom.FilterTableQuickWorkOrder(description, status, workType);
        }

        [Given("I select no. {int} record from Quick Work Order table records")]
        public void GivenISelectNo_RecordFromQuickWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Quick Work Order table records",
              () => pom.SelectNoRecordFromQuickWorkOrderTableRecords(recordNumber));
        }



        [Given("I set \\(Radio) field to Start Work order")]
        public void GivenISetRadioFieldToStartWorkOrder()
        {
            AllureLogger.LogStep("I set (Radio) field to Start Work order",
                pom.ISetRadioFieldToStartWorkOrder);
        }

        [Given("I select Ok button")]
        public void GivenISelectOkButton()
        {
            AllureLogger.LogStep("I select Ok button",
                pom.SelectOkButton);
        }

        [Given("I select action")]
        public void GivenISelectAction()
        {
            AllureLogger.LogStep("I select action",
                pom.SelectAction);
        }

        [Given("I select Create Work Order")]
        public void GivenISelectCreateWorkOrder()
        {
            AllureLogger.LogStep("I select Create Work Order",
                pom.SelectCreateWorkOrder);
        }

        [Given("I Select Value lookup for Work Type field")]
        public void GivenISelectValueLookupForWorkTypeField()
        {
            AllureLogger.LogStep("I Select Value lookup for Work Type",
                pom.SelectValueLookupForWorkType);
        }

        [Given("I filter table Follow on Work Type:")]
        public void GivenIFilterTableFollowOnWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Type"];
            AllureLogger.LogStep($"I filter table Follow on Work Type: {WorkType}", () =>
                pom.FilterTableFollowOnWorkType(WorkType));
        }
                    

        [Given("I select no. {int} record from Work Type table records")]
        public void GivenISelectNo_RecordFromWorkTypeTableRecords(int recordNumber)
        {

            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Type table records",
             () => pom.SelectNoRecordFromWorkTypeTableRecords(recordNumber));
                        
        }



        [Given("the record is saved successfully")]
        public void GivenTheRecordIsSavedSuccessfully()
        {
            AllureLogger.LogStep("the record is saved successfully",
               pom.TheRecordIsSavedSuccessfully);
        }

        [Given("I go to labour Tab")]
        public void GivenIGoToLabourTab()
        {
            AllureLogger.LogStep("I go to labour Tab",
                pom.GoToLabourTab);
        }

        [Given("I press new row under Labor Tab")]
        public void GivenIPressNewRowUnderLaborTab()
        {
            AllureLogger.LogStep("I press new row under Labor Tab",
                pom.PressNewRowUnderLaborTab);
        }

        [Given("I Select Value from Detail Menu of Labor field")]
        public void GivenISelectValueFromDetailMenuOfLaborField()
        {
            AllureLogger.LogStep("I Select Value from Detail Menu of Labor field",
                pom.SelectValueFromDetailMenuOfLaborField);
        }
        

        [Given("I select no. {int} record from table records")]
        public void GivenISelectNo_RecordFromTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Labor table records",
              () => pom.SelectNo_RecordFromTableRecords(p0));
        }

        [Given("I select Start and End time")]
        public void GivenISelectStartAndEndTime()
        {
            AllureLogger.LogStep("I select Start and End time",
              pom.SelectStartAndEndTime);
        }

        [Then("the record is saved successfully")]
        public void ThenTheRecordIsSavedSuccessfully()
        {
            AllureLogger.LogStep("the record is saved successfully",
               pom.TheRecordIsSavedSuccessfully);
        }

        [Then("I go to failure reporting tab")]
        public void ThenIGoToFailureReportingTab()
        {
            AllureLogger.LogStep("I go to failure reporting tab",
              pom.GoToFailureReportingTab);
        }

        [Then("I press the button select Failure Codes")]
        public void ThenIPressTheButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button select Failure Codes",
              pom.PressTheButtonSelectFailureCodes);
        }

        [Then("I filter table Follow on Failure Codes:")]
        public void ThenIFilterTableFollowOnFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFollowOnFailureCodes(FailureCodes));
        }

        
        [Then("I select faliure codes")]
        public void ThenISelectFaliureCodes()
        {
            AllureLogger.LogStep("I select faliure codes",
             pom.SelectFaliureCodes);
        }

        [Then("I select problem codes")]
        public void ThenISelectProblemCodes()
        {
            AllureLogger.LogStep("I select problem codes",
             pom.SelectProblemCodes);
        }

        [Then("I select cause codes")]
        public void ThenISelectCauseCodes()
        {
            AllureLogger.LogStep("I select cause codes",
             pom.SelectCauseCodes);
        }

        [Then("I select remedy codes")]
        public void ThenISelectRemedyCodes()
        {
            AllureLogger.LogStep("I select remedy codes",
            pom.SelectRemedyCodes);
        }

        [Then("I go to Log tab")]
        public void ThenIGoToLogTab()
        {
            AllureLogger.LogStep("I go to Log tab",
           pom.GoToLogtab);
        }
              

        [Then("I press add new row under Log")]
        public void ThenIPressAddNewRowUnderLog()
        {
            AllureLogger.LogStep("I press add new row under Log",
           pom.PressAddNewRowUnderLog);
        }
        
        [Then("I press route the workflow button")]
        public void ThenIPressRouteTheWorkflowButton()
        {
            AllureLogger.LogStep("I press route the workflow button",
              pom.PressRouteTheWorkflowButton);
        }

        [Then("I select \\(Radio) field Complete Work Assignment")]
        public void ThenISelectRadioFieldCompleteWorkAssignment()
        {
            AllureLogger.LogStep("I select (Radio) field Complete Work Assignment",
             pom.SelectRadioFieldCompleteWorkAssignment);
        }

        [Then("I press ok dialog button")]
        public void ThenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I press ok dialog button",
              pom.PressOkDialogButton);
        }

        [Then("I verify COMP-WREV Status")]
        public void ThenIVerifyCOMPWREVStatus()
        {
            AllureLogger.LogStep("I verify COMP-WREV Status",
               pom.VerifyCOMPWREVStatus);
        }


        //Creating a Found it Fixed it Work Order Step Definitions


       
        [Given("I take screenshot of Creating a Found it Fixed it Work Order Scenario one")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario one",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioOne);
        }

        [Given("I filter table CM Work Order:")]
        public void GivenIFilterTableCMWorkOrder(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            pom.FilterTableCMWorkOrder(description, status);
        }
                     

        [Given("I take screenshot of Creating a Found it Fixed it Work Order Scenario two")]
        public void GivenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario two",
               pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariotwo);
        }

        [Given("I go to failure reporting tab")]
        public void GivenIGoToFailureReportingTab()
        {
            AllureLogger.LogStep("I go to failure reporting tab",
               pom.GoToFailureReportingTab);
        }

        [Given("I press the button select Failure Codes")]
        public void GivenIPressTheButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button select Failure Codes",
              pom.PressTheButtonSelectFailureCodes);
        }

        [Given("I filter table Follow on Failure Codes:")]
        public void GivenIFilterTableFollowOnFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFollowOnFailureCodes(FailureCodes));
        }
                       

        [Given("I select faliure codes")]
        public void GivenISelectFaliureCodes()
        {
            AllureLogger.LogStep("I select faliure codes",
             pom.SelectFaliureCodes);
        }

        [Given("I select problem codes")]
        public void GivenISelectProblemCodes()
        {
            AllureLogger.LogStep("I select problem codes",
             pom.SelectProblemCodes);
        }

        [Given("I select cause codes")]
        public void GivenISelectCauseCodes()
        {
            AllureLogger.LogStep("I select cause codes",
            pom.SelectCauseCodes);
        }

        [Given("I select remedy codes")]
        public void GivenISelectRemedyCodes()
        {
            AllureLogger.LogStep("I select remedy codes",
           pom.SelectRemedyCodes);
        }

        [Given("I go to Log")]
        public void GivenIGoToLog()
        {
            AllureLogger.LogStep("I go to Log tab",
          pom.GoToLogtab);
        }

        [Given("I press add new row under Log")]
        public void GivenIPressAddNewRowUnderLog()
        {
            AllureLogger.LogStep("I press add new row under Log",
           pom.PressAddNewRowUnderLog);
        }

        [Given("I enter following data:")]
        public void GivenIEnterFollowingData(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];


            pom.EnterFollowingData(Summary, Details);
        }

        [Given("I filter table work Log:")]
        public void GivenIFilterTableWorkLog(Table table)
        {
            string workLogType = table.Rows[0]["Value"];
            AllureLogger.LogStep($"I filter table work Log Type: {workLogType}", () =>
                pom.FilterTableWorkLog(workLogType));
        }

        [Given("I select no. {int} record from work Log table records")]
        public void GivenISelectNo_RecordFromWorkLogTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Type table records",
             () => pom.SelectNoRecordFromWorkLogTableRecords(recordNumber));
        }



        [Given("I open Select Value lookup of Type")]
        public void GivenIOpenSelectValueLookupOfType()
        {
            AllureLogger.LogStep("I open Select Value lookup of Type",
                pom.SelectValueLookupOfType);
        }
               
        [Given("I Select UPDATE")]
        public void GivenISelectUPDATE()
        {
            AllureLogger.LogStep("I Select Drop Down Menu Button",
                  pom.DropdownMenu);
            AllureLogger.LogStep("I Select Drop Down Menu Button",
                pom.SelectUPDATE);
        }

        [Given("Work log Status field has value UPDATE")]
        public void GivenWorkLogStatusFieldHasValueUPDATE()
        {
            AllureLogger.LogStep("Work log Status field has value UPDATE",
               pom.LogStatusFieldHasValueUPDATE);
        }

        [Then("I take screenshot of Creating a Found it Fixed it Work Order Scenario three")]
        public void ThenITakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a Found it Fixed it Work Order test Scenario three",
                pom.TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariothree);
        }



        // Completing a CM Work Order for Review Step Definitions


        [Given("I take screenshot of Completing a CM Work Order for Review test Scenario two")]
        public void GivenITakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario two",
                pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioTwo);
        }

        [Given("I take screenshot of Completing a CM Work Order for Review test Scenario one")]
        public void GivenITakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario one",
                pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioone);
        }

        [Given("I filter table CM:")]
        public void GivenIFilterTableCM(Table table)
        {
            string description = table.Rows[0]["Description"];
            string status = table.Rows[0]["Status"];
            string workType = table.Rows[0]["Work Type"];

            pom.FilterTableCM(description, status, workType);
        }
                      

        [Given("I select \\(Radio) Box Complete Work Assignment")]
        public void GivenISelectRadioBoxCompleteWorkAssignment()
        {
            AllureLogger.LogStep("I select (Radio) Box Complete Work Assignment",
             pom.SelectRadioBoxCompleteWorkAssignment);
        }

        [Given("I press the button Ok")]
        public void GivenIPressTheButtonOk()
        {
            AllureLogger.LogStep("I press the button Ok",
               pom.PressTheButtonOk);
        }

        [Given("I press the button Close")]
        public void GivenIPressTheButtonClose()
        {
            AllureLogger.LogStep("I press the button Close",
               pom.PressTheButtonClose);
        }

        [Given("I go to actuals Tab")]
        public void GivenIGoToActualsTab()
        {
            AllureLogger.LogStep("I go to actuals Tab",
               pom.GoToActualsTab);
        }

        [Given("I select new row under labor section")]
        public void GivenISelectNewRowUnderLaborSection()
        {
            AllureLogger.LogStep("I select new row under labor section",
               pom.SelectNewRowUnderLaborSection);
        }

        [Given("I choose select value from detail menu of labor field")]
        public void GivenIChooseSelectValueFromDetailMenuOfLaborField()
        {
            AllureLogger.LogStep("I select value of labor field",
               pom.SelectValueOfLaborField);

            AllureLogger.LogStep("I select detail menu of labor field",
               pom.ChooseDetailMenuOfLaborField);
        }

        [Given("I filter table actuals labor:")]
        public void GivenIFilterTableActualsLabor(Table table)
        {
            string Labor = table.Rows[0]["Labor"];
            AllureLogger.LogStep($"I filter table actuals Labor: {Labor}", () =>
                pom.FilterTableActualsLabor(Labor));
        }


        [Given("I select no. {int} record from Labor table record")]
        public void GivenISelectNo_RecordFromLaborTableRecord(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Labor table records",
              () => pom.SelectLabor(p0));
        }

        [Given("I set Start and End time")]
        public void GivenISetStartAndEndTime()
        {
            AllureLogger.LogStep("I select Start and End time",
             pom.ISetStartAndEndTime);
        }

        [Then("I go to Failure Reporting")]
        public void ThenIGoToFailureReporting()
        {
            AllureLogger.LogStep("I go to failure reporting",
              pom.GoToFailureReporting);
        }

        [Then("I press dialog button Select Failure Codes")]
        public void ThenIPressDialogButtonSelectFailureCodes()
        {
            AllureLogger.LogStep("I press the button select Failure Codes",
             pom.PressDialogButtonSelectFailureCodes);
        }

        [Then("I filter table Failure Codes:")]
        public void ThenIFilterTableFailureCodes(Table table)
        {
            string FailureCodes = table.Rows[0]["Failure Codes"];
            AllureLogger.LogStep($"I filter table Failure Codes: {FailureCodes}", () =>
                pom.FilterTableFailureCodes(FailureCodes));
        }
                       

        [Then("I select Faliure Informations")]
        public void ThenISelectFaliureInformations()
        {
            AllureLogger.LogStep("I select Failure Codes",
           pom.FailureCodes);

            AllureLogger.LogStep("I select problem codes",
            pom.ProblemCodes);

            AllureLogger.LogStep("I select cause codes",
             pom.CauseCodes);

            AllureLogger.LogStep("I select remedy codes",
           pom.RemedyCodes);
        }

        [Then("I go to tab Log")]
        public void ThenIGoToTabLog()
        {
            AllureLogger.LogStep("I go to Log tab",
             pom.GoToTabLog);
        }

        [Then("I press add new row button under Log section")]
        public void ThenIPressAddNewRowButtonUnderLogSection()
        {
            AllureLogger.LogStep("I press add new row under Log",
          pom.AddNewRowButtonUnderLogSection);
        }

        [Then("I enter following data:")]
        public void ThenIEnterFollowingData(Table table)
        {
            string Summary = table.Rows[0]["Summary"];
            string Details = table.Rows[0]["Details"];


            pom.EnterFollowingData(Summary, Details);
        }



        [Then("I set [Radio] Box to Complete Work Assignment")]
        public void ThenISetRadioBoxToCompleteWorkAssignment()
        {
            AllureLogger.LogStep("I select (Radio) Box Complete Work Assignment",
            pom.SetRadioBoxToCompleteWorkAssignment);
        }

        [Then("I press the button Ok")]
        public void ThenIPressTheButtonOk()
        {
            AllureLogger.LogStep("I press ok dialog button",
               pom.IPressTheButtonOk);
        }

        [Then("work order Status field has value COMP-WREV")]
        public void ThenWorkOrderStatusFieldHasValueCOMPWREV()
        {
            AllureLogger.LogStep("I verify COMP-WREV Status",
               pom.WorkOrderStatusFieldHasValueCOMPWREV);
        }

        [Then("I take screenshot of Completing a CM Work Order for Review test Scenario three")]
        public void ThenITakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioThree);
        }



        //Rejecting an CM Work Order Step Definitions


        [Given("I take screenshot of Rejecting an CM Work Order test Scenario one")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfRejectingAnCMWorkOrderTestScenarioOne);
        }
                

        [Given("I take screenshot of Rejecting an CM Work Order test Scenario two")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfRejectingAnCMWorkOrderTestScenariotwo);
        }

        [Then("I take screenshot of Rejecting an CM Work Order test Scenario three")]
        public void ThenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario three",
                pom.TakeScreenshotOfRejectingAnCMWorkOrderTestScenariothree);
        }
    
        [Given("I set \\(Radio) Box to Reject Work")]
        public void GivenISetRadioBoxToRejectWork()
        {
            AllureLogger.LogStep("I set (Radio) field to Reject Work order",
                pom.SetRadioBoxToRejectWork);
        }

        [Given("I press dialog button ok")]
        public void GivenIPressDialogButtonOk()
        {
            AllureLogger.LogStep("I select dialog button ok",
             pom.PressDialogButtonOk);
        }

        [Given("work order Status field has value INPRG-HOLD")]
        public void GivenWorkOrderStatusFieldHasValueINPRG_HOLD()
        {
            AllureLogger.LogStep("work order Status field has value INPRG-HOLD",
               pom.StatusFieldHasValueINPRG_HOLD);
        }

        [Given("I verify generated Rejectd work order number")]
        public void GivenIVerifyGeneratedRejectdWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify generated Rejectd work order number",
               pom.VerifyGeneratedRejectdWorkOrderNumber);
        }

        [Given("I return to Maintainer Start Center")]
        public void GivenIReturnToMaintainerStartCenter()
        {
            AllureLogger.LogStep("I return to Maintainer Start Center",
             pom.ReturnToMaintainerStartCenter);
        }

        [Given("I take screenshot of Rejecting an CM Work Order test Scenario four")]
        public void GivenITakeScreenshotOfRejectingAnCMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Completing a CM Work Order for Review test Scenario four",
               pom.TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenariofour);
        }





        //Approving an CM Work Order Step Definitions


        [Given("I take screenshot of Approving an CM Work Order test Scenario one")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario one",
              pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenarioOne);
        }

        [Given("I verify Approving an CM Work Order generated number")]
        public void GivenIVerifyApprovingAnCMWorkOrderGeneratedNumber()
        {
            AllureLogger.LogStep("I verify Approving an CM Work Order generated number",
               pom.VerifyApprovingAnCMWorkOrderGeneratedNumber);
        }

        [Given("I take screenshot of Approving an CM Work Order test Scenario two")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario two",
               pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenariotwo);
        }

        [Then("I take screenshot of Approving an CM Work Order test Scenario three")]
        public void ThenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario three",
               pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenariothree);
        }


        [Given("I set \\(Radio) Box to Approve Work Order")]
        public void GivenISetRadioBoxToApproveWorkOrder()
        {
            AllureLogger.LogStep("I set (Radio) field to Approve Work order",
                pom.SetRadioBoxToApproveWorkOrder);
        }

        [Given("work order Status field has value COMP")]
        public void GivenWorkOrderStatusFieldHasValueCOMP()
        {
            AllureLogger.LogStep("work order Status field has value COMP",
              pom.WorkOrderStatusFieldHasValueCOMP);
        }

        [Given("I verify generated Approved work order number")]
        public void GivenIVerifyGeneratedApprovedWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify generated Approved work order number",
                pom.IVerifyGeneratedApprovedWorkOrderNumber);
        }


        [Given("I take screenshot of Approving an CM Work Order test Scenario four")]
        public void GivenITakeScreenshotOfApprovingAnCMWorkOrderTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Approving an CM Work Order test Scenario four",
                pom.TakeScreenshotOfApprovingAnCMWorkOrderTestScenarioFour);
        }



        //Automatic work order status transition to WMATL Step Definitions

        [Given("I open application Inventory")]
        public void GivenIOpenApplicationInventory()
        {
            AllureLogger.LogStep("Open [Go To] menu Bar",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Inventory menu",
                pom.OpenInventoryMenu);
            AllureLogger.LogStep("Launch application Inventory",
                pom.OpenApplicationInventory);
        }

        [Given("I filter table Inventory:")]
        public void GivenIFilterTableInventory(Table table)
        {
            string Item = table.Rows[0]["Inventory"];
            string storeroom = table.Rows[0]["storeroom"];


            pom.FilterTableInventor(Item, storeroom);
        }
                     

        [Given("I go to Team Leader Arising Tab")]
        public void GivenIGoToTeamLeaderArisingTab()
        {
            AllureLogger.LogStep("I go to Team Leader Arising Tab",
            pom.GoToTeamLeaderArisingTab);
        }

        [Given("I filter table Team Leader Arising Tab Work Type:")]
        public void GivenIFilterTableTeamLeaderArisingTabWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Type"];
            AllureLogger.LogStep($"I filter table Team Leader Arising Tab Work Type: {WorkType}", () =>
                pom.FilterTableTeamLeaderArisingTabWorkType(WorkType));
        }

        [Given("I select CM Work Order from table records")]
        public void GivenISelectCMWorkOrderFromTableRecords()
        {
            AllureLogger.LogStep("I select CM Work Order from table records",
            pom.SelectCMWorkOrderFromTableRecords);
        }
               
        [Given("I go to tab Plan")]
        public void GivenIGoToTabPlan()
        {
            AllureLogger.LogStep("I go to tab Plan",
            pom.GoToTabPlan);
        }

        [Given("I go to tab materials")]
        public void GivenIGoToTabMaterials()
        {
            AllureLogger.LogStep("I go to tab materials",
            pom.GoToTabmaterials);
        }

        [Given("I press add new row under materials tab")]
        public void GivenIPressAddNewRowUnderMaterialsTab()
        {
            AllureLogger.LogStep("I press add new row under materials tab",
            pom.PressAddNewRowUnderMaterialsTab);
        }

        [Given("I choose Select Value from Detail Menu of Item field")]
        public void GivenIChooseSelectValueFromDetailMenuOfItemField()
        {
            
            AllureLogger.LogStep("Detail Menu Of Item field",
                 pom.ChooseSelectValueFromDetailMenuOfItemField);
            AllureLogger.LogStep("Select Value Option Of Item field",
                pom.SelectValueOptionOfItemfield);
        }

        [Given("I filter table Item:")]
        public void GivenIFilterTableItem(Table table)
        {
            string Item = table.Rows[0]["Item"];
            AllureLogger.LogStep($"I filter table Item: {Item}", () =>
                pom.FilterTableItem(Item));
        }
        

        [Given("I select no. {int} record from Item table records")]
        public void GivenISelectNo_RecordFromItemTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Item table records",
             () => pom.SelectNoRecordFromItemTableRecords(p0));
        }

        [Given("I choose Select Value from Detail Menu of Storeroom field")]
        public void GivenIChooseSelectValueFromDetailMenuOfStoreroomField()
        {
           
            AllureLogger.LogStep("Detail Menu Of Storeroom field",
                 pom.SelectDetailMenuOfStoreroomField);
            AllureLogger.LogStep("Select Value Option Of Storeroom field",
                pom.SelectValueOptionOfStoreroomfield);
        }

        [Given("I select no. {int} record from Storeroom table records")]
        public void GivenISelectNo_RecordFromStoreroomTableRecords(int p0)
        {
            AllureLogger.LogStep($"I select no.{p0} record from Storeroom table records",
             () => pom.SelectNoRecordFromStoreroomTableRecords(p0));
        }

        [Given("I set Direct Issue active")]
        public void GivenISetDirectIssueActive()
        {
            AllureLogger.LogStep("I set Direct Issue active",
           pom.SetDirectIssueActive);
        }

        [Given("I set \\(Radio) field to Waiting Materials")]
        public void GivenISetRadioFieldToWaitingMaterials()
        {
            AllureLogger.LogStep("I set (Radio) field to Waiting Materials",
              pom.SetRadioFieldToWaitingMaterials);
        }

        [Given("I press ok dialog button")]
        public void GivenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I press ok dialog button",
           pom.IPressOkDialogButton);
        }

        [Given("I verify Status field has value WMATL")]
        public void GivenIVerifyStatusFieldHasValueWMATL()
        {
            AllureLogger.LogStep("I verify Status field has value WMATL",
              pom.VerifyStatusFieldHasValueWMATL);
        }

        [Given("I verify generated WMATL work order number")]
        public void GivenIVerifyGeneratedWMATLWorkOrderNumber()
        {
            AllureLogger.LogStep("I verify generated WMATL work order number",
                pom.VerifyGeneratedWMATLWorkOrderNumber);
        }


        [Given("I take screenshot of Automatic work order status transition to WMATL test")]
        public void GivenITakeScreenshotOfAutomaticWorkOrderStatusTransitionToWMATLTest()
        {
            AllureLogger.LogStep("I take screenshot of Automatic work order status transition to WMATL test",
               pom.TakeScreenshotOfAutomaticWorkOrderStatusTransitionToWMATLTest);
        }


    }
}
