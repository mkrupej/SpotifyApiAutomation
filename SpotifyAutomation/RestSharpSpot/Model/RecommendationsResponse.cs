using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class RecommendationsResponse
    {
        public List<RecommendationSeed> Seeds { get; set; }
        public List<SimplifiedTrack> Tracks { get; set; }
    }
}