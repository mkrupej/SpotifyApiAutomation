using RestSharpSpot.Miscellaneous;
using System;

namespace RestSharpSpot.Management
{
    public static class ApiManager
    {
        private const string CLIENT_ID = "5188c6210ac540a5ab12812e26060f32";
        private static string KEY = (new KeyManager()).Key;
        private const string RESPONSE_TYPE = "code";
        private const string REDIRECT_URI = "http://spotify.com";

        public static Tuple<string, string, string, string> GetApiAccessData()
        {
            return new Tuple<string, string, string, string>(CLIENT_ID, KEY, RESPONSE_TYPE, REDIRECT_URI);
        }
    }
}