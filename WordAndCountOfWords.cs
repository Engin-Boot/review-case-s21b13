using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverModule
{
    public class WordAndCountOfWords
    {
         public static Dictionary<string,int> WordsAndWordFrequency(string[] words)
        {
            Dictionary<String, int> _wordAndWordFrequency = new Dictionary<String, int>();
            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (_wordAndWordFrequency.ContainsKey(words[i]))
                    {
                        _wordAndWordFrequency[words[i]] = _wordAndWordFrequency[words[i]] + 1;
                    }
                    else
                    {
                        _wordAndWordFrequency.Add(words[i], 1);
                    }
                }
                Console.WriteLine("Word Frequency Count Successfull");
            }
            catch(Exception e)
            {
                Console.WriteLine("Word and Word Counting Error: " + e);
            }

            return _wordAndWordFrequency;
        }
        
    }
}
