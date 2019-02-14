using TechTalk.SpecFlow;

namespace SpotifyWebAppAutomation.Steps
{
    public class LoginSteps : BaseSteps
    {
        public LoginSteps()
        {
            Pages = new PageObjectManager();
        }

        [Given(@"I have logged as ""(.*)""}")]
        public void LoginAsUser(string username)
        {
            Pages.LoginPage.Goto();
            Pages.CurrentPage = Pages.LoginPage.LoginAs(username).Login();
        }
    }
}