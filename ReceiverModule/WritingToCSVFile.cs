using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReceiverModule
{
    public class WritingToCSVFile
    {
        public static bool RedirectingToCsvFile(Dictionary<String, int> _wordAndWordFrequency)
        {
            try
            {
                using (var writeToCsvFile = new StreamWriter(@"C:/WriteFile.csv"))
                {
                    foreach (KeyValuePair<string, int> wordisKeyWorkFrequencyisValue in _wordAndWordFrequency)
                    {
                        writeToCsvFile.WriteLine("{0} , {1}", wordisKeyWorkFrequencyisValue.Key, wordisKeyWorkFrequencyisValue.Value);
                    }
                }
                Console.WriteLine("Writting To File Successfull");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Writting To File: " + e);
                return false;
            }

        }
    }
}
