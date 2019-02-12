using RestSharpSpot.Api.Model;
using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using RestSharpSpot.SpotifyApi.Model;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class BrowseApi : BaseApi
    {
        public BrowseApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public CategoriesObject GetListOfCategories(string country = "SE", string locale = "sv-SE", int limit = 20, int offset = 0)
        {
            var queryParameters = new Dictionary<string, string>()
                {
                    { "country", country },
                    { "locale", locale },
                    { "limit", limit.ToString() },
                    { "offset", offset.ToString() }
                };

            return Rest.SendRequestAndGetData<CategoriesObject>("v1/browse/categories", queryParameters);
        }

        public Category GetSingleCategory(string categoryId, string country = "PL", string locale = "pl_PL")
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("category_id", categoryId);
            var queryParameters = new Dictionary<string, string>()
                {
                    { "country", country },
                    { "locale", locale },
                };

            return Rest.SendRequestAndGetData<Category>("v1/browse/categories/{category_id}", queryParameters, urlSegmentParameter);
        }

        public PlaylistsObject GetFeaturedPlaylists()
        {
            return Rest.SendRequestAndGetData<PlaylistsObject>("v1/browse/featured-playlists");
        }

        public AlbumsPagingWrapper GetListOfNewReleases(int limit = 20, int offset = 0)
        {
            var queryParameters = new Dictionary<string, string>()
                {
                    { "limit", limit.ToString() },
                    { "offset", offset.ToString() }
                };

            return Rest.SendRequestAndGetData<AlbumsPagingWrapper>("v1/browse/new-releases", queryParameters);
        }

        //TBD
        public PlaylistsObject GetCategoryPlaylists(string categoryId, string country = "PL", int limit = 20, int offset = 0)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("category_id", categoryId);
            var queryParameters = new Dictionary<string, string>()
                {
                    { "country", country },
                    { "limit", limit.ToString() },
                    { "offset", offset.ToString() }
                };

            return Rest.SendRequestAndGetData<PlaylistsObject>("v1/browse/categories/{category_id}/playlists", queryParameters, urlSegmentParameter);
        }

        public GenresObject GetAvailableGenreSeeds()
        {
            return Rest.SendRequestAndGetData<GenresObject>("v1/recommendations/available-genre-seeds");
        }

        public RecommendationsResponse GetRecommendationsBasedOnSeeds(int limit = 20, string market = "PL", string seedArtist = "4NHQUGzhtTLFvgF5SZesLK", string seedGenres = "classical,country", string seedTracks = "0c6xIDDpzE81m2q797ordA")
        {
            var queryParameters = new Dictionary<string, string>()
                {
                    { "limit", limit.ToString() },
                    { "market", market },
                    { "seed_artist", seedArtist },
                    { "seed_genres", seedGenres },
                    { "seed_tracks", seedTracks }
                };

            return Rest.SendRequestAndGetData<RecommendationsResponse>("v1/recommendations");
        }
    }
}