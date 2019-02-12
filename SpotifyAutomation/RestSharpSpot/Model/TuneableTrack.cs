namespace RestSharpSpot.Api.Objects
{
    public class TuneableTrack
    {
        public float Acousticness { get; set; }
        public float Danceability { get; set; }
        public int DurationMs { get; set; }
        public float Energy { get; set; }
        public float Instumentalness { get; set; }
        public int Key { get; set; }
        public float Liveness { get; set; }
        public float Loudness { get; set; }
        public int Mode { get; set; }
        public float Popularity { get; set; }
        public float Speechiness { get; set; }
        public float Tempo { get; set; }
        public int TimeSignature { get; set; }
        public float Valence { get; set; }
    }
}