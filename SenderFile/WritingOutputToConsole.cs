using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenderFile
{
    class WritingOutputToConsole
    {
        public static void DisplaysCommaSeperatedWordsOnConsole(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadKey();
        }
    }
}
