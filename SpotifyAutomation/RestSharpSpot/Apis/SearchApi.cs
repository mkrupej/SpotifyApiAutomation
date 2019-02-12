using RestSharpSpot.Api.Model;
using RestSharpSpot.Api.Model.Enum;
using RestSharpSpot.API;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class SearchApi : BaseApi
    {
        public SearchApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public SearchItem Search(string q, SearchType searchType = SearchType.artist, string market = "US", int limit = 20, int offset = 0)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "q" , q},
                { "type" , searchType.ToString().Replace(" ", string.Empty)},
                { "market" , market },
                { "limit", limit.ToString()},
                { "offset", offset.ToString() }
            };
            return Rest.SendRequestAndGetData<SearchItem>("/v1/search", queryParameters);
        }
    }
}