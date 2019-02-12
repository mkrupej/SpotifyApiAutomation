using RestSharpSpot.Api.Model;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class SimplifiedTrack
    {
        public SimplifiedAlbum Album { get; set; }
        public List<SimplifiedArtist> Artists { get; set; }
        public List<string> AvailableMarkets { get; set; }
        public int DiscNumber { get; set; }
        public int DurationMs { get; set; }
        public bool Explicit { get; set; }
        public ExternalUrlObject ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public bool IsPlayable { get; set; }
        public LinkedTrack LinkedFrom { get; set; }
        public string Name { get; set; }
        public string PreviewUrl { get; set; }
        public int TrackNumber { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}