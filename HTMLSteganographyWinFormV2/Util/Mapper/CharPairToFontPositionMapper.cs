using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLSteganographyWinFormV2.Util.Mapper
{
    class CharPairToFontPositionMapper
    {
        public static Dictionary<string, int> mapper = new Dictionary<string, int>
            {
                { "00", 0 },
                { "10", 1 },
                { "01", -1 },
                { "11", 2 },
            };
    }
}
