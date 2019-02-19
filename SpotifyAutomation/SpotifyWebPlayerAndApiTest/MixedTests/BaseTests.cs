using NUnit.Framework;
using RestSharpSpot.Api.Services;
using RestSharpSpot.API;
using RestSharpSpot.Management;
using SpotifyWebAppAutomation;
using SpotifyWebAppAutomation.Pages;
using SpotifyWebAppAutomation.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyTest.MixedTests
{
    [TestFixture]
    public class BaseTests
    {
        public static LoginSteps _loginPageSteps { get; set; }
        public PlayerApi _api { get; set; }

        [SetUp]
        public void Init()
        {
            Driver.Initialize();
            _loginPageSteps = new SpotifyWebAppAutomation.Steps.LoginSteps();
            _loginPageSteps.LoginAsUser("mkrupej");

            var apiAccessData = ApiManager.GetApiAccessData();
            _api = new PlayerApi(apiAccessData.Item1, apiAccessData.Item2, apiAccessData.Item3, apiAccessData.Item4);
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}