using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        static void ConsolePrint(int num)
        {
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            Action<int> printCns = ConsolePrint;
            printCns(5);
            Console.ReadLine();
        }

    }
}
