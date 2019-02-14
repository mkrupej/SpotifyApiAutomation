using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace SpotifyWebAppAutomation.Extensions
{
    public static class WebElementExtensions
    {
        public static void ChangeSliderValue(this RemoteWebElement slider, double percentage)
        {
            var width = slider.Size.Width;
            var driver = slider.WrappedDriver;

            Actions actions = new Actions(driver);
            actions.MoveToElement(slider, (int)((width * percentage) / 100), 0).ClickAndHold().Release().Perform();
        }
    }
}