using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
