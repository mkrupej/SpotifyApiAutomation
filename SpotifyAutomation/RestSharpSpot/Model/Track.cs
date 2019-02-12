using RestSharpSpot.Api.Model;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class Track : SimplifiedTrack
    {
        new public List<Artist> Artists { get; set; }
        public ExternalId ExternalIDs { get; set; }
        public int Popularity { get; set; }
        public List<Restrictions> Restrictions { get; set; } //List<TrackRestriction>
    }

    public class TracksObject
    {
        public List<Track> Tracks { get; set; }
    }
}