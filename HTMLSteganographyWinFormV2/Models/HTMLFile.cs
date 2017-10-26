using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLSteganographyWinFormV2.Models
{
    class HTMLFile
    {
        public StringBuilder File { get; set; }

        public decimal GetContainerCapacity(int bitsPerSymbol)
        {
            int containerCapacity = 0;

            try
            {
                for (int i = 0; i < File.Length; i++)
                {
                    if (File[i] == '\'' || File[i] == '\"')
                    {
                        containerCapacity++;

                        if (File[i] == '\'')
                        {
                            while (File[++i] != '\'') ;
                        }
                        else if (File[i] == '\"')
                        {
                            while (File[++i] != '\"') ;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return containerCapacity;
            }


            return Math.Floor((decimal)containerCapacity / bitsPerSymbol);
        }
    }
}
