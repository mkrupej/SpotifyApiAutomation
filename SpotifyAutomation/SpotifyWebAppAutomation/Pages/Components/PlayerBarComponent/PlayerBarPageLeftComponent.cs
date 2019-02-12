using OpenQA.Selenium;
using SpotifyWebAppAutomation.Extensions;

namespace SpotifyWebAppAutomation.Pages.PlayerBar
{
    public partial class PlayerBarComponent
    {
        private readonly By saveToLibraryButtonLocator = By.XPath("//footer/descendant::button[@title = 'Save to Your Library']");

        private readonly By removeFromLibraryButtonLocator = By.XPath("//footer/descendant::button[@title = 'Remove from Your Library']");

        private IWebElement SaveToLibraryButton => Driver.Instance.FindElement(saveToLibraryButtonLocator);

        private IWebElement RemoveFromLibraryButton => Driver.Instance.FindElement(removeFromLibraryButtonLocator);

        private IWebElement CoverMiniatureLink => Driver.Instance.FindElement(By.XPath("//footer/descendant::div[@class = 'cover-art-image cover-art-image-loaded']"));

        private IWebElement SongNameLink => Driver.Instance.FindElement(By.XPath("//div[@class = 'react-contextmenu-wrapper']/span/a"));

        private IWebElement ArtistNameLink => Driver.Instance.FindElement(By.XPath("//span[@class = 'react-contextmenu-wrapper']/span/a"));

        public PlaylistPage GoToCurrentPlaylist()
        {
            CoverMiniatureLink.Click();
            return new PlaylistPage();
        }

        public AlbumPage GoToCurrentAlbum()
        {
            SongNameLink.Click();
            return new AlbumPage();
        }

        public ArtistPage GoToCurrentArtist()
        {
            ArtistNameLink.Click();
            return new ArtistPage();
        }

        public bool IsNotSavedToLibrary => Driver.Instance.IsElementFoundByPresent(saveToLibraryButtonLocator);

        public bool IsSavedToLibrary => Driver.Instance.IsElementFoundByPresent(removeFromLibraryButtonLocator);

        public void SaveToLibrary() => SaveToLibraryButton.Click();

        public void RemoveFromLibrary() => RemoveFromLibraryButton.Click();
    }
}