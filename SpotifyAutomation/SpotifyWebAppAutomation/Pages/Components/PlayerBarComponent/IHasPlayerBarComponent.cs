using SpotifyWebAppAutomation.Pages.PlayerBar;

namespace SpotifyWebAppAutomation.Pages
{
    public interface IHasPlayerBarComponent
    {
        PlayerBarComponent PlayerBar { get; }
    }
}