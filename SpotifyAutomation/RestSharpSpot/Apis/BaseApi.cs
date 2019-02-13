namespace RestSharpSpot.API
{
    public class BaseApi
    {
        public string Client_id { get; }
        public string Response_type { get; }
        public string Redirect_uri { get; }
        public string Key { get; }
        public Rest Rest { get; }
        public string BaseUrl { get; set; } = "https://api.spotify.com";

        public BaseApi(string clientID, string key, string responseType, string redirectUri)
        {
            Client_id = clientID;
            Key = key;
            Response_type = responseType;
            Redirect_uri = redirectUri;
            Rest = new Rest(BaseUrl, Key);
        }
    }
}