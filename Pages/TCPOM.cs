using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
namespace GTR_AUTOMATED.Pages
{
    [Binding]
    public sealed class TCPOM
    {
        private readonly IWebDriver driver;
        public TCPOM(IWebDriver drv) => driver = drv;

        public void OpenGoToMenu() =>
           AllureLogger.LogStep("Open [Go To] menu", () =>
               SafeActions.Click(driver, By.Id("titlebar-tb_gotoButton"),
                                 "Go To button"));

        public void OpenWorkOrderMenu() =>
            AllureLogger.LogStep("Open [Work Order] menu", () =>
                SafeActions.Click(driver, By.Id("menu0_WO_MODULE_a_tnode"),
                                  "Work Order menu node"));

        public void OpenApplicationToiletCheckerMXR() =>
        AllureLogger.LogStep("Launch application Toilet Checker", () =>
            SafeActions.Click(driver, By.Id("menu0_WO_MODULE_sub_changeapp_MXRTOILETCHECKER_a"),
                              "Launch application Toilet Checker"));


          public void FilterTableToiletChecker(string ToiletChecker) =>
      AllureLogger.LogStep($"I filter table Toilet Checker with '{ToiletChecker}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(ToiletChecker);
          filterField.SendKeys(Keys.Enter);
      });


        public void SelectViewDetailsArrow() =>
         AllureLogger.LogStep("I select View Details arrow", () =>
             SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                               "I select View Details arrow"));


             public void VerifyToiletNumber() =>
           AllureLogger.LogStep("I verify toilet number", () =>
           {
                try
                {
                      // Wait 5 seconds for the page or element to load
                      Task.Delay(5000).Wait();

                     // Find the Related Work Order element by CSS selector
                     var relatedWorkOrder = driver.FindElement(By.CssSelector("#m7ec1f31b-tb"));

                    // Get the 'value' attribute of the element
                    string workOrderNumber = relatedWorkOrder.GetAttribute("value");

                     // Check if the work order number is null or empty
                     if (string.IsNullOrEmpty(workOrderNumber))
                     {
                          throw new Exception("Work Order: Work order number is empty or null.");
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


        public void VerifyToiletDescription() =>
       AllureLogger.LogStep("I verify toilet number", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#m7ec1f31b-tb2"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Work Order: Work order number is empty or null.");
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

         public void VerifyToiletStatus() =>
       AllureLogger.LogStep("I verify toilet number", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#m90cf9237-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Status: reason is empty or null.");
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

        public void VerifyToiletUnavailabilityReason() =>
       AllureLogger.LogStep("I verify toilet unavailability reason", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#meab0794-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("reason: reason is empty or null.");
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


          public void VerifyToiletLocked() =>
       AllureLogger.LogStep("I verify toilet locked", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#me0a566b8-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Status: reason is empty or null.");
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


            public void VerifyToiletCheckedDate() =>
       AllureLogger.LogStep("I verify toilet locked", () =>
       {
           try
           {
               // Wait 5 seconds for the page or element to load
               Task.Delay(5000).Wait();

               // Find the Related Work Order element by CSS selector
               var relatedWorkOrder = driver.FindElement(By.CssSelector("#meab0794-tb"));

               // Get the 'value' attribute of the element
               string workOrderNumber = relatedWorkOrder.GetAttribute("value");

               // Check if the work order number is null or empty
               if (string.IsNullOrEmpty(workOrderNumber))
               {
                   throw new Exception("Toilet Checked Date: reason is empty or null.");
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



        public void SelectTheCloseDetailsArrow() =>
        AllureLogger.LogStep("I select the Close Details arrow", () =>
            SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:0]_tgdet-ti[R:0]_img"),
                              "I select the Close Details arrow"));


         public void TakeScreenshotOfViewToiletStatus() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-001", () =>
       {
           try
           {
                var takescreenshot = new TakeScreenShotPOM(driver);
                string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-001.png";

                takescreenshot.TakeScreenshot(driver, successPath);
           }
                catch (Exception ex)
                {
                     Console.WriteLine($"Screenshot failed: {ex.Message}");

                     // Attempt fallback screenshot on failure
                     var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-001_Failure.png";
                     var takescreenshot = new TakeScreenShotPOM(driver);

                     takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

                     // Optional: Rethrow if test should fail
                      throw new Exception("Test failed while taking screenshot.", ex);
                }
       });



        //Change status of a Toilet Asset POM Steps


        public void SelectChangeToiletAssetStatuseButton() =>
        AllureLogger.LogStep("I select change toilet asset statuse button", () =>
            SafeActions.Click(driver, By.Id("m6a7dfd2f_tdrow_[C:8]_hyperlink-lb[R:0]_image"),
                              "I select change toilet asset statuse button"));


        public void ClickOnTheStatusDropdown() =>
        AllureLogger.LogStep("I Click on the status dropdown", () =>
            SafeActions.Click(driver, By.Id("m1c9ae976-img"),
                              "I Click on the status dropdown"));

        public void SelectUnavailable() =>
        AllureLogger.LogStep("I select unavailable", () =>
            SafeActions.Click(driver, By.Id("menu0_UNAVAILABLE_OPTION_a_tnode"),
                              "I select unavailable"));

         public void FilterTableToiletUnavailableReason(string ToiletCheckerunavailableReason) =>
      AllureLogger.LogStep($"I filter table Toilet Unavailable Reason with '{ToiletCheckerunavailableReason}'", () =>
      {
          Task.Delay(2000).Wait();
          By filterFieldLocator = By.CssSelector("#m8593b8cc-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(ToiletCheckerunavailableReason);
         
      });

        public void PressButtonOk() =>
        AllureLogger.LogStep("I press button ok", () =>
            SafeActions.Click(driver, By.CssSelector("#m5f66e129-pb"),
                              "I press button ok"));

        public void SelectAvailable() =>
        AllureLogger.LogStep("I select available", () =>
            SafeActions.Click(driver, By.Id("menu0_AVAILABLE_OPTION_a_tnode"),
                              "I select available"));


        public void TakeScreenshotOfChangeStatusOfAToiletAsset() =>
       AllureLogger.LogStep("Capture Screenshot for UAT-TAS-002SC02", () =>
       {
           try
           {
               var takescreenshot = new TakeScreenShotPOM(driver);
               string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-002SC02.png";

               takescreenshot.TakeScreenshot(driver, successPath);
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Screenshot failed: {ex.Message}");

               // Attempt fallback screenshot on failure
               var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-002SC02_Failure.png";
               var takescreenshot = new TakeScreenShotPOM(driver);

               takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

               // Optional: Rethrow if test should fail
               throw new Exception("Test failed while taking screenshot.", ex);
           }
       });


        //Lock/ Unlock a Toilet Asset POM Steps


        public void TakeScreenshotOfToiletStatusUnlock() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-002SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-002SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-002SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        public void PressButtonLockUnlockAToiletAsset() =>
        AllureLogger.LogStep("I press button Lock\\/Unlock a Toilet Asset", () =>
            SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:11]_hyperlink-lb[R:0]_image"),
                              "I press button Lock\\/Unlock a Toilet Asset"));


        public void EnterFollowingToiletCheckerData(string Comment) =>
      AllureLogger.LogStep($"I enter following Toilet Checker data '{Comment}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m78f8c09b-ta");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Comment);
          filterField.SendKeys(Keys.Enter);
      });


        public void PressOkButton() =>
        AllureLogger.LogStep("I press ok button", () =>
            SafeActions.Click(driver, By.CssSelector("#m42896c82-pb"),
                              "I press ok button"));


        public void PressDialogButtonNo() =>
        AllureLogger.LogStep("I press dialog button no", () =>
            SafeActions.Click(driver, By.CssSelector("#m96ad0396-pb"),
                              "I press dialog button no"));

        public void PressDialogButtonYes() =>
        AllureLogger.LogStep("I press dialog button yes", () =>
            SafeActions.Click(driver, By.CssSelector("#me1720906-pb"),
                              "I press dialog button yes"));


        //Check audit logs POM Steps


        public void PressButtonViewAuditLog() =>
        AllureLogger.LogStep("I press button View Audit Log", () =>
            SafeActions.Click(driver, By.CssSelector("#m39e89483-pb"),
                              "I press button View Audit Log"));

        public void TakeScreenshotOfAuditLog() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-004", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-004.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-004_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void PressOKButton() =>
        AllureLogger.LogStep("I press OK button", () =>
            SafeActions.Click(driver, By.CssSelector("#m11fb890d-pb"),
                              "I press OK button"));


        // Audit Log Updates POM Steps


          public void TakeScreenshotOfAuditLogUpdates() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-005", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-005.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-005_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });


        //Update status of  locked Toilet Asset POM Steps


        public void PressOkDialogSystemMessageButton() =>
       AllureLogger.LogStep("I press ok dialog system message button", () =>
           SafeActions.Click(driver, By.CssSelector("#m88dbf6ce-pb"),
                             "I press ok dialog system message button"));


         public void TakeScreenshotOfUpdateStatusOfLockedToiletAssetTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-006", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-006.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-006_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void ChangeToiletAssetStatuseButton() =>
       AllureLogger.LogStep("I change toilet asset statuse button", () =>
           SafeActions.Click(driver, By.Id("m6ef0bfaf_tdrow_[C:10]_hyperlink-lb[R:0]_image"),
                             "I change toilet asset statuse button"));



        //Toilet Asset Setup POM Steps


        public void OpenAssetMenu() =>
            AllureLogger.LogStep("Asset Menu Bar", () =>
                SafeActions.Click(driver, By.Id("menu0_ASSET_MODULE_a"),
                                  "Asset Menu node"));

        public void SelectNoRecordFromAssetsTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Asset Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:1]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Asset Table Records");
                Task.Delay(5000).Wait();

            });
        }
        
        public void OpenApplicationAssetTr() =>
            AllureLogger.LogStep("Launch application Asset (TR)", () =>
                SafeActions.Click(driver, By.Id("menu0_ASSET_MODULE_sub_changeapp_PLUSTASSET_a_tnode"),
                                  "Launch application Asset (TR)"));


         public void FilterTableAssets(string Asset) =>
      AllureLogger.LogStep($"I filter table Asset with '{Asset}'", () =>
      {
          By filterFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:1\\]_txt-tb");

          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          IWebElement filterField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(filterFieldLocator));

          filterField.Click();
          filterField.Clear();
          filterField.SendKeys(Asset);
          filterField.SendKeys(Keys.Enter);
      });

                public void GoToTabSpecifications() =>
      AllureLogger.LogStep("I go to Tab Specifications", () =>
          SafeActions.Click(driver, By.Id("mbda8a4b-tab_anchor"),
                            "I go to Tab Specifications"));



        public void AddNewRecordInSpecificationsSection() =>
            AllureLogger.LogStep("I add new record in Specifications section", () =>
                SafeActions.Click(driver, By.CssSelector("#mc8d54871_bg_button_addrow-pb"),
                                  "I add new record in Specifications section"));

        public void OpenSelectValueLookupForAttributeField() =>
           AllureLogger.LogStep("I open Select Value lookup for attribute field", () =>
               SafeActions.Click(driver, By.CssSelector("#m92e4efeb-img"),
                                 "I open Select Value lookup for attribute field"));

        public void SelectNoRecordFromAttributeTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From attribute Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From attribute Table Records");
            });

        }

        public void OpenSelectValueLookupForAlphanumericValueField() =>
          AllureLogger.LogStep("I open Select Value lookup for alphanumeric value field", () =>
              SafeActions.Click(driver, By.CssSelector("#m9ab0008-img"),
                                "I open Select Value lookup for alphanumeric value field"));

        public void SelectNoRecordFromAlphanumericValueTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From alphanumeric Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"lookup_page1_tdrow_[C:0]_ttxt-lb[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From alphanumeric Table Records");
            });

        }


         public void TakeScreenshotOfUpdateStatusOfToiletAssetSetupTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-007SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-007SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-007SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

           public void TakeScreenshotOfValidateToiletAssetSetupTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-007SC02", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-007SC02.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-007SC02_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });



        //View Clean Master Work orders POM Steps

        public void RefreshToiletCheckerTableRecords() =>
         AllureLogger.LogStep("I refresh Toilet Checker table records", () =>
         {
               By textFieldLocator = By.CssSelector("#m6a7dfd2f_tfrow_\\[C\\:0\\]_txt-tb");

              // Wait for the field to be visible and interactable
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
              IWebElement textField = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(textFieldLocator));

              // Click the field
               textField.Click();

              // Send ENTER key
              textField.SendKeys(Keys.Enter);
         });

        public void SelectNoRecordFromToiletCheckerTableRecords(int recordNumber)
        {
            AllureLogger.LogStep($"I Select No {recordNumber} Record From Toilet Checker Table Records", () =>
            {
                // Assuming your selector needs to change row index [R:x] with recordNumber - 1 (zero-based)
                int zeroBasedIndex = recordNumber - 1;

                // Build dynamic Id selector by replacing the row index [R:x]
                string selector = $"m6a7dfd2f_tdrow_[C:0]-c[R:{zeroBasedIndex}]";

                SafeActions.Click(driver, By.Id(selector),
                    $"I Select No {recordNumber} Record From Toilet Checker Table Records");
            });

        }


        public void ViewCleanMasterWorkOrdersOption() =>
       AllureLogger.LogStep("I select View clean master work orders option", () =>
           SafeActions.Click(driver, By.Id("m6a7dfd2f_tdrow_[C:6]_hyperlink-lb[R:0]_image"),
                             "I select View clean master work orders option"));

        public void SelectCompleteCleanMasterTaskButton() =>
       AllureLogger.LogStep("I select complete clean master task button", () =>
           SafeActions.Click(driver, By.Id("md6723283_tdrow_[C:7]_hyperlink-lb[R:0]_image"),
                             "I select complete clean master task button"));

         public void TakeScreenshotOfViewCleanMasterWork() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-008SC01", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-008SC01.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-008SC01_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });

        public void PressOk() =>
       AllureLogger.LogStep("I press OK button", () =>
           SafeActions.Click(driver, By.CssSelector("#m37917b04-pb"),
                             "I press OK button"));

        

         public void TakeScreenshotOfViewCleanMasterWorkOrdersTest() =>
      AllureLogger.LogStep("Capture Screenshot for UAT-TAS-008SC02", () =>
      {
          try
          {
              var takescreenshot = new TakeScreenShotPOM(driver);
              string successPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\UAT-TAS-008SC02.png";

              takescreenshot.TakeScreenshot(driver, successPath);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Screenshot failed: {ex.Message}");

              // Attempt fallback screenshot on failure
              var failureScreenshotPath = @"C:\Documents\GTR_AUTOMATED\Screenshots\Failures\UAT-TAS-008SC02_Failure.png";
              var takescreenshot = new TakeScreenShotPOM(driver);

              takescreenshot.TakeScreenshot(driver, failureScreenshotPath);

              // Optional: Rethrow if test should fail
              throw new Exception("Test failed while taking screenshot.", ex);
          }
      });




    }





}