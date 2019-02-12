using System;

namespace RestSharpSpot.Api.Model.Enum
{
    [Flags]
    public enum SearchType
    {
        album = 1,
        artist = 2,
        playlist = 4,
        track = 8
    }
}