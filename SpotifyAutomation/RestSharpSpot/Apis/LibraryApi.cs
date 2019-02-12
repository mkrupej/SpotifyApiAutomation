using RestSharp;
using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using System;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class LibraryApi : BaseApi
    {
        public LibraryApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public Paging<SavedTrack> GetUserSavedTracks(int limit = 20, int offset = 0, string market = "PL")
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() },
                { "market", market }
            };

            return Rest.SendRequestAndGetData<Paging<SavedTrack>>("v1/me/tracks", queryParameters);
        }

        public Paging<SavedAlbum> GetUserSavedAlbums(int limit = 20, int offset = 0, string market = "PL")
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() },
                { "market", market }
            };

            return Rest.SendRequestAndGetData<Paging<SavedAlbum>>("v1/me/tracks", queryParameters);
        }

        public List<bool> CheckUserSavedAlbums(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };

            return Rest.SendRequestAndGetData<List<bool>>("v1/artists/{id}/albums", queryParameters);
        }

        public List<bool> CheckUserSavedTracks(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };

            return Rest.SendRequestAndGetData<List<bool>>("v1/me/tracks/contains", queryParameters);
        }

        public IRestResponse<bool> SaveAlbumForCurrentUser(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };
            return Rest.SendRequestAndGetResponse<bool>("v1/me/albums", queryParameters);
        }

        public IRestResponse<bool> DeleteAlbumForCurrentUser(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };
            return Rest.SendRequestAndGetResponse<bool>("v1/me/albums", queryParameters, Method.DELETE);
        }

        public IRestResponse<bool> SaveTrackForCurrentUser(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };
            return Rest.SendRequestAndGetResponse<bool>("v1/me/tracks", queryParameters, Method.DELETE);
        }

        public IRestResponse<bool> DeleteTrackForCurrentUser(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "ids", ids },
            };
            return Rest.SendRequestAndGetResponse<bool>("v1/me/tracks", queryParameters, Method.DELETE);
        }
    }
}