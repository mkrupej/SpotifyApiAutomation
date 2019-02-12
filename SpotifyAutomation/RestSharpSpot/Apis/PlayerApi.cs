using RestSharp;
using RestSharpSpot.Api.Model;
using RestSharpSpot.Api.Model.Enum;
using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using System;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class PlayerApi : BaseApi
    {
        public PlayerApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public DevicesObject GetUserDevices()
        {
            return Rest.SendRequestAndGetData<DevicesObject>("v1/me/player/devices");
        }

        public CurrentlyPlayingContext GetCurrentPlayback()
        {
            return Rest.SendRequestAndGetData<CurrentlyPlayingContext>("v1/me/player");
        }

        public CursorPaging<PlayHistory> GetRecentlyPlayed(int limit = 20, string after = "0")
        {
            var queryParametersDictionary = new Dictionary<string, string>()
            {
                { "limit", limit.ToString() },
                { "after", after },
            };
            return Rest.SendRequestAndGetData<CursorPaging<PlayHistory>>("v1/me/player/recently-played", queryParametersDictionary);
        }

        public CurrentlyPlaying GetCurrentlyPlayingTrack()
        {
            return Rest.SendRequestAndGetData<CurrentlyPlaying>("v1/me/player/currently-playing");
        }

        public IRestResponse<Object> Pause()
        {
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/pause");
        }

        public IRestResponse<Object> SeekToPostion(int positionMs = 0)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "position_ms", positionMs.ToString() }
            };
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/seek", queryParameters);
        }

        public IRestResponse<Object> SetRepeatMode(RepeatModeState repeatStateMode = RepeatModeState.track)
        {
            var queryParameters = new KeyValuePair<string, string>("state", repeatStateMode.ToString());
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/repeat", queryParameters);
        }

        public IRestResponse<Object> SetVolume(int volumePercent = 0)
        {
            var queryParameters = new KeyValuePair<string, string>("volume_percent", volumePercent.ToString());
            return Rest.SendRequestAndGetResponse<Object>("/v1/me/player/volume", queryParameters);
        }

        public IRestResponse<Object> SkipToNextTrack()
        {
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/next", Method.POST);
        }

        public IRestResponse<Object> SkipToPreviousTrack()
        {
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/previous", Method.POST);
        }

        public IRestResponse<Object> Play(string contextUri = "", int offset = 0, int positionMs = 0)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "context_uri", contextUri },
                { "offset", offset.ToString() },
                { "position_ms", positionMs.ToString() }
            };
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/play", queryParameters);
        }

        public IRestResponse<Object> ShuffleUserPlayback(bool state = true)
        {
            var queryParameter = new KeyValuePair<string, string>("state", state.ToString());
            return Rest.SendRequestAndGetResponse<Object>("v1/me/player/shuffle", queryParameter);
        }
    }
}