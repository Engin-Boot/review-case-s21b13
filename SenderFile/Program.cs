using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenderFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvpath = "C:/ReviewS21b13.csv";
            ReadingCSVFile.CheckCSVPathAndReadCSVFile(csvpath);

        }
    }
}
