using SpotifyWebAppAutomation.Pages.PlayerBar;

namespace SpotifyWebAppAutomation.Pages
{
    public abstract class BasePage
    {
        public PlayerBarComponent PlayerBar { get; }
        public LeftPanelComponent LeftPanel { get; }

        protected BasePage()
        {
            PlayerBar = new PlayerBarComponent();
            LeftPanel = new LeftPanelComponent();
        }
    }
}