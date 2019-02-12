using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SpotifyWebAppAutomation.Extensions;

namespace SpotifyWebAppAutomation.Pages.PlayerBar
{
    public partial class PlayerBarComponent
    {
        private readonly By pauseButtonLocator = By.XPath("//button[@title = 'Pause']");

        private readonly By playButtonLocator = By.XPath("//button[@title = 'Play']");

        private IWebElement PauseButton => Driver.Instance.FindElement(pauseButtonLocator);

        public By disableShuffleButtonLocator = By.XPath("//button[@title = 'Disable shuffle']");

        private IWebElement PlayButton => Driver.Instance.FindElement(playButtonLocator);

        private IWebElement PreviousSongButton => Driver.Instance.FindElement(By.XPath("//button[@title = 'Previous']"));

        private IWebElement NextSongButton => Driver.Instance.FindElement(By.XPath("//button[@title = 'Next']"));

        private IWebElement EnableShuffleButton => Driver.Instance.FindElement(By.XPath("//button[@title = 'Enable shuffle']"));

        private IWebElement DisableShuffleButton => Driver.Instance.FindElement(disableShuffleButtonLocator);

        private RemoteWebElement ProgressBar => (RemoteWebElement)Driver.Instance.FindElement(By.XPath("//*[@class = 'progress-bar__fg']"));

        public void EnableShuffle() => EnableShuffleButton.Click();

        public void DisableShuffle() => DisableShuffleButton.Click();

        public void Play() => PlayButton.Click();

        public void Pause() => PauseButton.Click();

        public void NextSong() => NextSongButton.Click();

        public void PreviousSong() => PreviousSongButton.Click();

        public void SetSongProgress(double progressPercentage) => ProgressBar.ChangeSliderValue(progressPercentage);

        public bool IsSongPaused => Driver.Instance.IsElementFoundByPresent(playButtonLocator);

        public bool IsSongPlayed => Driver.Instance.IsElementFoundByPresent(pauseButtonLocator);

        public bool IsShufflingEnabled => Driver.Instance.IsElementFoundByPresent(disableShuffleButtonLocator);
    }
}