using System;
using System.Text;
using Allure.Net.Commons;

namespace GTR_AUTOMATED.Utilities
{
    /// <summary>
    /// Thin wrapper around the Allure 2 runtime helpers
    /// plus a few convenience methods for screenshots, text,
    /// and (now) the user’s login role.
    /// </summary>
    public static class AllureLogger
    {
        private static readonly AllureLifecycle Allure = AllureLifecycle.Instance;

        /* ---------- normal helpers ---------- */

        public static void LogStep(string name, Action action) =>
            AllureApi.Step(name, action);

        public static void AddTextAttachment(string title, string content) =>
            AllureApi.AddAttachment(
                title,
                "text/plain",
                Encoding.UTF8.GetBytes(content));

        public static void AddScreenshot(string title, byte[] png) =>
            AllureApi.AddAttachment(title, "image/png", png);

        public static void LogError(Exception ex, string context) =>
            AddTextAttachment($"Exception – {context}", ex.ToString());

        /* ---------- NEW: user‑login role helper ---------- */

        /// <summary>
        /// Adds/updates a “User role” parameter on the current test‑case
        /// and attaches the role name as a tiny text attachment so it is
        /// visible in step view as well.
        /// Call this once, right after you log in.
        /// </summary>
        public static void SetUserLoginRole(string role)
        {
            if (string.IsNullOrWhiteSpace(role)) return;

            // 1️⃣  parameter on the test‑case header
            Allure.UpdateTestCase(tc =>
            {
                tc.parameters.RemoveAll(p => p.name == "User role");
                tc.parameters.Add(new Parameter { name = "User role", value = role });
            });

            // 2️⃣  small attachment for step‑level visibility
            AddTextAttachment("User role", role);
        }

            


    }
}
