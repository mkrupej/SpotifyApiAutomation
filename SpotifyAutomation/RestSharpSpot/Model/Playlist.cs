using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class Playlist
    {
        public bool Collaborative { get; set; }
        public ExternalUrlObject ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public PublicUser Owner { get; set; }
        public bool Public { get; set; }
        public string SnapshotId { get; set; }
        public List<Paging<PlaylistTrack>> Tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}