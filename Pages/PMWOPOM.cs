using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using Reqnroll.Bindings;


namespace GTR_AUTOMATED.Pages
{
    [Binding]
    public sealed class PMWOPOM
    {
        private IWebDriver driver;

        public PMWOPOM(IWebDriver drv) => driver = drv;



        public void OpenGoToMenu() =>
            AllureLogger.LogStep("Open [Go To] menu", () =>
                SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                  "Go To button"));

        public void OpenPreventiveMaintenance() =>
            AllureLogger.LogStep("Open Preventive Maintenance Menu", () =>
                SafeActions.Click(driver, By.Id("menu0_PM_MODULE_a_tnode"),
                                  "Open Preventive Maintenance node"));

        public void OpenPreventativeMaintenanceBRDA() =>
            AllureLogger.LogStep("Launch Preventive Maintenance (BRDA)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_PM_MODULE_sub_changeapp_BRDAPM_a_tnode"),
                    "Preventive Maintenance (BRDA)"));

        public void CreateNewRecord() =>
           AllureLogger.LogStep("Click [New Record]", () =>
               SafeActions.Click(driver,
                   By.Id("toolactions_INSERT-tbb_anchor"),
                   "Create new record"));

        public void DetailMenuOfAssetGroupField() =>
         AllureLogger.LogStep("Detail Menu Of Asset Group Field", () =>
             SafeActions.Click(driver, By.CssSelector("#m6f3f99b7-img"),
                               "Detail Menu Of Asset Group Field"));

        public void SelectValueOption() =>
           AllureLogger.LogStep("Select Value Option", () =>
               SafeActions.Click(driver, By.Id("ASSETMAIN_assetmain0_a_tnode"),
                                 "Select Value Option"));


        public void FilterByAssetGroup(string assetGroup) =>
      AllureLogger.LogStep($"I filter table Asset Group with '{assetGroup}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(assetGroup);
          filterField.SendKeys(Keys.Enter);
      });


        public void SelectNoRecordFromAssetTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Asset Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Asset Table Records");
            });

        }

        public void SetIncludeThisPMInTheForecastCheckboxFieldToFalse() =>
        AllureLogger.LogStep("I set Include this PM in the Forecast [Checkbox] field to False", () =>
        {
            By checkboxLocator = By.CssSelector("#m13f9ca87-cb_img");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement checkbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(checkboxLocator));

            // Optional: Scroll into view
            new Actions(driver).MoveToElement(checkbox).Perform();

            // Only click if it's checked
            if (checkbox.Selected)
            {
                checkbox.Click();
            }

            // Assert or verify it's now unchecked
            if (checkbox.Selected)
            {
                throw new Exception("Checkbox is still checked after attempting to uncheck it.");
            }
        });


        public void OpenSelectValueLookupForWorkTypeField() =>
         AllureLogger.LogStep("I open Select Value lookup for Work Type field", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#m14940e9e-img"),
                 "I open Select Value lookup for Work Type field"));

        public void FilterTable(string worktype) =>
        AllureLogger.LogStep($"I filter table Work Type with '{worktype}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(worktype);
            filterField.SendKeys(Keys.Enter);
        });

        public void SelectNoRecordPMFromTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From PM Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From PM Table Records");
            });

        }

        public void SetInterruptibleCheckboxFieldToTrue() =>
      AllureLogger.LogStep("I set Interruptible [Checkbox] field to True", () =>
      {
          By checkboxLocator = By.CssSelector("#m13f9ca87-cb_img");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement checkbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(checkboxLocator));

          // Scroll to the checkbox to ensure it's visible
          new Actions(driver).MoveToElement(checkbox).Perform();

          // Check if it's already selected (use .Selected only if this is a real <input type="checkbox">)
          // If not, click to check it
          if (!checkbox.Selected)
          {
              checkbox.Click();
          }

          // Verify it is now checked
          //if (!checkbox.Selected)
          //{
          //    throw new Exception("Checkbox is still unchecked after attempting to check it.");
          //  }
      });

        public void ISaveCMRecord() =>
         AllureLogger.LogStep("I Save CM Record", () =>
             SafeActions.Click(driver, By.Id("toolactions_SAVE-tbb_anchor"),
                               "I Save CM Record"));


        public void PressChangeStatusButton() =>
           AllureLogger.LogStep("I press Change Status button", () =>
               SafeActions.Click(driver,
                   By.Id("md86fe08f_ns_menu_STATUS_OPTION_a_tnode"),
                   "I press Change Status button"));

        public void PressTheDropdownNewStatusButton() =>
           AllureLogger.LogStep("I press the dropdown new status button", () =>
               SafeActions.Click(driver,
                   By.CssSelector("#mc927149a-img"),
                   "I press the dropdown new status button"));

        public void SelectActiveStatus() =>
         AllureLogger.LogStep("I select active status", () =>
             SafeActions.Click(driver,
                 By.Id("menu0_ACTIVE_OPTION_a_tnode"),
                 "I select active status"));

        public void SetRollNewStatusToAllChildPMsCheckboxFieldToTrue() =>
        AllureLogger.LogStep("I set Roll New Status to All Child PMs [Checkbox] field to true", () =>
        {
            By checkboxLocator = By.CssSelector("#m502e4520-cb_img");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement checkbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(checkboxLocator));

            // Scroll to the checkbox to ensure it's visible
            new Actions(driver).MoveToElement(checkbox).Perform();

            // Check if it's already selected (use .Selected only if this is a real <input type="checkbox">)
            // If not, click to check it
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }

            // Verify it is now checked
            //if (!checkbox.Selected)
            // {
            //    throw new Exception("Checkbox is still unchecked after attempting to check it.");
            //  }
        });

        public void PressDialogButtonOK() =>
         AllureLogger.LogStep("I press dialog button OK", () =>
             SafeActions.Click(driver,
                 By.CssSelector("#m60bd6d91-pb"),
                 "I press dialog button OK"));


             public void FieldStatusHasValueACTIVE() =>
         AllureLogger.LogStep("field Status has value ACTIVE", () =>
         {
               try
               {
                     // Wait 5 seconds for the page or element to load
                     Task.Delay(5000).Wait();

                     // Find the Related Work Order element by CSS selector
                     var relatedWorkOrder = driver.FindElement(By.CssSelector("#mdc56918-tb"));

                    // Get the 'value' attribute of the element
                    string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                     // Check if the work order number is null or empty
                     if (string.IsNullOrEmpty(workOrderNumber))
                     {
                        throw new Exception("Status: Work order number is empty or null.");
                     }

                           // Log success with the work order number
                            Console.WriteLine("Success: Work order number is " + workOrderNumber);
                     }
                     catch (NoSuchElementException ex)
                     {
                           Console.WriteLine("Error: Work order element not found - " + ex.Message);
                            throw;
                     }
                     catch (Exception ex)
                     {
                           Console.WriteLine("Error: " + ex.Message);
                             throw;
                     }
         });


        public void TakeScreenshotOfCreateAPMTest() =>
    AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-300", () =>
    {
        try
        {
            var takescreenshot = new TakeScreenShotPOM(driver);
            string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-300.png";

            takescreenshot.TakeScreenshot(driver, successPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Screenshot failed: {ex.Message}");

            // Attempt fallback screenshot on failure
            var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-300_Failure.png";
            var takescreenshot = new TakeScreenShotPOM(driver);

            takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

            // Optional: Rethrow if test should fail
            throw new Exception("Test failed while taking screenshot.", ex);
        }
    });


        //Generating an Ad Hoc PM Work Order POM Steps


        public void TakeScreenshotOfGeneratingAnAdHocPMWorkOrderTestScenarioone() =>
     AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-301SC01", () =>
     {
         try
         {
             var takescreenshot = new TakeScreenShotPOM(driver);
             string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-301SC01.png";

             takescreenshot.TakeScreenshot(driver, successPath);
         }
         catch (Exception ex)
         {
             Console.WriteLine($"Screenshot failed: {ex.Message}");

             // Attempt fallback screenshot on failure
             var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-301SC01_Failure.png";
             var takescreenshot = new TakeScreenShotPOM(driver);

             takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

             // Optional: Rethrow if test should fail
             throw new Exception("Test failed while taking screenshot.", ex);
         }
     });



        public void FilterPMTable(string description, string status, string parent) =>
     AllureLogger.LogStep($"I filter PM table with Description = '{description}', Status = '{status}', Parent = '{parent}'", () =>
     {
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

         // Adjust column indices as per actual table structure:
         // Example assumptions:
         // Description = column 1 → C:1
         // Status = column 3 → C:3
         // Parent = column 4 → C:4

         By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
         By statusFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:10\\]_txt-tb");
         By parentFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:9\\]_txt-tb");

         // Handle ~Null~ token as empty string
         if (parent.Trim().Equals("~Null~", StringComparison.OrdinalIgnoreCase))
         {
             parent = "";
         }

         IWebElement descriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(descriptionFilterLocator));
         descriptionFilter.Click();
         descriptionFilter.Clear();
         descriptionFilter.SendKeys(description);

         IWebElement statusFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(statusFilterLocator));
         statusFilter.Click();
         statusFilter.Clear();
         statusFilter.SendKeys(status);

         IWebElement parentFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(parentFilterLocator));
         parentFilter.Click();
         parentFilter.Clear();
         parentFilter.SendKeys(parent);

         // Press Enter on the last filter field to trigger filtering
         parentFilter.SendKeys(Keys.Enter);
     });

        public void SelectNo_RecordFromPMsTable(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From PMs Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From PMs Table Records");
            });

        }

        public void SelectAction() =>
        AllureLogger.LogStep("select action", () =>
            SafeActions.Click(driver,
                By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-tb"),
                "select action"));

        public void GenerateWorkOrders() =>
        AllureLogger.LogStep("Generate Work Orders", () =>
            SafeActions.Click(driver,
                By.Id("menu0_GENERATEWO_OPTION_a_tnode"),
                "Generate Work Orders"));


        public void SetUseFrequencyCriteriaCheckboxFieldToFalse() =>
       AllureLogger.LogStep("I set Use Frequency Criteria [Checkbox] field to False", () =>
       {
           By checkboxLocator = By.XPath("//*[@id='mc3c4c116-cb_img']");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           IWebElement checkbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(checkboxLocator));

           // Scroll to the checkbox to ensure it's visible
           new Actions(driver).MoveToElement(checkbox).Perform();

           // Check if it's already selected (use .Selected only if this is a real <input type="checkbox">)
           // If not, click to check it
           if (!checkbox.Selected)
           {
               checkbox.Click();
           }

           // Verify it is now checked
           //if (!checkbox.Selected)
           //{
           //    throw new Exception("Checkbox is still unchecked after attempting to check it.");
           //  }
       });

          public void PressTheButtonOK() =>
         AllureLogger.LogStep("I press the button OK", () =>
         {
              SafeActions.Click(driver,
                   By.XPath("//*[@id='m575c541c-pb']"),
                     "I press the button OK");

                    Task.Delay(20000).Wait();
         });



        public void MessageAppearsBMXAAI(string expectedMessage)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            bool messageDisplayed = wait.Until(d =>
            {
                var popup = d.FindElement(By.CssSelector("#mb_msg"));
                return popup != null && popup.Text.Contains(expectedMessage);
            });

            if (!messageDisplayed)
            {
                throw new Exception($"Message popup with '{expectedMessage}' was not displayed.");
            }
        }

        public void PressTheButtonOk() =>
       AllureLogger.LogStep("I press the button OK", () =>
           SafeActions.Click(driver,
               By.CssSelector("#m88dbf6ce-pb"),
               "I press the button OK"));


        public void TakeScreenshotOfGeneratingAnAdHocPMWorkOrderTestScenarioTwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-301SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-301SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-301SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        // Assigning a PM Work Order Task POM Steps


             public void FilterTablePM(string description, string status, string workType) =>
           AllureLogger.LogStep($"I filter PM table with Description = '{description}', Status = '{status}', and Work Type = '{workType}'", () =>
           {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                  // Adjust column indexes if needed
                  By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
                  By statusFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:10\\]_txt-tb");
                  By workTypeFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:4\\]_txt-tb");

                 // Description filter
                 IWebElement descriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(descriptionFilterLocator));
                 descriptionFilter.Click();
                 descriptionFilter.Clear();
                 descriptionFilter.SendKeys(description);

                 // Status filter
                 IWebElement statusFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(statusFilterLocator));
                 statusFilter.Click();
                 statusFilter.Clear();
                 statusFilter.SendKeys(status);

                // Work Type filter
                IWebElement workTypeFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(workTypeFilterLocator));
                workTypeFilter.Click();
                workTypeFilter.Clear();
                workTypeFilter.SendKeys(workType);

               // Trigger filter (using Enter on the last field)
               workTypeFilter.SendKeys(Keys.Enter);
           });


        public void GoToAssignmentsTab() =>
     AllureLogger.LogStep("I go to Assignments Tab", () =>
         SafeActions.Click(driver,
             By.Id("m308a50dd-tab_anchor"),
             "I go to Assignments Tab"));

        public void AddNewRowInAssignmentsTab() =>
      AllureLogger.LogStep("I add new row in Assignments Tab", () =>
          SafeActions.Click(driver,
              By.Id("m6798a95d_bg_button_addrow-pb"),
              "I add new row in Assignments Tab"));

        public void SelectValueLookupForLaborField() =>
      AllureLogger.LogStep("I open Select Value lookup for Labor field", () =>
          SafeActions.Click(driver,
              By.CssSelector("#m5080505d-img"),
              "I open Select Value lookup for Labor field"));

        public void SelectNoRecordFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Labor Table Records");
            });

        }

        public void SelectNoFromLaborTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m825a12a1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Labor Table Records");
            });

        }


        public void TakeScreenshotOfAssigningAPMWorkOrderTaskScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-302SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-302SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-302SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

         public void TakeScreenshotOfAssigningAPMWorkOrderTaskScenarioTwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-302SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-302SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-302SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void TakeScreenshotOfAssigningAPMWorkOrderTaskScenarioThree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-302SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-302SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-302SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        //Complete a PM Work Order Task POM Steps



        public void TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-303SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-303SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-303SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        public void TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioTwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-303SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-303SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-303SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioThree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-303SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-303SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-303SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void PressRouteTheWorkflowButton() =>
      AllureLogger.LogStep("I press route the workflow button", () =>
          SafeActions.Click(driver,
              By.Id("ROUTEWF__-tbb"),
              "I press route the workflow button"));

        public void SetRadioFieldToStartWorkOrder() =>
      AllureLogger.LogStep("I set (Radio) field to Start Work order", () =>
          SafeActions.Click(driver,
              By.CssSelector("#mb64e0e96-rb"),
              "I set (Radio) field to Start Work order"));

        public void PressOkDialogButton() =>
      AllureLogger.LogStep("I press Ok dialog button", () =>
          SafeActions.Click(driver,
              By.XPath("//*[@id='m37917b04-pb']"),
              "I press Ok dialog button"));

        public void ReturnToMaintainerStartCenter() =>
      AllureLogger.LogStep("I return to Maintainer Start Center", () =>
          SafeActions.Click(driver,
              By.CssSelector("#titlebar-tb_homeButton"),
              "I return to Maintainer Start Center"));

       
        public void IOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu() =>
     AllureLogger.LogStep("I Open Application Work Order Tracking BRDA From Favorite Menu", () =>
         SafeActions.Click(driver, By.Id("FavoriteApp_BRDAWO"),
                           "I Open Application Work Order Tracking BRDA From Favorite Menu"));


        public void SetRadioFieldToCompleteWorkAssignment() =>
     AllureLogger.LogStep("I set (Radio) field to Complete Work Assignment", () =>
         SafeActions.Click(driver,
             By.CssSelector("#mc1493e00-rb"),
             "I set (Radio) field to Complete Work Assignment"));

        public void PressDialogButtonOk() =>
     AllureLogger.LogStep("I press Ok dialog button", () =>
         SafeActions.Click(driver,
             By.XPath("//*[@id='m37917b04-pb']"),
             "I press Ok dialog button"));

        public void PressDialogButtonClose() =>
     AllureLogger.LogStep("I press dialog button Close", () =>
         SafeActions.Click(driver,
             By.CssSelector("#m15f1c9f0-pb"),
             "I press dialog button Close"));

        public void GoToTabActuals() =>
     AllureLogger.LogStep("I go to Tab actuals", () =>
         SafeActions.Click(driver,
             By.Id("m272f5640-tab_anchor"),
             "I go to Tab actuals"));

        public void AddNewRowInLaborTab() =>
     AllureLogger.LogStep("I add new row in Labor Tab", () =>
         SafeActions.Click(driver,
             By.CssSelector("#m4dfd8aef_bg_button_addrow-pb"),
             "I add new row in Labor Tab"));

        public void SelectValueOfLaborField() =>
     AllureLogger.LogStep("I select value of labor field", () =>
         SafeActions.Click(driver,
             By.CssSelector("#mef50ddba-img"),
             "I select value of labor field"));


        public void ChooseDetailMenuOfLaborField() =>
    AllureLogger.LogStep("I select detail menu of labor field", () =>
        SafeActions.Click(driver,
            By.Id("LABORCRAFTRATE_LABORCRAFTRATE1_a_tnode"),
            "I select detail menu of labor field"));

         public void FilterTableLabor(string Labor) =>
        AllureLogger.LogStep($"I filter table Work Type with '{Labor}'", () =>
        {
            By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

            filterField.Click();
            filterField.Clear();
            filterField.SendKeys(Labor);
            filterField.SendKeys(Keys.Enter);
        });

        public void ISetStartAndEndTime() =>
      AllureLogger.LogStep("Set Scheduled Start and End Date/Time", () =>
      {    // Prepare date and time values
          string todayDate = DateTime.Today.ToString("dd-MM-yyyy");
          string startDate = DateTime.Today.AddDays(-2).ToString("dd-MM-yyyy");
          string endDate = DateTime.Today.AddDays(-5).ToString("dd-MM-yyyy");
          string currentTime = DateTime.Now.ToString("HH:mm:ss");

          // Set Start Date
          var startDateLocator = By.CssSelector("#mf3329b8e-tb");
          var startDateBox = driver.FindElement(startDateLocator);
          startDateBox.Clear();
          startDateBox.SendKeys(startDate);
          Task.Delay(1000).Wait();

          // Set Start Time
          var startTimePickerIcon = By.CssSelector("#m5df1446b-img");
          var startTimeCell = By.XPath("//*[@id=\"m5df1446b-tb_popup\"]/div[17]/div");

          // 1️⃣ Click to open time picker
          driver.FindElement(startTimePickerIcon).Click();
          Task.Delay(1000).Wait();

          // 2️⃣ Click specific time cell from the time picker
          var startimeCell = driver.FindElement(startTimeCell);
          startimeCell.Click();
          Task.Delay(1000).Wait();


          // Set End Date
          var endDateLocator = By.CssSelector("#m89f2c8ee-tb");
          var endDateBox = driver.FindElement(endDateLocator);
          endDateBox.Clear();
          endDateBox.SendKeys(endDate);
          Task.Delay(1000).Wait();

          // Select End Time from Time Picker Table
          var endTimePickerIcon = By.CssSelector("#m6d560e2d-img");
          var endTimeCell = By.XPath("//*[@id=\"m6d560e2d-tb_popup\"]/div[17]/div");

          // 1️⃣ Click to open time picker
          driver.FindElement(endTimePickerIcon).Click();
          Task.Delay(1000).Wait();

          // 2️⃣ Click specific time cell from the time picker
          var timeCell = driver.FindElement(endTimeCell);
          timeCell.Click();
          Task.Delay(1000).Wait();
                    
      });


        public void StatusFieldHasValueCOMP_WREV() =>
       AllureLogger.LogStep("field Status has value ACTIVE", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(10000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#md489b5d4-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Status: Work order number is empty or null.");
               }

               // Log success with the work order number
               Console.WriteLine("Success: Work order number is " + workOrderNumber);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Work order element not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });


         public void TakeScreenshotOfCompleteAPMWorkOrderTaskScenarioFour() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-303SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-303SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-303SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



        //Approve a PM Work Order Task POM Steps



          public void TakeScreenshotOfApproveAPMWorkOrderTaskScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-304SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-304SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-304SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


            public void TakeScreenshotOfApproveAPMWorkOrderTaskScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-304SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-304SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-304SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


            public void TakeScreenshotOfApproveAPMWorkOrderTaskScenariothree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-304SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-304SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-304SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

            public void TakeScreenshotOfApproveAPMWorkOrderTaskScenariofour() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-304SC04", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-304SC04.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-304SC04_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


              public void SetRadioFieldApproveWork() =>
         AllureLogger.LogStep("I set (Radio) field Approve Work", () =>
            SafeActions.Click(driver,
               By.CssSelector("#mb64e0e96-rb"),
                "I set (Radio) field Approve Work"));


        public void PressOKDialogButton() =>
       AllureLogger.LogStep("I press OK dialog button", () =>
          SafeActions.Click(driver,
             By.CssSelector("#m37917b04-pb"),
              "I press OK dialog button"));


        public void StatusFieldHasValueCOMP() =>
       AllureLogger.LogStep("Status field has value COMP", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(10000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#md3801d08-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Status: Work order number is empty or null.");
               }

               // Log success with the work order number
               Console.WriteLine("Success: Work order number is " + workOrderNumber);
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Work order element not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
       });



         public void TakeScreenshotOfApproveAPMWorkOrderTaskScenariofive() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-304SC05", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-304SC05.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-304SC05_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });



    }


}   