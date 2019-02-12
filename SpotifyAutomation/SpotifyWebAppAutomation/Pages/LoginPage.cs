using OpenQA.Selenium;
using SpotifyWebAppAutomation.Extensions;

using SpotifyWebAppAutomation.Management.RestSharpSpot.Miscellaneous;

namespace SpotifyWebAppAutomation.Pages
{
    public class LoginPage
    {
        public void Goto()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
            Driver.Instance.FindElement(By.XPath("//button[text() = 'Log in']")).Click();
        }

        public LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string _userName;
        private readonly string _password;

        public LoginCommand(string userName)
        {
            _userName = userName;
            _password = new KeyManager().Key;
        }

        public HomePage Login()
        {
            Driver.Instance.FindElement(By.Id("login-username"), 5).SendKeys(_userName);
            Driver.Instance.FindElement(By.Id("login-password")).SendKeys(_password);

            Driver.Instance.FindElement(By.Id("login-button")).Click();
            return new HomePage();
        }
    }
}