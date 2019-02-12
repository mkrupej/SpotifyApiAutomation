using RestSharp;
using RestSharpSpot.Api.Extensions;
using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using RestSharpSpot.SpotifyApi.Model;
using System;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class PlaylistsApi : BaseApi
    {
        public PlaylistsApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public IRestResponse<Object> RemoveTrackFromPlaylist(string playlistId, string tracks)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("playlist_id", playlistId);
            var queryParameters = new Dictionary<string, string>()
                {
                    { "tracks", tracks },
                };
            return Rest.SendRequestAndGetResponse<Object>("v1/playlists/{playlist_id}/tracks", queryParameters, urlSegmentParameter, Method.DELETE);
        }

        public Paging<Playlist> GetAListOfCurrentUserPlaylists(int limit = 20, int offset = 0)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() }
            };

            return Rest.SendRequestAndGetData<Paging<Playlist>>("v1/me/playlists", queryParameters);
        }

        public Paging<PlaylistTrack> GetPlaylistTracks(string playlistId, string market = "PL", int limit = 20, int offset = 0)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("playlist_id", playlistId);
            var queryParameters = new Dictionary<string, string>()
            {
                { "market", market },
                { "limit", limit.ToString() },
                { "offset", offset.ToString() }
            };

            return Rest.SendRequestAndGetData<Paging<PlaylistTrack>>("v1/playlists/{playlist_id}/tracks", queryParameters, urlSegmentParameter);
        }

        public Playlist GetPlaylist(string playlistId, string market = "PL")
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("playlist_id", playlistId);
            var queryParameters = new Dictionary<string, string>()
            {
                { "market", market },
            };
            return Rest.SendRequestAndGetData<Playlist>("v1/playlists/{playlist_id}", queryParameters, urlSegmentParameter);
        }

        public Paging<Playlist> GetListOfUserPlaylists(string userId, int limit = 20, int offset = 0)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("user_id", userId);
            var queryParameters = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() }
            };

            return Rest.SendRequestAndGetData<Paging<Playlist>>("v1/users/{user_id}/playlists", queryParameters, urlSegmentParameter);
        }

        public PlaylistSnapshot AddTrackToPlaylist(string playlistId, string uris, int position = 0)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("playlist_id", playlistId);
            var queryParameters = new Dictionary<string, string>()
            {
                { "uris", uris },
                { "position	", position.ToString() },
            };

            return Rest.SendRequestAndGetData<PlaylistSnapshot>("v1/playlists/{playlist_id}/tracks", queryParameters, urlSegmentParameter, Method.POST);
        }

        public Playlist CreatePlaylist(string userId, string name, bool _public = false, bool collaborative = false, string description = "")
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("user_id", userId);
            var queryParameters = new Dictionary<string, string>()
                {
                    { "name", name },
                    { "public", _public.ToString() },
                    { "collaborative", collaborative.ToString() },
                    { "description", description }
                };
            return Rest.SendRequestAndGetData<Playlist>("v1/users/{user_id}/playlists", queryParameters, urlSegmentParameter, Method.POST);
        }

        public bool ReorderPlaylistsTrack(string playlistId, int rangeStart, int rangeLength, int insertBefore, string snapshotId = "")
        {
            Rest.CreateRestRequest("v1/playlists/{playlist_id}/tracks", Method.PUT);
            Rest.RestRequest.AddUrlSegment("playlist_id", playlistId);
            var bodyParameters = new Dictionary<string, string>()
            {
                { "range_start", rangeStart.ToString() },
                { "range_length", rangeLength.ToString() },
                { "insert_before", insertBefore.ToString() },
                { "snapshot_id", snapshotId }
            };
            Rest.RestRequest.AddParameters(bodyParameters);

            return Rest.Execute<bool>();
        }

        public bool ChangePlaylistDetails(string playlistId, string name = "", bool _public = false, bool collaborative = false, string description = "")
        {
            Rest.CreateRestRequest("v1/playlists/{playlist_id}", Method.PUT);
            Rest.RestRequest.AddUrlSegment("playlist_id", playlistId);
            var bodyParameters = new Dictionary<string, string>()
            {
                { "name", name },
                { "public", _public.ToString() },
                { "collaborative", collaborative.ToString() },
                { "description", description }
            };
            Rest.RestRequest.AddParameters(bodyParameters);

            return Rest.Execute<bool>();
        }

        public List<Image> GetPlaylistCoverImage(string playlistId)
        {
            Rest.CreateRestRequest("v1/playlists/{playlist_id}/images");
            Rest.RestRequest.AddUrlSegment("playlist_id", playlistId);
            return Rest.Execute<List<Image>>();
        }
    }
}