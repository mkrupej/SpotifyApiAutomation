using RestSharpSpot.Api.Objects;

namespace RestSharpSpot.Api.Model
{
    public class LinkedTrack
    {
        public ExternalUrlObject ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}