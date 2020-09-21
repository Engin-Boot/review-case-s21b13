using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SenderFile
{
   public  class ReadingCSVFile
    {
        public static bool CheckCSVPathAndReadCSVFile(string path)
        {
            bool pathExists = CheckCSVPathExistOrNot(path);
            bool val = false;
            if (pathExists == true)
            {
                GetSequenceOfWords.SplittingCommentsToCommaSeperatedWords(path);
                val = true;
                return val;
            }
            else
            {
                return val;
            }
        }
        public static bool CheckCSVPathExistOrNot(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File Doesn't Exists!!");
                return false;
            }
        }
    }
}
