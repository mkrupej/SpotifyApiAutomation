using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class Artist : SimplifiedArtist
    {
        public Followers Followers { get; set; }
        public List<string> Genres { get; set; }
        public List<Image> Images { get; set; }
        public int Popularity { get; set; }
    }

    public class ArtistsObject
    {
        public List<Artist> Artists { get; set; }
    }
}