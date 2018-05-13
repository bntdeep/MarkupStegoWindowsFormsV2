using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using HTMLSteganographyWinFormV2.Util.Mapper;


namespace HTMLSteganographyWinFormV2.Stego
{
    class WhiteSpaceEmbedder
    {
        private static void embedMessage(Application word, string _fileName, List<int> embeddingBits, int containerSize)
        {

            if (containerSize < embeddingBits.Count)
            {
                throw new Exception("embedMessage Exception, MESSAGE: container size: " + containerSize + " < message size: " + embeddingBits.Count);
            }

            Document doc = new Document();

            object missing = Type.Missing;

            try
            {
                object fileName = _fileName;
                doc = word.Documents.Open(ref fileName);
                doc.Activate();

                word.Selection.Start = 0;
                object space = " ";

                int spaceCounter = 0;

                for (int currentIteration = 0; currentIteration < embeddingBits.Count; currentIteration += 2)
                {
                    string charsPair = embeddingBits[currentIteration].ToString();
                    charsPair += embeddingBits[currentIteration + 1].ToString();

                    word.Selection.Find.Execute(ref space);


                    switch (CharPairToFontPositionMapper.mapper[charsPair])
                    {
                        case 1: word.Selection.Font.ColorIndex = WdColorIndex.wdRed; break;
                        case 0: word.Selection.Font.ColorIndex = WdColorIndex.wdPink; break;
                        case -1: word.Selection.Font.ColorIndex = WdColorIndex.wdBlue; break;
                        case 2: word.Selection.Font.ColorIndex = WdColorIndex.wdGreen; break;
                    }
                    word.Selection.Font.Position = CharPairToFontPositionMapper.mapper[charsPair];
                    spaceCounter++;
                }

                for (int i = 0; i < 1; i++)
                {
                    word.Selection.Find.Execute(ref space);
                    word.Selection.Font.ColorIndex = WdColorIndex.wdGreen;
                    word.Selection.Font.Position = 0;
                }

                Console.WriteLine("number of spaces that uses in embedding: " + spaceCounter);

                doc.Save();
                doc.Close(ref missing, ref missing, ref missing);
            }
            catch (Exception e)
            {
                doc.Close(ref missing, ref missing, ref missing);
                throw new Exception("extractMessage Exception, MESSAGE: " + e.Message);
            }
        }
    }
}
