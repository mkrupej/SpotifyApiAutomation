namespace RestSharpSpot.Api.Objects
{
    public class Context
    {
        public string Type { get; set; }
        public string Href { get; set; }
        public ExternalUrlObject ExternalUrls { get; set; }
        public string Uri { get; set; }
    }
}