using SpotifyWebAppAutomation.Pages;

namespace SpotifyWebAppAutomation.Steps
{
    public class PageObjectManager
    {
        public PageObjectManager()
        {
            LoginPage = new LoginPage();
            HomePage = new HomePage();
            AlbumPage = new AlbumPage();
            ArtistPage = new ArtistPage();
            PlaylistPage = new PlaylistPage();
            QueuePage = new QueuePage();
            SearchPage = new SearchPage();
            YourLibraryPage = new YourLibraryPage();
        }

        public BasePage CurrentPage { get; set; }

        public LoginPage LoginPage { get; set; }

        public HomePage HomePage { get; set; }

        public AlbumPage AlbumPage { get; set; }

        public ArtistPage ArtistPage { get; set; }

        public PlaylistPage PlaylistPage { get; set; }

        public QueuePage QueuePage { get; set; }

        public SearchPage SearchPage { get; set; }

        public YourLibraryPage YourLibraryPage { get; set; }
    }
}