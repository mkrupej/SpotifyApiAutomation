﻿using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class AudioFeature
    {
        public float Acousticness { get; set; }
        public string AnalysisUrl { get; set; }
        public float Danceability { get; set; }
        public int DurationMs { get; set; }
        public float Energy { get; set; }
        public string Id { get; set; }
        public float Instrumentalness { get; set; }
        public int Key { get; set; }
        public float Liveness { get; set; }
        public float Loudness { get; set; }
        public int Mode { get; set; }
        public float Speechiness { get; set; }
        public float Tempo { get; set; }
        public int TimeSignature { get; set; }
        public string TrackHref { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
        public float Valence { get; set; } //0.0 sad 1.0 happy
    }

    public class AudioFeaturesObject
    {
        public List<AudioFeature> AudioFeatures { get; set; }
    }
}