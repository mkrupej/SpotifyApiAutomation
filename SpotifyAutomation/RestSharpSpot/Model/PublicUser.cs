using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class PublicUser
    {
        public string DisplayName { get; set; }
        public ExternalUrlObject ExternalUrls { get; set; }
        public Followers Followers { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}