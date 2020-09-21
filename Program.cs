using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverModule
{
    class Program
    {
        static List<string> inputvalues = new List<string>();
        static void Main(string[] args)
        {
            string read;
            while ((read = Console.ReadLine()) != null)
            {
                
                inputvalues.Add(read);
            }
           

            string[] readwords = inputvalues.ToArray();

          

            Dictionary<String, int> WordCount = new Dictionary<String, int>();
            WordCount = WordAndCountOfWords.WordsAndWordFrequency(readwords);
            WritingToCSVFile.RedirectingToCsvFile(WordCount);
            //Console.ReadKey();

        }
    }
}
