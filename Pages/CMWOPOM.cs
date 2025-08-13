﻿using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll.Bindings;
using static System.Net.Mime.MediaTypeNames;

namespace GTR_Automated_Tests.Pages
{
    public class CMWOPOM
    {
        private readonly IWebDriver driver;
        public CMWOPOM(IWebDriver drv) => driver = drv;
            

        /* ---------- Menu navigation ---------- */

        public void OpenGoToMenu() =>
            AllureLogger.LogStep("Open [Go To] menu", () =>
                SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                  "Go To button"));

        public void OpenWorkOrderMenu() =>
            AllureLogger.LogStep("Open [Work Order] menu", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                  "Work Order menu node"));

        public void OpenWorkOrderTrackingBRDA() =>
            AllureLogger.LogStep("Launch Work Order Tracking (BRDA)", () =>
                SafeActions.Click(driver,
                    By.Id("menu0_WO_MODULE_sub_changeapp_BRDAWO_a_tnode"),
                    "WO Tracking BRDA"));



        public void QuickWorkOrderTrackingBRDA() =>
            AllureLogger.LogStep("Launch Quick Work Order Tracking (BRDA)u", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_sub_changeapp_BRDAQW_a_tnode"),
                                  "Quick WO Tracking BRDA"));

        public void FilterTableQuickWorkOrder(string description, string status, string workType) =>
        AllureLogger.LogStep($"I filter Quick Work Order table with Description = '{description}', Status = '{status}', and Work Type = '{workType}'", () =>
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Adjust column indexes if needed
            By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
            By statusFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:7\\]_txt-tb");
            By workTypeFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");

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

        public void SelectNoRecordFromQuickWorkOrderTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Quick Work Order Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Quick Work Order Table Records");
                Task.Delay(5000).Wait();
            });
        }




        public void ClickCreateNewRecord() =>
            AllureLogger.LogStep("Click [New Record]", () =>
                SafeActions.Click(driver,
                    By.Id("toolactions_INSERT-tbb_anchor"),
                    "Create new record"));

        public void DetailMenuOfLocationField() =>
           AllureLogger.LogStep("Detail Menu Of Location Field", () =>
               SafeActions.Click(driver, By.CssSelector("#m7b0033b9-img"),
                                 "Detail Menu Of Location Field"));

        public void SelectValueOption() =>
           AllureLogger.LogStep("Select Value Option", () =>
               SafeActions.Click(driver, By.Id("LOCATIONS_locations0_a_tnode"),
                                 "Select Value Option"));

         public void FilterTableLocation(string location) =>
      AllureLogger.LogStep($"I filter table Location with '{location}'", () =>
      {
          By filterFieldLocator = By.XPath("//*[@id='lookup_page1_tfrow_[C:0]_txt-tb']");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(location);
          filterField.SendKeys(Keys.Enter);
      });

        public void ISelectNo_RecordFromLocationTableRecords(int recordNumber) =>
     AllureLogger.LogStep($"I Select No {recordNumber} Record From Location Table Records", () =>
     {
         // the id uses zero‑based [R:x] – convert first record (1) → 0, etc.
         int rowIndex = recordNumber - 1;

         // id pattern: lookup_page1_tdrow_[C:0]_ttxt-lb[R:x]
         // escape [, ], and : for CSS
         string selector =
             $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]";

         SafeActions.Click(driver,
             By.Id(selector),
             $"I Select No {recordNumber} Record From Location Table Records");
         Task.Delay(5000).Wait();
     });

          public void SelectNoRecordFromWorkTypeTableRecords(int recordNumber) =>
     AllureLogger.LogStep($"I Select No {recordNumber} Record From Work Type Table Records", () =>
     {
         // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
         int zeroBasedIndex = recordNumber - 1;

         // Build dynamic Id selector by replacing the row index [R:x]
         string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

         SafeActions.Click(driver, By.Id(selector),
             $"I Select No {recordNumber} Record From Work Type Table Records");
     });


            public void SelectNoFromLocationTableRecords(int recordNumber) =>
        AllureLogger.LogStep($"I Select No {recordNumber} From Location Table Records", () =>
        {
             // the id uses zero‑based [R:x] – convert first record (1) → 0, etc.
            int rowIndex = recordNumber - 1;

            // id pattern: lookup_page1_tdrow_[C:0]_ttxt-lb[R:x]
            // escape [, ], and : for CSS
            string selector =
              $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]";

              SafeActions.Click(driver,
                 By.Id(selector),
                 $"I Select No {recordNumber} From Location Table Records");
            Task.Delay(5000).Wait();
        });

        public void SelectValueLookupForWorkTypeField() =>
           AllureLogger.LogStep("I Select Value lookup for Work Type field", () =>
               SafeActions.Click(driver, By.CssSelector("#me2096203-img"),
                                 "I Select Value lookup for Work Type field"));

         public void FilterTableWorkType(string WorkType) =>
      AllureLogger.LogStep($"I filter table Work Type with '{WorkType}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(WorkType);
          filterField.SendKeys(Keys.Enter);
          Task.Delay(2000).Wait();
      });

        public void SelectNoFromWorkTypeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Work Type Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Work Type Table Records");
            });

        }

       
        public void DetailMenuOfRepairFacility() =>
          AllureLogger.LogStep("Detail Menu Of Repair Facility", () =>
              SafeActions.Click(driver, By.CssSelector("#mbacabd10-img"),
                                "Detail Menu Of Repair Facility"));

        public void SelectValueOptionOfRepairFacility() =>
          AllureLogger.LogStep("Select Value Option Of Repair Facility", () =>
              SafeActions.Click(driver, By.Id("REPFACILITY_repfacility0_a_tnode"),
                                "Select Value Option Of Repair Facility"));

          public void FilterTableRepairFacility(string RepairFacility) =>
      AllureLogger.LogStep($"I filter table Repair Facility with '{RepairFacility}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(RepairFacility);
          filterField.SendKeys(Keys.Enter);
      });


        public void ISelectNo_RecordFromRepairFacilityTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Location Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
            });
        }

     
             public void OpenSelectValueLookupForPriorityField() =>
           AllureLogger.LogStep("Open Select Value lookup for Priority Field", () =>
               SafeActions.Click(driver, By.CssSelector("#m950e5295-img"),
                                 "Open Select Value lookup for Priority Field"));

         public void FilterTablePriorityField(string Priority) =>
      AllureLogger.LogStep($"I filter table Priority with '{Priority}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Priority);
          filterField.SendKeys(Keys.Enter);
      });


        public void GivenISelectPriority(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Priority Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
            });
        }

        public void SetScheduledStart() =>
     AllureLogger.LogStep("Set Scheduled Start Date to today's date", () =>
     {
         // Date format expected by the input. Adjust if the control needs a different one.
         string today = DateTime.Today.ToString("dd-MM-yyyy");

         var locator = By.CssSelector("#m8b12679c-tb");
         var dateBox = driver.FindElement(locator);

         dateBox.Clear();
         dateBox.SendKeys(today);
         dateBox.SendKeys(Keys.Enter);          
     });



        public void ISaveCMRecord() =>
          AllureLogger.LogStep("I Save CM Record", () =>
              SafeActions.Click(driver, By.Id("toolactions_SAVE-tbb_anchor"),
                                "I Save CM Record"));


        public void VerifyGeneratedWorkOrderNumber() =>
    AllureLogger.LogStep("Verify Generated Work Order Number", () =>
    {
        try
        {
            // Wait 5 seconds for the page or element to load
            Task.Delay(5000).Wait();

            // Find the Related Work Order element by CSS selector
            var relatedWorkOrder = driver.FindElement(By.CssSelector("#mad3161b5-tb"));

            // Get the 'value' attribute of the element
            string workOrderNumber = relatedWorkOrder.GetAttribute("value");

            // Check if the work order number is null or empty
            if (string.IsNullOrEmpty(workOrderNumber))
            {
                throw new Exception("Failure: Work order number is empty or null.");
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

              public void TakeScreenshotOfAssigningACMWorkOrderTestScenarioOne() =>
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


        public void TakeScreenshotOfAssigningACMWorkOrderTestScenariotwo() =>
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

        public void VerifyCMWorkOrderGenerated() =>
    AllureLogger.LogStep("Verify Generated Work Order Number", () =>
    {
        try
        {
            // Wait 5 seconds for the page or element to load
            Task.Delay(5000).Wait();

            // Find the Related Work Order element by CSS selector
            var relatedWorkOrder = driver.FindElement(By.CssSelector("#m3a3ee28b-tb"));

            // Get the 'value' attribute of the element
            string workOrderNumber = relatedWorkOrder.GetAttribute("value");

            // Check if the work order number is null or empty
            if (string.IsNullOrEmpty(workOrderNumber))
            {
                throw new Exception("Failure: Work order number is empty or null.");
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


        public void ITakeScreenshotOfCreateACMWorkOrderTest() =>
    AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-200", () =>
    {
        try
        {
            var takescreenshot = new TakeScreenShotPOM(driver);
            string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-200.png";

            takescreenshot.TakeScreenshot(driver, successPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Screenshot failed: {ex.Message}");

            // Attempt fallback screenshot on failure
            var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-200_Failure.png";
            var takescreenshot = new TakeScreenShotPOM(driver);

            takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

            // Optional: Rethrow if test should fail
            throw new Exception("Test failed while taking screenshot.", ex);
        }
    });


        //Assigning a CM Work Order POM Step 


        public void IOpenApplicationWorkOrderTrackingBRDAFromFavoriteMenu() =>
      AllureLogger.LogStep("I Open Application Work Order Tracking BRDA From Favorite Menu", () =>
          SafeActions.Click(driver, By.Id("FavoriteApp_BRDAWO"),
                            "I Open Application Work Order Tracking BRDA From Favorite Menu"));

        
        public void ISelectCMWorkOrderFromTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From CM Work Order Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From CM Work Order Table Records");
            });

        }


        public void PressRouteTheWorkflowButton() =>
     AllureLogger.LogStep("I press route the workflow button", () =>
         SafeActions.Click(driver, By.Id("ROUTEWF__-tbb"),
                           "I press route the workflow button"));

        public void ISetRadioFieldToAcceptThisWorkOrderIntoTheWorkBank() =>
     AllureLogger.LogStep("I set (Radio) field to Accept this Work Order into the Work Bank", () =>
         SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                           "I set (Radio) field to Accept this Work Order into the Work Bank"));

        public void ISelectDialogButtonOk() =>
     AllureLogger.LogStep("I select dialog button ok", () =>
     {
         SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                           "I select dialog button ok");
                 
         Task.Delay(5000).Wait();
     });


        public void ISetRadioFieldToSendWorkForExecution() =>
         AllureLogger.LogStep("I set (Radio) field to Send Work for Execution", () =>
             SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                               "I set (Radio) field to Send Work for Execution"));


          public void ISelectOkDialogButton() =>
       AllureLogger.LogStep("I select dialog button ok", () =>
       {
           SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                          "I select dialog button ok");
                 
            Task.Delay(5000).Wait(); 
       });


        public void IGoToAssignmentsTab() =>
         AllureLogger.LogStep("I go to Assignments Tab", () =>
             SafeActions.Click(driver, By.Id("m308a50dd-tab_anchor"),
                               "I go to Assignments Tab"));


        public void AddNewRowInAssignmentsTab() =>
    AllureLogger.LogStep("I add new row in Assignments Tab", () =>
        SafeActions.Click(driver, By.Id("m6798a95d_bg_button_addrow-pb"),
                          "I add new row in Assignments Tab"));

        public void OpenSelectValueLookupForLaborField() =>
    AllureLogger.LogStep("I open Select Value lookup for Labor field", () =>
        SafeActions.Click(driver, By.CssSelector("#m5080505d-img"),
                          "I open Select Value lookup for Labor field"));

        public void FilterTableLabor(string Labor) =>
      AllureLogger.LogStep($"I filter table Labor with '{Labor}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m825a12a1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Labor);
          filterField.SendKeys(Keys.Enter);
      });

        public void ISelectLabor(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Priority Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m825a12a1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
            });
        }



          public void IPreeOkDialogSystemMessageButton() =>
       AllureLogger.LogStep("I pree Ok dialog system message button", () =>
           SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                          "I pree Ok dialog system message button"));



        public void ISaveRecord()
        {
            AllureLogger.LogStep("I Save Record", () =>
                SafeActions.Click(driver, By.Id("toolactions_SAVE-tbb_anchor"),
                                  "I Save Record"));

            Task.Delay(8000).Wait();
        }





        public void VerifyRejectingAnCMWorkOrderGeneratedNumber() =>
    AllureLogger.LogStep("I verify Rejecting an CM Work Order generated number", () =>
    {
        try
        {
            // Wait 5 seconds for the page or element to load
            Task.Delay(5000).Wait();

            // Find the Related Work Order element by CSS selector
            var relatedWorkOrder = driver.FindElement(By.CssSelector("#m3a3ee28b-tb"));

            // Get the 'value' attribute of the element
            string workOrderNumber = relatedWorkOrder.GetAttribute("value");

            // Check if the work order number is null or empty
            if (string.IsNullOrEmpty(workOrderNumber))
            {
                throw new Exception("CM Work Order: Work order number is empty or null.");
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



        public void ITakeScreenshotOfAssigningACMWorkOrderTest() =>
   AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-201SC02", () =>
   {
       try
       {
           var takescreenshot = new TakeScreenShotPOM(driver);
           string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-201SC02.png";

           takescreenshot.TakeScreenshot(driver, successPath);
       }
       catch (Exception ex)
       {
           Console.WriteLine($"Screenshot failed: {ex.Message}");

           // Attempt fallback screenshot on failure
           var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-201SC02_Failure.png";
           var takescreenshot = new TakeScreenShotPOM(driver);

           takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

           // Optional: Rethrow if test should fail
           throw new Exception("Test failed while taking screenshot.", ex);
       }
   });


        public void ITakeScreenshotOfAssigningACMWorkOrder() =>
   AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-201SC01", () =>
   {
       try
       {
           var takescreenshot = new TakeScreenShotPOM(driver);
           string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-201SC01.png";

           takescreenshot.TakeScreenshot(driver, successPath);
       }
       catch (Exception ex)
       {
           Console.WriteLine($"Screenshot failed: {ex.Message}");

           // Attempt fallback screenshot on failure
           var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-201SC01_Failure.png";
           var takescreenshot = new TakeScreenShotPOM(driver);

           takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

           // Optional: Rethrow if test should fail
           throw new Exception("Test failed while taking screenshot.", ex);
       }
   });


        public void VerifyAssignedWorkOrderDetails() =>
   AllureLogger.LogStep("Verify Generated Work Order Number", () =>
   {
       try
       {
           // Wait 5 seconds for the page or element to load
           Task.Delay(5000).Wait();

           // Find the Related Work Order element by CSS selector
           var relatedWorkOrder = driver.FindElement(By.CssSelector("#m3a3ee28b-tb"));

           // Get the 'value' attribute of the element
           string workOrderNumber = relatedWorkOrder.GetAttribute("value");

           // Check if the work order number is null or empty
           if (string.IsNullOrEmpty(workOrderNumber))
           {
               throw new Exception("Failure: Work order number is empty or null.");
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



        // Creating a Found it Fixed it Work Order POM Step




        public void TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioone() =>
            AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-203SC01", () =>
            {
                  try
                  {
                     var takescreenshot = new TakeScreenShotPOM(driver);
                     string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-203SC01.png";

                     takescreenshot.TakeScreenshot(driver, successPath);
                  }
                        catch (Exception ex)
                        {
                             Console.WriteLine($"Screenshot failed: {ex.Message}");

                             // Attempt fallback screenshot on failure
                             var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-203SC01_Failure.png";
                             var takescreenshot = new TakeScreenShotPOM(driver);

                             takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                               // Optional: Rethrow if test should fail
                                throw new Exception("Test failed while taking screenshot.", ex);
                        }
            });


        public void TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenarioTwo() =>
           AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-203SC02", () =>
           {
                   try
                   {
                         var takescreenshot = new TakeScreenShotPOM(driver);
                         string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-203SC02.png";

                         takescreenshot.TakeScreenshot(driver, successPath);
                   }
                        catch (Exception ex)
                        {
                               Console.WriteLine($"Screenshot failed: {ex.Message}");

                               // Attempt fallback screenshot on failure
                               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-203SC02_Failure.png";
                               var takescreenshot = new TakeScreenShotPOM(driver);

                               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                                // Optional: Rethrow if test should fail
                                 throw new Exception("Test failed while taking screenshot.", ex);
                        }
           });


        public void TakeScreenshotOfCreatingAFoundItFixedItWorkOrderTestScenariothree() =>
           AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-203SC03", () =>
           {
                 try
                 {
                      var takescreenshot = new TakeScreenShotPOM(driver);
                      string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-203SC03.png";

                        takescreenshot.TakeScreenshot(driver, successPath);
                 }
                      catch (Exception ex)
                      {
                           Console.WriteLine($"Screenshot failed: {ex.Message}");
      
                            // Attempt fallback screenshot on failure
                           var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-203SC03_Failure.png";
                            var takescreenshot = new TakeScreenShotPOM(driver);

                            takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                            // Optional: Rethrow if test should fail
                            throw new Exception("Test failed while taking screenshot.", ex);
                      }
           });

            public void ISetRadioFieldToStartWorkOrder() =>
            AllureLogger.LogStep("I set (Radio) field to Start Work order", () =>
                SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                               "I set (Radio) field to Start Work order"));

          public void SelectOkButton() =>
            AllureLogger.LogStep("I select Ok button", () =>
            {
               SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"), "I select Ok button");
               Task.Delay(10000).Wait();
            });


            public void SelectAction() =>
            AllureLogger.LogStep("I select action", () =>
                 SafeActions.Click(driver, By.CssSelector("#toolbar2_tbs_1_tbcb_0_action-img"),
                        "I select action"));

        public void SelectCreateWorkOrder() =>
         AllureLogger.LogStep("I select Create Work Order", () =>
             SafeActions.Click(driver, By.Id("menu0_AM120_HEADER_a_tnode"),
                               "I select Create Work Order"));


        public void SelectValueLookupForWorkType() =>
         AllureLogger.LogStep("I Select Value lookup for Work Type", () =>
             SafeActions.Click(driver, By.CssSelector("#m6131c0cf-img"),
                               "I Select Value lookup for Work Type"));

        
         public void FilterTableFollowOnWorkType(string WorkType) =>
      AllureLogger.LogStep($"I filter table Follow on Work Type with '{WorkType}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(WorkType);
          filterField.SendKeys(Keys.Enter);
      });


        public void SelectNoRecordFromFollowONWorkTypeTableRecords(int recordNumber)
        {

            // the id uses zero‑based [R:x] – convert first record (1) → 0, etc.
            int rowIndex = recordNumber - 1;

            // id pattern: lookup_page1_tdrow_[C:0]_ttxt-lb[R:x]
            // escape [, ], and : for CSS
            string selector =
                $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]";

            SafeActions.Click(driver,
                By.Id(selector),
                $"I Select No {recordNumber} Record From Location Table Records");
                       
        }

        public void TheRecordIsSavedSuccessfully() =>
        AllureLogger.LogStep("the record is saved successfully", () =>
            SafeActions.Click(driver, By.Id("toolactions_SAVE-tbb_anchor"),
                              "the record is saved successfully"));


        public void GoToLabourTab() =>
        AllureLogger.LogStep("I go to labour Tab", () =>
            SafeActions.Click(driver, By.CssSelector("#m5ff7dbee-tab_anchor"),
                              "I go to labour Tab"));

        public void PressNewRowUnderLaborTab() =>
        AllureLogger.LogStep("I press new row under Labor Tab", () =>
            SafeActions.Click(driver, By.CssSelector("#m6054d85d_bg_button_addrow-pb"),
                              "I press new row under Labor Tab"));

        public void SelectValueFromDetailMenuOfLaborField() =>
          AllureLogger.LogStep("I Select Value from Detail Menu of Labor field", () =>
          {
                // First click
                SafeActions.Click(driver, By.CssSelector("#m52473e68-img"),
                           "First click on Detail Menu of Labor field");

                // Second click
                SafeActions.Click(driver, By.Id("LABORCRAFTRATE_LABORCRAFTRATE1_a_tnode"),
                           "Second click on Detail Menu of Labor field to open the menu");
          });



        public void SelectNo_RecordFromTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Priority Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
                 Task.Delay(5000).Wait();
            });
        }

        public void SelectStartAndEndTime() =>
        AllureLogger.LogStep("Set Scheduled Start and End Date/Time", () =>
        {    // Prepare date and time values
            string todayDate = DateTime.Today.ToString("dd-MM-yyyy");
            string startDate = DateTime.Today.AddDays(-5).ToString("dd-MM-yyyy");
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            // Set Start Date
            var startDateLocator = By.CssSelector("#me8b034e0-tb");
            var startDateBox = driver.FindElement(startDateLocator);
            startDateBox.Clear();
            startDateBox.SendKeys(startDate);
            Task.Delay(1000).Wait();

            // Set Start Time
            var startTimePickerIcon = By.CssSelector("#m4673eb05-img");
            var startTimeCell = By.XPath("//*[@id=\"m4673eb05-tb_popup\"]/div[9]/div");

            // 1️⃣ Click to open time picker
            driver.FindElement(startTimePickerIcon).Click();
            Task.Delay(1000).Wait();

            // 2️⃣ Click specific time cell from the time picker
            var startimeCell = driver.FindElement(startTimeCell);
            startimeCell.Click();
            Task.Delay(1000).Wait();

            
            // Set End Date
            var endDateLocator = By.CssSelector("#m92706780-tb");
            var endDateBox = driver.FindElement(endDateLocator);
            endDateBox.Clear();
            endDateBox.SendKeys(todayDate);
            Task.Delay(1000).Wait();

            // Select End Time from Time Picker Table
            var endTimePickerIcon = By.CssSelector("#m76d4a143-img"); 
            var endTimeCell = By.XPath("//*[@id=\"m76d4a143-tb_popup\"]/div[17]/div"); 

            // 1️⃣ Click to open time picker
            driver.FindElement(endTimePickerIcon).Click();
            Task.Delay(1000).Wait();

            // 2️⃣ Click specific time cell from the time picker
            var timeCell = driver.FindElement(endTimeCell);
            timeCell.Click();
            Task.Delay(1000).Wait();



        });



        public void GoToFailureReportingTab() =>
        AllureLogger.LogStep("I go to failure reporting tab", () =>
            SafeActions.Click(driver, By.Id("m820ba5de-tab_anchor"),
                              "I go to failure reporting tab"));



        public void PressTheButtonSelectFailureCodes() =>
        AllureLogger.LogStep("I press the button select Failure Codes", () =>
            SafeActions.Click(driver, By.Id("mb030af35_bg_button_listfailurecodes-pb"),
                              "I press the button select Failure Codes"));


         public void FilterTableFollowOnFailureCodes(string FailureCodes) =>
      AllureLogger.LogStep($"I filter table Failure Codes with '{FailureCodes}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

          // Step 1: Click on the filter/search icon first
          By filterIconLocator = By.CssSelector("#mc36b05ed-hb_header_3"); // Update selector as needed
          IWebElement filterIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterIconLocator));
          filterIcon.Click();

          // Step 2: Interact with the filter input field
          By filterFieldLocator = By.CssSelector("#mc36b05ed_tfrow_\\[C\\:0\\]_txt-tb");
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));
          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(FailureCodes);
          filterField.SendKeys(Keys.Enter);

      });


        public void SelectFaliureCodes() =>
        AllureLogger.LogStep("I select faliure codes", () =>
            SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                              "I select faliure codes"));


        public void SelectProblemCodes() =>
       AllureLogger.LogStep("I select problem codes", () =>
           SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                             "I select problem codes"));

        public void SelectCauseCodes() =>
       AllureLogger.LogStep("I select cause codes", () =>
           SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                             "I select cause codes"));

        public void SelectRemedyCodes() =>
     AllureLogger.LogStep("I select remedy codes", () =>
     {
         SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"), "I select remedy codes");
         //Task.Delay(30000).Wait();
     });


        public void GoToLogtab() =>
      AllureLogger.LogStep("I go to Log tab", () =>
          SafeActions.Click(driver, By.Id("m8f3f68c5-tab"),
                            "I go to Log tab"));

        public void PressAddNewRowUnderLog() =>
      AllureLogger.LogStep("I press add new row under Log", () =>
          SafeActions.Click(driver, By.CssSelector("#m295a70c1_bg_button_addrow-pb"),
                            "I press add new row under Log"));


        public void SelectRadioFieldCompleteWorkAssignment() =>
        AllureLogger.LogStep("I select (Radio) field Complete Work Assignment", () =>
            SafeActions.Click(driver, By.CssSelector("#m58406fba-rb"),
                          "I select (Radio) field Complete Work Assignment"));

        public void PressOkDialogButton() =>
        AllureLogger.LogStep("I press ok dialog button", () =>
            SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                          "I press ok dialog button"));


           public void VerifyCOMPWREVStatus() =>
        AllureLogger.LogStep("I verify COMP-WREV Status", () =>
        {


            try
            {
                // Wait 10 seconds for the page or element to load
                Task.Delay(10000).Wait();

                // Find the Status field element by CSS selector (update selector if needed)
                var statusField = driver.FindElement(By.CssSelector("#me6e07274-tb")); 

                // Get the 'value' attribute of the element
                string statusValue = statusField.GetAttribute("value");

                // Validate the value is "COMP-WREV"
                if (string.IsNullOrEmpty(statusValue))
                {
                    throw new Exception("Status field is empty or null.");
                }

                if (statusValue != "COMP-WREV")
                {
                    throw new Exception($"Expected status value COMP-WREV but found '{statusValue}'.");
                }

                Console.WriteLine("Success: Status field value is COMP-WREV.");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Error: Status field not found - " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
                       
        });



        //Creating a Found it Fixed it Work Order POM Step




        public void TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenarioOne() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-203SC01", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-203SC01.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-203SC01_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


         public void FilterTableCMWorkOrder(string description, string status) =>
     AllureLogger.LogStep($"I filter CM Work Order table with Description = '{description}', Status = '{status}','", () =>
     {
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

         // Adjust column indices as per actual table structure:
         // Description = column 2 → C:2
         // Status = column 10 → C:10

         By descriptionFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:2\\]_txt-tb");
         By statusFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:10\\]_txt-tb");

         IWebElement descriptionFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(descriptionFilterLocator));
         descriptionFilter.Click();
         descriptionFilter.Clear();
         descriptionFilter.SendKeys(description);

         IWebElement statusFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(statusFilterLocator));
         statusFilter.Click();
         statusFilter.Clear();
         statusFilter.SendKeys(status);

         // Press Enter on the last filter field to trigger filtering
         statusFilter.SendKeys(Keys.Enter);
     });




        public void TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariotwo() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-203SC02", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-203SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-202SC02_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


              public void SelectValueLookupOfType() =>
            AllureLogger.LogStep("I open Select Value lookup of Type", () =>
                  SafeActions.Click(driver, By.CssSelector("#m3fe6df06-img"),
                 "I open Select Value lookup of Type"));



               public void DropdownMenu() =>
            AllureLogger.LogStep("I Select Drop Down Menu Button", () =>
                 SafeActions.Click(driver, By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb"),
                 "I Select Drop Down Menu Button"));

        public void SelectUPDATE() =>
           AllureLogger.LogStep("I open Select Value lookup of Type", () =>
                SafeActions.Click(driver, By.Id("lookup_page1_tdrow_[C:0]_ttxt-lb[R:0]"),
                "I open Select Value lookup of Type"));


        public void LogStatusFieldHasValueUPDATE() =>
        AllureLogger.LogStep("Work log Status field has value UPDATE", () =>
        {


            try
            {
                // Wait 10 seconds for the page or element to load
                Task.Delay(10000).Wait();

                // Find the Status field element by CSS selector (update selector if needed)
                var statusField = driver.FindElement(By.CssSelector("#m3fe6df06-tb")); 

                // Get the 'value' attribute of the element
                string statusValue = statusField.GetAttribute("value");

                // Validate the value is "UPDATE"
                if (string.IsNullOrEmpty(statusValue))
                {
                    throw new Exception("Status field is empty or null.");
                }

                if (statusValue != "UPDATE")
                {
                    throw new Exception($"Expected status value UPDATE but found '{statusValue}'.");
                }

                Console.WriteLine("Success: Status field value is UPDATE.");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Error: Status field not found - " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
                       
        });


        public void TakeScreenshotOfCreatingAFoundItFixedItWorkOrderScenariothree() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-203SC03", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-203SC03.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-203SC03_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });




        //Completing a CM Work Order for Review POM Step



        public void TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioTwo() =>
           AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-204SC02", () =>
           {
                try
                {
                      var takescreenshot = new TakeScreenShotPOM(driver);
                      string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-204SC02.png";

                      takescreenshot.TakeScreenshot(driver, successPath);
                }
                      catch (Exception ex)
                      {
                            Console.WriteLine($"Screenshot failed: {ex.Message}");

                             // Attempt fallback screenshot on failure
                             var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-204SC02_Failure.png";
                             var takescreenshot = new TakeScreenShotPOM(driver);

                             takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                             // Optional: Rethrow if test should fail
                            throw new Exception("Test failed while taking screenshot.", ex);
                      }
           });




        public void TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioone() =>
           AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-204SC01", () =>
           {
               try
               {
                   var takescreenshot = new TakeScreenShotPOM(driver);
                   string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-204SC01.png";

                   takescreenshot.TakeScreenshot(driver, successPath);
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"Screenshot failed: {ex.Message}");

                   // Attempt fallback screenshot on failure
                   var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-204SC01_Failure.png";
                   var takescreenshot = new TakeScreenShotPOM(driver);

                   takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                   // Optional: Rethrow if test should fail
                   throw new Exception("Test failed while taking screenshot.", ex);
               }
           });


        public void FilterTableCM(string description, string status, string workType) =>
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



        public void SelectRadioBoxCompleteWorkAssignment() =>
          AllureLogger.LogStep("I select (Radio) Box Complete Work Assignment", () =>
              SafeActions.Click(driver, By.CssSelector("#m58406fba-rb"),
                             "I select (Radio) Box Complete Work Assignment"));

        public void PressTheButtonOk() =>
           AllureLogger.LogStep("I press the button Ok", () =>
                SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                "I press the button Ok"));

        public void PressTheButtonClose() =>
           AllureLogger.LogStep("I press the button Close", () =>
                SafeActions.Click(driver, By.CssSelector("#m15f1c9f0-pb"),
                "I press the button Close"));

        public void GoToActualsTab() =>
           AllureLogger.LogStep("I go to actuals Tab", () =>
                SafeActions.Click(driver, By.Id("m272f5640-tab_anchor"),
                "I go to actuals Tab"));

        public void SelectNewRowUnderLaborSection() =>
          AllureLogger.LogStep("I select new row under labor section", () =>
               SafeActions.Click(driver, By.CssSelector("#m4dfd8aef_bg_button_addrow-pb"),
               "I press the button Close"));

        public void SelectValueOfLaborField() =>
          AllureLogger.LogStep("I select value of labor field", () =>
               SafeActions.Click(driver, By.CssSelector("#mef50ddba-img"),
               "I select value of labor field"));


        public void ChooseDetailMenuOfLaborField() =>
         AllureLogger.LogStep("I select detail menu of labor field", () =>
              SafeActions.Click(driver, By.Id("LABORCRAFTRATE_LABORCRAFTRATE1_a_tnode"),
              "I select detail menu of labor field"));

          public void FilterTableActualsLabor(string Labor) =>
      AllureLogger.LogStep($"I filter table actuals Labor with '{Labor}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Labor);
          filterField.SendKeys(Keys.Enter);
      });

        public void SelectLabor(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Labor Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Labor Table Records");

                Task.Delay(1000).Wait();
            });
        }


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


        public void GoToFailureReporting() =>
      AllureLogger.LogStep("I go to failure reporting", () =>
          SafeActions.Click(driver, By.Id("m4c8a7539-tab_anchor"),
                            "I go to failure reporting"));


        public void PressDialogButtonSelectFailureCodes() =>
       AllureLogger.LogStep("I press the button select Failure Codes", () =>
           SafeActions.Click(driver, By.Id("mc8862795_bg_button_listfailurecodes-pb"),
                             "I press the button select Failure Codes"));

        public void FilterTableFailureCodes(string FailureCodes) =>
      AllureLogger.LogStep($"I filter table Failure Codes with '{FailureCodes}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

          // Step 1: Click on the filter/search icon first
          By filterIconLocator = By.CssSelector("#mc36b05ed-lb2"); // Update selector as needed
          IWebElement filterIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterIconLocator));
          filterIcon.Click();

          // Step 2: Interact with the filter input field
          By filterFieldLocator = By.CssSelector("#mc36b05ed_tfrow_\\[C\\:0\\]_txt-tb");
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));
          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(FailureCodes);
          filterField.SendKeys(Keys.Enter);

      });


        public void FailureCodes() =>
      AllureLogger.LogStep("I select Failure Codes", () =>
          SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                            "I select Failure Codes"));

        public void ProblemCodes() =>
       AllureLogger.LogStep("I select problem codes", () =>
           SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                             "I select problem codes"));

        public void CauseCodes() =>
       AllureLogger.LogStep("I select cause codes", () =>
           SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"),
                             "I select cause codes"));

        public void RemedyCodes() =>
     AllureLogger.LogStep("I select remedy codes", () =>
     {
         SafeActions.Click(driver, By.Id("mc36b05ed_tdrow_[C:0]_ttxt-lb[R:0]"), "I select remedy codes");
         //Task.Delay(30000).Wait();
     });



        public void GoToTabLog() =>
      AllureLogger.LogStep("I go to Log tab", () =>
          SafeActions.Click(driver, By.Id("m8f3f68c5-tab_anchor"),
                            "I go to Log tab"));


        public void AddNewRowButtonUnderLogSection() =>
     AllureLogger.LogStep("I press add new row under Log", () =>
         SafeActions.Click(driver, By.CssSelector("#m295a70c1_bg_button_addrow-pb"),
                           "I press add new row under Log"));

          public void EnterFollowingData(string Summary, string Details) =>
     AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Summary}', Details = '{Details}','", () =>
     {
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

         // Adjust column indices as per actual table structure:
         // Description = column 2 → C:2
         // Status = column 10 → C:10

         By SummaryFilterLocator = By.CssSelector("#ma6ef8ebc-tb");
         By DetailsFilterLocator = By.XPath("//*[@id=\"dijitEditorBody\"]");

         IWebElement SummaryFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SummaryFilterLocator));
         SummaryFilter.Click();
         SummaryFilter.Clear();
         SummaryFilter.SendKeys(Summary);

         var iframe = driver.FindElement(By.Id("md1e8be2a-rte_iframe"));
         driver.SwitchTo().Frame(iframe);

         IWebElement DetailsFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DetailsFilterLocator));
         DetailsFilter.Click();
         DetailsFilter.Clear();
         DetailsFilter.SendKeys(Details);

         // Switch back to the main document
         driver.SwitchTo().DefaultContent();

     });

        
         public void FilterTableWorkLog(string workLogType) =>
      AllureLogger.LogStep($"I filter table Failure Codes with '{workLogType}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
          By filterFieldLocator = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));
          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(workLogType);
          filterField.SendKeys(Keys.Enter);

      });

           public void SelectNoRecordFromWorkLogTableRecords(int recordNumber) =>
        AllureLogger.LogStep($"I Select No {recordNumber} Record From work Log Table Records", () =>
        {
              // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
              int zeroBasedIndex = recordNumber - 1;

              // Build dynamic Id selector by replacing the row index [R:x]
              string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

              SafeActions.Click(driver, By.Id(selector),
               $"I Select No {recordNumber} Record From work Loge Table Records");
        });


        public void SetRadioBoxToCompleteWorkAssignment() =>
        AllureLogger.LogStep("I select (Radio) Box Complete Work Assignment", () =>
            SafeActions.Click(driver, By.CssSelector("#m58406fba-rb"),
                           "I select (Radio) Box Complete Work Assignment"));


        public void IPressTheButtonOk() =>
      AllureLogger.LogStep("I press ok dialog button", () =>
          SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                        "I press ok dialog button"));


        public void WorkOrderStatusFieldHasValueCOMPWREV() =>
       AllureLogger.LogStep("I verify COMP-WREV Status", () =>
       {

           try
           {
               // Wait 10 seconds for the page or element to load
               Task.Delay(25000).Wait();

               // Find the Status field element by CSS selector (update selector if needed)
               var statusField = driver.FindElement(By.CssSelector("#md70d61ba-tb"));

               // Get the 'value' attribute of the element
               string statusValue = statusField.GetAttribute("value");

               // Validate the value is "COMP-WREV"
               if (string.IsNullOrEmpty(statusValue))
               {
                   throw new Exception("Status field is empty or null.");
               }

               if (statusValue != "COMP-WREV")
               {
                   throw new Exception($"Expected status value COMP-WREV but found '{statusValue}'.");
               }

               Console.WriteLine("Success: Status field value is COMP-WREV.");
           }
           catch (NoSuchElementException ex)
           {
               Console.WriteLine("Error: Status field not found - " + ex.Message);
               throw;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error: " + ex.Message);
               throw;
           }
                     
       });

        public void TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenarioThree() =>
          AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-204SC04", () =>
          {
              try
              {
                  var takescreenshot = new TakeScreenShotPOM(driver);
                  string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-204SC04.png";

                  takescreenshot.TakeScreenshot(driver, successPath);
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Screenshot failed: {ex.Message}");

                  // Attempt fallback screenshot on failure
                  var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-204SC04_Failure.png";
                  var takescreenshot = new TakeScreenShotPOM(driver);

                  takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                  // Optional: Rethrow if test should fail
                  throw new Exception("Test failed while taking screenshot.", ex);
              }
          });



        //Rejecting an CM Work Order POM Step


        public void TakeScreenshotOfRejectingAnCMWorkOrderTestScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-205SC01", () =>
         {
             try
             {
                 var takescreenshot = new TakeScreenShotPOM(driver);
                 string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-205SC01.png";

                 takescreenshot.TakeScreenshot(driver, successPath);
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Screenshot failed: {ex.Message}");

                 // Attempt fallback screenshot on failure
                 var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-205SC01_Failure.png";
                 var takescreenshot = new TakeScreenShotPOM(driver);

                 takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                 // Optional: Rethrow if test should fail
                 throw new Exception("Test failed while taking screenshot.", ex);
             }
         });


        public void TakeScreenshotOfRejectingAnCMWorkOrderTestScenariotwo() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-205SC02", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-205SC02.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-205SC02_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });

        public void TakeScreenshotOfRejectingAnCMWorkOrderTestScenariothree() =>
        AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-206SC03", () =>
        {
            try
            {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-206SC03.png";

                takescreenshot.TakeScreenshot(driver, successPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Screenshot failed: {ex.Message}");

                // Attempt fallback screenshot on failure
                var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-206SC03_Failure.png";
                var takescreenshot = new TakeScreenShotPOM(driver);

                takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                // Optional: Rethrow if test should fail
                throw new Exception("Test failed while taking screenshot.", ex);
            }
        });


        public void SetRadioBoxToRejectWork() =>
           AllureLogger.LogStep("I set (Radio) field to Reject Work order", () =>
               SafeActions.Click(driver, By.CssSelector("#mc1493e00-rb"),
                              "I set (Radio) field to Reject Work order"));

        public void PressDialogButtonOk() =>
         AllureLogger.LogStep("I select dialog button ok", () =>
             SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                               "I select dialog button ok"));


        public void StatusFieldHasValueINPRG_HOLD() =>
            AllureLogger.LogStep("work order Status field has value INPRG-HOLD", () =>
            {

                try
                {
                    // Wait 10 seconds for the page or element to load
                    Task.Delay(10000).Wait();

                    // Find the Status field element by CSS selector (update selector if needed)
                    var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                    // Get the 'value' attribute of the element
                    string statusValue = statusField.GetAttribute("value");

                    // Validate the value is "INPRG-HOLD"
                    if (string.IsNullOrEmpty(statusValue))
                    {
                        throw new Exception("Status field is empty or null.");
                    }

                    if (statusValue != "INPRG-HOLD")
                    {
                        throw new Exception($"Expected status value INPRG-HOLD but found '{statusValue}'.");
                    }

                    Console.WriteLine("Success: Status field value is INPRG-HOLD.");
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("Error: Status field not found - " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
                               
            });


                public void VerifyGeneratedRejectdWorkOrderNumber() =>
             AllureLogger.LogStep("I verify generated Rejectd work order number", () =>
             {
                      try
                      {
                              // Wait 5 seconds for the page or element to load
                             Task.Delay(5000).Wait();

                             // Find the Related Work Order element by CSS selector
                             var relatedWorkOrder = driver.FindElement(By.CssSelector("#mad3161b5-tb"));

                               // Get the 'value' attribute of the element
                               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                              // Check if the work order number is null or empty
                                 if (string.IsNullOrEmpty(workOrderNumber))
                                 {
                                     throw new Exception("Rejectd: Work order number is empty or null.");
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



        public void ReturnToMaintainerStartCenter() =>
        AllureLogger.LogStep("I return to Maintainer Start Center", () =>
            SafeActions.Click(driver, By.CssSelector("#titlebar-tb_homeButton"),
                              "I return to Maintainer Start Center"));


        public void TakeScreenshotOfCompletingACMWorkOrderForReviewTestScenariofour() =>
          AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-204SC04", () =>
          {
              try
              {
                  var takescreenshot = new TakeScreenShotPOM(driver);
                  string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-204SC04.png";

                  takescreenshot.TakeScreenshot(driver, successPath);
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Screenshot failed: {ex.Message}");

                  // Attempt fallback screenshot on failure
                  var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-204SC04_Failure.png";
                  var takescreenshot = new TakeScreenShotPOM(driver);

                  takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                  // Optional: Rethrow if test should fail
                  throw new Exception("Test failed while taking screenshot.", ex);
              }
          });




        //Approving an CM Work Order POM Step


            public void TakeScreenshotOfApprovingAnCMWorkOrderTestScenarioOne() =>
         AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-206SC01", () =>
         {
              try
              {
                   var takescreenshot = new TakeScreenShotPOM(driver);
                   string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-206SC01.png";

                   takescreenshot.TakeScreenshot(driver, successPath);
              }
                   catch (Exception ex)
                   {
                        Console.WriteLine($"Screenshot failed: {ex.Message}");

                        // Attempt fallback screenshot on failure
                        var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-206SC01_Failure.png";
                        var takescreenshot = new TakeScreenShotPOM(driver);

                        takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                        // Optional: Rethrow if test should fail
                        throw new Exception("Test failed while taking screenshot.", ex);
                   }
         });





             public void VerifyApprovingAnCMWorkOrderGeneratedNumber() =>
         AllureLogger.LogStep("I verify Approving an CM Work Order generated number", () =>
         {
               try
               {
                     // Wait 5 seconds for the page or element to load
                     Task.Delay(5000).Wait();

                     // Find the Related Work Order element by CSS selector
                     var relatedWorkOrder = driver.FindElement(By.CssSelector("#m3a3ee28b-tb"));

                    // Get the 'value' attribute of the element
                    string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                     // Check if the work order number is null or empty
                      if (string.IsNullOrEmpty(workOrderNumber))
                      {
                           throw new Exception("CM Work Order: Work order number is empty or null.");
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


        public void TakeScreenshotOfApprovingAnCMWorkOrderTestScenariotwo() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-206SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-206SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-206SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });

        public void TakeScreenshotOfApprovingAnCMWorkOrderTestScenariothree() =>
       AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-206SC03", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-206SC03.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-206SC03_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        public void SetRadioBoxToApproveWorkOrder() =>
          AllureLogger.LogStep("I set (Radio) field to Approve Work order", () =>
              SafeActions.Click(driver, By.CssSelector("#mb64e0e96-rb"),
                             "I set (Radio) field to Approve Work order"));


        public void WorkOrderStatusFieldHasValueCOMP() =>
          AllureLogger.LogStep("work order Status field has value COMP", () =>
          {

              try
              {
                  // Wait 10 seconds for the page or element to load
                  Task.Delay(20000).Wait();

                  // Find the Status field element by CSS selector (update selector if needed)
                  var statusField = driver.FindElement(By.CssSelector("#md3801d08-tb"));

                  // Get the 'value' attribute of the element
                  string statusValue = statusField.GetAttribute("value");

                  // Validate the value is "COMP"
                  if (string.IsNullOrEmpty(statusValue))
                  {
                      throw new Exception("Status field is empty or null.");
                  }

                  if (statusValue != "COMP")
                  {
                      throw new Exception($"Expected status value COMP but found '{statusValue}'.");
                  }

                  Console.WriteLine("Success: Status field value is COMP.");
              }
              catch (NoSuchElementException ex)
              {
                  Console.WriteLine("Error: Status field not found - " + ex.Message);
                  throw;
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Error: " + ex.Message);
                  throw;
              }
                           
          });


        public void IVerifyGeneratedApprovedWorkOrderNumber() =>
        AllureLogger.LogStep("I verify generated Approved work order number", () =>
        {
             try
             {
                 // Wait 5 seconds for the page or element to load
                  Task.Delay(5000).Wait();

                 // Find the Related Work Order element by CSS selector
                 var relatedWorkOrder = driver.FindElement(By.CssSelector("#mad3161b5-tb"));

                  // Get the 'value' attribute of the element
                  string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                 // Check if the work order number is null or empty
                  if (string.IsNullOrEmpty(workOrderNumber))
                  {
                       throw new Exception("Approved: Work order number is empty or null.");
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


        public void TakeScreenshotOfApprovingAnCMWorkOrderTestScenarioFour() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-206SC04", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-206SC04.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-REG-206SC04_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        //Automatic work order status transition to WMATL POM Step

        public void OpenInventoryMenu() =>
           AllureLogger.LogStep("Open Inventory menu", () =>
               SafeActions.Click(driver, By.Id("menu0_INVENTOR_MODULE_a_tnode"),
                                 "Open Inventory menu"));

        public void OpenApplicationInventory() =>
         AllureLogger.LogStep("Launch application Inventory", () =>
             SafeActions.Click(driver, By.Id("menu0_INVENTOR_MODULE_sub_changeapp_INVENTOR_a_tnode"),
                               "Launch application Inventory"));

             public void FilterTableInventor(string Item, string storeroom) =>
         AllureLogger.LogStep($"I filter CM Work Order table with Description = '{Item}', Status = '{storeroom}','", () =>
         {
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

               // Adjust column indices as per actual table structure:
              // Description = column 2 → C:2
             // Status = column 10 → C:10

               By ItemFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");
               By storeroomFilterLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:3\\]_txt-tb");

               IWebElement ItemFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ItemFilterLocator));
              ItemFilter.Click();
              ItemFilter.Clear();
              ItemFilter.SendKeys(Item);

               IWebElement storeroomFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(storeroomFilterLocator));
               storeroomFilter.Click();
               storeroomFilter.Clear();
               storeroomFilter.SendKeys(storeroom);

               // Press Enter on the last filter field to trigger filtering
               storeroomFilter.SendKeys(Keys.Enter);
         });


             public void GoToTeamLeaderArisingTab() =>
          AllureLogger.LogStep("I go to Team Leader Arising Tab", () =>
          {
              SafeActions.Click(driver, By.Id("m1e20cba1-sct_anchor_2"),
                           "I go to Team Leader Arising Tab");

                // Delay AFTER the click (1 second)
                  Task.Delay(5000).Wait();
          });

        public void FilterTableTeamLeaderArisingTabWorkType(string WorkType) =>
      AllureLogger.LogStep($"I filter table Team Leader Arising Tab Work Type with '{WorkType}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

          // Step 1: Click on the filter/search icon first
          By filterIconLocator = By.CssSelector("#mf55b6555-lb2"); // Update selector as needed
          IWebElement filterIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterIconLocator));
          filterIcon.Click();

          // Step 2: Interact with the filter input field
          By filterIconWorkType = By.Id("WORKTYPE@505174");
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterIconWorkType));
          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(WorkType);
          filterField.SendKeys(Keys.Enter);

      });

        public void SelectCMWorkOrderFromTableRecords() =>
         AllureLogger.LogStep("I select CM Work Order from table records", () =>
         {
             SafeActions.Click(driver, By.XPath("//*[@id=\"rsportletdata_505174\"]/table/tbody/tr[3]/td[1]/a"),
                          "I select CM Work Order from table records");
                         
             Task.Delay(5000).Wait();
         });
                         
        public void GoToTabPlan() =>
        AllureLogger.LogStep("I go to tab Plan", () =>
            SafeActions.Click(driver, By.Id("m356798d1-tab_anchor"),
                              "I go to tab Plan"));

        public void GoToTabmaterials() =>
        AllureLogger.LogStep("I go to tab materials", () =>
            SafeActions.Click(driver, By.Id("m465d1be5-tab_anchor"),
                              "I go to tab materials"));

        public void PressAddNewRowUnderMaterialsTab() =>
        AllureLogger.LogStep("I press add new row under materials tab", () =>
            SafeActions.Click(driver, By.CssSelector("#m900f2d81_bg_button_addrow-pb"),
                              "I press add new row under materials tab"));

        public void ChooseSelectValueFromDetailMenuOfItemField() =>
       AllureLogger.LogStep("I choose Select Value from Detail Menu of Item field", () =>
           SafeActions.Click(driver, By.CssSelector("#md9029b42-img"),
                             "I choose Select Value from Detail Menu of Item field"));

        public void SelectValueOptionOfItemfield() =>
       AllureLogger.LogStep("Select Value Option Of Item field", () =>
           SafeActions.Click(driver, By.Id("ITEM_item0_a_tnode"),
                             "Select Value Option Of Item field"));

        public void FilterTableItem(string Item) =>
      AllureLogger.LogStep($"I filter table Team Leader Arising Tab Work Type with '{Item}'", () =>
      {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
          By filterItem = By.CssSelector("#lookup_page1_tfrow_\\[C\\:0\\]_txt-tb");
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterItem));
          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Item);
          filterField.SendKeys(Keys.Enter);

      });

        public void SelectNoRecordFromItemTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Priority Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
            });
        }

        public void SelectDetailMenuOfStoreroomField() =>
       AllureLogger.LogStep("Detail Menu Of Storeroom field", () =>
           SafeActions.Click(driver, By.CssSelector("#md25edc7f-img"),
                             "Detail Menu Of Storeroom field"));

        public void SelectValueOptionOfStoreroomfield() =>
      AllureLogger.LogStep("Select Value Option Of Storeroom field", () =>
          SafeActions.Click(driver, By.Id("NORMAL_normal0_a_tnode"),
                            "Select Value Option Of Storeroom field"));

        public void SelectNoRecordFromStoreroomTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Priority Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Location Table Records");
            });
        }

        public void SetDirectIssueActive() =>
      AllureLogger.LogStep("I set Direct Issue active", () =>
          SafeActions.Click(driver, By.CssSelector("#m4c3a49dc-cb_img"),
                            "I set Direct Issue active"));

        public void SetRadioFieldToWaitingMaterials() =>
      AllureLogger.LogStep("I set (Radio) field to Waiting Materials", () =>
          SafeActions.Click(driver, By.CssSelector("#m58406fba-rb"),
                            "I set (Radio) field to Waiting Materials"));

        public void IPressOkDialogButton() =>
         AllureLogger.LogStep("I press ok dialog button", () =>
             SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                               "I press ok dialog button"));

            public void VerifyStatusFieldHasValueWMATL() =>
       AllureLogger.LogStep("I verify Status field has value WMATL", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var WorkOrderStatus = driver.FindElement(By.CssSelector("#md1c6a351-tb"));

               // Get the 'value' attribute of the element
               string Status = WorkOrderStatus.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(Status))
               {
                   throw new Exception("Status: Work order number is empty or null.");
               }

               // Log success with the work order number
               Console.WriteLine("Success: Work order number is " + Status);
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


        public void TakeScreenshotOfAutomaticWorkOrderStatusTransitionToWMATLTest() =>
      AllureLogger.LogStep("Capture Screenshot for GTRDWM-REG-207SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\GTRDWM-REG-207SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\GTRDWM-207SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        public void VerifyGeneratedWMATLWorkOrderNumber() =>
       AllureLogger.LogStep("I verify generated WMATL work order number", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#maf77dfec-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("WMATL: Work order number is empty or null.");
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





    }





}
