using RestSharpSpot.Api.Model.Enum;
using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class PersonalizationApi : BaseApi
    {
        public PersonalizationApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public Paging<Track> GetUserTopTracks(int limit = 20, int offset = 0, TimeRange timeRange = TimeRange.medium_term)
        {
            return GetUserTop<Track>("tracks", limit, offset, timeRange);
        }

        public Paging<Artist> GetUserTopArtists(int limit = 20, int offset = 0, TimeRange timeRange = TimeRange.medium_term)
        {
            return GetUserTop<Artist>("artists", limit, offset, timeRange);
        }

        private Paging<T> GetUserTop<T>(string type, int limit = 20, int offset = 0, TimeRange timeRange = TimeRange.medium_term)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("type", type);
            var queryParameters = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() },
                { "time_range", timeRange.ToString() }
            };
            return Rest.SendRequestAndGetData<Paging<T>>("/v1/me/top/{type}", queryParameters, urlSegmentParameter);
        }
    }
}