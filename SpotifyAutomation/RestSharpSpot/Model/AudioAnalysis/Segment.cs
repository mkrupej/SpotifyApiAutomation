using System.Collections.Generic;

namespace RestSharpSpot.Api.Model.AudioAnalysis
{
    public class Segment
    {
        public float Start { get; set; }
        public float Duration { get; set; }
        public float Confidence { get; set; }
        public float LoudnessStart { get; set; }
        public float LoudnessMax { get; set; }
        public float LoudnessMaxtime { get; set; }
        public float LoudnessEnd { get; set; }
        public List<float> Pitches { get; set; }
        public List<float> Timbre { get; set; }
    }
}