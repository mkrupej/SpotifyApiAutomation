using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class Album : SimplifiedAlbum
    {
        new public List<Artist> Artists { get; set; }
        public List<Copyright> Copyrights { get; set; }
        public ExternalId ExternalIds { get; set; }
        public List<string> Genres { get; set; }
        public string Label { get; set; }
        public int Popularity { get; set; }
        public List<Paging<SimplifiedTrack>> Tracks { get; set; }
    }

    public class AlbumsObject
    {
        public List<Album> Albums { get; set; }
    }
}