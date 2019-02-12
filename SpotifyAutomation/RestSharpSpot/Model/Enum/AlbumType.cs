using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
