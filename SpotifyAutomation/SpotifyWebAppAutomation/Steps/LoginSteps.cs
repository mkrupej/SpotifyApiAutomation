using TechTalk.SpecFlow;

namespace SpotifyWebAppAutomation.Steps
{
    public class LoginSteps : BaseSteps
    {
        public LoginSteps()
        {
            PagesContext = new PageObjectManager();
        }

        [Given(@"I have logged as ""(.*)""}")]
        public void LoginAsUser(string username)
        {
            PagesContext.LoginPage.Goto();
            PagesContext.CurrentPage = PagesContext.LoginPage.LoginAs(username).Login();
        }
    }
}