using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLSteganographyWinFormV2
{
    class IntToStringOneSymbolBitsMapper
    {
        public static Dictionary<int, string> map =
                           new Dictionary<int, string>() {

             { 8, "00000000" },
             { 11, "00000000000" }
    };
    }
}
