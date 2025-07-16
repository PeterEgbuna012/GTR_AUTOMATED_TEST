using GTR_AUTOMATED.Pages;
using GTR_AUTOMATED.Utilities;
using GTR_Automated_Tests.Pages;
using OpenQA.Selenium;
using Reqnroll;
using TechTalk.SpecFlow;
using BindingAttribute = TechTalk.SpecFlow.BindingAttribute;
using GivenAttribute = TechTalk.SpecFlow.GivenAttribute;
using PendingStepException = TechTalk.SpecFlow.PendingStepException;
using Table = TechTalk.SpecFlow.Table;
using ThenAttribute = TechTalk.SpecFlow.ThenAttribute;
using WhenAttribute = TechTalk.SpecFlow.WhenAttribute;

namespace GTR_AUTOMATED.StepDefinitions
{
    [Binding]
    public sealed class FaultsStepDefinitions
    {

        private readonly IWebDriver driver;
        private readonly FAULTSPOM pom;

        public FaultsStepDefinitions(IWebDriver drv)
        {
            driver = drv;
            pom = new FAULTSPOM(driver);

        }

        [Given("I sign as Fault")]
        public void GivenISignAsFault()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAsFaultAnalyst();
            AllureLogger.SetUserLoginRole("Fault");
        }
                        
                
        [Then("Relationship field has value FOLLOWUP")]
        public void ThenRelationshipFieldHasValueFOLLOWUP()
        {
            AllureLogger.LogStep("Relationship field has value FOLLOWUP",
                 pom.RelationshipFieldHasValueFOLLOWUP);
        }


        [Then("I take screenshot of Raising a Fault Test")]
        public void ThenITakeScreenshotOfRaisingAFaultTest()
        {
            AllureLogger.LogStep("I take screenshot of Raising a Fault Test",
              pom.TakeScreenshotOfRaisingAFaultTest);
        }







    }
}