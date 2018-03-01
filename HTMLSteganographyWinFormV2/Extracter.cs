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
                        while (html.File[++i] != '\'')
                        {
                            if (FileCrashedByZero(extractedMessage))
                            {
                                return RestoreMessage(extractedMessage.ToString(), bitsInOneCharacter);
                            }
                        }
                        continue;
                    }
                    if (html.File[i] == '\"')
                    {
                        extractedMessage.Append("1");
                        while (html.File[++i] != '\"')
                        {
                            if (FileCrashedByOne(extractedMessage))
                            {
                                return RestoreMessage(extractedMessage.ToString(), bitsInOneCharacter);
                            }
                        }
                        continue;
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return e.Message;
            }


            return RestoreMessage(extractedMessage.ToString(), bitsInOneCharacter);
        }

        private static string RestoreMessage(string extractedMessage, int bitsInOneCharacter)
        {
            StringBuilder restoredMessage = new StringBuilder();
            int lengthOfEndMarker = 3;

            for (int i = 0; i < extractedMessage.Length; i += bitsInOneCharacter)
            {
                try
                {
                    string messageSymbol = extractedMessage.Substring(i, bitsInOneCharacter);

                    char restoredSymbol = (char)Convert.ToInt32(messageSymbol, 2);

                    restoredMessage.Append(restoredSymbol);

                    if (i >= bitsInOneCharacter * lengthOfEndMarker) //ищем конец сообщения
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

        private static bool FileCrashedByOne(StringBuilder message)
        {
            bool crashingStatus = false;
            if (message.Length >= 16)
            {
                if (message[message.Length - 1] == '1'
            && message[message.Length - 2] == '1'
            && message[message.Length - 3] == '1'
            && message[message.Length - 4] == '1'
            && message[message.Length - 5] == '1'
            && message[message.Length - 6] == '1'
            && message[message.Length - 7] == '1'
            && message[message.Length - 8] == '1'
            && message[message.Length - 9] == '1'
            && message[message.Length - 10] == '1'
            && message[message.Length - 11] == '1'
            && message[message.Length - 12] == '1'
            && message[message.Length - 13] == '1'
            && message[message.Length - 14] == '1'
            && message[message.Length - 15] == '1'
            && message[message.Length - 16] == '1')
                {
                    crashingStatus = true;
                }
            }


            return crashingStatus;
        }

        private static bool FileCrashedByZero(StringBuilder message)
        {
            bool crashingStatus = false;
            if (message.Length >= 16)
            {
                if (message[message.Length - 1] == '0'
            && message[message.Length - 2] == '0'
            && message[message.Length - 3] == '0'
            && message[message.Length - 4] == '0'
            && message[message.Length - 5] == '0'
            && message[message.Length - 6] == '0'
            && message[message.Length - 7] == '0'
            && message[message.Length - 8] == '0'
            && message[message.Length - 9] == '0'
            && message[message.Length - 10] == '0'
            && message[message.Length - 11] == '0'
            && message[message.Length - 12] == '0'
            && message[message.Length - 13] == '0'
            && message[message.Length - 14] == '0'
            && message[message.Length - 15] == '0'
            && message[message.Length - 16] == '0')
                {
                    crashingStatus = true;
                }
            }

            return crashingStatus;
        }
    }
}
