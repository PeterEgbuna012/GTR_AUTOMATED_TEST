using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Log;
using Reqnroll;
using System.Numerics;

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

        [Given("I sign as cms admin team leader")]
        public void GivenISignAsCmsAdminTeamLeader()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsCmsTeamLeader();
            AllureLogger.SetUserLoginRole("cms admin team leader");
        }

        [Given("I sign as cms admin")]
        public void GivenISignAsCmsAdmin()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsCMSADMIN();
            AllureLogger.SetUserLoginRole("cms admin");
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
            pom.EnterQualificationsDetails(QualificationCode, QualificationDescription);
        }

        [Given("I open Select Value lookup of Qualification Type field")]
        public void GivenIOpenSelectValueLookupOfQualificationTypeField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Qualification Type field",
                 pom.OpenSelectValueLookupOfQualificationTypeField);
        }

        [Given("I select Qualification Type:")]
        public void GivenISelectQualificationType(Table table)
        {
            string QualificationType = table.Rows[0]["Qualification Type"];
            AllureLogger.LogStep($"I select Qualification Type: {QualificationType}", () =>
                pom.SelectQualificationType(QualificationType));
        }

        [Given("I select Qualification Type")]
        public void GivenISelectQualificationType()
        {
            AllureLogger.LogStep("I select Qualification Type",
              pom.SelectQualificationType);
        }
                       

        [Given("I enter following:")]
        public void GivenIEnterFollowing(Table table)
        {
            string ParentQualification = table.Rows[0]["Parent Qualification"];
            string Duration = table.Rows[0]["Duration"];
            pom.EnterFollowing(ParentQualification, Duration);
        }

        [Given("I open Select Value lookup of Duration Period field")]
        public void GivenIOpenSelectValueLookupOfDurationPeriodField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Duration Period field",
              pom.OpenSelectValueLookupOfDurationPeriodField);
        }

        [Given("I select Years from the list")]
        public void GivenISelectYearsFromTheList()
        {
            AllureLogger.LogStep("I select Years from the list",
               pom.SelectYearsFromTheList);
        }

        [Given("I enter Required Use Length:")]
        public void GivenIEnterRequiredUseLength(Table table)
        {
            string RequiredUseLength = table.Rows[0]["Required Use Length"];
            AllureLogger.LogStep($"I enter Required Use Length: {RequiredUseLength}", () =>
                pom.EnterRequiredUseLength(RequiredUseLength));
        }

        [Given("I open Select Value lookup of Required Use Period field")]
        public void GivenIOpenSelectValueLookupOfRequiredUsePeriodField()
        {
              AllureLogger.LogStep("I open Select Value lookup of Required Use Period field",
              pom.OpenSelectValueLookupOfRequiredUsePeriodField);
        }

        [Given("I select MONTHS from the list")]
        public void GivenISelectMONTHSFromTheList()
        {
             AllureLogger.LogStep("I select MONTHS from the list",
             pom.SelectMONTHSFromTheList);
        }

        [Given("I select New Row under the Required Craft and Skill Level section")]
        public void GivenISelectNewRowUnderTheRequiredCraftAndSkillLevelSection()
        {
            AllureLogger.LogStep("I select New Row under the Required Craft and Skill Level section",
            pom.SelectNewRowUnderTheRequiredCraftAndSkillLevelSection);
        }

        [Given("I choose Select Value from Detail Menu of Craft field")]
        public void GivenIChooseSelectValueFromDetailMenuOfCraftField()
        {
            AllureLogger.LogStep("Detail Menu Of Craft Field",
                pom.DetailMenuOfCraftField);
            AllureLogger.LogStep("Select Value Option of Craft",
                pom.SelectValueOptionofCraft);
        }

        [Given("I filter table Craft and Skill Level:")]
        public void GivenIFilterTableCraftAndSkillLevel(Table table)
        {
            string Craft = table.Rows[0]["Craft"];
            string SkillLevel = table.Rows[0]["Skill-Level"];
            pom.FilterTableCraftAndSkillLevel(Craft, SkillLevel);
        }

        [Given("I select no. {int} record from Craft and Skill Level table records")]
        public void GivenISelectNo_RecordFromCraftAndSkillLevelTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Craft and Skill Level table records",
              () => pom.SelectNoRecordFromCraftAndSkillLevelTableRecords(recordNumber));
        }



        [Given("I take screenshot of Craft Skill-Level")]
        public void GivenITakeScreenshotOfCraftSkill_Level()
        {
            AllureLogger.LogStep("I take screenshot of Craft Skill-Level",
               pom.TakeScreenshotOfCraftSkill_Level);
        }

        [Given("I delete Craft Skill-Level")]
        public void GivenIDeleteCraftSkill_Level()
        {
            AllureLogger.LogStep("I delete Craft Skill-Level",
               pom.DeleteCraftSkillLevel);
        }

        [Given("I change qualifications change status inactive")]
        public void GivenIChangeQualificationsChangeStatusInactive()
        {
            AllureLogger.LogStep("I change qualifications status",
               pom.ChangeQualificationsstatus);
            AllureLogger.LogStep("Status Bar Drop Down Menu Option",
                pom.DropdownMenuOption);
            AllureLogger.LogStep("I set status inactive",
                pom.SetStatusInactive);
        }

        [Given("I verify status is INACTIVE")]
        public void GivenIVerifyStatusIsINACTIVE()
        {

            AllureLogger.LogStep("I verify status is INACTIVE",
              pom.VerifyStatusIsINACTIVE);

        }

        [Given("I select Ok Button")]
        public void GivenISelectOkButton()
        {
            AllureLogger.LogStep("I select Ok Button",
                pom.SelectOkButton);
        }

        [Given("I take screenshot of Creation of a Qualification Test")]
        public void GivenITakeScreenshotOfCreationOfAQualificationTest()
        {
            AllureLogger.LogStep("I take screenshot of Creation of a Qualification Test",
               pom.TakeScreenshotOfCreationOfAQualificationTest);
        }



        // Delete Qualification Steps Definitions





        [Given("I filter table Qualifications:")]
        public void GivenIFilterTableQualifications(Table table)
        {
            string Qualifications = table.Rows[0]["Qualifications"];
            AllureLogger.LogStep($"filter table Qualifications: {Qualifications}", () =>
                pom.FilterTableQualifications(Qualifications));
        }

        [Given("I select no. {int} record from Qualification table records")]
        public void GivenISelectNo_RecordFromQualificationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification table records",
             () => pom.SelectNoRecordFromQualificationTableRecords(recordNumber));
        }

        [Given("I select delete Qualifications")]
        public void GivenISelectDeleteQualifications()
        {
            AllureLogger.LogStep("I select delete Qualifications",
                pom.SelectDeleteQualifications);
        }

        [Given("I press Yes dialog button")]
        public void GivenIPressYesDialogButton()
        {
            AllureLogger.LogStep("I press Yes dialog button",
                pom.PressYesDialogButton);
        }
        
        [Given("I verify table has no records")]
        public void GivenIVerifyTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify table has no records",
                pom.VerifyTableHasNoRecords);
        }

        [Given("I take screenshot of Delete Qualification Test")]
        public void GivenITakeScreenshotOfDeleteQualificationTest()
        {
            AllureLogger.LogStep("I take screenshot of Delete Qualification Test",
               pom.TakeScreenshotOfDeleteQualificationTest);
        }






        // Association of a Qualification to a Labour Record Steps Definitions


        [Given("I take screenshot of Craft Skill Level")]
        public void GivenITakeScreenshotOfCraftSkillLevel()
        {
            AllureLogger.LogStep("I take screenshot of Craft Skill-Level",
               pom.TakeScreenshotOfCraftSkillLevel);
        }
        
        [Given("I verify status is ACTIVE")]
        public void GivenIVerifyStatusIsACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
              pom.VerifyStatusIsACTIVE);
        }

        [Given("I take screenshot of Association of a Qualification to a Labour Record test")]
        public void GivenITakeScreenshotOfAssociationOfAQualificationToALabourRecordTest()
        {
            AllureLogger.LogStep("I take screenshot of Association of a Qualification to a Labour Record test",
            pom.TakeScreenshotOfAssociationOfAQualificationToALabourRecordTest);
        }


        //Association of a Qualification to a Labour Record Steps Definitions



        [Given("I open application Labor")]
        public void GivenIOpenApplicationLabor()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Administration Menu Button",
                pom.AdministrationMenuButton);
            AllureLogger.LogStep("Resources Menu Button",
                pom.ResourcesMenuButton);
            AllureLogger.LogStep("Launch Application Labor",
                pom.OpenApplicationLabor);
        }

        [Given("I filter table labor:")]
        public void GivenIFilterTableLabor(Table table)
        {
            string labor = table.Rows[0]["labor"];
            AllureLogger.LogStep($"filter table labor: {labor}", () =>
                pom.FilterTableLabor(labor));
        }

        [Given("I select no. {int} record from labor table records")]
        public void GivenISelectNo_RecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from labor table records",
             () => pom.SelectNoRecordFromLaborTableRecords(recordNumber));
        }

        [Given("I go to Qualifications tab")]
        public void GivenIGoToQualificationsTab()
        {
            AllureLogger.LogStep("I go to Qualifications tab",
               pom.GoToQualificationsTab);
        }

        [Given("I select New Row Button")]
        public void GivenISelectNewRowButton()
        {
            AllureLogger.LogStep("I select New Row Button",
               pom.SelectNewRowButton);
        }

        [Given("I choose Select Value from Detail Menu of Qualification field")]
        public void GivenIChooseSelectValueFromDetailMenuOfQualificationField()
        {
            AllureLogger.LogStep("Detail Menu Of Qualification",
                  pom.DetailMenuOfQualification);
            AllureLogger.LogStep("Select Value Option Of Qualification",
                pom.SelectValueOptionOfQualification);
        }

        [Given("I filter table Qualification:")]
        public void GivenIFilterTableQualification(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"filter table Qualification: {Qualification}", () =>
                pom.FilterTableQualification(Qualification));
        }

        [Given("I select no. {int} from Qualification table records")]
        public void GivenISelectNo_FromQualificationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification table records",
             () => pom.SelectNoFromQualificationTableRecords(recordNumber));
        }

        [Given("I select no. {int} record from Qualification table record")]
        public void GivenISelectNo_RecordFromQualificationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification table records",
            () => pom.SelectNoRecordFromQualificationTableRecord(recordNumber));
        }


        [Given("I take screenshot of Association of a Qualification to a Labour Record")]
        public void GivenITakeScreenshotOfAssociationOfAQualificationToALabourRecord()
        {
            AllureLogger.LogStep("I take screenshot of Association of a Qualification to a Labour Record",
            pom.TakeScreenshotOfAssociationOfAQualificationToALabourRecord);
        }

        [Given("I select the filter option")]
        public void GivenISelectTheFilterOption()
        {
            AllureLogger.LogStep("I select the filter option",
               pom.SelectTheFilterOption);
        }

        [Given("I filter Qualification table:")]
        public void GivenIFilterQualificationTable(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"filter table Qualification: {Qualification}", () =>
                pom.FilterQualificationTable(Qualification));
        }


        [Given("I set qualifications status inactive")]
        public void GivenISetQualificationsChangeStatusInactive()
        {
            AllureLogger.LogStep("I change qualifications status",
               pom.ChangeQualificationsstatus);
            AllureLogger.LogStep("Status Bar Drop Down Menu",
                pom.DropdownMenu);
            AllureLogger.LogStep("I set status inactive",
                pom.SetStatusInactive);
        }


        [Given("I take screenshot of Set Qualification Inactive")]
        public void GivenITakeScreenshotOfSetQualificationInactive()
        {
            AllureLogger.LogStep("I take screenshot of Set Qualification Inactive",
            pom.TakeScreenshotOfSetQualificationInactive);
        }






        // View a List of Labor Records with Qualifications Soon to Expire Steps Definitions




        [Given("I go to CMS Administrator tab")]
        public void GivenIGoToCMSAdministratorTab()
        {
            AllureLogger.LogStep("I go to CMS Administrator tab",
                pom.GoToCMSAdministratorTab);
        }

        [Given("I Open Result Set in the Application")]
        public void GivenIOpenResultSetInTheApplication()
        {
            AllureLogger.LogStep("I Open Result Set in the Application",
                 pom.OpenResultSetInTheApplication);
        }

        [Given("I take screenshot of View a List of Labor Records with Qualifications Soon to Expire Test")]
        public void GivenITakeScreenshotOfViewAListOfLaborRecordsWithQualificationsSoonToExpireTest()
        {
            AllureLogger.LogStep("I take screenshot of View a List of Labor Records with Qualifications Soon to Expire Test",
            pom.TakeScreenshotOfViewAListOfLaborRecordsWithQualificationsSoonToExpireTest);
        }






        // Creating new Training Course Job Plans Steps Definitions





        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario one")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario one",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioOne);
        }
                

        [Given("I open application Job Plans \\(Tr)")]
        public void GivenIOpenApplicationJobPlansTr()
        {
            AllureLogger.LogStep("Open Go To Menu)",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Planning Menu Button",
                pom.PlanningMenuButton);
            AllureLogger.LogStep("Open Application Job Plans Tr",
                pom.OpenApplicationJobPlansTr);
        }

        [Given("I select New Job Plan")]
        public void GivenISelectNewJobPlan()
        {
            AllureLogger.LogStep("I select New Job Plan",
            pom.SelectNewJobPlan);
        }

        [Given("I enter Job Plan:")]
        public void GivenIEnterJobPlan(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterJobPlan(ID, Description);
        }

        [Given("I open Select Value lookup of Organisation field")]
        public void GivenIOpenSelectValueLookupOfOrganisationField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Organisation field",
               pom.OpenSelectValueLookupOfOrganisationField);
        }

        [Given("I select no. {int} record from Organisation table records")]
        public void GivenISelectNo_RecordFromOrganisationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Organisation table records",
            () => pom.SelectNoRecordFromOrganisationTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup of Site field")]
        public void GivenIOpenSelectValueLookupOfSiteField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Site field",
            pom.OpenSelectValueLookupOfSiteField);
        }

        [Given("I select no. {int} record from Site table records")]
        public void GivenISelectNo_RecordFromSiteTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Site table records",
            () => pom.SelectNoRecordFromSiteTableRecords(recordNumber));
        }

        [Given("I enter Duration:")]
        public void GivenIEnterDuration(Table table)
        {
            string Duration = table.Rows[0]["Duration"];
            AllureLogger.LogStep($"I enter Duration: {Duration}", () =>
                pom.EnterDuration(Duration));
        }

        [Given("I select New Row button under Job Plans Tasks section")]
        public void GivenISelectNewRowButtonUnderJobPlansTasksSection()
        {
            AllureLogger.LogStep("I select New Row button under Job Plans Tasks section",
              pom.SelectNewRowButtonUnderJobPlansTasksSection);
        }

        [Given("I enter Task Description:")]
        public void GivenIEnterTaskDescription(Table table)
        {
            string TaskDescription = table.Rows[0]["Task Description"];
            AllureLogger.LogStep($"I enter Task Description: {TaskDescription}", () =>
                pom.TaskDescription(TaskDescription));
        }

        [Given("I open Select Value lookup of Qualifications field")]
        public void GivenIOpenSelectValueLookupOfQualificationsField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Qualifications field",
              pom.OpenSelectValueLookupOfQualificationsField);
        }

        [Given("I select yes dialog button of System Message")]
        public void GivenISelectYesDialogButtonOfSystemMessage()
        {
            AllureLogger.LogStep("I select yes dialog button of System Message",
           pom.SelectYesDialogButtonOfSystemMessage);
        }

        [Given("I select New Row")]
        public void GivenISelectNewRow()
        {
            AllureLogger.LogStep("I select New Row",
            pom.SelectNewRow);
        }

        [Given("I open Select Value lookup of Qualification Requirements field")]
        public void GivenIOpenSelectValueLookupOfQualificationRequirementsField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Qualification Requirements field",
                   pom.SelectValueLookupOfQualificationRequirementsField);
        }
                  

        [Given("I filter Qualification Requirements:")]
        public void GivenIFilterQualificationRequirements(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"I filter Qualification Requirements: {Qualification}", () =>
            pom.FilterQualificationRequirements(Qualification));
        }

        [Given("I select no. {int} record from Qualification Requirements table records")]
        public void GivenISelectNo_RecordFromQualificationRequirementsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Qualification Requirements table records",
            () => pom.SelectNoRecordFromQualificationRequirementsTableRecords(recordNumber));
        }

        [Given("I Press Ok dialog button")]
        public void GivenIPressOkDialogButton()
        {
            AllureLogger.LogStep("I Press Ok dialog button",
           pom.PressOkDialogButton);
        }


        [Given("I Select Value from Detail Menu of Qualification")]
        public void GivenISelectValueFromDetailMenuOfQualification()
        {
            AllureLogger.LogStep("Detail Menu Of Qualification",
                  pom.DetailMenuOfQualification);
            AllureLogger.LogStep("Select Value Option Of Qualification",
                pom.SelectValueOptionOfQualification);
        }

        [Given("I filter Qualification:")]
        public void GivenIFilterQualification(Table table)
        {
            string Qualification = table.Rows[0]["Qualification"];
            AllureLogger.LogStep($"I filter Qualification: {Qualification}", () =>
            pom.FilterQualification(Qualification));
        }

        [Given("I set Qualification status ACTIVE")]
        public void GivenISetQualificationStatusACTIVE()
        {
            AllureLogger.LogStep("I select Change Status Button",
            pom.ChangeStatusButton);
            AllureLogger.LogStep("I select Drop Down New Status Menu Option",
           pom.SelectDropdownNewStatusMenuOption);
            AllureLogger.LogStep("I Select ACTIVE From New Status Menu Option",
                pom.SelectACTIVEFromNewStatusMenuOption);

        }

        [Given("I click Ok")]
        public void GivenIClickOk()
        {
            AllureLogger.LogStep("I click Ok",
           pom.ClickOk);
        }

        [Given("I verify Job Plans status ACTIVE")]
        public void GivenIVerifyJobPlansStatusACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
             pom.VerifyJobPlansStatusACTIVE);
        }


        [Given("I verify status ACTIVE")]
        public void GivenIVerifyStatusACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
              pom.VerifyStatusACTIVE);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario two")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario two",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariotwo);
        }

        [Given("I open Select Value lookup of Nested Job Plan field")]
        public void GivenIOpenSelectValueLookupOfNestedJobPlanField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Nested Job Plan field",
                pom.OpenSelectValueLookupOfNestedJobPlanField);
        }

        [Given("I filter Nested Job Plan:")]
        public void GivenIFilterNestedJobPlan(Table table)
        {
            string Description = table.Rows[0]["Description"];
            AllureLogger.LogStep($"I filter Nested Job Plan: {Description}", () =>
            pom.FilterNestedJobPlan(Description));
        }

        [Given("I select no. {int} record from Nested Job Plan table records")]
        public void GivenISelectNo_RecordFromNestedJobPlanTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Nested Job Plan table records",
            () => pom.SelectNoRecordFromNestedJobPlanTableRecords(recordNumber));
        }

        [Given("I select New Row button under Planned Labor section")]
        public void GivenISelectNewRowButtonUnderPlannedLaborSection()
        {
            AllureLogger.LogStep("I select New Row button under Planned Labor section",
                pom.SelectNewRowButtonUnderPlannedLaborSection);
        }

        [Given("I enter Task Value:")]
        public void GivenIEnterTaskValue(Table table)
        {
            string TaskValue = table.Rows[0]["Task Value"];
            AllureLogger.LogStep($"I enter Task Value: {TaskValue}", () =>
                pom.EnterTaskValue(TaskValue));
        }

        [Given("I choose Select Value from Detail Menu of Craft")]
        public void GivenIChooseSelectValueFromDetailMenuOfCraft()
        {
            AllureLogger.LogStep("Detail Menu Of Craft",
                pom.DetailMenuOfCraft);
            AllureLogger.LogStep("Select Value Option of Craft",
                pom.SelectValueOption);
        }

        [Given("I filter table Craft:")]
        public void GivenIFilterTableCraft(Table table)
        {
            string Craft = table.Rows[0]["Craft"];
            string SkillLevel = table.Rows[0]["Skill-Level"];
            pom.FilterTableCraft(Craft, SkillLevel);
        }

        [Given("I select no. {int} record from Craft table records")]
        public void GivenISelectNo_RecordFromCraftTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Craft table records",
            () => pom.SelectNoRecordFromCraftTableRecords(recordNumber));
        }


        [Given("I set Job Plan status ACTIVE")]
        public void GivenISetJobPlanStatusACTIVE()
        {
            AllureLogger.LogStep("I select Change Status Button",
            pom.ChangeStatusButton);
            AllureLogger.LogStep("I select Drop Down New Status Menu Option",
           pom.SelectDropdownNewStatusMenuOption);
            AllureLogger.LogStep("I Select ACTIVE From New Status Menu Option",
                pom.SelectACTIVEFromNewStatusMenuOption);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario three")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario three",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariothree);
        }

        [Given("I filter table Job Plans:")]
        public void GivenIFilterTableJobPlans(Table table)
        {
            string JobPlans = table.Rows[0]["Job Plans"];
            AllureLogger.LogStep($"I filter Job Plans: {JobPlans}", () =>
            pom.FilterTableJobPlans(JobPlans));
        }

        [Given("I select no. {int} record from Job Plans table records")]
        public void GivenISelectNo_RecordFromJobPlansTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Job Plan table records",
            () => pom.SelectNoRecordFromJobPlansTableRecords(recordNumber));
        }

        [Given("I select delete Job Plans")]
        public void GivenISelectDeleteJobPlans()
        {
            AllureLogger.LogStep("I select delete Job Plans",
          pom.SelectDeleteJobPlans);
        }

        [Given("I press Yes button")]
        public void GivenIPressYesButton()
        {
            AllureLogger.LogStep("I press Yes button",
           pom.PressYesButton);
        }

        [Given("I verify Job Plans table has no records")]
        public void GivenIVerifyJobPlansTableHasNoRecords()
        {
            AllureLogger.LogStep("verify Job Plans table has no records",
                pom.VerifyJobPlansTableHasNoRecords);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario four")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario four",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariofour);
        }

        [Given("I select delect Job Plan")]
        public void GivenISelectDelectJobPlan()
        {
            AllureLogger.LogStep("I select delete Job Plans",
            pom.SelectDeleteJobPlans);
        }

        [Given("I select Yes button")]
        public void GivenISelectYesButton()
        {
            AllureLogger.LogStep("I press Yes button",
            pom.PressYesButton);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario five")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioFive()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario five",
           pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariofive);
        }

        [Given("I take screenshot of Creating new Training Course Job Plans Test Scenario six")]
        public void GivenITakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioSix()
        {
            AllureLogger.LogStep("I take screenshot of Creating new Training Course Job Plans Test Scenario six",
            pom.TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariosix);
        }






        // Creating a new Training Course Work Order Template Steps Definitions






        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario one")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioOne()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario one",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioOne);
        }

        [Given("I open application Work Order Template \\(BRDA)")]
        public void GivenIOpenApplicationWorkOrderTemplateBRDA()
        {
            AllureLogger.LogStep("Go To Menu",
                pom.OpenGoToMenu);
            AllureLogger.LogStep("Open Work Order Menu",
                pom.OpenWorkOrderMenu);
            AllureLogger.LogStep("Launch Work Order Template",
                pom.OpenApplicationWorkOrderTemplateBRDA);
        }

        [Given("I select new record")]
        public void GivenISelectNewRecord()
        {
            AllureLogger.LogStep("I select new record",
            pom.SelectNewRecord);
        }

        [Given("I enter Work Order Template Details:")]
        public void GivenIEnterWorkOrderTemplateDetails(Table table)
        {
            string ID = table.Rows[0]["ID"];
            string Description = table.Rows[0]["Description"];
            pom.EnterWorkOrderTemplateDetails(ID, Description);
        }

        [Given("I choose Select Value from Detail Menu of Asset Group field")]
        public void GivenIChooseSelectValueFromDetailMenuOfAssetGroupField()
        {
            AllureLogger.LogStep("Detail Menu Of Asset Group",
                pom.DetailMenuOfAssetGroup);
            AllureLogger.LogStep("Select Value Option of Asset Group",
                pom.SelectValueOptionOfAssetGroup);
        }

        [Given("I select no. {int} record from Asset Group table records")]
        public void GivenISelectNo_RecordFromAssetGroupTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Asset Group table records",
            () => pom.SelectNoRecordFromAssetGroupTableRecords(recordNumber));
        }

        [Given("I open Select Value lookup of Work Type field")]
        public void GivenIOpenSelectValueLookupOfWorkTypeField()
        {
            AllureLogger.LogStep("I open Select Value lookup of Work Type field",
            pom.OpenSelectValueLookupOfWorkTypeField);
        }

        [Given("I filter Work Type:")]
        public void GivenIFilterWorkType(Table table)
        {
            string WorkType = table.Rows[0]["Work Type"];
            AllureLogger.LogStep($"I filter Work Type: {WorkType}", () =>
            pom.FilterWorkType(WorkType));
        }

        [Given("I select no. {int} record from Template Work Type table records")]
        public void GivenISelectNo_RecordFromTemplateWorkTypeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Template Work Type table records",
            () => pom.SelectNoRecordFromTemplateWorkTypeTableRecords(recordNumber));
        }

        [Given("I choose Select Value from Detail Menu of Job Plan field")]
        public void GivenIChooseSelectValueFromDetailMenuOfJobPlanField()
        {
            AllureLogger.LogStep("Detail Menu Of Job Plan",
               pom.DetailMenuOfJobPlan);
            AllureLogger.LogStep("Select Value Option of Job Plan",
                pom.SelectValueOptionOfJobPlan);
        }

        [Given("I filter Job Plan:")]
        public void GivenIFilterJobPlan(Table table)
        {
            string JobPlan = table.Rows[0]["Job Plan"];
            AllureLogger.LogStep($"I filter Job Plan: {JobPlan}", () =>
            pom.FilterJobPlan(JobPlan));
        }

        [Given("I select no. {int} record from Job Plan table records")]
        public void GivenISelectNo_RecordFromJobPlanTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Job Plan table records",
            () => pom.SelectNoRecordFromJobPlanTableRecords(recordNumber));
        }

        [Given("I set Work Order Template status to ACTIVE")]
        public void GivenISetWorkOrderTemplateStatusToACTIVE()
        {
            AllureLogger.LogStep("I select Change Status Button",
            pom.OpenSelectValueOfStatusField);
            AllureLogger.LogStep("I Select ACTIVE",
                pom.SelectStatusACTIVE);
        }

        [Given("I verify template status ACTIVE")]
        public void GivenIVerifyTemplateStatusACTIVE()
        {
            AllureLogger.LogStep("I verify status is ACTIVE",
             pom.VerifyTemplateStatusACTIVE);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario two")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioTwo()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario two",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariotwo);
        }

        [Given("I filter table Work Order Template:")]
        public void GivenIFilterTableWorkOrderTemplate(Table table)
        {
            string ID = table.Rows[0]["ID"];
            AllureLogger.LogStep($"I filter ID: {ID}", () =>
            pom.FilterTableWorkOrderTemplate(ID));
        }

        [Given("I select no. {int} record from Work Order Template table records")]
        public void GivenISelectNo_RecordFromWorkOrderTemplateTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I select no.{recordNumber} record from Work Order Template table records",
            () => pom.SelectNoRecordFromWorkOrderTemplateTableRecords(recordNumber));
        }

        [Given("I select delete Work Order Template record")]
        public void GivenISelectDeleteWorkOrderTemplateRecord()
        {
            AllureLogger.LogStep("I select delete Work Order Template record",
           pom.SelectDeleteWorkOrderTemplateRecord);
        }

        [Given("I verify Work Order Template table has no records")]
        public void GivenIVerifyWorkOrderTemplateTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify Work Order Template table has no records",
                pom.VerifyWorkOrderTemplateTableHasNoRecords);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario three")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioThree()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario three",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariothree);
        }

        [Given("I take screenshot of Creating a new Training Course Work Order Template Test Scenario four")]
        public void GivenITakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioFour()
        {
            AllureLogger.LogStep("I take screenshot of Creating a new Training Course Work Order Template Test Scenario four",
            pom.TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariofour);
        }









    }
}