using HTMLSteganographyWinFormV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLSteganographyWinFormV2
{
    class Extracter
    {
        public static string ExtractMessage(HTMLFile html, int bitsInOneCharacter)
        {
            StringBuilder extractedMessage = new StringBuilder();

            try
            {
                for (int i = 0; i < html.File.Length - 1; i++)
                {
                    if (html.File[i] == '\'')
                    {
                        extractedMessage.Append("0");
                        while (html.File[++i] != '\'') ;
                        continue;
                    }
                    if (html.File[i] == '\"')
                    {
                        extractedMessage.Append("1");
                        while (html.File[++i] != '\"') ;
                        continue;
                    }
                }
            }
            catch(IndexOutOfRangeException e)
            {
                return "";
            }
  

            return RestoreMessage(extractedMessage.ToString(), bitsInOneCharacter);
        }

        private static string RestoreMessage(string extractedMessage, int bitsInOneCharacter)
        {
            StringBuilder restoredMessage = new StringBuilder();
            int lengthOfEndMarker = 3;

            for (int i = 0; i < extractedMessage.Length; i+=bitsInOneCharacter)
            {
                try
                {
                    string messageSymbol = extractedMessage.Substring(i, bitsInOneCharacter);

                    char restoredSymbol = (char)Convert.ToInt32(messageSymbol, 2);

                    restoredMessage.Append(restoredSymbol);

                    if(i >= bitsInOneCharacter * lengthOfEndMarker) //ищем конец сообщения
                    {
                        if (IsEndOfMessage(restoredMessage))
                        {
                            return restoredMessage.ToString()
                                                .Remove(restoredMessage.Length - 3);
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return restoredMessage.ToString();
                }               
            }
            return restoredMessage.ToString();
        }

        private static bool IsEndOfMessage(StringBuilder restoringMEssage)
        {
            StringBuilder lastThreeSymbols = new StringBuilder();
            lastThreeSymbols.Append(restoringMEssage[restoringMEssage.Length - 3]);
            lastThreeSymbols.Append(restoringMEssage[restoringMEssage.Length - 2]);
            lastThreeSymbols.Append(restoringMEssage[restoringMEssage.Length - 1]);

            if (lastThreeSymbols.ToString() == "!@#")
            {
                return true;
            }

            return false;
        }
    }
}
