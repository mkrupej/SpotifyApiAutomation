using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using RestSharpSpot.SpotifyApi.Model.Enum;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class ArtistsApi : BaseApi
    {
        public ArtistsApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public Artist GetArtist(string id)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            return Rest.SendRequestAndGetData<Artist>("/v1/artists/{id}", urlSegmentParameter);
        }

        public Paging<SimplifiedAlbum> GetArtistAlbums(string id, AlbumGroup includeGroups = AlbumGroup.single, string market = "PL", int limit = 20, int offset = 0)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "include_groups", includeGroups.ToString().Replace(" ", string.Empty) },
                { "market", market },
                { "limit", limit.ToString() },
                { "offset", offset.ToString() },
            };
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);

            return Rest.SendRequestAndGetData<Paging<SimplifiedAlbum>>("/v1/artists/{id}/albums", queryParameters, urlSegmentParameter);
        }

        public TracksObject GetArtistTopTracks(string id, string market = "PL")
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            var queryParameters = new Dictionary<string, string>()
            {
                { "market", market },
            };

            return Rest.SendRequestAndGetData<TracksObject>("/v1/artists/{id}/top-tracks", queryParameters, urlSegmentParameter);
        }

        public ArtistsObject GetSeveralArtists(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };
            return Rest.SendRequestAndGetData<ArtistsObject>("v1/artists", queryParameters);
        }

        public ArtistsObject GetRelatedArtists(string id)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            return Rest.SendRequestAndGetData<ArtistsObject>("v1/artists/{id}/related-artists", urlSegmentParameter);
        }
    }
}