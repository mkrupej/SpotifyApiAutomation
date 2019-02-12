using static SpotifyWebAppAutomation.Driver;

namespace SpotifyWebAppAutomation.Pages
{
    public class HomePage : BasePage, IHasPlayerBarComponent, IHasLeftPanelComponent
    {
        public void Goto()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }
    }
}