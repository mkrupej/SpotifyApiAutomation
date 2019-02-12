namespace RestSharpSpot.Api.Objects
{
    public class CurrentlyPlaying
    {
        public Context Context { get; set; }
        public string TimeStamp { get; set; }
        public int ProgressMs { get; set; }
        public bool IsPlaying { get; set; }
        public Track Item { get; set; }
        public string CurrentlyPlayingType { get; set; }
    }
}