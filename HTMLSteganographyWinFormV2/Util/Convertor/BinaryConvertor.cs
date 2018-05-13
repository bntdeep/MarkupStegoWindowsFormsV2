using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTMLSteganographyWinFormV2.Util.Mapper;

namespace HTMLSteganographyWinFormV2.Util.Convertor
{
    class BinaryConvertor
    {
        public static List<int> convertMessageToBinaryListMapper(string secretMessage)
        {
            List<int> binarySecretMessage = new List<int>();

            try
            {
                foreach (char item in secretMessage)
                {
                    string binarySymbol = CharToBinaryMapper.mapper[item];
                    binarySecretMessage.AddRange(
                                binarySymbol.Select(
                                        c => Int32.Parse(c.ToString()))
                                .ToList());
                }

                List<int> endOfMessage = new List<int>();
                for (int i = 0; i < 6; i++)
                {
                    endOfMessage.Add(0);
                }
                binarySecretMessage.AddRange(endOfMessage);
            }
            catch (Exception e)
            {
                throw new Exception("BinaryConvertor.convertMessageToBinaryListMapper() Exception, MESSAGE: " + e.Message);
            }

            return binarySecretMessage;
        }

        public static string convertBinaryListToStringMapper(List<int> binaryList)
        {
            StringBuilder message = new StringBuilder();

            try
            {
                for (int i = 0; i < binaryList.Count; i += 6)
                {
                    List<int> list = binaryList.GetRange(i, 6);
                    string oneSymbol = String.Join("", list.ToArray());

                    if (oneSymbol == "000000") break;

                    message.Append(
                        CharToBinaryMapper.mapper.FirstOrDefault(
                                                    x => x.Value == oneSymbol).Key);
                }
            }
            catch (Exception e)
            {
                throw new Exception("BinaryConvertor.convertBinaryListToStringMapper() Exception, MESSAGE: " + e.Message);
            }

            return message.ToString();
        }
    }
}
