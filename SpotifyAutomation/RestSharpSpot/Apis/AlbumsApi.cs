using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class AlbumsApi : BaseApi
    {
        public AlbumsApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public Album GetAlbum(string id, string market = "PL")
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            var queryParameter = new KeyValuePair<string, string>("market", market);
            return Rest.SendRequestAndGetData<Album>("/v1/albums/{id}", queryParameter, urlSegmentParameter);
        }

        public AlbumsObject GetSeveralAlbums(string ids, string market = "PL")
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
                { "market", market }
            };
            return Rest.SendRequestAndGetData<AlbumsObject>("/v1/albums", queryParameters);
        }

        public Paging<Track> GetAlbumsTracks(string id, int limit = 20, int offset = 0, string market = "PL")
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            var queryParameters = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString()},
                { "market", market }
            };
            return Rest.SendRequestAndGetData<Paging<Track>>("v1/albums/{id}/tracks", queryParameters, urlSegmentParameter);
        }
    }
}