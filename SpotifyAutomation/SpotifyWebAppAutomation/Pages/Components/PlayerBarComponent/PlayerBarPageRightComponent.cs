using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SpotifyWebAppAutomation.Extensions;

namespace SpotifyWebAppAutomation.Pages.PlayerBar
{
    public partial class PlayerBarComponent
    {
        private IWebElement QueueButton => Driver.Instance.FindElement(By.XPath("//button[@title = 'Queue']"));

        private readonly By MuteButtonLocator = By.XPath("//div[@class = 'volume-bar']/button[@aria-label='Mute']");

        private IWebElement MuteButton => Driver.Instance.FindElement(MuteButtonLocator);

        private IWebElement UnmuteButton => Driver.Instance.FindElement(By.XPath("//div[@class = 'volume-bar']/button[@aria-label='Unmute']"));

        private RemoteWebElement VolumeBar => (RemoteWebElement)Driver.Instance.FindElement(By.XPath("//div[@class = 'volume-bar']/div[@class = 'progress-bar']"));

        public QueuePage GoToQueue()
        {
            QueueButton.Click();
            return new QueuePage();
        }

        public void Unmute() => UnmuteButton.Click();

        public bool IsMuted() => !Driver.Instance.IsElementFoundByPresent(MuteButtonLocator);

        public bool IsNotMuted() => !IsMuted();

        public void Mute() => MuteButton.Click();

        public void SetVolume(double volumePercentage) => VolumeBar.ChangeSliderValue(volumePercentage);
    }
}