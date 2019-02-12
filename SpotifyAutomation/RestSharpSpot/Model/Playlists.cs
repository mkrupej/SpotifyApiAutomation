using RestSharpSpot.Api.Objects;

namespace RestSharpSpot.SpotifyApi.Model
{
    public class PlaylistsObject
    {
        public Paging<PlaylistTrack> Playlists { get; set; }

        public string Message { get; set; }
    }
}