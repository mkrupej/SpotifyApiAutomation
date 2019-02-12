using System;

namespace RestSharpSpot.SpotifyApi.Model.Enum
{
    [Flags]
    public enum AlbumGroup
    {
        album = 1,

        single = 2,

        appears_on = 4,

        compilation = 8
    }
}