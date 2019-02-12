using OpenQA.Selenium;
using SpotifyWebAppAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotifyWebAppAutomation.Pages
{
    public class LeftPanelComponent
    {
        private IWebElement SearchButton => Driver.Instance.FindElement(By.XPath("//span[text() = 'Search']"));
        private IWebElement HomeButton => Driver.Instance.FindElement(By.XPath("//span[text() = 'Home']"));
        private IWebElement YourLibraryButton => Driver.Instance.FindElement(By.XPath("//span[text() = 'Your Library']"));

        public SearchPage GoToSearch()
        {
            SearchButton.Click();
            return new SearchPage();
        }

        public HomePage GoToHome()
        {
            HomeButton.Click();
            return new HomePage();
        }

        public YourLibraryPage GoToYourLibrary()
        {
            YourLibraryButton.Click();
            return new YourLibraryPage();
        }

        public BasePage GoToRecentlyPlayedItem(Ordinal recentlyPlayedItemIndex)
        {
            var recentlyPlayed = GetRecentlyPlayedItems.ElementAt((int)recentlyPlayedItemIndex);

            switch (recentlyPlayed.FindElement(By.TagName("span")).Text)
            {
                case RecentlyPlayedItemTypes.PLAYLIST:
                    return new PlaylistPage();

                case RecentlyPlayedItemTypes.ALBUM:
                    return new AlbumPage();

                case RecentlyPlayedItemTypes.ARTIST:
                    return new ArtistPage();

                default:
                    return new PlaylistPage();
            }
        }

        private IReadOnlyCollection<IWebElement> GetRecentlyPlayedItems => Driver.Instance.FindElements(By.XPath("//h2[text() = 'RECENTLY PLAYED']/following-sibling::ul/descendant::a"));

        //public PlaylistPage GetRecentlyPlayed(int index)
        //{
        //    GetRecentlyPlayedItems.ElementAt(index).Click();
        //    return new PlaylistPage();
        //}
    }
}