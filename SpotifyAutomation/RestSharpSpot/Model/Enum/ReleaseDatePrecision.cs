using System;

namespace RestSharpSpot.Model.Enum
{
    [Flags]
    public enum ReleaseDatePrecision
    {
        day = 1,

        month = 2,

        year = 4,
    }
}