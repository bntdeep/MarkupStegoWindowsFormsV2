using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTMLSteganographyWinFormV2.Util.Mapper;

namespace HTMLSteganographyWinFormV2.Stego
{
    class WhiteSpaceExtracter
    {
        public static List<int> extractMessage(Application word, string _fileName)
        {
            Document doc = new Document();
            List<int> message = new List<int>();

            object missing = Type.Missing;

            try
            {
                object fileName = _fileName;
                doc = word.Documents.Open(ref fileName);

                doc.Activate();

                word.Selection.Start = 0;
                object space = " ";
                while (word.Selection.Find.Execute(ref space))
                {
                    string symbolsPair = CharPairToFontPositionMapper.mapper
                                                .FirstOrDefault(
                                                    x => x.Value == word.Selection.Font.Position)
                                                .Key;
                    message.Add(Int32.Parse(symbolsPair[0].ToString()));
                    message.Add(Int32.Parse(symbolsPair[1].ToString()));
                }
                doc.Close(ref missing, ref missing, ref missing);
            }
            catch (Exception e)
            {
                doc.Close(ref missing, ref missing, ref missing);
                throw new Exception("WhiteSpaceExtracter.extractMessage() Exception, MESSAGE: " + e.Message);
            }
            return message;
        }
    }
}
