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
        public static void EmbedMessage(HTMLFile html, string embedingMessage, int bitsOfOneCharacter)
        {
            embedingMessage = embedingMessage + "!@#"; // конец сообщения
            string message = MakeBinaryString(embedingMessage, bitsOfOneCharacter);

            int embedCounter = 0;

            for (int i = 0; i < html.File.Length-1 && embedCounter < message.Length; i++)
            {
                if(html.File[i] == '\'')
                {
                    if(message[embedCounter] == '0')
                    {
                        while (html.File[++i] != '\'');
                        embedCounter++;
                    }
                    else if (message[embedCounter] == '1')
                    {
                        html.File[i] = '\"';

                        while (html.File[++i] != '\'')
                        {
                            if (html.File[i] == '\"')
                            {
                                html.File[i] = '\'';
                            }
                        }

                        html.File[i] = '\"';

                        embedCounter++;
                    }
                }
                else  if (html.File[i] == '\"')
                {
                    if (message[embedCounter] == '1')
                    {
                        while (html.File[++i] != '\"') ;
                        embedCounter++;
                    }
                    else if (message[embedCounter] == '0')
                    {
                        html.File[i] = '\'';
                        while (html.File[++i] != '\"')
                        {
                            if(html.File[i] == '\'')
                            {
                                html.File[i] = '\"';
                            }                    
                        }

                        html.File[i] = '\'';

                        embedCounter++;
                    }
                }
            }
        }

        private static string MakeBinaryString(string charString, int bitsOfOneCharacter)
        {
            StringBuilder binaryString = new StringBuilder();
           // int bitsInOneSymbol = 8;
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
