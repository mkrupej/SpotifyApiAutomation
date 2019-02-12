using System;

namespace RestSharpSpot.Api.Model.Enum
{
    [Flags]
    public enum RepeatModeState
    {
        track = 1,
        context = 2,
        off = 4
    }
}