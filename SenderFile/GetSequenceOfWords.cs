using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SenderFile
{
    class GetSequenceOfWords
    {
        public static void SplittingCommentsToCommaSeperatedWords(string path)
        {
            var ReadingCsvFile = new StreamReader(File.OpenRead(@"C:/ReviewS21b13.csv"));
            List<string> DateTimeColumn = new List<string>();
            List<string> CommentColumn = new List<string>();

            while (!ReadingCsvFile.EndOfStream)
            {
                var StoreDataEachRowOfCsvFile = ReadingCsvFile.ReadLine();
                var SplitColumn = StoreDataEachRowOfCsvFile.Split(',', '\n');
                DateTimeColumn.Add(SplitColumn[0]);
                CommentColumn.Add(SplitColumn[1]);
            }

            StringBuilder builder = new StringBuilder();

            foreach (string CommentData in CommentColumn)
            {
                builder.Append(CommentData);
            }

            string Comment = builder.ToString();
            string RemoveHeader = string.Join(" ", Comment.Split().Skip(1));
            string[] word = RemoveHeader.Split(' ');
            WritingOutputToConsole.DisplaysCommaSeperatedWordsOnConsole(word);
        }
    }
}
