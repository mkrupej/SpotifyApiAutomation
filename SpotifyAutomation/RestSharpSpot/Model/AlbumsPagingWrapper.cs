using RestSharpSpot.Api.Objects;

namespace RestSharpSpot.SpotifyApi.Model
{
    public class AlbumsPagingWrapper
    {
        public Paging<SimplifiedAlbum> Albums { get; set; }
    }
}