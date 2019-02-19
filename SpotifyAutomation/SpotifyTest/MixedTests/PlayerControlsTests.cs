using NUnit.Framework;
using SpotifyWebAppAutomation.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyTest.MixedTests
{
    [TestFixture]
    public class PlayerControlsTests : BaseTests
    {
        [Test]
        public void PauseOnWebApp()
        {
            var playerControlSteps = new PlayerControlSteps(_loginPageSteps.PagesContext);
            playerControlSteps.Pause();
            Assert.That(playerControlSteps.IsPaused);
        }

        [Test]
        public void PauseOnApi()
        {
            _api.Pause();
        }
    }
}