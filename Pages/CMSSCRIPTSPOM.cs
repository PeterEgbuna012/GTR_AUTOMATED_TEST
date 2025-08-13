using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        public void OpenApplicationLabor() =>
            AllureLogger.LogStep("Launch Application Labor", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_SETUP_MODULE_sub_MOD10041_HEADER_sub_changeapp_LABOR_a_tnode"),
                    "Launch Application Labor"));

        public void SelectNewQualification() =>
           AllureLogger.LogStep("I select New Qualification", () =>
               SafeActions.Click(driver,
                   By.Id("toolactions_INSERT-tbb_image"),
                   "I select New Qualification"));

         public void EnterQualificationsDetails(string QualificationCode, string QualificationDescription) =>
        AllureLogger.LogStep($"I enter Qualifications Details Qualification Code = '{QualificationCode}', Qualification Description = '{QualificationDescription}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

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


        public void OpenSelectValueLookupOfQualificationTypeField() =>
          AllureLogger.LogStep("I open Select Value lookup of Qualification Type field", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#m685f0dda-img"),
                  "I open Select Value lookup of Qualification Type field"));

        public void SelectQualificationType(string qualificationType)
        {
            AllureLogger.LogStep($"I select Qualification Type: {qualificationType}", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                // Step 1: Locate and type into the input field
                By inputField = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
                IWebElement input = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(inputField));

                input.Click();
                input.Clear();
                input.SendKeys(qualificationType);
                input.SendKeys(Keys.Enter);
                              
            });
        }


        public void SelectQualificationType() =>
        AllureLogger.LogStep("I select Qualification Type", () =>
        {
            SafeActions.Click(driver,
               By.Id("lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]"),
               "I select Qualification Type");

            Task.Delay(3000).Wait(); 
        });



        public void EnterFollowing(string ParentQualification, string Duration) =>
       AllureLogger.LogStep($"I enter following Parent Qualification = '{ParentQualification}', Duration = '{Duration}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

           // Adjust column indexes if needed
           By ParentQualificationLocator = By.CssSelector("#m5ceec9a-tb");
           By DurationLocator = By.CssSelector("#m2df729aa-tb");

           // Description filter
           IWebElement ParentQualificationFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ParentQualificationLocator));
           ParentQualificationFilter.Click();
           ParentQualificationFilter.Clear();
           ParentQualificationFilter.SendKeys(ParentQualification);

           // Status filter
           IWebElement DurationFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DurationLocator));
           DurationFilter.Click();
           DurationFilter.Clear();
           DurationFilter.SendKeys(Duration);

       });


        public void OpenSelectValueLookupOfDurationPeriodField() =>
          AllureLogger.LogStep("I open Select Value lookup of Duration Period field", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#mb4fe7810-img"),
                  "I open Select Value lookup of Duration Period field"));

         public void SelectYearsFromTheList() =>
           AllureLogger.LogStep("I select Years from the list", () =>
               SafeActions.Click(driver,
                   By.Id("lookup_page1_tdrow_[C:0]_ttxt-lb[R:1]"),
                   "I select Years from the list"));

         public void EnterRequiredUseLength(string RequiredUseLength) =>
       AllureLogger.LogStep($"I enter Required Use Length'{RequiredUseLength}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#m1097001a-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(RequiredUseLength);
         
       });

        public void OpenSelectValueLookupOfRequiredUsePeriodField() =>
          AllureLogger.LogStep("I open Select Value lookup of Required Use Period field", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#m899e51a0-img"),
                  "I open Select Value lookup of Required Use Period field"));

        public void SelectMONTHSFromTheList() =>
           AllureLogger.LogStep("I select MONTHS from the list", () =>
               SafeActions.Click(driver,
                   By.Id("lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]"),
                   "I select MONTHS from the list"));

        public void SelectNewRowUnderTheRequiredCraftAndSkillLevelSection() =>
          AllureLogger.LogStep("I select New Row under the Required Craft and Skill Level section", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#mb2fa26d9_bg_button_addrow-pb"),
                  "I select New Row under the Required Craft and Skill Level section"));

        public void DetailMenuOfCraftField() =>
           AllureLogger.LogStep("Detail Menu Of Craft Field", () =>
               SafeActions.Click(driver, By.CssSelector("#m735efe0b-img"),
                                 "Detail Menu Of Craft Field"));

        public void SelectValueOptionofCraft() =>
           AllureLogger.LogStep("Select Value Option of Craft", () =>
               SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                                 "Select Value Option of Craft"));


          public void FilterTableCraftAndSkillLevel(string Craft, string SkillLevel) =>
       AllureLogger.LogStep($"I enter following Parent Qualification = '{Craft}', Skill-Level = '{SkillLevel}'", () =>
       {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

           // Adjust column indexes if needed
           By CraftLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
           By SkillLevelLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");

           // Description filter
           IWebElement CraftFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CraftLocator));
           CraftFilter.Click();
           CraftFilter.Clear();
           CraftFilter.SendKeys(Craft);

           // Status filter
           IWebElement SkillLevelFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SkillLevelLocator));
           SkillLevelFilter.Click();
           SkillLevelFilter.Clear();
           SkillLevelFilter.SendKeys(SkillLevel);
           SkillLevelFilter.SendKeys(Keys.Enter);

       });


        public void SelectNoRecordFromCraftAndSkillLevelTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Craft and Skill Level Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Craft and Skill Level Table Records");
                Task.Delay(5000).Wait();
            });
        }

        public void TakeScreenshotOfCraftSkill_Level() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-200SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-200SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-200SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void DeleteCraftSkillLevel() =>
          AllureLogger.LogStep("I delete Craft Skill-Level", () =>
              SafeActions.Click(driver, By.Id("mb2fa26d9_tdrow_[C:4]_toggleimage-ti[R:0]_img"),
                                "I delete Craft Skill-Level"));
        public void ChangeQualificationsstatus() =>
            AllureLogger.LogStep("I change qualifications status", () =>
            {
                SafeActions.Click(driver,
                    By.Id("md86fe08f_ns_menu_STATUS_OPTION_a_tnode"),
                    "I change qualifications status");

                // Add a delay after the click (e.g., 3 seconds)
                Task.Delay(3000).Wait();
            });

        public void DropdownMenuOption() =>
          AllureLogger.LogStep("Status Bar Drop Down Menu Option", () =>
              SafeActions.Click(driver, By.CssSelector("#mc927149a-img"),
                                "Status Bar Drop Down Menu Option"));

        public void SetStatusInactive() =>
         AllureLogger.LogStep("I set status inactive", () =>
             SafeActions.Click(driver, By.Id("menu0_INACTIVE_OPTION_a_tnode"),
                               "I set status inactive"));

            public void VerifyStatusIsINACTIVE() =>
        AllureLogger.LogStep("I verify status is INACTIVE", () =>
        {
             try
             {

                  Task.Delay(10000).Wait();
                  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#m2fff770a-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();
   
                  // Verify the status is exactly "INACTIVE"
                  if (!string.Equals(actualStatus, "INACTIVE", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Failure: Status is not INACTIVE. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is INACTIVE.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });


        public void SelectOkButton() =>
          AllureLogger.LogStep("I select Ok Button", () =>
              SafeActions.Click(driver, By.CssSelector("#m60bd6d91-pb"),
                                "I select Ok Button"));

         public void TakeScreenshotOfCreationOfAQualificationTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-200SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-200SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-200SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        //Delete Qualification POM Steps Definitions




        public void FilterTableQualifications(string Qualifications) =>
       AllureLogger.LogStep($"filter table Qualifications'{Qualifications}'", () =>
       {
           By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Qualifications);
           filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromQualificationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Qualification Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Qualification Table Records");
                Task.Delay(5000).Wait();
            });
        }


        public void SelectDeleteQualifications() =>
         AllureLogger.LogStep("I select delete Qualifications", () =>
             SafeActions.Click(driver, By.Id("m74daaf83_ns_menu_DELETE_OPTION_a_tnode"),
                               "I select delete Qualifications"));

        public void PressYesDialogButton() =>
         AllureLogger.LogStep("I press Yes dialog button", () =>
             SafeActions.Click(driver, By.CssSelector("#me1720906-pb"),
                               "I press Yes dialog button"));

        public void VerifyTableHasNoRecords()
        {



            AllureLogger.LogStep("I verify table has no records", () =>
            {
                // Click the refresh button
                var refreshButton = By.CssSelector("#m6a7dfd2f-img5");
                SafeActions.Click(driver, refreshButton, "Clicking refresh button on table");

                // Wait for the table to reload – use a reliable condition
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d =>
                {
                    var rows = d.FindElements(By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb"));
                    return rows.Count == 0 || rows.All(row => row.Text.Contains("No records found") || string.IsNullOrWhiteSpace(row.Text));
                });

                // Verify that no records exist in the table
                var tableRows = driver.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                int rowCount = tableRows.Count;

                // If table shows a "no records" placeholder row, consider it as empty
                if (rowCount > 0 && tableRows.Any(row => !row.Text.Contains("No records found") && !string.IsNullOrWhiteSpace(row.Text)))
                {
                    throw new Exception($"Expected 0 records in the table, but found {rowCount}.");
                }
            });
                      
        }


         public void TakeScreenshotOfDeleteQualificationTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-200SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-200SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-200SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });





        // Association of a Qualification to a Labour Record POM Steps Definitions




         public void TakeScreenshotOfCraftSkillLevel() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-002SC01", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-002SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-002SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void VerifyStatusIsACTIVE() =>
        AllureLogger.LogStep("I verify status is ACTIVE", () =>
        {
            try
            {


                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                // Wait for the status field to be visible
                var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#m2fff770a-tb")));

                // Get the actual value of the field
                string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "ACTIVE"
                if (!string.Equals(actualStatus, "ACTIVE", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception($"Failure: Status is not ACTIVE. Actual value: '{actualStatus ?? "null"}'");
                }

                Console.WriteLine("Success: Status is ACTIVE.");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Error: Status element not found - " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        });


        
         public void TakeScreenshotOfAssociationOfAQualificationToALabourRecordTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-002SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-002SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-002SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Association of a Qualification to a Labour Record POM Steps Definitions





         public void FilterTableLabor(string labor) =>
       AllureLogger.LogStep($"filter table Qualifications'{labor}'", () =>
       {
           By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(labor);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(3000).Wait();
       });

        public void SelectNoRecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From labor Table Records");
                Task.Delay(5000).Wait();
            });
        }


        public void GoToQualificationsTab() =>
            AllureLogger.LogStep("I go to Qualifications tab", () =>
                SafeActions.Click(driver,
                    By.Id("m981fc5cb-tab_anchor"),
                    "I go to Qualifications tab"));

        public void SelectNewRowButton() =>
            AllureLogger.LogStep("I select New Row Button", () =>
                SafeActions.Click(driver,
                    By.CssSelector("#m90d92e4e_bg_button_addrow-pb"),
                    "I select New Row Button"));


          public void DetailMenuOfQualification() =>
         AllureLogger.LogStep("Detail Menu Of Qualification", () =>
             SafeActions.Click(driver, By.CssSelector("#m418c2ef7-img"),
                               "Detail Menu Of Qualification"));

          public void SelectValueOptionOfQualification() =>
         AllureLogger.LogStep("Select Value Option Of Qualification", () =>
             SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                               "Select Value Option Of Qualification"));


         public void FilterTableQualification(string Qualification) =>
       AllureLogger.LogStep($"filter table Qualifications'{Qualification}'", () =>
       {
           By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Qualification);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(3000).Wait();
       });

        public void SelectNoFromQualificationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Qualification Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m90d92e4e_tdrow_[C:0]_tgdet-ti[R:{zeroBasedIndex}]_img";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Qualification Table Records");
                Task.Delay(5000).Wait();
            });
        }

        public void SelectNoRecordFromQualificationTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Qualification Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Qualification Table Records");
                Task.Delay(5000).Wait();
            });
        }

        public void TakeScreenshotOfAssociationOfAQualificationToALabourRecord() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-002SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-002SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-002SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        public void SelectTheFilterOption() =>
           AllureLogger.LogStep("I select the filter option", () =>
               SafeActions.Click(driver,
                   By.CssSelector("#m90d92e4e-lb2"),
                   "I select the filter option"));


         public void FilterQualificationTable(string Qualification) =>
       AllureLogger.LogStep($"filter table Qualifications'{Qualification}'", () =>
       {
           By filterFieldLocator = By.CssSelector("#m90d92e4e_tfrow_\\[C\\:1\\]_txt-tb");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

           filterField.Click();
           filterField.Clear();
           filterField.SendKeys(Qualification);
           filterField.SendKeys(Keys.Enter);
           Task.Delay(3000).Wait();
       });

        public void DropdownMenu() =>
          AllureLogger.LogStep("Status Bar Drop Down Menu", () =>
              SafeActions.Click(driver, By.CssSelector("#mc927149a-img"),
                                "Status Bar Drop Down Menu"));


        public void TakeScreenshotOfSetQualificationInactive() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-002SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-002SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-002SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });




        // View a List of Labor Records with Qualifications Soon to Expire POM Steps Definitions


         public void GoToCMSAdministratorTab() =>
          AllureLogger.LogStep("I go to CMS Administrator tab", () =>
              SafeActions.Click(driver, By.Id("m1e20cba1-sct_anchor_0"),
                                "I go to CMS Administrator tab"));

         public void OpenResultSetInTheApplication() =>
          AllureLogger.LogStep("I Open Result Set in the Application", () =>
              SafeActions.Click(driver, By.CssSelector("#m62cafa92-img4"),
                                "I Open Result Set in the Application"));

         public void TakeScreenshotOfViewAListOfLaborRecordsWithQualificationsSoonToExpireTest() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-003", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-003.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-003_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });






        // Creating new Training Course Job Plans POM Steps Definitions




         public void TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-004SC01", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-004SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-004SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



         public void PlanningMenuButton() =>
            AllureLogger.LogStep("Planning Menu Button", () =>
                SafeActions.Click(driver, By.Id("menu0_PLANS_MODULE_a_tnode"),
                                  "Planning Menu Button"));

            public void OpenApplicationJobPlansTr() =>
            AllureLogger.LogStep("Open Application Job Plans Tr", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_PLANS_MODULE_sub_changeapp_PLUSTJP_a_tnode"),
                    "Open Application Job Plans Tr"));


         public void SelectNewJobPlan() =>
           AllureLogger.LogStep("I select New Job Plan", () =>
               SafeActions.Click(driver,
                   By.Id("toolactions_INSERT-tbb_image"),
                   "I select New Job Plan"));


          public void EnterJobPlan(string ID, string Description) =>
        AllureLogger.LogStep($"I enter Job Plan = '{ID}', Description = '{Description}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By IDLocator = By.CssSelector("#m8ee1358-tb");
            By DescriptionLocator = By.CssSelector("#m8ee1358-tb2");
           
            // Description filter
            IWebElement IDFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(IDLocator));
            IDFilter.Click();
            IDFilter.Clear();
            IDFilter.SendKeys(ID);

            // Status filter
            IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);
            
        });


        public void OpenSelectValueLookupOfOrganisationField() =>
           AllureLogger.LogStep("I open Select Value lookup of Organisation field", () =>
               SafeActions.Click(driver,
                   By.CssSelector("#m91e742e2-img"),
                   "I open Select Value lookup of Organisation field"));



        public void SelectNoRecordFromOrganisationTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Organisation Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Organisation Table Records");
                Task.Delay(5000).Wait();
            });
        }



        public void OpenSelectValueLookupOfSiteField() =>
          AllureLogger.LogStep("I open Select Value lookup of Site field", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#me6e07274-img"),
                  "I open Select Value lookup of Site field"));


        public void SelectNoRecordFromSiteTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Site Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Site Table Records");
                Task.Delay(5000).Wait();
            });
        }


         public void EnterDuration(string Duration) =>
       AllureLogger.LogStep($"I enter Required Use Length'{Duration}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#m551e658-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Duration);
     
       });


          public void SelectNewRowButtonUnderJobPlansTasksSection() =>
          AllureLogger.LogStep("I select New Row button under Job Plans Tasks section", () =>
              SafeActions.Click(driver,
                  By.CssSelector("#mc564eb3c_bg_button_addrow-pb"),
                  "I select New Row button under Job Plans Tasks section"));


         public void TaskDescription(string TaskDescription) =>
       AllureLogger.LogStep($"I enter Task Description'{TaskDescription}'", () =>
       {
           Task.Delay(5000).Wait();
           By filterFieldLocator = By.CssSelector("#m79f34481-tb2");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(TaskDescription);
         
       });

        public void OpenSelectValueLookupOfQualificationsField() =>
         AllureLogger.LogStep("I open Select Value lookup of Qualifications field", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#me413054c-img"),
                 "I open Select Value lookup of Qualifications field"));


         public void SelectYesDialogButtonOfSystemMessage() =>
           AllureLogger.LogStep("I select yes dialog button of System Message", () =>
               SafeActions.Click(driver,
                   By.CssSelector("#me1720906-pb"),
                   "I select yes dialog button of System Message"));


        public void SelectNewRow() =>
         AllureLogger.LogStep("I select New Row", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#m6ebbfb3d_bg_button_addrow-pb"),
                 "I select New Row"));


          public void FilterQualification(string Qualification) =>
       AllureLogger.LogStep($"I filter Qualification'{Qualification}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Qualification);
          filterField.SendKeys(Keys.Enter);
       });

        public void ChangeStatusButton() =>
         AllureLogger.LogStep("I select Change Status Button", () =>
             SafeActions.Click(driver,
                 By.Id("toolactions_STATUS-tbb_image"),
                 "I select Change Status Button"));

        public void SelectDropdownNewStatusMenuOption() =>
         AllureLogger.LogStep("I select Drop Down New Status Menu Option", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#ma9cc2b8f-img"),
                 "I select Drop Down New Status Menu Option"));

        public void SelectACTIVEFromNewStatusMenuOption() =>
          AllureLogger.LogStep("I Select ACTIVE From New Status Menu Option", () =>
              SafeActions.Click(driver,
                  By.Id("menu0_ACTIVE_OPTION_a_tnode"),
                  "I Select ACTIVE From New Status Menu Option"));


        public void ClickOk() =>
        AllureLogger.LogStep("I Click Ok", () =>
            SafeActions.Click(driver,
                By.CssSelector("#m60bd6d91-pb"),
                "I Click Ok"));

          public void VerifyStatusACTIVE() =>
        AllureLogger.LogStep("I verify status is ACTIVE", () =>
        {
             try
             {

                Task.Delay(10000).Wait();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#m9c58b7e2-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "ACTIVE"
                if (!string.Equals(actualStatus, "ACTIVE", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Failure: Status is not ACTIVE. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is ACTIVE.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });

          public void VerifyJobPlansStatusACTIVE() =>
        AllureLogger.LogStep("I verify Job Plans status ACTIVE", () =>
        {
             try
             {

                Task.Delay(10000).Wait();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#m9c58b7e2-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "ACTIVE"
                if (!string.Equals(actualStatus, "ACTIVE", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Failure: Status is not ACTIVE. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is ACTIVE.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });



        public void TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-004SC02", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-004SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-004SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void OpenSelectValueLookupOfNestedJobPlanField() =>
       AllureLogger.LogStep("I open Select Value lookup of Nested Job Plan field", () =>
           SafeActions.Click(driver,
               By.CssSelector("#m999b00e-img"),
               "I open Select Value lookup of Nested Job Plan field"));



          public void FilterNestedJobPlan(string Description) =>
       AllureLogger.LogStep($"I filter Nested Job Plan'{Description}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:3\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Description);
          filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromNestedJobPlanTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Nested Job Plan Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Nested Job Plan Table Records");
                Task.Delay(5000).Wait();
            });
        }


         public void SelectNewRowButtonUnderPlannedLaborSection() =>
       AllureLogger.LogStep("I select New Row button under Planned Labor section", () =>
           SafeActions.Click(driver,
               By.CssSelector("#ma0e8b2fb_bg_button_addrow-pb"),
               "I select New Row button under Planned Labor section"));


         public void EnterTaskValue(string TaskValue) =>
       AllureLogger.LogStep($"I enter Task Value'{TaskValue}'", () =>
       {
           Task.Delay(3000).Wait();
           By filterFieldLocator = By.CssSelector("#m9baf3199-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(TaskValue);
         
       });

        public void DetailMenuOfCraft() =>
          AllureLogger.LogStep("Detail Menu Of Craft", () =>
              SafeActions.Click(driver, By.CssSelector("#m99e98fc0-img"),
                                "Detail Menu Of Craft Field"));

        public void SelectValueOption() =>
           AllureLogger.LogStep("Select Value Option of Craft", () =>
               SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                                 "Select Value Option of Craft"));

          public void FilterTableCraft(string Craft, string SkillLevel) =>
        AllureLogger.LogStep($"I enter Job Plan = '{Craft}', Description = '{SkillLevel}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By CraftLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            By SkillLevelLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");
           
            // Description filter
            IWebElement CraftFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CraftLocator));
            CraftFilter.Click();
            CraftFilter.Clear();
            CraftFilter.SendKeys(Craft);

            // Status filter
            IWebElement SkillLevelFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SkillLevelLocator));
            SkillLevelFilter.Click();
            SkillLevelFilter.Clear();
            SkillLevelFilter.SendKeys(SkillLevel);
            SkillLevelFilter.SendKeys(Keys.Enter);


        });

        public void SelectNoRecordFromCraftTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Craft Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Craft Table Records");
                Task.Delay(5000).Wait();
            });
        }


        public void TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariothree() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-004SC03", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-004SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-004SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



         public void FilterTableJobPlans(string JobPlans) =>
       AllureLogger.LogStep($"I filter Job Plans'{JobPlans}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(JobPlans);
          filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromJobPlansTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Job Plan Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Job Plan Table Records");
                Task.Delay(5000).Wait();
            });
        }


         public void SelectDeleteJobPlans() =>
        AllureLogger.LogStep("I select delete Job Plans", () =>
            SafeActions.Click(driver,
                By.Id("m74daaf83_ns_menu_DELETE_OPTION_a_tnode"),
                "I select delete Job Plans"));

         public void PressYesButton() =>
        AllureLogger.LogStep("I press Yes button", () =>
            SafeActions.Click(driver,
                By.CssSelector("#me1720906-pb"),
                "I press Yes button"));


        public void VerifyJobPlansTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify Job Plans table has no records", () =>
            {
                // Click the refresh button
                var refreshButton = By.CssSelector("#m6a7dfd2f-img5"); 
                SafeActions.Click(driver, refreshButton, "Clicking refresh button on Job Plans table");

                // Wait for the table to reload – use a reliable condition
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d =>
                {
                    var rows = d.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                    return rows.Count == 0 || rows.All(row => row.Text.Contains("No records found") || string.IsNullOrWhiteSpace(row.Text));
                });

                // Verify that no records exist in the table
                var tableRows = driver.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                int rowCount = tableRows.Count;

                // If table shows a "no records" placeholder row, consider it as empty
                if (rowCount > 0 && tableRows.Any(row => !row.Text.Contains("No records found") && !string.IsNullOrWhiteSpace(row.Text)))
                {
                    throw new Exception($"Expected 0 records in the table, but found {rowCount}.");
                }
            });
        }



        public void TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariofour() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-004SC04", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-004SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-004SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariofive() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-004SC05", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-004SC05.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-004SC05_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void TakeScreenshotOfCreatingNewTrainingCourseJobPlansTestScenariosix() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-004SC06", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-004SC06.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-004SC06_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


        public void SelectValueLookupOfQualificationRequirementsField() =>
        AllureLogger.LogStep("I open Select Value lookup of Qualification Requirements field", () =>
            SafeActions.Click(driver, By.CssSelector("#mae285089-img"),
                              "I open Select Value lookup of Qualification Requirements field"));

         public void FilterQualificationRequirements(string Qualification) =>
       AllureLogger.LogStep($"I filter Qualification'{Qualification}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#lookup_page2_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Qualification);
          filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromQualificationRequirementsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Qualification Requirements Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page2_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Qualification Requirements Table Records");
                Task.Delay(5000).Wait();
            });
        }


        public void PressOkDialogButton() =>
       AllureLogger.LogStep("I Press Ok dialog button", () =>
           SafeActions.Click(driver, By.CssSelector("#m80414ea4-pb"),
                             "I Press Ok dialog button"));







        // Creating a new Training Course Work Order Template POM Steps Definitions







         public void TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenarioOne() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-005ASC01", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-005ASC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-005ASC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        public void OpenWorkOrderMenu() =>
          AllureLogger.LogStep("Open [Work Order] menu", () =>
              SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                "Work Order menu node"));

        public void OpenApplicationWorkOrderTemplateBRDA() =>
            AllureLogger.LogStep("Launch Work Order Template (BRDA)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_WO_MODULE_sub_changeapp_BRDAWT_a_tnode"),
                    "Launch Work Order Template (BRDA)"));


         public void SelectNewRecord() =>
        AllureLogger.LogStep("I select new record", () =>
            SafeActions.Click(driver,
                By.Id("toolactions_INSERT-tbb_image"),
                "I select new record"));


          public void EnterWorkOrderTemplateDetails(string ID, string Description) =>
        AllureLogger.LogStep($"I enter Work Order Template = '{ID}', Description = '{Description}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By IDLocator = By.CssSelector("#m50d84adb-tb");
            By DescriptionLocator = By.CssSelector("#m50d84adb-tb2");
           
            // Description filter
            IWebElement IDFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(IDLocator));
            IDFilter.Click();
            IDFilter.Clear();
            IDFilter.SendKeys(ID);

            // Status filter
            IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);
            
        });


         public void DetailMenuOfAssetGroup() =>
          AllureLogger.LogStep("Detail Menu Of Asset Group", () =>
              SafeActions.Click(driver, By.CssSelector("#m72c11027-img"),
                                "Detail Menu Of Asset Group Field"));

        public void SelectValueOptionOfAssetGroup() =>
           AllureLogger.LogStep("Select Value Option of Asset Group", () =>
               SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                                 "Select Value Option of Asset Group"));

         public void SelectNoRecordFromAssetGroupTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Asset Group Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Asset Group Table Records");
                Task.Delay(5000).Wait();
            });
         }


        public void OpenSelectValueLookupOfWorkTypeField() =>
        AllureLogger.LogStep("I open Select Value lookup of Work Type field", () =>
            SafeActions.Click(driver,
                By.CssSelector("#m1959e344-img"),
                "I open Select Value lookup of Work Type field"));


         public void FilterWorkType(string WorkType) =>
       AllureLogger.LogStep($"I filter Work Type'{WorkType}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:2\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(WorkType);
          filterField.SendKeys(Keys.Enter);
       });


        public void SelectNoRecordFromTemplateWorkTypeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Template Work Type Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Template Work Type Table Records");
                Task.Delay(5000).Wait();
            });
        }


         public void DetailMenuOfJobPlan() =>
          AllureLogger.LogStep("Detail Menu Of Job Plan", () =>
              SafeActions.Click(driver, By.CssSelector("#ma1857f9-img"),
                                "Detail Menu Of Job Plan"));

        public void SelectValueOptionOfJobPlan() =>
           AllureLogger.LogStep("Select Value Option of Job Plan", () =>
               SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                                 "Select Value Option of Job Plan"));



         public void FilterJobPlan(string JobPlan) =>
       AllureLogger.LogStep($"I filter Job Plan'{JobPlan}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(JobPlan);
          filterField.SendKeys(Keys.Enter);
       });


         public void SelectNoRecordFromJobPlanTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Job Plan Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Job Plan Table Records");
                Task.Delay(5000).Wait();
            });
         }

         public void OpenSelectValueOfStatusField() =>
         AllureLogger.LogStep("I Open Select Value Of Status Field", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#m1e34275d-img"),
                 "I Open Select Value Of Status Field"));
               
        public void SelectStatusACTIVE() =>
          AllureLogger.LogStep("I Select ACTIVE", () =>
              SafeActions.Click(driver,
                  By.Id("lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]"),
                  "I Select ACTIVE"));



         public void VerifyTemplateStatusACTIVE() =>
        AllureLogger.LogStep("I verify template status ACTIVE", () =>
        {
             try
             {

                Task.Delay(10000).Wait();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#m1e34275d-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "ACTIVE"
                if (!string.Equals(actualStatus, "ACTIVE", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Failure: Status is not ACTIVE. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is ACTIVE.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });

         public void TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariotwo() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-005ASC02", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-005ASC02.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-005ASC02_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        public void FilterTableWorkOrderTemplate(string ID) =>
      AllureLogger.LogStep($"I filter Work Type'{ID}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(ID);
          filterField.SendKeys(Keys.Enter);
      });

        public void SelectNoRecordFromWorkOrderTemplateTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Work Order Template Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Work Order Template Table Records");
                Task.Delay(5000).Wait();
            });
        }

        public void SelectDeleteWorkOrderTemplateRecord() =>
       AllureLogger.LogStep("I select delete Work Order Template record", () =>
           SafeActions.Click(driver,
               By.Id("m74daaf83_ns_menu_DELETE_OPTION_a_tnode"),
               "I select delete Work Order Template record"));


        public void VerifyWorkOrderTemplateTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify Work Order Template table has no records", () =>
            {
                // Click the refresh button
                var refreshButton = By.CssSelector("#m6a7dfd2f-img5");
                SafeActions.Click(driver, refreshButton, "Clicking refresh button on Work Order Template table");

                // Wait for the table to reload – use a reliable condition
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d =>
                {
                    var rows = d.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                    return rows.Count == 0 || rows.All(row => row.Text.Contains("No records found") || string.IsNullOrWhiteSpace(row.Text));
                });

                // Verify that no records exist in the table
                var tableRows = driver.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                int rowCount = tableRows.Count;

                // If table shows a "no records" placeholder row, consider it as empty
                if (rowCount > 0 && tableRows.Any(row => !row.Text.Contains("No records found") && !string.IsNullOrWhiteSpace(row.Text)))
                {
                    throw new Exception($"Expected 0 records in the table, but found {rowCount}.");
                }
            });
        }


        public void TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariothree() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-005ASC03", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-005ASC03.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-005ASC03_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTemplateTestScenariofour() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-005ASC04", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-005ASC04.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-005ASC04_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });





        // Creating a new Training Course Work Order POM Steps Definitions





          public void EnterWorkOrder(string Description) =>
         AllureLogger.LogStep($"I enter work order'{Description}'", () =>
         {

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By filterFieldLocator = By.CssSelector("#mad3161b5-tb2");
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(Description);
          
         });

         public void SetWorkTypeField(string WorkType) =>
         AllureLogger.LogStep($"I set Work Type field'{WorkType}'", () =>
         {

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By filterFieldLocator = By.CssSelector("#me2096203-tb");
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(WorkType);
          
         });

         public void VerifyWorkOrderStatusWAITREV() =>
        AllureLogger.LogStep("I verify work order status WAIT-REV", () =>
        {
             try
             {

                Task.Delay(10000).Wait();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#md3801d08-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "WAIT-REV"
                if (!string.Equals(actualStatus, "WAIT-REV", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Failure: Status is not WAIT-REV. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is WAIT-REV.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });


         public void TakeScreenshotOfCreatingANewTrainingCourseWorkOrderTest() =>
      AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-005B", () =>
      {
          try
          {
              Task.Delay(5000).Wait();
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-005B.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-005B_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });




        // Scheduling a Training Course (in Graphical Scheduling) POM Steps Definitions






        public void PlanningAndSchedulingMenuButton() =>
         AllureLogger.LogStep("Open Planning And Scheduling Menu Button", () =>
             SafeActions.Click(driver, By.Id("menu0_SCHEDULER_MODULE_a_tnode"),
                               "Planning And Scheduling Menu Button"));

        public void GraphicalSchedulingButton() =>
            AllureLogger.LogStep("Launch Graphical Scheduling", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_SCHEDULER_MODULE_sub_changeapp_SCHEDACM_a_tnode"),
                    "Launch Graphical Scheduling"));


        public void SelectCreateNewSchedule() =>
       AllureLogger.LogStep("I select create new schedule", () =>
           SafeActions.Click(driver,
               By.Id("toolactions_INSERT-tbb_image"),
               "I select create new schedule"));


         public void EnterScheduleID(string ID, string Description) =>
        AllureLogger.LogStep($"I enter Work Order Template = '{ID}', Description = '{Description}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By IDLocator = By.CssSelector("#mad3161b5-tb");
            By DescriptionLocator = By.CssSelector("#mad3161b5-tb2");
           
            // Description filter
            IWebElement IDFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(IDLocator));
            IDFilter.Click();
            IDFilter.Clear();
            IDFilter.SendKeys(ID);

            // Status filter
            IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);
            
        });

        public void DetailMenuOfcalendar() =>
          AllureLogger.LogStep("Detail Menu Of calendar", () =>
              SafeActions.Click(driver, By.CssSelector("#m3438300f-img"),
                                "Detail Menu Of calendar Field"));

        public void SelectValueOptionOfcalendar() =>
           AllureLogger.LogStep("Select Value Option of calendar", () =>
               SafeActions.Click(driver, By.Id("CALENDAR_calendar0_a_tnode"),
                                 "Select Value Option of calendar"));


        public void SelectGTRBASE() =>
       AllureLogger.LogStep("I select GTRBASE", () =>
           SafeActions.Click(driver,
               By.Id("lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]"),
               "I select GTRBASE"));

         public void SelectCopyQueryButtonUnderWorkQueriesSection() =>
       AllureLogger.LogStep("I select Copy Query button under Work Queries section", () =>
           SafeActions.Click(driver,
               By.CssSelector("#m7ad62980_bg_button_selectquery-pb"),
               "I select Copy Query button under Work Queries section"));



         public void FilterTableQuery(string Query) =>
         AllureLogger.LogStep($"I filter table Query'{Query}'", () =>
         {
             By filterFieldLocator = By.CssSelector("#m4577f3eb_tfrow_\\[C\\:2\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(Query);
             filterField.SendKeys(Keys.Enter);


         });


        public void SelectNoFromQueryTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Query Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m4577f3eb_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Query Table Records");
                Task.Delay(5000).Wait();
            });
        }

         public void PressDialogOkButtonOfCopyQuery() =>
       AllureLogger.LogStep("I press dialog ok button of copy Query", () =>
           SafeActions.Click(driver,
               By.CssSelector("#m6a1295ef-pb"),
               "I press dialog ok button of copy Query"));

           public void WaitForQueryToLoad() =>
        AllureLogger.LogStep("I wait for Query to load", () =>
        {
            Task.Delay(350000).Wait();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

             // Define the ID of the element that indicates the query page is loaded
             string selectorId = "m397b0593-tabs_middle";

            // Wait until the element is clickable
             wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(selectorId)));
            Task.Delay(20000).Wait();
        });


         public void GoToTabGraphicalView() =>
       AllureLogger.LogStep("I go to tab Graphical View", () =>
           SafeActions.Click(driver,
               By.Id("m71dde5a3-tab_anchor"),
               "I go to tab Graphical View"));


        public void WaitForGraphicalPageToLoad() =>
       AllureLogger.LogStep("I wait for Query to load", () =>
       {
           Task.Delay(250000).Wait();
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

           // Define the ID of the element that indicates the query page is loaded
           string selectorId = "md86fe08f_ns_menu_COMMIT_OPTION_a_tnode";

           // Wait until the element is clickable
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(selectorId)));
           Task.Delay(5000).Wait();
       });



          public void SelectCommitChanges() =>
       AllureLogger.LogStep("I select Commit Changes", () =>
           SafeActions.Click(driver,
               By.Id("md86fe08f_ns_menu_COMMIT_OPTION_a_tnode"),
               "I select Commit Changes"));

          public void ClickYesDialogButton() =>
       AllureLogger.LogStep("I click yes dialog button", () =>
           SafeActions.Click(driver,
               By.CssSelector("#me1720906-pb"),
               "I click yes dialog button"));

          public void PressOKDialogButtonOfSystemMessage() =>
       AllureLogger.LogStep("I press OK dialog button of system message", () =>
           SafeActions.Click(driver,
               By.CssSelector("#m88dbf6ce-pb"),
               "I press OK dialog button of system message"));

          public void ChangeStatus() =>
       AllureLogger.LogStep("I select Change Status", () =>
           SafeActions.Click(driver,
               By.Id("md86fe08f_ns_menu_STATUSMAIN_OPTION_a_tnode"),
               "I select Change Status"));

        public void DropDownMenuOption() =>
       AllureLogger.LogStep("Drop Down Menu Option", () =>
           SafeActions.Click(driver,
               By.CssSelector("#m392ddbaa-img"),
               "Drop Down Menu Option"));

         public void SelectApproved() =>
       AllureLogger.LogStep("I select Approved", () =>
           SafeActions.Click(driver,
               By.Id("menu0_APPR_OPTION_a_tnode"),
               "I select Approved"));


         public void SelectOk() =>
       AllureLogger.LogStep("I click yes dialog button", () =>
           SafeActions.Click(driver,
               By.CssSelector("#mce78731e-pb"),
               "I click yes dialog button"));

         public void GoToTabSchedule() =>
       AllureLogger.LogStep("I go to tab Schedule", () =>
           SafeActions.Click(driver,
               By.Id("mbf28cd64-tab_anchor"),
               "I go to tab Schedule"));


         public void VerifyStatusAPPROVED() =>
        AllureLogger.LogStep("I verify template status APPROVED", () =>
        {
             try
             {

                Task.Delay(10000).Wait();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#ma3558a76-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "APPR"
                if (!string.Equals(actualStatus, "APPR", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Failure: Status is not APPR. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is APPR.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });


            public void TakeScreenshotOfSchedulingATrainingCourseInGraphicalSchedulingTestScenarioOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-006A", () =>
        {
            try
            {
                Task.Delay(5000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-006A.png";

               takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-006A_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
            }
       });



         public void FilterTableGraphicalScheduling(string GraphicalScheduling) =>
       AllureLogger.LogStep($"I filter Job Plan'{GraphicalScheduling}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(GraphicalScheduling);
          filterField.SendKeys(Keys.Enter);
           Task.Delay(5000).Wait();
       });


        public void SelectNoRecordFromGraphicalSchedulingTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  Graphical Scheduling Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From  Graphical Scheduling Table Records");
                Task.Delay(5000).Wait();
            });
        }

         public void SelectDeleteGraphicalSchedulingRecord() =>
       AllureLogger.LogStep("I select delete Graphical Scheduling record", () =>
           SafeActions.Click(driver,
               By.Id("md86fe08f_ns_menu_DELETE_OPTION_a_tnode"),
               "I select delete Graphical Scheduling record"));


        public void VerifyGraphicalSchedulingTableHasNoRecords()
        {
            AllureLogger.LogStep("I verify Graphical Scheduling table has no records", () =>
            {
                // Click the refresh button
                var refreshButton = By.CssSelector("#m6a7dfd2f-img5");
                SafeActions.Click(driver, refreshButton, "Clicking refresh button on Work Order Template table");

                // Wait for the table to reload – use a reliable condition
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d =>
                {
                    var rows = d.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                    return rows.Count == 0 || rows.All(row => row.Text.Contains("No records found") || string.IsNullOrWhiteSpace(row.Text));
                });

                // Verify that no records exist in the table
                var tableRows = driver.FindElements(By.CssSelector("#m6a7dfd2f_tbod_tempty_tcell_statictext-lb"));
                int rowCount = tableRows.Count;

                // If table shows a "no records" placeholder row, consider it as empty
                if (rowCount > 0 && tableRows.Any(row => !row.Text.Contains("No records found") && !string.IsNullOrWhiteSpace(row.Text)))
                {
                    throw new Exception($"Expected 0 records in the table, but found {rowCount}.");
                }
            });
        }


        public void TakeScreenshotOfSchedulingATrainingCourseInGraphicalSchedulingTestScenariotwo() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-006ASC02", () =>
        {
            try
            {
                Task.Delay(5000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-006ASC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-006ASC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });






        // Scheduling a Training Course (in Work Order Tracking) POM Steps Definitions





        public void TakeScreenshotOfSchedulingATrainingCourseInWorkOrderTrackingTestScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-006BSC01", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-006BSC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-006BSC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void OpenApplicationCMSCourseWorkOrderMXR() =>
            AllureLogger.LogStep("Launch CMS Course Work Order (MXR)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_WO_MODULE_sub_changeapp_MXRCMSWO_a_tnode"),
                    "Launch CMS Course Work Order (MXR)"));


         public void FilterTableCMSCourseWorkOrder(string Description) =>
       AllureLogger.LogStep($"I filter table CMS Course Work Order'{Description}'", () =>
       {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Description);
          filterField.SendKeys(Keys.Enter);
           Task.Delay(3000).Wait();
       });

        public void SelectNoFromCMSCourseWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From CMS Course Work Order Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From CMS Course Work Order Table Records");
                Task.Delay(5000).Wait();
            });
        }


            public void SetScheduledStart() =>
         AllureLogger.LogStep("I Set Scheduled Start Date", () =>
         {
                  
             // Date format expected by the input. Adjust if the control needs a different one.
             string today = DateTime.Today.AddDays(-5).ToString("dd-MM-yyyy");

             var locator = By.CssSelector("#m5401b8f3-tb");
              var dateBox = driver.FindElement(locator);

              dateBox.Clear();
              dateBox.SendKeys(today);
              dateBox.SendKeys(Keys.Enter);          
         });

        public void SetScheduledFinishDate() =>
         AllureLogger.LogStep("I Scheduled Finish date", () =>
         {

             // Date format expected by the input. Adjust if the control needs a different one.
             string today = DateTime.Today.AddDays(+5).ToString("dd-MM-yyyy");

             var locator = By.CssSelector("#m7f6d89d8-tb");
             var dateBox = driver.FindElement(locator);

             dateBox.Clear();
             dateBox.SendKeys(today);
             dateBox.SendKeys(Keys.Enter);
         });


           public void VerifyGeneratedWorkOrderNumber() =>
        AllureLogger.LogStep("I verify Scheduled Start", () =>
        {
           try
           {
                // Wait 5 seconds for the page or element to load
                Task.Delay(5000).Wait();

                // Find the Related Work Order element by CSS selector
                var relatedWorkOrder = driver.FindElement(By.CssSelector("#m7f6d89d8-tb"));

                // Get the 'value' attribute of the element
                string ScheduledStart = relatedWorkOrder.GetAttribute("value");

                // Check if the Scheduled Start is null or empty
                if (string.IsNullOrEmpty(ScheduledStart))
                {
                    throw new Exception("Failure:Scheduled Start is empty or null.");
                }

                // Log success with the Scheduled Start
                Console.WriteLine("Success: Scheduled Start is " + ScheduledStart);
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Error:Scheduled Start element not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                }
        });


         public void TakeScreenshotOfSchedulingATrainingCourseInWorkOrderTrackingTestScenarioTwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-006BSC02", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-006BSC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-006BSC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });






        // Allocating a Trainer & Classroom to a Training Course (in Graphical Assignment) POM Steps Definitions




            public void EnterLongDescription(string longDescription) =>
           AllureLogger.LogStep($"I enter long description '{longDescription}'", () =>
           {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

               // 1. Click the long description icon (replace selector as needed)
               By iconLocator = By.CssSelector("#mad3161b5-img2");
               IWebElement iconElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(iconLocator));
               iconElement.Click();

               // 2. Wait for the iframe to appear and switch to it
               wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Id("ma6499a9c-rte_iframe")));

               // 3. Wait for the textarea or input inside the iframe to be ready
               By descriptionFieldLocator = By.XPath("//*[@id='dijitEditorBody']");
               IWebElement descriptionField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(descriptionFieldLocator));
        
               descriptionField.Clear();
               descriptionField.SendKeys(longDescription);

               // 4. Switch back to the main document
                driver.SwitchTo().DefaultContent();
           });


           public void SelectTheOkButton() =>
         AllureLogger.LogStep("I select the Ok button", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m74031266-pb"),
               "I select the Ok button"));



           public void SelectListViewButton() =>
         AllureLogger.LogStep("I select list view button", () =>
             SafeActions.Click(driver,
               By.Id("m397b0593-tabs_middle"),
               "I select list view button"));

         public void FilterGraphicalSchedulingTable(string ID) =>
         AllureLogger.LogStep($"I filter Graphical Scheduling'{ID}'", () =>
         {
             By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(ID);
             filterField.SendKeys(Keys.Enter);
             Task.Delay(3000).Wait();
         });



        public void SelectNoFromGraphicalSchedulingTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Graphical Scheduling Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Graphical Scheduling Table Records");
                Task.Delay(5000).Wait();
            });
        }

         public void TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInGraphicalAssignmentTestScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-007ASC01", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-007ASC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-007ASC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

         public void TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInGraphicalAssignmentTestScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-007ASC02", () =>
       {
           try
           {
               Task.Delay(5000).Wait();
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-007ASC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-007ASC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });







        // Allocating a Trainer & Classroom to a Training Course (in Work Order Tracking) POM Steps Definitions







          public void TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInWorkOrderTrackingTestScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-007BSC01", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-007BSC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-007BSC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });

        public void FilterWorkOrder(string description, string WorkType) =>
         AllureLogger.LogStep($"I filter  work Order table with Description = '{description}', WorkType = '{WorkType}'", () =>
         {
             
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
             By WorkTypeFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:4\\]_txt-tb");

             
             IWebElement descriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(descriptionFilterLocator));
             descriptionFilter.Click();
             descriptionFilter.Clear();
             descriptionFilter.SendKeys(description);
                         
             IWebElement WorkTypeFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(WorkTypeFilterLocator));
             WorkTypeFilter.Click();
             WorkTypeFilter.Clear();
             WorkTypeFilter.SendKeys(WorkType);
             WorkTypeFilter.SendKeys(Keys.Enter);
             Task.Delay(3000).Wait();
         });

        public void SelectNoRecordFromWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Work Order Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Work Order Table Records");
                Task.Delay(3000).Wait();
            });

        }


        public void RescheduleStartDateTomorrowsDate() =>
         AllureLogger.LogStep("I Set Scheduled Start Date", () =>
         {
                  
             // Date format expected by the input. Adjust if the control needs a different one.
             string today = DateTime.Today.AddDays(-8).ToString("dd-MM-yyyy");

             var locator = By.CssSelector("#m8b12679c-tb");
              var dateBox = driver.FindElement(locator);

              dateBox.Clear();
              dateBox.SendKeys(today);
              dateBox.SendKeys(Keys.Enter);          
         });


        public void TakeScreenshotOfAllocatingATrainerClassroomToATrainingCourseInWorkOrderTrackingTestScenariotwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-007BSC02", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-007BSC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-007BSC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });






        // Allocating a Trainer, Classroom & Trainees to a Training Course (in Graphical Assignment) POM Steps Definitions




        public void GraphicalAssignment() =>
           AllureLogger.LogStep("Launch Graphical Assignment", () =>
               SafeActions.Click(driver,
                   By.Id("menu0_SCHEDULER_MODULE_sub_changeapp_RLASSIGN_a_tnode"),
                   "Launch Graphical Assignment"));


         public void EnterAssignment(string ID, string Description) =>
        AllureLogger.LogStep($"I enter Assignment = '{ID}', Description = '{Description}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By IDLocator = By.CssSelector("#m5311c821-tb");
            By DescriptionLocator = By.CssSelector("#m5311c821-tb2");
           
            // Description filter
            IWebElement IDFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(IDLocator));
            IDFilter.Click();
            IDFilter.Clear();
            IDFilter.SendKeys(ID);

            // Status filter
            IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);
            
        });

                
         public void OpenSelectValueLookupOfShiftField() =>
         AllureLogger.LogStep("I open Select Value lookup of Shift field", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m433f0099-img"),
               "I open Select Value lookup of Shift field"));


         public void SelectNoFromShiftTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Shift Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m8da9ac55_tdrow_[C:0]_tbselrow-ti[R:{zeroBasedIndex}]_img";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Shift Table Records");
                Task.Delay(3000).Wait();
            });

         }

         public void FilterGraphicalScheduling(string Description) =>
         AllureLogger.LogStep($"I filter Graphical Scheduling'{Description}'", () =>
         {
             By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(Description);
             filterField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });

         public void SelectNoRecordFromGraphicalTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Graphical Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Graphical Table Records");
                Task.Delay(5000).Wait();
            });

         }

         public void PressOkDialogSelectShiftButton() =>
         AllureLogger.LogStep("I Press Ok dialog select Shift button", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m3945131e-pb"),
               "I Press Ok dialog select Shift button"));

         public void GoToTabWorkView() =>
         AllureLogger.LogStep("I go to tab Work View", () =>
             SafeActions.Click(driver,
               By.Id("mffa89387-tab_anchor"),
               "I go to tab Work View"));


         public void WaitForWorkViewPageToLoad() =>
        AllureLogger.LogStep("I wait for Work View page to load", () =>
        {
            Task.Delay(250000).Wait();
           
        });


         public void TakeScreenshotOfAllocatingATrainerClassroomTraineesToATrainingCourseInGraphicalAssignmentTestScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-008ASC01", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-008ASC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-008ASC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });

        public void TakeScreenshotOfAllocatingATrainerClassroomTraineesToATrainingCourseInGraphicalAssignmentTestScenariotwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-008ASC02", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-008ASC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-008ASC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });






        // Allocating a Trainee to a Training Course (in Work Order Tracking)  POM Steps Definitions






        public void TakeScreenshotOfAllocatingATraineeToATrainingCourseInWorkOrderTrackingTestScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-008BSC01", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-008BSC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-008BSC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });



        public void FilterTableCMSCourseWorkOrderMXR(string Description, string Status) =>
        AllureLogger.LogStep($"I filter table CMS Course Work Order (MXR) Description = '{Description}', Status = '{Status}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By DescriptionLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");
            By StatusLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:7\\]_txt-tb");

            // Description filter
            IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);

            // Status filter
            IWebElement StatusFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(StatusLocator));
            StatusFilter.Click();
            StatusFilter.Clear();
            StatusFilter.SendKeys(Status );
            StatusFilter.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });


         public void SelectNewRowButtonUnderAssignmentsSection() =>
         AllureLogger.LogStep("I select New Row button under Assignments section", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m6798a95d_bg_button_addrow-pb"),
               "I select New Row button under Assignments section"));


         public void DetailMenuOfTheCraftField() =>
         AllureLogger.LogStep("Detail Menu of the Craft Field", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m278760cb-img"),
               "Detail Menu of the Craft Field"));

         public void SelectValueOfTheCraftField() =>
         AllureLogger.LogStep("I Select Value of the Craft Field", () =>
             SafeActions.Click(driver,
               By.Id("NORMAL_normal0_a_tnode"),
               "I Select Value of the Craft Field"));

         public void FilterCraftTable(string Craft) =>
         AllureLogger.LogStep($"I filter Craft'{Craft}'", () =>
         {
             By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(Craft);
             filterField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });

         public void SelectNoFromCraftTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Craft Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Craft Table Records");
                Task.Delay(5000).Wait();
            });
         }


         public void FilterCraftAndSkillLevelTable(string Craft, string SkillLevel) =>
        AllureLogger.LogStep($"I filter Craft and skill level table Craft = '{Craft}', SkillLevel = '{SkillLevel}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By CraftLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
            By SkillLevelLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");

            // Description filter
            IWebElement CraftFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CraftLocator));
            CraftFilter.Click();
            CraftFilter.Clear();
            CraftFilter.SendKeys(Craft);

            // Status filter
            IWebElement SkillLevelFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SkillLevelLocator));
            SkillLevelFilter.Click();
            SkillLevelFilter.Clear();
            SkillLevelFilter.SendKeys(SkillLevel);
            SkillLevelFilter.SendKeys(Keys.Enter);
            Task.Delay(5000).Wait();
        });



         public void SelectNoFromCraftAndSkillLevlTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Craft and skill levl Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Craft and skill levl Table Records");
                Task.Delay(5000).Wait();
            });
         }

        public void DetailMenuOflaborField() =>
         AllureLogger.LogStep("Detail Menu of the labor Field", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m5080505d-img"),
               "Detail Menu of the labor Field"));

         public void SelectValueOflaborField() =>
         AllureLogger.LogStep("I Select Value of the labor Field", () =>
             SafeActions.Click(driver,
               By.Id("NORMAL_normal0_a_tnode"),
               "I Select Value of the labor Field"));


         public void SelectNoFromLaborTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From labor Table Records");
                Task.Delay(5000).Wait();
            });
         }

         public void VerifyAssignmentsStatusIsASSIGNED() =>
        AllureLogger.LogStep("I verify Assignments status is ASSIGNED", () =>
        {
             try
             {

                  Task.Delay(10000).Wait();
                  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                  // Wait for the status field to be visible
                  var statusField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#mba672106-tb")));

                  // Get the actual value of the field
                  string actualStatus = statusField.GetAttribute("value")?.Trim();

                // Verify the status is exactly "ASSIGNED"
                if (!string.Equals(actualStatus, "ASSIGNED", StringComparison.OrdinalIgnoreCase))
                  {
                      throw new Exception($"Assignments: Status is not ASSIGNED. Actual value: '{actualStatus ?? "null"}'");
                  }

                      Console.WriteLine("Success: Status is ASSIGNED.");
                 }
                 catch (NoSuchElementException ex)
                 {
                     Console.WriteLine("Error: Status element not found - " + ex.Message);
                     throw;
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                     throw;
                 }
        });



        public void TakeScreenshotOfAllocatingATraineeToATrainingCourseInWorkOrderTrackingTestScenariotwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-008BSC02", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-008BSC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-008BSC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });






        //  Allocating a Trainee to a Training Course (in Work Order Tracking) 8C POM Steps Definitions





         public void TakeScreenshotOfAllocatingTraineeTrainingCourseInWorkOrderTrackingTestScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-008CSC01", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-008CSC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-008CSC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });


         public void TakeScreenshotOfAllocatingTraineeTrainingCourseInWorkOrderTrackingTestScenariotwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-008CSC02", () =>
         {
             try
             {
                 Task.Delay(5000).Wait();
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-008CSC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-008CSC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });







        // Assigning a Work Order to a Labour Record - Qualification Match POM Steps Definitions






         public void GoToTeamLeaderRoutineWorkTab() =>
         AllureLogger.LogStep("I go to Team Leader Routine Work Tab", () =>
             SafeActions.Click(driver,
               By.Id("m1e20cba1-sct_anchor_2"),
               "I go to Team Leader Routine Work Tab"));

         public void SelectWorkOrderFromTheRoutineWorkOrdersToSchedulePortlet() =>
         AllureLogger.LogStep("I select Work Order from the Routine Work Orders to Schedule portlet", () =>
             SafeActions.Click(driver,
               By.XPath("//*[@id='rsportletdata_352892']/table/tbody/tr[3]/td[1]/a"),
               "I select Work Order from the Routine Work Orders to Schedule portlet"));

        public void TakeScreenshotOfAssigningAWorkOrderToALabourRecordQualificationMatchTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-0010A", () =>
        {
            try
            {
                Task.Delay(5000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-0010A.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-0010A_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });




        // Labor Skill-Level Check - Update skill-levels POM Steps Definitions



        public void OpenApplicationBusinessRulesBRDB() =>
           AllureLogger.LogStep("Open Application Business Rules BRDB", () =>
               SafeActions.Click(driver,
                   By.Id("menu0_SETUP_MODULE_sub_changeapp_BRDBRULES_a_tnode"),
                   "Open Application Business Rules BRDB"));

         public void FilterTableBusinessRule(string BusinessRule) =>
         AllureLogger.LogStep($"I filter Business Rule'{BusinessRule}'", () =>
         {
             By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

             filterField.Click();
             filterField.Clear();
             filterField.SendKeys(BusinessRule);
             filterField.SendKeys(Keys.Enter);
             Task.Delay(5000).Wait();
         });


         public void SelectNoRecordFromBusinessRuleTableRecords(int recordNumber)
         {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Business Rule Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Business Rule Table Records");
                Task.Delay(5000).Wait();
            });
         }


        public void SelectNewRowButtonUnderTheListValuesForMXRCMSSKILLLEVELSection() =>
         AllureLogger.LogStep("I select New Row button under the List Values for MXRCMSSKILLLEVEL section", () =>
             SafeActions.Click(driver,
               By.CssSelector("#m26aedc28_bg_button_addrow-pb"),
               "I select New Row button under the List Values for MXRCMSSKILLLEVEL section"));


         public void EnterSkillLevelDetails(string Skilllevel, string Description) =>
        AllureLogger.LogStep($"I Skill level Details = Skill level '{Skilllevel}', Description = '{Description}'", () =>
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            // Adjust column indexes if needed
            By SkilllevelLocator = By.CssSelector("#m5a3a685c-tb");
            By DescriptionLocator = By.CssSelector("#m5a3a685c-tb2");
           
            // Description filter
            IWebElement SkilllevelFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SkilllevelLocator));
            SkilllevelFilter.Click();
            SkilllevelFilter.Clear();
            SkilllevelFilter.SendKeys(Skilllevel);

            // Status filter
            IWebElement DescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));
            DescriptionFilter.Click();
            DescriptionFilter.Clear();
            DescriptionFilter.SendKeys(Description);
        });


        public void TakeScreenshotOfLaborSkillLevelCheckUpdateSkillLevelsTestScenarioOne() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-0012SC01", () =>
        {
            try
            {
                Task.Delay(5000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-0012SC01.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-0012SC01_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void SelectDeleteButtonUnderTheListValuesForMXRCMSSKILLLEVELSection() =>
         AllureLogger.LogStep("I select delete button under the List Values for MXRCMSSKILLLEVEL section", () =>
             SafeActions.Click(driver,
               By.Id("m26aedc28_tdrow_[C:7]_toggleimage-ti[R:0]_img"),
               "I select delete button under the List Values for MXRCMSSKILLLEVEL section"));


         public void TakeScreenshotOfDeletingUpdatedSkillLevelsTest() =>
        AllureLogger.LogStep("Capture Screenshot for GTR-UAT-CMS-0012SC02", () =>
        {
            try
            {
                Task.Delay(5000).Wait();
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-CMS-0012SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-CMS-0012SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void VerifyTableSkillLevelsHasNoRecords()
        {
            AllureLogger.LogStep("I verify table has There are no rows to display", () =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

                // Wait for the "There are no rows to display" element or rows to be present
                var rowsOrEmptyMessage = wait.Until(driver =>
                {
                    var elements = driver.FindElements(By.Id("m26aedc28_tbod_tempty_tcell_statictext-lb"));
                    return elements.Count > 0 ? elements : null;
                });

                // Check the text content of the element
                var placeholder = rowsOrEmptyMessage.FirstOrDefault();

                if (placeholder == null)
                {
                    throw new Exception("Could not find the placeholder element for 'There are no rows to display'.");
                }

                string message = placeholder.Text.Trim();

                if (!message.Contains("There are no rows to display", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception($"Expected There are no rows to display message, but found: '{message}'");
                }

                Console.WriteLine("✅ Table correctly shows: " + message);
            });
        }







    }
}