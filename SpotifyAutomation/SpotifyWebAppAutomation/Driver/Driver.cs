using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SpotifyWebAppAutomation
{
    public static class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get
            {
                return "https://open.spotify.com/browse/featured";
            }
        }

        public static void Initialize()
        {
            ChromeOptions options = GetDriverOptions();
            Instance = new ChromeDriver(options);
            Instance.Manage().Window.Position = new System.Drawing.Point(-1000, 0);
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            //TurnOnImplicitWait();
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static ChromeOptions GetDriverOptions()
        {
            var options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Driver, LogLevel.All);
            options.AddAdditionalCapability("useAutomationExtension", false);
            return options;
        }

        private static void TurnOnImplicitWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        private static void TurnOffImplicitWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.00);
        }
    }
}