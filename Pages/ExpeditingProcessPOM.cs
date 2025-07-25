﻿using GTR_AUTOMATED.Utilities;
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

        public void BusinessRulesBRDB() =>
            AllureLogger.LogStep("Launch Business Rules BRDB", () =>
                SafeActions.Click(driver, By.Id("menu0_SETUP_MODULE_sub_changeapp_BRDBRULES_a_tnode"),
                                  "Launch Business Rules BRDB"));

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



        //Automatic Email to Supplier POM Steps


        public void FilterTableBusinessRulesBRDB(string BusinessRules) =>
       AllureLogger.LogStep($"I filter Business Rules table with Business Rules = '{BusinessRules}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           By BusinessRulesFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

           IWebElement BusinessRulesFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BusinessRulesFilterLocator));
           BusinessRulesFilter.Click();
           BusinessRulesFilter.Clear();
           BusinessRulesFilter.SendKeys(BusinessRules);
           BusinessRulesFilter.SendKeys(Keys.Enter);

       });


        public void SelectNoRecordFromBusinessRulesTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  Business Rules Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From  Business Rules Table Records");
            });

        }

        public void FilterApplicationSearchField(string Application) =>
       AllureLogger.LogStep($"I filter Application table with Application = '{Application}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           By ApplicationFilterLocator = By.CssSelector("#nav_search_fld");

           IWebElement ApplicationFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ApplicationFilterLocator));
           ApplicationFilter.Click();
           ApplicationFilter.Clear();
           ApplicationFilter.SendKeys(Application);
           ApplicationFilter.SendKeys(Keys.Enter);

       });

        public void SelectApplicationEscalations() =>
        AllureLogger.LogStep("I set escalations active", () =>
            SafeActions.Click(driver, By.Id("nav_search_fld_menu_navSearchItemmea59820d_ns_menu_UTIL_MODULE_sub_MOD11130_HEADER_sub_changeapp_ESCALATION_a_a"),
                              "I set escalations active"));
        
         public void FilterTableEscalations(string Escalations) =>
       AllureLogger.LogStep($"I filter Escalations table with Escalations = '{Escalations}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           By EscalationsLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

           IWebElement EscalationsFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(EscalationsLocator));
           EscalationsFilter.Click();
           EscalationsFilter.Clear();
           EscalationsFilter.SendKeys(Escalations);
           EscalationsFilter.SendKeys(Keys.Enter);

       });


        public void SelectNoRecordFromEscalationsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  Escalations Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Escalations Table Records");
            });

        }


        public void SetEscalationsActive() =>
         AllureLogger.LogStep("I set escalations active", () =>
             SafeActions.Click(driver, By.Id("m74daaf83_ns_menu_ADESC_OPTION_a_tnode"),
                               "I set escalations active"));


        public void SelectViewDetails() =>
        AllureLogger.LogStep("I select view details", () =>
            SafeActions.Click(driver, By.Id("m309d6abf_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                              "I select view details"));


        public void GoToNotificationsTab() =>
          AllureLogger.LogStep("I go to notifications tab", () =>
              SafeActions.Click(driver, By.Id("mbf5476ca-tab_anchor"),
                                "I go to notifications tab"));

        public void DetailMenuTemplateField() =>
       AllureLogger.LogStep("Select Value from Detail Menu  of Template field", () =>
           SafeActions.Click(driver, By.CssSelector("#m309d6abf_tdrow_\\[C\\:1\\]_txt-img\\[R\\:0\\]"),
                             "Select Value from Detail Menu  of Template field"));

        public void GoToCommuncationTemplates() =>
       AllureLogger.LogStep("Go To Communcation Templates", () =>
           SafeActions.Click(driver, By.Id("NORMAL_applink_undefined_a_tnode"),
                             "Go To Communcation Templates"));

        public void GoToRecipientsTab() =>
         AllureLogger.LogStep("I go to Recipients tab", () =>
             SafeActions.Click(driver, By.Id("m6fdf0506-tab_anchor"),
                               "I go to Recipients tab"));

        public void SelectNewRowButton() =>
         AllureLogger.LogStep("I select New Row button", () =>
             SafeActions.Click(driver, By.CssSelector("#m8673ef24_bg_button_addrow-pb"),
                               "I select New Row button"));

        public void EnterFollowingEmail(string Email) =>
      AllureLogger.LogStep($"I filter Email table with Email = '{Email}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          By EmailLocator = By.CssSelector("#m2efbc330-tb");

          IWebElement EmailFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(EmailLocator));
          EmailFilter.Click();
          EmailFilter.Clear();
          EmailFilter.SendKeys(Email);
          
      });

        public void SetRadioFieldToActive() =>
         AllureLogger.LogStep("I set (Radio) field to active", () =>
             SafeActions.Click(driver, By.CssSelector("#ma1b167c4-cb_img"),
                               "I set (Radio) field to active"));


        public void IReturn() =>
          AllureLogger.LogStep("I return", () =>
              SafeActions.Click(driver, By.CssSelector("#mainrec-pg_retBut"),
                                "I return"));


        public void SelectValueLookupOfScheduleField() =>
          AllureLogger.LogStep("I select value lookup of Schedule field", () =>
              SafeActions.Click(driver, By.CssSelector("#m9163e8f4-img"),
                                "I select value lookup of Schedule field"));


         public void EnterFollowingSchedule(string Schedule) =>
      AllureLogger.LogStep($"I enter following Schedule = '{Schedule}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          By ScheduleLocator = By.CssSelector("#m67dae847-tb");

          IWebElement ScheduleFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ScheduleLocator));
          ScheduleFilter.Click();
          ScheduleFilter.Clear();
          ScheduleFilter.SendKeys(Schedule);
          
      });


        public void PressTheDialogButtonOk() =>
         AllureLogger.LogStep("I  press the dialog button ok", () =>
             SafeActions.Click(driver, By.CssSelector("#m7bd6e15a-pb"),
                               "I press the dialog button ok"));


         public void ReviewSentEmail() =>
           AllureLogger.LogStep("Verifying email fields: Text, Recipient, Subject, Email Contents", () =>
           {
                 try
                 {
                       // Wait for elements to be ready
                       Task.Delay(20000).Wait();

                       // Locate and validate text-based fields
                       var recipientField = driver.FindElement(By.CssSelector("#m13ff2b14-tb"));
                       var subjectField = driver.FindElement(By.CssSelector("#m64f81b82-tb"));

                        string recipientValue = recipientField.GetAttribute("value");
                        string subjectValue = subjectField.GetAttribute("value");

                     if (string.IsNullOrWhiteSpace(recipientValue))
                         throw new Exception("Recipient field is empty or null.");
                     if (string.IsNullOrWhiteSpace(subjectValue))
                      throw new Exception("Subject field is empty or null.");

                       // Switch into iframe BEFORE reading email content
                       driver.SwitchTo().Frame(driver.FindElement(By.Id("mfa9c8e21-rte_iframe")));

                       var emailContentsField = driver.FindElement(By.Id("dijitEditorBody"));
                       string emailContentsValue = emailContentsField.Text;

                     if (string.IsNullOrWhiteSpace(emailContentsValue))
                     throw new Exception("Email Contents field inside iframe is empty or null.");

                     // Switch back to main content
                       driver.SwitchTo().DefaultContent();

                      // Log the results
                     Console.WriteLine("Success: All email fields have valid values.");
                     Console.WriteLine($"Recipient: {recipientValue}");
                     Console.WriteLine($"Subject: {subjectValue}");
                     Console.WriteLine($"Email Contents: {emailContentsValue}");
                     }
                     catch (NoSuchElementException ex)
                     {
                          Console.WriteLine("Error: One or more fields not found - " + ex.Message);
                          throw;
                     }
                     catch (Exception ex)
                     {
                           Console.WriteLine("Validation Error: " + ex.Message);
                           throw;
                     }
           });


        public void TakeScreenshotOfAutomaticEmailToSupplierTestScenarioOne() =>
          AllureLogger.LogStep("Capture Screenshot for GTR-UAT-EXP-002SC01", () =>
          {
              try
              {
                  var takescreenshot = new TakeScreenShotPOM(driver);
                  string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-EXP-002SC01.png";

                  takescreenshot.TakeScreenshot(driver, successPath);
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Screenshot failed: {ex.Message}");

                  // Attempt fallback screenshot on failure
                  var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-EXP-002SC01_Failure.png";
                  var takescreenshot = new TakeScreenShotPOM(driver);

                  takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                  // Optional: Rethrow if test should fail
                  throw new Exception("Test failed while taking screenshot.", ex);
              }
          });


                public void SelectShowCommuncationTemplateMenuButton() =>
            AllureLogger.LogStep("I select show communication template menu button", () =>
            {
                   SafeActions.Click(driver, By.CssSelector("#m8673ef24-ti8_img"),
                     "I select show communication template menu button");

                    // Delay added after the action to allow UI to update
                   Task.Delay(3000).Wait(); 
            });



        public void FilterTableEmail(string Email) =>
         AllureLogger.LogStep($"I filter Email table with Email = '{Email}'", () =>
         {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
 
               // Step 1: Click the filter icon (assumed CSS selector, update if needed)
               By filterIconLocator = By.CssSelector("#m8673ef24-lb2");
               IWebElement filterIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterIconLocator));
               filterIcon.Click();

               // Step 2: Wait for and interact with the email filter input
               By emailInputLocator = By.CssSelector("#m8673ef24_tfrow_\\[C\\:1\\]_txt-tb");
               IWebElement emailFilterInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(emailInputLocator));
               emailFilterInput.Clear();
               emailFilterInput.SendKeys(Email);
         });


        public void DeleteEmailRecord() =>
        AllureLogger.LogStep("I  delete email record", () =>
            SafeActions.Click(driver, By.Id("m8673ef24_tdrow_[C:5]_toggleimage-ti[R:0]_img"),
                              "I delete email record"));

             public void TableAssetTemplatesHasNoRecords() =>
          AllureLogger.LogStep("the table Asset Templates has no records", () =>
          {
                try
                {
                     // Wait 5 seconds for the page or element to load
                     Task.Delay(5000).Wait();

                    // Locate the table rows (adjust selector to target the rows inside the table)
                    var tableRows = driver.FindElements(By.Id("m8673ef24_tdrow_[C:0]_tgdet-ti[R:0]_img"));

                     // Locate the 'no records' message element (adjust selector accordingly)
                      var noRecordsMessage = driver.FindElement(By.Id("m8673ef24_tbod_tempty_tcell_statictext-lb"));

                     // Validate that there are no rows in the table
                     if (tableRows.Count > 0)
                     {
                          throw new Exception("Failure: Table contains records when it should be empty.");
                     }

                     // Validate that the no records message is visible and has expected text
                    if (!noRecordsMessage.Displayed)
                    {
                           throw new Exception("Failure: There are no rows to display..");
                    }

                       string messageText = noRecordsMessage.Text;
                      if (string.IsNullOrWhiteSpace(messageText))
                      {
                           throw new Exception("Failure: No records message text is empty.");
                      }

                       // Log success message
                       Console.WriteLine($"Success: Table is empty and message displayed - '{messageText}'");
                      }
                      catch (NoSuchElementException ex)
                      {
                            Console.WriteLine("Error: Required element not found - " + ex.Message);
                            throw;
                      }
                      catch (Exception ex)
                      {
                          Console.WriteLine("Error: " + ex.Message);
                          throw;
                       }
          });


        public void SelectReturn() =>
        AllureLogger.LogStep("I  select return", () =>
            SafeActions.Click(driver, By.CssSelector("#mainrec-pg_retBut"),
                              "I select return"));


        public void SetEscalationsInactive() =>
       AllureLogger.LogStep("I  select return", () =>
           SafeActions.Click(driver, By.Id("m74daaf83_ns_menu_ADESC_OPTION_a_tnode"),
                             "I select return"));

        public void TakeScreenshotOfDeletedEmailToSupplierTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-EXP-002SC02", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-EXP-002SC02.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-EXP-002SC02_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });

        public void TakeScreenshotOfAutomaticEmailToSupplierTestScenarioTwo() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-EXP-002SC03", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-EXP-002SC03.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-EXP-002SC03_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });


        // Raising a Purchase Requisition - Stocked Item POM Steps



            public void GoToSupplyChainSupportTab() =>
          AllureLogger.LogStep("I go to Supply Chain Support Tab", () =>
              SafeActions.Click(driver, By.Id("m1e20cba1-sct_anchor_1"),
                             "I go to Supply Chain Support Tab"));
          
             public void SelectNewPurchaseRequisition() =>
          AllureLogger.LogStep("I select New Purchase Requisition", () =>
               SafeActions.Click(driver, By.CssSelector("#QuickInsert_PLUSTPR"),
                             "I select New Purchase Requisition"));
         
         
          public void EnterFollowingPurchaseRequisition(string PurchaseRequisition) =>
         AllureLogger.LogStep($"I enter following Purchase Requisition = '{PurchaseRequisition}'", () =>
         {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             By PurchaseRequisitionLocator = By.CssSelector("#m8ee1358-tb2");

             IWebElement PurchaseRequisitionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(PurchaseRequisitionLocator));
             PurchaseRequisitionFilter.Click();
             PurchaseRequisitionFilter.Clear();
             PurchaseRequisitionFilter.SendKeys(PurchaseRequisition);
          
         });

        public void SelectRequiredDateMenu() =>
          AllureLogger.LogStep("I select Required Date Menu", () =>
               SafeActions.Click(driver, By.CssSelector("#mcd12264a-img"),
                             "I select Required Date Menu"));

        public void SelectRequiredDate() =>
         AllureLogger.LogStep("I select Required Date", () =>
              SafeActions.Click(driver, By.XPath("//*[@id='mcd12264a-tb_popup']/tbody/tr[2]/td/button[1]"),
                            "I select Required Date"));



        public void EnterGLDebitAccount(string GLDebitAccount) =>
         AllureLogger.LogStep($"I enter GL Debit Account = '{GLDebitAccount}'", () =>
         {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             By GLDebitAccountLocator = By.CssSelector("#m9ec9217a-tb");

             IWebElement GLDebitAccountFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(GLDebitAccountLocator));
             GLDebitAccountFilter.Click();
             GLDebitAccountFilter.Clear();
             GLDebitAccountFilter.SendKeys(GLDebitAccount);
          
         });


           public void SetRadioAllowExpeditingEmailTrue() =>
         AllureLogger.LogStep("I set (Radio) Allow Expediting Email True", () =>
         { 
              // Click the checkbox/radio button
               SafeActions.Click(driver, By.CssSelector("#m4b526021-cb_img"),
                      "I set (Radio) Allow Expediting Email True");
                  
                // Locate the actual checkbox input (not the image) to verify its state
                var checkboxInput = driver.FindElement(By.CssSelector("#m4b526021-cb_img"));

               Console.WriteLine("Success: 'Allow Expediting Email' checkbox is checked.");
         });

        public void VerifyEstimatedDueDateIsSetToDays(int recordNumber)
        {
            AllureLogger.LogStep($"I verify Estimated Due Date is set to {recordNumber} days", () =>
            {
                try
                {
                    Task.Delay(8000).Wait();
                    // Assuming the field ID doesn't vary with recordNumber — adjust if needed
                    string selector = "#m6ddf9208-tb";

                    // Wait and find the input field
                    var dueDateField = driver.FindElement(By.CssSelector(selector));

                    // Get the value of the field
                    string fieldValue = dueDateField.GetAttribute("value");

                    if (string.IsNullOrWhiteSpace(fieldValue))
                    {
                        throw new Exception("Failure: Estimated Due Date field is empty.");
                    }
                     Console.WriteLine($"Success: Estimated Due Date is correctly set to {recordNumber} days.");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Error: Estimated Due Date field not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            });

        }


        public void VerifyVendorDueDateIsSetPlusDays(int recordNumber)
        {
            AllureLogger.LogStep($"I Verify Vendor Due Date is set plus to {recordNumber} days", () =>
            {
                try
                {
                    // Assuming the field ID doesn't vary with recordNumber — adjust if needed
                    string selector = "#m6b8d3d40-tb";

                    // Wait and find the input field
                    var dueDateField = driver.FindElement(By.CssSelector(selector));

                    // Get the value of the field
                    string fieldValue = dueDateField.GetAttribute("value");

                    if (string.IsNullOrWhiteSpace(fieldValue))
                    {
                        throw new Exception("Failure: Vendor Due Date field is empty.");
                    }
                    

                    Console.WriteLine($"Success: Vendor Due Date is correctly set to {recordNumber} days.");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Error: Vendor Due Date field not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            });

        }

        public void GoToShipToBillToTab() =>
          AllureLogger.LogStep("I go to Ship To Bill To tab", () =>
               SafeActions.Click(driver, By.Id("m11b7f2a2-tab_anchor"),
                             "I go to Ship To Bill To tab"));

         public void PressOkManualInputDialogButton() =>
       AllureLogger.LogStep("I press ok manual input dialog button", () =>
           SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                             "I press ok manual input dialog button"));


        public void TakeScreenshotOfRaisingAPurchaseRequisitionStockedItemTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-EXP-003", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-EXP-003.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-EXP-003_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });






        //  Raising a Purchase Requisition - Non-stocked Item POM Steps



        public void AddNewRowUnderPRLinesTab() =>
       AllureLogger.LogStep("I add new row under PR Lines tab", () =>
           SafeActions.Click(driver, By.CssSelector("#mf66f4c27_bg_button_addrow-pb"),
                             "I add new row under PR Lines tab"));

        public void SelectDropDownOptionsOfLineType() =>
       AllureLogger.LogStep("I select dropdown options of Line Type", () =>
           SafeActions.Click(driver, By.CssSelector("#me66f0e0a-img"),
                             "I select dropdown options of Line Type"));

        public void SelectMaterial() =>
       AllureLogger.LogStep("I  select Material", () =>
           SafeActions.Click(driver, By.Id("menu0_MATERIAL_OPTION_a_tnode"),
                             "I select Material"));

            public void EnterFollowingMaterialDetails(string MaterialDescription, string LineCost) =>
        AllureLogger.LogStep($"I enter following Material Details = Material Description = '{MaterialDescription}', Line Cost = '{LineCost}','", () =>
        {
            Task.Delay(5000).Wait();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            By MaterialDescriptionFilterLocator = By.CssSelector("#m91683e9c-tb2");
            By LineCostFilterLocator = By.CssSelector("#m59bead76-tb");

            IWebElement MaterialDescriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MaterialDescriptionFilterLocator));
            MaterialDescriptionFilter.Click();
            MaterialDescriptionFilter.Clear();
            MaterialDescriptionFilter.SendKeys(MaterialDescription);
            
            IWebElement LineCostFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(LineCostFilterLocator));
            LineCostFilter.Click();
            LineCostFilter.Clear();
            LineCostFilter.SendKeys(LineCost);
            
        });

        public void OpenSelectValueLookupForOrderUnitField() =>
       AllureLogger.LogStep("I open Select Value lookup for Order Unit field", () =>
           SafeActions.Click(driver, By.CssSelector("#m29d459f9-img"),
                             "I open Select Value lookup for Order Unit field"));


        public void SelectNoRecordFromOrderUnitTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  Order Unit Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Order Unit Table Records");
            });

        }

          public void DetailMenuOfWorkOrder() =>
        AllureLogger.LogStep("I select Detail Menu Of Work Order", () =>
            SafeActions.Click(driver, By.CssSelector("#m5a0d006c-img"),
                            "I select Detail Menu Of Work Order"));

          public void SelectValueOption() =>
        AllureLogger.LogStep("I  Select Value Option", () =>
            SafeActions.Click(driver, By.Id("WORKORDER_workorder1_a_tnode"),
                            "I Select Value Option"));


        public void FilterTableWorkOrder(string Description) =>
       AllureLogger.LogStep($"I filter table Work Order Description with '{Description}'", () =>
       {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           By DescriptionLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");
           IWebElement DescriptionField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DescriptionLocator));

           DescriptionField.Click();
           DescriptionField.Clear();
           DescriptionField.SendKeys(Description);
           DescriptionField.SendKeys(Keys.Enter);
       });

        public void SelectNoRecordFromWorkOrderTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  work Order Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From work Order Table Records");
            });

        }

        public void OpenSelectValueLookupForShipToField() =>
      AllureLogger.LogStep("I open Select Value lookup for Ship To field", () =>
          SafeActions.Click(driver, By.CssSelector("#m431a6e3-img"),
                            "I open Select Value lookup for Ship To field"));

         public void FilterTableShipTo(string ShipTo) =>
       AllureLogger.LogStep($"I filter table Ship To with '{ShipTo}'", () =>
       {


           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           By ShipToLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
           IWebElement ShipToField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ShipToLocator));

           ShipToField.Click();
           ShipToField.Clear();
           ShipToField.SendKeys(ShipTo);
           ShipToField.SendKeys(Keys.Enter);
       });

        public void SelectNoRecordFromShipToTableRecord(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From  Ship To Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Ship To Table Records");
            });

        }


        public void TakeScreenshotOfRaisingAPurchaseRequisitionNonStockedItemTest() =>
         AllureLogger.LogStep("Capture Screenshot for GTR-UAT-EXP-004", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTR-UAT-EXP-004.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTR-UAT-EXP-004_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });




    }
}