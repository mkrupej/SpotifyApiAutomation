using NUnit.Framework;
using SpotifyWebAppAutomation.Pages.PlayerBar;

namespace SpotifyWebAppAutomation.Steps
{
    public class PlayerControlSteps : BaseSteps
    {
        private readonly PlayerBarComponent playerBar;

        public PlayerControlSteps(PageObjectManager pages)
        {
            PagesContext = pages;
            playerBar = PagesContext.CurrentPage.PlayerBar;
        }

        public void GoToCurrentAlbum()
        {
            PagesContext.CurrentPage = playerBar.GoToCurrentAlbum();
        }

        public void GoToCurrentPlaylist()
        {
            PagesContext.CurrentPage = playerBar.GoToCurrentPlaylist();
        }

        public void GoToCurrentArtist()
        {
            PagesContext.CurrentPage = playerBar.GoToCurrentArtist();
        }

        public void SaveCurrentSongToLibrary()
        {
            if (playerBar.IsNotSavedToLibrary)
            {
                playerBar.SaveToLibrary();
            }
            Assert.IsTrue(playerBar.IsSavedToLibrary, "Song is not saved to library when expected opposite");
        }

        public void RemoveCurrentSongFromLibrary()
        {
            if (playerBar.IsSavedToLibrary)
            {
                playerBar.RemoveFromLibrary();
            }
            Assert.IsTrue(playerBar.IsNotSavedToLibrary, "Song is saved to library when expected opposite");
        }

        public void EnableShuffle()
        {
            if (!playerBar.IsShufflingEnabled)
            {
                playerBar.EnableShuffle();
            }
        }

        public void DisableShuffle()
        {
            if (playerBar.IsShufflingEnabled)
            {
                playerBar.DisableShuffle();
            }
        }

        public void Play()
        {
            if (playerBar.IsSongPaused)
            {
                playerBar.Play();
            }
        }

        public void Pause()
        {
            if (playerBar.IsSongPlayed)
            {
                playerBar.Pause();
            }
        }

        public bool IsPaused()
        {
            return playerBar.IsSongPaused;
        }

        public bool IsPlaying()
        {
            return playerBar.IsSongPlayed;
        }

        public void SetSongProgress(double progressPercentage)
        {
            playerBar.SetSongProgress(progressPercentage);
        }

        public void PlayNext()
        {
            playerBar.NextSong();
        }

        public void PlayPrevious()
        {
            playerBar.PreviousSong();
        }
    }
}