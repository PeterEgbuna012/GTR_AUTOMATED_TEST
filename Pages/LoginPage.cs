using GTR_AUTOMATED.Utilities;
using OpenQA.Selenium;

namespace GTR_Automated_Tests.Pages
{
    /// <summary>
    /// Handles all Maximo login flows.
    /// Every public method is a one‑liner that wraps a common private Login() helper
    /// so credentials live in exactly one place and every attempt is reported to Allure.
    /// </summary>
    public class LoginPage
    {
        private readonly IWebDriver driver;

        /* ----- Locators ----- */
        private readonly By userField = By.Id("username");
        private readonly By passField = By.Id("password");
        private readonly By submitBtn = By.CssSelector("#loginform > div > input[type=submit]");

        public LoginPage(IWebDriver webDriver) => driver = webDriver;

        /* ---------- Core helper ---------- */
        private void LoginAs(string user, string pass) =>
            AllureLogger.LogStep($"Login as {user}", () =>
            {
                SafeActions.EnterText(driver, userField, user, "Username field");
                SafeActions.EnterText(driver, passField, pass, "Password field");
                SafeActions.Click(driver, submitBtn, "Submit button");
            });

        /* ---------- Role‑specific one‑liners ---------- */
        public void LoginAsStoresPerson() => LoginAs("PSTEVENS", "maximo");
        public void LoginAsFaultAnalyst() => LoginAs("MTICKNER", "maximo");
        public void LoginAsMaterialsController() => LoginAs("PBANKS", "maximo");
        public void LoginAsTeamLeaderStores() => LoginAs("MFLYNN", "maximo");
        public void LoginAsStoresPersonHornsey() => LoginAs("MDUMPHY", "maximo");
        public void LoginAsSandMaster() => LoginAs("ABOLTON", "maximo");
        public void LoginAsAdmin() => LoginAs("ABOLTON", "maximo");
        public void LoginAsMaxAdmin() => LoginAs("MAXADMIN", "maxadmin");
        public void LoginAsCMSADMIN() => LoginAs("ABANTON", "maximo");
        public void LoginAsCMSManager() => LoginAs("ARICHARDS", "maximo");
        public void LoginAsTrainingManager() => LoginAs("ARICHARDS", "maximo");
        public void LoginAsMaintainerTeamLeader() => LoginAs("ISCOTT", "maximo");
        public void LoginAsTeamLeaderMaintainer() => LoginAs("AJONES", "maximo");
        public void LoginAsstores() => LoginAs("GHENDLEY", "maximo");
        public void LoginAsMaintainer() => LoginAs("ABRACE", "maximo");
        public void LoginAsMaterialsDepotManager() => LoginAs("GTAYLOR", "maximo");
        public void LoginAsCleanMaster() => LoginAs("ABOLTON", "maximo");
        public void LoginAsCleanMasterTeamLeader() => LoginAs("AWATKINS", "maximo");
        public void LoginAsMaximoadministrator() => LoginAs("PREED", "maximo");
        public void LoginAsCmsTeamLeader() => LoginAs("CALPHONSO", "maximo");
        public void LoginAsWarrantyManager() => LoginAs("BBRIDGES", "maximo");
        public void LoginAsMaterialsSupplyChainSupport() => LoginAs("JFEDERICO", "maximo");
        
    }
}
