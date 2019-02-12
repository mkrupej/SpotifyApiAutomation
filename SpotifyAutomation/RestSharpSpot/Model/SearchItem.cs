using RestSharpSpot.Api.Objects;

namespace RestSharpSpot.Api.Model
{
    public class SearchItem
    {
        public Paging<Artist> Artists { get; set; }

        public Paging<Album> Albums { get; set; }

        public Paging<Track> Tracks { get; set; }

        public Paging<Playlist> Playlists { get; set; }
    }
}