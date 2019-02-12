namespace RestSharpSpot.Api.Objects
{
    public class PlayHistory
    {
        public SimplifiedTrack Track { get; set; }
        public string PlayedAt { get; set; }
        public Context Context { get; set; }
    }
}