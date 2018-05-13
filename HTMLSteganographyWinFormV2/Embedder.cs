using HTMLSteganographyWinFormV2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLSteganographyWinFormV2
{
    class Embedder
    {
        public static void EmbedMessage(XMLFile xml, string embedingMessage, int bitsOfOneCharacter)
        {
            string message = MakeBinaryString(embedingMessage, bitsOfOneCharacter);

            int embedCounter = 0;

            message += IntToStringOneSymbolBitsMapper.map[bitsOfOneCharacter];

            for (int i = 0; i < xml.File.Length-1 && embedCounter < message.Length; i++)
            {
                if(xml.File[i] == '\'')
                {
                    if(message[embedCounter] == '0')
                    {
                        while (xml.File[++i] != '\'');
                        embedCounter++;
                    }
                    else if (message[embedCounter] == '1')
                    {
                        xml.File[i] = '\"';

                        while (xml.File[++i] != '\'')
                        {
                            if (xml.File[i] == '\"')
                            {
                                xml.File[i] = '\'';
                            }
                        }

                        xml.File[i] = '\"';

                        embedCounter++;
                    }
                }
                else  if (xml.File[i] == '\"')
                {
                    if (message[embedCounter] == '1')
                    {
                        while (xml.File[++i] != '\"') ;
                        embedCounter++;
                    }
                    else if (message[embedCounter] == '0')
                    {
                        xml.File[i] = '\'';
                        while (xml.File[++i] != '\"')
                        {
                            if(xml.File[i] == '\'')
                            {
                                xml.File[i] = '\"';
                            }                    
                        }

                        xml.File[i] = '\'';

                        embedCounter++;
                    }
                }
            }
        }

        private static string MakeBinaryString(string charString, int bitsOfOneCharacter)
        {
            StringBuilder binaryString = new StringBuilder();

            foreach (char item in charString)
            {
                int symbolCode = (int)item;
                string binarySymbolCode = Convert.ToString(symbolCode, 2);

                if (binarySymbolCode.Length != bitsOfOneCharacter)
                {
                    int addedBits = bitsOfOneCharacter - binarySymbolCode.Length;
                    for (int i = 0; i < addedBits; i++)
                    {
                        binarySymbolCode = "0" + binarySymbolCode;//выравнивание длины строки до 8 бит
                    }
                }
                binaryString.Append(binarySymbolCode);
            }
            return binaryString.ToString();
        }

        public static void AddStegoContainerToArchive(string archive, string containerName, string containerContent)
        {
            if (System.IO.File.Exists(archive))
            {
                System.IO.Compression.ZipArchive apcZipFile = System.IO.Compression.ZipFile.Open(archive, System.IO.Compression.ZipArchiveMode.Update);

                ZipArchiveEntry entry = apcZipFile.CreateEntry(containerName);

                StreamWriter writer = new StreamWriter(entry.Open());
                writer.WriteLine(containerContent);
                writer.Flush();

                apcZipFile.Dispose();
            }
        }
    }
}
