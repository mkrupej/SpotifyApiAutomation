namespace RestSharpSpot.Api.Objects
{
    public class PlaylistTrack
    {
        public string AddedAt { get; set; }
        public PublicUser AddedBy { get; set; }
        public bool Islocal { get; set; }
        public Track Track { get; set; }
    }
}