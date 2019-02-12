using RestSharpSpot.Api.Model.Enum;
using RestSharpSpot.Api.Services;
using RestSharpSpot.Miscellaneous;
using System;

namespace RestSharpSpot
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string key = (new KeyManager()).Key;
            const string client_id = "5188c6210ac540a5ab12812e26060f32";
            const string response_type = "code";
            const string redirect_uri = "http://spotify.com";
            /**
            track ids "029l68p4fPYZeAgJ5c60zR" "49X0LAl6faAusYq02PRAY6"

            SpotifyPlayerApi sp = new SpotifyPlayerApi(client_id, key, response_type, redirect_uri);

            var e = sp.SetRepeatMode(Api.Model.Enum.RepeatModeState.track);
            var f = sp.SkipToPreviousTrack();

            PersonalizationApi sp = new PersonalizationApi(client_id, key, response_type, redirect_uri);
            var a = sp.GetUserTopArtists();
            var b = sp.GetUserTopTracks();

            var b = sp2.AddTrackToPlaylist("66q5xfePGHk0xf1e4HdZ3F", "spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M");
            var c = sp2.RemoveTrackFromPlaylist("66q5xfePGHk0xf1e4HdZ3F", "[{ "uri": "spotify: track:4iV5W9uYEdYUVa79Axb7Rh" },{ "uri": "spotify: track: 1301WleyT98MSxVHPZCA6M" }]");
            var a = sp2.CreatePLaylist("mkrupej", "\"testowa\"", description: "\"opis\"");
            var b = sp2.Play("potify:album:5ht7ItJgpBH7W6vJ5BqpPr");

            var b = sp2.SeekToPostion(12000);

            var g = sp2.SetVolume(20);
            var k = sp2.ShuffleUserPlayback();

            sp2.GetTracks("11dFghVXANMlKmJXsNCbNl");
            sp2.GetTracks("11dFghVXANMlKmJXsNCbNl");
            sp2.GetSeveralTracks("11dFghVXANMlKmJXsNCbNl,49X0LAl6faAusYq02PRAY6");
                        sp2.ChangePlaylistDetails("66q5xfePGHk0xf1e4HdZ3F", "\"zmiananazwy\"");

            var a = sp2.GetSeveralTracks("11dFghVXANMlKmJXsNCbNl,3n3Ppam7vgaVa1iaRUc9Lp"); **/
            //var a = sp2.DeleteTrackForCurrentUser("7ouMYWpwJ422jRcDASZB7P,4VqPOruhp5EdPBeR92t6lQ,2takcwOaAZWiXQijPHIx7B");

            var sp2 = new SearchApi(client_id, key, response_type, redirect_uri);
            var s = sp2.Search("U2", searchType: SearchType.album | SearchType.artist);
        }
    }
}