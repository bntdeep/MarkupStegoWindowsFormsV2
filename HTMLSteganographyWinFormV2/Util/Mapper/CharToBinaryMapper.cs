using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLSteganographyWinFormV2.Util.Mapper
{
    class CharToBinaryMapper
    {
        public static Dictionary<char, string> mapper = new Dictionary<char, string>
            {
                { 'a', "000001" },
                { 'b', "000010" },
                { 'c', "000011" },
                { 'd', "000100" },
                { 'e', "000101" },
                { 'f', "000110" },
                { 'g', "000111" },
                { 'h', "001000" },
                { 'i', "001001" },
                { 'j', "001010" },
                { 'k', "001011" },
                { 'l', "001100" },
                { 'm', "001101" },
                { 'n', "001110" },
                { 'o', "001111" },
                { 'p', "010000" },
                { 'q', "010001" },
                { 'r', "010010" },
                { 's', "010011" },
                { 't', "010100" },
                { 'u', "010101" },
                { 'v', "010110" },
                { 'w', "010111" },
                { 'x', "011000" },
                { 'y', "011001" },
                { 'z', "011010" },

                { ' ', "011011" },
                { '.', "011100" },
                { ',', "011101" },
            };
    }
}
