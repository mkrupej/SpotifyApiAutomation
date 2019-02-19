using NUnit.Framework;
using SpotifyWebAppAutomation.Steps;

namespace SpotifyTest.MixedTests
{
    [TestFixture]
    public class PlayerControlsTests : BaseTests
    {
        [Test]
        public void PlayOnApi()
        {
            var playerControlSteps = new PlayerControlSteps(_loginPageSteps.PagesContext);
            _api.Play();
            Assert.That(playerControlSteps.IsPlaying());
        }

        [Test]
        public void PauseOnWebApp()
        {
            var playerControlSteps = new PlayerControlSteps(_loginPageSteps.PagesContext);
            playerControlSteps.Pause();
            Assert.That(playerControlSteps.IsPaused);
        }
    }
}