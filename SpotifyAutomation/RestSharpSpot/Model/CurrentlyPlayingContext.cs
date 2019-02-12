using RestSharpSpot.Api.Objects;

namespace RestSharpSpot.Api.Model
{
    public class CurrentlyPlayingContext
    {
        public Device Device { get; set; }
        public string RepeatState { get; set; }
        public bool ShuffleState { get; set; }
        public Context Context { get; set; }
        public string TimeStamp { get; set; }
        public int ProgressMs { get; set; }
        public bool IsPlaying { get; set; }
        public Track Item { get; set; }
        public string CurrentlyPlayingType { get; set; }
    }
}