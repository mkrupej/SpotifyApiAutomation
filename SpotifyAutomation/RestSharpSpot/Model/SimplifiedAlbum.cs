using RestSharpSpot.Model.Enum;
using RestSharpSpot.SpotifyApi.Model.Enum;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class SimplifiedAlbum
    {
        public AlbumGroup AlbumGroup { get; set; }
        public AlbumType AlbumType { get; set; }
        public List<SimplifiedArtist> Artists { get; set; }
        public List<string> AvailableMarkets { get; set; }
        public ExternalUrlObject ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public ReleaseDatePrecision ReleaseDatePrecision { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}