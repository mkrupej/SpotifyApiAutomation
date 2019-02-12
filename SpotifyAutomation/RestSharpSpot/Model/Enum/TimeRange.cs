using System;

namespace RestSharpSpot.Api.Model.Enum
{
    [Flags]
    public enum TimeRange
    {
        long_term = 1, // several years
        medium_term = 2, // 6 months
        short_term = 4 //4 weeks
    }
}