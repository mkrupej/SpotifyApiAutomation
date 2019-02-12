using SpotifyWebAppAutomation.Pages;
using System;
using SpotifyWebAppAutomation.Models;
using SpotifyWebAppAutomation.Steps;
using OpenQA.Selenium;

namespace SpotifyWebAppAutomation
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Driver.Initialize();
            var loginPage = new LoginSteps();
            loginPage.LoginAsUser("mkrupej");

            System.Threading.Thread.Sleep(5000);

            //var playerbar = new PlayerBarPage();
            //playerbar.NextSong();
            //playerbar.Mute();
            //playerbar.Unmute();
            //Console.WriteLine($"Is muted? {playerbar.IsMuted()}");
            //playerbar.Unmute();
            ////Console.WriteLine($"Is muted? {playerbar.IsMuted()}");
            //var homePage = new HomePage();
            //homePage
            //    .LeftPanel
            //    .GoToRecentlyPlayedItem(Ordinal.first);
            //homePage
            //    .LeftPanel
            //    .GoToRecentlyPlayedItem(Ordinal.second);
            //homePage
            //    .LeftPanel
            //    .GoToRecentlyPlayedItem(Ordinal.third);
            //homePage
            //    .LeftPanel
            //    .GoToRecentlyPlayedItem(Ordinal.fourth);
            //homePage
            //    .LeftPanel
            //    .GoToRecentlyPlayedItem(Ordinal.fifth);

            var playerControlSteps = new PlayerControlSteps(loginPage.Pages);

            playerControlSteps.Pause();
            playerControlSteps.Play();

            playerControlSteps.SetSongProgress(40);
            //var homePage = new HomePage(loginPage)
            Console.WriteLine("passed");
            Console.ReadKey();
        }
    }
}