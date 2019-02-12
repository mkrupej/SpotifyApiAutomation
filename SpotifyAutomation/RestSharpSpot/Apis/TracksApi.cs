using RestSharpSpot.Api.Model.AudioAnalysis;
using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services
{
    public class TracksApi : BaseApi
    {
        public TracksApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public AudioAnalysis GetAudioAnalysisForTrack(string id)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            return Rest.SendRequestAndGetData<AudioAnalysis>("v1/audio-analysis/{id}", urlSegmentParameter);
        }

        public AudioFeature GetAudioFeatureForTrack(string id)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            return Rest.SendRequestAndGetData<AudioFeature>("v1/audio-features/{id}", urlSegmentParameter);
        }

        public AudioFeaturesObject GetAudioFeaturesForSeveralTracks(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
                {
                    { "ids", ids },
                };
            return Rest.SendRequestAndGetData<AudioFeaturesObject>("v1/audio-features/", queryParameters);
        }

        public TracksObject GetSeveralTracks(string ids)
        {
            var queryParameters = new Dictionary<string, string>()
                {
                    { "ids", ids },
                };
            return Rest.SendRequestAndGetData<TracksObject>("v1/tracks/", queryParameters);
        }

        public Track GetTrack(string id)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("id", id);
            return Rest.SendRequestAndGetData<Track>("v1/tracks/{id}", urlSegmentParameter);
        }
    }
}