using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using Reqnroll;
using System.Diagnostics;
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

        [Given("I sign as materials supply chain support")]
        public void GivenISignAsMaterialsSupplyChainSupport()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsMaterialsSupplyChainSupport();
            AllureLogger.SetUserLoginRole("materials supply chain support");
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


        // Automatic Email to Supplier Step Definitions



        [Given("I open application Business Rules \\(BRDB)")]
        public void GivenIOpenApplicationBusinessRulesBRDB()
        {
            AllureLogger.LogStep("Open GoTO Menu Bar",
               pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu",
                pom.AdministrationMenu);
            AllureLogger.LogStep("Launch Business Rules (BRDA)",
                pom.BusinessRulesBRDB);
        }

        [Given("I filter table Business Rules \\(BRDB):")]
        public void GivenIFilterTableBusinessRulesBRDB(Table table)
        {
            string BusinessRules = table.Rows[0]["Business Rules"];
            pom.FilterTableBusinessRulesBRDB(BusinessRules);
        }

        [Given("I select no. {int} record from Business Rules table records")]
        public void GivenISelectNo_RecordFromBusinessRulesTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Business Rules table records",
             () => pom.SelectNoRecordFromBusinessRulesTableRecords(recordNumber));
        }

        [Given("I filter Application Search field:")]
        public void GivenIFilterApplicationSearchField(Table table)
        {
            string Application = table.Rows[0]["Application"];
            pom.FilterApplicationSearchField(Application);
        }

        [Given("I select Application Escalations")]
        public void GivenISelectApplicationEscalations()
        {
            AllureLogger.LogStep("I select Application Escalations",
               pom.SelectApplicationEscalations);
        }
              

        [Given("I filter table Escalations:")]
        public void GivenIFilterTableEscalations(Table table)
        {
            string Escalations = table.Rows[0]["Escalations"];
            pom.FilterTableEscalations(Escalations);
        }
               
        [Given("I select no. {int} record from Escalations table records")]
        public void GivenISelectNo_RecordFromEscalationsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Escalations table records",
             () => pom.SelectNoRecordFromEscalationsTableRecords(recordNumber));
        }

        [Given("I set escalations active")]
        public void GivenISetEscalationsActive()
        {
            AllureLogger.LogStep("I set escalations active",
               pom.SetEscalationsActive);
        }

        [Given("I select view details")]
        public void GivenISelectViewDetails()
        {
            AllureLogger.LogStep("I select view details",
               pom.SelectViewDetails);
        }
                      

        [Given("I go to notifications tab")]
        public void GivenIGoToNotificationsTab()
        {
            AllureLogger.LogStep("I go to notifications tab",
               pom.GoToNotificationsTab);
        }

        [Given("I choose Go To Communcation Templates from Detail Menu of Template field")]
        public void GivenIChooseGoToCommuncationTemplatesFromDetailMenuOfTemplateField()
        {
            AllureLogger.LogStep("Select Value from Detail Menu  of Template field",
               pom.DetailMenuTemplateField);
            AllureLogger.LogStep("Go To Communcation Templates",
               pom.GoToCommuncationTemplates);
        }
                     
        [Given("I go to Recipients tab")]
        public void GivenIGoToRecipientsTab()
        {
            AllureLogger.LogStep("I go to Recipients tab",
                pom.GoToRecipientsTab);
        }

        [Given("I select New Row button")]
        public void GivenISelectNewRowButton()
        {
            AllureLogger.LogStep("I select New Row button",
               pom.SelectNewRowButton);
        }

        [Given("I enter following Email:")]
        public void GivenIEnterFollowingEmail(Table table)
        {
            string Email = table.Rows[0]["Email"];
            pom.EnterFollowingEmail(Email);
        }

        [Given("I set \\(Radio) field to active")]
        public void GivenISetRadioFieldToActive()
        {
            AllureLogger.LogStep("I set (Radio) field to active",
               pom.SetRadioFieldToActive);
        }

        [Given("I return")]
        public void GivenIReturn()
        {
            AllureLogger.LogStep("I return",
               pom.IReturn);
        }

        [Given("I select value lookup of Schedule field")]
        public void GivenISelectValueLookupOfScheduleField()
        {
            AllureLogger.LogStep("I select value lookup of Schedule field",
              pom.SelectValueLookupOfScheduleField);
        }

        [Given("I enter following Schedule:")]
        public void GivenIEnterFollowingSchedule(Table table)
        {
            string Schedule = table.Rows[0]["Schedule"];
            pom.EnterFollowingSchedule(Schedule);
        }

        [Given("I press the dialog button ok")]
        public void GivenIPressTheDialogButtonOk()
        {
            AllureLogger.LogStep("I press the dialog button ok",
              pom.PressTheDialogButtonOk);
        }

        [Given("I review sent email")]
        public void GivenIReviewSentEmail()
        {
            AllureLogger.LogStep("I review sent email",
              pom.ReviewSentEmail);
        }

        [Given("I take screenshot of Automatic Email to Supplier Test Scenario one")]
        public void GivenITakeScreenshotOfAutomaticEmailToSupplierTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Automatic Email to Supplier Test Scenario one",
              pom.TakeScreenshotOfAutomaticEmailToSupplierTestScenarioOne);
        }

        [Given("I select show communcation template menu button")]
        public void GivenISelectShowCommuncationTemplateMenuButton()
        {
            AllureLogger.LogStep("I select show communcation template menu button",
             pom.SelectShowCommuncationTemplateMenuButton);
        }

        [Given("I filter table Email:")]
        public void GivenIFilterTableEmail(Table table)
        {
            string Email = table.Rows[0]["Email"];
            pom.FilterTableEmail(Email);
        }

        [Given("I delete email record")]
        public void GivenIDeleteEmailRecord()
        {
            AllureLogger.LogStep("I delete email record",
             pom.DeleteEmailRecord);
        }

        [Given("I take screenshot of Deleted Email to Supplier Test")]
        public void GivenITakeScreenshotOfDeletedEmailToSupplierTest()
        {
            AllureLogger.LogStep("I take screenshot of Deleted Email to Supplier Test",
              pom.TakeScreenshotOfDeletedEmailToSupplierTest);
        }

        [Given("the table Asset Templates has no records")]
        public void GivenTheTableAssetTemplatesHasNoRecords()
        {
            AllureLogger.LogStep("the table Asset Templates has no records",
               pom.TableAssetTemplatesHasNoRecords);
        }
                
        [Given("I select return")]
        public void GivenISelectReturn()
        {
            AllureLogger.LogStep("I select return",
             pom.SelectReturn);
        }

        [Given("I set escalations inactive")]
        public void GivenISetEscalationsInactive()
        {
            AllureLogger.LogStep("I set escalations inactive",
             pom.SetEscalationsInactive);
        }

        [Given("I take screenshot of Automatic Email to Supplier Test Scenario two")]
        public void GivenITakeScreenshotOfAutomaticEmailToSupplierTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Automatic Email to Supplier Test Scenario two",
              pom.TakeScreenshotOfAutomaticEmailToSupplierTestScenarioTwo);
        }


        //Raising a Purchase Requisition - Stocked Item Step Definitions

             

        [Given("I go to Supply Chain Support Tab")]
        public void GivenIGoToSupplyChainSupportTab()
        {
            AllureLogger.LogStep("I go to Supply Chain Support Tab",
             pom.GoToSupplyChainSupportTab);
        }

        [Given("I select New Purchase Requisition")]
        public void GivenISelectNewPurchaseRequisition()
        {
            AllureLogger.LogStep("I select New Purchase Requisition",
             pom.SelectNewPurchaseRequisition);
        }

        [Given("I enter following Purchase Requisition:")]
        public void GivenIEnterFollowingPurchaseRequisition(Table table)
        {
            string PurchaseRequisition = table.Rows[0]["Purchase Requisition"];
            pom.EnterFollowingPurchaseRequisition(PurchaseRequisition);
        }

        [Given("I set Required Date")]
        public void GivenISetRequiredDate()
        {
            AllureLogger.LogStep("I select Required Date Menu",
             pom.SelectRequiredDateMenu);

            AllureLogger.LogStep("I select Required Date",
              pom.SelectRequiredDate);

        }
        

        [Given("I enter GL Debit Account:")]
        public void GivenIEnterGLDebitAccount(Table table)
        {
            string GLDebitAccount = table.Rows[0]["GL Debit Account"];
            pom.EnterGLDebitAccount(GLDebitAccount);
        }

        [Given("I set \\(Radio) Allow Expediting Email True")]
        public void GivenISetRadioAllowExpeditingEmailTrue()
        {
            AllureLogger.LogStep("I set (Radio) Allow Expediting Email True",
             pom.SetRadioAllowExpeditingEmailTrue);
        }

        [Given("I Verify Estimated Due Date is set to {int} days")]
        public void GivenIVerifyEstimatedDueDateIsSetToDays(int recordNumber)
        {
            AllureLogger.LogStep($"I Verify Estimated Due Date is set to {{int}} days",
              () => pom.VerifyEstimatedDueDateIsSetToDays(recordNumber));
        }

        [Given("I Verify Vendor Due Date is set plus {int} days")]
        public void GivenIVerifyVendorDueDateIsSetPlusDays(int recordNumber)
        {
            AllureLogger.LogStep($"I Verify Vendor Due Date is set plus {{int}} days",
              () => pom.VerifyVendorDueDateIsSetPlusDays(recordNumber));
        }

        [Given("I go to Ship To Bill To tab")]
        public void GivenIGoToShipToBillToTab()
        {
            AllureLogger.LogStep("I go to Ship To Bill To tab",
             pom.GoToShipToBillToTab);
        }

        [Given("I press ok manual input dialog button")]
        public void GivenIPressOkManualInputDialogButton()
        {
            AllureLogger.LogStep("I press ok manual input dialog button",
                  pom.PressOkManualInputDialogButton);
        }


        [Given("I take screenshot of Raising a Purchase Requisition - Stocked Item Test")]
        public void GivenITakeScreenshotOfRaisingAPurchaseRequisition_StockedItemTest()
        {
            AllureLogger.LogStep("I take screenshot of Raising a Purchase Requisition - Stocked Item Test",
              pom.TakeScreenshotOfRaisingAPurchaseRequisitionStockedItemTest);
        }





        //  Raising a Purchase Requisition - Non-stocked Item Step Definitions


        [Given("I add new row under PR Lines tab")]
        public void GivenIAddNewRowUnderPRLinesTab()
        {
            AllureLogger.LogStep("I add new row under PR Lines tab",
            pom.AddNewRowUnderPRLinesTab);
        }

        [Given("I select Material from Line Type dropdown options")]
        public void GivenISelectMaterialFromLineTypeDropdownOptions()
        {
            AllureLogger.LogStep("I select dropdown options of Line Type",
            pom.SelectDropDownOptionsOfLineType);
            AllureLogger.LogStep("I Select Material",
            pom.SelectMaterial);
        }

        [Given("I enter following Material Details:")]
        public void GivenIEnterFollowingMaterialDetails(Table table)
        {
            string MaterialDescription = table.Rows[0]["Material Description"];
            string LineCost = table.Rows[0]["Line Cost"];
            pom.EnterFollowingMaterialDetails(MaterialDescription, LineCost);
        }

        [Given("I open Select Value lookup for Order Unit field")]
        public void GivenIOpenSelectValueLookupForOrderUnitField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Order Unit field",
            pom.OpenSelectValueLookupForOrderUnitField);
        }

        [Given("I select no. {int} record from Order Unit table record")]
        public void GivenISelectNo_RecordFromOrderUnitTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Order Unit table records",
            () => pom.SelectNoRecordFromOrderUnitTableRecord(recordNumber));
        }

        [Given("I choose Select Value from Detail Menu of Work Order")]
        public void GivenIChooseSelectValueFromDetailMenuOfWorkOrder()
        {
            AllureLogger.LogStep("I select Detail Menu Of Work Order",
             pom.DetailMenuOfWorkOrder);
            AllureLogger.LogStep("I Select Value Option",
            pom.SelectValueOption);
        }

        [Given("I filter table work Order:")]
        public void GivenIFilterTableWorkOrder(Table table)
        {

            string Description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter table Vendor Items: {Description}", () =>
                pom.FilterTableWorkOrder(Description));
        }

        [Given("I select no. {int} record from work Order table record")]
        public void GivenISelectNo_RecordFromWorkOrderTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  work Order table records",
           () => pom.SelectNoRecordFromWorkOrderTableRecord(recordNumber));
        }

        [Given("I open Select Value lookup for Ship To field")]
        public void GivenIOpenSelectValueLookupForShipToField()
        {
            AllureLogger.LogStep("I open Select Value lookup for Ship To field",
           pom.OpenSelectValueLookupForShipToField);
        }

        [Given("I filter table Ship To:")]
        public void GivenIFilterTableShipTo(Table table)
        {
            string ShipTo = table.Rows[0]["Ship To"];
            AllureLogger.LogStep($"I filter table Vendor Items: {ShipTo}", () =>
                pom.FilterTableShipTo(ShipTo));
        }


        [Given("I select no. {int} record from Ship To table record")]
        public void GivenISelectNo_RecordFromShipToTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from  Ship To table records",
           () => pom.SelectNoRecordFromShipToTableRecord(recordNumber));
        }

        [Given("I take screenshot of  Raising a Purchase Requisition - Non-stocked Item Test")]
        public void GivenITakeScreenshotOfRaisingAPurchaseRequisition_Non_StockedItemTest()
        {
            AllureLogger.LogStep("I take screenshot of  Raising a Purchase Requisition - Non-stocked Item Test",
              pom.TakeScreenshotOfRaisingAPurchaseRequisitionNonStockedItemTest);
        }








    }
}