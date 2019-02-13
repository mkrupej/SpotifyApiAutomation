using System;

namespace RestSharpSpot.Model.Enum
{
    [Flags]
    public enum AlbumType
    {
        album = 1,

        single = 2,

        compilation = 4
    }
}